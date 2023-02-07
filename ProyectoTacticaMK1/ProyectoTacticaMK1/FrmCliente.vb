Imports System.Data.SqlClient
Public Class FrmCliente

    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
        Dim MostrarTabla As String = "SELECT * FROM Clientes"
        Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

        Dim Tabla As New DataTable()

        Adaptador.Fill(Tabla)
        DataClientes.DataSource = Tabla

        conexion.Close()


        ComboBoxAtributo.Items.Add("ID")
        ComboBoxAtributo.Items.Add("Cliente")
        ComboBoxAtributo.Items.Add("Telefono")
        ComboBoxAtributo.Items.Add("Correo")


    End Sub

    Private Sub DataClientes_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataClientes.MouseClick
        For Each row As DataGridViewRow In DataClientes.SelectedRows
            Dim value1 As String = row.Cells(0).Value.ToString
            Dim value2 As String = row.Cells(1).Value.ToString
            Dim value3 As String = row.Cells(2).Value.ToString
            Dim value4 As String = row.Cells(3).Value.ToString

            TxtIdCon.Text = value1
            TxtClienteCon.Text = value2
            TxtTelCon.Text = value3
            TxtCorreoCon.Text = value4
        Next
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        BtnGuardar.Visible = True
        BtnVolver.Visible = True

        TxtIdCon.Enabled = True
        TxtClienteCon.Enabled = True
        TxtCorreoCon.Enabled = True
        TxtTelCon.Enabled = True

    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        BtnGuardar.Visible = False
        BtnVolver.Visible = False

        TxtIdCon.Enabled = False
        TxtClienteCon.Enabled = False
        TxtCorreoCon.Enabled = False
        TxtTelCon.Enabled = False

        TxtIdCon.Text = ""
        TxtClienteCon.Text = ""
        TxtTelCon.Text = ""
        TxtCorreoCon.Text = ""
    End Sub

    Private Sub BtnGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardarCliente.Click
        Dim conexion As String = "Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim AltaCliente As New SqlCommand("INSERT INTO clientes (Cliente,Telefono,Correo) VALUES ('" & TxtCliente.Text & "','" & TxtTelefono.Text & "','" & TxtCorreo.Text & "')")
        AltaCliente.Connection = cn

        cn.Open()

        AltaCliente.ExecuteNonQuery()
        MsgBox("SE REGISTRO CON EXITO")

        cn.Close()

        Dim conexion2 As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
        Dim MostrarTabla As String = "SELECT * FROM Clientes"
        Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

        Dim Tabla As New DataTable()

        Adaptador.Fill(Tabla)
        DataClientes.DataSource = Tabla

        conexion2.Close()
    End Sub

    Private Sub BtnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim conexion As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
        Dim MostrarTabla As String = "SELECT * FROM Clientes WHERE " & ComboBoxAtributo.SelectedItem & "='" & TxtValorAtri.Text & "'"
        Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

        Dim Tabla As New DataTable()

        Adaptador.Fill(Tabla)
        DataClientes.DataSource = Tabla

        conexion.Close()
    End Sub

    Private Sub BtnListaCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListaCom.Click
        Dim conexion As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
        Dim MostrarTabla As String = "SELECT * FROM Clientes"
        Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

        Dim Tabla As New DataTable()

        Adaptador.Fill(Tabla)
        DataClientes.DataSource = Tabla

        conexion.Close()

        ComboBoxAtributo.Text = ""
        TxtValorAtri.Text = ""

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim conexion As String = "Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim EliminarCliente As New SqlCommand("DELETE FROM clientes WHERE ID='" & TxtIdCon.Text & "'")
        EliminarCliente.Connection = cn

        Dim aux As Integer

        aux = MsgBox("SEGURO QUE QUIERE ELIMINAR?", 32 + 1, "eliminado con exito")

        If aux = 1 Then

            cn.Open()

            EliminarCliente.ExecuteNonQuery()

            cn.Close()

            TxtIdCon.Text = ""
            TxtClienteCon.Text = ""
            TxtTelCon.Text = ""
            TxtCorreoCon.Text = ""

            Dim conexion2 As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
            Dim MostrarTabla As String = "SELECT * FROM Clientes"
            Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

            Dim Tabla As New DataTable()

            Adaptador.Fill(Tabla)
            DataClientes.DataSource = Tabla

            conexion2.Close()

            MsgBox("ELIMINADO CON EXITO")

        Else
            MsgBox("NO FUE ELIMINADO")
        End If

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim conexion As String = "Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim ModificarCliente As New SqlCommand("UPDATE clientes SET Cliente='" & TxtClienteCon.Text & "',Telefono='" & TxtTelCon.Text & "',Correo='" & TxtCorreoCon.Text & "' WHERE ID='" & TxtIdCon.Text & "';")
        ModificarCliente.Connection = cn

        Dim aux As Integer

        aux = MsgBox("SEGURO QUE QUIERE MODIFICAR?", 32 + 1, "eliminado con exito")

        If aux = 1 Then
            cn.Open()

            ModificarCliente.ExecuteNonQuery()
            MsgBox("SE MODIFICO CON EXITO")

            cn.Close()

            Dim conexion2 As New SqlConnection("Server=Localhost\SQLEXPRESS;Integrated Security=True;Database=pruebademo;")
            Dim MostrarTabla As String = "SELECT * FROM Clientes"
            Dim Adaptador As New SqlDataAdapter(MostrarTabla, conexion)

            Dim Tabla As New DataTable()

            Adaptador.Fill(Tabla)
            DataClientes.DataSource = Tabla

            conexion2.Close()

            BtnGuardar.Visible = False
            BtnVolver.Visible = False

            TxtIdCon.Enabled = False
            TxtClienteCon.Enabled = False
            TxtCorreoCon.Enabled = False
            TxtTelCon.Enabled = False

        Else
            MsgBox("NO SE REALIZARON LOS CAMBIOS")

            BtnGuardar.Visible = False
            BtnVolver.Visible = False

            TxtIdCon.Enabled = False
            TxtClienteCon.Enabled = False
            TxtCorreoCon.Enabled = False
            TxtTelCon.Enabled = False

            TxtIdCon.Text = ""
            TxtClienteCon.Text = ""
            TxtTelCon.Text = ""
            TxtCorreoCon.Text = ""
        End If

    End Sub
End Class