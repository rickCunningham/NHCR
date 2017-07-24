<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImports
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Grid = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.rdoDrugs = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rdoClient = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rdoAppt = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.lblLastAppointmentID = New DevComponents.DotNetBar.LabelX()
        Me.lblLastCreated = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.rdoProviders = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rdoInsurance = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(1082, 6)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(140, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Import "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Grid
        '
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Grid.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(1234, 580)
        Me.Grid.TabIndex = 1
        Me.Grid.Text = "SuperGridControl1"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.rdoInsurance)
        Me.PanelEx1.Controls.Add(Me.rdoProviders)
        Me.PanelEx1.Controls.Add(Me.rdoDrugs)
        Me.PanelEx1.Controls.Add(Me.rdoClient)
        Me.PanelEx1.Controls.Add(Me.rdoAppt)
        Me.PanelEx1.Controls.Add(Me.lblLastAppointmentID)
        Me.PanelEx1.Controls.Add(Me.lblLastCreated)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1234, 35)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'rdoDrugs
        '
        '
        '
        '
        Me.rdoDrugs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoDrugs.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoDrugs.Location = New System.Drawing.Point(235, 6)
        Me.rdoDrugs.Name = "rdoDrugs"
        Me.rdoDrugs.Size = New System.Drawing.Size(100, 23)
        Me.rdoDrugs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoDrugs.TabIndex = 5
        Me.rdoDrugs.Tag = "2"
        Me.rdoDrugs.Text = "Import Drugs"
        '
        'rdoClient
        '
        '
        '
        '
        Me.rdoClient.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoClient.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoClient.Location = New System.Drawing.Point(138, 6)
        Me.rdoClient.Name = "rdoClient"
        Me.rdoClient.Size = New System.Drawing.Size(91, 23)
        Me.rdoClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoClient.TabIndex = 4
        Me.rdoClient.Tag = "1"
        Me.rdoClient.Text = "Import Clients"
        '
        'rdoAppt
        '
        '
        '
        '
        Me.rdoAppt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoAppt.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoAppt.Checked = True
        Me.rdoAppt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoAppt.CheckValue = "Y"
        Me.rdoAppt.Location = New System.Drawing.Point(12, 6)
        Me.rdoAppt.Name = "rdoAppt"
        Me.rdoAppt.Size = New System.Drawing.Size(120, 23)
        Me.rdoAppt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoAppt.TabIndex = 3
        Me.rdoAppt.Tag = "0"
        Me.rdoAppt.Text = "Import Appointments"
        '
        'lblLastAppointmentID
        '
        '
        '
        '
        Me.lblLastAppointmentID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblLastAppointmentID.Location = New System.Drawing.Point(877, 6)
        Me.lblLastAppointmentID.Name = "lblLastAppointmentID"
        Me.lblLastAppointmentID.Size = New System.Drawing.Size(199, 23)
        Me.lblLastAppointmentID.TabIndex = 2
        '
        'lblLastCreated
        '
        '
        '
        '
        Me.lblLastCreated.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblLastCreated.Location = New System.Drawing.Point(658, 6)
        Me.lblLastCreated.Name = "lblLastCreated"
        Me.lblLastCreated.Size = New System.Drawing.Size(199, 23)
        Me.lblLastCreated.TabIndex = 1
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Grid)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 35)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1234, 580)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 6
        Me.PanelEx2.Text = "PanelEx2"
        '
        'rdoProviders
        '
        '
        '
        '
        Me.rdoProviders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoProviders.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoProviders.Location = New System.Drawing.Point(341, 6)
        Me.rdoProviders.Name = "rdoProviders"
        Me.rdoProviders.Size = New System.Drawing.Size(100, 23)
        Me.rdoProviders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoProviders.TabIndex = 6
        Me.rdoProviders.Tag = "3"
        Me.rdoProviders.Text = "Import Providers"
        '
        'rdoInsurance
        '
        '
        '
        '
        Me.rdoInsurance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoInsurance.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoInsurance.Location = New System.Drawing.Point(447, 6)
        Me.rdoInsurance.Name = "rdoInsurance"
        Me.rdoInsurance.Size = New System.Drawing.Size(165, 23)
        Me.rdoInsurance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoInsurance.TabIndex = 7
        Me.rdoInsurance.Tag = "4"
        Me.rdoInsurance.Text = "Import Patient Insurance"
        '
        'frmImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 615)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmImports"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Grid As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblLastAppointmentID As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblLastCreated As DevComponents.DotNetBar.LabelX
    Friend WithEvents rdoClient As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoAppt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoDrugs As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoInsurance As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoProviders As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
