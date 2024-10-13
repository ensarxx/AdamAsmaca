using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

namespace AdamAsmaca
{
    internal static class Program
    {

        public static string[] sehirler = {"Adana", "Ad�yaman", "Afyonkarahisar", "A�r�", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan",
    "Artvin", "Ayd�n", "Bal�kesir", "Bart�n", "Batman", "Bayburt", "Bilecik", "Bing�l", "Bitlis",
    "Bolu", "Burdur", "Bursa", "�anakkale", "�ank�r�", "�orum", "Denizli", "Diyarbak�r", "D�zce",
    "Edirne", "Elaz��", "Erzincan", "Erzurum", "Eski�ehir", "Gaziantep", "Giresun", "G�m��hane",
    "Hakk�ri", "Hatay", "I�d�r", "Isparta", "�stanbul", "�zmir", "Kahramanmara�", "Karab�k", "Karaman",
    "Kastamonu", "Kayseri", "K�r�kkale", "K�rklareli", "K�r�ehir", "Kilis", "Konya", "K�tahya",
    "Malatya", "Manisa", "Mardin", "Mersin", "Mu�la", "Mu�", "Nev�ehir", "Ni�de", "Ordu",
    "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirda�", "Tokat",
    "Trabzon", "Tunceli", "�anl�urfa", "U�ak", "Van", "Yalova", "Yozgat", "Zonguldak"};


        public static Label[] labelList;
        public static PictureBox[] pictureList;
        public static string rndSehir = "yok";


        [STAThread]

        
        static void Main()
        {

            

            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();

            Label[] localLabelList = { form.l1, form.l2, form.l3, form.l4, form.l5, form.l6, form.l7, form.l8, form.l9, form.l10, form.l11, form.l12, form.l13, form.l14 };
            PictureBox[] localPictureList = { form.p1, form.p2, form.p3, form.p4, form.p5, form.p6, form.p7 };


            pictureList = localPictureList;
            labelList = localLabelList;

            for (int i = 0; i < pictureList.Length; i++)
            {
                pictureList[i].Visible = false;
            }

            for (int i = 0; i < labelList.Length; i++)
            {
                labelList[i].Visible = false; // Kelime karakter say�s� kadar label aktif hale getirmek i�in �ncelikle hepsi g�r�nmez hale getirildi.
            }


            Random rnd = new Random();
            int r = rnd.Next(labelList.Count());
            rndSehir = sehirler[r];
            //MessageBox.Show("�ehir: "+rndSehir+" girilenText: "+ form.girilenText);

            
            for (int i = 0; i < rndSehir.Length; i++) {

                labelList[i].Visible = true;// Kelime karakter say�s� kadar label aktifle�tirildi.
            }

            

            Application.Run(form);




        }
    }
}