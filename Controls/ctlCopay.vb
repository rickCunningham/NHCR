Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class ctlCopay

    Dim Loading As Boolean
    Private SelectedDrugID As Integer
    Dim Attributes As DrugAttributeClass


    Public Sub Activate(ByVal Optional DrugID As Integer = 0)

        cboMfg.DataSource = DBDrugs.GetDrugMfgs
        cboMfg.DisplayMember = "Mfg"
        cboMfg.ValueMember = "MfgID"

        cboOrderCompany.DataSource = DBDrugs.GetDrugOrderCompanies
        cboOrderCompany.DisplayMember = "OrderCompany"
        cboOrderCompany.ValueMember = "OrderCoID"

        cboSupplier.DataSource = DBDrugs.GetDrugSuppliers
        cboSupplier.DisplayMember = "Supplier"
        cboSupplier.ValueMember = "SupplierID"

        cboCategory.DataSource = DBDrugs.GetDrugCategories
        cboCategory.DisplayMember = "Category"
        cboCategory.ValueMember = "CategoryID"

        cboStorage.DataSource = DBDrugs.GetDrugStorage
        cboStorage.DisplayMember = "Storage"
        cboStorage.ValueMember = "StorageID"


        SelectedDrugID = DrugID

        Dim DrugAttributes As DataTable = DBDrugs.GetDrugAttributes(SelectedDrugID)
        Attributes = New DrugAttributeClass(DrugAttributes)

        FillForm(DrugAttributes)

    End Sub


    Private Sub ClearForm()
        chkCopay.Checked = False
        chkBenefits.Checked = False
        txtPayer.Clear()
        txtPaymentCode.Clear()
        txtAcctCode.Clear()
        txtAthemCode.Clear()
        dblCopayMax.Value = 0
        cboMfg.SelectedIndex = 0
        cboSupplier.SelectedIndex = 0
        cboOrderCompany.SelectedIndex = 0
        cboCategory.SelectedIndex = 0
        cboStorage.SelectedIndex = 0

        tknVial.Tokens.Clear()
        vialList.Items.Clear()




    End Sub

    Private Sub FillForm(drugAttributes As DataTable)
        ClearForm()

        With Attributes
            lblName.Text = "<div align=""center""><b>Procedure Code: </b>" & .ProcedureCode & "</div>"
            chkCopay.Checked = .CopayAssist
            chkBenefits.Checked = .BenefitVerification
            txtPayer.Text = .CopayPayer.ToUpper
            txtPaymentCode.Text = .CopayPaymentCode.ToUpper
            dblCopayMax.Value = .CopayMaximum
            cboMfg.SelectedValue = .MfgID
            cboSupplier.SelectedValue = .SupplierID
            cboOrderCompany.SelectedValue = .OrderCoID
            cboCategory.SelectedValue = .CategoryID
            cboStorage.SelectedValue = .StorageID
            txtAcctCode.Text = .AcctgCode
            txtAthemCode.Text = .AnthemAdminCode
        End With

        LoadVials()

    End Sub

    Private Sub LoadVials()

        Dim DrugVials As DataTable = Attributes.DrugVials
        Dim AssignedVials As List(Of Integer) = Nothing
        If Not IsNothing(DrugVials) AndAlso DrugVials.Rows.Count > 0 Then

            For Each row As DataRow In DrugVials.Rows
                Dim Item As New ListBoxItem
                AddHandler Item.MouseDown, AddressOf ListBoxItem_MouseDown
                Item.Text = row("Qty") & " " & row("Unit")
                Item.Tag = row
                vialList.Items.Add(Item)
            Next
            Dim Vials = (From Vial In DrugVials
                         Select New With {.VialQtyId = Vial.Field(Of Integer)("VialQtyID")}).ToList

            If Vials.Count > 0 Then
                AssignedVials = New List(Of Integer)
                For Each Vial In Vials
                    AssignedVials.Add(Vial.VialQtyId)
                Next
            End If

        End If
        GetAllVials(AssignedVials)
    End Sub

    Private Sub ClearSelectedTokens()

        Dim count As Integer = tknVial.SelectedTokens.Count

        For I = 0 To count - 1
            tknVial.SelectedTokens.RemoveAt(0)
        Next
    End Sub

    Private Function GetVialToken(ByVal row As DataRow) As EditToken
        Dim VialDesc As String = row("Qty") & " " & row("Unit")
        Dim VialQtyID As Integer = row("VialQtyID")

        Dim token As New EditToken(VialQtyID, VialDesc)
        token.Tag = row
        Return token
    End Function

    Private Sub GetAllVials(ByVal Optional Assigned As List(Of Integer) = Nothing)

        Dim AllVials As DataTable = DBDrugs.GetAllVials()
        Dim tbl As New DataTable

        tbl = AllVials.Clone
        ClearSelectedTokens()
        If Not IsNothing(Assigned) Then

            For Each row In AllVials.Rows
                If Not Assigned.Contains(row("VialQtyID")) Then
                    tbl.ImportRow(row)
                End If
            Next
        Else
            tbl = AllVials
        End If

        For Each row In tbl.Rows
            tknVial.Tokens.Add(GetVialToken(row))
        Next

    End Sub


    Private Function NewVials() As Boolean

        Return tknVial.SelectedTokens.Count > 0
    End Function

    Private Sub GetFormData()

        If IsNothing(Attributes) Then
            Attributes = New DrugAttributeClass(DBDrugs.GetDrugAttributes(SelectedDrugID))
        End If

        With Attributes
            .CopayAssist = chkCopay.Checked
            .BenefitVerification = chkBenefits.Checked
            .CopayPayer = txtPayer.Text.ToUpper
            .CopayPaymentCode = txtPaymentCode.Text.ToUpper
            .CopayMaximum = dblCopayMax.Value
            .MfgID = cboMfg.SelectedValue
            .SupplierID = cboSupplier.SelectedValue
            .OrderCoID = cboOrderCompany.SelectedValue
            .CategoryID = cboCategory.SelectedValue
            .StorageID = cboStorage.SelectedValue
            .AcctgCode = txtAcctCode.Text
            .AnthemAdminCode = txtAthemCode.Text
        End With



        Dim VialTbl As New DataTable
        If NewVials() Then

            Dim DrugIDCol As New DataColumn("DrugID", GetType(Integer))
            Dim VialQtyIDCol As New DataColumn("VialQtyID", GetType(Integer))
            Dim BenchMarkIDCol As New DataColumn("BenchMarkID", GetType(Integer))
            VialTbl.Columns.AddRange({DrugIDCol, VialQtyIDCol, BenchMarkIDCol})

            For Each tkn As EditToken In tknVial.SelectedTokens
                Dim Vialrow As DataRow = VialTbl.NewRow
                Vialrow("DrugID") = Attributes.DrugID
                Vialrow("BenchmarkID") = Attributes.BenchMarkID
                Vialrow("VialQtyID") = tkn.Value
                VialTbl.Rows.Add(Vialrow)
            Next
        Else VialTbl = Nothing

        End If


        Attributes.Save(VialTbl)



        Dim DrugAttributes As DataTable = DBDrugs.GetDrugAttributes(SelectedDrugID)
        Attributes = New DrugAttributeClass(DrugAttributes)

        FillForm(DrugAttributes)


    End Sub





    Private Sub ctlCopay_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loading = True

    End Sub

    Private Sub tknVial_ValidateToken(sender As Object, ea As ValidateTokenEventArgs) Handles tknVial.ValidateToken
        ea.IsValid = Not ea.IsNewToken
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        GetFormData()
    End Sub

    Private Sub ListBoxItem_MouseDown(sender As Object, e As MouseEventArgs)
        Dim x As Integer = 0

        Dim pt As New Drawing.Point(e.Location)

        Dim row As DataRow = DirectCast(sender, ListBoxItem).Tag


        vialList.Items.Remove(DirectCast(sender, ListBoxItem))

    End Sub
End Class
