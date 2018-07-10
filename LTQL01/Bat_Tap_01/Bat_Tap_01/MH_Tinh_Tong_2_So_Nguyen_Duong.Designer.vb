<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tinh_Tong_2_So_Nguyen_Duong
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.X = New System.Windows.Forms.Label()
        Me.Y = New System.Windows.Forms.Label()
        Me.KQ = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtKQ = New System.Windows.Forms.TextBox()
        Me.btnDongY = New System.Windows.Forms.Button()
        Me.lb_X_error = New System.Windows.Forms.Label()
        Me.lb_Y_error = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN DƯƠNG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X.Location = New System.Drawing.Point(229, 135)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(20, 20)
        Me.X.TabIndex = 1
        Me.X.Text = "X"
        '
        'Y
        '
        Me.Y.AutoSize = True
        Me.Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Y.Location = New System.Drawing.Point(229, 180)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(20, 20)
        Me.Y.TabIndex = 2
        Me.Y.Text = "Y"
        '
        'KQ
        '
        Me.KQ.AutoSize = True
        Me.KQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KQ.Location = New System.Drawing.Point(171, 231)
        Me.KQ.Name = "KQ"
        Me.KQ.Size = New System.Drawing.Size(78, 20)
        Me.KQ.TabIndex = 3
        Me.KQ.Text = "KẾT QUẢ"
        '
        'txtX
        '
        Me.txtX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(255, 132)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(214, 26)
        Me.txtX.TabIndex = 4
        Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtY
        '
        Me.txtY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY.Location = New System.Drawing.Point(255, 180)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(214, 26)
        Me.txtY.TabIndex = 5
        Me.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKQ
        '
        Me.txtKQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKQ.Location = New System.Drawing.Point(255, 228)
        Me.txtKQ.Name = "txtKQ"
        Me.txtKQ.ReadOnly = True
        Me.txtKQ.Size = New System.Drawing.Size(214, 26)
        Me.txtKQ.TabIndex = 6
        Me.txtKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDongY
        '
        Me.btnDongY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDongY.Location = New System.Drawing.Point(312, 260)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(100, 34)
        Me.btnDongY.TabIndex = 7
        Me.btnDongY.Text = "ĐỒNG Ý"
        Me.btnDongY.UseVisualStyleBackColor = True
        '
        'lb_X_error
        '
        Me.lb_X_error.AutoSize = True
        Me.lb_X_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_X_error.ForeColor = System.Drawing.Color.Red
        Me.lb_X_error.Location = New System.Drawing.Point(281, 161)
        Me.lb_X_error.Name = "lb_X_error"
        Me.lb_X_error.Size = New System.Drawing.Size(162, 16)
        Me.lb_X_error.TabIndex = 8
        Me.lb_X_error.Text = "* Vui lòng nhập số nguyên"
        '
        'lb_Y_error
        '
        Me.lb_Y_error.AutoSize = True
        Me.lb_Y_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Y_error.ForeColor = System.Drawing.Color.Red
        Me.lb_Y_error.Location = New System.Drawing.Point(281, 209)
        Me.lb_Y_error.Name = "lb_Y_error"
        Me.lb_Y_error.Size = New System.Drawing.Size(162, 16)
        Me.lb_Y_error.TabIndex = 9
        Me.lb_Y_error.Text = "* Vui lòng nhập số nguyên"
        '
        'MH_Tinh_Tong_2_So_Nguyen_Duong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 398)
        Me.Controls.Add(Me.lb_Y_error)
        Me.Controls.Add(Me.lb_X_error)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.txtKQ)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.KQ)
        Me.Controls.Add(Me.Y)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Tinh_Tong_2_So_Nguyen_Duong"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents X As Label
    Friend WithEvents Y As Label
    Friend WithEvents KQ As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtKQ As TextBox
    Friend WithEvents btnDongY As Button
    Friend WithEvents lb_X_error As Label
    Friend WithEvents lb_Y_error As Label
End Class
