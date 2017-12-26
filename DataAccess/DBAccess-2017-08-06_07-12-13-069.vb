Imports System.Data.SqlClient

Public Class DBAccess

    Public Shared Sub InsertAppointments(ByVal tblAppointments As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertAppointments"
                    cmd.Parameters.AddWithValue("@Appointments", tblAppointments)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try


    End Sub
    Public Shared Function GetLastAppointment() As LastAppointmentClass

        Dim Result As New LastAppointmentClass
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetLastAppointment"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    Dim dt As New DataTable
                    adapt.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Result.LastCreated = Cast.DbNullDate(dt.Rows(0)("lastCreated"))
                        Result.LastAppointmentID = Cast.DbNullInt(dt.Rows(0)("LastAppointmentID"))
                    End If
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return Result
    End Function
    Public Shared Function GetLastPatient() As LastPatientClass

        Dim Result As New LastPatientClass
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetLastPatient"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    Dim dt As New DataTable
                    adapt.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Result.AcctID = dt.Rows(0)("AcctNum")
                        Result.FirstName = dt.Rows(0)("FirstName")
                        Result.LastName = dt.Rows(0)("LastName")
                    End If
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return Result
    End Function
    Public Shared Sub InsertPatients(ByVal tblPatients As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertPatients"
                    cmd.Parameters.AddWithValue("@Patients", tblPatients)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try


    End Sub



    Public Shared Sub InsertPatientsInsurance(ByVal tblPatientsInsurance As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertPatientInsurance"
                    cmd.Parameters.AddWithValue("@PatientsInsurance", tblPatientsInsurance)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try


    End Sub



End Class

Public Class DBAppointments
    Public Shared Function GetAppointments() As DataTable

        Dim Result As New DataTable
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetMonthAppointments"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    Dim dt As New DataTable
                    adapt.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Result = dt
                    Else
                        dt = Nothing
                    End If
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return Result
    End Function
End Class

Public Class DBDrugs
    ''' <summary>
    ''' Pass in the imported drug table , get the id and cpt from db  use LINQ to return rows that do not match what is in db
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns>Table that has Rows that are new</returns> 
    ''' 
    ''' 
    ''' 
    ''' 
    ''' 

    Public Shared Function ConvertDrugs(dt As DataTable) As DataTable
        Dim x As Integer = 1
        Dim result As New DataTable
        Dim DrugImport As New DataTable
        DrugImport = Nothing
        result = Nothing
        Dim IDs = (From id In dt
                   Select New With {.ImportID = Cast.DbNullInt(id.Field(Of Double)("BenchMarkID"))}).ToList

        If IDs.Count > 0 Then

            result = IDs.ToDataTable

            result = GetNewDrugs(result)


            If Not IsNothing(result) Then
                Dim NewDrugs = (From drug In dt
                                Join ID In result
                                On Cast.DbNullInt(drug.Field(Of Double)("BenchMarkID")) Equals Cast.DbNullInt(ID.Field(Of Integer)("ImportID"))
                                Select New With {.BenchMarkID = Cast.DbNullInt(drug.Field(Of Double)("BenchMarkID")),
                                             .CPTCode = drug.Field(Of String)("CPTCode"),
                                             .ProcedureCode = drug.Field(Of String)("ProcedureCode"),
                                             .DrugQty = Cast.DBNullDec(drug.Field(Of Double)("DrugQty")),
                                             .Unit = drug.Field(Of String)("Unit"),
                                             .Description = drug.Field(Of String)("Description"),
                                             .ProcedureDescription = drug.Field(Of String)("ProcedureDescription"),
                                             .StandardFee = Cast.DBNullDec(drug.Field(Of Double)("StandardFee")),
                                             .NDCCode = drug.Field(Of String)("NDCCode"),
                                            .DefaultUnit = Cast.DbNullInt(drug.Field(Of String)("DefaultUnit")),
                                             .Inventory = False
                                             }).ToList


                If NewDrugs.Count > 0 Then

                    DrugImport = NewDrugs.ToDataTable
                    Dim dv As New DataView(DrugImport)
                    dv.Sort = "BenchMarkID"

                    DrugImport = dv.ToTable
                    If DrugImport.Rows.Count > 0 Then InsertDrugs(DrugImport)

                End If




            End If
        End If

        Return DrugImport
    End Function

#Region "Insert Procedures"

    Public Shared Sub InsertDrugs(ByVal tblDrugs As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertDrugs"
                    cmd.Parameters.AddWithValue("@Drugs", tblDrugs)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try
    End Sub



    Public Shared Sub InsertDrugAttributes(ByVal dBInputTbl As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertDrugAttributes"
                    cmd.Parameters.AddWithValue("@DrugAttributes", dBInputTbl)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try


    End Sub

    Public Shared Sub InsertDrugVialLinks(ByVal VialLinksTbl As DataTable)
        'sp_InsertDrugVialLinks
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_InsertDrugVialLinks"
                    cmd.Parameters.AddWithValue("@Vials", VialLinksTbl)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try
    End Sub

#End Region

#Region "Update Procedures"
    Public Shared Sub UpdateMasterDrugCatalog(ByVal UpdateTable As DataTable)
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_UpdateMasterDrugCatalog"
                    cmd.Parameters.AddWithValue("@UpdateTable", UpdateTable)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try
    End Sub

    Public Shared Sub UpdateDrugAttributesTbl(ByVal AttrUpdateTbl As DataTable)
        '
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_UpdateDrugAttributesTable"
                    cmd.Parameters.AddWithValue("@UpdateTable", AttrUpdateTbl)
                    con.Open()
                    Dim result As Integer = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
        End Try
    End Sub

#End Region

#Region "DB Drugs Get Procedures"
    Public Shared Function GetNewDrugs(ByVal dt As DataTable) As DataTable
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_Drugs2Import"
                    cmd.Parameters.AddWithValue("@ImportID", dt)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function


    Public Shared Function GetDrugs(ByVal Optional DrugID As Integer = 0, ByVal Optional BenchmarkID As Integer = 0)
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetMasterDrugCatalog"
                    ' cmd.Parameters.AddWithValue("@ImportID", dt)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "MasterDrugCatalog"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugMfgs(ByVal Optional MfgId As Integer = 0)
        '
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugMfgs"
                    cmd.Parameters.AddWithValue("@MfgID", MfgId)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "Mfg"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    '
    Public Shared Function GetDrugSuppliers(ByVal Optional SupplierId As Integer = 0)
        '
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugSuppliers"
                    cmd.Parameters.AddWithValue("@SupplierID", SupplierId)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "Suppliers"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    '
    Public Shared Function GetDrugOrderCompanies(ByVal Optional OrderCoID As Integer = 0)
        '
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugOrderCompanies"
                    cmd.Parameters.AddWithValue("@OrderCoID", OrderCoID)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "OrderCompanies"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function
    '

    Public Shared Function GetDrugCategories(ByVal Optional CategoryID As Integer = 0)
        '
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugCategories"
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "Categories"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugAttributes(ByVal DrugID As Integer) As DataTable
        'sp_GetDrugAttributes
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugAttributes"
                    cmd.Parameters.AddWithValue("@DrugID", DrugID)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "DrugAttributes"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugStorage(ByVal Optional StorageID As Integer = 0) As Object
        'sp_GetDrugStorage
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugStorage"
                    cmd.Parameters.AddWithValue("@StorageID", StorageID)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "DrugStorage"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugVials(ByVal DrugID As Integer) As DataTable
        'sp_GetDrugStorage
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugVials"
                    cmd.Parameters.AddWithValue("@DrugID", DrugID)
                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "DrugVials"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetAllVials() As DataTable
        'sp_GetAllVials
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetAllVials"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "AllVials"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugUnits() As DataTable
        '
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugUnits"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "DrugUnits"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function

    Public Shared Function GetDrugInventory() As DataTable
        'sp_GetDrugInventory
        Dim result As New DataTable

        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetDrugInventory"

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()

                    adapt.Fill(result)
                    result.TableName = "DrugInventory"

                    If result.Rows.Count <= 0 Then

                        result = Nothing
                    End If

                End Using
            End Using
        Catch ex As SqlException
        End Try


        Return result
    End Function





#End Region



End Class


Public Class DBPatients
    Public Shared Function GetPatients(ByVal Optional ChartType As String = "") As DataTable

        Dim dt As New DataTable
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetAllPatients"
                    cmd.Parameters.AddWithValue("@ChartType", ChartType)

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()


                    adapt.Fill(dt)
                    If dt.Rows.Count < 0 Then dt = Nothing
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return dt
    End Function
End Class


Public Class DBProviders
    Public Shared Function GetProviders(ByVal Optional ProviderID As Integer = 0) As DataTable
        '
        Dim dt As New DataTable
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetProviders"
                    cmd.Parameters.AddWithValue("@ProviderID", ProviderID)

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()


                    adapt.Fill(dt)
                    If dt.Rows.Count < 0 Then dt = Nothing
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return dt
    End Function
End Class


Public Class DbPatientOrders
    Public Shared Function PatientHasActiveOrder(ByVal PatientAcctNum As Integer) As Boolean
        Dim result As Boolean = False


        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select dbo.fn_PatientHasActiveOrder(@PatientAcctNum)"
                    cmd.Parameters.AddWithValue("@PatientAcctNum", PatientAcctNum)


                    con.Open()
                    result = cmd.ExecuteScalar


                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return result
    End Function

    Public Shared Function GetActivePatientDrugOrder(ByVal AcctNum As Integer) As DataTable
        Dim result As New DataTable
        'sp_GetActivePatientDrugOrder
        '
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetActivePatientDrugOrder"
                    cmd.Parameters.AddWithValue("@PatientAcctNum", AcctNum)

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()


                    adapt.Fill(result)
                    If result.Rows.Count <= 0 Then result = Nothing
                End Using
            End Using
        Catch ex As SqlException
        End Try

        Return result
    End Function

    Public Shared Function DBGetDefaultPatientOrder(ByVal PatientAcctNum As Integer) As Object
        'sp_GetPatientDefaultOrder
        Dim result As New DataTable
        Try
            Dim con As SqlConnection = GetConnection(Access.Develop)

            Using con
                Using cmd As New SqlCommand
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_GetPatientDefaultOrder"
                    cmd.Parameters.AddWithValue("@AcctNum", PatientAcctNum)

                    Dim adapt As New SqlDataAdapter(cmd)
                    con.Open()


                    adapt.Fill(Result)
                    If Result.Rows.Count <= 0 Then Result = Nothing
                End Using
            End Using
        Catch ex As SqlException
        End Try
        Return Result

    End Function
End Class












