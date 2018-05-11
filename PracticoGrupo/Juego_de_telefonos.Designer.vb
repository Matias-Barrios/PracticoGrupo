<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego_de_telefonos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel3 = New System.Windows.Forms.TextBox()
        Me.txtTel4 = New System.Windows.Forms.TextBox()
        Me.txtTel5 = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarGanador = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 166)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escriba cinco numeros de telefono y seleccionaremos un ganador al azar!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTel1
        '
        Me.txtTel1.Location = New System.Drawing.Point(82, 231)
        Me.txtTel1.MaxLength = 10
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Size = New System.Drawing.Size(198, 20)
        Me.txtTel1.TabIndex = 1
        '
        'txtTel2
        '
        Me.txtTel2.Location = New System.Drawing.Point(82, 266)
        Me.txtTel2.MaxLength = 10
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(198, 20)
        Me.txtTel2.TabIndex = 2
        '
        'txtTel3
        '
        Me.txtTel3.Location = New System.Drawing.Point(82, 302)
        Me.txtTel3.MaxLength = 10
        Me.txtTel3.Name = "txtTel3"
        Me.txtTel3.Size = New System.Drawing.Size(198, 20)
        Me.txtTel3.TabIndex = 3
        '
        'txtTel4
        '
        Me.txtTel4.Location = New System.Drawing.Point(82, 338)
        Me.txtTel4.MaxLength = 10
        Me.txtTel4.Name = "txtTel4"
        Me.txtTel4.Size = New System.Drawing.Size(198, 20)
        Me.txtTel4.TabIndex = 4
        '
        'txtTel5
        '
        Me.txtTel5.Location = New System.Drawing.Point(82, 378)
        Me.txtTel5.MaxLength = 10
        Me.txtTel5.Name = "txtTel5"
        Me.txtTel5.Size = New System.Drawing.Size(198, 20)
        Me.txtTel5.TabIndex = 5
        '
        'btnSeleccionarGanador
        '
        Me.btnSeleccionarGanador.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnSeleccionarGanador.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarGanador.Location = New System.Drawing.Point(21, 453)
        Me.btnSeleccionarGanador.Name = "btnSeleccionarGanador"
        Me.btnSeleccionarGanador.Size = New System.Drawing.Size(332, 54)
        Me.btnSeleccionarGanador.TabIndex = 6
        Me.btnSeleccionarGanador.Text = "Selecionar Ganador!!"
        Me.btnSeleccionarGanador.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Juego_de_telefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 549)
        Me.Controls.Add(Me.btnSeleccionarGanador)
        Me.Controls.Add(Me.txtTel5)
        Me.Controls.Add(Me.txtTel4)
        Me.Controls.Add(Me.txtTel3)
        Me.Controls.Add(Me.txtTel2)
        Me.Controls.Add(Me.txtTel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(396, 588)
        Me.MinimumSize = New System.Drawing.Size(396, 588)
        Me.Name = "Juego_de_telefonos"
        Me.Text = "Juego_de_telefonos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTel1 As TextBox
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents txtTel3 As TextBox
    Friend WithEvents txtTel4 As TextBox
    Friend WithEvents txtTel5 As TextBox
    Friend WithEvents btnSeleccionarGanador As Button
    Friend WithEvents Timer1 As Timer
End Class
