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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.aside = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.main = New System.Windows.Forms.Panel()
        Me.pnBot = New System.Windows.Forms.Panel()
        Me.pnBot_Dia = New System.Windows.Forms.Panel()
        Me.pnBot_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnBot_info = New System.Windows.Forms.Panel()
        Me.pnBot_lbTitle = New System.Windows.Forms.Label()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.pnTop_Dia = New System.Windows.Forms.Panel()
        Me.pnTop_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnTop_Info = New System.Windows.Forms.Panel()
        Me.pnTop_lbTitle = New System.Windows.Forms.Label()
        Me.btnTCDV = New System.Windows.Forms.Button()
        Me.btnHSDV = New System.Windows.Forms.Button()
        Me.btnHSCN = New System.Windows.Forms.Button()
        Me.btnHSCT = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.aside.SuspendLayout()
        Me.main.SuspendLayout()
        Me.pnBot.SuspendLayout()
        Me.pnBot_Dia.SuspendLayout()
        CType(Me.pnBot_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnBot_info.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.pnTop_Dia.SuspendLayout()
        CType(Me.pnTop_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTop_Info.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'aside
        '
        Me.aside.Controls.Add(Me.FlowLayoutPanel1)
        Me.aside.Controls.Add(Me.Label2)
        Me.aside.Controls.Add(Me.Label1)
        Me.aside.Controls.Add(Me.txtSearch)
        Me.aside.Controls.Add(Me.logo)
        Me.aside.Location = New System.Drawing.Point(12, 12)
        Me.aside.Name = "aside"
        Me.aside.Size = New System.Drawing.Size(455, 705)
        Me.aside.TabIndex = 0
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
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(16, 184)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(423, 20)
        Me.txtSearch.TabIndex = 1
        '
        'main
        '
        Me.main.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.main.Controls.Add(Me.pnBot)
        Me.main.Controls.Add(Me.pnTop)
        Me.main.Location = New System.Drawing.Point(473, 12)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(865, 705)
        Me.main.TabIndex = 1
        '
        'pnBot
        '
        Me.pnBot.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnBot.Controls.Add(Me.pnBot_Dia)
        Me.pnBot.Controls.Add(Me.pnBot_info)
        Me.pnBot.Location = New System.Drawing.Point(3, 357)
        Me.pnBot.Name = "pnBot"
        Me.pnBot.Size = New System.Drawing.Size(859, 345)
        Me.pnBot.TabIndex = 1
        '
        'pnBot_Dia
        '
        Me.pnBot_Dia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnBot_Dia.Controls.Add(Me.pnBot_chart)
        Me.pnBot_Dia.Location = New System.Drawing.Point(434, 16)
        Me.pnBot_Dia.Name = "pnBot_Dia"
        Me.pnBot_Dia.Size = New System.Drawing.Size(412, 322)
        Me.pnBot_Dia.TabIndex = 2
        '
        'pnBot_chart
        '
        ChartArea3.Name = "ChartArea1"
        Me.pnBot_chart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.pnBot_chart.Legends.Add(Legend3)
        Me.pnBot_chart.Location = New System.Drawing.Point(12, 9)
        Me.pnBot_chart.Name = "pnBot_chart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.pnBot_chart.Series.Add(Series3)
        Me.pnBot_chart.Size = New System.Drawing.Size(386, 300)
        Me.pnBot_chart.TabIndex = 1
        Me.pnBot_chart.Text = "Chart1"
        '
        'pnBot_info
        '
        Me.pnBot_info.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnBot_info.Controls.Add(Me.pnBot_lbTitle)
        Me.pnBot_info.Location = New System.Drawing.Point(16, 16)
        Me.pnBot_info.Name = "pnBot_info"
        Me.pnBot_info.Size = New System.Drawing.Size(412, 317)
        Me.pnBot_info.TabIndex = 1
        '
        'pnBot_lbTitle
        '
        Me.pnBot_lbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnBot_lbTitle.Location = New System.Drawing.Point(3, 9)
        Me.pnBot_lbTitle.Name = "pnBot_lbTitle"
        Me.pnBot_lbTitle.Size = New System.Drawing.Size(406, 30)
        Me.pnBot_lbTitle.TabIndex = 1
        Me.pnBot_lbTitle.Text = "Label3"
        Me.pnBot_lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnTop.Controls.Add(Me.pnTop_Dia)
        Me.pnTop.Controls.Add(Me.pnTop_Info)
        Me.pnTop.Location = New System.Drawing.Point(3, 3)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(859, 345)
        Me.pnTop.TabIndex = 0
        '
        'pnTop_Dia
        '
        Me.pnTop_Dia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnTop_Dia.Controls.Add(Me.pnTop_chart)
        Me.pnTop_Dia.Location = New System.Drawing.Point(434, 10)
        Me.pnTop_Dia.Name = "pnTop_Dia"
        Me.pnTop_Dia.Size = New System.Drawing.Size(412, 322)
        Me.pnTop_Dia.TabIndex = 1
        '
        'pnTop_chart
        '
        ChartArea4.Name = "ChartArea1"
        Me.pnTop_chart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.pnTop_chart.Legends.Add(Legend4)
        Me.pnTop_chart.Location = New System.Drawing.Point(12, 10)
        Me.pnTop_chart.Name = "pnTop_chart"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.pnTop_chart.Series.Add(Series4)
        Me.pnTop_chart.Size = New System.Drawing.Size(386, 300)
        Me.pnTop_chart.TabIndex = 0
        Me.pnTop_chart.Text = "Chart1"
        '
        'pnTop_Info
        '
        Me.pnTop_Info.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnTop_Info.Controls.Add(Me.pnTop_lbTitle)
        Me.pnTop_Info.Location = New System.Drawing.Point(16, 10)
        Me.pnTop_Info.Name = "pnTop_Info"
        Me.pnTop_Info.Size = New System.Drawing.Size(412, 322)
        Me.pnTop_Info.TabIndex = 0
        '
        'pnTop_lbTitle
        '
        Me.pnTop_lbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnTop_lbTitle.Location = New System.Drawing.Point(3, 10)
        Me.pnTop_lbTitle.Name = "pnTop_lbTitle"
        Me.pnTop_lbTitle.Size = New System.Drawing.Size(406, 30)
        Me.pnTop_lbTitle.TabIndex = 0
        Me.pnTop_lbTitle.Text = "Label3"
        Me.pnTop_lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTCDV
        '
        Me.btnTCDV.Image = Global.WindowsApplication.My.Resources.Resources.btn_04
        Me.btnTCDV.Location = New System.Drawing.Point(3, 90)
        Me.btnTCDV.Name = "btnTCDV"
        Me.btnTCDV.Size = New System.Drawing.Size(423, 23)
        Me.btnTCDV.TabIndex = 5
        Me.btnTCDV.Text = "Button4"
        Me.btnTCDV.UseVisualStyleBackColor = True
        '
        'btnHSDV
        '
        Me.btnHSDV.Image = Global.WindowsApplication.My.Resources.Resources.btn_03
        Me.btnHSDV.Location = New System.Drawing.Point(3, 61)
        Me.btnHSDV.Name = "btnHSDV"
        Me.btnHSDV.Size = New System.Drawing.Size(423, 23)
        Me.btnHSDV.TabIndex = 4
        Me.btnHSDV.Text = "Button3"
        Me.btnHSDV.UseVisualStyleBackColor = True
        '
        'btnHSCN
        '
        Me.btnHSCN.Image = Global.WindowsApplication.My.Resources.Resources.btn_02
        Me.btnHSCN.Location = New System.Drawing.Point(3, 32)
        Me.btnHSCN.Name = "btnHSCN"
        Me.btnHSCN.Size = New System.Drawing.Size(423, 23)
        Me.btnHSCN.TabIndex = 3
        Me.btnHSCN.Text = "Button2"
        Me.btnHSCN.UseVisualStyleBackColor = True
        '
        'btnHSCT
        '
        Me.btnHSCT.Image = Global.WindowsApplication.My.Resources.Resources.btn_01
        Me.btnHSCT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHSCT.Location = New System.Drawing.Point(3, 3)
        Me.btnHSCT.Name = "btnHSCT"
        Me.btnHSCT.Size = New System.Drawing.Size(420, 23)
        Me.btnHSCT.TabIndex = 2
        Me.btnHSCT.Text = "Button1"
        Me.btnHSCT.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Image = Global.WindowsApplication.My.Resources.Resources.logo_khtn_200w
        Me.logo.Location = New System.Drawing.Point(128, 13)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(200, 165)
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHSCT)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHSCN)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHSDV)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTCDV)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 223)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(423, 303)
        Me.FlowLayoutPanel1.TabIndex = 8
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
        Me.main.ResumeLayout(False)
        Me.pnBot.ResumeLayout(False)
        Me.pnBot_Dia.ResumeLayout(False)
        CType(Me.pnBot_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnBot_info.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop_Dia.ResumeLayout(False)
        CType(Me.pnTop_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTop_Info.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents pnBot As Panel
    Friend WithEvents pnBot_Dia As Panel
    Friend WithEvents pnBot_chart As DataVisualization.Charting.Chart
    Friend WithEvents pnBot_info As Panel
    Friend WithEvents pnBot_lbTitle As Label
    Friend WithEvents pnTop As Panel
    Friend WithEvents pnTop_Dia As Panel
    Friend WithEvents pnTop_chart As DataVisualization.Charting.Chart
    Friend WithEvents pnTop_Info As Panel
    Friend WithEvents pnTop_lbTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
