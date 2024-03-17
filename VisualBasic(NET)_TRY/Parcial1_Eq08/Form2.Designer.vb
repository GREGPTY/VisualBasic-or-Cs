<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Bienvenido_lbl = New System.Windows.Forms.Label()
        Me.Salirf2_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Find_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name_txt = New System.Windows.Forms.TextBox()
        Me.Num_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Movie_cb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ver_btn = New System.Windows.Forms.Button()
        Me.ver_img = New System.Windows.Forms.PictureBox()
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.GB_img = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ver_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_img.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bienvenido_lbl
        '
        Me.Bienvenido_lbl.AutoSize = True
        Me.Bienvenido_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Bienvenido_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bienvenido_lbl.ForeColor = System.Drawing.Color.White
        Me.Bienvenido_lbl.Location = New System.Drawing.Point(284, 33)
        Me.Bienvenido_lbl.Name = "Bienvenido_lbl"
        Me.Bienvenido_lbl.Size = New System.Drawing.Size(188, 20)
        Me.Bienvenido_lbl.TabIndex = 1
        Me.Bienvenido_lbl.Text = "Bienvenido Al Sistema"
        '
        'Salirf2_btn
        '
        Me.Salirf2_btn.Location = New System.Drawing.Point(713, 378)
        Me.Salirf2_btn.Name = "Salirf2_btn"
        Me.Salirf2_btn.Size = New System.Drawing.Size(75, 23)
        Me.Salirf2_btn.TabIndex = 7
        Me.Salirf2_btn.Text = "Salir"
        Me.Salirf2_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(93, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 200)
        Me.DataGridView1.TabIndex = 8
        '
        'Find_btn
        '
        Me.Find_btn.Location = New System.Drawing.Point(446, 151)
        Me.Find_btn.Name = "Find_btn"
        Me.Find_btn.Size = New System.Drawing.Size(75, 23)
        Me.Find_btn.TabIndex = 9
        Me.Find_btn.Text = "Buscar"
        Me.Find_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Genero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "La tabla muestra por las más vistas"
        '
        'Name_txt
        '
        Me.Name_txt.Location = New System.Drawing.Point(272, 59)
        Me.Name_txt.Name = "Name_txt"
        Me.Name_txt.Size = New System.Drawing.Size(100, 20)
        Me.Name_txt.TabIndex = 14
        '
        'Num_txt
        '
        Me.Num_txt.Location = New System.Drawing.Point(499, 62)
        Me.Num_txt.Name = "Num_txt"
        Me.Num_txt.Size = New System.Drawing.Size(100, 20)
        Me.Num_txt.TabIndex = 16
        Me.Num_txt.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Año" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Year_M)"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Seleccionar", "Terror", "Romance", "Comedia", "Ciencia Ficcion", "Aventura", "Accion", "Animacion"})
        Me.Gender.Location = New System.Drawing.Point(272, 99)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(121, 21)
        Me.Gender.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(713, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Editar datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Movie_cb
        '
        Me.Movie_cb.FormattingEnabled = True
        Me.Movie_cb.Location = New System.Drawing.Point(645, 205)
        Me.Movie_cb.Name = "Movie_cb"
        Me.Movie_cb.Size = New System.Drawing.Size(121, 21)
        Me.Movie_cb.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(645, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Seleccionar la Pelicula"
        '
        'Ver_btn
        '
        Me.Ver_btn.Location = New System.Drawing.Point(668, 254)
        Me.Ver_btn.Name = "Ver_btn"
        Me.Ver_btn.Size = New System.Drawing.Size(75, 23)
        Me.Ver_btn.TabIndex = 23
        Me.Ver_btn.Text = "Ver"
        Me.Ver_btn.UseVisualStyleBackColor = True
        '
        'ver_img
        '
        Me.ver_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ver_img.Image = Global.Parcial1_Eq08.My.Resources.Resources.Netflix
        Me.ver_img.Location = New System.Drawing.Point(0, 0)
        Me.ver_img.Name = "ver_img"
        Me.ver_img.Size = New System.Drawing.Size(823, 424)
        Me.ver_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ver_img.TabIndex = 24
        Me.ver_img.TabStop = False
        '
        'Back_btn
        '
        Me.Back_btn.BackColor = System.Drawing.Color.Black
        Me.Back_btn.ForeColor = System.Drawing.Color.White
        Me.Back_btn.Location = New System.Drawing.Point(770, 397)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(48, 23)
        Me.Back_btn.TabIndex = 25
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = False
        '
        'GB_img
        '
        Me.GB_img.BackColor = System.Drawing.Color.Transparent
        Me.GB_img.Controls.Add(Me.Back_btn)
        Me.GB_img.Controls.Add(Me.ver_img)
        Me.GB_img.Location = New System.Drawing.Point(-2, -8)
        Me.GB_img.Name = "GB_img"
        Me.GB_img.Size = New System.Drawing.Size(829, 424)
        Me.GB_img.TabIndex = 26
        Me.GB_img.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial1_Eq08.My.Resources.Resources.NetflixLoginAndSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(817, 413)
        Me.Controls.Add(Me.GB_img)
        Me.Controls.Add(Me.Ver_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Movie_cb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Num_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Name_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Find_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Salirf2_btn)
        Me.Controls.Add(Me.Bienvenido_lbl)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conusltar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ver_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_img.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bienvenido_lbl As Label
    Friend WithEvents Salirf2_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Find_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_txt As TextBox
    Friend WithEvents Num_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Movie_cb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Ver_btn As Button
    Friend WithEvents ver_img As PictureBox
    Friend WithEvents Back_btn As Button
    Friend WithEvents GB_img As GroupBox
End Class
