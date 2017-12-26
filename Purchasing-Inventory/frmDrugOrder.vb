Public Class frmDrugOrder
    Private Sub frmDrugOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboSupplier.DataSource = DBDrugs.GetDrugSuppliers
        cboSupplier.DisplayMember = "Supplier"
        cboSupplier.ValueMember = "SupplierID"

        cboDrugs.DataSource = DBDrugs.dbGet_With_DrugVialOptions

        cboDrugs.DisplayMember = "DrugName"
        cboDrugs.ValueMember = "DrugID"


    End Sub

    Private Sub LabelX2_Click(sender As Object, e As EventArgs) Handles LabelX2.Click

        Dim ctlLineItem As New ctlDrugLineItem
        AddHandler ctlLineItem.ExtendedPriceChanged, AddressOf ComputeRunningTotal

        ctlLineItem.Fill(CInt(cboDrugs.SelectedValue))
        ctlLineItem.Name = "LineItem" & CustomFlowLayoutPanel1.Controls.Count.ToString
        CustomFlowLayoutPanel1.Controls.Add(ctlLineItem)
    End Sub


    Public Sub ComputeRunningTotal(sender As Object, e As ExtPriceEventArgs)
        'TODO Change to get a datarow

        Dim runningtotal As Decimal = 0


        For Each control In CustomFlowLayoutPanel1.Controls
            If TypeOf (control) Is ctlDrugLineItem Then
                Dim temp As DrugLineItemClass = CType(control.DrugLineItem, DrugLineItemClass)



            End If


        Next








        Dim x As Decimal = e.DrugLineItem.ExtendedPrice
    End Sub
End Class