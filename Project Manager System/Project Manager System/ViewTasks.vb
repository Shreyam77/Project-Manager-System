Imports System.Data.SqlClient
Public Class ViewTasks
    Private Sub ViewTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        'Adding ProjectName in ComboBox1
        Dim Str As String
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As SqlCommand = New SqlCommand("Select [Project Name] from CreateProject where SID='" & Class1.savedSID & "'", con)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Str = CStr((ds.Tables(0).Rows(i).Item(0)))
                ComboBox1.Items.Add(Str)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")


        'Adding tasks in ComboBox2
        Dim cmd As New SqlCommand("select Title from CreateTask where [Project Name]='" & ComboBox1.SelectedItem & "'", con)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim str As String

        Try
            con.Open()
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                str = CStr((ds.Tables(0).Rows(i).Item(0)))
                ComboBox2.Items.Add(str)
            Next
        Catch ex As Exception

        End Try



    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'For Description in Panel
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim da1 As New SqlDataAdapter
        Dim ds1 As New DataSet
        Dim cmd1 As New SqlCommand("Select Description,Status,Priority,Type from CreateTask where [Title]='" & ComboBox2.SelectedItem & "'", con)
        Try
            con.Open()
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            con.Close()
            LblDescription.Text = CStr(ds1.Tables(0).Rows(0).Item(0))
            LblStatus.Text = CStr(ds1.Tables(0).Rows(0).Item(1))
            LblPriority.Text = CStr(ds1.Tables(0).Rows(0).Item(2))
            LblType.Text = CStr(ds1.Tables(0).Rows(0).Item(3))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class