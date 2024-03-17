<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edicion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Name_txt = New System.Windows.Forms.TextBox()
        Me.Selection_sld = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ADD_gb = New System.Windows.Forms.GroupBox()
        Me.Wa_info_lbl = New System.Windows.Forms.Label()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Time_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Num_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nameee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Find_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Edit_gb = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Columna_list = New System.Windows.Forms.ComboBox()
        Me.Columna_lbl = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Time_Edit_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Gender_Edit_lst = New System.Windows.Forms.ComboBox()
        Me.year_Edit_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Name_Edit_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Editar_Edit_btn = New System.Windows.Forms.Button()
        Me.Eliminar_gb = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Titulo_Eliminar_txt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ADD_gb.SuspendLayout()
        Me.Edit_gb.SuspendLayout()
        Me.Eliminar_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Name_txt
        '
        Me.Name_txt.Location = New System.Drawing.Point(109, 169)
        Me.Name_txt.Name = "Name_txt"
        Me.Name_txt.Size = New System.Drawing.Size(218, 20)
        Me.Name_txt.TabIndex = 0
        '
        'Selection_sld
        '
        Me.Selection_sld.FormattingEnabled = True
        Me.Selection_sld.Items.AddRange(New Object() {"Seleccionar", "Agregar", "Editar", "Eliminar"})
        Me.Selection_sld.Location = New System.Drawing.Point(161, 111)
        Me.Selection_sld.Name = "Selection_sld"
        Me.Selection_sld.Size = New System.Drawing.Size(121, 21)
        Me.Selection_sld.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Acción a Realizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre de la Pelicula(Titulo)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Realizar Acción"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ADD_gb
        '
        Me.ADD_gb.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.BSpaceBlue_Background
        Me.ADD_gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ADD_gb.Controls.Add(Me.Wa_info_lbl)
        Me.ADD_gb.Controls.Add(Me.id_txt)
        Me.ADD_gb.Controls.Add(Me.Label7)
        Me.ADD_gb.Controls.Add(Me.Button2)
        Me.ADD_gb.Controls.Add(Me.Time_txt)
        Me.ADD_gb.Controls.Add(Me.Label6)
        Me.ADD_gb.Controls.Add(Me.Gender)
        Me.ADD_gb.Controls.Add(Me.Num_txt)
        Me.ADD_gb.Controls.Add(Me.Label4)
        Me.ADD_gb.Controls.Add(Me.Nameee)
        Me.ADD_gb.Controls.Add(Me.Label3)
        Me.ADD_gb.Controls.Add(Me.Label5)
        Me.ADD_gb.Controls.Add(Me.Find_btn)
        Me.ADD_gb.ForeColor = System.Drawing.Color.White
        Me.ADD_gb.Location = New System.Drawing.Point(12, 31)
        Me.ADD_gb.Name = "ADD_gb"
        Me.ADD_gb.Size = New System.Drawing.Size(437, 269)
        Me.ADD_gb.TabIndex = 22
        Me.ADD_gb.TabStop = False
        Me.ADD_gb.Text = "Agregar"
        '
        'Wa_info_lbl
        '
        Me.Wa_info_lbl.AutoSize = True
        Me.Wa_info_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Wa_info_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wa_info_lbl.ForeColor = System.Drawing.Color.White
        Me.Wa_info_lbl.Location = New System.Drawing.Point(14, 235)
        Me.Wa_info_lbl.Name = "Wa_info_lbl"
        Me.Wa_info_lbl.Size = New System.Drawing.Size(413, 26)
        Me.Wa_info_lbl.TabIndex = 29
        Me.Wa_info_lbl.Text = "Si aparece un aviso de ""Error"" significa que en el ID añadido ya existe," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Intente" &
    " verificar en la tabla y ver cuales ID ya existen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(199, 59)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(100, 20)
        Me.id_txt.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(142, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "ID(Pos.)"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(115, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Time_txt
        '
        Me.Time_txt.Location = New System.Drawing.Point(276, 137)
        Me.Time_txt.Name = "Time_txt"
        Me.Time_txt.Size = New System.Drawing.Size(100, 20)
        Me.Time_txt.TabIndex = 26
        Me.Time_txt.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(236, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tiempo"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Seleccionar", "Terror", "Romance", "Comedia", "Ciencia Ficcion", "Aventura", "Accion", "Animacion"})
        Me.Gender.Location = New System.Drawing.Point(102, 138)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(121, 21)
        Me.Gender.TabIndex = 24
        '
        'Num_txt
        '
        Me.Num_txt.Location = New System.Drawing.Point(276, 95)
        Me.Num_txt.Name = "Num_txt"
        Me.Num_txt.Size = New System.Drawing.Size(100, 20)
        Me.Num_txt.TabIndex = 23
        Me.Num_txt.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(244, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Año"
        '
        'Nameee
        '
        Me.Nameee.Location = New System.Drawing.Point(102, 99)
        Me.Nameee.Name = "Nameee"
        Me.Nameee.Size = New System.Drawing.Size(121, 20)
        Me.Nameee.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(52, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Titulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(54, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Genero"
        '
        'Find_btn
        '
        Me.Find_btn.BackColor = System.Drawing.Color.Black
        Me.Find_btn.Location = New System.Drawing.Point(258, 184)
        Me.Find_btn.Name = "Find_btn"
        Me.Find_btn.Size = New System.Drawing.Size(75, 23)
        Me.Find_btn.TabIndex = 18
        Me.Find_btn.Text = "Añadir"
        Me.Find_btn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(335, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Volver a la cartelera"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Edit_gb
        '
        Me.Edit_gb.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.BSpaceBlue_Background
        Me.Edit_gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Edit_gb.Controls.Add(Me.Label8)
        Me.Edit_gb.Controls.Add(Me.Columna_list)
        Me.Edit_gb.Controls.Add(Me.Columna_lbl)
        Me.Edit_gb.Controls.Add(Me.Button4)
        Me.Edit_gb.Controls.Add(Me.Time_Edit_txt)
        Me.Edit_gb.Controls.Add(Me.Label10)
        Me.Edit_gb.Controls.Add(Me.Gender_Edit_lst)
        Me.Edit_gb.Controls.Add(Me.year_Edit_txt)
        Me.Edit_gb.Controls.Add(Me.Label11)
        Me.Edit_gb.Controls.Add(Me.Name_Edit_txt)
        Me.Edit_gb.Controls.Add(Me.Label12)
        Me.Edit_gb.Controls.Add(Me.Label13)
        Me.Edit_gb.Controls.Add(Me.Editar_Edit_btn)
        Me.Edit_gb.ForeColor = System.Drawing.Color.White
        Me.Edit_gb.Location = New System.Drawing.Point(12, 31)
        Me.Edit_gb.Name = "Edit_gb"
        Me.Edit_gb.Size = New System.Drawing.Size(437, 269)
        Me.Edit_gb.TabIndex = 30
        Me.Edit_gb.TabStop = False
        Me.Edit_gb.Text = "Edicion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(60, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(323, 39)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Se modificara exclusivamente la columna seleccionada," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para modificar otra debera" &
    " seleccionarla en la lista de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Columna""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Columna_list
        '
        Me.Columna_list.FormattingEnabled = True
        Me.Columna_list.Items.AddRange(New Object() {"Gender", "Year", "Time"})
        Me.Columna_list.Location = New System.Drawing.Point(99, 64)
        Me.Columna_list.Name = "Columna_list"
        Me.Columna_list.Size = New System.Drawing.Size(121, 21)
        Me.Columna_list.TabIndex = 29
        '
        'Columna_lbl
        '
        Me.Columna_lbl.AutoSize = True
        Me.Columna_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Columna_lbl.Location = New System.Drawing.Point(51, 70)
        Me.Columna_lbl.Name = "Columna_lbl"
        Me.Columna_lbl.Size = New System.Drawing.Size(48, 13)
        Me.Columna_lbl.TabIndex = 28
        Me.Columna_lbl.Text = "Columna"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(115, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Time_Edit_txt
        '
        Me.Time_Edit_txt.Location = New System.Drawing.Point(276, 137)
        Me.Time_Edit_txt.Name = "Time_Edit_txt"
        Me.Time_Edit_txt.Size = New System.Drawing.Size(100, 20)
        Me.Time_Edit_txt.TabIndex = 26
        Me.Time_Edit_txt.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(236, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Tiempo"
        '
        'Gender_Edit_lst
        '
        Me.Gender_Edit_lst.FormattingEnabled = True
        Me.Gender_Edit_lst.Items.AddRange(New Object() {"Terror", "Romance", "Comedia", "Ciencia Ficcion", "Aventura", "Accion", "Animacion"})
        Me.Gender_Edit_lst.Location = New System.Drawing.Point(102, 138)
        Me.Gender_Edit_lst.Name = "Gender_Edit_lst"
        Me.Gender_Edit_lst.Size = New System.Drawing.Size(121, 21)
        Me.Gender_Edit_lst.TabIndex = 24
        '
        'year_Edit_txt
        '
        Me.year_Edit_txt.Location = New System.Drawing.Point(276, 95)
        Me.year_Edit_txt.Name = "year_Edit_txt"
        Me.year_Edit_txt.Size = New System.Drawing.Size(100, 20)
        Me.year_Edit_txt.TabIndex = 23
        Me.year_Edit_txt.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(244, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Año"
        '
        'Name_Edit_txt
        '
        Me.Name_Edit_txt.Location = New System.Drawing.Point(99, 38)
        Me.Name_Edit_txt.Name = "Name_Edit_txt"
        Me.Name_Edit_txt.ReadOnly = True
        Me.Name_Edit_txt.Size = New System.Drawing.Size(144, 20)
        Me.Name_Edit_txt.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(49, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Titulo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(54, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Genero"
        '
        'Editar_Edit_btn
        '
        Me.Editar_Edit_btn.BackColor = System.Drawing.Color.Black
        Me.Editar_Edit_btn.Location = New System.Drawing.Point(258, 184)
        Me.Editar_Edit_btn.Name = "Editar_Edit_btn"
        Me.Editar_Edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Editar_Edit_btn.TabIndex = 18
        Me.Editar_Edit_btn.Text = "Editar"
        Me.Editar_Edit_btn.UseVisualStyleBackColor = False
        '
        'Eliminar_gb
        '
        Me.Eliminar_gb.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.BSpaceBlue_Background
        Me.Eliminar_gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_gb.Controls.Add(Me.Label9)
        Me.Eliminar_gb.Controls.Add(Me.Button5)
        Me.Eliminar_gb.Controls.Add(Me.Titulo_Eliminar_txt)
        Me.Eliminar_gb.Controls.Add(Me.Label17)
        Me.Eliminar_gb.Controls.Add(Me.Button6)
        Me.Eliminar_gb.ForeColor = System.Drawing.Color.White
        Me.Eliminar_gb.Location = New System.Drawing.Point(12, 31)
        Me.Eliminar_gb.Name = "Eliminar_gb"
        Me.Eliminar_gb.Size = New System.Drawing.Size(437, 269)
        Me.Eliminar_gb.TabIndex = 30
        Me.Eliminar_gb.TabStop = False
        Me.Eliminar_gb.Text = "Eliminar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(52, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(340, 26)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "¿Seguro que desea eliminar?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No se podra recuperar una vez usted confirme esta op" &
    "ción"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(115, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Volver"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Titulo_Eliminar_txt
        '
        Me.Titulo_Eliminar_txt.Location = New System.Drawing.Point(170, 107)
        Me.Titulo_Eliminar_txt.Name = "Titulo_Eliminar_txt"
        Me.Titulo_Eliminar_txt.ReadOnly = True
        Me.Titulo_Eliminar_txt.Size = New System.Drawing.Size(163, 20)
        Me.Titulo_Eliminar_txt.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(120, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Titulo"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(258, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Confirmar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Edicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.BSpaceBlue_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 336)
        Me.Controls.Add(Me.Eliminar_gb)
        Me.Controls.Add(Me.Edit_gb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ADD_gb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Selection_sld)
        Me.Controls.Add(Me.Name_txt)
        Me.Name = "Edicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edicion"
        Me.ADD_gb.ResumeLayout(False)
        Me.ADD_gb.PerformLayout()
        Me.Edit_gb.ResumeLayout(False)
        Me.Edit_gb.PerformLayout()
        Me.Eliminar_gb.ResumeLayout(False)
        Me.Eliminar_gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name_txt As TextBox
    Friend WithEvents Selection_sld As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ADD_gb As GroupBox
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Num_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Nameee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Find_btn As Button
    Friend WithEvents Time_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents id_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Wa_info_lbl As Label
    Friend WithEvents Edit_gb As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Time_Edit_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Gender_Edit_lst As ComboBox
    Friend WithEvents year_Edit_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Name_Edit_txt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Editar_Edit_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Columna_list As ComboBox
    Friend WithEvents Columna_lbl As Label
    Friend WithEvents Eliminar_gb As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Titulo_Eliminar_txt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button6 As Button
End Class
