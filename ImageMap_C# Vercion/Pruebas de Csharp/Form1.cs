//Angel Eduardo Rodríguez Flores & Carlos David Ramírez Santiago

//Programa exportado de VS a C#

//Este programa permite diferenciar que posicion de una imagen(Cuerpo humano) fue cliqueada.
//Esto se logra con 2 imagenes, la primera imagen solo es una vista, en cambio la segunda imagen es la misma que la primera solo que diferencia
//las partes identificadas con colores, dependiendo del color identificado por RGB se le relaciona con una respuesta o en este caso con una
//parte del cuerpo. Para tener un mejor vistazo de esta funciona, intenta mover el PictureBox2 para visualizar el PictureBox1.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Pruebas_de_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Tipo";
            comboBox2.Text = "Lado";
            comboBox3.Text = "Vista";
            comboBox4.Text = "Cantidad";
        }

        string inCoordenadas;
        int imageTest = 0;

        private void button1_Click(object sender, EventArgs e) //Boton Guardar
        {
            if (textBox1.Text != "Región cuerpo" && comboBox1.Text != "Tipo" && comboBox2.Text != "Lado" && comboBox4.Text != "Cantidad" 
                && comboBox3.Text != "Vista" && richtextBox1.Text != "Descripción" && imageTest != 0 && inCoordenadas != "")
            {
                int contadorFilas = 0;

                // Incrementa el contador de filas
                contadorFilas += 1;

                // Obtener imagen
                Image imagenSeleccionada = pictureBox4.Image;

                // Crea un array para representar los datos de una fila
                object[] nuevaFila = { contadorFilas, textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, comboBox3.Text, richtextBox1.Text, imagenSeleccionada, inCoordenadas };

                // Agrega la nueva fila al DataGridView
                dataGridView1.Rows.Add(nuevaFila);

                textBox1.ForeColor = System.Drawing.Color.LightGray;
                textBox1.Text = "Región cuerpo";

                comboBox1.Items.Add("Tipo");
                comboBox1.ForeColor = System.Drawing.Color.LightGray;
                comboBox1.Text = "Tipo";

                comboBox2.Items.Add("Lado");
                comboBox2.ForeColor = System.Drawing.Color.LightGray;
                comboBox2.Text = "Lado";

                comboBox3.Items.Add("Vista");
                comboBox3.ForeColor = System.Drawing.Color.LightGray;
                comboBox3.Text = "Vista";

                comboBox4.Items.Add("Cantidad");
                comboBox4.ForeColor = System.Drawing.Color.LightGray;
                comboBox4.Text = "Cantidad";

                richtextBox1.ForeColor = System.Drawing.Color.LightGray;
                richtextBox1.Text = "Descripción";

                inCoordenadas = "";
                imageTest = 0;

                string directorioBase = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string defaultImage = Path.Combine(directorioBase, "Resources", "Minus loadIcon.png");

                if (File.Exists(defaultImage))
                {
                    pictureBox4.Image = Image.FromFile(defaultImage);
                    imageTest = 1;

                    MessageBox.Show("Se guardo la informacion correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al cargar los recursos del proyecto. \nNo se encontro:\n" + defaultImage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Llena los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e) //Imagen para subir imagen
        {
            // Configurar el OpenFileDialog
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter= "Archivos de imagen|*.jpg;*.jpeg;*.png;*";
            OpenFileDialog1.Title = "Seleccionar una imagen";

            // Mostrar el cuadro de diálogo y comprobar si se seleccionó un archivo
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = OpenFileDialog1.FileName;

                // Mostrar la imagen en el PictureBox
                MostrarImagen(rutaArchivo);
            }
        }

        private void MostrarImagen(string rutaArchivo) //Accion remplazar imagen
        {
            try
            {
                // Verificar si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Cargar la imagen en el PictureBox
                    pictureBox4.Image = Image.FromFile(rutaArchivo);
                    imageTest = 1;
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception e) { MessageBox.Show("Error al cargar la imagen\n\nPosibles causas:\n-La extencion no es la correcta (.jpg, .png, .jpeg)\n-El archivo es muy pesado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e) //Boton Borrar
        {
            //Verifica si una fila a sido seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                //Elimina la fila
                dataGridView1.Rows.Remove(filaSeleccionada);
            }
            else
            {
                //Si no se selecciona ninguna fila
                MessageBox.Show("Ninguna fila a sido seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Imagen del cuerpo
        {
            //Cambia el color del TextBox por negro
            textBox1.ForeColor = System.Drawing.Color.Black;
            comboBox3.ForeColor = System.Drawing.Color.Black;

            // Obtener coordenadas del clic del mouse
            MouseEventArgs xy = e as MouseEventArgs;
            int x = xy.X;
            int y = xy.Y;

            label2.Text = $"Coordenadas: {x}, {y}";
            inCoordenadas = $"{x}, {y}";

            // Obtener colores de la posición del clic del mouse
            Bitmap map = new Bitmap(pictureBox1.Image);
            Color color = map.GetPixel(x, y);

            Bitmap map0 = new Bitmap(pictureBox2.Image);
            Color color0 = map0.GetPixel(x, y);

            // Transforma los datos RGB en el formato "r, g, b"
            string rgbColor = $"{color.R}, {color.G}, {color.B}";
            string rgbColor0 = $"{color0.R}, {color0.G}, {color0.B}";

            // Cambia el texto del Label1 a los valores en RGB del color seleccionado
            label1.Text = $"RGB: {rgbColor0}";

            switch (rgbColor0)
            {
                case "255, 242, 0":
                    comboBox3.Text = "DORSAL";
                    break;
                case "255, 127, 39":
                    comboBox3.Text = "FRONTAL";
                    break;
                case "237, 28, 36":
                    comboBox3.Text = "COSTADO";
                    break;
                default:
                    comboBox3.Text = "NO ESPECIFICA";
                    break;
            }

            switch (rgbColor)
            {
                case "177, 0, 0":
                    textBox1.Text = "BORDE INTERNO DEL PIE"; //1
                    break;
                case "177, 67, 1":
                    textBox1.Text = "BORDE EXTERNO DEL PIE";
                    break;
                case "177, 117, 2":
                    textBox1.Text = "CARA DORSAL DE LA MANO";
                    break;
                case "177, 158, 0":
                    textBox1.Text = "CARA INTERNA DEL MUSLO";
                    break;
                case "134, 177, 0":
                    textBox1.Text = "CARA PLANTAR O PLANTA DEL PIE";
                    break;
                case "81, 177, 1":
                    textBox1.Text = "CARA POSTERIOR DE LA MUÑECA";
                    break;
                case "0, 2, 61":
                    textBox1.Text = "CARA POSTERIOR DE LA PIERNA";
                    break;
                case "1, 177, 99":
                    textBox1.Text = "CARA POSTERIOR DEL ANTEBRAZO";
                    break;
                case "1, 152, 177":
                    textBox1.Text = "CARA POSTERIOR DEL BRAZO";
                    break;
                case "2, 98, 177":
                    textBox1.Text = "CARA PORTERIOR DEL CODO"; //10
                    break;
                case "1, 177, 5":
                    textBox1.Text = "CARA PORSTERIOR DEL MUSLO";
                    break;
                case "53, 1, 177":
                    textBox1.Text = "DEDOS DE LA MANO";
                    break;
                case "106, 0, 177":
                    textBox1.Text = "HUECO POPLITEO";
                    break;
                case "167, 0, 177":
                    textBox1.Text = "OLECRANO";
                    break;
                case "177, 96, 153":
                    textBox1.Text = "PARES POSTERIOR DE LA AXILA";
                    break;
                case "PROMINENTE":
                    // ¿Qué se supone que debe hacer en este caso?
                    break;
                case "177, 0, 74":
                    textBox1.Text = "REGION DEL TRAPECIO";
                    break;
                case "177, 0, 3":
                    textBox1.Text = "REGION ESCAPULAR";
                    break;
                case "177, 24, 27":
                    textBox1.Text = "REGION CLUTEA";
                    break;
                case "177, 24, 99":
                    textBox1.Text = "REGION INFRAESCAPULAR"; //20
                    break;
                case "177, 24, 170":
                    textBox1.Text = "REGION INTERESCAPULAR";
                    break;
                case "126, 24, 177":
                    textBox1.Text = "REGION LUMBAR";
                    break;
                case "37, 38, 177":
                    textBox1.Text = "REGION LUMBAR EXTERNA FLANCO";
                    break;
                case "37, 118, 177":
                    textBox1.Text = "REGION OCCIPITAL";
                    break;
                case "37, 170, 177":
                    textBox1.Text = "REGION POSTERIOR DEL CUELLO";
                    break;
                case "37, 177, 128":
                    textBox1.Text = "REGION SACRA";
                    break;
                case "36, 177, 78":
                    textBox1.Text = "REGION SUPRAESCAPULAR";
                    break;
                case "63, 177, 35":
                    textBox1.Text = "REGION TROCANTEREANA";
                    break;
                case "116, 177, 35":
                    textBox1.Text = "TALON"; //30
                    break;
                case "176, 177, 35":
                    textBox1.Text = "TENDON DE AQUILES";
                    break;
                case "177, 118, 34":
                    textBox1.Text = "CARA ANTERIOR DE LA PIERNA";
                    break;
                case "CARA ANTERIOR DE LA RODILLA":
                    // ¿Qué se supone que debe hacer en este caso?
                    break;
                case "177, 54, 48":
                    textBox1.Text = "CARA ANTERIOR DE LA MUÑECA";
                    break;
                case "177, 76, 69":
                    textBox1.Text = "CARA ANTERIOR DEL ANTEBRAZO";
                    break;
                case "177, 0, 132":
                    textBox1.Text = "CARA ANTERIOR DEL BRAZO";
                    break;
                case "177, 152, 152":
                    textBox1.Text = "CARA ANTERIOR DEL MUSLO";
                    break;
                case "177, 166, 154":
                    textBox1.Text = "CARA INTERNA DEL MUSLO";
                    break;
                case "177, 130, 69":
                    textBox1.Text = "CARA PALMAR DE LA 2A. FALANGE";
                    break;
                case "171, 177, 68":
                    textBox1.Text = "CARA PALMAR DE LA 3A. FALANGE"; //40
                    break;
                case "177, 73, 68":
                    textBox1.Text = "CARA PALMAR DE LA 1A. FALANGE";
                    break;
                case "136, 177, 71":
                    textBox1.Text = "CUELLO DEL PIE";
                    break;
                case "74, 177, 144":
                    textBox1.Text = "DORDO DEL PIE";
                    break;
                case "75, 174, 177":
                    textBox1.Text = "EMINENCIA HIPOTENAR";
                    break;
                case "177, 113, 78":
                    textBox1.Text = "EMINENCIA TENAR";
                    break;
                case "74, 177, 75":
                    textBox1.Text = "EPIGASTRO";
                    break;
                case "157, 177, 87":
                    textBox1.Text = "FLANCO";
                    break;
                case "121, 177, 90":
                    textBox1.Text = "FOSA ILIACA";
                    break;
                case "91, 177, 109":
                    textBox1.Text = "HIPOCONDRIO";
                    break;
                case "91, 177, 153":
                    textBox1.Text = "HIPOGASTRIO"; //50
                    break;
                case "94, 153, 177":
                    textBox1.Text = "MALEOLO EXTERNO";
                    break;
                case "96, 112, 177":
                    textBox1.Text = "MALEOLO INTERNO";
                    break;
                case "111, 95, 177":
                    textBox1.Text = "MASETERINA";
                    break;
                case "160, 96, 177":
                    textBox1.Text = "MENTON O BARBILLA";
                    break;
                case "177, 151, 166":
                    textBox1.Text = "PARED ANTERIOR DE LA AXILA";
                    break;
                case "177, 99, 111":
                    textBox1.Text = "REGION ACROMIAL";
                    break;
                case "177, 116, 124":
                    textBox1.Text = "REGION ANTERIOR DEL CUELLO (MANZANA DE ADAN)";
                    break;
                case "177, 115, 151":
                    textBox1.Text = "REGION CIGOMATICA";
                    break;
                case "177, 115, 163":
                    textBox1.Text = "REGION CLAVICULAR";
                    break;
                case "177, 116, 176":
                    textBox1.Text = "REGION ESTERNAL"; //60
                    break;
                case "167, 116, 177":
                    textBox1.Text = "REGION FOSETA YUGULAR";
                    break;
                case "135, 118, 177":
                    textBox1.Text = "REGION INGUINAL O INGLE";
                    break;
                case "124, 119, 177":
                    textBox1.Text = "REGION LATERAL DEL CUELLO";
                    break;
                case "118, 132, 177":
                    textBox1.Text = "REGION MALAR O POMULO";
                    break;
                case "118, 146, 177":
                    textBox1.Text = "REGION MESOGASTRIO";
                    break;
                case "146, 177, 92":
                    textBox1.Text = "REGION METATARZO";
                    break;
                case "177, 176, 97":
                    textBox1.Text = "REGION NASAL";
                    break;
                case "177, 153, 101":
                    textBox1.Text = "REGION ORBITARIA";
                    break;
                case "177, 118, 118":
                    textBox1.Text = "REGION PALMAR";
                    break;
                case "177, 133, 121":
                    textBox1.Text = "REGION PECTORAL"; //70
                    break;
                case "177, 151, 121":
                    textBox1.Text = "REGION PERIBUCAL";
                    break;
                case "177, 168, 122":
                    textBox1.Text = "REGION PUBIANA";
                    break;
                case "168, 177, 124":
                    textBox1.Text = "REGION TORULEANA O ROTULA";
                    break;
                case "144, 177, 126":
                    textBox1.Text = "REGION SUPRACLAVICULAR";
                    break;
                case "127, 177, 133":
                    textBox1.Text = "REGION XIFOIDEA";
                    break;
                case "128, 177, 156":
                    textBox1.Text = "REGION MANO";
                    break;
                case "128, 177, 168":
                    textBox1.Text = "REGION PIE";
                    break;
                case "128, 173, 177":
                    textBox1.Text = "REGION HOMBRO";
                    break;
                case "126, 149, 177":
                    textBox1.Text = "REGION TIBIA";
                    break;
                case "126, 136, 177":
                    textBox1.Text = "REGION ABDOMEN INFERIOR"; //80
                    break;
                case "137, 128, 177":
                    textBox1.Text = "REGION ABDOMEN SUPERIOR";
                    break;
                case "153, 127, 177":
                    textBox1.Text = "REGION BOCA";
                    break;
                case "169, 128, 177":
                    textBox1.Text = "REGION NARIZ";
                    break;
                case "177, 129, 169":
                    textBox1.Text = "REGION OREJA";
                    break;
                case "177, 130, 154":
                    textBox1.Text = "REGION FRENTE";
                    break;
                case "177, 130, 137":
                    textBox1.Text = "REGION CARA";
                    break;
                case "177, 141, 144":
                    textBox1.Text = "REGION ESPALDA INFERIOR";
                    break;
                case "177, 142, 155":
                    textBox1.Text = "REGION ESPALDA SUPERIOR";
                    break;
                case "177, 144, 167":
                    textBox1.Text = "REGION CABEZA";
                    break;
                case "171, 146, 177":
                    textBox1.Text = "REGION NUCA"; //90
                    break;
                default:
                    textBox1.Text = "Ninguna selección";
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#9A1A1A");
        }

        //De aqui para abajo su funcion es el diseño del texto que se muestra cuando no hay ninguna seleccion
        private void richtextBox1_Enter(object sender, EventArgs e)
        {
            if (richtextBox1.Text == "Descripción")
            {
                richtextBox1.Text = "";
                richtextBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void richtextBox1_Leave(object sender, EventArgs e)
        {
            if (richtextBox1.Text == "")
            {
                richtextBox1.Text = "Descripción";
                richtextBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Tipo");
            comboBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Items.Add("Tipo");
                comboBox1.Text = "Tipo";
                comboBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            comboBox2.Items.Remove("Lado");
            comboBox2.ForeColor = System.Drawing.Color.Black;
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Items.Add("Lado");
                comboBox2.Text = "Lado";
                comboBox2.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            comboBox3.Items.Remove("Vista");
            comboBox3.ForeColor = System.Drawing.Color.Black;
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.Items.Add("Vista");
                comboBox3.Text = "Vista";
                comboBox3.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void comboBox4_Enter(object sender, EventArgs e)
        {
            comboBox4.Items.Remove("Cantidad");
            comboBox4.ForeColor = System.Drawing.Color.Black;
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                comboBox4.Items.Add("Cantidad");
                comboBox4.Text = "Cantidad";
                comboBox4.ForeColor = System.Drawing.Color.LightGray;
            }
        }
        //----------------------------------------------------------------------------------------------------
    }
}