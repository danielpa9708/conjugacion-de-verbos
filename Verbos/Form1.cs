using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Verbos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string tiempo;
        string NumPers;

        string Conjuga_Verbo(string s)
        {
            string verbo = "";
            string infinitivo = "";
            bool inf = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 2)
                {
                    inf = true;
                }
                if (inf)
                {
                    infinitivo += s[i];
                }
                if (!inf)
                {
                    verbo += s[i];
                }
            }
            switch (infinitivo)
            {
                case "ar":
                    Conjuga_ar(ref verbo);
                    break;
                case "er":
                    Conjuga_er(ref verbo);
                    break;
                case "ir":
                    Conjuga_ir(ref verbo);
                    break;
            }
            string oracion = "";
            switch (NumPers)
            {
                case "1raSingular":
                    oracion = "Yo";
                    break;
                case "2daSingular":
                    oracion = "Tú";
                    break;
                case "3raSingular":
                    oracion = "El";
                    break;
                case "1raPlural":
                    oracion = "Nosotros";
                    break;
                case "2daPlural":
                    oracion = "Ustedes";
                    break;
                case "3raPlural":
                    oracion = "Ellos";
                    break;
            }
            oracion += " " + verbo;
            return oracion;
        }
        void Conjuga_ar(ref string verbo)
        {
            tiempo = comboBox1.SelectedItem.ToString();
            NumPers = comboBox2.SelectedItem.ToString();
            string morfema = "ado";
            switch (tiempo)
            {
                #region Preterito

                case "preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "é";
                            break;
                        case "2daSingular":
                            morfema = "aste";
                            break;
                        case "3raSingular":
                            morfema = "ó";
                            break;
                        case "1raPlural":
                            morfema = "amos";
                            break;
                        case "2daPlural":
                            morfema = "asteis";
                            break;
                        case "3raPlural":
                            morfema = "aron";
                            break;
                    }
                    break;

                #endregion
                #region AntePreterito

                case "ante preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "hube " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "hubiste " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "hubo " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hubimos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "hubisteis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "hubieron " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Copreterito
                case "copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "aba";
                            break;
                        case "2daSingular":
                            morfema = "abas";
                            break;
                        case "3raSingular":
                            morfema = "aba";
                            break;
                        case "1raPlural":
                            morfema = "ábamos";
                            break;
                        case "2daPlural":
                            morfema = "abais";
                            break;
                        case "3raPlural":
                            morfema = "aban";
                            break;
                    }
                    break;

                #endregion
                #region AnteCopreterito

                case "ante copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habíamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habíais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Pospreterito
                case "pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "aría";
                            break;
                        case "2daSingular":
                            morfema = "arías";
                            break;
                        case "3raSingular":
                            morfema = "aría";
                            break;
                        case "1raPlural":
                            morfema = "aríamos";
                            break;
                        case "2daPlural":
                            morfema = "aríais";
                            break;
                        case "3raPlural":
                            morfema = "arían";
                            break;
                    }
                    break;

                #endregion
                #region AntePospreterito

                case "ante pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habríamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habríais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Presente

                case "presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "o";
                            break;
                        case "2daSingular":
                            morfema = "as";
                            break;
                        case "3raSingular":
                            morfema = "a";
                            break;
                        case "1raPlural":
                            morfema = "amos";
                            break;
                        case "2daPlural":
                            morfema = "aís";
                            break;
                        case "3raPlural":
                            morfema = "an";
                            break;
                    }
                    break;

                #endregion
                #region AntePresente

                case "ante presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "he " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "has " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "ha " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hemos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habéis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "han " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Futuro

                case "futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "aré";
                            break;
                        case "2daSingular":
                            morfema = "arás";
                            break;
                        case "3raSingular":
                            morfema = "ará";
                            break;
                        case "1raPlural":
                            morfema = "aremos";
                            break;
                        case "2daPlural":
                            morfema = "aréis";
                            break;
                        case "3raPlural":
                            morfema = "arán";
                            break;
                    }
                    break;

                #endregion
                #region AnteFuturo

                case "ante futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habré " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrás " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habrá " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habremos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habréis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrán " + verbo;
                            break;
                    }
                    break;

                #endregion
            }
            verbo += morfema;
        }
        void Conjuga_er(ref string verbo)
        {
            tiempo = comboBox1.SelectedItem.ToString();
            NumPers = comboBox2.SelectedItem.ToString();
            string morfema = "ido";
            switch (tiempo)
            {
                #region Preterito

                case "preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "í";
                            break;
                        case "2daSingular":
                            morfema = "iste";
                            break;
                        case "3raSingular":
                            morfema = "ió";
                            break;
                        case "1raPlural":
                            morfema = "imos";
                            break;
                        case "2daPlural":
                            morfema = "isteis";
                            break;
                        case "3raPlural":
                            morfema = "ieron";
                            break;
                    }
                    break;

                #endregion
                #region AntePreterito

                case "ante preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "hube " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "hubiste " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "hubo " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hubimos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "hubisteis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "hubieron " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region CoPreterito

                case "copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "ía";
                            break;
                        case "2daSingular":
                            morfema = "ías";
                            break;
                        case "3raSingular":
                            morfema = "ía";
                            break;
                        case "1raPlural":
                            morfema = "íamos";
                            break;
                        case "2daPlural":
                            morfema = "íais";
                            break;
                        case "3raPlural":
                            morfema = "ían";
                            break;
                    }
                    break;

                #endregion
                #region AntePreterito

                case "ante copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habíamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habíais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region PosPreterito

                case "pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "ería";
                            break;
                        case "2daSingular":
                            morfema = "erías";
                            break;
                        case "3raSingular":
                            morfema = "ería";
                            break;
                        case "1raPlural":
                            morfema = "eríamos";
                            break;
                        case "2daPlural":
                            morfema = "eríais";
                            break;
                        case "3raPlural":
                            morfema = "erían";
                            break;
                    }
                    break;

                #endregion
                #region AntePospreterito

                case "ante pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habríamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habríais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Presente

                case "presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "o";
                            break;
                        case "2daSingular":
                            morfema = "es";
                            break;
                        case "3raSingular":
                            morfema = "e";
                            break;
                        case "1raPlural":
                            morfema = "emos";
                            break;
                        case "2daPlural":
                            morfema = "éis";
                            break;
                        case "3raPlural":
                            morfema = "en";
                            break;
                    }
                    break;

                #endregion
                #region AntePresente

                case "ante presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "he " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "has " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "ha " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hemos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habéis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "han " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Futuro

                case "futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "eré";
                            break;
                        case "2daSingular":
                            morfema = "erás";
                            break;
                        case "3raSingular":
                            morfema = "erá";
                            break;
                        case "1raPlural":
                            morfema = "eremos";
                            break;
                        case "2daPlural":
                            morfema = "eréis";
                            break;
                        case "3raPlural":
                            morfema = "eran";
                            break;
                    }
                    break;

                #endregion
                #region AnteFuturo

                case "ante futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habré " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrás " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habrá " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habremos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habréis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrán " + verbo;
                            break;
                    }
                    break;

                #endregion
            }
            verbo += morfema;
        }
        void Conjuga_ir(ref string verbo)
        {
            tiempo = comboBox1.SelectedItem.ToString();
            NumPers = comboBox2.SelectedItem.ToString();
            string morfema = "ido";
            switch (tiempo)
            {
                #region Preterito

                case "preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "í";
                            break;
                        case "2daSingular":
                            morfema = "iste";
                            break;
                        case "3raSingular":
                            morfema = "ió";
                            break;
                        case "1raPlural":
                            morfema = "imos";
                            break;
                        case "2daPlural":
                            morfema = "isteis";
                            break;
                        case "3raPlural":
                            morfema = "ieron";
                            break;
                    }
                    break;

                #endregion
                #region AntePreterito

                case "ante preterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "hube " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "hubiste " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "hubo " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hubimos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "hubisteis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "hubieron " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region CoPreterito

                case "copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "ía";
                            break;
                        case "2daSingular":
                            morfema = "ías";
                            break;
                        case "3raSingular":
                            morfema = "ía";
                            break;
                        case "1raPlural":
                            morfema = "íamos";
                            break;
                        case "2daPlural":
                            morfema = "íais";
                            break;
                        case "3raPlural":
                            morfema = "ían";
                            break;
                    }
                    break;

                #endregion
                #region AntePreterito

                case "ante copreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "había " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habíamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habíais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region PosPreterito

                case "pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "iría";
                            break;
                        case "2daSingular":
                            morfema = "irías";
                            break;
                        case "3raSingular":
                            morfema = "iría";
                            break;
                        case "1raPlural":
                            morfema = "iríamos";
                            break;
                        case "2daPlural":
                            morfema = "iríais";
                            break;
                        case "3raPlural":
                            morfema = "irían";
                            break;
                    }
                    break;

                #endregion
                #region AntePospreterito

                case "ante pospreterito":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrías " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habría " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habríamos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habríais " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrían " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Presente

                case "presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "o";
                            break;
                        case "2daSingular":
                            morfema = "es";
                            break;
                        case "3raSingular":
                            morfema = "e";
                            break;
                        case "1raPlural":
                            morfema = "imos";
                            break;
                        case "2daPlural":
                            morfema = "ís";
                            break;
                        case "3raPlural":
                            morfema = "en";
                            break;
                    }
                    break;

                #endregion
                #region AntePresente

                case "ante presente":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "he " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "has " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "ha " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "hemos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habéis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "han " + verbo;
                            break;
                    }
                    break;

                #endregion

                #region Futuro

                case "futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            morfema = "iré";
                            break;
                        case "2daSingular":
                            morfema = "irás";
                            break;
                        case "3raSingular":
                            morfema = "irá";
                            break;
                        case "1raPlural":
                            morfema = "iremos";
                            break;
                        case "2daPlural":
                            morfema = "iréis";
                            break;
                        case "3raPlural":
                            morfema = "irán";
                            break;
                    }
                    break;

                #endregion
                #region AnteFuturo

                case "ante futuro":
                    switch (NumPers)
                    {
                        case "1raSingular":
                            verbo = "habré " + verbo;
                            break;
                        case "2daSingular":
                            verbo = "habrás " + verbo;
                            break;
                        case "3raSingular":
                            verbo = "habrá " + verbo;
                            break;
                        case "1raPlural":
                            verbo = "habremos " + verbo;
                            break;
                        case "2daPlural":
                            verbo = "habréis " + verbo;
                            break;
                        case "3raPlural":
                            verbo = "habrán " + verbo;
                            break;
                    }
                    break;

                #endregion
            }
            verbo += morfema;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = Conjuga_Verbo(textBox1.Text);
            timer1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Enabled = false;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
