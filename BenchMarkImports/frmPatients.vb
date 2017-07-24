Imports DevComponents.DotNetBar.SuperGrid

Public Class frmPatients

    Dim loading As Boolean

    Dim ChartType As String


    Private Sub btnGetPatients_Click(sender As Object, e As EventArgs) Handles btnGetPatients.Click
        loading = True
        Dim dt As New DataTable




        dt = DBPatients.GetPatients(ChartType)


        sgPatients.PrimaryGrid.DataSource = dt


        loading = False

    End Sub

    Private Sub rdoAllergy_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllergy.CheckedChanged, rdoAll.CheckedChanged, rdoInfusion.CheckedChanged
        If sender.Checked Then
            ChartType = CStr(sender.tag)

            If ChartType.Length = 0 Then ChartType = String.Empty
        End If

    End Sub


    'TODO Code DefaultOrder

    Private Sub sgPatients_SelectionChanged(sender As Object, e As GridEventArgs) Handles sgPatients.SelectionChanged

        If Not loading Then
            Dim x As Integer = 0

            Dim ActiveRow As GridRow = e.GridPanel.ActiveRow
            Dim AcctNum As Integer = ActiveRow("AcctNum").Value


            CtlPatientDrugOrder1.Activate(AcctNum)
        End If

    End Sub
End Class