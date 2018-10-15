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
        float lambda, miu;
        int c;
        string modelo;
        public frmSimulador()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            SetVariablesAndProbabilies();
            if(c > 1 && lambda > 30)
            {
                if(c*miu <= lambda)
                {
                    MessageBox.Show("No se cumple la Condicion para POBLACION INFINITA, COLA MULTIPLE.");
                }
                modelo = "MI"; 
            }
            else if( c==1 && lambda > 30)
            {
                modelo = "SI";
            }
            else if (c==1 && lambda <= 30)
            {
                modelo = "SF";
            }
            else
            {
                modelo = "MF";
            }
            UpdateGrid();
        }

        private void SetVariablesAndProbabilies()
        {
            miu = 1;
        }

        private void UpdateGrid()
        {
            DgvResultados.Rows.Add(CalcLq(), "", "", "", "", "", "", "", "");
        }

        private string CalcLq()
        {
            string resultado = string.Empty;
            switch (modelo)
            {
                case "MI":
                    break;
                case "SI":
                    break;
                case "SF":
                    break;
                case "MF":
                    break;
                default:
                    MessageBox.Show("Modelo no encontrado.");
                    break;
            }
            return resultado;
        }
    }
}
