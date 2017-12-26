Imports DevComponents.DotNetBar.Schedule
Imports DevComponents.Schedule.Model

Public Class frmScheduler


    Private Sub frmScheduler_Load(sender As Object, e As EventArgs) Handles Me.Load



        Dim _Model As New CalendarModel()
        'Dim workDay As WorkDay = _Model.WorkDays(DayOfWeek.Monday)

        For I = DayOfWeek.Monday To DayOfWeek.Friday
            Dim workDay As WorkDay = _Model.WorkDays(I)
            Dim workStartTime As New WorkTime()

            workStartTime.Hour = 7
            workStartTime.Minute = 0
            workDay.WorkStartTime = workStartTime

            ' Set working day end time
            ' 8:00 PM, 24 hour format is used

            Dim workEndTime As New WorkTime()

            workEndTime.Hour = 21
            workEndTime.Minute = 0
            workDay.WorkEndTime = workEndTime

        Next
        CalendarView1.CalendarModel = _Model

        LoadAppointments
    End Sub

    Private Sub LoadAppointments()


        Dim appts As DataTable = DBAppointments.GetAppointments

        If Not IsNothing(appts) Then
            For Each row As DataRow In appts.Rows
                Dim NewAppointment As New MedApptClass(row)
                AddAppointment(NewAppointment)
            Next

        End If

        AddHolidaySchedule()

    End Sub




    Private Function AddAppointment(ByVal MedAppt As MedApptClass) As Appointment
        Dim appointment As New Appointment()

        appointment.Id = MedAppt.AppointmentID
        appointment.StartTime = MedAppt.starttime
        appointment.EndTime = MedAppt.endtime
        appointment.OwnerKey = "Infusions"
        appointment.Subject = MedAppt.DisplayText
        appointment.Description = MedAppt.ApptType
        appointment.Tag = MedAppt
        Select Case MedAppt.Duration
            Case 30
                appointment.CategoryColor = Appointment.CategoryBlue
            Case 60
                appointment.CategoryColor = Appointment.CategoryGreen
            Case 90
                appointment.CategoryColor = Appointment.CategoryOrange
            Case 120
                appointment.CategoryColor = Appointment.CategoryPurple
            Case 180
                appointment.CategoryColor = Appointment.CategoryRed

            Case 240
                appointment.CategoryColor = Appointment.CategoryYellow
            Case 300
                appointment.CategoryColor = "#61cde0"
            Case 360
                appointment.CategoryColor = "#c680b3"

            Case 480
                appointment.CategoryColor = "#da3d25"

        End Select
        CalendarView1.CalendarModel.Appointments.Add(appointment)
        appointment.Locked = True
        Return appointment

    End Function


    Private Function AddAppointment(ByVal s As String, ByVal startTime As DateTime, ByVal endTime As DateTime, ByVal ownerKey As String, ByVal color As String, ByVal marker As String) As Appointment
        Dim appointment As New Appointment()

        appointment.StartTime = startTime
        appointment.EndTime = endTime
        appointment.OwnerKey = ownerKey

        appointment.Subject = s
        appointment.Description = "Custom description for this appointment"
        appointment.CategoryColor = color
        appointment.TimeMarkedAs = marker

        appointment.Tooltip = "This is a Custom tooltip for this appointment"

        CalendarView1.CalendarModel.Appointments.Add(appointment)

        Return (appointment)
    End Function




    Private Sub AppointmentViewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As AppointmentView = TryCast(sender, AppointmentView)
        Dim appt As MedApptClass = DirectCast(view.Appointment.Tag, MedApptClass)
        If Not IsNothing(appt) Then
            MessageBox.Show(String.Format("Appointment on  {0} for {1}", appt.starttime.ToShortDateString, appt.FirstName & " " & appt.LastName))

        End If

    End Sub


#Region "AddHolidaySchedule"

    ''' <summary>
    ''' Adds our Holiday schedule, starting January 1, 2010
    ''' and continuing for the next 10 years
    ''' </summary>
    Private Sub AddHolidaySchedule()
        AddHoliday("New Years Day", 1, 1)
        AddHoliday("Martin Luther King Jr Day", 1, eRelativeDayInMonth.Third, DayOfWeek.Monday)
        AddHoliday("Groundhog Day", 2, 2)
        AddHoliday("Valentines Day", 2, 14)
        AddHoliday("Presidents Day", 2, eRelativeDayInMonth.Third, DayOfWeek.Monday)
        AddHoliday("St. Patricks Day", 3, 17)
        AddHoliday("April Fools Day", 4, 1)
        AddHoliday("Earth Day", 4, 22)
        AddHoliday("Cinco de Mayo", 5, 5)
        AddHoliday("Mothers Day", 5, eRelativeDayInMonth.Second, DayOfWeek.Saturday)
        AddHoliday("Memorial Day", 5, eRelativeDayInMonth.Last, DayOfWeek.Monday)
        AddHoliday("Flag Day", 6, 14)
        AddHoliday("Fathers Day", 6, eRelativeDayInMonth.Third, DayOfWeek.Sunday)
        AddHoliday("Independence Day", 7, 4)
        AddHoliday("Labor Day", 9, eRelativeDayInMonth.First, DayOfWeek.Monday)
        AddHoliday("Columbus Day", 10, eRelativeDayInMonth.Second, DayOfWeek.Monday)
        AddHoliday("Halloween", 10, 31)
        AddHoliday("Veterans Day", 11, 11)
        AddHoliday("Thanksgiving", 11, eRelativeDayInMonth.Fourth, DayOfWeek.Thursday)
        AddHoliday("Christmas", 12, 25)
        AddHoliday("New Years Eve", 12, 31)

        ' Add Easter

        AddEaster()
    End Sub

