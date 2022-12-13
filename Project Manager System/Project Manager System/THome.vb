Imports System.Data.SqlClient
Public Class THome
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TViewProjects.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TViewStatistics.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub THome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        Label1.Text += Class1.savedTName

        'Inserting Values in datagridview
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select PID,[Project Name],Synopsis,DFD,ER,[Gantt Chart] from CreateProject", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds, "CreateProject")
            con.Close()
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "CreateProject"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Calculating Total Number of projects 
        Dim cmd1 As New SqlCommand("Select count(*) from CreateProject ", con)
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet

        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()
            TStats.tProjects = CInt((ds1.Tables(0).Rows(0).Item(0)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Calculating Completed Number of Projects
        Dim cmd2 As New SqlCommand("Select count(*) from CreateProject where Status='Completed' ", con)
        Dim da2 As New SqlDataAdapter
        Dim ds2 As New DataSet

        Try
            con.Open()
            da2.SelectCommand = cmd2
            da2.Fill(ds2)
            con.Close()
            TStats.cProjects = CInt((ds2.Tables(0).Rows(0).Item(0)))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class

Public Class Class3
    Public Shared savedPID As Integer = Nothing
    Public Shared ProjectName As String = Nothing
End Class