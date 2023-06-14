Imports System.Data.OleDb
Public Class frmEditTaklfa
    Dim Cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=  " & Application.StartupPath & "\MG.accdb ")
    Dim da As New OleDbDataAdapter()
    Dim dt As New DataTable

    Public Function GetMaxID()
        Dim dt As New DataTable
        Dim adp As OleDbDataAdapter
        dt.Clear()
        adp = New OleDbDataAdapter("select MAX(ID) from MSHT", Cn)
        adp.Fill(dt)

        Dim autoNumber As Integer
        If IsDBNull(dt(0)(0)) = True Then
            autoNumber = 1
        Else
            autoNumber = dt(0)(0) + 1
        End If
        Return autoNumber
    End Function
    Sub load_data()
        dt.Clear()
        da = New OleDbDataAdapter("select * from MSHT", Cn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        GetMaxID()
    End Sub
    Sub save_data()
        Dim save As New OleDbCommandBuilder(da)
        save.QuotePrefix = "["
        save.QuoteSuffix = "]"
        da.Update(dt)
        dt.AcceptChanges()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        firstShow.Show()
    End Sub

    Private Sub SaveEdit_Click(sender As Object, e As EventArgs) Handles SaveEdit.Click
        Try

            Dim pos As String = BindingContext(dt).Position
            dt.Rows(pos).Item(0) = TextBox1.Text
            dt.Rows(pos).Item(1) = DateTimePicker1.Value.ToString("dd/MM/yyyy")
            dt.Rows(pos).Item(2) = ComboBox1.SelectedItem.ToString
            dt.Rows(pos).Item(3) = ComboBox2.SelectedItem.ToString
            dt.Rows(pos).Item(4) = TextBox2.Text
            save_data()
            load_data()
            MessageBox.Show(" تم حفظ التعديل الجديد", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Form1.dg2.Update()
            'Form1.dg2.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmEditTaklfa_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data()
        TextBox1.Text = GetMaxID()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Columns(0).Width = 50
        'كود لتوسيط الاعمدة
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'كود لتوسيط العناوين
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        '-=-=-=-=-=----*/*/*/*/*/*/*/*/*/*/***********************
        DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString


        Catch ex As Exception

        End Try
    End Sub
End Class