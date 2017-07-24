Public Class PatientDrugOrderClass

    Public Property PatientOrderID As Integer
    Public Property PatientAcctNum As Integer
    Public Property ProviderID As Integer
    Public Property OrderDate As DateTime
    Public Property ExpirationDate As DateTime
    Public Property DrugID As Integer
    Public Property DrugAmount As Decimal
    Public Property UnitID As Integer
    Public Property isActive As Boolean
    Public Property NewOrder As Boolean
    Public Property UpdateOrder As Boolean
    Public Property FirstName As String
    Public Property LastName As String

    Public Property AccountDisplay As String



    Public Sub New()
        PatientOrderID = 0
        PatientAcctNum = 0
        ProviderID = 0
        OrderDate = Nothing
        ExpirationDate = Nothing
        DrugID = 0
        DrugAmount = 0
        UnitID = 0
        isActive = False
        NewOrder = False
        UpdateOrder = False
        FirstName = String.Empty
        LastName = String.Empty
        AccountDisplay = String.Empty

    End Sub


    Private Function OrderExists() As Boolean

        Return DbPatientOrders.PatientHasActiveOrder(PatientAcctNum)
    End Function

    Public Sub GetActiveOrder(ByVal _AcctNum As Integer)
        PatientAcctNum = _AcctNum
        Dim PatientOrderRow As DataRow = DbPatientOrders.GetActivePatientDrugOrder(PatientAcctNum).Rows(0)

        PatientOrderID = Cast.DbNullInt(PatientOrderRow("PatientOrderID"))
        PatientAcctNum = Cast.DbNullInt(PatientOrderRow("PatientAcctNum"))
        ProviderID = Cast.DbNullInt(PatientOrderRow("ProviderID"))

        If IsDBNull(PatientOrderRow("OrderDate")) Then
            OrderDate = Today()
        Else
            OrderDate = PatientOrderRow("OrderDate")
        End If

        ExpirationDate = DateAdd("d", 180, OrderDate)

        DrugID = Cast.DbNullInt(PatientOrderRow("DrugID"))
        DrugAmount = Cast.DBNullDec(PatientOrderRow("DrugAmount"))
        UnitID = Cast.DbNullInt(PatientOrderRow("UnitID"))
        isActive = Cast.DbNullBoolean(PatientOrderRow("isActive"))
        LastName = Cast.DbNullStr(PatientOrderRow("LastName"))
        FirstName = Cast.DbNullStr(PatientOrderRow("FirstName"))

        AccountDisplay = String.Format("{0}-{1}, {2}", PatientAcctNum, LastName, FirstName)

        NewOrder = False
        UpdateOrder = True

    End Sub

    Public Sub GetDefaultOrder(ByVal _AcctNum As Integer)
        PatientAcctNum = _AcctNum

        Dim dt As DataTable = DbPatientOrders.DBGetDefaultPatientOrder(PatientAcctNum)
        If Not IsNothing(dt) AndAlso dt.Rows.Count >= 1 Then
            Dim PatientOrderRow As DataRow = dt.Rows(0)
            PatientOrderID = 0
            PatientAcctNum = Cast.DbNullInt(PatientOrderRow("PatientAcctNum"))
            ProviderID = Cast.DbNullInt(PatientOrderRow("ProviderID"))

            If IsDBNull(PatientOrderRow("OrderDate")) Then
                OrderDate = Today()
            Else
                OrderDate = PatientOrderRow("OrderDate")
            End If

            ExpirationDate = DateAdd("d", 180, OrderDate)

            DrugID = Cast.DbNullInt(PatientOrderRow("DrugID"))
            DrugAmount = Cast.DBNullDec(PatientOrderRow("DrugAmount"))
            UnitID = Cast.DbNullInt(PatientOrderRow("UnitID"))
            isActive = Cast.DbNullBoolean(PatientOrderRow("isActive"))
            LastName = Cast.DbNullStr(PatientOrderRow("LastName"))
            FirstName = Cast.DbNullStr(PatientOrderRow("FirstName"))

            AccountDisplay = String.Format("{0}-{1}, {2}", PatientAcctNum, LastName, FirstName)

            NewOrder = True
            UpdateOrder = False
        Else
            OrderDate = Today

        End If
    End Sub
End Class
