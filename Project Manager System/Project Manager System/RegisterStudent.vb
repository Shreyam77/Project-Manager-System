Imports System.Data.SqlClient
Public Class RegisterStudent
    Private Sub BtnStudentRegister_Click(sender As Object, e As EventArgs) Handles BtnStudentRegister.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As SqlCommand = New SqlCommand("INSERT into RegisterStudent values ('" & TbSID.Text & "','" & TbUsername.Text & "','" & TbPassword.Text & "')", con)
        con.Open()

        If TbReTypePassword.Text <> TbPassword.Text Then
            MessageBox.Show("Password and Re-Type Password should be same")
        ElseIf TbUsername.Text = TbPassword.Text Then
            MessageBox.Show("Username and Password cannot be same")
        Else
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            TbUsername.Text = Nothing
            TbPassword.Text = Nothing
            TbReTypePassword.Text = Nothing
            TbGroupMember.Text = Nothing

            MessageBox.Show("Successfully Registered")
            Me.Close()
        End If
    End Sub

    Private Sub RegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)

        TbSID.Text = "101"
        CBoxGroupID.Items.Add("1")
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")

        'Adding GroupID to ComboBox
        'Dim cmd2 As New SqlCommand("Select distinct GroupID from RegisterStudent", con)
        'Dim da2 As New SqlDataAdapter
        'Dim ds2 As New DataSet
        'con.Open()

        'Try
        'da2.SelectCommand = cmd2
        'da2.Fill(ds2)
        'con.Close()

        'For i = 0 To ds2.Tables(0).Rows.Count - 1
        'CBoxGroupID.Items.Add(CInt((ds2.Tables(0).Rows(i).Item(0))) + 1)
        'CBoxGroupID.SelectedValue = (CInt((ds2.Tables(0).Rows(i).Item(0))) + 1)
        'Next


        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

        'Generating SID
        Dim cmd As New SqlCommand("Select SID from RegisterStudent", con)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        con.Open()

        Try
            da.SelectCommand = cmd
            da.Fill(ds)
            con.Close()

            For i = 0 To ds.Tables(0).Rows.Count - 1
                TbSID.Text = CInt((ds.Tables(0).Rows(i).Item(0))) + 1
                TbSID.Enabled = False
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Generating GroupID
        'Dim cmd1 As New SqlCommand("Select GroupID from RegisterStudent", con)
        'Dim da1 As New SqlDataAdapter
        'Dim ds1 As New DataSet
        'con.Open()

        'Try
        ' da1.SelectCommand = cmd1
        ' da1.Fill(ds1)
        ' con.Close()

        'For i = 0 To ds.Tables(0).Rows.Count - 1
        ' CBoxGroupID.Text = CInt((ds1.Tables(0).Rows(i).Item(0))) + 1
        ' Next

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

        'TbGroupMember.Text = Nothing

    End Sub


    Private Sub CBoxGroupID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxGroupID.SelectedIndexChanged

        'Changing Group member
        'TbGroupMember.Text = Nothing
        'Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shreyam\Documents\PMS_Database.mdf;Integrated Security=True;Connect Timeout=30")
        'Dim cmd As New SqlCommand("Select SName from RegisterStudent where GroupID='" & CBoxGroupID.SelectedItem & "'", con)
        'Dim da As New SqlDataAdapter
        'Dim ds As New DataSet
        'con.Open()

        'Try
        'da.SelectCommand = cmd
        'da.Fill(ds)
        'con.Close()

        'For i = 0 To ds.Tables(0).Rows.Count - 1
        'If i = 0 Then
        'TbGroupMember.Text = CStr((ds.Tables(0).Rows(i).Item(0)))
        'ElseIf i = 1 Then
        'TbGroupMember.Text = "Not Available"
        'End If
        'Next

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

        'If TbGroupMember.Text = "Not Available" Then
        'BtnStudentRegister.Enabled = False
        'Else
        'BtnStudentRegister.Enabled = True
        'End If
    End Sub
End Class