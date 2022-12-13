Imports System.Data.SqlClient
Public Class CreateNewProject
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Adding values to CreateProject
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("INSERT INTO CreateProject VALUES('" & class2.savedPID & "','" & Class1.savedSID & "','" & Class1.savedSName & "','" & TbProjectName.Text & "','" & RTbdescription.Text & "','" & TbVersion.Text & "','Opened','" & DateTime.Now.ToString & "','Not Submitted','Not Submitted','Not Submitted','Not Submitted')", con)
        con.Open()

        Try
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TbProjectName.Text = ""
        TbVersion.Text = ""
        RTbdescription.Text = ""

        LblPID.Text += 1
        MessageBox.Show("New Project Added")
        Me.Close()
        Home.Close()
        Home.Show()

    End Sub

    Private Sub CreateNewProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblPID.Text = class2.savedPID
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
    End Sub

    Private Sub LblPID_Click(sender As Object, e As EventArgs) Handles LblPID.Click

    End Sub
End Class
