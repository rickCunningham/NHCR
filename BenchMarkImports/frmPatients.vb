Imports AccuPoint
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

    Private Function GetProviderName(ByVal ProviderID As Integer) As String

    End Function


    Private Sub CtlPatientDrugOrder1_ProviderContact_Clicked(sender As Object, e As ProviderInfoArgs) Handles CtlPatientDrugOrder1.ProviderContact_Clicked


        Dim msg As String = String.Format("Provider Clicked is : {0}", GetProviderName(e.ProviderID))
        'MessageBox.Show()
    End Sub
End Class