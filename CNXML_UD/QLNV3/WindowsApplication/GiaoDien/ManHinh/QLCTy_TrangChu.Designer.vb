<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLCTy_TrangChu
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
        Me.aside = New System.Windows.Forms.Panel()
        Me.main = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnHSCT = New System.Windows.Forms.Button()
        Me.btnHSCN = New System.Windows.Forms.Button()
        Me.btnHSDV = New System.Windows.Forms.Button()
        Me.btnTCDV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.aside.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aside
        '
        Me.aside.Controls.Add(Me.Label2)
        Me.aside.Controls.Add(Me.Label1)
        Me.aside.Controls.Add(Me.btnTCDV)
        Me.aside.Controls.Add(Me.btnHSDV)
        Me.aside.Controls.Add(Me.btnHSCN)
        Me.aside.Controls.Add(Me.btnHSCT)
        Me.aside.Controls.Add(Me.txtSearch)
        Me.aside.Controls.Add(Me.logo)
        Me.aside.Location = New System.Drawing.Point(12, 12)
        Me.aside.Name = "aside"
        Me.aside.Size = New System.Drawing.Size(455, 705)
        Me.aside.TabIndex = 0
        '
        'main
        '
        Me.main.Location = New System.Drawing.Point(473, 12)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(865, 705)
        Me.main.TabIndex = 1
        '
        'logo
        '
        Me.logo.Image = Global.WindowsApplication.My.Resources.Resources.logo_khtn_200w
        Me.logo.Location = New System.Drawing.Point(128, 13)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(200, 156)
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(16, 184)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(423, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnHSCT
        '
        Me.btnHSCT.Location = New System.Drawing.Point(16, 238)
        Me.btnHSCT.Name = "btnHSCT"
        Me.btnHSCT.Size = New System.Drawing.Size(423, 23)
        Me.btnHSCT.TabIndex = 2
        Me.btnHSCT.Text = "Button1"
        Me.btnHSCT.UseVisualStyleBackColor = True
        '
        'btnHSCN
        '
        Me.btnHSCN.Location = New System.Drawing.Point(16, 281)
        Me.btnHSCN.Name = "btnHSCN"
        Me.btnHSCN.Size = New System.Drawing.Size(423, 23)
        Me.btnHSCN.TabIndex = 3
        Me.btnHSCN.Text = "Button2"
        Me.btnHSCN.UseVisualStyleBackColor = True
        '
        'btnHSDV
        '
        Me.btnHSDV.Location = New System.Drawing.Point(16, 326)
        Me.btnHSDV.Name = "btnHSDV"
        Me.btnHSDV.Size = New System.Drawing.Size(423, 23)
        Me.btnHSDV.TabIndex = 4
        Me.btnHSDV.Text = "Button3"
        Me.btnHSDV.UseVisualStyleBackColor = True
        '
        'btnTCDV
        '
        Me.btnTCDV.Location = New System.Drawing.Point(16, 405)
        Me.btnTCDV.Name = "btnTCDV"
        Me.btnTCDV.Size = New System.Drawing.Size(423, 23)
        Me.btnTCDV.TabIndex = 5
        Me.btnTCDV.Text = "Button4"
        Me.btnTCDV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(16, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(16, 667)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QLCTy_TrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.aside)
        Me.Name = "QLCTy_TrangChu"
        Me.Text = "MainQLCTy"
        Me.aside.ResumeLayout(False)
        Me.aside.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents aside As Panel
    Friend WithEvents logo As PictureBox
    Friend WithEvents main As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTCDV As Button
    Friend WithEvents btnHSDV As Button
    Friend WithEvents btnHSCN As Button
    Friend WithEvents btnHSCT As Button
    Friend WithEvents txtSearch As TextBox
End Class