#Region "AddHoliday"

    ''' <summary>
    ''' Adds the given "Absolute" Holiday to the calendar
    ''' </summary>
    ''' <param name="title">Holiday title</param>
    ''' <param name="month">Month</param>
    ''' <param name="day">Day</param>
    Private Sub AddHoliday(ByVal title As String, ByVal month As Integer, ByVal day As Integer)
        Dim appointment As Appointment = NewHoliday(title, New DateTime(Today.Year, month, day))

        appointment.Recurrence.Yearly.RepeatOnMonth = month
        appointment.Recurrence.Yearly.RepeatOnDayOfMonth = day

        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)
    End Sub

    ''' <summary>
    ''' Adds the given "Relative" Holiday to the calendar
    ''' </summary>
    ''' <param name="title">Holiday title</param>
    ''' <param name="month">Month</param>
    ''' <param name="relDim">Day in Month</param>
    ''' <param name="dow">Day of Week</param>
    Private Sub AddHoliday(ByVal title As String, ByVal month As Integer, ByVal relDim As eRelativeDayInMonth, ByVal dow As DayOfWeek)
        Dim appointment As Appointment = NewHoliday(title, RelativeDate(month, relDim, dow))

        appointment.Recurrence.Yearly.RepeatOnMonth = month
        appointment.Recurrence.Yearly.RelativeDayOfWeek = dow
        appointment.Recurrence.Yearly.RepeatOnRelativeDayInMonth = relDim
        appointment.Recurrence.Yearly.RepeatOnDayOfMonth = 0

        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)
    End Sub

#End Region

#Region "RelativeDate"

    ''' <summary>
    ''' Calculates the date from the given
    ''' relative day in the month and day of the week
    ''' </summary>
    ''' <param name="month">Month</param>
    ''' <param name="relDim">Relative Day in Month</param>
    ''' <param name="dow">Day of Week</param>
    ''' <returns>Date</returns>
    Private Function RelativeDate(ByVal month As Integer, ByVal relDim As eRelativeDayInMonth, ByVal dow As DayOfWeek) As DateTime
        Dim relDate As New DateTime(2010, month, 1)

        While relDate.DayOfWeek <> dow
            relDate = relDate.AddDays(1)
        End While

        Select Case relDim
            Case eRelativeDayInMonth.First
                Return (relDate)

            Case eRelativeDayInMonth.Second
                Return (relDate.AddDays(7))

            Case eRelativeDayInMonth.Third
                Return (relDate.AddDays(14))

            Case eRelativeDayInMonth.Fourth
                Return (relDate.AddDays(21))
        End Select

        Return (relDate)
    End Function

#End Region

#Region "NewHoliday"

    ''' <summary>
    ''' Allocates a new Holiday appointment
    ''' </summary>
    ''' <param name="title">Holiday title</param>
    ''' <param name="startTime">Start time</param>
    ''' <returns>Allocated appointment</returns>
    Private Function NewHoliday(ByVal title As String, ByVal startTime As DateTime) As Appointment
        ' Allocate a new Appointment

        Dim appointment As New Appointment()

        appointment.Subject = title
        appointment.Tooltip = title
        appointment.OwnerKey = "Infusions"
        appointment.CategoryColor = Appointment.CategoryGreen
        appointment.TimeMarkedAs = Appointment.TimerMarkerFree
        appointment.Locked = True

        appointment.StartTime = startTime
        appointment.EndTime = startTime.AddDays(1)

        ' Allocate a new AppointmentRecurrence

        appointment.Recurrence = New AppointmentRecurrence()

        appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Yearly
        appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate
        appointment.Recurrence.RangeEndDate = DateTime.Today.AddYears(10)

        Return (appointment)
    End Function

#End Region

#Region "AddEaster"

    ''' <summary>
    ''' Add Easter appointments for the next 10 years
    ''' </summary>
    Private Sub AddEaster()
        ' Add 10 years worth of dates

        For i As Integer = 2010 To 2019
            Dim [date] As DateTime = EasterDate(i)

            ' Add Easter

            Dim appointment As New Appointment()

            appointment.StartTime = [date]
            appointment.EndTime = appointment.StartTime.AddDays(1)

            appointment.Subject = "Easter"
            appointment.Tooltip = appointment.Subject
            appointment.OwnerKey = "Infusions"
            appointment.CategoryColor = Appointment.CategoryRed
            appointment.TimeMarkedAs = Appointment.TimerMarkerFree
            appointment.Locked = True

            CalendarView1.CalendarModel.Appointments.Add(appointment)

            ' Add Good Friday

            appointment = New Appointment()

            appointment.StartTime = [date].AddDays(-2)
            appointment.EndTime = appointment.StartTime.AddDays(1)

            appointment.Subject = "Good Friday"
            appointment.Tooltip = appointment.Subject
            appointment.OwnerKey = "Infusions"
            appointment.CategoryColor = Appointment.CategoryRed
            appointment.TimeMarkedAs = Appointment.TimerMarkerFree
            appointment.Locked = True

            CalendarView1.CalendarModel.Appointments.Add(appointment)
        Next
    End Sub

