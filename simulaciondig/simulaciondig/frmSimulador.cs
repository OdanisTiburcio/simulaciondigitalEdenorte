using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulaciondig
{
    public partial class frmSimulador : Form
    {
        public frmSimulador()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int lambda, mu;
            float representantes;
            float tiempoespera;
            try
            {
                representantes = int.Parse(nudctdservidores.Text);
                if (representantes < 2)
                {
                    MessageBox.Show("Debe digitar una cantidad de representantes mayor que uno");
                }
                else if (nudctdservidores.Text.ToString() == "Tanda 1(8:00am - 11:00am)")
                {
                    lambda = 10;
                    mu = 12;
                    for (int i = 0; i <= 50; i++)
                    {
                        float dividir = (float)Math.Pow(lambda / mu, i);
                    }
                    return ;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Algunos campos no pueden estar vacíos");

            }

            /*Tanda 2(11:01am - 3:00pm)
            Tanda 3(3:01pm - 6:00pm))*/
            {

            }
           
        }

        private void cbTanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            borrartextos();
            btncalcular.Enabled = true;
        }
        private void borrartextos()
        {
            nudtasallegada.Text = "";
            nudtasaservicio.Text = "";
            nudctdservidores.Text = "";
            
        }
        private void llenarlistbox(List<string> probabilidad)
        {
            foreach (string calculoprob in probabilidad)
            {
                
            }
        }

        private void frmSimulador_Load(object sender, EventArgs e)
        {

        }
    }
}
