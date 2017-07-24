Imports DevComponents.DotNetBar

Public Class frmNav

    Enum forms
        Import
        Schedule
        Drugs
        Patients

    End Enum


    Private Loading As Boolean


    Private Sub frmNav_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loading = True
        Dim FormList As New List(Of FormItems)
        FormList.Add(New FormItems With {.ValueMember = forms.Import, .DisplayMember = "Imports"})
        FormList.Add(New FormItems With {.ValueMember = forms.Schedule, .DisplayMember = "Scheduler"})
        FormList.Add(New FormItems With {.ValueMember = forms.Drugs, .DisplayMember = "Drugs"})
        FormList.Add(New FormItems With {.ValueMember = forms.Patients, .DisplayMember = "Patients"})

        ComboBoxEx1.DataSource = FormList
        ComboBoxEx1.ValueMember = "ValueMember"
        ComboBoxEx1.DisplayMember = "DisplayMember"
        ComboBoxEx1.SelectedIndex = -1
        Loading = False


    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If Not Loading Then

            Dim f As New OfficeForm
            Select Case ComboBoxEx1.SelectedValue
                Case forms.Import
                    f = New frmImports
                Case forms.Schedule
                    f = New frmScheduler
                Case forms.Drugs
                    f = New frmDrugs
                Case forms.Patients
                    f = New frmPatients
            End Select
            f.ShowDialog()
        End If
    End Sub
End Class

Public Class FormItems
    Public Property ValueMember As Integer
    Public Property DisplayMember As String
End Class