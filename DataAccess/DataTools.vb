Imports System.ComponentModel
Imports System.Data.SqlClient

Module DataTools


    Public Enum Access
        Develop
        Production
    End Enum

    Public Function GetConnection(ByVal DB As Integer) As SqlConnection
        Dim result As SqlConnection = Nothing
        Select Case DB
            Case Access.Develop
                result = New SqlConnection(My.Settings.Develop)
            Case Access.Production
                result = New SqlConnection(My.Settings.Production)
        End Select
        Return result
    End Function


    <System.Runtime.CompilerServices.Extension>
    Public Function ToDataTable(Of T)(data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim dt As New DataTable()
        For i As Integer = 0 To properties.Count - 1
            Dim [property] As PropertyDescriptor = properties(i)
            dt.Columns.Add([property].Name, If(Nullable.GetUnderlyingType([property].PropertyType), [property].PropertyType))
        Next
        Dim Indexs As Object() = New Object(properties.Count - 1) {}
        For Each item As T In data
            For i As Integer = 0 To Indexs.Length - 1
                Indexs(i) = properties(i).GetValue(item)
            Next
            dt.Rows.Add(Indexs)
        Next
        Return dt
    End Function



End Module
