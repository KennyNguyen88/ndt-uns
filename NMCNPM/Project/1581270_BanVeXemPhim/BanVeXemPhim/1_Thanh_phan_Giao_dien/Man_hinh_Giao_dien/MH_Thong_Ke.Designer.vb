<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Thong_Ke
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
        Me.lbTieuDe = New System.Windows.Forms.Label()
        Me.flResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.dtNgay = New System.Windows.Forms.DateTimePicker()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTieuDe
        '
        Me.lbTieuDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTieuDe.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTieuDe.Location = New System.Drawing.Point(12, 9)
        Me.lbTieuDe.Name = "lbTieuDe"
        Me.lbTieuDe.Size = New System.Drawing.Size(960, 38)
        Me.lbTieuDe.TabIndex = 15
        Me.lbTieuDe.Text = "Label1"
        Me.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flResult
        '
        Me.flResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flResult.AutoScroll = True
        Me.flResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.flResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flResult.Location = New System.Drawing.Point(15, 163)
        Me.flResult.Name = "flResult"
        Me.flResult.Size = New System.Drawing.Size(954, 386)
        Me.flResult.TabIndex = 21
        Me.flResult.WrapContents = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lbThongBao)
        Me.Panel3.Location = New System.Drawing.Point(15, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 50)
        Me.Panel3.TabIndex = 20
        '
        'lbThongBao
        '
        Me.lbThongBao.AutoSize = True
        Me.lbThongBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongBao.Location = New System.Drawing.Point(21, 17)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(0, 16)
        Me.lbThongBao.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.dtNgay)
        Me.Panel1.Controls.Add(Me.btnTim)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(15, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 50)
        Me.Panel1.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tháng"
        '
        'btnTim
        '
        Me.btnTim.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTim.FlatAppearance.BorderSize = 0
        Me.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.Location = New System.Drawing.Point(554, 14)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(75, 29)
        Me.btnTim.TabIndex = 13
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = False
        '
        'dtNgay
        '
        Me.dtNgay.CustomFormat = "M/yyyy"
        Me.dtNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtNgay.Location = New System.Drawing.Point(396, 14)
        Me.dtNgay.Name = "dtNgay"
        Me.dtNgay.Size = New System.Drawing.Size(152, 26)
        Me.dtNgay.TabIndex = 14
        '
        'MH_Thong_Ke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.flResult)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbTieuDe)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "MH_Thong_Ke"
        Me.Text = "MH_Thong_Ke"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbTieuDe As Label
    Friend WithEvents flResult As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbThongBao As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTim As Button
    Friend WithEvents dtNgay As DateTimePicker
End Class
