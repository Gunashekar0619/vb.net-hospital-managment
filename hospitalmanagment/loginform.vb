Imports MySql.Data.MySqlClient

Public Class loginform
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub signup_Click(sender As Object, e As EventArgs) Handles signup.Click
        signupwin.Visible = True
        loginwin.Visible = False
    End Sub

    Private Sub login2_Click(sender As Object, e As EventArgs) Handles login2.Click
        loginwin.Visible = True
        signupwin.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dectorform.Close()
        reseptionistform.Close()
        admin.Close()
        Me.Close()

    End Sub

    Private Sub signup2_Click(sender As Object, e As EventArgs) Handles signup2.Click

        loginwin.Visible = True
        signupwin.Visible = False
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.login set password ='" & newpassword.Text & "' where userid ='" & userid2.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            MessageBox.Show("sinup done successfull ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "Select * from hospitalmanagment.login where userid='" & userid.Text & "' and password='" & password.Text & "'"
            Cmd = New MySqlCommand(query, conn)
            reader = Cmd.ExecuteReader
            Dim count As Integer
            Dim usertype As String
            count = 0
            While reader.Read
                count = count + 1
                usertype = reader.GetString("usertype")
            End While
            If count = 1 Then
                If usertype = "admin" Then
                    MessageBox.Show("login successfull")
                    admin.Show()
                ElseIf usertype = "doctor" Then
                    MessageBox.Show("login successfull")
                    dectorform.Show()
                ElseIf usertype = "reseptionist" Then
                    MessageBox.Show("login successfull")
                    reseptionistform.Show()
                End If
            ElseIf userid.Text = "" Then
                MessageBox.Show("userid or password should not be empty")
            Else
                MessageBox.Show("incorrect")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class