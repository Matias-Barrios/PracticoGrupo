<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorasTrabajadas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSueldoResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 166)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca la cantidad de horas trabajadas. El valor por hora es de $6.5 hasta la" &
    "s 160 horas y de $7.5  mas de 160 horas."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(102, 178)
        Me.txtHorasTrabajadas.MaxLength = 4
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(100, 20)
        Me.txtHorasTrabajadas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(1, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 116)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Su sueldo es de : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSueldoResultado
        '
        Me.lblSueldoResultado.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoResultado.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSueldoResultado.Location = New System.Drawing.Point(167, 210)
        Me.lblSueldoResultado.Name = "lblSueldoResultado"
        Me.lblSueldoResultado.Size = New System.Drawing.Size(145, 116)
        Me.lblSueldoResultado.TabIndex = 4
        Me.lblSueldoResultado.Text = "0"
        Me.lblSueldoResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HorasTrabajadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(319, 334)
        Me.Controls.Add(Me.lblSueldoResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHorasTrabajadas)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(335, 373)
        Me.MinimumSize = New System.Drawing.Size(335, 373)
        Me.Name = "HorasTrabajadas"
        Me.Text = "HorasTrabajadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHorasTrabajadas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSueldoResultado As Label
End Class
