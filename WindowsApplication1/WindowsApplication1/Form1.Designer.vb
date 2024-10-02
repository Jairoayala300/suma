<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lblnum1 = New System.Windows.Forms.Label()
        Me.Lblnum2 = New System.Windows.Forms.Label()
        Me.Lblres = New System.Windows.Forms.Label()
        Me.Txtres = New System.Windows.Forms.TextBox()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.Txtnum1 = New System.Windows.Forms.TextBox()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Lblmensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(86, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 39)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "suma de numeros"
        '
        'Lblnum1
        '
        Me.Lblnum1.AutoSize = True
        Me.Lblnum1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnum1.Location = New System.Drawing.Point(37, 132)
        Me.Lblnum1.Name = "Lblnum1"
        Me.Lblnum1.Size = New System.Drawing.Size(127, 16)
        Me.Lblnum1.TabIndex = 1
        Me.Lblnum1.Text = "ingrese primer numero"
        '
        'Lblnum2
        '
        Me.Lblnum2.AutoSize = True
        Me.Lblnum2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnum2.Location = New System.Drawing.Point(37, 171)
        Me.Lblnum2.Name = "Lblnum2"
        Me.Lblnum2.Size = New System.Drawing.Size(134, 16)
        Me.Lblnum2.TabIndex = 2
        Me.Lblnum2.Text = "ingrese segundo numero"
        '
        'Lblres
        '
        Me.Lblres.AutoSize = True
        Me.Lblres.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblres.Location = New System.Drawing.Point(37, 200)
        Me.Lblres.Name = "Lblres"
        Me.Lblres.Size = New System.Drawing.Size(56, 16)
        Me.Lblres.TabIndex = 3
        Me.Lblres.Text = "resultado"
        '
        'Txtres
        '
        Me.Txtres.Location = New System.Drawing.Point(208, 200)
        Me.Txtres.Name = "Txtres"
        Me.Txtres.Size = New System.Drawing.Size(100, 20)
        Me.Txtres.TabIndex = 4
        '
        'Txtnum2
        '
        Me.Txtnum2.Location = New System.Drawing.Point(208, 171)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.Txtnum2.TabIndex = 5
        '
        'Txtnum1
        '
        Me.Txtnum1.Location = New System.Drawing.Point(208, 122)
        Me.Txtnum1.Name = "Txtnum1"
        Me.Txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.Txtnum1.TabIndex = 6
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Location = New System.Drawing.Point(86, 297)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btnnuevo.TabIndex = 7
        Me.Btnnuevo.Text = "nuevo"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(208, 297)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 8
        Me.Btncalcular.Text = "calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(389, 297)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.Btnsalir.TabIndex = 9
        Me.Btnsalir.Text = "salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Lblmensaje
        '
        Me.Lblmensaje.AutoSize = True
        Me.Lblmensaje.Location = New System.Drawing.Point(107, 243)
        Me.Lblmensaje.Name = "Lblmensaje"
        Me.Lblmensaje.Size = New System.Drawing.Size(76, 13)
        Me.Lblmensaje.TabIndex = 10
        Me.Lblmensaje.Text = "El resultado es"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 392)
        Me.Controls.Add(Me.Lblmensaje)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Btnnuevo)
        Me.Controls.Add(Me.Txtnum1)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Txtres)
        Me.Controls.Add(Me.Lblres)
        Me.Controls.Add(Me.Lblnum2)
        Me.Controls.Add(Me.Lblnum1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "suma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblnum1 As System.Windows.Forms.Label
    Friend WithEvents Lblnum2 As System.Windows.Forms.Label
    Friend WithEvents Lblres As System.Windows.Forms.Label
    Friend WithEvents Txtres As System.Windows.Forms.TextBox
    Friend WithEvents Txtnum2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtnum1 As System.Windows.Forms.TextBox
    Friend WithEvents Btnnuevo As System.Windows.Forms.Button
    Friend WithEvents Btncalcular As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents Lblmensaje As System.Windows.Forms.Label

End Class
