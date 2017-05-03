using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TP3 : Form
    {
        enum tipo_distribucion { Uniforme, Poisson, Normal, Exponencial };
        double confianza = 0.95;
        int distribucion_seleccionada = 0;
        int n;
        double[] numeros;
        DataTable dt;
        double intervalos;
        double prob = 0;
        public TP3()
        {
            InitializeComponent();
        }

        private void TP3Inicio_Load(object sender, EventArgs e)
        {
            lbl_resultadoPrueba.Visible = false;
            txt_confianza.Text = confianza.ToString();
            txt_confianza.Enabled = false;
            txt_n.Text = "1000";
            rb_5.Select();
        }


        public void btn_generar_Click(object sender, EventArgs e)
        {
            // limpieza tablas
            lbl_resultadoPrueba.Text = "";

            dgv_frec.DataSource = null;
            dgv_frec.Refresh();
            chrt_histograma.Series["Frecuencia"].Points.Clear(); //limpio grafico
            lst_distrib.Items.Clear(); // limpio bloc

            // paso generar valores
            generarValores();

            // Paso generar tabla y grafico 
            switch (distribucion_seleccionada)
            {
                case (int)tipo_distribucion.Uniforme:
                    generar_tabla_distribucion_Uniforme();
                    break;
                case (int)tipo_distribucion.Exponencial:
                    generar_tablasExp();
                    break;
                case (int)tipo_distribucion.Poisson:
                    generar_tablasPoisson();
                    break;
                case (int)tipo_distribucion.Normal:
                    generar_tablasNormal();
                    break;
            }
            //paso de evaluar prueba
            evaluarPrueba();
        }

        
        public void generar_tabla_distribucion_Uniforme()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("numero");
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");

            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
            }
            else
            {
                intervalos = 20;
            }

            int min = Convert.ToInt32(numeros[0]);
            int max = Convert.ToInt32(numeros[0]);
            double intSig = 0;
            double frec = 0;
            double marcaClase = 0;
            double j = 0;

            double fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0.0;
            double numero = 0;

            // armar intervalos
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > max)
                {
                    max = Convert.ToInt32(numeros[i]);
                }
                if (numeros[i] < min)
                {
                    min = Convert.ToInt32(numeros[i]);
                }
            }

            double cteIntervalo = (max - min) / intervalos;

            for (j = min; j < max; j = j + cteIntervalo)
            {
                numero = numero + 1;
                intSig = j + cteIntervalo;
                marcaClase = (intSig + j) / 2;
                for (int i = 0; i < n; i++)
                {
                    if (numeros[i] >= j && numeros[i] < intSig)
                    {
                        frec = frec + 1;
                    }
                }

                fe = n / intervalos;
                //frec = (frec - fe) / fe;
                po = (double)frec / (double)n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;

                abs = Math.Abs(abs);

                //MessageBox.Show("anda"+abs);

                double grafico = Math.Round((j + (cteIntervalo / 2)), 4);
                // double grafico = Math.Round((j + intSig / 2), 4);

                chrt_histograma.Series["Frecuencia"].Points.AddXY(grafico, frec);

                // agus
                DataRow dr = dt.NewRow();
                dr["numero"] = numero;
                dr["Mín"] = j;
                dr["Máx"] = intSig;
                dr["Marca Clase"] = Math.Round(marcaClase, 4);
                dr["Fe"] = Math.Round(fe, 4);
                dr["Fo"] = Math.Round(frec, 4);
                dr["Po"] = Math.Round(po, 4);
                dr["Pe"] = Math.Round(pe, 4);
                dr["PoAc"] = Math.Round(poAc, 4);
                dr["PeAc"] = Math.Round(peAc, 4);
                dr["PoAc-PeAc"] = Math.Round(abs, 4);

                dt.Rows.Add(dr);
                frec = 0;
            }
            dgv_frec.DataSource = dt;
        }

        public void generar_tablasNormal()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("numero");
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");
            dt.Columns.Add("P()");
            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
            }
            else
            {
                intervalos = 20;
            }

            double min = numeros[0];
            double max = numeros[0];
            double intSig = 0;
            int frec = 0;
            double marcaClase = 0;
            double j = 0;

            double fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0;
            double numero = 0;

            // armar intervalos
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > max)
                {
                    max = numeros[i];
                }
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }

            double cteIntervalo = (max - min) / intervalos;
            j = 0;
            for (j = min; j < max; j = j + cteIntervalo)
            {
                intSig = j + cteIntervalo;
                numero = numero + 1;

                //marcaClase = (intSig + j) / 2;
                marcaClase = ((j + (intSig / 2)));
                for (int i = 0; i < n; i++)
                {
                    if (numeros[i] >= j && numeros[i] < intSig)
                    {
                        frec = frec + 1;
                    }
                }
                prob = (1 / (1 * Math.Sqrt((2 * (Math.PI))))) * Math.Exp(-0.5 * (marcaClase * marcaClase));

                fe = prob * (double)n;
                po = (double)frec / (double)n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;
                abs = Math.Abs(abs);

                //chart1.Titles.Add("Frecuencia Observada");
                chrt_histograma.Series["Frecuencia"].Points.AddXY((j + (cteIntervalo / 2)), frec);

                DataRow dr = dt.NewRow();
                dr["numero"] = numero;
                dr["Mín"] = j;
                dr["Máx"] = intSig;
                dr["Marca Clase"] = Math.Round(marcaClase, 4);
                dr["Fo"] = frec;
                dr["P()"] = Math.Round(prob, 4);
                dr["Fe"] = Math.Round(fe, 4);
                dr["Po"] = Math.Round(po, 4);
                dr["Pe"] = Math.Round(pe, 4);
                dr["PoAc"] = Math.Round(poAc, 4);
                dr["PeAc"] = Math.Round(peAc, 4);
                dr["PoAc-PeAc"] = Math.Round(abs, 4);

                dt.Rows.Add(dr);
                frec = 0;
                prob = 0;
            }
            dgv_frec.DataSource = dt;
        }

        public double[] generarValores()
        {
            // limpieza tablas
            dgv_frec.DataSource = null;
            dgv_frec.Refresh();
            chrt_histograma.Series["Frecuencia"].Points.Clear(); //limpio grafico
            lst_distrib.Items.Clear(); // limpio bloc

            numeros = null;

            //Creo el objeto de la clase Random 
            Random RND = new Random();
            n = Convert.ToInt32(txt_n.Text);

            //Creamos un array que va a contener cantidad aleatoria de numeros que ingresamos por el texbox
            numeros = new double[n];

            //Recorremos el array y vamos asignando a cada posición un número aleatorio
            double min, max, media, desv, lambdaPoisson;
            switch (distribucion_seleccionada)
            {
                case (int)tipo_distribucion.Uniforme:
                    min = Convert.ToDouble(txt_min.Text);
                    max = Convert.ToDouble(txt_max.Text);
                    for (int i = 0; i < n; i++)
                    {
                        numeros[i] = Distribucion.generarUniforme(min, max);
                        lst_distrib.Items.Add(numeros[i].ToString());
                    }
                    break;
                case (int)tipo_distribucion.Exponencial:
                    media = Convert.ToDouble(txt_media.Text);
                    numeros = Distribucion.generarExponencial(media, n);

                    for (int i = 0; i < n; i++)
                    {

                        lst_distrib.Items.Add(numeros[i].ToString());
                    }
                    break;
                case (int)tipo_distribucion.Poisson:
                    lambdaPoisson = Convert.ToDouble(txt_lambda.Text);
                    numeros = Distribucion.generarPoisson(lambdaPoisson, n);
                    for (int i = 0; i < n; i++)
                    {

                        lst_distrib.Items.Add(numeros[i].ToString());
                    }
                    break;
                case (int)tipo_distribucion.Normal:
                    media = Convert.ToDouble(txt_media.Text);
                    desv = Convert.ToDouble(txt_desv.Text);
                    numeros = Distribucion.generarNor(n, media, desv);
                    for (int i = 0; i < n; i++)
                    {
                        // numeros = Distribucion.generarNormal(n, media, desv) // muy eneficiente 
                        lst_distrib.Items.Add(numeros[i].ToString());
                    }
                    break;
            }
            return numeros;
        }
        
        public double calcularMedia()
        {
            double[] numerosGenerados = generarValores();
            int n;
            n = Convert.ToInt32(txt_n.Text);
            n = int.Parse(txt_n.Text);
            double media = 0;
            for (int i = 0; i < numerosGenerados.Length; i++)
            {
                double contar = i++;
                media = contar / n;
            }
            return media;
        }

        public double calcularLambda()
        {
            double media = calcularMedia();
            double lambda = 1 / media;
            return lambda;
        }

        private void txt_lambda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_distrib_SelectedIndexChanged(object sender, EventArgs e)
        {
            // limpieza tablas
            lbl_resultadoPrueba.Text = "";
            dgv_frec.DataSource = null;
            dgv_frec.Refresh();
            chrt_histograma.Series["Frecuencia"].Points.Clear(); //limpio grafico
            lst_distrib.Items.Clear(); // limpio bloc

            switch (cbo_distrib.SelectedIndex)
            {
                case 0:
                    distribucion_seleccionada = (int)tipo_distribucion.Uniforme;
                    txt_min.Enabled = true;
                    txt_max.Enabled = true;
                    txt_media.Enabled = false;
                    txt_desv.Enabled = false;
                    txt_lambda.Enabled = false;
                    break;
                case 1:
                    distribucion_seleccionada = (int)tipo_distribucion.Normal;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = true;
                    txt_desv.Enabled = true;
                    txt_lambda.Enabled = false;
                    break;
                case 2:
                    distribucion_seleccionada = (int)tipo_distribucion.Exponencial;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = true;
                    txt_desv.Enabled = false;
                    txt_lambda.Enabled = false;
                    break;
                case 3:
                    distribucion_seleccionada = (int)tipo_distribucion.Poisson;
                    txt_min.Enabled = false;
                    txt_max.Enabled = false;
                    txt_media.Enabled = false;
                    txt_desv.Enabled = false;
                    txt_lambda.Enabled = true;
                    break;
            }
            txt_min.Text = "";
            txt_max.Text = "";
            txt_media.Text = "";
            txt_desv.Text = "";
            txt_lambda.Text = "";
        }

        // Exponencial 
        public void generar_tablasExp()
        {
            double media = Convert.ToDouble(txt_media.Text);

            DataTable dt = new DataTable();
            dt.Columns.Add("numero");
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");
            dt.Columns.Add("P()");
            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
            }
            else
            {
                intervalos = 20;
            }

            int min = Convert.ToInt32(numeros[0]);
            double max = Convert.ToInt32(numeros[0]);
            double intSig = 0;
            int frec = 0;
            double marcaClase = 0;
            double j = 0;

            double lamdaExp = 1 / media;

            double fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0;
            double numero = 0;

            // armar intervalos
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > max)
                {
                    max = Convert.ToInt32(numeros[i]);
                }
                if (numeros[i] < min)
                {
                    min = Convert.ToInt32(numeros[i]);
                }
            }

            double cteIntervalo = Convert.ToInt32(max / intervalos);
            for (j = 0; j < max; j = j + cteIntervalo)
            {
                numero = numero + 1;
                intSig = j + cteIntervalo;
                marcaClase = (intSig + j) / 2;
                for (int i = 0; i < n; i++)
                {
                    if (numeros[i] >= j && numeros[i] < intSig)
                    {
                        frec = frec + 1;
                    }
                }

                prob = (1 - Math.Exp(-(lamdaExp * (j + cteIntervalo)))) - (1 - Math.Exp(-(lamdaExp * (j))));

                fe = prob * (double)n;
                po = (double)frec / (double)n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;
                abs = Math.Abs(abs);

                chrt_histograma.Series["Frecuencia"].Points.AddXY((j + (cteIntervalo / 2)), frec);
                //chrt_histograma.Series["Frecuencia"].Points.AddXY((j + intSig / 2), frec);

                DataRow dr = dt.NewRow();
                dr["numero"] = numero;
                dr["Mín"] = Math.Round(j, 4);
                dr["Máx"] = Math.Round(intSig, 4);
                dr["Marca Clase"] = Math.Round(marcaClase, 4);
                dr["Fo"] = frec;
                dr["P()"] = Math.Round(prob, 4);
                dr["Fe"] = Math.Round(fe, 4);
                dr["Po"] = Math.Round(po, 4);
                dr["Pe"] = Math.Round(pe, 4);
                dr["PoAc"] = Math.Round(poAc, 4);
                dr["PeAc"] = Math.Round(peAc, 4);
                dr["PoAc-PeAc"] = Math.Round(abs, 4);

                dt.Rows.Add(dr);
                frec = 0;
                prob = 0;
            }
            dgv_frec.DataSource = dt;
        }

        // POISSON
        public void generar_tablasPoisson()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("numero");
            dt.Columns.Add("Mín");
            dt.Columns.Add("Máx");
            dt.Columns.Add("Marca Clase");
            dt.Columns.Add("Fo");
            dt.Columns.Add("P()");
            dt.Columns.Add("Fe");
            dt.Columns.Add("Po");
            dt.Columns.Add("Pe");
            dt.Columns.Add("PoAc");
            dt.Columns.Add("PeAc");
            dt.Columns.Add("PoAc-PeAc");

            if (rb_5.Checked)
            {
                intervalos = 5;
            }
            else if (rb_10.Checked)
            {
                intervalos = 10;
            }
            else
            {
                intervalos = 20;
            }

            int min = Convert.ToInt32(numeros[0]);
            int max = Convert.ToInt32(numeros[0]);
            double intSig = 0;
            int frec = 0;
            double marcaClase = 0;
            double j = 0;

            double lambdaPoisson = Convert.ToDouble(txt_lambda.Text);

            double fe = 0;
            double po = 0;
            double pe = 0;
            double poAc = 0;
            double peAc = 0;
            double abs = 0;
            int numero = 0;

            // armar intervalos
            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > max)
                {
                    max = Convert.ToInt32(numeros[i]);
                }
                if (numeros[i] < min)
                {
                    min = Convert.ToInt32(numeros[i]);
                }
            }

            double cteIntervalo = max / intervalos;  // ancho intervalo
            //MessageBox.Show("ancho" + cteIntervalo);
            for (j = 0; j < max; j = j + cteIntervalo)
            {
                numero = numero + 1;

                intSig = j + cteIntervalo;
                marcaClase = (intSig + j) / 2;
                for (int i = 0; i < n; i++)
                {
                    if (numeros[i] >= j && numeros[i] < intSig)
                    {
                        frec = frec + 1;

                    }
                }

                prob = ((Math.Pow(lambdaPoisson, j)) * Math.Exp(-lambdaPoisson)) / factorial(j);
                
                fe = prob * (double)n;
                po = (double)frec / (double)n;
                pe = fe / n;
                poAc = poAc + po;
                peAc = peAc + pe;
                abs = poAc - peAc;
                abs = Math.Abs(abs);
                
                chrt_histograma.Series["Frecuencia"].Points.AddXY((j + (cteIntervalo / 2)), frec);
                //chrt_histograma.Series["Frecuencia"].Points.AddXY((j + intSig / 2), frec);
                
                DataRow dr = dt.NewRow();

                dr["numero"] = numero;
                dr["Mín"] = Math.Round(j, 4);
                dr["Máx"] = Math.Round(intSig, 4);
                dr["Marca Clase"] = Math.Round(marcaClase, 4);
                dr["Fo"] = frec;
                dr["P()"] = Math.Round(prob, 4);
                dr["Fe"] = Math.Round(fe, 4);
                dr["Po"] = Math.Round(po, 4);
                dr["Pe"] = Math.Round(pe, 4);
                dr["PoAc"] = Math.Round(poAc, 4);
                dr["PeAc"] = Math.Round(peAc, 4);
                dr["PoAc-PeAc"] = Math.Round(abs, 4);
                
                dt.Rows.Add(dr);
                frec = 0;
                prob = 0;
            }
            dgv_frec.DataSource = dt;
        }

        private void evaluarPrueba()
        {
            // para saber si acepta o rechaza la prueba
            double mayor = 0;
            foreach (DataGridViewRow row in dgv_frec.Rows)
            {
                double valor_ac = Convert.ToDouble(row.Cells["PoAc-PeAc"].Value);
                if (valor_ac > mayor)
                {
                    mayor = valor_ac;
                }
            }

            // tomando nivel de confianza 0.95 y muestra tamaño = n
            double valor = 1.36 / Math.Sqrt(n);
            lbl_resultadoPrueba.Text = "Para un nivel de confianza " +
            txt_confianza.Text + " (" + valor + "), y el máximo valor obtenido de la prueba " + mayor + ", obtenemos entonces como conclusión que";

            if (valor > mayor)
            {
                lbl_resultadoPrueba.Text += " SE ACEPTA la prueba.";
            }
            else
            {
                lbl_resultadoPrueba.Text += " SE RECHAZA la prueba.";
            }
            lbl_resultadoPrueba.Visible = true;
        }
        
        private static double factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // esto nose para que diablos pero no tocar 
        private void txt_intervalos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_media_TextChanged(object sender, EventArgs e)
        {
            //double media = calcularMedia();
            //string mensaje = Convert.ToString(media);
            ////enseguida se muestra en el textbox esta variable
            //txt_media.Text = mensaje;
        }

        private void txt_numeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_resultadoPrueba_Click(object sender, EventArgs e)
        {

        }
    }
}

