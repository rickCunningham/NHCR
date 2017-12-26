<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPatientDrugOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ctlPanel = New DevComponents.DotNetBar.PanelEx()
        Me.lstNotes = New DevComponents.DotNetBar.ListBoxAdv()
        Me.lblAddNote = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.pnlBottom = New DevComponents.DotNetBar.PanelEx()
        Me.btnNewOrder = New DevComponents.DotNetBar.ButtonX()
        Me.btnUpdate = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dblQty = New DevComponents.Editors.DoubleInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cboUnit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.dtExpirationDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.dtOrderDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lblInfo = New DevComponents.DotNetBar.LabelX()
        Me.cboProviders = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboDrugs = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblPatientName = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.ctlPanel.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dblQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpirationDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctlPanel
        '
        Me.ctlPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ctlPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ctlPanel.Controls.Add(Me.lstNotes)
        Me.ctlPanel.Controls.Add(Me.lblAddNote)
        Me.ctlPanel.Controls.Add(Me.LabelX8)
        Me.ctlPanel.Controls.Add(Me.pnlBottom)
        Me.ctlPanel.Controls.Add(Me.GroupPanel1)
        Me.ctlPanel.Controls.Add(Me.Line1)
        Me.ctlPanel.Controls.Add(Me.LabelX7)
        Me.ctlPanel.Controls.Add(Me.dtExpirationDate)
        Me.ctlPanel.Controls.Add(Me.LabelX6)
        Me.ctlPanel.Controls.Add(Me.dtOrderDate)
        Me.ctlPanel.Controls.Add(Me.LabelX4)
        Me.ctlPanel.Controls.Add(Me.lblInfo)
        Me.ctlPanel.Controls.Add(Me.cboProviders)
        Me.ctlPanel.Controls.Add(Me.LabelX1)
        Me.ctlPanel.Controls.Add(Me.cboDrugs)
        Me.ctlPanel.Controls.Add(Me.lblPatientName)
        Me.ctlPanel.Controls.Add(Me.LabelX5)
        Me.ctlPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.ctlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlPanel.Location = New System.Drawing.Point(5, 5)
        Me.ctlPanel.Name = "ctlPanel"
        Me.ctlPanel.Size = New System.Drawing.Size(489, 448)
        Me.ctlPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ctlPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ctlPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ctlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ctlPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ctlPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ctlPanel.Style.GradientAngle = 90
        Me.ctlPanel.TabIndex = 0
        '
        'lstNotes
        '
        Me.lstNotes.AutoScroll = True
        Me.lstNotes.BackColor = System.Drawing.Color.LightYellow
        '
        '
        '
        Me.lstNotes.BackgroundStyle.BackColor = System.Drawing.Color.Beige
        Me.lstNotes.BackgroundStyle.Class = "ListBoxAdv"
        Me.lstNotes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lstNotes.CheckStateMember = Nothing
        Me.lstNotes.ContainerControlProcessDialogKey = True
        Me.lstNotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstNotes.DragDropSupport = True
        Me.lstNotes.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.lstNotes.Location = New System.Drawing.Point(0, 265)
        Me.lstNotes.Name = "lstNotes"
        Me.lstNotes.Size = New System.Drawing.Size(489, 146)
        Me.lstNotes.TabIndex = 28
        Me.lstNotes.Text = "ListBoxAdv1"
        '
        'lblAddNote
        '
        '
        '
        '
        Me.lblAddNote.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAddNote.Image = Global.AccuPoint.My.Resources.Resources.Plus
        Me.lblAddNote.Location = New System.Drawing.Point(75, 245)
        Me.lblAddNote.Name = "lblAddNote"
        Me.lblAddNote.Size = New System.Drawing.Size(100, 23)
        Me.lblAddNote.TabIndex = 27
        Me.lblAddNote.Text = "Add Note"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(7, 245)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 26
        Me.LabelX8.Text = "Order Notes"
        '
        'pnlBottom
        '
        Me.pnlBottom.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlBottom.Controls.Add(Me.btnNewOrder)
        Me.pnlBottom.Controls.Add(Me.btnUpdate)
        Me.pnlBottom.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 411)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(489, 37)
        Me.pnlBottom.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlBottom.Style.BackColor1.Color = System.Drawing.Color.LightSlateGray
        Me.pnlBottom.Style.BackColor2.Color = System.Drawing.Color.SlateGray
        Me.pnlBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlBottom.Style.GradientAngle = 90
        Me.pnlBottom.TabIndex = 21
        '
        'btnNewOrder
        '
        Me.btnNewOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNewOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnNewOrder.Image = Global.AccuPoint.My.Resources.Resources.Add
        Me.btnNewOrder.Location = New System.Drawing.Point(254, 0)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(118, 37)
        Me.btnNewOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNewOrder.TabIndex = 2
        Me.btnNewOrder.Text = "New Order"
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnUpdate.Image = Global.AccuPoint.My.Resources.Resources.Refresh
        Me.btnUpdate.Location = New System.Drawing.Point(117, 0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 37)
        Me.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Order"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dblQty)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.cboUnit)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(233, 166)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(226, 79)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 20
        Me.GroupPanel1.Text = "Dosage Information"
        '
        'dblQty
        '
        '
        '
        '
        Me.dblQty.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dblQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dblQty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dblQty.Increment = 1.0R
        Me.dblQty.Location = New System.Drawing.Point(3, 28)
        Me.dblQty.Name = "dblQty"
        Me.dblQty.ShowUpDown = True
        Me.dblQty.Size = New System.Drawing.Size(80, 20)
        Me.dblQty.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(5, 8)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(54, 19)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Amount"
        '
        'cboUnit
        '
        Me.cboUnit.DisplayMember = "Text"
        Me.cboUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.ItemHeight = 14
        Me.cboUnit.Location = New System.Drawing.Point(89, 28)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(121, 20)
        Me.cboUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboUnit.TabIndex = 3
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(91, 7)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(30, 20)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Unit"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(0, 143)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(489, 23)
        Me.Line1.TabIndex = 19
        Me.Line1.Text = "Line1"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(296, 48)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(148, 23)
        Me.LabelX7.TabIndex = 18
        Me.LabelX7.Text = "Order Expiration Date"
        '
        'dtExpirationDate
        '
        '
        '
        '
        Me.dtExpirationDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtExpirationDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtExpirationDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtExpirationDate.ButtonDropDown.Visible = True
        Me.dtExpirationDate.DisabledBackColor = System.Drawing.Color.FloralWhite
        Me.dtExpirationDate.DisabledForeColor = System.Drawing.Color.Black
        Me.dtExpirationDate.Enabled = False
        Me.dtExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtExpirationDate.IsPopupCalendarOpen = False
        Me.dtExpirationDate.Location = New System.Drawing.Point(296, 74)
        Me.dtExpirationDate.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        '
        '
        '
        Me.dtExpirationDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtExpirationDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtExpirationDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtExpirationDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtExpirationDate.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtExpirationDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtExpirationDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtExpirationDate.MonthCalendar.TodayButtonVisible = True
        Me.dtExpirationDate.Name = "dtExpirationDate"
        Me.dtExpirationDate.Size = New System.Drawing.Size(163, 20)
        Me.dtExpirationDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtExpirationDate.TabIndex = 17
        Me.dtExpirationDate.Value = New Date(2017, 7, 20, 18, 44, 52, 0)
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(30, 48)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 16
        Me.LabelX6.Text = "Order Date"
        '
        'dtOrderDate
        '
        '
        '
        '
        Me.dtOrderDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtOrderDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtOrderDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtOrderDate.ButtonDropDown.Visible = True
        Me.dtOrderDate.IsPopupCalendarOpen = False
        Me.dtOrderDate.Location = New System.Drawing.Point(30, 74)
        Me.dtOrderDate.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        '
        '
        '
        '
        '
        Me.dtOrderDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtOrderDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtOrderDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtOrderDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtOrderDate.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.dtOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtOrderDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtOrderDate.MonthCalendar.TodayButtonVisible = True
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(163, 20)
        Me.dtOrderDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtOrderDate.TabIndex = 15
        Me.dtOrderDate.Value = New Date(2017, 7, 20, 18, 44, 52, 0)
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(30, 102)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(111, 23)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Referring Provider"
        '
        'lblInfo
        '
        '
        '
        '
        Me.lblInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblInfo.Image = Global.AccuPoint.My.Resources.Resources.Info1
        Me.lblInfo.Location = New System.Drawing.Point(255, 121)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(29, 23)
        Me.lblInfo.TabIndex = 8
        '
        'cboProviders
        '
        Me.cboProviders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProviders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProviders.DisplayMember = "Text"
        Me.cboProviders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProviders.FormattingEnabled = True
        Me.cboProviders.ItemHeight = 15
        Me.cboProviders.Location = New System.Drawing.Point(30, 123)
        Me.cboProviders.Name = "cboProviders"
        Me.cboProviders.Size = New System.Drawing.Size(219, 21)
        Me.cboProviders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboProviders.TabIndex = 7
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(41, 192)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 20)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Drug"
        '
        'cboDrugs
        '
        Me.cboDrugs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDrugs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDrugs.DisplayMember = "Text"
        Me.cboDrugs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDrugs.FormattingEnabled = True
        Me.cboDrugs.ItemHeight = 15
        Me.cboDrugs.Location = New System.Drawing.Point(39, 211)
        Me.cboDrugs.Name = "cboDrugs"
        Me.cboDrugs.Size = New System.Drawing.Size(179, 21)
        Me.cboDrugs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboDrugs.TabIndex = 1
        '
        'lblPatientName
        '
        '
        '
        '
        Me.lblPatientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPatientName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPatientName.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPatientName.Location = New System.Drawing.Point(0, 23)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(489, 23)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "LabelX1"
        Me.lblPatientName.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(0, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(489, 23)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Patient Order Information"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ctlPatientDrugOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.ctlPanel)
        Me.Name = "ctlPatientDrugOrder"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(499, 458)
        Me.ctlPanel.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dblQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpirationDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ctlPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblPatientName As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDrugs As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboUnit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dblQty As DevComponents.Editors.DoubleInput
    Friend WithEvents cboProviders As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblInfo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtOrderDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtExpirationDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblAddNote As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pnlBottom As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lstNotes As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents btnUpdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNewOrder As DevComponents.DotNetBar.ButtonX
End Class
