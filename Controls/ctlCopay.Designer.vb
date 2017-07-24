<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctlCopay
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblName = New DevComponents.DotNetBar.LabelX()
        Me.chkCopay = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cboMfg = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cboSupplier = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtPayer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPaymentCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dblCopayMax = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cboOrderCompany = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.chkBenefits = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.cboCategory = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.cboStorage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ctlPanel = New DevComponents.DotNetBar.PanelEx()
        Me.txtAcctCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.txtAthemCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.btnPanel = New DevComponents.DotNetBar.PanelEx()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.vialPanel = New DevComponents.DotNetBar.PanelEx()
        Me.vialList = New DevComponents.DotNetBar.ListBoxAdv()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.tknVial = New DevComponents.DotNetBar.Controls.TokenEditor()
        CType(Me.dblCopayMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctlPanel.SuspendLayout()
        Me.btnPanel.SuspendLayout()
        Me.vialPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        '
        '
        '
        Me.lblName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Location = New System.Drawing.Point(3, 3)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(991, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "LabelX1"
        Me.lblName.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chkCopay
        '
        '
        '
        '
        Me.chkCopay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkCopay.Location = New System.Drawing.Point(26, 65)
        Me.chkCopay.Name = "chkCopay"
        Me.chkCopay.Size = New System.Drawing.Size(141, 23)
        Me.chkCopay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkCopay.TabIndex = 2
        Me.chkCopay.Text = "Has CoPay Assistance"
        '
        'cboMfg
        '
        Me.cboMfg.DisplayMember = "Text"
        Me.cboMfg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMfg.FormattingEnabled = True
        Me.cboMfg.ItemHeight = 14
        Me.cboMfg.Location = New System.Drawing.Point(97, 189)
        Me.cboMfg.Name = "cboMfg"
        Me.cboMfg.Size = New System.Drawing.Size(166, 20)
        Me.cboMfg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboMfg.TabIndex = 7
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(20, 185)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(71, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Manufacturer"
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "Text"
        Me.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.ItemHeight = 14
        Me.cboSupplier.Location = New System.Drawing.Point(348, 189)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(166, 20)
        Me.cboSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboSupplier.TabIndex = 8
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(292, 188)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(50, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Supplier"
        '
        'txtPayer
        '
        '
        '
        '
        Me.txtPayer.Border.Class = "TextBoxBorder"
        Me.txtPayer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPayer.Location = New System.Drawing.Point(97, 97)
        Me.txtPayer.Name = "txtPayer"
        Me.txtPayer.PreventEnterBeep = True
        Me.txtPayer.Size = New System.Drawing.Size(128, 20)
        Me.txtPayer.TabIndex = 4
        '
        'txtPaymentCode
        '
        '
        '
        '
        Me.txtPaymentCode.Border.Class = "TextBoxBorder"
        Me.txtPaymentCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPaymentCode.Location = New System.Drawing.Point(348, 98)
        Me.txtPaymentCode.Name = "txtPaymentCode"
        Me.txtPaymentCode.PreventEnterBeep = True
        Me.txtPaymentCode.Size = New System.Drawing.Size(134, 20)
        Me.txtPaymentCode.TabIndex = 5
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(26, 94)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(65, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Copay Payer"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(231, 95)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(111, 23)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Copay Payment Code"
        '
        'dblCopayMax
        '
        '
        '
        '
        Me.dblCopayMax.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dblCopayMax.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dblCopayMax.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dblCopayMax.DisplayFormat = "C"
        Me.dblCopayMax.Increment = 1.0R
        Me.dblCopayMax.Location = New System.Drawing.Point(97, 130)
        Me.dblCopayMax.MinValue = 0R
        Me.dblCopayMax.Name = "dblCopayMax"
        Me.dblCopayMax.ShowUpDown = True
        Me.dblCopayMax.Size = New System.Drawing.Size(128, 20)
        Me.dblCopayMax.TabIndex = 6
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(25, 127)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(66, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Copay Max"
        '
        'cboOrderCompany
        '
        Me.cboOrderCompany.DisplayMember = "Text"
        Me.cboOrderCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrderCompany.FormattingEnabled = True
        Me.cboOrderCompany.ItemHeight = 14
        Me.cboOrderCompany.Location = New System.Drawing.Point(97, 230)
        Me.cboOrderCompany.Name = "cboOrderCompany"
        Me.cboOrderCompany.Size = New System.Drawing.Size(166, 20)
        Me.cboOrderCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboOrderCompany.TabIndex = 9
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 227)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(85, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Order Company"
        '
        'chkBenefits
        '
        '
        '
        '
        Me.chkBenefits.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkBenefits.Location = New System.Drawing.Point(173, 66)
        Me.chkBenefits.Name = "chkBenefits"
        Me.chkBenefits.Size = New System.Drawing.Size(141, 23)
        Me.chkBenefits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkBenefits.TabIndex = 3
        Me.chkBenefits.Text = "Benefit Verification"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(4, 154)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(545, 23)
        Me.Line1.TabIndex = 15
        Me.Line1.Text = "Line1"
        '
        'cboCategory
        '
        Me.cboCategory.DisplayMember = "Text"
        Me.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.ItemHeight = 14
        Me.cboCategory.Location = New System.Drawing.Point(84, 284)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(166, 20)
        Me.cboCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCategory.TabIndex = 10
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(6, 281)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(72, 23)
        Me.LabelX8.TabIndex = 17
        Me.LabelX8.Text = "Drug Category"
        '
        'cboStorage
        '
        Me.cboStorage.DisplayMember = "Text"
        Me.cboStorage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStorage.FormattingEnabled = True
        Me.cboStorage.ItemHeight = 14
        Me.cboStorage.Location = New System.Drawing.Point(360, 283)
        Me.cboStorage.Name = "cboStorage"
        Me.cboStorage.Size = New System.Drawing.Size(166, 20)
        Me.cboStorage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboStorage.TabIndex = 11
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(269, 281)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(85, 23)
        Me.LabelX9.TabIndex = 19
        Me.LabelX9.Text = "Storage Location"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(26, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(66, 23)
        Me.LabelX1.TabIndex = 21
        Me.LabelX1.Text = "Acctg. Code"
        '
        'ctlPanel
        '
        Me.ctlPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ctlPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ctlPanel.Controls.Add(Me.txtAcctCode)
        Me.ctlPanel.Controls.Add(Me.Line3)
        Me.ctlPanel.Controls.Add(Me.LabelX10)
        Me.ctlPanel.Controls.Add(Me.txtAthemCode)
        Me.ctlPanel.Controls.Add(Me.LabelX1)
        Me.ctlPanel.Controls.Add(Me.LabelX9)
        Me.ctlPanel.Controls.Add(Me.cboStorage)
        Me.ctlPanel.Controls.Add(Me.LabelX8)
        Me.ctlPanel.Controls.Add(Me.cboCategory)
        Me.ctlPanel.Controls.Add(Me.chkBenefits)
        Me.ctlPanel.Controls.Add(Me.LabelX7)
        Me.ctlPanel.Controls.Add(Me.cboOrderCompany)
        Me.ctlPanel.Controls.Add(Me.LabelX6)
        Me.ctlPanel.Controls.Add(Me.dblCopayMax)
        Me.ctlPanel.Controls.Add(Me.LabelX5)
        Me.ctlPanel.Controls.Add(Me.LabelX4)
        Me.ctlPanel.Controls.Add(Me.txtPaymentCode)
        Me.ctlPanel.Controls.Add(Me.txtPayer)
        Me.ctlPanel.Controls.Add(Me.LabelX3)
        Me.ctlPanel.Controls.Add(Me.cboSupplier)
        Me.ctlPanel.Controls.Add(Me.LabelX2)
        Me.ctlPanel.Controls.Add(Me.cboMfg)
        Me.ctlPanel.Controls.Add(Me.chkCopay)
        Me.ctlPanel.Controls.Add(Me.Line2)
        Me.ctlPanel.Controls.Add(Me.Line1)
        Me.ctlPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.ctlPanel.Location = New System.Drawing.Point(3, 23)
        Me.ctlPanel.Name = "ctlPanel"
        Me.ctlPanel.Size = New System.Drawing.Size(549, 316)
        Me.ctlPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ctlPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ctlPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ctlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ctlPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ctlPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ctlPanel.Style.GradientAngle = 90
        Me.ctlPanel.TabIndex = 0
        '
        'txtAcctCode
        '
        '
        '
        '
        Me.txtAcctCode.Border.Class = "TextBoxBorder"
        Me.txtAcctCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAcctCode.Location = New System.Drawing.Point(91, 19)
        Me.txtAcctCode.Name = "txtAcctCode"
        Me.txtAcctCode.PreventEnterBeep = True
        Me.txtAcctCode.Size = New System.Drawing.Size(97, 20)
        Me.txtAcctCode.TabIndex = 0
        Me.txtAcctCode.WatermarkText = "###.##"
        '
        'Line3
        '
        Me.Line3.Location = New System.Drawing.Point(3, 255)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(545, 23)
        Me.Line3.TabIndex = 26
        Me.Line3.Text = "Line3"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(215, 16)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(111, 23)
        Me.LabelX10.TabIndex = 24
        Me.LabelX10.Text = "Anthem Admin Code"
        '
        'txtAthemCode
        '
        '
        '
        '
        Me.txtAthemCode.Border.Class = "TextBoxBorder"
        Me.txtAthemCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAthemCode.Location = New System.Drawing.Point(332, 17)
        Me.txtAthemCode.Name = "txtAthemCode"
        Me.txtAthemCode.PreventEnterBeep = True
        Me.txtAthemCode.Size = New System.Drawing.Size(134, 20)
        Me.txtAthemCode.TabIndex = 1
        '
        'Line2
        '
        Me.Line2.Location = New System.Drawing.Point(3, 45)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(546, 23)
        Me.Line2.TabIndex = 25
        Me.Line2.Text = "Line2"
        '
        'btnPanel
        '
        Me.btnPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.btnPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPanel.Controls.Add(Me.btnSave)
        Me.btnPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPanel.Location = New System.Drawing.Point(3, 341)
        Me.btnPanel.Name = "btnPanel"
        Me.btnPanel.Size = New System.Drawing.Size(991, 32)
        Me.btnPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.btnPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.btnPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.btnPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.btnPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.btnPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.btnPanel.Style.GradientAngle = 90
        Me.btnPanel.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btnSave.Image = Global.AccuPoint.My.Resources.Resources.Save1
        Me.btnSave.Location = New System.Drawing.Point(450, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 28)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'vialPanel
        '
        Me.vialPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.vialPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.vialPanel.Controls.Add(Me.LabelX12)
        Me.vialPanel.Controls.Add(Me.LabelX11)
        Me.vialPanel.Controls.Add(Me.vialList)
        Me.vialPanel.Controls.Add(Me.tknVial)
        Me.vialPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.vialPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vialPanel.Location = New System.Drawing.Point(3, 3)
        Me.vialPanel.Name = "vialPanel"
        Me.vialPanel.Size = New System.Drawing.Size(991, 370)
        Me.vialPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.vialPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.vialPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.vialPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.vialPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.vialPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.vialPanel.Style.GradientAngle = 90
        Me.vialPanel.TabIndex = 11
        Me.vialPanel.Text = "PanelEx1"
        '
        'vialList
        '
        Me.vialList.AutoScroll = True
        '
        '
        '
        Me.vialList.BackgroundStyle.Class = "ListBoxAdv"
        Me.vialList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.vialList.ContainerControlProcessDialogKey = True
        Me.vialList.DragDropSupport = True
        Me.vialList.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.vialList.Location = New System.Drawing.Point(556, 65)
        Me.vialList.Name = "vialList"
        Me.vialList.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.vialList.Size = New System.Drawing.Size(200, 258)
        Me.vialList.TabIndex = 1
        Me.vialList.Text = "ListBoxAdv1"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(811, 39)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(124, 23)
        Me.LabelX12.TabIndex = 3
        Me.LabelX12.Text = "Available Vials"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(600, 37)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(96, 23)
        Me.LabelX11.TabIndex = 2
        Me.LabelX11.Text = "Assigned Vials"
        '
        'tknVial
        '
        '
        '
        '
        Me.tknVial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tknVial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tknVial.CheckBoxesVisible = True
        Me.tknVial.DropDownButtonVisible = True
        Me.tknVial.Location = New System.Drawing.Point(772, 65)
        Me.tknVial.Name = "tknVial"
        Me.tknVial.Separators.Add(";")
        Me.tknVial.Separators.Add(",")
        Me.tknVial.Size = New System.Drawing.Size(209, 21)
        Me.tknVial.TabIndex = 0
        '
        'ctlCopay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.ctlPanel)
        Me.Controls.Add(Me.btnPanel)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.vialPanel)
        Me.Name = "ctlCopay"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(997, 376)
        CType(Me.dblCopayMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctlPanel.ResumeLayout(False)
        Me.btnPanel.ResumeLayout(False)
        Me.vialPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkCopay As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cboMfg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboSupplier As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPayer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPaymentCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dblCopayMax As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboOrderCompany As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkBenefits As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents cboCategory As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboStorage As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ctlPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAthemCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents btnPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents vialPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtAcctCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents vialList As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents tknVial As DevComponents.DotNetBar.Controls.TokenEditor
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
End Class
