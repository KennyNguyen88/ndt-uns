<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Quan_Ly_Ca_Chieu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.flResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID_Them = New System.Windows.Forms.TextBox()
        Me.dtKetThuc_Them = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dtBatDau_Them = New System.Windows.Forms.DateTimePicker()
        Me.txtTen_Them = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBuoi_Them = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtKetThuc_Tim = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtBatDau_Tim = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbBuoi_Tim = New System.Windows.Forms.ComboBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtTen_Tim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTieuDe = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flResult
        '
        Me.flResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flResult.AutoScroll = True
        Me.flResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.flResult.Location = New System.Drawing.Point(18, 216)
        Me.flResult.Name = "flResult"
        Me.flResult.Size = New System.Drawing.Size(954, 331)
        Me.flResult.TabIndex = 9
        Me.flResult.WrapContents = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lbThongBao)
        Me.Panel3.Location = New System.Drawing.Point(18, 160)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 50)
        Me.Panel3.TabIndex = 7
        '
        'lbThongBao
        '
        Me.lbThongBao.AutoSize = True
        Me.lbThongBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongBao.Location = New System.Drawing.Point(21, 17)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(74, 16)
        Me.lbThongBao.TabIndex = 0
        Me.lbThongBao.Text = "Thông báo"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtID_Them)
        Me.Panel2.Controls.Add(Me.dtKetThuc_Them)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnThem)
        Me.Panel2.Controls.Add(Me.dtBatDau_Them)
        Me.Panel2.Controls.Add(Me.txtTen_Them)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbBuoi_Them)
        Me.Panel2.Location = New System.Drawing.Point(18, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 50)
        Me.Panel2.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(596, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kết Thúc"
        '
        'txtID_Them
        '
        Me.txtID_Them.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtID_Them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID_Them.Enabled = False
        Me.txtID_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID_Them.Location = New System.Drawing.Point(31, 9)
        Me.txtID_Them.Name = "txtID_Them"
        Me.txtID_Them.Size = New System.Drawing.Size(49, 26)
        Me.txtID_Them.TabIndex = 6
        '
        'dtKetThuc_Them
        '
        Me.dtKetThuc_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtKetThuc_Them.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtKetThuc_Them.Location = New System.Drawing.Point(662, 10)
        Me.dtKetThuc_Them.Name = "dtKetThuc_Them"
        Me.dtKetThuc_Them.Size = New System.Drawing.Size(109, 26)
        Me.dtKetThuc_Them.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Bắt Đầu"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnThem.FlatAppearance.BorderSize = 0
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(783, 9)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'dtBatDau_Them
        '
        Me.dtBatDau_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBatDau_Them.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtBatDau_Them.Location = New System.Drawing.Point(481, 10)
        Me.dtBatDau_Them.Name = "dtBatDau_Them"
        Me.dtBatDau_Them.Size = New System.Drawing.Size(109, 26)
        Me.dtBatDau_Them.TabIndex = 11
        '
        'txtTen_Them
        '
        Me.txtTen_Them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTen_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_Them.Location = New System.Drawing.Point(124, 9)
        Me.txtTen_Them.Name = "txtTen_Them"
        Me.txtTen_Them.Size = New System.Drawing.Size(177, 26)
        Me.txtTen_Them.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Buổi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên"
        '
        'cbBuoi_Them
        '
        Me.cbBuoi_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuoi_Them.FormattingEnabled = True
        Me.cbBuoi_Them.Location = New System.Drawing.Point(348, 10)
        Me.cbBuoi_Them.Name = "cbBuoi_Them"
        Me.cbBuoi_Them.Size = New System.Drawing.Size(66, 28)
        Me.cbBuoi_Them.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtKetThuc_Tim)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtBatDau_Tim)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbBuoi_Tim)
        Me.Panel1.Controls.Add(Me.btnTim)
        Me.Panel1.Controls.Add(Me.txtTen_Tim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 50)
        Me.Panel1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(596, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Kết Thúc"
        '
        'dtKetThuc_Tim
        '
        Me.dtKetThuc_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtKetThuc_Tim.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtKetThuc_Tim.Location = New System.Drawing.Point(662, 9)
        Me.dtKetThuc_Tim.Name = "dtKetThuc_Tim"
        Me.dtKetThuc_Tim.Size = New System.Drawing.Size(109, 26)
        Me.dtKetThuc_Tim.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Bắt Đầu"
        '
        'dtBatDau_Tim
        '
        Me.dtBatDau_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBatDau_Tim.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtBatDau_Tim.Location = New System.Drawing.Point(481, 9)
        Me.dtBatDau_Tim.Name = "dtBatDau_Tim"
        Me.dtBatDau_Tim.Size = New System.Drawing.Size(109, 26)
        Me.dtBatDau_Tim.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(307, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Buổi"
        '
        'cbBuoi_Tim
        '
        Me.cbBuoi_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuoi_Tim.FormattingEnabled = True
        Me.cbBuoi_Tim.Location = New System.Drawing.Point(348, 9)
        Me.cbBuoi_Tim.Name = "cbBuoi_Tim"
        Me.cbBuoi_Tim.Size = New System.Drawing.Size(66, 28)
        Me.cbBuoi_Tim.TabIndex = 3
        '
        'btnTim
        '
        Me.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTim.FlatAppearance.BorderSize = 0
        Me.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.Location = New System.Drawing.Point(783, 11)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 29)
        Me.btnTim.TabIndex = 2
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = False
        '
        'txtTen_Tim
        '
        Me.txtTen_Tim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTen_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_Tim.Location = New System.Drawing.Point(124, 9)
        Me.txtTen_Tim.Name = "txtTen_Tim"
        Me.txtTen_Tim.Size = New System.Drawing.Size(177, 26)
        Me.txtTen_Tim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên"
        '
        'lbTieuDe
        '
        Me.lbTieuDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTieuDe.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTieuDe.Location = New System.Drawing.Point(12, 14)
        Me.lbTieuDe.Name = "lbTieuDe"
        Me.lbTieuDe.Size = New System.Drawing.Size(960, 31)
        Me.lbTieuDe.TabIndex = 5
        Me.lbTieuDe.Text = "Label1"
        Me.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MH_Quan_Ly_Ca_Chieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.flResult)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbTieuDe)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "MH_Quan_Ly_Ca_Chieu"
        Me.Text = "MH_Quan_Ly_Ca_Chieu"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flResult As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbThongBao As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtID_Them As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtTen_Them As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtKetThuc_Tim As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtBatDau_Tim As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbBuoi_Tim As ComboBox
    Friend WithEvents btnTim As Button
    Friend WithEvents txtTen_Tim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTieuDe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtKetThuc_Them As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtBatDau_Them As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cbBuoi_Them As ComboBox
End Class
