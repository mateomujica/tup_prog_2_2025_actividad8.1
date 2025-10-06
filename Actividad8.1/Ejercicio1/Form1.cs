using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cuenta> cuentas = new List<Cuenta>();
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            string nom = tbxNombre.Text;
            int dni = Convert.ToInt32(tbxDni.Text);
            double importe = Convert.ToDouble(tbxMonto.Text);
            Cuenta cuenta = new Cuenta(nom, dni, importe);

            cuentas.Sort();

            int idx = cuentas.BinarySearch(cuenta);
            if (idx >= 0)
            {
                cuentas[idx].Nombre = nom;
                cuentas[idx].Importe += importe;
            }
            else
            {

                cuentas.Add(cuenta);
            }

            tbxNombre.Clear();
            tbxDni.Clear();
            tbxMonto.Clear();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        //☺ 
        {
            lsbDatos.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbDatos.Items.Add(cuenta);
            }
        }

        private void lsbDatos_SelectedValueChanged(object sender, EventArgs e)

        {
            Cuenta? c = lsbDatos.SelectedItem as Cuenta;

            if (c != null)
            {
                tbxDni.Text = c.DNI.ToString();
                tbxNombre.Text = c.Nombre;
                tbxMonto.Text = c.Importe.ToString();

            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null; ;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();
                        string dni = line.Substring(0, 9);
                        string nombre = line.Substring(9, 10).Trim();
                        string Importe = line.Substring(19, 9);

                        Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(Importe));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    foreach (Cuenta cuenta in cuentas)
                    {
                        string nombre = cuenta.Nombre;
                        if (cuenta.Nombre.Length > 10)
                            nombre = cuenta.Nombre.Substring(0, 10);

                        string linea = $"{cuenta.DNI,+9}{nombre,-10}{cuenta.Importe,+9}";

                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }

            }
        }

    }
}

