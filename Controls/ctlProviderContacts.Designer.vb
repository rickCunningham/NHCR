<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlProviderContacts
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
        Me.SuspendLayout()
        '
        'ctlPanel
        '
        Me.ctlPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ctlPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ctlPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.ctlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlPanel.Location = New System.Drawing.Point(5, 5)
        Me.ctlPanel.Name = "ctlPanel"
        Me.ctlPanel.Size = New System.Drawing.Size(1212, 448)
        Me.ctlPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ctlPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ctlPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ctlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ctlPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ctlPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ctlPanel.Style.GradientAngle = 90
        Me.ctlPanel.TabIndex = 0
        Me.ctlPanel.Text = "PanelEx1"
        '
        'ctlProviderContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.ctlPanel)
        Me.Name = "ctlProviderContacts"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(1222, 458)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ctlPanel As DevComponents.DotNetBar.PanelEx
End Class
