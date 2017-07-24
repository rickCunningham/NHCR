<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduler
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduler))
        Me.topPanel = New DevComponents.DotNetBar.PanelEx()
        Me.ribbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.buttonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewAppointment = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewAllDay = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewMultiDay = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewRecurring = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewReminder = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewStartReached = New DevComponents.DotNetBar.ButtonItem()
        Me.btnToday = New DevComponents.DotNetBar.ButtonItem()
        Me.btnBlue = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007Blue = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007Silver = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007Black = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2007VistaGlass = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2010Blue = New DevComponents.DotNetBar.ButtonItem()
        Me.Office2010Silver = New DevComponents.DotNetBar.ButtonItem()
        Me.Windows7Blue = New DevComponents.DotNetBar.ButtonItem()
        Me.contentPanel = New DevComponents.DotNetBar.PanelEx()
        Me.CalendarView1 = New DevComponents.DotNetBar.Schedule.CalendarView()
        Me.DateNavigator1 = New DevComponents.DotNetBar.Schedule.DateNavigator()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonDay = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonWeek = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonMonth = New DevComponents.DotNetBar.ButtonItem()
        Me.btnYear = New DevComponents.DotNetBar.ButtonItem()
        Me.btnTimeLine = New DevComponents.DotNetBar.ButtonItem()
        Me.topPanel.SuspendLayout()
        Me.contentPanel.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.topPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.topPanel.Controls.Add(Me.ribbonBar3)
        Me.topPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1490, 54)
        Me.topPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.topPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.topPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.topPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.topPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.topPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.topPanel.Style.GradientAngle = 90
        Me.topPanel.TabIndex = 0
        Me.topPanel.Text = "PanelEx1"
        '
        'ribbonBar3
        '
        Me.ribbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar3.ContainerControlProcessDialogKey = True
        Me.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonBar3.DragDropSupport = True
        Me.ribbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem21, Me.btnToday, Me.btnBlue})
        Me.ribbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.ribbonBar3.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar3.Name = "ribbonBar3"
        Me.ribbonBar3.Size = New System.Drawing.Size(1490, 54)
        Me.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonBar3.TabIndex = 4
        Me.ribbonBar3.Text = "Schedule"
        '
        '
        '
        Me.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar3.TitleVisible = False
        '
        'buttonItem21
        '
        Me.buttonItem21.AutoCheckOnClick = True
        Me.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem21.Image = CType(resources.GetObject("buttonItem21.Image"), System.Drawing.Image)
        Me.buttonItem21.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.buttonItem21.Name = "buttonItem21"
        Me.buttonItem21.OptionGroup = "Color"
        Me.buttonItem21.SplitButton = True
        Me.buttonItem21.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnNewAppointment, Me.btnNewAllDay, Me.btnNewMultiDay, Me.btnNewRecurring, Me.btnNewReminder, Me.btnNewStartReached})
        Me.buttonItem21.Text = "New"
        '
        'btnNewAppointment
        '
        Me.btnNewAppointment.Name = "btnNewAppointment"
        Me.btnNewAppointment.Text = "New Appointment"
        '
        'btnNewAllDay
        '
        Me.btnNewAllDay.Name = "btnNewAllDay"
        Me.btnNewAllDay.Text = "New All Day Event"
        '
        'btnNewMultiDay
        '
        Me.btnNewMultiDay.Name = "btnNewMultiDay"
        Me.btnNewMultiDay.Text = "New Multi-Day Event"
        '
        'btnNewRecurring
        '
        Me.btnNewRecurring.Name = "btnNewRecurring"
        Me.btnNewRecurring.Text = "New RecurringAppointment"
        '
        'btnNewReminder
        '
        Me.btnNewReminder.Name = "btnNewReminder"
        Me.btnNewReminder.Text = "New Appointment with Reminder in 2 Minutes"
        '
        'btnNewStartReached
        '
        Me.btnNewStartReached.Name = "btnNewStartReached"
        Me.btnNewStartReached.Text = "New Appointment with StartTimeReached Notification"
        '
        'btnToday
        '
        Me.btnToday.AutoCheckOnClick = True
        Me.btnToday.BeginGroup = True
        Me.btnToday.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnToday.Image = CType(resources.GetObject("btnToday.Image"), System.Drawing.Image)
        Me.btnToday.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnToday.Name = "btnToday"
        Me.btnToday.OptionGroup = "Color"
        Me.btnToday.SubItemsExpandWidth = 14
        Me.btnToday.Text = "Today"
        Me.btnToday.Tooltip = "Foobar"
        '
        'btnBlue
        '
        Me.btnBlue.BeginGroup = True
        Me.btnBlue.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnBlue.Image = CType(resources.GetObject("btnBlue.Image"), System.Drawing.Image)
        Me.btnBlue.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.SplitButton = True
        Me.btnBlue.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007Blue, Me.Office2007Silver, Me.Office2007Black, Me.Office2007VistaGlass, Me.Office2010Blue, Me.Office2010Silver, Me.Windows7Blue})
        Me.btnBlue.Text = "Color"
        '
        'Office2007Blue
        '
        Me.Office2007Blue.Name = "Office2007Blue"
        Me.Office2007Blue.Text = "Office2007Blue"
        '
        'Office2007Silver
        '
        Me.Office2007Silver.Name = "Office2007Silver"
        Me.Office2007Silver.Text = "Office2007Silver"
        '
        'Office2007Black
        '
        Me.Office2007Black.Name = "Office2007Black"
        Me.Office2007Black.Text = "Office2007Black"
        '
        'Office2007VistaGlass
        '
        Me.Office2007VistaGlass.Name = "Office2007VistaGlass"
        Me.Office2007VistaGlass.Text = "Office2007VistaGlass"
        '
        'Office2010Blue
        '
        Me.Office2010Blue.BeginGroup = True
        Me.Office2010Blue.Name = "Office2010Blue"
        Me.Office2010Blue.Text = "Office2010Blue"
        '
        'Office2010Silver
        '
        Me.Office2010Silver.Name = "Office2010Silver"
        Me.Office2010Silver.Text = "Office2010Silver"
        '
        'Windows7Blue
        '
        Me.Windows7Blue.BeginGroup = True
        Me.Windows7Blue.Name = "Windows7Blue"
        Me.Windows7Blue.Text = "Windows7Blue"
        '
        'contentPanel
        '
        Me.contentPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.contentPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.contentPanel.Controls.Add(Me.CalendarView1)
        Me.contentPanel.Controls.Add(Me.DateNavigator1)
        Me.contentPanel.Controls.Add(Me.Bar1)
        Me.contentPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(0, 54)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1490, 685)
        Me.contentPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.contentPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.contentPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.contentPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.contentPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.contentPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.contentPanel.Style.GradientAngle = 90
        Me.contentPanel.TabIndex = 4
        Me.contentPanel.Text = "PanelEx1"
        '
        'CalendarView1
        '
        Me.CalendarView1.AutoScrollMinSize = New System.Drawing.Size(252, 980)
        Me.CalendarView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        Me.CalendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CalendarView1.ContainerControlProcessDialogKey = True
        Me.CalendarView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CalendarView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalendarView1.HighlightCurrentDay = True
        Me.CalendarView1.LabelTimeSlots = True
        Me.CalendarView1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.CalendarView1.Location = New System.Drawing.Point(0, 59)
        Me.CalendarView1.MultiUserTabHeight = 19
        Me.CalendarView1.Name = "CalendarView1"
        Me.CalendarView1.ShowOnlyWorkDayHours = True
        Me.CalendarView1.Size = New System.Drawing.Size(1490, 626)
        Me.CalendarView1.TabIndex = 1
        Me.CalendarView1.Text = "CalendarView1"
        Me.CalendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty
        Me.CalendarView1.TimeIndicator.IndicatorArea = DevComponents.DotNetBar.Schedule.eTimeIndicatorArea.All
        Me.CalendarView1.TimeIndicator.Tag = Nothing
        Me.CalendarView1.TimeIndicator.Visibility = DevComponents.DotNetBar.Schedule.eTimeIndicatorVisibility.AllResources
        Me.CalendarView1.TimeSlotDuration = 30
        '
        'DateNavigator1
        '
        Me.DateNavigator1.CalendarView = Me.CalendarView1
        Me.DateNavigator1.CanvasColor = System.Drawing.SystemColors.Control
        Me.DateNavigator1.DisabledBackColor = System.Drawing.Color.Empty
        Me.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateNavigator1.Location = New System.Drawing.Point(0, 29)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.Size = New System.Drawing.Size(1490, 30)
        Me.DateNavigator1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DateNavigator1.TabIndex = 9
        Me.DateNavigator1.Text = "DateNavigator1"
        '
        'Bar1
        '
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonDay, Me.ButtonWeek, Me.ButtonMonth, Me.btnYear, Me.btnTimeLine})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1490, 29)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 5
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonDay
        '
        Me.ButtonDay.Checked = True
        Me.ButtonDay.Name = "ButtonDay"
        Me.ButtonDay.OptionGroup = "View"
        Me.ButtonDay.Text = "Day"
        '
        'ButtonWeek
        '
        Me.ButtonWeek.Name = "ButtonWeek"
        Me.ButtonWeek.OptionGroup = "View"
        Me.ButtonWeek.Text = "Week"
        '
        'ButtonMonth
        '
        Me.ButtonMonth.Name = "ButtonMonth"
        Me.ButtonMonth.OptionGroup = "View"
        Me.ButtonMonth.Text = "Month"
        '
        'btnYear
        '
        Me.btnYear.Name = "btnYear"
        Me.btnYear.OptionGroup = "View"
        Me.btnYear.Text = "Year"
        '
        'btnTimeLine
        '
        Me.btnTimeLine.Name = "btnTimeLine"
        Me.btnTimeLine.OptionGroup = "View"
        Me.btnTimeLine.Text = "TimeLine"
        '
        'frmScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 739)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.topPanel)
        Me.DoubleBuffered = True
        Me.Name = "frmScheduler"
        Me.Text = "frmScheduler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.topPanel.ResumeLayout(False)
        Me.contentPanel.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topPanel As DevComponents.DotNetBar.PanelEx
    Private WithEvents ribbonBar3 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents buttonItem21 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewAppointment As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewAllDay As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewMultiDay As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewRecurring As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewReminder As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnNewStartReached As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnToday As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnBlue As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Office2007Blue As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Office2007Silver As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Office2007Black As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Office2007VistaGlass As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Office2010Blue As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Office2010Silver As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Windows7Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents contentPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CalendarView1 As DevComponents.DotNetBar.Schedule.CalendarView
    Friend WithEvents DateNavigator1 As DevComponents.DotNetBar.Schedule.DateNavigator
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonDay As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonWeek As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonMonth As DevComponents.DotNetBar.ButtonItem
    Private WithEvents btnYear As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnTimeLine As DevComponents.DotNetBar.ButtonItem
End Class
