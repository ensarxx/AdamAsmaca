using System.Collections.Generic;
using System.Diagnostics;
using System.Web;

namespace AdamAsmaca
{
    internal static class Program
    {

        public static string[] sehirler = {"Adana", "Adýyaman", "Afyonkarahisar", "Aðrý", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan",
    "Artvin", "Aydýn", "Balýkesir", "Bartýn", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis",
    "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankýrý", "Çorum", "Denizli", "Diyarbakýr", "Düzce",
    "Edirne", "Elazýð", "Erzincan", "Erzurum", "Eskiþehir", "Gaziantep", "Giresun", "Gümüþhane",
    "Hakkâri", "Hatay", "Iðdýr", "Isparta", "Ýstanbul", "Ýzmir", "Kahramanmaraþ", "Karabük", "Karaman",
    "Kastamonu", "Kayseri", "Kýrýkkale", "Kýrklareli", "Kýrþehir", "Kilis", "Konya", "Kütahya",
    "Malatya", "Manisa", "Mardin", "Mersin", "Muðla", "Muþ", "Nevþehir", "Niðde", "Ordu",
    "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdað", "Tokat",
    "Trabzon", "Tunceli", "Þanlýurfa", "Uþak", "Van", "Yalova", "Yozgat", "Zonguldak"};


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
                labelList[i].Visible = false; // Kelime karakter sayýsý kadar label aktif hale getirmek için öncelikle hepsi görünmez hale getirildi.
            }


            Random rnd = new Random();
            int r = rnd.Next(labelList.Count());
            rndSehir = sehirler[r];
            //MessageBox.Show("þehir: "+rndSehir+" girilenText: "+ form.girilenText);

            
            for (int i = 0; i < rndSehir.Length; i++) {

                labelList[i].Visible = true;// Kelime karakter sayýsý kadar label aktifleþtirildi.
            }

            

            Application.Run(form);




        }
    }
}