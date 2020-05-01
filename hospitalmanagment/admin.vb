Imports MySql.Data.MySqlClient
Public Class admin
    Dim result As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rgender As String
    Dim dgender As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        loginform.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        listofdoctorspanel.Visible = True
        doctorprofile.Visible = False
    End Sub
    Private Sub search_Click(sender As Object, e As EventArgs) Handles searchdocpro.Click
        listofdoctorspanel.Visible = True
        doctorprofile.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles doctorbuttonbutton.Click
        listofdoctorspanel.Visible = True
        listofreseptionist.Visible = False
        stockspanel.Visible = False
        doctorbuttonbutton.Enabled = False
        resepbuttonbutton.Enabled = True
        stocksbuttonbuttom.Enabled = True
        doctorprofile.Visible = False
    End Sub
    Private Sub resepbutton_Click(sender As Object, e As EventArgs) Handles resepbuttonbutton.Click
        listofdoctorspanel.Visible = False
        listofreseptionist.Visible = True
        stockspanel.Visible = False
        doctorbuttonbutton.Enabled = True
        resepbuttonbutton.Enabled = False
        stocksbuttonbuttom.Enabled = True
        doctorprofile.Visible = False
    End Sub
    Private Sub stocksbutton_Click(sender As Object, e As EventArgs) Handles stocksbuttonbuttom.Click
        listofdoctorspanel.Visible = False
        listofreseptionist.Visible = False
        stockspanel.Visible = True
        doctorbuttonbutton.Enabled = True
        resepbuttonbutton.Enabled = True
        stocksbuttonbuttom.Enabled = False
        doctorprofile.Visible = False
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles savereseptionist.Click
        addrepsuc.Visible = True
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            query = "select MAX(rid) from reseptionist"
            cmd = New MySqlCommand(query, conn)
            result = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(result) Then
                result = 3001
                query1 = "insert into hospitalmanagment.reseptionist (rid,name,qulification,dob,address,phoneno,gender) values ('" & result & "','" & addresepname.Text & "', '" & addresepqual.Text & "','" & addresepdod.Text & "','" & addresepaddress.Text & "', '" & addresepphno.Text & "','" & rgender & "' )"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            Else
                result = result + 1
                query1 = "insert into hospitalmanagment.reseptionist (rid,name,qulification,dob,address,phoneno,gender) values ('" & result & "','" & addresepname.Text & "', '" & addresepqual.Text & "','" & addresepdod.Text & "','" & addresepaddress.Text & "', '" & addresepphno.Text & "','" & rgender & "' )"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            End If
            MessageBox.Show("User_Name='" & TextBox1.Text & "'" & vbCrLf & "userid='" & result & "'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addresepname.Text = ""
            addresepqual.Text = ""

            addresepaddress.Text = ""
            addresepphno.Text = ""
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            conn.Open()
            Dim query2 As String
            query2 = "insert into hospitalmanagment.login (userid , usertype) values ('" & result & "','" & reseplab.Text & "' )"
            cmd = New MySqlCommand(query2, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub addreseptionist_Click(sender As Object, e As EventArgs) Handles addreseptionist.Click
        addreseppanel.Visible = True
        deleteresppanel.Visible = False
        modifyreseppanel.Visible = False
        profileresp.Visible = False
        addrepsuc.Visible = False
    End Sub
    Private Sub modifyresptionist_Click(sender As Object, e As EventArgs) Handles modifyresptionist.Click
        addreseppanel.Visible = False
        deleteresppanel.Visible = False
        modifyreseppanel.Visible = True
        profileresp.Visible = False
        modrespsuc.Visible = False
    End Sub
    Private Sub deletereseptionist_Click(sender As Object, e As EventArgs) Handles deletereseptionist.Click
        addreseppanel.Visible = False
        deleteresppanel.Visible = True
        modifyreseppanel.Visible = False
        profileresp.Visible = False
        deleteressucc.Visible = False
    End Sub
    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        addreseppanel.Visible = False
        deleteresppanel.Visible = False
        modifyreseppanel.Visible = False
        profileresp.Visible = True
    End Sub
    Private Sub cancelresep_Click(sender As Object, e As EventArgs) Handles cancelresep.Click
        deleteresppanel.Visible = False
    End Sub
    Private Sub cancelresepmod_Click(sender As Object, e As EventArgs) Handles cancelresepmod.Click
        modifyreseppanel.Visible = False
    End Sub
    Private Sub backaddresept_Click(sender As Object, e As EventArgs) Handles backaddresept.Click
        addreseppanel.Visible = False
    End Sub
    Private Sub backpro_Click(sender As Object, e As EventArgs) Handles backpro.Click
        profileresp.Visible = False
    End Sub
    Private Sub adddocbutton_Click(sender As Object, e As EventArgs) Handles adddocbutton.Click
        adddocpanel.Visible = True
        deletedocpanel.Visible = False
        modifyreseppanel.Visible = False
        doctorprofile.Visible = False
    End Sub
    Private Sub modifydocbutton_Click(sender As Object, e As EventArgs) Handles modifydocbutton.Click
        adddocpanel.Visible = False
        deletedocpanel.Visible = False
        modidydocpanel.Visible = True
        doctorprofile.Visible = False
    End Sub
    Private Sub deletedocbutton_Click(sender As Object, e As EventArgs) Handles deletedocbutton.Click
        adddocpanel.Visible = False
        deletedocpanel.Visible = True
        modifyreseppanel.Visible = False
        doctorprofile.Visible = False
    End Sub
    Private Sub canceladdoc_Click(sender As Object, e As EventArgs) Handles canceladdoc.Click
        adddocpanel.Visible = False
    End Sub
    Private Sub saveadddoc_Click(sender As Object, e As EventArgs) Handles saveadddoc.Click
        addsuccess.Visible = True
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            Dim query1 As String
            Dim result As String
            query = "select MAX(doctorid) from doctor"
            cmd = New MySqlCommand(query, conn)
            result = cmd.ExecuteScalar().ToString()
            If String.IsNullOrEmpty(result) Then
                result = 2001
                query1 = "insert into hospitalmanagment.doctor (doctorid,doctorname,qualification,specialization,dob,address,phoneno,email ,gender ) values ('" & result & "','" & adddocname.Text & "', '" & adddocquali.Text & "','" & adddocspeci.Text & "','" & adddocdob.Text & "','" & adddocaddress.Text & "', '" & adddocphno.Text & "','" & adddocemail.Text & "','" & dgender & "')"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            Else
                result = result + 1
                query1 = "insert into hospitalmanagment.doctor (doctorid,doctorname,qualification,specialization,dob,address,phoneno,email ,gender ) values ('" & result & "','" & adddocname.Text & "', '" & adddocquali.Text & "','" & adddocspeci.Text & "','" & adddocdob.Text & "','" & adddocaddress.Text & "', '" & adddocphno.Text & "','" & adddocemail.Text & "','" & dgender & "')"
                cmd = New MySqlCommand(query1, conn)
                reader = cmd.ExecuteReader
            End If
            MessageBox.Show("doctorname='" & TextBox1.Text & "'" & vbCrLf & "doctorid='" & result & "'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            conn.Open()
            Dim query2 As String
            query2 = "insert into hospitalmanagment.login (userid , usertype) values ('" & result & "','" & doctorlab.Text & "' )"
            cmd = New MySqlCommand(query2, conn)
            reader = cmd.ExecuteReader
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        adddocpanel.Visible = False
        addsuccess.Visible = False
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles cancelmod.Click
        modidydocpanel.Visible = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.doctor set gender='" & dgender & "', email ='" & mdocmail.Text & "', doctorname='" & mdocname.Text & "',qualification ='" & mdocqual.Text & "',specialization ='" & mdocseci.Text & "',phoneno='" & mdocphno.Text & "',address ='" & modifiydocddress.Text & "'where doctorid='" & combomododc.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
            moddocsucce.Visible = True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        modidydocpanel.Visible = False
        moddocsucce.Visible = False
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        deldosuccess.Visible = False
        deletedocpanel.Visible = False
    End Sub
    Private Sub deletedoc_Click(sender As Object, e As EventArgs) Handles deletedoc.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " delete from hospitalmanagment.doctor where doctorid='" & combodeldoc.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
            deldosuccess.Visible = True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub deletedoccancel_Click(sender As Object, e As EventArgs) Handles deletedoccancel.Click
        deletedocpanel.Visible = False
    End Sub
    Private Sub deteleresep_Click(sender As Object, e As EventArgs) Handles deteleresep.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " delete from hospitalmanagment.reseptionist where rid='" & combodelrid.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
            deleteressucc.Visible = True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        deleteresppanel.Visible = False
    End Sub
    Private Sub modifyresep_Click(sender As Object, e As EventArgs) Handles modifyresep.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.reseptionist set name='" & resepnamemod.Text & "',qulification ='" & resepqualmod.Text & "',gender ='" & rgender & "',dob ='" & resepdobmod.Text & "',phoneno='" & resepphnomod.Text & "',address ='" & resepadressmod.Text & "' ,gender = '" & rgender & "' where rid = '" & combomodrid.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
            modrespsuc.Visible = True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        modifyreseppanel.Visible = False
        modrespsuc.Visible = False
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        addreseppanel.Visible = False
        addsuccess.Visible = False
    End Sub
    Private Sub load_table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim sda As New MySqlDataAdapter
        Dim bddataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select rid , name ,gender , phoneno from hospitalmanagment.reseptionist"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(bddataset)
            bsource.DataSource = bddataset
            DataGridView1.DataSource = bsource
            sda.Update(bddataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub listofreseptionist_Paint(sender As Object, e As PaintEventArgs) Handles listofreseptionist.Paint
        load_table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("rid")
                ComboBox1.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub listofdoctorspanel_Paint(sender As Object, e As PaintEventArgs) Handles listofdoctorspanel.Paint
        load_doctable()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("doctorid")
                combodocpro.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub load_doctable()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim sda As New MySqlDataAdapter
        Dim bddataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "select doctorid , doctorname ,specialization , phoneno from hospitalmanagment.doctor"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(bddataset)
            bsource.DataSource = bddataset
            DataGridView2.DataSource = bsource
            sda.Update(bddataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub savestock_Click(sender As Object, e As EventArgs) Handles savestock.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = " update hospitalmanagment.stock set gloves ='" & glovescount.Text & "', mask='" & maskscount.Text & "',sthethoscope ='" & sthethoscopecount.Text & "',syringes ='" & syringescount.Text & "',sanitizers ='" & sanitizerscount.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            conn.Close()
            moddocsucce.Visible = True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub modifyreseppanel_Paint(sender As Object, e As PaintEventArgs) Handles modifyreseppanel.Paint
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("rid")
                combomodrid.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub deleteresppanel_Paint(sender As Object, e As PaintEventArgs) Handles deleteresppanel.Paint
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("rid")
                combodelrid.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        rgender = "Male"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        rgender = "Female"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        rgender = "Male"
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        rgender = "Female"
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        rgender = "Male"
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        rgender = "Female"
    End Sub
    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        dgender = "Male"
    End Sub
    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        dgender = "Female"
    End Sub
    Private Sub deletedocpanel_Paint(sender As Object, e As PaintEventArgs) Handles deletedocpanel.Paint
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim did = reader.GetString("doctorid")
                combodeldoc.Items.Add(did)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor where doctorid='" & combodeldoc.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                ddocname.Text = reader.GetString("doctorname")
                ddocadress.Text = reader.GetString("address")
                ddocemail.Text = reader.GetString("email")
                ddocphno.Text = reader.GetString("phoneno")
                ddocquali.Text = reader.GetString("qualification")
                ddocsecif.Text = reader.GetString("specialization")
                deletedoc.Enabled = True
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub modidydocpanel_Paint(sender As Object, e As PaintEventArgs) Handles modidydocpanel.Paint
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim rid = reader.GetString("doctorid")
                combomododc.Items.Add(rid)
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub msearchdoc_Click(sender As Object, e As EventArgs) Handles msearchdoc.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor where doctorid='" & combomododc.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                mdocname.Text = reader.GetString("doctorname")
                modifiydocddress.Text = reader.GetString("address")
                mdocmail.Text = reader.GetString("email")
                mdocphno.Text = reader.GetString("phoneno")
                mdocqual.Text = reader.GetString("qualification")
                mdocseci.Text = reader.GetString("specialization")
                Button7.Enabled = True
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        doctorprofile.Visible = True
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.doctor where doctorid='" & combodocpro.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                TextBox1.Text = reader.GetString("doctorid")
                TextBox2.Text = reader.GetString("doctorname")
                TextBox4.Text = reader.GetString("address")
                TextBox6.Text = reader.GetString("email")
                TextBox5.Text = reader.GetString("phoneno")
                TextBox7.Text = reader.GetString("qualification")
                TextBox3.Text = reader.GetString("specialization")
                Button7.Enabled = True
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub searchresepdel_Click(sender As Object, e As EventArgs) Handles searchresepdel.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist where rid='" & combodelrid.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                reseptionistname.Text = reader.GetString("name")
                TextBox18.Text = reader.GetString("address")
                resepdod.Text = reader.GetString("dob")
                resepgender.Text = reader.GetString("gender")
                resepphno.Text = reader.GetString("phoneno")
                TextBox8.Text = reader.GetString("qulification")
                deteleresep.Enabled = True
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist where rid='" & combomodrid.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                resepnamemod.Text = reader.GetString("name")
                resepadressmod.Text = reader.GetString("address")
                resepdobmod.Text = reader.GetString("dob")
                resepphnomod.Text = reader.GetString("phoneno")
                resepqualmod.Text = reader.GetString("qulification")
                modifyresep.Enabled = True
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        profileresp.Visible = True
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=pubg;database=hospitalmanagment"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * from hospitalmanagment.reseptionist where rid='" & ComboBox1.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                TextBox21.Text = reader.GetString("rid")
                respnamepro.Text = reader.GetString("name")
                resepaddresspro.Text = reader.GetString("address")
                resepdobpro.Text = reader.GetString("dob")
                resepgender.Text = reader.GetString("gender")
                resepphnopro.Text = reader.GetString("phoneno")
                resepqualipro.Text = reader.GetString("qulification")
                resepgenderpro.Text = reader.GetString("gender")
            Else
                MessageBox.Show("records not found")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class