Imports DevComponents.DotNetBar

Public Class frmNav

    Enum Forms
        Import
        Schedule
        Drugs
        Patients

    End Enum


    Private Loading As Boolean


    Private Sub frmNav_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loading = True
        Dim FormList As New List(Of FormItems)
        FormList.Add(New FormItems With {.ValueMember = Forms.Import, .DisplayMember = "Imports"})
        FormList.Add(New FormItems With {.ValueMember = Forms.Schedule, .DisplayMember = "Scheduler"})
        FormList.Add(New FormItems With {.ValueMember = Forms.Drugs, .DisplayMember = "Drugs"})
        FormList.Add(New FormItems With {.ValueMember = Forms.Patients, .DisplayMember = "Patients"})

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
                Case Forms.Import
                    f = New frmImports
                Case Forms.Schedule
                    f = New frmScheduler
                Case Forms.Drugs
                    f = New frmDrugs
                Case Forms.Patients
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