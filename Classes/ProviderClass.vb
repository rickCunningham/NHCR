Public Class ProviderClass
    Public Property ProviderID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property NPI As String
    Public Property OfficePhone As String
    Public Property Degree As String
    Public Property Code As String
    Public Property Address As String
    Public Property City As String
    Public Property State As String
    Public Property Zip As String
    Public Property ProviderTypeID As Integer
    Public Property ProviderType As String
    Public Property LicenseNum As String
    Public Property TaxID As String
    Public Property isActive As Boolean

    Public Sub New()
        ProviderID = 0
        FirstName = String.Empty
        LastName = String.Empty
        NPI = String.Empty
        OfficePhone = String.Empty
        Degree = String.Empty
        Code = String.Empty
        Address = String.Empty
        City = String.Empty
        State = String.Empty
        Zip = String.Empty
        ProviderTypeID = 0
        ProviderType = String.Empty
        LicenseNum = String.Empty
        TaxID = String.Empty
        isActive = True
    End Sub


    Public Sub New(ByVal _ProviderID As Integer)
        Dim provider As New ProviderClass
        provider = GetProviderById(_ProviderID)
    End Sub


    Public Function GetProviderById(ByVal ProviderId As Integer) As ProviderClass

        Dim result As New ProviderClass

        Dim ProviderRow As DataRow = DBProviders.GetActiveProvider_ByID(ProviderId).Rows(0)

        result = DTRowToClass(ProviderRow)

        Return result
    End Function

    Private Function DTRowToClass(ByVal dr As DataRow) As ProviderClass

        Dim result As New ProviderClass

        With result
            .ProviderID = dr("ProviderID")

        End With

        Return result
    End Function


End Class
