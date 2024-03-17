Imports MySql.Data.MySqlClient
Public Class Form1
    Public cant As Integer = 0
    Function existeusuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim oConexion As New MySqlConnection, oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Dim sSql As String, sw As Boolean = False
        Try

            oConexion.ConnectionString = "server=localhost;database=Netflix_Regist; user id=root;password=123456789;"
            sSql = "SELECT * FROM usuario Where nom_usr= '" & usuario & "' and pass_word= '" & password & "' "
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
            oConexion.Open()
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuario")
            If (oDataSet.Tables("usuario").Rows.Count() = 0) Then
                If cant = 3 Then
                    MessageBox.Show("Numero de intentos Alcanzados, No puede ingresar al sistema", "Sistema")
                    Me.Close()
                Else
                    MessageBox.Show("Usuario y/o Password no válidos", "Sistema")
                    Usuario_txt.Text = ""
                    Contrasena_txt.Text = ""
                    Usuario_txt.Focus()
                    sw = False
                End If
                cant = cant + 1
            Else

                MessageBox.Show("Bienvenido al Sistema", "Sistema")
                sw = True
            End If
            oConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
        Return (sw)
    End Function

    Private Sub Ingresar_btn_Click(sender As Object, e As EventArgs) Handles Ingresar_btn.Click
        If (existeusuario(Usuario_txt.Text, Contrasena_txt.Text)) Then
            Usuario_Name = Usuario_txt.Text
            Usuario_PassWord = Contrasena_txt.Text
            MostrarImagen()
        End If

    End Sub

    Private Sub Salir_btn_Click(sender As Object, e As EventArgs) Handles Salir_btn.Click
        Application.Exit()
    End Sub

    Private Sub PáginaDePresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PáginaDePresentaciónToolStripMenuItem.Click
        MsgBox("Universidad Tecnológica de Panamá" & vbNewLine & "Facultad de Ingeniería de Sistemas Computacionales" & vbNewLine & "Herramientas de Programación Aplicadas III" & vbNewLine & vbNewLine & "Proyecto Final" & vbNewLine & "Animación y Gráficos" & vbNewLine & vbNewLine & "Falicitador(a): Anna Araba de Ruiz" & vbNewLine & vbNewLine & "Equipo 08:" & vbNewLine & "Anthony Avila (20-70-4203)" & vbNewLine & "Daniel Tejera (8-967-1202)" & vbNewLine & "José Torres (8-955-1617)" & vbNewLine & "Greg Torres (8-956-675)" & vbNewLine & "Piero Zavaleta (8-991-519)" & vbNewLine & vbNewLine & "Grupo: 1IL-132" & vbNewLine & vbNewLine & "JULIO DE 2021")
    End Sub

    Private Sub CrearNuevoUser(ByVal usuario As String, ByVal password As String, ByVal Email As String, ByVal Credit_Card As String, ByVal Membresia As String)
        Dim oConexion As New MySqlConnection, oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Dim sSql As String, sw As Boolean = False
        Try
            oConexion.ConnectionString = "server=localhost;database=Netflix_Regist; user id=root;password=123456789;"
            sSql = "INSERT INTO usuario(nom_usr,pass_word,email,credit_card,plan) values('" & usuario & "', '" & password & "', '" & Email & "','" & Credit_Card & "','" & Membresia & "')"
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
            oConexion.Open()
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuario")
            oConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub

    Private Sub VersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiónToolStripMenuItem.Click
        MsgBox("Versión Visual Basic: 2019")
    End Sub

    Private Sub SignUp_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUp_link.LinkClicked
        SignIn_box.Hide()
        SignUp_box.Show()
    End Sub

    Sub MostrarImagen()
        ImagBox.Show()
        Timer1.Start()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImagBox.Hide()
        SignUp_box.Hide()
        SignIn_box.Show()
        Step1of3_box.Hide()
        Step2of3_box.Hide()
        Step3of3_box.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Email_txt.Text = "" Or Email_txt.Text = "Correo" Or Email_txt.Text = "Corre" Or Email_txt.Text = "Corr" Or Email_txt.Text = "Cor" Or Email_txt.Text = "Co" Or Email_txt.Text = "C" Or Email_txt.Text = Nothing) Then
            MessageBox.Show("Email no valido")
        Else
            Email2_txt.Text = Email_txt.Text
            SignUp_box.Hide()
            Step1of3_box.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Password_txt.Text = Nothing Or Password_txt.Text = "") Then
            MessageBox.Show("El campo de la contraseña no puede estar vacio")
        Else
            If (User_txt.Text = Nothing Or User_txt.Text = "") Then
                MessageBox.Show("El campo del nombre de usuario no puede estar vacio")
            Else
                Step1of3_box.Hide()
                Step2of3_box.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Plan_list.SelectedItem = Nothing) Then
            MessageBox.Show("Debes seleccionar un plan")
        Else
            Step2of3_box.Hide()
            Step3of3_box.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Card_list.SelectedItem = Nothing) Then
            MessageBox.Show("Debes seleccionar una Tarjeta")
        Else
            Step3of3_box.Hide()
            CrearNuevoUser(User_txt.Text, Password_txt.Text, Email_txt.Text, Card_list.SelectedItem, Plan_list.SelectedItem)
            SignIn_box.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Step3of3_box.Hide()
        Step2of3_box.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Step2of3_box.Hide()
        Step1of3_box.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Step1of3_box.Hide()
        SignUp_box.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SignUp_box.Hide()
        SignIn_box.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim D As Integer = 0
        Do
            D = D + 1
        Loop While D < 10000

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Consulta.Show()

    End Sub

    Private Sub Log_Out_btn_Click(sender As Object, e As EventArgs) Handles Log_Out_btn.Click
        ImagBox.Hide()
        SignUp_box.Hide()
        SignIn_box.Show()
        Step1of3_box.Hide()
        Step2of3_box.Hide()
        Step3of3_box.Hide()
        Usuario_txt.Text = Nothing
        Contrasena_txt.Text = ""
        Contrasena_txt.Text = Nothing
        Usuario_Name = Nothing
        Usuario_PassWord = Nothing
    End Sub
    Private Sub Cbo_Nombre_KeyPress(KeyAscii As Integer)
        KeyAscii = 0
    End Sub
    Private Sub cmbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Card_list.KeyPress, Plan_list.KeyPress
        e.Handled = Usuario.HandleBoolean
    End Sub
End Class
