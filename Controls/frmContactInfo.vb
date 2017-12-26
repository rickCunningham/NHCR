Public Class frmContactInfo


    Public Property ProviderID As Integer

    Public Sub ContactActivate(ByVal _ProviderID As Integer)

        Me.ProviderID = _ProviderID

        Me.ShowDialog()


    End Sub

End Class