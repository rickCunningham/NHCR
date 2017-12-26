<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDrugLineItem
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
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.lblExtendedPrice = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dblUnitPrice = New DevComponents.Editors.DoubleInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cboVialQty = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.intOrderQty = New DevComponents.Editors.IntegerInput()
        Me.lblDrugName = New DevComponents.DotNetBar.LabelX()
        Me.ctlPanel.SuspendLayout()
        CType(Me.dblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intOrderQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ctlPanel
        '
        Me.ctlPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ctlPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ctlPanel.Controls.Add(Me.btnDelete)
        Me.ctlPanel.Controls.Add(Me.lblExtendedPrice)
        Me.ctlPanel.Controls.Add(Me.LabelX3)
        Me.ctlPanel.Controls.Add(Me.dblUnitPrice)
        Me.ctlPanel.Controls.Add(Me.LabelX2)
        Me.ctlPanel.Controls.Add(Me.cboVialQty)
        Me.ctlPanel.Controls.Add(Me.LabelX1)
        Me.ctlPanel.Controls.Add(Me.intOrderQty)
        Me.ctlPanel.Controls.Add(Me.lblDrugName)
        Me.ctlPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.ctlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlPanel.Location = New System.Drawing.Point(1, 1)
        Me.ctlPanel.Name = "ctlPanel"
        Me.ctlPanel.Padding = New System.Windows.Forms.Padding(5, 7, 5, 5)
        Me.ctlPanel.Size = New System.Drawing.Size(681, 33)
        Me.ctlPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ctlPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me.ctlPanel.Style.BackColor2.Color = System.Drawing.Color.White
        Me.ctlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ctlPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ctlPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.ctlPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ctlPanel.Style.GradientAngle = 90
        Me.ctlPanel.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.Image = Global.AccuPoint.My.Resources.Resources.Delete
        Me.btnDelete.Location = New System.Drawing.Point(634, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(42, 21)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 13
        '
        'lblExtendedPrice
        '
        '
        '
        '
        Me.lblExtendedPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblExtendedPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblExtendedPrice.Location = New System.Drawing.Point(493, 7)
        Me.lblExtendedPrice.Name = "lblExtendedPrice"
        Me.lblExtendedPrice.PaddingRight = 75
        Me.lblExtendedPrice.Size = New System.Drawing.Size(141, 21)
        Me.lblExtendedPrice.TabIndex = 12
        Me.lblExtendedPrice.Text = "LabelX4"
        Me.lblExtendedPrice.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX3.Location = New System.Drawing.Point(429, 7)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(64, 21)
        Me.LabelX3.TabIndex = 11
        '
        'dblUnitPrice
        '
        '
        '
        '
        Me.dblUnitPrice.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dblUnitPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dblUnitPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dblUnitPrice.DisplayFormat = "c"
        Me.dblUnitPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.dblUnitPrice.Increment = 1.0R
        Me.dblUnitPrice.Location = New System.Drawing.Point(355, 7)
        Me.dblUnitPrice.Name = "dblUnitPrice"
        Me.dblUnitPrice.ShowUpDown = True
        Me.dblUnitPrice.Size = New System.Drawing.Size(74, 20)
        Me.dblUnitPrice.TabIndex = 10
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX2.Location = New System.Drawing.Point(318, 7)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(37, 21)
        Me.LabelX2.TabIndex = 9
        '
        'cboVialQty
        '
        Me.cboVialQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVialQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVialQty.DisplayMember = "Text"
        Me.cboVialQty.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboVialQty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVialQty.FormattingEnabled = True
        Me.cboVialQty.ItemHeight = 15
        Me.cboVialQty.Location = New System.Drawing.Point(243, 7)
        Me.cboVialQty.Name = "cboVialQty"
        Me.cboVialQty.Size = New System.Drawing.Size(75, 21)
        Me.cboVialQty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVialQty.TabIndex = 8
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX1.Location = New System.Drawing.Point(206, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(37, 21)
        Me.LabelX1.TabIndex = 7
        '
        'intOrderQty
        '
        '
        '
        '
        Me.intOrderQty.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.intOrderQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.intOrderQty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.intOrderQty.Dock = System.Windows.Forms.DockStyle.Left
        Me.intOrderQty.Location = New System.Drawing.Point(152, 7)
        Me.intOrderQty.Name = "intOrderQty"
        Me.intOrderQty.ShowUpDown = True
        Me.intOrderQty.Size = New System.Drawing.Size(54, 20)
        Me.intOrderQty.TabIndex = 5
        '
        'lblDrugName
        '
        Me.lblDrugName.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.lblDrugName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDrugName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDrugName.Location = New System.Drawing.Point(5, 7)
        Me.lblDrugName.Name = "lblDrugName"
        Me.lblDrugName.PaddingLeft = 5
        Me.lblDrugName.SingleLineColor = System.Drawing.Color.White
        Me.lblDrugName.Size = New System.Drawing.Size(147, 21)
        Me.lblDrugName.TabIndex = 0
        '
        'ctlDrugLineItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ctlPanel)
        Me.Name = "ctlDrugLineItem"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(683, 35)
        Me.ctlPanel.ResumeLayout(False)
        CType(Me.dblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intOrderQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ctlPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblDrugName As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblExtendedPrice As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dblUnitPrice As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboVialQty As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents intOrderQty As DevComponents.Editors.IntegerInput
End Class
