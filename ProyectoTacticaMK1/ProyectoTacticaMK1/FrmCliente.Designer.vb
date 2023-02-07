<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtCorreoCon = New System.Windows.Forms.TextBox()
        Me.TxtTelCon = New System.Windows.Forms.TextBox()
        Me.TxtClienteCon = New System.Windows.Forms.TextBox()
        Me.TxtIdCon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnGuardarCliente = New System.Windows.Forms.Button()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ComboBoxAtributo = New System.Windows.Forms.ComboBox()
        Me.TxtValorAtri = New System.Windows.Forms.TextBox()
        Me.DataClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnListaCom = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnVolver)
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.TxtCorreoCon)
        Me.GroupBox2.Controls.Add(Me.TxtTelCon)
        Me.GroupBox2.Controls.Add(Me.TxtClienteCon)
        Me.GroupBox2.Controls.Add(Me.TxtIdCon)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 181)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "*BAJA Y MODIFICACION"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(58, 144)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 27
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        Me.BtnVolver.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(139, 144)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 28
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(139, 144)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(58, 144)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 26
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtCorreoCon
        '
        Me.TxtCorreoCon.Enabled = False
        Me.TxtCorreoCon.Location = New System.Drawing.Point(105, 105)
        Me.TxtCorreoCon.Name = "TxtCorreoCon"
        Me.TxtCorreoCon.Size = New System.Drawing.Size(140, 20)
        Me.TxtCorreoCon.TabIndex = 25
        '
        'TxtTelCon
        '
        Me.TxtTelCon.Enabled = False
        Me.TxtTelCon.Location = New System.Drawing.Point(105, 79)
        Me.TxtTelCon.Name = "TxtTelCon"
        Me.TxtTelCon.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelCon.TabIndex = 24
        '
        'TxtClienteCon
        '
        Me.TxtClienteCon.Enabled = False
        Me.TxtClienteCon.Location = New System.Drawing.Point(105, 50)
        Me.TxtClienteCon.Name = "TxtClienteCon"
        Me.TxtClienteCon.Size = New System.Drawing.Size(140, 20)
        Me.TxtClienteCon.TabIndex = 23
        '
        'TxtIdCon
        '
        Me.TxtIdCon.Enabled = False
        Me.TxtIdCon.Location = New System.Drawing.Point(105, 24)
        Me.TxtIdCon.Name = "TxtIdCon"
        Me.TxtIdCon.Size = New System.Drawing.Size(140, 20)
        Me.TxtIdCon.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ID:"
        '
        'BtnGuardarCliente
        '
        Me.BtnGuardarCliente.Location = New System.Drawing.Point(105, 147)
        Me.BtnGuardarCliente.Name = "BtnGuardarCliente"
        Me.BtnGuardarCliente.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardarCliente.TabIndex = 26
        Me.BtnGuardarCliente.Text = "Guardar"
        Me.BtnGuardarCliente.UseVisualStyleBackColor = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(105, 108)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(140, 20)
        Me.TxtCorreo.TabIndex = 25
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(105, 82)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelefono.TabIndex = 24
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(105, 53)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(140, 20)
        Me.TxtCliente.TabIndex = 23
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(105, 27)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(140, 20)
        Me.TxtID.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Valor del atributo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Atributo:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(285, 45)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 30
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ComboBoxAtributo
        '
        Me.ComboBoxAtributo.FormattingEnabled = True
        Me.ComboBoxAtributo.Location = New System.Drawing.Point(12, 48)
        Me.ComboBoxAtributo.Name = "ComboBoxAtributo"
        Me.ComboBoxAtributo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxAtributo.TabIndex = 29
        '
        'TxtValorAtri
        '
        Me.TxtValorAtri.Location = New System.Drawing.Point(139, 48)
        Me.TxtValorAtri.Name = "TxtValorAtri"
        Me.TxtValorAtri.Size = New System.Drawing.Size(140, 20)
        Me.TxtValorAtri.TabIndex = 28
        '
        'DataClientes
        '
        Me.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataClientes.Location = New System.Drawing.Point(9, 74)
        Me.DataClientes.Name = "DataClientes"
        Me.DataClientes.Size = New System.Drawing.Size(569, 158)
        Me.DataClientes.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.BtnGuardarCliente)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 181)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*ALTA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnListaCom)
        Me.GroupBox3.Controls.Add(Me.DataClientes)
        Me.GroupBox3.Controls.Add(Me.TxtValorAtri)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ComboBoxAtributo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(584, 247)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "*CONSULTA"
        '
        'BtnListaCom
        '
        Me.BtnListaCom.Location = New System.Drawing.Point(285, 16)
        Me.BtnListaCom.Name = "BtnListaCom"
        Me.BtnListaCom.Size = New System.Drawing.Size(116, 23)
        Me.BtnListaCom.TabIndex = 33
        Me.BtnListaCom.Text = "Listado Completo"
        Me.BtnListaCom.UseVisualStyleBackColor = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 458)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmCliente"
        Me.Text = "Cliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents TxtCorreoCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtClienteCon As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardarCliente As System.Windows.Forms.Button
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAtributo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtValorAtri As System.Windows.Forms.TextBox
    Friend WithEvents DataClientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnListaCom As System.Windows.Forms.Button
End Class
