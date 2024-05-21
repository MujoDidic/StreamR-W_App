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

namespace StreamR_W_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Speichern_Click(object sender, EventArgs e)
        {
            //eine neue Instanz von StreamWriter erzeugen
            StreamWriter textDatei = new StreamWriter("C:\\Test\\daten.txt",
                true, Encoding.ASCII);
            //alle daten in der ListBox in die Datei schreiben
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                textDatei.WriteLine(listBox1.Items[i].ToString());

                //die Datei ---StreamWriter--- wieder schließen
            }
            textDatei.Close();
        }

        private void Laden_Click(object sender, EventArgs e)
        {
            //existiert die Datei
            if (File.Exists("C:\\Test\\daten.txt"))
            {
                //eine neue instanz von Streamer erzeugen
                using (StreamReader textDatei = new StreamReader("C:\\daten.txt"))
                {
                    //für die Zeilen in der Datei
                    string zeile;
                    //die Listbox leeren
                    listBox1.Items.Clear();
                    //solange das Ende der Datei nicht erreicht ist,die Daten lesen und in die ListBox schreiben
                    while (textDatei.EndOfStream == false)
                    {
                        zeile = textDatei.ReadLine();
                        listBox1.Items.Add(zeile);
                    }
                }
            }

        }

        private void Einfuegen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(EintragTextBox.Text);
        }
    }
}
