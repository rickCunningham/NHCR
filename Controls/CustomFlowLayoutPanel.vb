Imports System.Windows.Forms

Public Class CustomFlowLayoutPanel
    Inherits FlowLayoutPanel
    Public Sub New()
        MyBase.New()

        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
        AutoScroll = True

    End Sub

End Class

