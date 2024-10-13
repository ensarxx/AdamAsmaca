namespace AdamAsmaca
{
    public partial class Form1 : Form
    {




        public int yanlisSayisi = 0;

        public Form1()
        {



            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girilenText = textBox1.Text;


            bool eslesme = false;



            if (girilenText.Length == 1)
            {

                for (int i = 0; i < Program.rndSehir.Length; i++)
                {

                    if (girilenText.ToLower() == Program.rndSehir[i].ToString().ToLower())
                    {
                        Program.labelList[i].Text = girilenText.ToUpper();
                        eslesme = true;
                    }



                }
            }
            else if (girilenText.ToLower() != Program.rndSehir.ToLower() && yanlisSayisi < 8)
            { 

                MessageBox.Show("Yanlýþ Tahmin !");
                MessageBox.Show(yanlisSayisi.ToString());
                Program.pictureList[yanlisSayisi].Visible = true;
                eslesme = true;
                yanlisSayisi++;



            }






            if (girilenText.ToLower() == Program.rndSehir.ToLower())
            {
                for (int i = 0; i < Program.rndSehir.Length; i++)
                {

                    Program.labelList[i].Text = Program.rndSehir[i].ToString().ToUpper();

                }
                eslesme = true;
                MessageBox.Show("DOÐRU !");
                Application.Restart();
                yanlisSayisi = 0;

            }

            if (eslesme == false)
            {
                if (yanlisSayisi == 7)
                {
                    MessageBox.Show("Kaybettin !");
                    Application.Restart();
                }
                else
                {

                    Program.pictureList[yanlisSayisi].Visible = true;
                    yanlisSayisi++;
                }
            }



        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}