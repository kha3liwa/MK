Imports System.Data.OleDb
Public Class tonjra

    Dim Cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=  " & Application.StartupPath & "\magona2022.accdb ")
    Dim Cmd As New OleDbCommand("", Cn)
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter


    Public Function GetMaxID_tonjra()
        Dim dt As New DataTable
        Dim adp As OleDbDataAdapter
        dt.Clear()
        adp = New OleDbDataAdapter("select MAX(ID) from tonjra_info", Cn)
        adp.Fill(dt)

        Dim autoNumber As Integer
        If IsDBNull(dt(0)(0)) = True Then
            autoNumber = 1
        Else
            autoNumber = dt(0)(0) + 1
        End If
        Return autoNumber
    End Function
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

            LsOn.DataBindings.Clear()
            LsOn.DataBindings.Add("text", bs, "tonjra_total")

            Cn.Close()
        Catch ex As Exception
            If Cn.State = ConnectionState.Open Then Cn.Close()
            MsgBox(ex.Message)
        End Try



    End Sub
    Sub load_data()
        dt.Clear()
        da = New OleDbDataAdapter("select * from tonjra_info", Cn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        GetMaxID_tonjra()
    End Sub
    Sub save_data()
        Dim save As New OleDbCommandBuilder(da)
        save.QuotePrefix = "["
        save.QuoteSuffix = "]"
        da.Update(dt)
        dt.AcceptChanges()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        firstShow.Show()
        load_data()
    End Sub
    Sub runcommand(sqlcommand As String, Optional message As String = "")
        Try
            If Cn.State = ConnectionState.Closed Then Cn.Open()
            Cmd.CommandText = sqlcommand
            Cmd.ExecuteNonQuery()
            If message <> "" Then MsgBox(message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Cn.State = ConnectionState.Open Then Cn.Close()
        End Try
    End Sub
    Private Sub add_new_tonjra_Click(sender As Object, e As EventArgs) Handles add_new_tonjra.Click
        If Tangra_totalAll.Text = "" Then
            MessageBox.Show("كلفة الطنجرة كاملة فارغة")
        Else

            ' كود الترقيم التلقائي

            Cmd.CommandText = "Select Max(ID) from tonjra_info "
            Cmd.Connection = Cn
            If Cn.State = ConnectionState.Closed Then Cn.Open()

            Dim Maxtonjra As Integer = Val(Cmd.ExecuteScalar.ToString) + Val("1")

            runcommand("insert into tonjra_info values(" & txt_Max.Text & ",'" & DTP1.Text & "','" & Tangra_totalAll.Text & "')", "تم اضافة البيانات الجديدة بنجاح")
            'runcommand = "Insert into tonjra_info  values (@ID,@tonjra_data,@tonjra_total)", "newdata is added")
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
            Next
            save_data()
            load_data()
            GetMaxID_tonjra()
            txt_Max.Text = GetMaxID_tonjra()

        End If
    End Sub

    Private Sub tonjra_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_Max.Text = GetMaxID_tonjra()
        load_data()
        With DataGridView1


            .Columns("ID").HeaderText = "التسلسل"
            .Columns("ID").Width = 140
            .Columns("ID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ID").DefaultCellStyle.Font = New Font("Tahoma", 30)

            .Columns("tonjra_data").HeaderText = "تاريخ الطنجرة"
            .Columns("tonjra_data").Width = 140
            .Columns("tonjra_data").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tonjra_data").DefaultCellStyle.Font = New Font("Tahoma", 30)

            .Columns("tonjra_total").HeaderText = "تكلفة الطنجرة"
            .Columns("tonjra_total").Width = 140
            .Columns("tonjra_total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("tonjra_total").DefaultCellStyle.Font = New Font("Tahoma", 30)

        End With
        DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0)

        last_tonjra()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_takl_oli.Text = Val(txt_prise_oil.Text) / Val(txt_num_oli.Text)
        txt_takl_tom_gan.Text = Val(txt_prise_tom_gan.Text) / Val(txt_num_tom_gan.Text)
        txt_takl_tom_gsh.Text = Val(txt_prise_tom_gsh.Text) / Val(txt_num_tom_gsh.Text)
        txt_takl_paper.Text = Val(txt_prise_paper.Text) / Val(txt_num_paper.Text)
        txt_takl_galg.Text = Val(txt_prise_galg.Text) / Val(txt_num_galg.Text)
        txt_takl_onun.Text = Val(txt_prise_onun.Text) / Val(txt_num_onun.Text)
        txt_takl_FR.Text = Val(txt_prise_FR.Text) / Val(txt_num_FR.Text)
        txt_takl_FH.Text = Val(txt_prise_FH.Text) / Val(txt_num_FH.Text)
        txt_takl_Hand.Text = Val(txt_prise_Hand.Text) / Val(txt_num_Hand.Text)
        '====
        Tangra_oil.Text = Val(txt_num_oli2.Text) * Val(txt_takl_oli.Text)
        Tangra_tom_gan.Text = Val(txt_num_tom_gan2.Text) * Val(txt_takl_tom_gan.Text)
        Tangra_tom_gsh.Text = Val(txt_num_tom_gsh2.Text) * Val(txt_takl_tom_gsh.Text)
        Tangra_paper.Text = Val(txt_num_paper2.Text) * Val(txt_takl_paper.Text)
        Tangra_galg.Text = Val(txt_num_galg2.Text) * Val(txt_takl_galg.Text)
        Tangra_onun.Text = Val(txt_num_onun2.Text) * Val(txt_takl_onun.Text)
        Tangra_FR.Text = Val(txt_num_FR2.Text) * Val(txt_takl_FR.Text)
        Tangra_FH.Text = Val(txt_num_FH2.Text) * Val(txt_takl_FH.Text)
        Tangra_hand.Text = Val(txt_num_Hand2.Text) * Val(txt_takl_Hand.Text)
        '========
        Dim totalTangra As Double
        totalTangra = Val(Tangra_oil.Text) + Val(Tangra_tom_gan.Text) +
                   Val(Tangra_tom_gsh.Text) + Val(Tangra_paper.Text) + Val(Tangra_galg.Text) +
                    Val(Tangra_onun.Text) + Val(Tangra_FR.Text) + Val(Tangra_FH.Text) + Val(Tangra_hand.Text)
        Tangra_totalAll.Text = String.Format("{0:c}", totalTangra)

    End Sub

    Private Sub btn_Clean_text_Click(sender As Object, e As EventArgs) Handles btn_Clean_text.Click
        txt_num_oli2.Text = ""
        txt_num_tom_gan2.Text = ""
        txt_num_tom_gsh2.Text = ""
        txt_num_paper2.Text = ""
        txt_num_galg2.Text = ""
        txt_num_onun2.Text = ""
        txt_num_FR2.Text = ""
        txt_num_FH2.Text = ""
        txt_num_Hand2.Text = ""

        Tangra_oil.Text = ""
        Tangra_tom_gan.Text = ""
        Tangra_tom_gsh.Text = ""
        Tangra_paper.Text = ""
        Tangra_galg.Text = ""
        Tangra_onun.Text = ""
        Tangra_FR.Text = ""
        Tangra_FH.Text = ""
        Tangra_hand.Text = ""
        Tangra_totalAll.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("هل تريد حذف السجل الحالي ؟", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "سجل حذف") = MsgBoxResult.Cancel Then Exit Sub
        Try
            Cmd = New OleDbCommand("DELETE FROM tonjra_info where ID = " & DataGridView1.CurrentRow.Cells(0).Value, Cn)
            Cn.Open()
            Cmd.ExecuteNonQuery()
            Cn.Close()
            MsgBox("تمت عملية الحذف من الاول", MsgBoxStyle.Information, "الحذف ")
            load_data()
            save_data()


        Catch ex As Exception
            Exit Sub
        Finally
            Cn.Close()
        End Try
    End Sub


End Class