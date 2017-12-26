
Public Class ctlDrugLineItem

    Public Property DrugLineItem As DrugLineItemClass
    Public Event ExtendedPriceChanged(ByVal sender As Object, e As ExtPriceEventArgs)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DrugLineItem = New DrugLineItemClass
    End Sub

    Public Sub Fill(ByVal DrugID As Integer)

        ' This call is required by the designer.

        DrugLineItem = New DrugLineItemClass
        ' Add any initialization after the InitializeComponent() call.
        DrugLineItem.FillControl(DrugID)

        cboVialQty.DataSource = DrugLineItem.VialOptions
        cboVialQty.DisplayMember = "VialQty"
        cboVialQty.ValueMember = "VialQtyID"
        lblDrugName.Text = DrugLineItem.DrugName
        intOrderQty.Value = 0
        dblUnitPrice.Value = 0



    End Sub


    Private Sub ComputeExtended()
        Dim e As New ExtPriceEventArgs
        If dblUnitPrice.Value > 0 AndAlso intOrderQty.Value > 0 Then

            'Dim item As DataRow = DirectCast(cboQty.SelectedItem, DataRowView).Row

            With DrugLineItem

                .DrugName = lblDrugName.Text
                .OrderQty = intOrderQty.Value
                .UnitPrice = dblUnitPrice.Value
                .VialQtyID = cboVialQty.SelectedValue
                .VialQty = cboVialQty.Text

                lblExtendedPrice.Text = .ExtendedPrice.ToString("c")
            End With
            e.DrugLineItem = DrugLineItem
                RaiseEvent ExtendedPriceChanged(Me, e)
        End If
    End Sub

    Private Sub dblUnitPrice_ValueChanged(sender As Object, e As EventArgs) Handles dblUnitPrice.ValueChanged
        If intOrderQty.Value > 0 Then ComputeExtended()
    End Sub

    Private Sub intOrderQty_ValueChanged(sender As Object, e As EventArgs) Handles intOrderQty.ValueChanged
        If dblUnitPrice.Value > 0 Then ComputeExtended()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Dispose()
    End Sub
End Class



