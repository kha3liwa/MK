Imports System.Data.OleDb

Public Class firstShow

    Public Cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & Application.StartupPath & "\MG.accdb")
    Public Cmd As New OleDbCommand("", Cn)
    Public dt As New DataTable
    Public da As New OleDbDataAdapter
    'Public dataexpiry As DateTime



    Public Sub expiry_dateShow()
        Dim expiry_date As Date
        'Dim to_expiry As Integer
        Dim to_expiry As String = Date.Parse(TextBox1.Text).ToString("yyyy-mm-dd")

        expiry_date = TextBox1.Text '#12/31/2023# ' تاريخ انتهاء الصلاحية

        to_expiry = DateDiff("d", Now(), expiry_date) ' عد الأيام المتبقية
        Label3.Text = to_expiry

        If to_expiry < 30 Then
            MsgBox("يجب تجديد الرخصة قبل انتهاء صلاحيتها")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Now()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tonjra.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmEditTaklfa.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MB.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        expiry_dateShow()
    End Sub
End Class
