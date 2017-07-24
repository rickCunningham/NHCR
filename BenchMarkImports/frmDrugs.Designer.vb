<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrugs
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
        Me.ctlPanel = New AccuPoint.CustomFlowLayoutPanel()
        Me.CtlCopay1 = New AccuPoint.ctlCopay()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.sgDrugs = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.btnUpdateGrid = New DevComponents.DotNetBar.ButtonX()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel1.SuspendLayout()
        Me.ctlPanel.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
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
        Me.SideNav1.Size = New System.Drawing.Size(1270, 912)
        Me.SideNav1.TabIndex = 0
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.Controls.Add(Me.ctlPanel)
        Me.SideNavPanel1.Controls.Add(Me.PanelEx1)
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.Location = New System.Drawing.Point(77, 37)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(1188, 874)
        Me.SideNavPanel1.TabIndex = 2
        '
        'ctlPanel
        '
        Me.ctlPanel.AutoScroll = True
        Me.ctlPanel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ctlPanel.Controls.Add(Me.CtlCopay1)
        Me.ctlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlPanel.Location = New System.Drawing.Point(0, 554)
        Me.ctlPanel.Name = "ctlPanel"
        Me.ctlPanel.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ctlPanel.Size = New System.Drawing.Size(1188, 320)
        Me.ctlPanel.TabIndex = 8
        '
        'CtlCopay1
        '
        Me.CtlCopay1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CtlCopay1.Location = New System.Drawing.Point(3, 13)
        Me.CtlCopay1.Name = "CtlCopay1"
        Me.CtlCopay1.Padding = New System.Windows.Forms.Padding(3)
        Me.CtlCopay1.Size = New System.Drawing.Size(990, 376)
        Me.CtlCopay1.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.sgDrugs)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1188, 554)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "PanelEx1"
        '
        'sgDrugs
        '
        Me.sgDrugs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sgDrugs.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.sgDrugs.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.sgDrugs.Location = New System.Drawing.Point(0, 35)
        Me.sgDrugs.Name = "sgDrugs"
        '
        '
        '
        Me.sgDrugs.PrimaryGrid.EnableColumnFiltering = True
        Me.sgDrugs.PrimaryGrid.EnableFiltering = True
        Me.sgDrugs.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.sgDrugs.PrimaryGrid.Filter.Visible = True
        Me.sgDrugs.PrimaryGrid.KeyboardEditMode = DevComponents.DotNetBar.SuperGrid.KeyboardEditMode.EditOnEntry
        Me.sgDrugs.PrimaryGrid.MouseEditMode = DevComponents.DotNetBar.SuperGrid.MouseEditMode.SingleClick
        Me.sgDrugs.PrimaryGrid.MultiSelect = False
        Me.sgDrugs.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight
        Me.sgDrugs.Size = New System.Drawing.Size(1188, 519)
        Me.sgDrugs.TabIndex = 0
        Me.sgDrugs.Text = "SuperGridControl1"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.btnUpdateGrid)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1188, 35)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
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
        'btnUpdateGrid
        '
        Me.btnUpdateGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdateGrid.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnUpdateGrid.Enabled = False
        Me.btnUpdateGrid.Location = New System.Drawing.Point(492, 6)
        Me.btnUpdateGrid.Name = "btnUpdateGrid"
        Me.btnUpdateGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateGrid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUpdateGrid.TabIndex = 0
        Me.btnUpdateGrid.Text = "Update"
        '
        'frmDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 912)
        Me.Controls.Add(Me.SideNav1)
        Me.DoubleBuffered = True
        Me.Name = "frmDrugs"
        Me.Text = "frmDrugs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.SideNavPanel1.ResumeLayout(False)
        Me.ctlPanel.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Friend WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents sgDrugs As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ctlPanel As CustomFlowLayoutPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CtlCopay1 As ctlCopay
    Friend WithEvents btnUpdateGrid As DevComponents.DotNetBar.ButtonX
End Class
