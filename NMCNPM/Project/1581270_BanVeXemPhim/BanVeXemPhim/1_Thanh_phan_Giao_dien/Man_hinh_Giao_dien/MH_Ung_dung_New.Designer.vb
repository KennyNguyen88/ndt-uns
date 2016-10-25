<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Ung_dung_New
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
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Thuc_don = New System.Windows.Forms.MenuStrip()
        Me.flowCaChieu = New System.Windows.Forms.FlowLayoutPanel()
        Me.flowSuatChieu = New System.Windows.Forms.FlowLayoutPanel()
        Me.flowGhe = New System.Windows.Forms.FlowLayoutPanel()
        Me.flowThongBao = New System.Windows.Forms.FlowLayoutPanel()
        Me.flowThongBao.SuspendLayout()
        Me.SuspendLayout()
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.Location = New System.Drawing.Point(3, 0)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Size = New System.Drawing.Size(77, 25)
        Me.Th_Thong_bao.TabIndex = 5
        Me.Th_Thong_bao.Text = "Label1"
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(9, 9)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(840, 43)
        Me.Th_Tieu_de.TabIndex = 3
        Me.Th_Tieu_de.Text = "Label1"
        Me.Th_Tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Thuc_don
        '
        Me.Thuc_don.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thuc_don.AutoSize = False
        Me.Thuc_don.BackColor = System.Drawing.Color.Transparent
        Me.Thuc_don.Dock = System.Windows.Forms.DockStyle.None
        Me.Thuc_don.Location = New System.Drawing.Point(9, 52)
        Me.Thuc_don.Name = "Thuc_don"
        Me.Thuc_don.Size = New System.Drawing.Size(840, 48)
        Me.Thuc_don.TabIndex = 4
        Me.Thuc_don.Text = "MenuStrip1"
        '
        'flowCaChieu
        '
        Me.flowCaChieu.AutoScroll = True
        Me.flowCaChieu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.flowCaChieu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowCaChieu.Location = New System.Drawing.Point(9, 103)
        Me.flowCaChieu.Name = "flowCaChieu"
        Me.flowCaChieu.Size = New System.Drawing.Size(206, 228)
        Me.flowCaChieu.TabIndex = 6
        '
        'flowSuatChieu
        '
        Me.flowSuatChieu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowSuatChieu.AutoScroll = True
        Me.flowSuatChieu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.flowSuatChieu.Location = New System.Drawing.Point(221, 103)
        Me.flowSuatChieu.Name = "flowSuatChieu"
        Me.flowSuatChieu.Size = New System.Drawing.Size(628, 228)
        Me.flowSuatChieu.TabIndex = 7
        '
        'flowGhe
        '
        Me.flowGhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowGhe.AutoScroll = True
        Me.flowGhe.BackColor = System.Drawing.Color.Transparent
        Me.flowGhe.Location = New System.Drawing.Point(221, 337)
        Me.flowGhe.Name = "flowGhe"
        Me.flowGhe.Size = New System.Drawing.Size(628, 129)
        Me.flowGhe.TabIndex = 8
        '
        'flowThongBao
        '
        Me.flowThongBao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flowThongBao.BackColor = System.Drawing.SystemColors.Control
        Me.flowThongBao.Controls.Add(Me.Th_Thong_bao)
        Me.flowThongBao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowThongBao.Location = New System.Drawing.Point(9, 337)
        Me.flowThongBao.Name = "flowThongBao"
        Me.flowThongBao.Size = New System.Drawing.Size(206, 128)
        Me.flowThongBao.TabIndex = 7
        '
        'MH_Ung_dung_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 478)
        Me.Controls.Add(Me.flowThongBao)
        Me.Controls.Add(Me.flowGhe)
        Me.Controls.Add(Me.flowSuatChieu)
        Me.Controls.Add(Me.flowCaChieu)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Thuc_don)
        Me.Name = "MH_Ung_dung_New"
        Me.Text = "MH_Ung_dung_New"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.flowThongBao.ResumeLayout(False)
        Me.flowThongBao.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Thuc_don As MenuStrip
    Friend WithEvents flowCaChieu As FlowLayoutPanel
    Friend WithEvents flowSuatChieu As FlowLayoutPanel
    Friend WithEvents flowGhe As FlowLayoutPanel
    Friend WithEvents flowThongBao As FlowLayoutPanel
End Class
