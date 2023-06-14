Imports System.Data.OleDb

Public Class MB

    'الاتصال بقاعده البيانات 
    Dim Cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=  " & Application.StartupPath & "\magona2022.accdb ")

    Dim Cmd As New OleDbCommand("", Cn)
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter

    '==============******************////////89889+9-+96+464646464=====================
    ' last tonjra

    Sub last_tonjra()
        Try

            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            dt.Clear()
            da = New OleDbDataAdapter("SELECT Last(tonjra_info.ID) AS LastمنID, Last(tonjra_info.tonjra_total) AS Lastمنtonjra_total
FROM tonjra_info;
", Cn)
            da.Fill(dt)

            '===========================

            Dim cmd As OleDbCommand
            Dim ds As DataSet
            Dim bs As BindingSource
            Dim sqlstr As String

            '======================  SELECT tonjra_info.ID, tonjra_info.tonjra_total From tonjra_info Order By tonjra_info.ID DESC;
            sqlstr = "SELECT tonjra_info.ID, tonjra_info.tonjra_total From tonjra_info Order By tonjra_info.ID DESC;"

            'sqlstr = "SELECT * From tonjra_info"
            cmd = New OleDbCommand(sqlstr, Cn)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "tonjra_info")

            bs = New BindingSource
            bs.DataSource = ds.Tables("tonjra_info")

            txt_lastT.DataBindings.Clear()
            txt_lastT.DataBindings.Add("text", bs, "tonjra_total")

            Cn.Close()
        Catch ex As Exception
            If Cn.State = ConnectionState.Open Then Cn.Close()
            MsgBox(ex.Message)
        End Try



    End Sub
    '==============******************///////5564564646464646464646=====================







    '================================
    Public Function GetMaxID()
        Dim dt As New DataTable
        Dim adp As OleDbDataAdapter
        dt.Clear()
        adp = New OleDbDataAdapter("select MAX(ID) from sales", Cn)
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
        da = New OleDbDataAdapter("select * from sales", Cn)
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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        firstShow.Show()
    End Sub

    Private Sub MB_Load(sender As Object, e As EventArgs) Handles Me.Load


        load_data()


        txt_ID.Text = GetMaxID()
        txt_lastT.Text = tonjra.LsOn.Text
        txt_data.Text = DateTimePicker1.Value.ToString("dd/MM/yyyy")

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Columns(0).Width = 50
        'كود لتوسيط الاعمدة
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ''كود لتوسيط العناوين
        'DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ''-=-=-=-=-=----*/*/*/*/*/*/*/*/*/*/***********************
        'DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(0)

        last_tonjra()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim pos As String = BindingContext(dt).Position
            dt.Rows(pos).Item(0) = txt_ID.Text ' ID الترقيم
            dt.Rows(pos).Item(1) = DateTimePicker1.Value.ToString("dd/MM/yyyy") 'Sold_dataTime  تاريخ البيع
            dt.Rows(pos).Item(2) = txt_lastT.Text 'tonjra_total  تكلفة الطنجرة
            dt.Rows(pos).Item(3) = txt_count.Text 'Quantity    عدد المباع
            dt.Rows(pos).Item(4) = cmb_kind.SelectedItem.ToString 'type نوع المباع
            dt.Rows(pos).Item(5) = txt_Mony.Text 'mony_Sold    ثمن المباع
            dt.Rows(pos).Item(6) = ComboBox1.SelectedItem.ToString 'receipt استلام
            save_data()
            load_data()
            MessageBox.Show(" تم حفظ التعديل الجديد في جدول sales  ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Update()
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString) '
        End Try

        save_data()
        load_data()
        DataGridView1.Update()
        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim FR As String
        Dim FH As String
        Dim somNos As Double
        Dim somRob As Double

        somNos = Val(txt_nos.Text)
        somRob = Val(txt_roba.Text)

        ' Dim FF As String
        If cmb_kind.Text = "ربع" Then

            FR = Val(txt_count.Text) * somRob

            txt_Mony.Text = String.Format("{0:c}", FR)
        Else
            cmb_kind.Text = "نص"
            ' Dim FH As String
            FH = Val(txt_count.Text) * somNos
            txt_Mony.Text = String.Format("{0:c}", FH)

        End If
        'txt_total_buy
        If cmb_kind.Text = "ربع" Then

            FR = Val(txt_count.Text) * somRob

            txt_Mony.Text = String.Format("{0:c}", FR)
        Else
            cmb_kind.Text = "نص"
            ' Dim FH As String
            FH = Val(txt_count.Text) * somNos
            txt_Mony.Text = String.Format("{0:c}", FH)

        End If
        ' txt_total_buy.Text = Val(txt_buy1.Text) + Val(txt_buy2.Text)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class