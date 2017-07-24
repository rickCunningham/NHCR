Imports System.Data.OleDb

Public Class Import

    Public Shared Function GetExcelSheet(ByVal fileName As String, Optional ByVal FileType As Integer = 0) As DataTable
        Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
          fileName & ";Extended Properties=""Excel 12.0;IMEX=1; Xml;HDR=YES"";"
        Dim conn As New OleDbConnection(strconn)

        conn.Open()

        Dim dtSheets As DataTable =
              conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim listSheet As New List(Of String)
        Dim SheetName As String = dtSheets.Rows(0)("TABLE_NAME").ToString()

        Dim cmd As OleDbCommand
        Dim query As String = "SELECT * From [" & SheetName & "]"
        cmd = New OleDbCommand(query, conn)

        Dim oda As OleDbDataAdapter
        oda = New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        oda.Fill(dt)


        '//show sheetname in textbox where multiline Is true
        'For Each sheet As String In listSheet
        '        TextBox1.Text = TextBox1.Text & sheet & vbNewLine
        '    Next

        conn.Close()



        If Not IsNothing(dt) Then

            End If
            'sgExcel.PrimaryGrid.DataSource = dt
            'ProcessData(dt)
            Return dt
    End Function



    Public Shared Function ConvertAppointment(ByVal dt As DataTable) As DataTable

        Dim result As New DataTable
        Dim tbl = (From appt In dt
                   Select New With
                       {.Created = Cast.DbNullDate(appt.Field(Of DateTime?)("Created")),
                       .AppointmentTime = Cast.DbNullDate(appt.Field(Of DateTime?)("Appt Time")),
                       .EndTime = Cast.DbNullDate(appt.Field(Of DateTime?)("End Time")),
                       .Duration = Cast.DbNullInt(appt.Field(Of Double)("Duration")),
                       .Description = appt.Field(Of String)("Desc"),
                       .EmployeeID = Cast.DbNullInt(appt.Field(Of Double)("OP ID")),
                       .Employee = appt.Field(Of String)("Employee"),
                       .SlotTypeID = Cast.DbNullInt(appt.Field(Of Double)("SlotTypeID")),
                       .ScheduleCode = Cast.DbNullInt(appt.Field(Of Double)("ScheduleCode")),
                       .ProviderID = Cast.DbNullInt(appt.Field(Of Double)("ProvID")),
                       .LocationID = Cast.DbNullInt(appt.Field(Of Double)("LocID")),
                       .PatientID = Cast.DbNullInt(appt.Field(Of Double)("PatientID")),
                       .StatusCode = Cast.DbNullInt(appt.Field(Of Double)("Status")),
                       .AppointmentTypeID = Cast.DbNullInt(appt.Field(Of Double)("ApptTypeID")),
                       .AppointmentID = Cast.DbNullInt(appt.Field(Of Double)("APPID")),
                       .PriorAppointmentID = Cast.DbNullInt(appt.Field(Of Double)("PriorAptID")),
                       .Updated = Cast.DbNullDate(appt.Field(Of DateTime?)("Updated"))}).ToList

        If tbl.Count > 0 Then
            result = tbl.ToDataTable
        Else
            result = Nothing
        End If


        Return result
    End Function
    Public Shared Function ConvertPatient(ByVal dt As DataTable) As DataTable

        Dim result As New DataTable
        Dim tbl = (From patient In dt
                   Select New With
                       {.FirstName = Cast.DbNullStr(patient.Field(Of String)("Fname")),
                      .LastName = Cast.DbNullStr(patient.Field(Of String)("Lname")),
                       .AcctNum = Cast.DbNullInt(patient.Field(Of Double?)("Acct#")),
                       .Address = Cast.DbNullStr(patient.Field(Of String)("Address")),
                       .City = Cast.DbNullStr(patient.Field(Of String)("City")),
                       .State = Cast.DbNullStr(patient.Field(Of String)("State")),
                       .Zip = Cast.DbNullStr(Convert.ToString(patient.Field(Of Double?)("Zip"))),
                       .Gender = Cast.DbNullInt(patient.Field(Of Double?)("Gender")),
                       .DOB = Cast.DbNullDate(patient.Field(Of Date)("DOB")),
                       .Email = Cast.DbNullStr(patient.Field(Of String)("Email")),
                       .Mobile = Cast.DbNullStr(Convert.ToString(patient.Field(Of Double?)("Mobile"))),
                       .Phone = Cast.DbNullStr(Convert.ToString(patient.Field(Of Double?)("Phone"))),
                       .DefaultProviderID = Cast.DbNullInt(patient.Field(Of Double?)("defProvID")),
                       .PatientID = Cast.DbNullInt(patient.Field(Of Double?)("PatientID")),
                       .ReferralID = Cast.DbNullInt(patient.Field(Of Double?)("RefID")),
                       .ChartType = Cast.DbNullStr(patient.Field(Of String)("ChartType"), "ChartType"),
                       .isActive = True}).ToList

        If tbl.Count > 0 Then
            result = tbl.ToDataTable
        Else
            result = Nothing
        End If


        Return result
    End Function


    Public Shared Function ConvertPatientInsurance(ByVal dt As DataTable) As DataTable

        Dim result As New DataTable
        Dim tbl = (From patient In dt
                   Select New With
                       {.AcctNum = Cast.DbNullInt(patient.Field(Of Double)("AcctNum")),
                      .InsuranceID = Cast.DbNullInt(patient.Field(Of Double)("InsuranceID")),
                       .GroupNumber = Cast.DbNullStr(patient.Field(Of String)("GroupNumber")),
                       .Copay = Cast.DBNullDec(patient.Field(Of Decimal)("Copay")),
                       .EffectiveDate = Cast.DbNothingDate(patient.Field(Of DateTime?)("EffectiveDate")),
                       .TerminationDate = Cast.DbNothingDate(patient.Field(Of String)("TerminationDate")),
                       .InsuranceType = Cast.DbNullInt(patient.Field(Of Double)("InsuranceType"))}).ToList

        If tbl.Count > 0 Then
            result = tbl.ToDataTable
        Else
            result = Nothing
        End If


        Return result
    End Function

End Class
