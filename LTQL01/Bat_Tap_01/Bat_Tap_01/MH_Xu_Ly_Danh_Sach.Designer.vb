﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Xu_Ly_Danh_Sach
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_A = New System.Windows.Forms.ComboBox()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MÀN HÌNH XỬ LÝ DANH SÁCH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Danh Sách A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Danh Sách B"
        '
        'cb_A
        '
        Me.cb_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_A.FormattingEnabled = True
        Me.cb_A.Location = New System.Drawing.Point(259, 117)
        Me.cb_A.Name = "cb_A"
        Me.cb_A.Size = New System.Drawing.Size(168, 28)
        Me.cb_A.TabIndex = 3
        '
        'txt_B
        '
        Me.txt_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B.Location = New System.Drawing.Point(259, 162)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.ReadOnly = True
        Me.txt_B.Size = New System.Drawing.Size(316, 26)
        Me.txt_B.TabIndex = 4
        '
        'MH_Xu_Ly_Danh_Sach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_B)
        Me.Controls.Add(Me.cb_A)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Xu_Ly_Danh_Sach"
        Me.Text = "MH_Xu_Ly_Danh_Sach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_A As ComboBox
    Friend WithEvents txt_B As TextBox
End Class