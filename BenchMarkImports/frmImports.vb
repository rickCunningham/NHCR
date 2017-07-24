Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid


Public Class frmImports

    Dim SelectedTable As TableType
    Enum TableType
        Appointments
        Clients
        Drugs
        Providers
        PatientInsurance

    End Enum
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel Files:|*.xlsx;.xls"
        Dim filepath As String = String.Empty
        Dim dt As New DataTable
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            filepath = OpenFileDialog1.FileName
            dt = Import.GetExcelSheet(filepath)
            If Not IsNothing(dt) Then

                Select Case SelectedTable
                    Case TableType.Appointments
                        dt = Import.ConvertAppointment(dt)
                        GetAppointments(dt)
                    Case TableType.Clients
                        dt = Import.ConvertPatient(dt)
                        GetPatients(dt)
                    Case TableType.Drugs
                        dt = DBDrugs.ConvertDrugs(dt)
                        If Not IsNothing(dt) Then
                            GetDrugs(dt)
                        Else
                            MessageBox.Show("No New Drugs to Import")
                        End If
                        Dim frm As New frmDrugs
                        frm.Show()
                    Case TableType.PatientInsurance
                        dt = Import.ConvertPatientInsurance(dt)
                        GetPatientInsurance(dt)
                End Select
            End If
        End If
    End Sub



    Private Sub sgAppt_DataBindingComplete(sender As Object, e As GridDataBindingCompleteEventArgs) Handles Grid.DataBindingComplete
        Dim panel As GridPanel = Grid.PrimaryGrid

        For Each column As GridColumn In panel.Columns

            Dim name As String = column.Name
            Select Case True
                Case name.Contains("Time")
                    Dim datecell As GridDateTimeInputEditControl = DirectCast(column.RenderControl, GridDateTimeInputEditControl)
                    datecell.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
                    datecell.CustomFormat = "MM/dd/yy h:mm tt"
            End Select
        Next
    End Sub


    Private Sub ShowLastAppointment()


        lblLastCreated.Text = String.Empty
        lblLastAppointmentID.Text = String.Empty
    End Sub

    Private Sub ShowLastClient()
        Dim LastClient As New LastPatientClass

        LastClient = DBAccess.GetLastPatient()

        lblLastCreated.Text = String.Format("Last Client Created <b>{0}</b>", LastClient.FirstName & " " & LastClient.LastName)
        lblLastAppointmentID.Text = String.Format("Last AcctID <b>{0}</b>", LastClient.AcctID)
    End Sub

    Private Sub ShowNewDrugs()

    End Sub

    Private Sub ShowImportData()
        Dim RowCount As Integer = Grid.PrimaryGrid.Rows.Count
        Dim Message As String = String.Empty
        Dim TableTypeStr As String = String.Empty
        Select Case SelectedTable
            Case TableType.Appointments
                TableTypeStr = "Appointments"
                ShowLastAppointment()
            Case TableType.Clients
                TableTypeStr = "Clients"
                ShowLastClient()
            Case TableType.Drugs
                TableTypeStr = "Drugs"
                ShowNewDrugs()
            Case TableType.PatientInsurance
                TableTypeStr = "Patient Insurance"
                ShowNewDrugs()
        End Select
        Message = String.Format("{0} {1} have been Imported", RowCount, TableTypeStr)
        MessageBox.Show(Message)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SelectedTable = TableType.Appointments
    End Sub


    Private Sub FillGrid(ByVal dt As DataTable)
        Grid.PrimaryGrid.Columns.Clear()
        Grid.PrimaryGrid.DataSource = Nothing
        Grid.PrimaryGrid.AutoGenerateColumns = True
        Grid.PrimaryGrid.DataSource = dt
        Grid.ArrangeGrid()
    End Sub


    Private Sub GetAppointments(dt)
        If Not IsNothing(dt) Then
            FillGrid(dt)

            DBAccess.InsertAppointments(dt)
            ShowImportData()

        End If
    End Sub

    Private Sub GetPatients(ByVal dt As DataTable)


        If Not IsNothing(dt) Then
            FillGrid(dt)
            DBAccess.InsertPatients(dt)
            'Dim message As String = String.Format("{0} Clients have been Imported", dt.Rows.Count)
            'MessageBox.Show(message)
            ShowImportData()

        End If
    End Sub

    Private Sub GetPatientInsurance(ByVal dt As DataTable)


        If Not IsNothing(dt) Then
            FillGrid(dt)
            DBAccess.InsertPatientsInsurance(dt)
            'Dim message As String = String.Format("{0} Clients have been Imported", dt.Rows.Count)
            'MessageBox.Show(message)
            ShowImportData()

        End If
    End Sub
    Private Sub GetDrugs(ByVal dt As DataTable)

        If Not IsNothing(dt) Then
            FillGrid(dt)
            'DBImports.InsertPatients(dt)
            'Dim message As String = String.Format("{0} Clients have been Imported", dt.Rows.Count)
            'MessageBox.Show(message)
            ShowImportData()

        End If
    End Sub



    Private Sub rdoAppt_CheckedChanged(sender As CheckBoxX, e As EventArgs) Handles rdoAppt.CheckedChanged, rdoClient.CheckedChanged, rdoDrugs.CheckedChanged, rdoInsurance.CheckedChanged, rdoProviders.CheckedChanged

        If sender.Checked Then
            SelectedTable = CInt(sender.Tag)


            Select Case SelectedTable
                Case TableType.Appointments
                    ShowLastAppointment()
                Case TableType.Clients
                    ShowLastClient()
            End Select
        End If
    End Sub


End Class