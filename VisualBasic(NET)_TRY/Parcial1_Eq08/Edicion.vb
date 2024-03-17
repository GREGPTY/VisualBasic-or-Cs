Imports MySql.Data.MySqlClient
Public Class Edicion
    Private Sub Conecta_EditP(ByVal sSql As String, ByVal Name As String)
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        oConexion.Open()
        oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
        oDataAdapter.Fill(oDataSet, "content")
        If (oDataSet.Tables("content").Rows.Count() = 0) Then
            MessageBox.Show("La pelicula buscada para editar, no existe")
        Else
            Edit_gb.Show()
            oConexion.Close()
            Edit(Name)
        End If
        oConexion.Close()
    End Sub
    Private Sub Conecta_Busca(ByVal sSQL As String)
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Try
            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(sSQL, oConexion)
            oDataAdapter.Fill(oDataSet, "content")
            oConexion.Close()
        Catch ex As Exception
            oConexion.Close()
            MessageBox.Show("Error")
        End Try
    End Sub
    Private Function IsInt(ByRef n As String) As Boolean
        Dim R As Boolean = True
        If (IsNumeric(n)) Then
            R = False
        Else
            MessageBox.Show("Una de las tablas ya sea [id] o [año], no es un valor numerico")
            R = True
        End If
        Return R
    End Function
    Private Sub Adde(ByVal Name As String, ByVal Gendero As String, ByVal Year As Integer, ByVal Duration As String, ByVal id As Integer)
        Dim Sql As String
        Sql = " insert into content(id,Titulo,Genero,Duracion,Year_M) values ('" & id & "','" & Name & "','" & Gendero & "','" & Duration & "','" & Year & "')ON DUPLICATE KEY UPDATE id = id+1;"
        Conecta_Busca(Sql)
        Gender.SelectedItem = Nothing
        Nameee.Text = Nothing
        Name_txt.Text = Nothing
        Time_txt.Text = Nothing
        Num_txt.Text = Nothing
    End Sub
    Private Sub Edit(ByVal Name As String)
        Dim Csql As String = Nothing
        Name_Edit_txt.Text = Name
        If (Columna_list.SelectedItem = Nothing) Then
            MessageBox.Show("Debe seleccionar una columna [La que va a editar exclusivamente]")
        Else
            If (Columna_list.SelectedItem = "Gender") Then
                If (Gender_Edit_lst.SelectedItem = "Terror" Or Gender_Edit_lst.SelectedItem = "Romance" Or
                    Gender_Edit_lst.SelectedItem = "Comedia" Or Gender_Edit_lst.SelectedItem = "Ciencia Ficcion" Or
                    Gender_Edit_lst.SelectedItem = "Aventura" Or Gender_Edit_lst.SelectedItem = "Accion" Or
                    Gender_Edit_lst.SelectedItem = "Animacion") Then
                    Csql = "Update content set Genero = '" & Gender_Edit_lst.SelectedItem & "' where Titulo = '" & Name & "';"
                    Conecta_Busca(Csql)
                Else
                    MessageBox.Show("El genero no esta en rango")
                End If
            ElseIf (Columna_list.SelectedItem = "Year") Then
                If (IsInt(year_Edit_txt.Text) Or year_Edit_txt.Text = Nothing Or year_Edit_txt.Text = "0") Then
                    MessageBox.Show("Introduzca un valor numerico")
                Else
                    Csql = "Update content set Year_M = '" & year_Edit_txt.Text & "' where Titulo = '" & Name & "';"
                    Conecta_Busca(Csql)
                End If
            ElseIf (Columna_list.SelectedItem = "Time") Then
                If (Time_Edit_txt.Text = Nothing) Then
                    MessageBox.Show("Como minimo añade 1 segundo")
                Else
                    Csql = "Update content set Duracion = '" & Time_Edit_txt.Text & "' where Titulo = '" & Name & "';"
                    Conecta_Busca(Csql)
                End If
            Else
                MessageBox.Show("No Esta disponible esa Columna")
            End If
            MessageBox.Show("Acción Realizada")
        End If
    End Sub

    Private Sub Delete(ByVal Name As String)
        Dim Sql As String
        Sql = "Delete From content Where Titulo = '" & Name & "'"
        Conecta_Busca(Sql)
        Name_txt.Text = Nothing
        Selection_sld.SelectedItem = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ADD_gb.Hide()
        If (Name_txt.Text = "") Then
            MessageBox.Show("El campo de nombre debe ser llenado")
        Else
            If (Selection_sld.SelectedItem = "" Or Selection_sld.SelectedItem = Nothing) Then
                MessageBox.Show("Debe Seleccionar una acción")
            ElseIf (Selection_sld.SelectedItem = "Agregar") Then
                Nameee.Text = Name_txt.Text
                ADD_gb.Show()
                'All the Bright Places 2

            ElseIf (Selection_sld.SelectedItem = "Editar") Then
                Dim NameO As String
                NameO = Name_txt.Text

                Dim FsQL As String
                FsQL = "Select * From content Where Titulo= '" & NameO & "';"
                Conecta_EditP(FsQL, NameO)
            ElseIf (Selection_sld.SelectedItem = "Eliminar") Then
                'Añadir un salvavidas
                Eliminar_gb.Show()
            End If
        End If
    End Sub

    Private Sub Edicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Edit_gb.Hide()
        ADD_gb.Hide()
        Eliminar_gb.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Name_txt.Text = Nothing
        Nameee.Text = Nothing
        id_txt.Text = Nothing
        Time_txt.Text = Nothing
        Gender.SelectedItem = Nothing
        ADD_gb.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Editar_Edit_btn_Click(sender As Object, e As EventArgs) Handles Editar_Edit_btn.Click
        Edit(Name_Edit_txt.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Columna_list.SelectedItem = Nothing
        Name_Edit_txt.Text = Nothing
        year_Edit_txt.Text = Nothing
        Gender_Edit_lst.SelectedItem = Nothing
        Time_Edit_txt.Text = Nothing
        Name_txt.Text = Nothing

        Edit_gb.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Delete(Name_txt.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Eliminar_gb.Hide()
        Name_txt.Text = Nothing
    End Sub

    Private Sub Find_btn_Click(sender As Object, e As EventArgs) Handles Find_btn.Click
        If (Nameee.Text = Nothing) Then
            MessageBox.Show("No puede dejar este campo vacio[Nombre]")
        Else
            If (Gender.SelectedItem = Nothing Or Gender.SelectedItem = "Seleccionar") Then
                MessageBox.Show("No puede dejar este campo vacio[Genero]")

            Else
                If (Num_txt.Text = "0" Or Num_txt.Text = Nothing Or IsInt(Num_txt.Text)) Then
                    MessageBox.Show("No puede dejar este campo vacio[Año]")

                Else
                    If (id_txt.Text = Nothing Or id_txt.Text = "0" Or IsInt(id_txt.Text)) Then
                        MessageBox.Show("No puede dejar este campo vacio[id]")
                    Else
                        If (Time_txt.Text = Nothing Or Time_txt.Text = "0") Then
                            MessageBox.Show("No puede dejar este campo vacio[Duracion]")
                        Else
                            Dim gene As String
                            Dim An, id As Integer
                            gene = Gender.SelectedItem
                            An = CInt(Num_txt.Text)
                            id = CInt(id_txt.Text)
                            Adde(Name_txt.Text, gene, An, Time_txt.Text, id)
                            Name_txt.Text = Nothing
                            Nameee.Text = Nothing
                            id_txt.Text = Nothing
                            Time_txt.Text = Nothing
                            Gender.SelectedItem = Nothing
                        End If
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub Cbo_Nombre_KeyPress(KeyAscii As Integer)
        KeyAscii = 0
    End Sub

    Private Sub cmbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Selection_sld.KeyPress, Columna_list.KeyPress, Gender_Edit_lst.KeyPress, Gender.KeyPress
        e.Handled = HandleBoolean
    End Sub
End Class