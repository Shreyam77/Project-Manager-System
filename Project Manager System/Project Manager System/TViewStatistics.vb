Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Public Class TViewStatistics
    Private Sub TViewStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        Chart1.Series.Clear()
        Chart1.Series.Add("Series 1")
        Chart1.Series("Series 1").ChartType = SeriesChartType.Pie
        Chart1.Series("Series 1").Points.AddXY("Completed Projects", TStats.cProjects)
        Chart1.Series("Series 1").Points.AddXY("Incomplete Projects", (TStats.tProjects - TStats.cProjects))
        Chart1.Series("Series 1")("PieLabelStyle") = "Outside"
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub
End Class

Class TStats
    Public Shared tProjects As Integer = Nothing
    Public Shared cProjects As Integer = Nothing
End Class