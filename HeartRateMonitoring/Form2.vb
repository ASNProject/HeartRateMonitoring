Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String = TextBox1.Text.Trim()
        If Not String.IsNullOrEmpty(nama) Then
            LoadCharts(nama)
        Else
            MessageBox.Show("Masukkan nama terlebih dahulu.")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadCharts(nama As String)
        Dim connectionString As String = "Server=127.0.0.1;Database=bpm_db;Uid=root;Pwd=;"
        Dim query As String = "SELECT nik, nama, bpm, alamat, code FROM bpm_data WHERE nama = @nama ORDER BY code"

        Dim dataDict As New Dictionary(Of Integer, List(Of Integer))
        Dim nik As String = ""
        Dim alamat As String = ""

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@nama", nama)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim code As Integer = Convert.ToInt32(reader("code"))
                        Dim bpm As Integer = Convert.ToInt32(reader("bpm"))

                        If Not dataDict.ContainsKey(code) Then
                            dataDict(code) = New List(Of Integer)
                        End If
                        dataDict(code).Add(bpm)

                        nik = reader("nik").ToString()
                        alamat = reader("alamat").ToString()

                    End While
                End Using

                Label4.Text = nama
                Label6.Text = nik
                Label8.Text = alamat

                DisplayCharts(dataDict)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub DisplayCharts(dataDict As Dictionary(Of Integer, List(Of Integer)))
        chartPanel.Controls.Clear()

        Dim chartIndex As Integer = 0
        For Each kvp In dataDict
            Dim chart As New Chart()
            chart.Width = 720
            chart.Height = 300
            chart.Left = 10
            chart.Top = chartIndex * 310

            Dim chartArea As New ChartArea()
            chartArea.AxisX.Minimum = 0

            chartArea.AxisX.MajorGrid.Enabled = False
            chartArea.AxisX.MinorGrid.Enabled = False
            chartArea.AxisY.MajorGrid.Enabled = False
            chartArea.AxisY.MinorGrid.Enabled = False

            chart.ChartAreas.Add(chartArea)

            Dim series As New Series("Pengambilan data ke " & kvp.Key)
            series.ChartType = SeriesChartType.Spline
            series.Color = Color.Orange

            For i As Integer = 0 To kvp.Value.Count - 1
                series.Points.AddXY(i, kvp.Value(i))
            Next

            chart.Series.Add(series)
            chart.Titles.Add("Pengambilan data ke " & kvp.Key)

            chartPanel.Controls.Add(chart)
            chartIndex += 1
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class