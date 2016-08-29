<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Quan_ly_Ghe
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
        Me.flResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.cbPhong_Them = New System.Windows.Forms.ComboBox()
        Me.Y_Them = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.X_Them = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTen_Them = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbPhong_Tim = New System.Windows.Forms.ComboBox()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtTen_Tim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTieuDe = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Y_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_Them, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.flResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flResult.Location = New System.Drawing.Point(18, 219)
        Me.flResult.Name = "flResult"
        Me.flResult.Size = New System.Drawing.Size(954, 331)
        Me.flResult.TabIndex = 8
        Me.flResult.WrapContents = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lbThongBao)
        Me.Panel3.Location = New System.Drawing.Point(18, 163)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 50)
        Me.Panel3.TabIndex = 6
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
        Me.Panel2.Controls.Add(Me.btnThem)
        Me.Panel2.Controls.Add(Me.cbPhong_Them)
        Me.Panel2.Controls.Add(Me.Y_Them)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.X_Them)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtTen_Them)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(18, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 50)
        Me.Panel2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phòng"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnThem.FlatAppearance.BorderSize = 0
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(787, 11)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'cbPhong_Them
        '
        Me.cbPhong_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhong_Them.FormattingEnabled = True
        Me.cbPhong_Them.Location = New System.Drawing.Point(411, 12)
        Me.cbPhong_Them.Name = "cbPhong_Them"
        Me.cbPhong_Them.Size = New System.Drawing.Size(136, 28)
        Me.cbPhong_Them.TabIndex = 5
        '
        'Y_Them
        '
        Me.Y_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Y_Them.Location = New System.Drawing.Point(715, 12)
        Me.Y_Them.Name = "Y_Them"
        Me.Y_Them.Size = New System.Drawing.Size(66, 26)
        Me.Y_Them.TabIndex = 9
        Me.Y_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(692, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Y"
        '
        'X_Them
        '
        Me.X_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X_Them.Location = New System.Drawing.Point(586, 12)
        Me.X_Them.Name = "X_Them"
        Me.X_Them.Size = New System.Drawing.Size(66, 26)
        Me.X_Them.TabIndex = 7
        Me.X_Them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(564, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "X"
        '
        'txtTen_Them
        '
        Me.txtTen_Them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTen_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_Them.Location = New System.Drawing.Point(124, 12)
        Me.txtTen_Them.Name = "txtTen_Them"
        Me.txtTen_Them.Size = New System.Drawing.Size(199, 26)
        Me.txtTen_Them.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbPhong_Tim)
        Me.Panel1.Controls.Add(Me.btnTim)
        Me.Panel1.Controls.Add(Me.txtTen_Tim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 50)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phòng"
        '
        'cbPhong_Tim
        '
        Me.cbPhong_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhong_Tim.FormattingEnabled = True
        Me.cbPhong_Tim.Location = New System.Drawing.Point(411, 8)
        Me.cbPhong_Tim.Name = "cbPhong_Tim"
        Me.cbPhong_Tim.Size = New System.Drawing.Size(136, 28)
        Me.cbPhong_Tim.TabIndex = 3
        '
        'btnTim
        '
        Me.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTim.FlatAppearance.BorderSize = 0
        Me.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.Location = New System.Drawing.Point(787, 8)
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
        Me.txtTen_Tim.Size = New System.Drawing.Size(199, 26)
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
        Me.lbTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTieuDe.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTieuDe.Location = New System.Drawing.Point(12, 10)
        Me.lbTieuDe.Name = "lbTieuDe"
        Me.lbTieuDe.Size = New System.Drawing.Size(960, 38)
        Me.lbTieuDe.TabIndex = 4
        Me.lbTieuDe.Text = "Label1"
        Me.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MH_Quan_ly_Ghe
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
        Me.Name = "MH_Quan_ly_Ghe"
        Me.Text = "MH_Quan_ly_Ghe"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Y_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_Them, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flResult As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbThongBao As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents Y_Them As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents X_Them As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTen_Them As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTim As Button
    Friend WithEvents txtTen_Tim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTieuDe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPhong_Them As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbPhong_Tim As ComboBox
End Class
