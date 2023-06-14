<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_kind = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lastT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Mony = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_roba = New System.Windows.Forms.TextBox()
        Me.txt_nos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_nos)
        Me.GroupBox1.Controls.Add(Me.txt_roba)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txt_data)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_kind)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_lastT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Mony)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_count)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(777, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "الموافق"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(215, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 24)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_data.Location = New System.Drawing.Point(746, 48)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(113, 24)
        Me.txt_data.TabIndex = 2
        Me.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(212, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "قيمة المبيع"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"تم السداد", "لم يتم السداد"})
        Me.ComboBox1.Location = New System.Drawing.Point(299, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(71, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(308, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "تم سداد"
        '
        'cmb_kind
        '
        Me.cmb_kind.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmb_kind.FormattingEnabled = True
        Me.cmb_kind.Items.AddRange(New Object() {"ربع", "نص"})
        Me.cmb_kind.Location = New System.Drawing.Point(486, 47)
        Me.cmb_kind.Name = "cmb_kind"
        Me.cmb_kind.Size = New System.Drawing.Size(71, 24)
        Me.cmb_kind.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(503, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "نوعه"
        '
        'txt_lastT
        '
        Me.txt_lastT.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_lastT.Location = New System.Drawing.Point(671, 48)
        Me.txt_lastT.Name = "txt_lastT"
        Me.txt_lastT.Size = New System.Drawing.Size(69, 24)
        Me.txt_lastT.TabIndex = 9
        Me.txt_lastT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(668, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "عرض اخر طنجرة"
        '
        'txt_Mony
        '
        Me.txt_Mony.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Mony.Location = New System.Drawing.Point(394, 48)
        Me.txt_Mony.Name = "txt_Mony"
        Me.txt_Mony.Size = New System.Drawing.Size(69, 24)
        Me.txt_Mony.TabIndex = 7
        Me.txt_Mony.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(391, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "قيمة المبيع"
        '
        'txt_count
        '
        Me.txt_count.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_count.Location = New System.Drawing.Point(576, 47)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(69, 24)
        Me.txt_count.TabIndex = 5
        Me.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(560, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "الكمية المباعة"
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_ID.Location = New System.Drawing.Point(865, 50)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(38, 24)
        Me.txt_ID.TabIndex = 3
        Me.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(862, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Sale"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(925, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 54)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "احسب القيمة"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(925, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حفظ "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 156)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(7, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(239, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 145)
        Me.Panel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 113)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_roba
        '
        Me.txt_roba.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_roba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_roba.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_roba.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_roba.Location = New System.Drawing.Point(697, 88)
        Me.txt_roba.Name = "txt_roba"
        Me.txt_roba.Size = New System.Drawing.Size(43, 24)
        Me.txt_roba.TabIndex = 17
        Me.txt_roba.Text = "3.5"
        Me.txt_roba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nos
        '
        Me.txt_nos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_nos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nos.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_nos.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_nos.Location = New System.Drawing.Point(697, 125)
        Me.txt_nos.Name = "txt_nos"
        Me.txt_nos.Size = New System.Drawing.Size(43, 24)
        Me.txt_nos.TabIndex = 18
        Me.txt_nos.Text = "7"
        Me.txt_nos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(749, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ثمن بيع قطعة الربع ك"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(746, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "ثمن بيع قطعة النصف ك"
        '
        'MB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1036, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MB"
        Me.Text = "MB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_kind As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lastT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Mony As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_count As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_data As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nos As TextBox
    Friend WithEvents txt_roba As TextBox
End Class
