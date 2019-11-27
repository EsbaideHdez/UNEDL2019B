using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_TPV2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filename.Text != "")
            {
                content.Text = "";
                try
                {
                    var fs = File.OpenRead(filename.Text);
                    var stream = new StreamReader(fs);
                    String line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        content.Text += line + "\n";
                    }
                    fs.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes escribir el nombre de un archivo!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filename.Text != "")
            {
                try
                {
                    File.WriteAllText(filename.Text, content.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes escribir el nombre de un archivo!");
            }
        }
    }
}

/*Esbaide Yaziel Hernández Delgadillo   27-Noviembre-2019
 * 1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
 * R=son las clases que se utilizan para el manejo de varios valores de diferentes seriesy existen 2 tipos las
 * non-generic collections y las generic collections.
 * 
2.Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
R=el codigo no seguro es el que usa los apuntadores y se le llama contexto inseguro y para implementarlo es utilizando
el modificador unsafe para un metodo o constructor, tambien se deve utilizar la palabra unsafe para definir el grupo de 
codigo y  se debe habilitar en el compilador el uso del unsafe ya que si este no se habilita se genera un error a la hora de compilar.

3.Mencione al menos tres clases que se utilizan en I/O y proporcione brevemente la idea central de las mismas.
FileStream:lee y escribe bytes desde y hacia un archivo
BufferedStream: lee y escribe bytes desde y hacia otros Streams para mejorar el rendimiento de las operaciones de entrada y salia
PipeStream: lee y escribe bytes desde y hacia diferentes procesos.

4. Explique la diferencia entre los siguientes códigos en csharp
a. Console. Writeline ("resultado: (*ptr) ").
b. Console.WriteLine("resultado: ((int)ptr)")
5.Mencione al menos tres caracteristicas de las excepciones (Exceptions).
R=las excepciones son eventos inesperados que aparecen durante la ejecucion de agun programa,
puede ser al tratar de acceder a un elemento fuera del limite.

6.En Java, mencione y describa los tres tipos de excepciones.
R=
7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para
usarlas.
R=son las que dan las instrucciones al compilador para que procese la informacion antes de iniciar con
la propia compilacion y para usarlas es que las directivas inician con # y no termina con , las directivas deben ser las unicas
instrucciones de la linea y el compilador no contiene un prepocesador

8. Explique las diferencias entre ArrayList, SortedList y  HashTable.
R=el ArrayList es el que Almacena objetos de cualquier tipo a manera de arreglo. No se necesita especificar el tamaño del arreglo, ya que se
incrementa automáticamente, el SortedList es el que acomoda automaticamente los elemtos deascendente y el HashTable es el que recupera los valores
utilizando la llave dada.

9. Describa las para que sirven StreamReader y StreamWriter
R=son las clases de apoyp que permiten la lectura y la escritura convirtiendo los bytes en caracteres y viceversa.

10. Explique el funcionamiento del algoritmo Quicksort
R=es un algoritmo que inicia partiendo de un pivote partiendo la lista de los elementos en 2, los elemntos de la seccion demla derecha so mayores
y los del lado izquierdo menores y se hace el mismo procediemto en la parte derecha y en la parte izquierda y se puede utilizar la recursividad.

11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
R=system.out es la salida de normas. el system.in es la entradda de normas y el system.err es el error de las normas.

12. Explique cuáles son las ventajas de utilizar "generic collections"
R=pueden almacenar cualquier tipo de elementos, la limitantes es quue debe usar casting para poder recorrer el contenido ya que si no se hace se genera una
excepcion

13 Desarrolle en C#, un programa en Windows Forms llamado TPV2doParcial que permita crear un
archivo, lo lea y permita escribir en el. El programa debe permitir la captura de una lista de palabras
y al finalizar la captura, debe reportar la cantidad total de palabras, las palabras repetidas y la
cantidad de ocurrencias. Capture las excepciones necesarias. Al terminar, suba su codigo a su
repositorio y escriba el SHA correspondiente en el examen*/
