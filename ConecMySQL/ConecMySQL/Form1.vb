'para acceso con MySQLSERVER
Imports MySql.Data.MySqlClient

Public Class Form1

    'conexion con la base de datos
    Public Sub Conexion()

        'gestionamos los posibles errores
        Try
            
            ' Crearobjeto Conexión
            Dim con As MySqlConnection
            ' Pasar cadena de conexión
            con = New MySqlConnection()
            con.ConnectionString = "Data Source=localhost;Database=bd;User Id=root;Password=25255252"

            ' Conectar con la Base de Datos
            con.Open()
            MessageBox.Show("¡Conectado!")
            ' Desconectar de la Base de Datos
            con.Close()
            MessageBox.Show("¡Desconectado!")

        Catch excepcion As MySqlException
            MessageBox.Show(excepcion.Message)
            'MessageBox.Show("Error al conectar con la Base de Datos")
        End Try
    End Sub
    'operar con datos
    Public Sub Insercion()

        ' Crearobjeto Conexión
        Dim con As MySqlConnection
        ' Pasar cadena de conexión
        con = New MySqlConnection()
        con.ConnectionString = "Data Source=localhost;Database=bd;User Id=root;Password=25255252"


        ' Crear comando MySQL
        Dim comando As New MySqlCommand()

        'Sentencia a realizar
        comando.CommandText = "INSERT INTO Alumnos VALUES (123, 'Pablo','Neruda','1996/12/23')"
        comando.Connection = con
        Dim resultados As Integer
        ' Conectar con Base de Datos
        con.Open()


        Try
            ' Ejecuta la sentencia SQL (NonQuery ya que es una inserción). Sólo devuelve el número de filas afectadas
            'ExecuteNonQuery : Ejecuta la sentencia SQL contenida en la propiedad CommandText del objeto Command. 
            'En este caso la sentencia que se ejecuta debe ser una sentencia de un tipo que no devuelva resultado alguno (UPDATE, DELETE, INSERT).
            resultados = comando.ExecuteNonQuery()

        Catch excepcion As MySqlException
            MessageBox.Show(excepcion.Message)
        End Try

        ' Desconectar de la Base de Datos
        con.Close()
        'mostrar resultado
        MessageBox.Show("Se han añadido " & resultados & " filas")
    End Sub

    'consulta escalar
    Private Sub ConsultaEscalar()
        Dim con As MySqlConnection
        con = New MySqlConnection()
        con.ConnectionString = "Data Source=localhost;Database=bd;User Id=root;Password=25255252"

        ' Crear comando MySQL
        Dim comando As New MySqlCommand()

        'sentencia a ejecutar
        comando.CommandText = "SELECT COUNT(*) FROM Alumnos"
        comando.Connection = con

        Dim resultados As Integer
        ' Conectar con Base de Datos
        con.Open()
        ' Ejecutar sentencia MySQL (NonQuery ya que es una ' ' ' inserción). Sólo devuelve el número de filas afectadas
        resultados = comando.ExecuteScalar()
        ' Desconectar la Base de Datos
        con.Close()
        'mostrar resultados
        MessageBox.Show("Hay " & resultados & " alumnos.")
    End Sub

    
    'consultar nombres
    Private Sub Consulta()
        Dim con As MySqlConnection
        con = New MySqlConnection()
        con.ConnectionString = "Data Source=localhost;Database=bd;User Id=root;Password=25255252"

        ' Crear el comando MySQL
        Dim comando As New MySqlCommand()
        'sentencia a ejecutar
        comando.CommandText = "SELECT * FROM Alumnos"
        comando.Connection = con


        'Un objeto DataReader permite la navegación hacia delante y de sólo lectura de los registros devueltos por una consulta.
        ' Crear DataReader
        Dim lectorDatos As MySqlDataReader
        ' Conectar con Base de Datos
        con.Open()

        'obtener datos de la consulta 
        lectorDatos = comando.ExecuteReader()


        'Read() : Desplaza el cursor actual al siguiente registro permitiendo obtener los valores del mismo a través del objeto DataReader. 
        'Además, devolverá True si quedan más elementos dentro del objeto DataReader y False si hemos llegado al final del conjunto de registros. 
        'La posición inicial de un objeto DataReader es justo antes del primer registro por lo que lo primero que deberemos hacer será realizar una llamada a este método para empezar a obtener valores.
        ' Recorre las filas devueltas en el DataReader y los muestra en un ListBox
        Me.ListaAlumnos.Items.Clear()
        While lectorDatos.Read()
            Me.ListaAlumnos.Items.Add(lectorDatos("Nombre"))
        End While

        ' Cierra el objeto DataReader, liberando sus recursos
        lectorDatos.Close()
        ' Desconectar Base de Datos
        con.Close()
    End Sub
   
    Private Sub TrabajandoDataSet()

        ' DataSet es el almacén de datos por excelencia de ADO.NET.
        ' Un objeto DataSet es capaz de almacenar y representar a una Base de Datos en memoria y desconectada del proveedor de datos (Base de Datos) que contiene tablas y sus relaciones.
        ' Cada tabla contenida dentro del objeto DataSet se encuentra disponible a través de su propiedad Tables, que es una colección de objetos System.Data.DataTable. 
        ' Cada objeto System.Data.DataTable es una colección de objetos System.Data.DataRow que representan las filas de la Base de Datos. 
        ' Y siguiendo con esto, cada objeto DataRow posee una colección de objetos DataColumn que representan cada una de las filas de la fila actual.
        ' Para poder crear e inicializar las tablas del DataSet deberemos hacer uso del objeto DataAdapter (SqlAdapter para Microsoft SQL Server y OleDbDataAdapter para OLEdb).
        ' Al objeto DataAdapter le pasaremos como parámetro la cadena que represente la consulta que queremos hacer, y que rellenará de datos el DataSet. 
        ' Del objeto DataAdapter utilizaremos su método Fill(), que tiene dos parámetros: uno el objeto DataSet que se rellenará de datos y otro que será el nombre que tendrá la tabla dentro del objeto DataSet.

        Dim con As MySqlConnection
        con = New MySqlConnection()
        con.ConnectionString = "Data Source=localhost;Database=bd;User Id=root;Password=25255252"

        ' Crea el DataAdapter
        Dim adaptadordatos As New MySqlDataAdapter("SELECT * FROM Alumnos ORDER BY Nombre", con)

        'Crea el DataSet
        Dim conjuntoDatos As New DataSet()

        ' Conecta a la Base de Datos, carga el DataSet y desconecta
        con.Open()
        adaptadordatos.Fill(conjuntoDatos, "Alumnos")
        con.Close()

        ' Ahora DESCONECTADO, puede trabajar con los datos del DataSet
        Dim tabla As DataTable
        tabla = conjuntoDatos.Tables("Alumnos")
        Dim fila As DataRow
        Me.ListaAlumnos.Items.Clear()
        For Each fila In tabla.Rows
            ' Muestra los datos en un ListBox
            Me.ListaAlumnos.Items.Add(fila.Item("Nombre") & " " & fila.Item("Apellidos"))
        Next
    End Sub
    'evento boton conexion
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Conexion()
    End Sub
    'evento insercion
    Private Sub BtnInsercion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsercion.Click
        Insercion()
    End Sub
    'evento consulta
    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Consulta()
    End Sub
    'evento consulta escalar
    Private Sub BtnConsultaEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaEsc.Click
        ConsultaEscalar()
    End Sub
    'evento consulta sin conexion
    Private Sub BtnConsultaDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaDesc.Click
        TrabajandoDataSet()
    End Sub

End Class
