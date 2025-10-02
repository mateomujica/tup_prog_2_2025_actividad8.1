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
            if (idx >=0)
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
        {
            lsbDatos.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbDatos.Items.Add(cuenta);
            }
        }

        //private void lsbDatos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Cuenta? c = lsbDatos.SelectedItem as Cuenta;

        //    if (c != null)
        //    {
        //        tbxDni.Text = c.DNI.ToString();
        //        tbxNombre.Text = c.Nombre;
        //        tbxMonto.Text = c.Importe.ToString();

        //    }
        //}

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
    }
}
