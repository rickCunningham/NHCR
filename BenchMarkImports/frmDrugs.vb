Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports AccuPoint


Public Class frmDrugs
    Dim loading As Boolean
    Dim GridNeedsUpdate As Boolean

    Private Sub frmDrugs_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshGrid()
    End Sub


    Private Sub RefreshGrid()
        loading = True
        btnUpdateGrid.Enabled = False


        If Not IsNothing(sgDrugs.PrimaryGrid.DataSource) Then
            Dim panel As GridPanel = sgDrugs.PrimaryGrid

            panel.ClearDirtyRowMarkers()
            panel.ClearAll()
            panel.DataSource = Nothing
        End If


        Dim drugs As DataTable = DBDrugs.GetDrugs()

        sgDrugs.PrimaryGrid.DataSource = drugs
        loading = False
        GridNeedsUpdate = False

    End Sub

    Private Sub sgDrugs_SelectionChanged(sender As Object, e As GridEventArgs) Handles sgDrugs.SelectionChanged
        If Not loading Then
            Dim x As Integer = 0

            Dim ActiveRow As GridRow = e.GridPanel.ActiveRow
            Dim DrugId As Integer = ActiveRow("DrugId").Value
            Dim BenchMarkID As Integer = ActiveRow("BenchMarkID").Value
            Dim CPTCode As String = ActiveRow("CPTCode").Value

            CtlCopay1.Activate(DrugId)
        End If
    End Sub

    Private Sub sgDrugs_DataBindingComplete(sender As Object, e As GridDataBindingCompleteEventArgs) Handles sgDrugs.DataBindingComplete
        Dim panel As GridPanel = DirectCast(DirectCast(sender, SuperGridControl).PrimaryGrid, GridPanel)

        For Each column As GridColumn In panel.Columns


            Select Case True
                Case column.Name.ToUpper.Contains("ID")
                    column.Visible = False
                Case column.Name.ToUpper.Contains("FEE")
                    column.EditorType = GetType(MyCurrencyEditControl)
                    column.CellStyles.[Default].Alignment = Alignment.MiddleRight
                Case column.Name.ToUpper.Contains("QTY")
                    column.CellStyles.[Default].Alignment = Alignment.MiddleRight
                Case column.Name.ToUpper.Contains("INVENTORY") Or column.Name.ToUpper.Contains("UNIT") Or column.Name.ToUpper.Contains("CPT")
                    column.CellStyles.[Default].Alignment = Alignment.MiddleCenter

            End Select


            column.CellStyles.[Default].Padding = New Style.Padding(5, 0, 5, 0)


        Next
        panel.ColumnAutoSizeMode = ColumnAutoSizeMode.AllCells
    End Sub

    Private Sub sgDrugs_CellValueChanged(sender As Object, e As GridCellValueChangedEventArgs) Handles sgDrugs.CellValueChanged
        Dim x As Integer = 0

        GridNeedsUpdate = True
        btnUpdateGrid.Enabled = GridNeedsUpdate

    End Sub

    Private Sub btnUpdateGrid_Click(sender As Object, e As EventArgs) Handles btnUpdateGrid.Click

        Dim UpdateTable As DataTable = DirectCast(sgDrugs.PrimaryGrid.DataSource, DataTable).Clone
        Dim Rows = (From items In sgDrugs.PrimaryGrid.FlatDirtyRows
                    Select items).ToList
        Dim result As New DataTable
        If Rows.Count > 0 Then
            For Each item As GridRow In Rows
                Dim UpdateRow As DataRow = DirectCast(item.DataItem, DataRowView).Row
                UpdateTable.ImportRow(UpdateRow)
            Next
        End If
        If UpdateTable.Rows.Count > 0 Then
            DBDrugs.UpdateMasterDrugCatalog(UpdateTable)
        End If

        Dim msg As String = String.Format("{0} Items have been updated", UpdateTable.Rows.Count)

        MessageBox.Show(msg)
        RefreshGrid()
    End Sub
End Class

Public Class MyCurrencyEditControl
    Inherits GridDoubleInputEditControl
    Public Sub New()
        DisplayFormat = "C"
    End Sub
End Class