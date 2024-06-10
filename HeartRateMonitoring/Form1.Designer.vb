<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.nameTitleText = New System.Windows.Forms.Label()
        Me.nikInput = New System.Windows.Forms.TextBox()
        Me.nikText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.scanButton = New System.Windows.Forms.Button()
        Me.portComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.baudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.connectButton = New System.Windows.Forms.Button()
        Me.disconnectButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.addressInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(32, 20)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(274, 32)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Heart Rate Monitoring"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nameTitleText
        '
        Me.nameTitleText.AutoSize = True
        Me.nameTitleText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTitleText.Location = New System.Drawing.Point(34, 92)
        Me.nameTitleText.Name = "nameTitleText"
        Me.nameTitleText.Size = New System.Drawing.Size(128, 21)
        Me.nameTitleText.TabIndex = 1
        Me.nameTitleText.Text = "Masukkan Data"
        '
        'nikInput
        '
        Me.nikInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nikInput.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nikInput.Location = New System.Drawing.Point(38, 135)
        Me.nikInput.Name = "nikInput"
        Me.nikInput.Size = New System.Drawing.Size(253, 22)
        Me.nikInput.TabIndex = 2
        '
        'nikText
        '
        Me.nikText.AutoSize = True
        Me.nikText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nikText.Location = New System.Drawing.Point(35, 117)
        Me.nikText.Name = "nikText"
        Me.nikText.Size = New System.Drawing.Size(80, 13)
        Me.nikText.TabIndex = 3
        Me.nikText.Text = "Masukkan NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Masukkan Nama"
        '
        'nameInput
        '
        Me.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameInput.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInput.Location = New System.Drawing.Point(38, 180)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(253, 22)
        Me.nameInput.TabIndex = 5
        '
        'startButton
        '
        Me.startButton.BackColor = System.Drawing.Color.Lime
        Me.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.ForeColor = System.Drawing.Color.Black
        Me.startButton.Location = New System.Drawing.Point(38, 252)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(253, 23)
        Me.startButton.TabIndex = 6
        Me.startButton.Text = "MULAI"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'scanButton
        '
        Me.scanButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scanButton.Location = New System.Drawing.Point(639, 29)
        Me.scanButton.Name = "scanButton"
        Me.scanButton.Size = New System.Drawing.Size(75, 23)
        Me.scanButton.TabIndex = 7
        Me.scanButton.Text = "Scan Port"
        Me.scanButton.UseVisualStyleBackColor = True
        '
        'portComboBox
        '
        Me.portComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portComboBox.FormattingEnabled = True
        Me.portComboBox.Location = New System.Drawing.Point(724, 30)
        Me.portComboBox.Name = "portComboBox"
        Me.portComboBox.Size = New System.Drawing.Size(86, 21)
        Me.portComboBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(819, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Baud Rate"
        '
        'baudRateComboBox
        '
        Me.baudRateComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baudRateComboBox.FormattingEnabled = True
        Me.baudRateComboBox.Location = New System.Drawing.Point(884, 30)
        Me.baudRateComboBox.Name = "baudRateComboBox"
        Me.baudRateComboBox.Size = New System.Drawing.Size(86, 21)
        Me.baudRateComboBox.TabIndex = 10
        '
        'connectButton
        '
        Me.connectButton.BackColor = System.Drawing.Color.Lime
        Me.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connectButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connectButton.ForeColor = System.Drawing.Color.Black
        Me.connectButton.Location = New System.Drawing.Point(724, 57)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(246, 23)
        Me.connectButton.TabIndex = 11
        Me.connectButton.Text = "Connect"
        Me.connectButton.UseVisualStyleBackColor = False
        '
        'disconnectButton
        '
        Me.disconnectButton.BackColor = System.Drawing.Color.Red
        Me.disconnectButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disconnectButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disconnectButton.ForeColor = System.Drawing.Color.White
        Me.disconnectButton.Location = New System.Drawing.Point(639, 57)
        Me.disconnectButton.Name = "disconnectButton"
        Me.disconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.disconnectButton.TabIndex = 12
        Me.disconnectButton.Text = "Disconnect"
        Me.disconnectButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(339, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Data Grafik"
        '
        'Chart1
        '
        ChartArea4.AxisX.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(343, 124)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.Legend = "Legend1"
        Series4.Name = "BPM"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(627, 315)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        '
        'TimerSerial
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Realtime Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 72)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "BPM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Alamat"
        '
        'addressInput
        '
        Me.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressInput.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInput.Location = New System.Drawing.Point(38, 223)
        Me.addressInput.Name = "addressInput"
        Me.addressInput.Size = New System.Drawing.Size(253, 22)
        Me.addressInput.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(38, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Berhenti/Simpan Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(38, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Lihat Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 470)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addressInput)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.disconnectButton)
        Me.Controls.Add(Me.connectButton)
        Me.Controls.Add(Me.baudRateComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.portComboBox)
        Me.Controls.Add(Me.scanButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nikText)
        Me.Controls.Add(Me.nikInput)
        Me.Controls.Add(Me.nameTitleText)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heart Rate Monitoring"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents nameTitleText As Label
    Friend WithEvents nikInput As TextBox
    Friend WithEvents nikText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents startButton As Button
    Friend WithEvents scanButton As Button
    Friend WithEvents portComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents baudRateComboBox As ComboBox
    Friend WithEvents connectButton As Button
    Friend WithEvents disconnectButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents addressInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
