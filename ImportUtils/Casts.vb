Public Class Cast





#Region "Conversions"

    ' <DebuggerStepThrough()>
    Public Shared Function DbNullImage(ByVal d As Object) As Byte()
        Dim result As Byte() = Nothing
        If Not IsDBNull(d) Then
            result = d
        End If
        Return result
    End Function

    ' <DebuggerStepThrough()>
    Public Shared Function DbNullStr2Int(ByVal d As Object) As Integer
        Dim result As Integer = Nothing
        If Not IsDBNull(d) Then
            If IsNumeric(d) Then result = CInt(d) Else result = 0
        End If
        Return result
    End Function
    '<DebuggerStepThrough()>
    Public Shared Function DBNullDec(ByVal d As Object) As Decimal
        Dim result As Decimal = 0
        If Not IsDBNull(d) Then result = CDec(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DBNullDbl(ByVal d As Object) As Double
        Dim result As Decimal = 0
        If Not IsDBNull(d) Then result = CDec(d)
        Return result
    End Function
    '<DebuggerStepThrough()>
    Public Shared Function DbNullInt(ByVal d As Object) As Integer
        Dim result As Integer = 0
        If Not IsDBNull(d) Then result = CInt(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullStr(ByVal d As Object) As String
        Dim result As String = String.Empty
        If Not IsDBNull(d) AndAlso Not IsNothing(d) Then result = CStr(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullDec(ByVal d As Object, field As String) As Decimal
        Dim result As Decimal = 0
        If Not IsDBNull(d) Then result = CDec(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DBNullDbl(ByVal d As Object, field As String) As Double
        Dim result As Decimal = 0
        If Not IsDBNull(d) Then result = CDec(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullInt(ByVal d As Object, field As String) As Integer
        Dim result As Integer = 0
        If Not IsDBNull(d) Then result = CInt(d)
        Return result
    End Function
    '<DebuggerStepThrough()>
    Public Shared Function DbNullStr(ByVal d As Object, field As String) As String
        Dim result As String = String.Empty
        If Not IsDBNull(d) AndAlso Not IsNothing(d) Then result = CStr(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullDate(ByVal d As Object) As Date
        Dim result As Date = DateAdd(DateInterval.Year, -100, Now())
        If Not IsDBNull(d) AndAlso Not IsNothing(d) Then result = CDate(d)
        Return result
    End Function

    ' <DebuggerStepThrough()>
    Public Shared Function DbNothingDate(ByVal d As Object) As Date


        If TypeOf (d) Is System.String Then

            Dim x As Integer = 1
            d = CDate(d)
        End If


        Dim result As Date = Nothing
        If Not IsDBNull(d) AndAlso Not IsNothing(d) Then result = CDate(d)
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function ConvertToDBNullDate(ByVal o As Date) As Object



        If o = #1/1/0001 12:00:00 AM# OrElse IsNothing(o) Then
            Return DBNull.Value
        Else
            Return o
        End If






    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullColor(o As Object) As String
        Dim result As String = Cast.DbNullStr(o)

        If result = String.Empty Then result = "Transparent"
        Return result
    End Function
    ' <DebuggerStepThrough()>
    Public Shared Function DbNullBoolean(o As Object) As Boolean
        Dim result As Boolean = False
        If Not IsDBNull(o) AndAlso Not IsNothing(o) Then result = CBool(o)
        Return result
    End Function


#End Region




End Class