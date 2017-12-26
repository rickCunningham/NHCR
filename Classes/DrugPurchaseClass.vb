Public Class DrugPurchaseClass

End Class


Public Class DrugLineItemClass

    Public Property DrugID As Integer
    Public Property DrugName As String
    Public Property OrderQty As Integer
    Public Property UnitPrice As Decimal
    Public Property VialQtyID As Integer
    Public Property VialQty As String
    Public Property DrugPurchaseOrderID As Integer
    Public Property LineItemID As Integer

    Public Property VialOptions As DataTable




    Public Sub New()
        DrugID = 0
        DrugName = String.Empty
        OrderQty = 0
        UnitPrice = 0
        VialQtyID = 0
        VialQty = String.Empty
        DrugPurchaseOrderID = 0
        LineItemID = 0
    End Sub

    Public Sub FillControl(ByVal _DrugId As Integer)
        Dim dt As DataTable = DBDrugs.dbGetDrugVialOptions(_DrugId)

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            DrugID = _DrugId
            DrugName = CType(dt.Rows(0)("DrugName"), String)
            VialOptions = Import.GetVialOptions(dt)

        End If
    End Sub




    Public Function ExtendedPrice() As Decimal
        Return OrderQty * UnitPrice
    End Function





End Class




