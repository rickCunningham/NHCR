<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
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
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.pnlContent = New DevComponents.DotNetBar.PanelEx()
        Me.sgPatients = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.pnlbottom = New DevComponents.DotNetBar.PanelEx()
        Me.OrderPanel = New AccuPoint.CustomFlowLayoutPanel()
        Me.CtlPatientDrugOrder1 = New AccuPoint.ctlPatientDrugOrder()
        Me.pnlTop = New DevComponents.DotNetBar.PanelEx()
        Me.btnGetPatients = New DevComponents.DotNetBar.ButtonX()
        Me.rdoAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rdoAllergy = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rdoInfusion = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel1.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlbottom.SuspendLayout()
        Me.OrderPanel.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideNav1
        '
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.Separator1, Me.SideNavItem2})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(1472, 780)
        Me.SideNav1.TabIndex = 0
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.Controls.Add(Me.pnlContent)
        Me.SideNavPanel1.Controls.Add(Me.pnlbottom)
        Me.SideNavPanel1.Controls.Add(Me.pnlTop)
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.Location = New System.Drawing.Point(77, 37)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(1390, 742)
        Me.SideNavPanel1.TabIndex = 2
        '
        'pnlContent
        '
        Me.pnlContent.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlContent.Controls.Add(Me.sgPatients)
        Me.pnlContent.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 100)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1390, 123)
        Me.pnlContent.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlContent.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlContent.Style.GradientAngle = 90
        Me.pnlContent.TabIndex = 12
        Me.pnlContent.Text = "PanelEx1"
        '
        'sgPatients
        '
        Me.sgPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sgPatients.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.sgPatients.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.sgPatients.Location = New System.Drawing.Point(0, 0)
        Me.sgPatients.Name = "sgPatients"
        '
        '
        '
        Me.sgPatients.PrimaryGrid.EnableColumnFiltering = True
        Me.sgPatients.PrimaryGrid.EnableFiltering = True
        Me.sgPatients.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.sgPatients.PrimaryGrid.Filter.Visible = True
        Me.sgPatients.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight
        Me.sgPatients.Size = New System.Drawing.Size(1390, 123)
        Me.sgPatients.TabIndex = 0
        Me.sgPatients.Text = "SuperGridControl1"
        '
        'pnlbottom
        '
        Me.pnlbottom.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlbottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlbottom.Controls.Add(Me.OrderPanel)
        Me.pnlbottom.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbottom.Location = New System.Drawing.Point(0, 223)
        Me.pnlbottom.Name = "pnlbottom"
        Me.pnlbottom.Size = New System.Drawing.Size(1390, 519)
        Me.pnlbottom.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlbottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlbottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlbottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlbottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlbottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlbottom.Style.GradientAngle = 90
        Me.pnlbottom.TabIndex = 8
        Me.pnlbottom.Text = "PanelEx2"
        '
        'OrderPanel
        '
        Me.OrderPanel.AutoScroll = True
        Me.OrderPanel.BackColor = System.Drawing.Color.SlateGray
        Me.OrderPanel.Controls.Add(Me.CtlPatientDrugOrder1)
        Me.OrderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderPanel.Location = New System.Drawing.Point(0, 0)
        Me.OrderPanel.Name = "OrderPanel"
        Me.OrderPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.OrderPanel.Size = New System.Drawing.Size(1390, 519)
        Me.OrderPanel.TabIndex = 0
        '
        'CtlPatientDrugOrder1
        '
        Me.CtlPatientDrugOrder1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CtlPatientDrugOrder1.CurrentPatientOrder = Nothing
        Me.CtlPatientDrugOrder1.Location = New System.Drawing.Point(8, 8)
        Me.CtlPatientDrugOrder1.Name = "CtlPatientDrugOrder1"
        Me.CtlPatientDrugOrder1.Padding = New System.Windows.Forms.Padding(5)
        Me.CtlPatientDrugOrder1.Size = New System.Drawing.Size(499, 458)
        Me.CtlPatientDrugOrder1.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlTop.Controls.Add(Me.btnGetPatients)
        Me.pnlTop.Controls.Add(Me.rdoAll)
        Me.pnlTop.Controls.Add(Me.rdoAllergy)
        Me.pnlTop.Controls.Add(Me.rdoInfusion)
        Me.pnlTop.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1390, 100)
        Me.pnlTop.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlTop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlTop.Style.GradientAngle = 90
        Me.pnlTop.TabIndex = 0
        Me.pnlTop.Text = "PanelEx1"
        '
        'btnGetPatients
        '
        Me.btnGetPatients.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetPatients.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnGetPatients.Location = New System.Drawing.Point(373, 39)
        Me.btnGetPatients.Name = "btnGetPatients"
        Me.btnGetPatients.Size = New System.Drawing.Size(75, 23)
        Me.btnGetPatients.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGetPatients.TabIndex = 3
        Me.btnGetPatients.Text = "Get Patients"
        '
        'rdoAll
        '
        '
        '
        '
        Me.rdoAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoAll.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoAll.Location = New System.Drawing.Point(244, 39)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(100, 23)
        Me.rdoAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoAll.TabIndex = 2
        Me.rdoAll.Tag = ""
        Me.rdoAll.Text = "All Patients"
        '
        'rdoAllergy
        '
        '
        '
        '
        Me.rdoAllergy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoAllergy.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoAllergy.Location = New System.Drawing.Point(127, 39)
        Me.rdoAllergy.Name = "rdoAllergy"
        Me.rdoAllergy.Size = New System.Drawing.Size(100, 23)
        Me.rdoAllergy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoAllergy.TabIndex = 1
        Me.rdoAllergy.Tag = "A"
        Me.rdoAllergy.Text = "Allergy Patients"
        '
        'rdoInfusion
        '
        '
        '
        '
        Me.rdoInfusion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rdoInfusion.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rdoInfusion.Location = New System.Drawing.Point(4, 39)
        Me.rdoInfusion.Name = "rdoInfusion"
        Me.rdoInfusion.Size = New System.Drawing.Size(106, 23)
        Me.rdoInfusion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rdoInfusion.TabIndex = 0
        Me.rdoInfusion.Tag = "H"
        Me.rdoInfusion.Text = "Infusion  Patients"
        '
        'SideNavItem1
        '
        Me.SideNavItem1.IsSystemMenu = True
        Me.SideNavItem1.Name = "SideNavItem1"
        Me.SideNavItem1.Symbol = ""
        Me.SideNavItem1.Text = "Menu"
        '
        'Separator1
        '
        Me.Separator1.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Padding.Bottom = 2
        Me.Separator1.Padding.Left = 6
        Me.Separator1.Padding.Right = 6
        Me.Separator1.Padding.Top = 2
        Me.Separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'SideNavItem2
        '
        Me.SideNavItem2.Checked = True
        Me.SideNavItem2.Name = "SideNavItem2"
        Me.SideNavItem2.Panel = Me.SideNavPanel1
        Me.SideNavItem2.Symbol = ""
        Me.SideNavItem2.Text = "Home"
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 780)
        Me.Controls.Add(Me.SideNav1)
        Me.DoubleBuffered = True
        Me.Name = "frmPatients"
        Me.Text = "frmPatients"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.SideNavPanel1.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlbottom.ResumeLayout(False)
        Me.OrderPanel.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents pnlContent As DevComponents.DotNetBar.PanelEx
    Friend WithEvents sgPatients As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents pnlbottom As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnlTop As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnGetPatients As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rdoAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoAllergy As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rdoInfusion As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Friend WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents OrderPanel As CustomFlowLayoutPanel
    Friend WithEvents CtlPatientDrugOrder1 As ctlPatientDrugOrder
End Class
