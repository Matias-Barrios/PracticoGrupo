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
        Me.SuspendLayout()
        '
        'btnJuegoTelefonos
        '
        Me.btnJuegoTelefonos.Location = New System.Drawing.Point(24, 95)
        Me.btnJuegoTelefonos.Name = "btnJuegoTelefonos"
        Me.btnJuegoTelefonos.Size = New System.Drawing.Size(247, 41)
        Me.btnJuegoTelefonos.TabIndex = 0
        Me.btnJuegoTelefonos.Text = "Juego de telefonos"
        Me.btnJuegoTelefonos.UseVisualStyleBackColor = True
        '
        'btnHorasTrabajadas
        '
        Me.btnHorasTrabajadas.Location = New System.Drawing.Point(24, 280)
        Me.btnHorasTrabajadas.Name = "btnHorasTrabajadas"
        Me.btnHorasTrabajadas.Size = New System.Drawing.Size(247, 41)
        Me.btnHorasTrabajadas.TabIndex = 1
        Me.btnHorasTrabajadas.Text = "Horas Trabajadas"
        Me.btnHorasTrabajadas.UseVisualStyleBackColor = True
        '
        'VentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 426)
        Me.Controls.Add(Me.btnHorasTrabajadas)
        Me.Controls.Add(Me.btnJuegoTelefonos)
        Me.MaximumSize = New System.Drawing.Size(308, 464)
        Me.MinimumSize = New System.Drawing.Size(308, 464)
        Me.Name = "VentanaPrincipal"
        Me.Text = "Practico Grupo I"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnJuegoTelefonos As Button
    Friend WithEvents btnHorasTrabajadas As Button
End Class
