<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Tra_Cuu_Suat_Chieu_Beta
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
        Me.flPhim = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbThongBao = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.flCaChieu = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dtpNgayChieu = New System.Windows.Forms.DateTimePicker()
        Me.lbTieuDe = New System.Windows.Forms.Label()
        Me.flDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.flResults = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flPhim
        '
        Me.flPhim.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flPhim.AutoSize = True
        Me.flPhim.BackColor = System.Drawing.SystemColors.Control
        Me.flPhim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flPhim.Location = New System.Drawing.Point(3, 22)
        Me.flPhim.Name = "flPhim"
        Me.flPhim.Padding = New System.Windows.Forms.Padding(2)
        Me.flPhim.Size = New System.Drawing.Size(181, 150)
        Me.flPhim.TabIndex = 1
        Me.flPhim.WrapContents = False
        '
        'lbThongBao
        '
        Me.lbThongBao.AutoSize = True
        Me.lbThongBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThongBao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbThongBao.Location = New System.Drawing.Point(257, 49)
        Me.lbThongBao.Name = "lbThongBao"
        Me.lbThongBao.Size = New System.Drawing.Size(66, 24)
        Me.lbThongBao.TabIndex = 3
        Me.lbThongBao.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.flPhim)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(190, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phim"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.flCaChieu)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(3, 241)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(190, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 210)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ca Chiếu"
        '
        'flCaChieu
        '
        Me.flCaChieu.AutoSize = True
        Me.flCaChieu.BackColor = System.Drawing.SystemColors.Control
        Me.flCaChieu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flCaChieu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flCaChieu.Location = New System.Drawing.Point(3, 22)
        Me.flCaChieu.Name = "flCaChieu"
        Me.flCaChieu.Padding = New System.Windows.Forms.Padding(2)
        Me.flCaChieu.Size = New System.Drawing.Size(184, 185)
        Me.flCaChieu.TabIndex = 1
        Me.flCaChieu.WrapContents = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.dtpNgayChieu)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 76)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(200, 473)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(219, 476)
        Me.FlowLayoutPanel1.TabIndex = 7
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'dtpNgayChieu
        '
        Me.dtpNgayChieu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNgayChieu.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayChieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayChieu.Location = New System.Drawing.Point(3, 3)
        Me.dtpNgayChieu.MinimumSize = New System.Drawing.Size(190, 26)
        Me.dtpNgayChieu.Name = "dtpNgayChieu"
        Me.dtpNgayChieu.Size = New System.Drawing.Size(190, 26)
        Me.dtpNgayChieu.TabIndex = 9
        '
        'lbTieuDe
        '
        Me.lbTieuDe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTieuDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTieuDe.Location = New System.Drawing.Point(12, 9)
        Me.lbTieuDe.Name = "lbTieuDe"
        Me.lbTieuDe.Size = New System.Drawing.Size(760, 31)
        Me.lbTieuDe.TabIndex = 0
        Me.lbTieuDe.Text = "Label1"
        Me.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flDetail
        '
        Me.flDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flDetail.AutoScroll = True
        Me.flDetail.Location = New System.Drawing.Point(237, 76)
        Me.flDetail.MinimumSize = New System.Drawing.Size(500, 150)
        Me.flDetail.Name = "flDetail"
        Me.flDetail.Size = New System.Drawing.Size(535, 153)
        Me.flDetail.TabIndex = 0
        '
        'flResults
        '
        Me.flResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flResults.AutoScroll = True
        Me.flResults.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flResults.Location = New System.Drawing.Point(237, 235)
        Me.flResults.MinimumSize = New System.Drawing.Size(500, 317)
        Me.flResults.Name = "flResults"
        Me.flResults.Size = New System.Drawing.Size(535, 317)
        Me.flResults.TabIndex = 1
        Me.flResults.WrapContents = False
        '
        'MH_Tra_Cuu_Suat_Chieu_Beta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.flDetail)
        Me.Controls.Add(Me.flResults)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lbThongBao)
        Me.Controls.Add(Me.lbTieuDe)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "MH_Tra_Cuu_Suat_Chieu_Beta"
        Me.Text = "MH_Tra_Cuu_Suat_Chieu_Beta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flPhim As FlowLayoutPanel
    Friend WithEvents lbThongBao As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents flCaChieu As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents dtpNgayChieu As DateTimePicker
    Friend WithEvents lbTieuDe As Label
    Friend WithEvents flDetail As FlowLayoutPanel
    Friend WithEvents flResults As FlowLayoutPanel
End Class
