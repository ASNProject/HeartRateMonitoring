Imports System
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Public Class Form1
    Private ReadOnly updateInterval As Integer = 1000
    Private currentNik As String = ""
    Private currentName As String = ""
    Private currentAddress As String = ""
    Private serialPort As SerialPort
    Private bpm As Integer
    Private isConnected As Boolean = False
    Private latestCode As Integer
    Private newCode As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles nikText.Click

    End Sub

    Private Sub portComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles portComboBox.SelectedIndexChanged
        UpdateConnectButtonState()

    End Sub

    Private Sub scanButton_Click(sender As Object, e As EventArgs) Handles scanButton.Click
        ScanComPorts()
    End Sub

    Private Sub connectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        ConnectToArduino()
        isConnected = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        If isConnected AndAlso Not String.IsNullOrEmpty(currentNik) AndAlso Not String.IsNullOrEmpty(currentName) AndAlso bpm > 0 Then
            LoadChart(currentNik)
            InsertDataToDatabase(currentNik, currentName, bpm, currentAddress, newCode)
        End If
    End Sub

    Private Sub disconnectButton_Click(sender As Object, e As EventArgs) Handles disconnectButton.Click
        DisconnectFromArduino()
        isConnected = False
        Label5.Text = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimerSerial.Interval = updateInterval
        TimerSerial.Start()
        UpdateConnectButtonState()


    End Sub

    Private Sub portComboBox_Click(sender As Object, e As EventArgs) Handles portComboBox.Click

    End Sub

    Private Sub LoadChart(nik As String)
        Dim connectionString As String = "Server=127.0.0.1;Database=bpm_db;Uid=root;Pwd=;"
        Dim query As String = "SELECT id, nik, nama, bpm FROM bpm_data WHERE nik = @nik"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@nik", nik)

                Dim reader As MySqlDataReader = cmd.ExecuteReader

                Chart1.Series.Clear()

                Dim series As New Series("BPM Data")
                series.ChartType = SeriesChartType.Spline
                series.Color = Color.Orange


                Dim count As String = 1
                Dim lastData As String = ""

                While reader.Read()

                    series.Points.AddXY(count.ToString(), Convert.ToInt32(reader("bpm")))
                    count += 1

                    lastData = $" {reader("bpm")}"

                End While

                Chart1.Series.Add(series)

                If Not String.IsNullOrEmpty(lastData) Then
                    Label5.Text = lastData
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        currentNik = nikInput.Text
        currentName = nameInput.Text
        currentAddress = addressInput.Text
        latestCode = GetLatestCode(currentNik)
        newCode = latestCode + 1

        If Not String.IsNullOrEmpty(currentNik) AndAlso Not String.IsNullOrEmpty(currentName) AndAlso Not String.IsNullOrEmpty(currentAddress) Then
            LoadChart(currentNik)
            isConnected = True
        Else
            MessageBox.Show("Mohon masukkan nik, nama, dan alamat terlebih dahulu")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ScanComPorts()
        portComboBox.Items.Clear()
        Dim ports As String() = SerialPort.GetPortNames()

        If ports.Length > 0 Then
            For Each port In ports
                portComboBox.Items.Add(port)
            Next
            portComboBox.SelectedIndex = 0

            Dim baudRates As Integer() = {9600, 19200, 38400, 57600, 115200}

            For Each baudRate In baudRates
                baudRateComboBox.Items.Add(baudRate)
            Next
            baudRateComboBox.SelectedIndex = 0
        Else
            MessageBox.Show("Tidak ada port COM yang ditemukan")
        End If

        UpdateConnectButtonState()

    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Try
            Dim data As String = serialPort.ReadLine()
            bpm = Convert.ToInt32(data)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ConnectToArduino()
        Try
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                serialPort.Close()
            End If

            serialPort = New SerialPort(portComboBox.SelectedItem.ToString(), CInt(baudRateComboBox.SelectedItem.ToString()))
            AddHandler serialPort.DataReceived, AddressOf SerialPort_DataReceived
            serialPort.Open()
            MessageBox.Show("Terhubung ke Sistem pada " & serialPort.PortName)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisconnectFromArduino()
        Try
            If serialPort IsNot Nothing AndAlso serialPort.IsOpen Then
                serialPort.Close()
                MessageBox.Show("Terputus dari Arduino")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub UpdateConnectButtonState()
        connectButton.Enabled = portComboBox.SelectedItem IsNot Nothing AndAlso baudRateComboBox.SelectedItem IsNot Nothing
    End Sub

    Private Sub baudRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles baudRateComboBox.SelectedIndexChanged
        UpdateConnectButtonState()
    End Sub

    Private Sub InsertDataToDatabase(nik As String, nama As String, bpm As Integer, alamat As String, code As Integer)
        Dim connectionString As String = "Server=127.0.0.1;Database=bpm_db;Uid=root;Pwd=;"
        Dim query As String = "INSERT INTO bpm_data (nik, nama, bpm, alamat, code) VALUES (@nik, @nama, @bpm, @alamat, @code)"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@nik", nik)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@bpm", bpm)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@code", code)

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isConnected = False
        Label5.Text = 0
    End Sub

    Private Function GetLatestCode(nik As String) As Integer
        Dim connectionString As String = "Server=127.0.0.1;Database=bpm_db;Uid=root;Pwd=;"
        Dim query As String = "SELECT MAX(code) FROM bpm_data WHERE nik = @nik"
        Dim latestCode As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@nik", nik)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    latestCode = Convert.ToInt32(result)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return latestCode
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2()
        newForm.Show()
    End Sub
End Class
