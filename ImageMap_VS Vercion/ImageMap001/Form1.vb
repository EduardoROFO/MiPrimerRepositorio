'Carlos David Ramírez Santiago

'Este programa permite diferenciar que posicion de una imagen(Cuerpo humano) fue cliqueada.
'Esto se logra con 2 imagenes, la primera imagen solo es una vista, en cambio la segunda imagen es la misma que la primera solo que diferencia
'las partes identificadas con colores, dependiendo del color identificado por RGB se le relaciona con una respuesta o en este caso con una
'parte del cuerpo. Para tener un mejor vistazo de esta funciona, intenta mover el PictureBox2 para visualizar el PictureBox1.

Imports System.Reflection.Emit
Imports Newtonsoft.Json
Imports RestSharp
Imports System.IO

Public Class Form1

    Dim inCoordenadas As String
    Dim contadorFilas As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") And (ComboBox1.Text <> "") And (ComboBox2.Text <> "") And (ComboBox4.Text <> "") And (ComboBox3.Text <> "") And (RichTextBox1.Text <> "") And (inCoordenadas <> "") Then

            ' Incrementa el contador de filas
            contadorFilas += 1

            ' Obtener imagen
            Dim imagenSeleccionada As Image = PictureBox4.Image
            ' Crea un array para representar los datos de una fila
            Dim nuevaFila As Object() = {contadorFilas, TextBox1.Text, ComboBox1.Text, ComboBox2.Text, ComboBox4.Text, ComboBox3.Text, RichTextBox1.Text, imagenSeleccionada, inCoordenadas}


            ' Agrega la nueva fila al DataGridView
            DataGridView1.Rows.Add(nuevaFila)
        Else
            MsgBox("Llena los campos requeridos", vbOKOnly, "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim FilaSeleccionada As DataGridViewRow = DataGridView1.CurrentRow
            DataGridView1.Rows.Remove(FilaSeleccionada)
        Catch
            MsgBox("No hay datos selecionados", vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ' Configurar el OpenFileDialog
        OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*"
        OpenFileDialog1.Title = "Seleccionar una imagen"

        ' Mostrar el cuadro de diálogo y comprobar si se seleccionó un archivo
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim rutaArchivo As String = OpenFileDialog1.FileName

            ' Mostrar la imagen en el PictureBox
            MostrarImagen(rutaArchivo)
        End If
    End Sub

    Private Sub MostrarImagen(rutaArchivo As String)
        ' Verificar si el archivo existe
        If File.Exists(rutaArchivo) Then
            ' Cargar la imagen en el PictureBox
            PictureBox4.Image = Image.FromFile(rutaArchivo)
        Else
            MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Imagen

    'PictureBox1 Imagen de colores
    'PictureBox2 Imagen de vista
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        'Obtener coordenadas del clic del mouse
        Dim xy As MouseEventArgs = TryCast(e, MouseEventArgs)
        Dim x As Integer = xy.X
        Dim y As Integer = xy.Y

        Label3.Text = $"Coordenadas: {x}, {y}"
        inCoordenadas = $"{x}, {y}"

        'Obtener colores de la posicion del clic del mouse
        Dim map As New Bitmap(PictureBox1.Image)
        Dim color As Color = map.GetPixel(x, y)

        Dim map0 As New Bitmap(PictureBox2.Image)
        Dim color0 As Color = map0.GetPixel(x, y)

        'Transforma los datos RGB en el formato "r, g, b"
        Dim rgbColor As String = $"{color.R}, {color.G}, {color.B}"
        Dim rgbColor0 As String = $"{color0.R}, {color0.G}, {color0.B}"

        'Cambia el texto del Label1 a los valores en RGB del color seleccionado
        Label1.Text = $"RGB: {rgbColor0}"

        'Switch que permite identificar en base a colores las diferentes lados del cuerpo(Los colores son identificados en RGB)
        Select Case rgbColor0
            Case "255, 242, 0"
                ComboBox4.Text = "DORSAL"
            Case "255, 127, 39"
                ComboBox4.Text = "FRONTAL"
            Case "237, 28, 36"
                ComboBox4.Text = "COSTADO"
            Case Else
                ComboBox4.Text = "NO ESPECIFICA"
        End Select

        'Switch que permite identificar en base a colores las diferentes partes del cuerpo(Los colores son identificados en RGB)
        Select Case rgbColor
            Case "177, 0, 0"
                TextBox1.Text = "BORDE INTERNO DEL PIE" '1
            Case "177, 67, 1"
                TextBox1.Text = "BORDE EXTERNO DEL PIE"
            Case "177, 117, 2"
                TextBox1.Text = "CARA DORSAL DE LA MANO"
            Case "177, 158, 0"
                TextBox1.Text = "CARA INTERNA DEL MUSLO"
            Case "134, 177, 0"
                TextBox1.Text = "CARA PLANTAR O PLANTA DEL PIE"
            Case "81, 177, 1"
                TextBox1.Text = "CARA POSTERIOR DE LA MUÑECA"
            Case "0, 2, 61"
                TextBox1.Text = "CARA POSTERIOR DE LA PIERNA"
            Case "1, 177, 99"
                TextBox1.Text = "CARA POSTERIOR DEL ANTEBRAZO"
            Case "1, 152, 177"
                TextBox1.Text = "CARA POSTERIOR DEL BRAZO"
            Case "2, 98, 177"
                TextBox1.Text = "CARA PORTERIOR DEL CODO" '10
            Case "1, 177, 5"
                TextBox1.Text = "CARA PORSTERIOR DEL MUSLO"
            Case "53, 1, 177"
                TextBox1.Text = "DEDOS DE LA MANO"
            Case "106, 0, 177"
                TextBox1.Text = "HUECO POPLITEO"
            Case "167, 0, 177"
                TextBox1.Text = "OLECRANO"
            Case "177, 96, 153"
                TextBox1.Text = "PARES POSTERIOR DE LA AXILA"
            Case "PROMINENTE"

            Case "177, 0, 74"
                TextBox1.Text = "REGION DEL TRAPECIO"
            Case "177, 0, 3"
                TextBox1.Text = "REGION ESCAPULAR"
            Case "177, 24, 27"
                TextBox1.Text = "REGION CLUTEA"
            Case "177, 24, 99"
                TextBox1.Text = "REGION INFRAESCAPULAR" '20
            Case "177, 24, 170"
                TextBox1.Text = "REGION INTERESCAPULAR"
            Case "126, 24, 177"
                TextBox1.Text = "REGION LUMBAR"
            Case "37, 38, 177"
                TextBox1.Text = "REGION LUMBAR EXTERNA FLANCO"
            Case "REGION MASTOIDEA"

            Case "37, 118, 177"
                TextBox1.Text = "REGION OCCIPITAL"
            Case "37, 170, 177"
                TextBox1.Text = "REGION POSTERIOR DEL CUELLO"
            Case "37, 177, 128"
                TextBox1.Text = "REGION SACRA"
            Case "36, 177, 78"
                TextBox1.Text = "REGION SUPRAESCAPULAR"
            Case "63, 177, 35"
                TextBox1.Text = "REGION TROCANTEREANA"
            Case "116, 177, 35"
                TextBox1.Text = "TALON" '30
            Case "176, 177, 35"
                TextBox1.Text = "TENDON DE AQUILES"
            Case "177, 118, 34"
                TextBox1.Text = "CARA ANTERIOR DE LA PIERNA"
            Case "CARA ANTERIOR DE LA RODILLA"

            Case "177, 54, 48"
                TextBox1.Text = "CARA ANTERIOR DE LA MUÑECA"
            Case "177, 76, 69"
                TextBox1.Text = "CARA ANTERIOR DEL ANTEBRAZO"
            Case "177, 0, 132"
                TextBox1.Text = "CARA ANTERIOR DEL BRAZO"
            Case "177, 152, 152"
                TextBox1.Text = "CARA ANTERIOR DEL MUSLO"
            Case "177, 166, 154"
                TextBox1.Text = "CARA INTERNA DEL MUSLO"
            Case "177, 130, 69"
                TextBox1.Text = "CARA PALMAR DE LA 2A. FALANGE"
            Case "171, 177, 68"
                TextBox1.Text = "CARA PALMAR DE LA 3A. FALANGE" '40
            Case "177, 73, 68"
                TextBox1.Text = "CARA PALMAR DE LA 1A. FALANGE"
            Case "136, 177, 71"
                TextBox1.Text = "CUELLO DEL PIE"
            Case "74, 177, 144"
                TextBox1.Text = "DORDO DEL PIE"
            Case "75, 174, 177"
                TextBox1.Text = "EMINENCIA HIPOTENAR"
            Case "177, 113, 78"
                TextBox1.Text = "EMINENCIA TENAR"
            Case "74, 177, 75"
                TextBox1.Text = "EPIGASTRO"
            Case "157, 177, 87"
                TextBox1.Text = "FLANCO"
            Case "121, 177, 90"
                TextBox1.Text = "FOSA ILIACA"
            Case "91, 177, 109"
                TextBox1.Text = "HIPOCONDRIO"
            Case "91, 177, 153"
                TextBox1.Text = "HIPOGASTRIO" '50
            Case "94, 153, 177"
                TextBox1.Text = "MALEOLO EXTERNO"
            Case "96, 112, 177"
                TextBox1.Text = "MALEOLO INTERNO"
            Case "111, 95, 177"
                TextBox1.Text = "MASETERINA"
            Case "160, 96, 177"
                TextBox1.Text = "MENTON O BARBILLA"
            Case "177, 151, 166"
                TextBox1.Text = "PARED ANTERIOR DE LA AXILA"
            Case "177, 99, 111"
                TextBox1.Text = "REGION ACROMIAL"
            Case "177, 116, 124"
                TextBox1.Text = "REGION ANTERIOR DEL CUELLO (MANZANA DE ADAN)"
            Case "177, 115, 151"
                TextBox1.Text = "REGION CIGOMATICA"
            Case "177, 115, 163"
                TextBox1.Text = "REGION CLAVICULAR"
            Case "177, 116, 176"
                TextBox1.Text = "REGION ESTERNAL" '60
            Case "167, 116, 177"
                TextBox1.Text = "REGION FOSETA YUGULAR"
            Case "135, 118, 177"
                TextBox1.Text = "REGION INGUINAL O INGLE"
            Case "124, 119, 177"
                TextBox1.Text = "REGION LATERAL DEL CUELLO"
            Case "118, 132, 177"
                TextBox1.Text = "REGION MALAR O POMULO"
            Case "118, 146, 177"
                TextBox1.Text = "REGION MESOGASTRIO"
            Case "146, 177, 92"
                TextBox1.Text = "REGION METATARZO"
            Case "177, 176, 97"
                TextBox1.Text = "REGION NASAL"
            Case "177, 153, 101"
                TextBox1.Text = "REGION ORBITARIA"
            Case "177, 118, 118"
                TextBox1.Text = "REGION PALMAR"
            Case "177, 133, 121"
                TextBox1.Text = "REGION PECTORAL" '70
            Case "177, 151, 121"
                TextBox1.Text = "REGION PERIBUCAL"
            Case "177, 168, 122"
                TextBox1.Text = "REGION PUBIANA"
            Case "168, 177, 124"
                TextBox1.Text = "REGION TORULEANA O ROTULA"
            Case "144, 177, 126"
                TextBox1.Text = "REGION SUPRACLAVICULAR"
            Case "127, 177, 133"
                TextBox1.Text = "REGION XIFOIDEA"
            Case "128, 177, 156"
                TextBox1.Text = "REGION MANO"
            Case "128, 177, 168"
                TextBox1.Text = "REGION PIE"
            Case "128, 173, 177"
                TextBox1.Text = "REGION HOMBRO"
            Case "126, 149, 177"
                TextBox1.Text = "REGIION TIBIA"
            Case "126, 136, 177"
                TextBox1.Text = "REGION ABDOMEN INFERIOR" '80
            Case "137, 128, 177"
                TextBox1.Text = "REGION ABDOMEN SUPERIOR"
            Case "153, 127, 177"
                TextBox1.Text = "REGION BOCA"
            Case "169, 128, 177"
                TextBox1.Text = "REGION NARIZ"
            Case "177, 129, 169"
                TextBox1.Text = "REGION OREJA"
            Case "177, 130, 154"
                TextBox1.Text = "REGION FRENTE"
            Case "177, 130, 137"
                TextBox1.Text = "REGION CARA"
            Case "177, 141, 144"
                TextBox1.Text = "REGION ESPALDA INFERIOR"
            Case "177, 142, 155"
                TextBox1.Text = "REGION ESPALDA SUPERIOR"
            Case "177, 144, 167"
                TextBox1.Text = "REGION CABEZA"
            Case "171, 146, 177"
                TextBox1.Text = "REGION NUCA" '90
                'Case 
                'Label2.Text = ""
            Case Else
                TextBox1.Text = "Ninguna selección"
        End Select
    End Sub

    Private Sub CargarDatoslengua()
        ' URL de la API que deseas consultar
        Dim apiUrl As String = "http://187.188.213.206:18080/api/senasparticulares"


        ' Crea una instancia de RestClient
        Dim client As New RestClient(apiUrl)

        ' Crea una solicitud GET utilizando RestRequest
        Dim request As New RestRequest(Method.GET)

        Try
            ' Ejecuta la solicitud
            Dim response As IRestResponse = client.Execute(request)

            ' Verifica si la solicitud fue exitosa (código de estado 200)
            If response.StatusCode = System.Net.HttpStatusCode.OK Then
                ' Lee el contenido de la respuesta como una cadena JSON
                Dim jsonContent As String = response.Content

                ' Deserializa el JSON a una lista de objetos (ajusta el tipo según tu estructura)
                Dim data As List(Of Lengua) = JsonConvert.DeserializeObject(Of List(Of Lengua))(jsonContent)

                For Each lengua As Lengua In data
                    'CheckedListBox2.Items.Add(lengua.valor)
                Next
            Else
                ' Muestra un mensaje de error si la solicitud no fue exitosa
                MessageBox.Show($"Error: {response.StatusCode} - {response.ErrorMessage}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al realizar la solicitud: {ex.Message}")
        End Try
    End Sub
End Class

Public Class Lengua
    Public Property Id As Integer
    Public Property valor As String
End Class