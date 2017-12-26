Public Class ProviderInfoArgs
    Inherits EventArgs

    Public Property ProviderID As Integer
    Public Property Provider As ProviderClass

    Public Sub New()
        ProviderID = 0
        Provider = New ProviderClass(ProviderID)
    End Sub

    Public Sub New(_ProviderID As Integer)
        Provider = New ProviderClass(ProviderID)
    End Sub

End Class
