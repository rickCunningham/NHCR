Public Class EventArgsClasses

End Class
Public Class ExtPriceEventArgs
    Inherits EventArgs
    Public Property DrugLineItem As DrugLineItemClass

    Public Sub New()
        DrugLineItem = New DrugLineItemClass
    End Sub
End Class
