﻿using System;
using System.Windows.Forms;

namespace simulaciondig
{
    public partial class frmSimulador : Form
    {
        decimal lambda, miu;
        int c, iteracion = 1, minLambda = 0, maxLambda = 0, minMiu = 0, maxMiu = 0;
        public frmSimulador()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (cbTanda.SelectedIndex == 0 || cbTanda.SelectedIndex == 1 || cbTanda.SelectedIndex == 2)
                Calcular();
            else
                MessageBox.Show("Favor elegir una tanda antes de proceder.");
        }

        private void Calcular()
        {
            tbidsimulacion.Text = iteracion.ToString();
            SetVariablesAndProbabilites();       
            if(c > 1 && lambda > 30)
            {
                if(c*miu <= lambda)
                {
                    MessageBox.Show("No se cumple la condición para POBLACIÓN INFINITA, COLA MÚLTIPLE.\nc * μ > λ");
                    return;
                }
            }
            RunEvents();
            UpdateGrid();
            SetRecomendaciones(Convert.ToDecimal(DgvResultados.Rows[DgvResultados.Rows.Count - 1].Cells[3].Value), Convert.ToDecimal(DgvResultados.Rows[DgvResultados.Rows.Count - 1].Cells[4].Value), Convert.ToDecimal(DgvResultados.Rows[DgvResultados.Rows.Count - 1].Cells[5].Value), Convert.ToDecimal(DgvResultados.Rows[DgvResultados.Rows.Count - 1].Cells[6].Value), Convert.ToDecimal(DgvResultados.Rows[DgvResultados.Rows.Count - 1].Cells[7].Value) * 100);
        }

        private void SetRecomendaciones(decimal lq, decimal ls, decimal wq, decimal ws, decimal p)
        {
            bool calcular = false;
            LbxRecomendaciones.Items.Clear();
            LbxRecomendaciones.Items.Add("-----------CONDICIONES-----------");
            if (p > 88)
            {
                LbxRecomendaciones.Items.Add("Servidores saturados.");
                calcular = true;
            }
            if(ws > 20)
            {
                LbxRecomendaciones.Items.Add("Tiempo de servicio muy extenso.");
                calcular = true;
            }
            if(wq > 10)
            {
                LbxRecomendaciones.Items.Add("Tiempo en cola muy extenso.");
                calcular = true;
            }
            if(ls > 15)
            {
                LbxRecomendaciones.Items.Add("Demasiados clientes en el sistema.");
                calcular = true;
            }
            if(lq > 10)
            {
                LbxRecomendaciones.Items.Add("Demasiados clientes en cola.");
                calcular = true;
            }
            LbxRecomendaciones.Items.Add("");
            LbxRecomendaciones.Items.Add("-----RECOMENDACIONES-----");
            if (calcular)
            {
                do
                {
                    miu += 1;
                    if (Convert.ToDecimal(CalcP()) <= 88 && Convert.ToDecimal(CalcWs()) <= 20 && Convert.ToDecimal(CalcWq()) <= 10 && Convert.ToDecimal(CalcLs()) <= 15 && Convert.ToDecimal(CalcLq()) <= 10)
                        break;
                } while (true);
                LbxRecomendaciones.Items.Add("Entrenar servidor hasta que Miu = " + miu + " c/h");
                LbxRecomendaciones.Items.Add("O bien...");
                do
                {
                    c += 1;
                    if (Convert.ToDecimal(CalcP()) <= 88 && Convert.ToDecimal(CalcWs()) <= 20 && Convert.ToDecimal(CalcWq()) <= 10 && Convert.ToDecimal(CalcLs()) <= 15 && Convert.ToDecimal(CalcLq()) <= 10)
                        break;
                } while (true);
                LbxRecomendaciones.Items.Add("Agregar servidores hasta que S = " + c + " servidores");
            }
        }

        private void RunEvents()
        {
            Random random = new Random();
            decimal tiempo = 0M;
            LbxEventos.Items.Clear();
            foreach (DataGridViewRow row in DgvEventos.Rows)
            {
                switch (cbTanda.SelectedIndex)
                {
                    case 0:
                        if(random.Next(10000) <= Convert.ToDecimal(row.Cells[1].Value.ToString()) * 100)
                        {
                            tiempo += Convert.ToInt32(row.Cells[4].Value);
                            LbxEventos.Items.Add(row.Cells[0].Value.ToString());
                        }
                        break;
                    case 1:
                        if (random.Next(10000) <= Convert.ToDecimal(row.Cells[2].Value.ToString()) * 100)
                        {
                            tiempo += Convert.ToInt32(row.Cells[4].Value);
                            LbxEventos.Items.Add(row.Cells[0].Value.ToString());
                        }
                        break;
                    case 2:
                        if (random.Next(10000) <= Convert.ToDecimal(row.Cells[3].Value.ToString()) * 100)
                        {
                            tiempo += Convert.ToInt32(row.Cells[4].Value);
                            LbxEventos.Items.Add(row.Cells[0].Value.ToString());
                        }
                        break;
                    default:
                        break;
                }
            }
            if (LbxEventos.Items.Count > 0)
            {
                LbxEventos.Items.Add(string.Format("Tiempo total agregado en horas: {0:N}",(tiempo / 60)));
                lambda += 3.4M * tiempo / 60; 
            }
        }

