Imports MySql.Data.MySqlClient
Public Class Consulta
    Dim anim As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub RealizarCambiosSQL(ByVal sSql As String)
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Try
            oConexion.Open()
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
            oDataAdapter.Fill(oDataSet, "usuario")
            oConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Muestra_UsuariosList()
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Dim READER As MySqlDataReader, commando As MySqlCommand
        Dim sSql As String, sw As Boolean = False
        Accion_lst.Items.Clear()
        Try
            sSql = "Select * from usuario where plan not in ('BigBoss') ;"
            oConexion.Open()
            commando = New MySqlCommand(sSql, oConexion)
            oDataSet.Clear()
            READER = commando.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("nom_usr")
                Accion_lst.Items.Add(sName)
            End While
            'Accion_lst.DataSource = oDataSet.Tables("usuario")
            'Accion_lst.DisplayMember = "nom_usr"
            oConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
    Private Function Existeusuari() As Boolean
        Dim oConexion As New MySqlConnection("server=localhost;database=Netflix_Regist; user id=root;password=123456789;")
        Dim oDataAdapter As New MySqlDataAdapter, oDataSet As New DataSet '
        Dim sSql As String, sw As Boolean
        Try
            sSql = "SELECT * FROM usuario Where (plan = 'BigBoss' or plan ='Boss') and nom_usr= '" & Usuario_Name & "';"
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)
            oConexion.Open()
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuario")
            If (oDataSet.Tables("usuario").Rows.Count() = 0) Then
                sw = False
                UserEdit_btn.Show()
                oConexion.Close()
            Else
                sw = True
                UserEdit_btn.Show()
                oConexion.Close()
            End If
            oConexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error")
            oConexion.Close()
        End Try
        Return sw
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Imagen.Click

    End Sub

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Existeusuari()
        EditUser_gb.Hide()
        ECU_gb.Hide()
        EU_gb.Hide()
        Edit_lbl.Show()
        Edit_lbl.Text = "Bienvenido Usuario de Categoria ' Boss ' , ya usted sabe que hacer."
        'AoSU_gb.Hide()
    End Sub

    Private Sub tmr_Animacion_Tick(sender As Object, e As EventArgs) Handles tmr_Animacion.Tick
        Select Case anim
            Case 1
                Imagen.Image = My.Resources.frame_1
                anim += 1
            Case 2
                Imagen.Image = My.Resources.frame_2
                anim += 1
            Case 3
                Imagen.Image = My.Resources.frame_3
                anim += 1
            Case 4
                Imagen.Image = My.Resources.frame_4
                anim += 1
            Case 5
                Imagen.Image = My.Resources.frame_5
                anim += 1
            Case 6
                Imagen.Image = My.Resources.frame_6
                anim += 1
            Case 7
                Imagen.Image = My.Resources.frame_7
                anim += 1
            Case 8
                Imagen.Image = My.Resources.frame_8
                anim = 1
        End Select
    End Sub

    Private Sub LogOut_btn_Click(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Atras_btn_Click(sender As Object, e As EventArgs) Handles Atras_btn.Click
        EditUser_gb.Hide()
        Accion_lst.SelectedItem = Nothing
        AccionJeje_lst.SelectedItem = Nothing
    End Sub

    Private Sub UserEdit_btn_Click(sender As Object, e As EventArgs) Handles UserEdit_btn.Click
        If (Existeusuari()) Then
            EditUser_gb.Show()
        Else
            MessageBox.Show("Usted no tiene el rango de categoria 'Boss'")
        End If
    End Sub

    Private Sub Cbo_Nombre_KeyPress(KeyAscii As Integer)
        KeyAscii = 0
    End Sub

    Private Sub cmbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Accion_lst.KeyPress, AccionJeje_lst.KeyPress, ECU_Accion_lst.KeyPress
        e.Handled = HandleBoolean
    End Sub

    Private Sub Hacer_btn_Click(sender As Object, e As EventArgs) Handles Hacer_btn.Click
        If (AccionJeje_lst.SelectedItem = Nothing) Then
            MessageBox.Show("Debes Seleccionar una acción a realizar")
        Else
            If ((AccionJeje_lst.SelectedItem = "Editar Categoria del Usuario" Or
               AccionJeje_lst.SelectedItem = "Eliminar Usuario") And
                Accion_lst.SelectedItem = Nothing) Then
                MessageBox.Show("Debes Seleccionar un Usuario para realizar esa acción")
            Else
                If (AccionJeje_lst.SelectedItem = "Editar Categoria del Usuario") Then 'Editar Categoria
                    'MessageBox.Show("A " & Accion_lst.SelectedItem & " se le realizara " & AccionJeje_lst.SelectedItem)
                    ECU_Name_Lbl.Text = "El Usuario [" & Accion_lst.SelectedItem & "]" & vbCrLf &
                                         "sera cambiado a la siguiente categoria"
                    ECU_gb.Show()
                ElseIf (AccionJeje_lst.SelectedItem = "Eliminar Usuario") Then 'Editar Categoria
                    'MessageBox.Show("A " & Accion_lst.SelectedItem & " se le realizara " & AccionJeje_lst.SelectedItem)
                    EU_Name_Lbl.Text = "El Usuario [" & Accion_lst.SelectedItem & "]" & vbCrLf &
                                        "sera Eliminado del Registro"
                    EU_gb.Show()
                End If
            End If
        End If
    End Sub

    Private Sub EditUser_gb_Enter(sender As Object, e As EventArgs) Handles EditUser_gb.Enter
        Muestra_UsuariosList()
    End Sub

    Private Sub Atras1_btn_Click(sender As Object, e As EventArgs) Handles Atras1_btn.Click
        ECU_gb.Hide()
    End Sub

    Private Sub atras2_btn_Click(sender As Object, e As EventArgs) Handles atras2_btn.Click
        EU_gb.Hide()
    End Sub

    Private Sub ECU_Accion_btn_Click(sender As Object, e As EventArgs) Handles ECU_Accion_btn.Click
        If (ECU_Accion_lst.SelectedItem = Nothing) Then
            MessageBox.Show("Debes seleccionar un plan")
        Else
            Dim sss As String
            sss = "Update usuario set plan = '" & ECU_Accion_lst.SelectedItem & "' where nom_usr = '" & Accion_lst.SelectedItem & "';"
            'MessageBox.Show(sss)
            RealizarCambiosSQL(sss)
            MessageBox.Show(Accion_lst.SelectedItem & " Ha sido cambiado a " & ECU_Accion_lst.SelectedItem)
            ECU_Accion_lst.SelectedItem = Nothing
        End If
    End Sub

    Private Sub EU_Name_btn_Click(sender As Object, e As EventArgs) Handles EU_Name_btn.Click
        Dim sss As String
        sss = "Delete From usuario Where nom_usr = '" & Accion_lst.SelectedItem & "';"
        'MessageBox.Show(sss)
        RealizarCambiosSQL(sss)
        Muestra_UsuariosList()
        EU_gb.Hide()
        MessageBox.Show("Ya elimino al Usuario")

    End Sub

    Private Sub Accion_lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Accion_lst.SelectedIndexChanged

    End Sub

    Private Sub Edit_lbl_Click(sender As Object, e As EventArgs) Handles Edit_lbl.Click
        Edit_lbl.Text = "Bienvenido Usuario de Categoria 'BOSS', ya usted sabe que hacer"
    End Sub

    Private Sub AccionJeje_lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccionJeje_lst.SelectedIndexChanged

    End Sub
End Class