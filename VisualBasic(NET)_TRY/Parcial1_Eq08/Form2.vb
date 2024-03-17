Imports MySql.Data.MySqlClient
Public Class Form2

    Dim sSql As String

    Private Sub Salirf2_btn_Click(sender As Object, e As EventArgs) Handles Salirf2_btn.Click
        Application.Exit()
    End Sub
    Private Function Clean()
        Return "SELECT * FROM content Where Title=''"
    End Function
    Private Function All() 'all
        Return "SELECT * FROM content"
    End Function
    Private Function Year_Only(ByVal year As Integer) 'only year
        Return "SELECT * FROM content where Year_M = '" & year & "'"
    End Function
    Private Function Gender_Only(ByVal Gender As String) 'only gender
        Return "SELECT * FROM content where Genero = '" & Gender & "'"
    End Function
    Private Function tittle_Only(ByVal tittle As String) 'only Tittle
        Return "SELECT * FROM content where Titulo = '" & tittle & "'"
    End Function
    Private Function Gender_Year(ByVal gender As String, ByVal year As Integer) 'gender and year
        Return ("SELECT * FROM content where Genero = '" & gender & "' AND Year_M = '" & year & "'")
    End Function
    Private Function tittle_Year(ByVal tittle As String, ByVal year As Integer) 'only Tittle
        Return "SELECT * FROM content where Titulo = '" & tittle & "' AND Year_M = '" & year & "'"
    End Function
    Private Function tittle_Gender(ByVal tittle As String, ByVal gender As String) 'only Tittle
        Return "SELECT * FROM content where Titulo = '" & tittle & "' AND Genero = '" & gender & "'"
    End Function
    Private Function tittle_Gender_Year(ByVal tittle As String, ByVal gender As String, ByVal year As Integer) 'only Tittle
        Return "SELECT * FROM content where Titulo = '" & tittle & "' AND Genero = '" & gender & "' AND Year_M = " & year & ""
    End Function
    Private Sub Busqueda(ByVal Titulo As String, ByVal Genero As String, ByVal year As Integer)
        Dim ssq As String
        If Titulo = "" And Genero = "Seleccionar" And year = 0 Then
            ssq = All()
        ElseIf Titulo = "" And Genero = "Seleccionar" Then
            ssq = Year_Only(year)
        ElseIf Titulo = "" And year = 0 Then
            ssq = Gender_Only(Genero)
        ElseIf Genero = "Seleccionar" And year = 0 Then
            ssq = tittle_Only(Titulo)
        ElseIf Titulo = "" Then
            ssq = Gender_Year(Genero, year)
        ElseIf Genero = "Seleccionar" Then
            ssq = tittle_Year(Titulo, year)
        ElseIf year = 0 Then
            ssq = tittle_Gender(Titulo, Genero)
        Else
            ssq = tittle_Gender_Year(Titulo, Genero, year)
        End If
        Conecta_Busca(ssq)
    End Sub

    Private Sub Conecta_Busca(ByVal sSQL As String)
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Dim commando As New MySqlCommand, READER As MySqlDataReader
        Try
            Movie_cb.Items.Clear()
            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(sSQL, oConexion)
            commando = New MySqlCommand(sSQL, oConexion)
            oDataAdapter.Fill(oDataSet, "content")
            DataGridView1.DataSource = oDataSet
            DataGridView1.DataMember = "content" 'tabla
            READER = commando.ExecuteReader
            While READER.Read 'combobox por comando
                Dim CatM = READER.GetString("Titulo")
                Movie_cb.Items.Add(CatM)
            End While
            'combo box solo para mostrar
            'Movie_cb.DataSource = oDataSet.Tables("content")
            'Movie_cb.DisplayMember = "Titulo"
            oConexion.Close()
        Catch ex As Exception
            oConexion.Close()
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Find_btn_Click(sender As Object, e As EventArgs) Handles Find_btn.Click

        Dim A As Integer
        Dim B As String, T As String
        If IsNumeric(Num_txt.Text) Then
            A = CInt(Num_txt.Text)
        Else
            MessageBox.Show("No es valido, en año se pondra 0")
            Num_txt.Text = "0"
            A = (Num_txt.Text)
        End If
        If Name_txt.Text = "T" Then
            T = ""
        Else
            T = Name_txt.Text
        End If
        B = Gender.SelectedItem
        Busqueda(T, B, A)
        Num_txt.Text = 0
        Name_txt.Text = "T"
        Gender.SelectedItem = "Seleccionar"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Movie_cb.DataSource = Nothing
        Movie_cb.Items.Clear()
        DataGridView1.Columns.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Consulta.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sqql As String
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '

        sqql = "SELECT * FROM usuario Where (plan = 'BigBoss' or plan ='Boss') and nom_usr= '" & Usuario_Name & "';"
        Try
            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(sqql, oConexion)
            oDataAdapter.Fill(oDataSet, "usuario")
            If (oDataSet.Tables("usuario").Rows.Count() = 0) Then
                MessageBox.Show("Usted No tiene el permiso para acceder a esta opción")
            Else
                Me.Hide()
                Edicion.Show()
            End If
            oConexion.Close()
        Catch ex As Exception
            oConexion.Close()
            MessageBox.Show("Error")
        End Try


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver_img.Hide()
        GB_img.Hide()
        Num_txt.Text = 0
        Name_txt.Text = "T"
        Gender.SelectedItem = "Seleccionar"
    End Sub

    Private Sub Ver_btn_Click(sender As Object, e As EventArgs) Handles Ver_btn.Click
        If (Movie_cb.SelectedItem = Nothing) Then
            MessageBox.Show("Debes seleccionar una pelicula")
        Else
            GB_img.Show()
            ver_img.Show()
        End If
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        ver_img.Hide()
        GB_img.Hide()
    End Sub

    Private Sub Cbo_Nombre_KeyPress(KeyAscii As Integer)
        KeyAscii = 0
    End Sub
    Private Sub cmbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Movie_cb.KeyPress
        e.Handled = HandleBoolean
    End Sub
End Class