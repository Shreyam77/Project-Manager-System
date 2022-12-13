Imports System.Data.SqlClient
Public Class RegisterTeacher
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        TbTID.Text = "101"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")

        'Generating TID
        Dim cmd As New SqlCommand("Select TID from RegisterTeacher", con)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        con.Open()

        Try
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                TbTID.Text = CInt((ds.Tables(0).Rows(i).Item(0))) + 1
                TbTID.Enabled = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnTeacherRegister_Click(sender As Object, e As EventArgs) Handles BtnTeacherRegister.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As SqlCommand = New SqlCommand("INSERT into RegisterTeacher values ('" & TbTID.Text & "','" & TbUsername.Text & "','" & TbPassword.Text & "')", con)
        con.Open()

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MessageBox.Show("Successfully Registered")
        Me.Close()
    End Sub

End Class