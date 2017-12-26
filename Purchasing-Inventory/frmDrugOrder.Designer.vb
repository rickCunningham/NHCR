<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDrugOrder
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.topPanel = New DevComponents.DotNetBar.PanelEx()
        Me.sidePanel = New DevComponents.DotNetBar.PanelEx()
        Me.contentPanel = New DevComponents.DotNetBar.PanelEx()
        Me.cboDrugs = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboSupplier = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.CustomFlowLayoutPanel1 = New AccuPoint.CustomFlowLayoutPanel()
        Me.HeaderPanel = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.contentPanel.SuspendLayout()
        Me.CustomFlowLayoutPanel1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.topPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.topPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1389, 65)
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
        'sidePanel
        '
        Me.sidePanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.sidePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sidePanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 65)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(200, 561)
        Me.sidePanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.sidePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.sidePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.sidePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sidePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.sidePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.sidePanel.Style.GradientAngle = 90
        Me.sidePanel.TabIndex = 7
        Me.sidePanel.Text = "PanelEx2"
        '
        'contentPanel
        '
        Me.contentPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.contentPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.contentPanel.Controls.Add(Me.CustomFlowLayoutPanel1)
        Me.contentPanel.Controls.Add(Me.LabelX2)
        Me.contentPanel.Controls.Add(Me.cboDrugs)
        Me.contentPanel.Controls.Add(Me.cboSupplier)
        Me.contentPanel.Controls.Add(Me.LabelX1)
        Me.contentPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(200, 65)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1189, 561)
        Me.contentPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.contentPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.contentPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.contentPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.contentPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.contentPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.contentPanel.Style.GradientAngle = 90
        Me.contentPanel.TabIndex = 11
        Me.contentPanel.Text = "PanelEx3"
        '
        'cboDrugs
        '
        Me.cboDrugs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDrugs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDrugs.DisplayMember = "Text"
        Me.cboDrugs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDrugs.FormattingEnabled = True
        Me.cboDrugs.ItemHeight = 15
        Me.cboDrugs.Location = New System.Drawing.Point(44, 75)
        Me.cboDrugs.Name = "cboDrugs"
        Me.cboDrugs.Size = New System.Drawing.Size(245, 21)
        Me.cboDrugs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboDrugs.TabIndex = 3
        '
        'cboSupplier
        '
        Me.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSupplier.DisplayMember = "Text"
        Me.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.ItemHeight = 15
        Me.cboSupplier.Location = New System.Drawing.Point(44, 34)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(245, 21)
        Me.cboSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboSupplier.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(44, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(245, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Choose Supplier"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Image = Global.AccuPoint.My.Resources.Resources.Plus
        Me.LabelX2.Location = New System.Drawing.Point(296, 72)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "LabelX2"
        '
        'CustomFlowLayoutPanel1
        '
        Me.CustomFlowLayoutPanel1.AutoScroll = True
        Me.CustomFlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.CustomFlowLayoutPanel1.Controls.Add(Me.HeaderPanel)
        Me.CustomFlowLayoutPanel1.Location = New System.Drawing.Point(44, 117)
        Me.CustomFlowLayoutPanel1.Name = "CustomFlowLayoutPanel1"
        Me.CustomFlowLayoutPanel1.Size = New System.Drawing.Size(706, 432)
        Me.CustomFlowLayoutPanel1.TabIndex = 5
        '
        'HeaderPanel
        '
        Me.HeaderPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.HeaderPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.HeaderPanel.Controls.Add(Me.LabelX7)
        Me.HeaderPanel.Controls.Add(Me.LabelX6)
        Me.HeaderPanel.Controls.Add(Me.LabelX5)
        Me.HeaderPanel.Controls.Add(Me.LabelX4)
        Me.HeaderPanel.Controls.Add(Me.LabelX3)
        Me.HeaderPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(3, 3)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(678, 28)
        Me.HeaderPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.HeaderPanel.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.HeaderPanel.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.HeaderPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.HeaderPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.HeaderPanel.Style.GradientAngle = 90
        Me.HeaderPanel.TabIndex = 0
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX7.FontBold = True
        Me.LabelX7.Location = New System.Drawing.Point(478, 0)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.PaddingLeft = 20
        Me.LabelX7.Size = New System.Drawing.Size(200, 28)
        Me.LabelX7.TabIndex = 4
        Me.LabelX7.Text = "Extended Price"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX6.FontBold = True
        Me.LabelX6.Location = New System.Drawing.Point(354, 0)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(124, 28)
        Me.LabelX6.TabIndex = 3
        Me.LabelX6.Text = "Unit Price"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX5.FontBold = True
        Me.LabelX5.Location = New System.Drawing.Point(226, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.PaddingLeft = 20
        Me.LabelX5.Size = New System.Drawing.Size(128, 28)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "Vial Amount"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX4.FontBold = True
        Me.LabelX4.Location = New System.Drawing.Point(153, 0)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(73, 28)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Order Qty"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX3.FontBold = True
        Me.LabelX3.Location = New System.Drawing.Point(0, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.PaddingLeft = 15
        Me.LabelX3.Size = New System.Drawing.Size(153, 28)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Drug"
        '
        'frmDrugOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 626)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topPanel)
        Me.DoubleBuffered = True
        Me.Name = "frmDrugOrder"
        Me.Text = "frmDrugOrder"
        Me.contentPanel.ResumeLayout(False)
        Me.CustomFlowLayoutPanel1.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents sidePanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents contentPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboSupplier As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboDrugs As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CustomFlowLayoutPanel1 As CustomFlowLayoutPanel
    Friend WithEvents HeaderPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
