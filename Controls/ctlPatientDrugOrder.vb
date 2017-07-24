Imports System.Windows.Forms

Public Class ctlPatientDrugOrder

    Private Enum EditMode
        [New]
        Save
        Update
    End Enum


    Public Property CurrentPatientOrder As PatientDrugOrderClass

    Public Sub Activate(ByVal Optional AcctNum As Integer = 0)


        cboDrugs.DataSource = DBDrugs.GetDrugInventory
        cboDrugs.DisplayMember = "ProcedureCode"
        cboDrugs.ValueMember = "DrugId"

        cboUnit.DataSource = DBDrugs.GetDrugUnits
        cboUnit.DisplayMember = "DrugUnit"
        cboUnit.ValueMember = "DrugUnitID"

        cboProviders.DataSource = DBProviders.GetProviders

        cboProviders.DisplayMember = "Display"
        cboProviders.DropDownColumns = "LastName,FirstName,Degree,Title"
        cboProviders.DropDownColumnsHeaders = "LastName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FirstName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Title"
        cboProviders.ValueMember = "ProviderID"
        cboProviders.DropDownWidth = 320
        cboProviders.DropDownHeight = 200
        dblQty.Value = 0
        CurrentPatientOrder = New PatientDrugOrderClass
        FillForm(AcctNum)

        Dim dtExp As Date = DateAdd("d", 180, dtOrderDate.Value)
        dtExpirationDate.Value = dtExp


    End Sub

    Private Sub FillForm(ByVal AcctNum As Integer)




        If DbPatientOrders.PatientHasActiveOrder(AcctNum) Then

            CurrentPatientOrder.GetActiveOrder(AcctNum)


        Else

            CurrentPatientOrder.GetDefaultOrder(AcctNum)


        End If


        With CurrentPatientOrder
            dtOrderDate.Value = .OrderDate
            dtExpirationDate.Value = DateAdd("d", 180, .OrderDate)
            lblPatientName.Text = .AccountDisplay
            cboProviders.SelectedValue = .ProviderID
            cboDrugs.SelectedValue = .DrugID
            dblQty.Value = .DrugAmount
            cboUnit.SelectedValue = .UnitID

        End With



    End Sub





    Private Sub ctlPatientDrugOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Activate()
    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs) Handles lblInfo.Click

        lblInfo.Tag = cboProviders.SelectedItem

        Dim ShowProviderID As Integer = DirectCast(cboProviders.SelectedItem, DataRowView).Row("ProviderID")

        MessageBox.Show(String.Format("Provider ID {0}", ShowProviderID))

    End Sub

    Private Sub dtOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtOrderDate.ValueChanged
        Dim dtExp As Date = DateAdd("d", 180, dtOrderDate.Value)

        dtExpirationDate.Value = dtExp
    End Sub

    Private Sub lblAddNote_Click(sender As Object, e As EventArgs) Handles lblAddNote.Click

    End Sub
End Class
