<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnJuegoTelefonos = New System.Windows.Forms.Button()
        Me.btnHorasTrabajadas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJuegoTelefonos
        '
        Me.btnJuegoTelefonos.BackColor = System.Drawing.Color.Orange
        Me.btnJuegoTelefonos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJuegoTelefonos.Location = New System.Drawing.Point(24, 169)
        Me.btnJuegoTelefonos.Name = "btnJuegoTelefonos"
        Me.btnJuegoTelefonos.Size = New System.Drawing.Size(247, 41)
        Me.btnJuegoTelefonos.TabIndex = 0
        Me.btnJuegoTelefonos.Text = "Juego de telefonos"
        Me.btnJuegoTelefonos.UseVisualStyleBackColor = False
        '
        'btnHorasTrabajadas
        '
        Me.btnHorasTrabajadas.BackColor = System.Drawing.Color.Orange
        Me.btnHorasTrabajadas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btnHorasTrabajadas.Location = New System.Drawing.Point(24, 372)
        Me.btnHorasTrabajadas.Name = "btnHorasTrabajadas"
        Me.btnHorasTrabajadas.Size = New System.Drawing.Size(247, 41)
        Me.btnHorasTrabajadas.TabIndex = 1
        Me.btnHorasTrabajadas.Text = "Horas Trabajadas"
        Me.btnHorasTrabajadas.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PracticoGrupo.My.Resources.Resources.telefono_icon
        Me.PictureBox1.Location = New System.Drawing.Point(24, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PracticoGrupo.My.Resources.Resources.Money_Face_Emoji
        Me.PictureBox2.Location = New System.Drawing.Point(66, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 145)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(292, 425)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHorasTrabajadas)
        Me.Controls.Add(Me.btnJuegoTelefonos)
        Me.MaximumSize = New System.Drawing.Size(308, 464)
        Me.MinimumSize = New System.Drawing.Size(308, 464)
        Me.Name = "VentanaPrincipal"
        Me.Text = "Practico Grupo I"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJuegoTelefonos As Button
    Friend WithEvents btnHorasTrabajadas As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