        private void SetVariablesAndProbabilites()
        {
            Random rnd = new Random();
            c = (int)NudServidores.Value;
            miu = Convert.ToInt16(rnd.Next(minMiu, maxMiu));
            lambda = Convert.ToInt16(rnd.Next(minLambda, maxLambda));
        }

        private void UpdateGrid()
        {
            DgvResultados.Rows.Add(iteracion++, string.Format("{0:F0}",lambda), miu, CalcLq(), CalcLs(), CalcWq(), CalcWs(), CalcP(), CalcP0());   
        }   

        private void NudServidores_ValueChanged(object sender, EventArgs e)
        {
            if (NudServidores.Value < 2)
                NudServidores.Value = 2;
        }

        private void frmSimulador_Load(object sender, EventArgs e)
        {
            DgvEventos.Rows.Add("Falta de luz", "8", "9", "7", "20");
            DgvEventos.Rows.Add("Falla de planta/inversor", "1", "2", "1", "30");
            DgvEventos.Rows.Add("Computador se congela", "5", "8", "8", "20");
            DgvEventos.Rows.Add("Computador se reinicia por error en el sistema", "1", "1", "1", "10");
            DgvEventos.Rows.Add("Error de conexión a internet", "3", "1", "1", "10");
            DgvEventos.Rows.Add("Servidor cuadrando caja", "10", "14", "8", "12");
            DgvEventos.Rows.Add("Servidor fuera de servicio", "7", "13", "14", "8");
            DgvEventos.Rows.Add("Servidor almorzando", "12.5", "0", "0", "25");
            DgvEventos.Rows.Add("Búsqueda del elemento clave para la transacción", "18", "15", "13", "1");
            DgvEventos.Rows.Add("Cliente no acude al servidor al ser llamado", "9", "7", "6.6", "1");
            DgvEventos.Rows.Add("Cliente proporciona información incorrecta", "3", "4", "3", "1");
        }

        private decimal GetFactorial(int i)
        {
            if (i == 1 || i == 0)
                return 1;
            else
                return i * GetFactorial(i - 1);
        }

        private string CalcLs()
        {
            decimal resultado = 0M;

            resultado = Convert.ToDecimal(CalcLq()) + (lambda / miu);

            return string.Format("{0:N}", resultado);
        }

        private string CalcLq()
        {
            decimal resultado = 0M;

            resultado = ((decimal)(Math.Pow((double)(lambda / miu), c)) * lambda * miu * Convert.ToDecimal(CalcP0())) / (GetFactorial(c - 1) * (decimal)Math.Pow((double)((c * miu) - lambda), 2));

            return string.Format("{0:N}", resultado);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DgvResultados.Rows.Clear();
        }

        private string CalcP0()
        {
            decimal resultado = 0M;

            decimal sumatoria = 0M, multiplicacion = 0M;
            for (int i = 0; i < c; i++)
            {
                sumatoria += ((1 / GetFactorial(i)) * (decimal)Math.Pow((double)(lambda / miu), i));
            }
            multiplicacion = (1 / GetFactorial(c)) * (decimal)((Math.Pow((double)(lambda / miu), c))) * ((c * miu) / ((c * miu) - lambda));
            resultado = 1 / (sumatoria + multiplicacion);
            return string.Format("{0:N}", resultado);
        }

        private string CalcP()
        {
            decimal resultado = 0M;
            resultado = lambda / (c * miu);
            return string.Format("{0:N}", resultado);
        }

        private string CalcPn(int v)
        {
            decimal resultado = 0M;
            if(v > c)
            {
                resultado = ((decimal)Math.Pow((double)(lambda / miu), v) * Convert.ToDecimal(CalcP0())) / ((GetFactorial(c) * (decimal)Math.Pow(c, (v - c))));
                return string.Format("{0:N}", resultado);
            }
            else
            {
                resultado = ((decimal)Math.Pow((double)(lambda / miu), v) * Convert.ToDecimal(CalcP0())) / GetFactorial(v);
                return string.Format("{0:N}", resultado);
            }
        }

        private void cbTanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTanda.SelectedIndex == 0)
            {
                minLambda = 26;
                maxLambda = 29;
                minMiu = 16;
                maxMiu = 18;
                NudServidores.Value = 2;
            }
            else if (cbTanda.SelectedIndex == 1)
            {
                minLambda = 31;
                maxLambda = 35;
                minMiu = 13;
                maxMiu = 18;
                NudServidores.Value = 3;
            }
            else
            {
                minLambda = 36;
                maxLambda = 40;
                minMiu = 14;
                maxMiu = 18;
                NudServidores.Value = 3;
            }
        }

        private string CalcWs()
        {
            return string.Format("{0:N}", Convert.ToDecimal(CalcWq()) + ((1 / miu) * 60));
        }

        private string CalcWq()
        {
            return string.Format("{0:N}", (Convert.ToDecimal(CalcLq()) / lambda) * 60);
        }
    }
}