#Region "EasterDate"

    ''' <summary>
    ''' Gets the Date for Easter for the given year
    ''' </summary>
    ''' <param name="year">Year</param>
    ''' <returns>Easter date</returns>
    Private Function EasterDate(ByVal year As Integer) As DateTime

        Dim g As Integer = year Mod 19
        Dim c As Integer = year \ 100
        Dim h As Integer = (c - (c \ 4) - ((8 * c + 13) \ 25) + 19 * g + 15) Mod 30
        Dim i As Integer = h - (h \ 28) * (1 - (h \ 28) * (29 \ (h + 1)) * ((21 - g) \ 11))

        Dim day As Integer = i - ((year + (year \ 4) + i + 2 - c + (c \ 4)) Mod 7) + 28
        Dim month As Integer = 3

        If day > 31 Then
            month = month + 1
            day = day - 31
        End If

        Return (New DateTime(year, month, day))

    End Function

#End Region

#End Region

#End Region



#Region "btnToday_Click"

    ''' <summary>
    ''' Sets the calendar view display to today's date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToday_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToday.Click
        CalendarView1.ShowDate(DateTime.Today)
    End Sub

#End Region




#Region "View change"

    ''' <summary>
    ''' Day view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnDay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDay.Click
        CalendarView1.SelectedView = eCalendarView.Day
    End Sub

    ''' <summary>
    ''' Week view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonWeek.Click
        CalendarView1.SelectedView = eCalendarView.Week
    End Sub

    ''' <summary>
    ''' Month view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonMonth.Click
        CalendarView1.SelectedView = eCalendarView.Month
    End Sub

    ''' <summary>
    ''' Year view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYear.Click
        CalendarView1.SelectedView = eCalendarView.Year
    End Sub

    ''' <summary>
    ''' TimeLine view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub ButtonTimeLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeLine.Click
        CalendarView1.SelectedView = eCalendarView.TimeLine
    End Sub

#End Region

#Region "calendarView1_SelectedViewChanged"

    ''' <summary>
    ''' Processes CalendarView SelectedViewChanged events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub calendarView1_SelectedViewChanged(ByVal sender As Object, ByVal e As SelectedViewEventArgs) Handles CalendarView1.SelectedViewChanged
        Select Case e.NewValue
            Case eCalendarView.Day
                ButtonDay.Checked = True
                Exit Select

            Case eCalendarView.Week
                ButtonWeek.Checked = True
                Exit Select

            Case eCalendarView.Month
                ButtonMonth.Checked = True
                Exit Select

            Case eCalendarView.Year
                btnYear.Checked = True
                Exit Select

            Case eCalendarView.TimeLine
                btnTimeLine.Checked = True
                Exit Select
        End Select
    End Sub



    Private Sub CalendarView1_MouseUp(sender As Object, e As MouseEventArgs) Handles CalendarView1.MouseUp
        If e.Button = MouseButtons.Right Then
            If TypeOf sender Is AppointmentView Then
                AppointmentViewMouseUp(sender, e)
            End If
        End If
    End Sub






#End Region

End Class


Public Class MedApptClass
    Public Property AppointmentRow As DataRow
    Public Property AppointmentID As Integer

    Public Property starttime As Date
    Private Property _endtime As Date
    Public ReadOnly Property endtime As Date
        Get
            Return _endtime

        End Get
    End Property
    Public Property PatientID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DisplayText As String
    Public Property Duration As Integer
    Public Property ApptType As String

    Public Sub New()
        Duration = 0
        DisplayText = String.Empty
        ApptType = String.Empty
    End Sub

    Public Sub New(ByVal _Appointmentrow As DataRow)
        AppointmentRow = _Appointmentrow
        AppointmentID = AppointmentRow("AppointmentId")
        starttime = AppointmentRow("AppointmentTime")
        Duration = AppointmentRow("Duration")
        _endtime = starttime.AddMinutes(Duration)
        FirstName = AppointmentRow("FirstName")
        LastName = AppointmentRow("LastName")
        PatientID = AppointmentRow("PatientID")

        DisplayText = String.Format("{0} {1} - {2} hrs", FirstName, LastName, Duration / 60)
        ApptType = AppointmentRow("Description")


    End Sub





End Class