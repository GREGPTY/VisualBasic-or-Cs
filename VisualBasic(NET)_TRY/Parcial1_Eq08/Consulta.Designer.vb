<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.tmr_Animacion = New System.Windows.Forms.Timer(Me.components)
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.UserEdit_btn = New System.Windows.Forms.Button()
        Me.EditUser_gb = New System.Windows.Forms.GroupBox()
        Me.EU_gb = New System.Windows.Forms.GroupBox()
        Me.EU_Name_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EU_Name_Lbl = New System.Windows.Forms.Label()
        Me.atras2_btn = New System.Windows.Forms.Button()
        Me.ECU_gb = New System.Windows.Forms.GroupBox()
        Me.ECU_Accion_btn = New System.Windows.Forms.Button()
        Me.ECU_Name_Lbl = New System.Windows.Forms.Label()
        Me.ECU_Accion_lst = New System.Windows.Forms.ComboBox()
        Me.Atras1_btn = New System.Windows.Forms.Button()
        Me.Hacer_btn = New System.Windows.Forms.Button()
        Me.AccionJeje_lst = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Accion_lst = New System.Windows.Forms.ComboBox()
        Me.Edit_lbl = New System.Windows.Forms.Label()
        Me.Atras_btn = New System.Windows.Forms.Button()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditUser_gb.SuspendLayout()
        Me.EU_gb.SuspendLayout()
        Me.ECU_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONSULTAR CARTELERA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Image = Global.Parcial1_Eq08.My.Resources.Resources.frame_1
        Me.Imagen.Location = New System.Drawing.Point(260, 214)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(277, 210)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen.TabIndex = 2
        Me.Imagen.TabStop = False
        '
        'tmr_Animacion
        '
        '
        'LogOut_btn
        '
        Me.LogOut_btn.Location = New System.Drawing.Point(700, 415)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Size = New System.Drawing.Size(88, 23)
        Me.LogOut_btn.TabIndex = 3
        Me.LogOut_btn.Text = "Cerrar Sesión"
        Me.LogOut_btn.UseVisualStyleBackColor = True
        '
        'UserEdit_btn
        '
        Me.UserEdit_btn.BackColor = System.Drawing.Color.Transparent
        Me.UserEdit_btn.Location = New System.Drawing.Point(345, 163)
        Me.UserEdit_btn.Name = "UserEdit_btn"
        Me.UserEdit_btn.Size = New System.Drawing.Size(102, 23)
        Me.UserEdit_btn.TabIndex = 4
        Me.UserEdit_btn.Text = "Editar Usuarios"
        Me.UserEdit_btn.UseVisualStyleBackColor = False
        Me.UserEdit_btn.Visible = False
        '
        'EditUser_gb
        '
        Me.EditUser_gb.BackColor = System.Drawing.Color.Transparent
        Me.EditUser_gb.Controls.Add(Me.EU_gb)
        Me.EditUser_gb.Controls.Add(Me.ECU_gb)
        Me.EditUser_gb.Controls.Add(Me.Hacer_btn)
        Me.EditUser_gb.Controls.Add(Me.AccionJeje_lst)
        Me.EditUser_gb.Controls.Add(Me.Label2)
        Me.EditUser_gb.Controls.Add(Me.Label1)
        Me.EditUser_gb.Controls.Add(Me.Accion_lst)
        Me.EditUser_gb.Controls.Add(Me.Edit_lbl)
        Me.EditUser_gb.Controls.Add(Me.Atras_btn)
        Me.EditUser_gb.ForeColor = System.Drawing.Color.White
        Me.EditUser_gb.Location = New System.Drawing.Point(12, 43)
        Me.EditUser_gb.Name = "EditUser_gb"
        Me.EditUser_gb.Size = New System.Drawing.Size(783, 395)
        Me.EditUser_gb.TabIndex = 5
        Me.EditUser_gb.TabStop = False
        Me.EditUser_gb.Text = "Editar Usuarios"
        '
        'EU_gb
        '
        Me.EU_gb.Controls.Add(Me.EU_Name_btn)
        Me.EU_gb.Controls.Add(Me.Label3)
        Me.EU_gb.Controls.Add(Me.EU_Name_Lbl)
        Me.EU_gb.Controls.Add(Me.atras2_btn)
        Me.EU_gb.ForeColor = System.Drawing.Color.White
        Me.EU_gb.Location = New System.Drawing.Point(107, 19)
        Me.EU_gb.Name = "EU_gb"
        Me.EU_gb.Size = New System.Drawing.Size(597, 362)
        Me.EU_gb.TabIndex = 14
        Me.EU_gb.TabStop = False
        Me.EU_gb.Text = "Eliminar Usuario"
        '
        'EU_Name_btn
        '
        Me.EU_Name_btn.ForeColor = System.Drawing.Color.Black
        Me.EU_Name_btn.Location = New System.Drawing.Point(510, 333)
        Me.EU_Name_btn.Name = "EU_Name_btn"
        Me.EU_Name_btn.Size = New System.Drawing.Size(59, 23)
        Me.EU_Name_btn.TabIndex = 20
        Me.EU_Name_btn.Text = "Confirmar"
        Me.EU_Name_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 44)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "¿Estas Seguro de Realizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Esta Accion?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EU_Name_Lbl
        '
        Me.EU_Name_Lbl.AutoSize = True
        Me.EU_Name_Lbl.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EU_Name_Lbl.Location = New System.Drawing.Point(124, 77)
        Me.EU_Name_Lbl.Name = "EU_Name_Lbl"
        Me.EU_Name_Lbl.Size = New System.Drawing.Size(319, 44)
        Me.EU_Name_Lbl.TabIndex = 19
        Me.EU_Name_Lbl.Text = "El Usuario []" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sera Eliminado del registro final"
        Me.EU_Name_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'atras2_btn
        '
        Me.atras2_btn.ForeColor = System.Drawing.Color.Black
        Me.atras2_btn.Location = New System.Drawing.Point(15, 333)
        Me.atras2_btn.Name = "atras2_btn"
        Me.atras2_btn.Size = New System.Drawing.Size(59, 23)
        Me.atras2_btn.TabIndex = 17
        Me.atras2_btn.Text = "Atras"
        Me.atras2_btn.UseVisualStyleBackColor = True
        '
        'ECU_gb
        '
        Me.ECU_gb.Controls.Add(Me.ECU_Accion_btn)
        Me.ECU_gb.Controls.Add(Me.ECU_Name_Lbl)
        Me.ECU_gb.Controls.Add(Me.ECU_Accion_lst)
        Me.ECU_gb.Controls.Add(Me.Atras1_btn)
        Me.ECU_gb.ForeColor = System.Drawing.Color.White
        Me.ECU_gb.Location = New System.Drawing.Point(107, 19)
        Me.ECU_gb.Name = "ECU_gb"
        Me.ECU_gb.Size = New System.Drawing.Size(597, 362)
        Me.ECU_gb.TabIndex = 13
        Me.ECU_gb.TabStop = False
        Me.ECU_gb.Text = "Editar Categoria del Usuario"
        '
        'ECU_Accion_btn
        '
        Me.ECU_Accion_btn.ForeColor = System.Drawing.Color.Black
        Me.ECU_Accion_btn.Location = New System.Drawing.Point(525, 333)
        Me.ECU_Accion_btn.Name = "ECU_Accion_btn"
        Me.ECU_Accion_btn.Size = New System.Drawing.Size(59, 23)
        Me.ECU_Accion_btn.TabIndex = 19
        Me.ECU_Accion_btn.Text = "Confirmar"
        Me.ECU_Accion_btn.UseVisualStyleBackColor = True
        '
        'ECU_Name_Lbl
        '
        Me.ECU_Name_Lbl.AutoSize = True
        Me.ECU_Name_Lbl.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECU_Name_Lbl.Location = New System.Drawing.Point(85, 77)
        Me.ECU_Name_Lbl.Name = "ECU_Name_Lbl"
        Me.ECU_Name_Lbl.Size = New System.Drawing.Size(393, 44)
        Me.ECU_Name_Lbl.TabIndex = 18
        Me.ECU_Name_Lbl.Text = "El Usuario []" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sera cambiado a la siguiente categoria"
        Me.ECU_Name_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ECU_Accion_lst
        '
        Me.ECU_Accion_lst.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECU_Accion_lst.FormattingEnabled = True
        Me.ECU_Accion_lst.Items.AddRange(New Object() {"Boss", "Premium", "Estandar", "Basico"})
        Me.ECU_Accion_lst.Location = New System.Drawing.Point(181, 147)
        Me.ECU_Accion_lst.Name = "ECU_Accion_lst"
        Me.ECU_Accion_lst.Size = New System.Drawing.Size(224, 26)
        Me.ECU_Accion_lst.TabIndex = 17
        '
        'Atras1_btn
        '
        Me.Atras1_btn.ForeColor = System.Drawing.Color.Black
        Me.Atras1_btn.Location = New System.Drawing.Point(15, 333)
        Me.Atras1_btn.Name = "Atras1_btn"
        Me.Atras1_btn.Size = New System.Drawing.Size(59, 23)
        Me.Atras1_btn.TabIndex = 16
        Me.Atras1_btn.Text = "Atras"
        Me.Atras1_btn.UseVisualStyleBackColor = True
        '
        'Hacer_btn
        '
        Me.Hacer_btn.ForeColor = System.Drawing.Color.Black
        Me.Hacer_btn.Location = New System.Drawing.Point(356, 162)
        Me.Hacer_btn.Name = "Hacer_btn"
        Me.Hacer_btn.Size = New System.Drawing.Size(59, 23)
        Me.Hacer_btn.TabIndex = 12
        Me.Hacer_btn.Text = "Hacer"
        Me.Hacer_btn.UseVisualStyleBackColor = True
        '
        'AccionJeje_lst
        '
        Me.AccionJeje_lst.FormattingEnabled = True
        Me.AccionJeje_lst.Items.AddRange(New Object() {"Editar Categoria del Usuario", "Eliminar Usuario"})
        Me.AccionJeje_lst.Location = New System.Drawing.Point(398, 130)
        Me.AccionJeje_lst.Name = "AccionJeje_lst"
        Me.AccionJeje_lst.Size = New System.Drawing.Size(171, 21)
        Me.AccionJeje_lst.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Seleccionar un Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Acción a realizar"
        '
        'Accion_lst
        '
        Me.Accion_lst.FormattingEnabled = True
        Me.Accion_lst.Location = New System.Drawing.Point(194, 130)
        Me.Accion_lst.Name = "Accion_lst"
        Me.Accion_lst.Size = New System.Drawing.Size(177, 21)
        Me.Accion_lst.TabIndex = 8
        '
        'Edit_lbl
        '
        Me.Edit_lbl.AutoSize = True
        Me.Edit_lbl.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_lbl.Location = New System.Drawing.Point(87, 41)
        Me.Edit_lbl.Name = "Edit_lbl"
        Me.Edit_lbl.Size = New System.Drawing.Size(638, 22)
        Me.Edit_lbl.TabIndex = 7
        Me.Edit_lbl.Text = "Bienvenido Usuario de Categoria ""BOSS"", ya usted sabe que hacer"
        Me.Edit_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Atras_btn
        '
        Me.Atras_btn.ForeColor = System.Drawing.Color.Black
        Me.Atras_btn.Location = New System.Drawing.Point(610, 352)
        Me.Atras_btn.Name = "Atras_btn"
        Me.Atras_btn.Size = New System.Drawing.Size(59, 23)
        Me.Atras_btn.TabIndex = 6
        Me.Atras_btn.Text = "Atras"
        Me.Atras_btn.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.NetflixLoginAndSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditUser_gb)
        Me.Controls.Add(Me.UserEdit_btn)
        Me.Controls.Add(Me.LogOut_btn)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditUser_gb.ResumeLayout(False)
        Me.EditUser_gb.PerformLayout()
        Me.EU_gb.ResumeLayout(False)
        Me.EU_gb.PerformLayout()
        Me.ECU_gb.ResumeLayout(False)
        Me.ECU_gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents tmr_Animacion As Timer
    Friend WithEvents LogOut_btn As Button
    Friend WithEvents UserEdit_btn As Button
    Friend WithEvents EditUser_gb As GroupBox
    Friend WithEvents Atras_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Accion_lst As ComboBox
    Friend WithEvents Edit_lbl As Label
    Friend WithEvents AccionJeje_lst As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Hacer_btn As Button
    Friend WithEvents ECU_gb As GroupBox
    Friend WithEvents EU_gb As GroupBox
    Friend WithEvents atras2_btn As Button
    Friend WithEvents Atras1_btn As Button
    Friend WithEvents ECU_Accion_lst As ComboBox
    Friend WithEvents ECU_Name_Lbl As Label
    Friend WithEvents EU_Name_Lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ECU_Accion_btn As Button
    Friend WithEvents EU_Name_btn As Button
End Class
