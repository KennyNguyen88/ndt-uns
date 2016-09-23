<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Quan_Ly_Phim
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
        Me.lbTieuDe = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtTen_Tim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtTen_Them = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.flResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTieuDe
        '
        Me.lbTieuDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTieuDe.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTieuDe.Location = New System.Drawing.Point(12, 9)
        Me.lbTieuDe.Name = "lbTieuDe"
        Me.lbTieuDe.Size = New System.Drawing.Size(760, 31)
        Me.lbTieuDe.TabIndex = 0
        Me.lbTieuDe.Text = "Label1"
        Me.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnTim)
        Me.Panel1.Controls.Add(Me.txtTen_Tim)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(18, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnTim
        '
        Me.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTim.FlatAppearance.BorderSize = 0
        Me.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.Location = New System.Drawing.Point(587, 6)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnThem)
        Me.Panel2.Controls.Add(Me.txtTen_Them)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(18, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(754, 50)
        Me.Panel2.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnThem.FlatAppearance.BorderSize = 0
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(587, 6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'txtTen_Them
        '
        Me.txtTen_Them.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTen_Them.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_Them.Location = New System.Drawing.Point(124, 9)
        Me.txtTen_Them.Name = "txtTen_Them"
        Me.txtTen_Them.Size = New System.Drawing.Size(199, 26)
        Me.txtTen_Them.TabIndex = 1
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
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lbThongBao)
        Me.Panel3.Location = New System.Drawing.Point(18, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(754, 50)
        Me.Panel3.TabIndex = 3
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
        'flResult
        '
        Me.flResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flResult.AutoScroll = True
        Me.flResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.flResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flResult.Location = New System.Drawing.Point(18, 211)
        Me.flResult.Name = "flResult"
        Me.flResult.Size = New System.Drawing.Size(754, 331)
        Me.flResult.TabIndex = 4
        Me.flResult.WrapContents = False
        '
        'MH_Quan_Ly_Phim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.flResult)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbTieuDe)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MH_Quan_Ly_Phim"
        Me.Text = "MH_Quan_Ly_Phim"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbTieuDe As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTim As Button
    Friend WithEvents txtTen_Tim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents txtTen_Them As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbThongBao As Label
    Friend WithEvents flResult As FlowLayoutPanel
End Class
