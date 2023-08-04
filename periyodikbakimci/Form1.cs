using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace periyodikbakimci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // KWPH YAZI METODU
        public static string kwhpmetot(string hpkw)
        {
            string kwhpbul = hpkw;
            string kwhp = "";

            for (int i = 0; i <= kwhpbul.Length - 1; i++)
            {
                kwhp += kwhpbul[i];
                if (kwhpbul[i] == ')') break;
            }

            return kwhp;
        }






        // BEYGİR BULMA METODU
        public static string beygirbulmetod(string beygir)
        {
            string ilkbeygir = beygir;
            string sonbeygir = "";

            for (int i = 0; i <= ilkbeygir.Length - 1; i++)
            {
                if (ilkbeygir[i] == '-')
                {
                    for (int j = i + 1; j <= ilkbeygir.Length - 1; j++)
                    {
                        if (ilkbeygir[j] != 'H')
                        {
                            sonbeygir += ilkbeygir[j];
                        }
                        else break;
                    }
                }
            }


            return sonbeygir;
        }








        // ÜRÜN MARKA BÖLME METODU
        public static string sonmarkametod(string marka)
        {
            string aaa = "";
            string sonmarka = "";
            for (int i = marka.Length - 1; i >= 0; i--)
            {
                if (marka[i] != ')')
                {
                    aaa += marka[i];
                }
                else break;
            }
            for (int i = aaa.Length - 1; i >= 0; i--)
            {
                sonmarka += aaa[i];
            }

            return sonmarka;
        }







        // MARKA AÇIKLAMA YAZISI METODU
        public static string markaciklamametod(string sonmarka)
        {
            string markayazısı = "";

            if (sonmarka.Contains("Bosch"))
            {
                markayazısı = "Bosch, dünyanın en büyük otomotiv yedek parça sağlayıcısıdır.";
            }

            else if (sonmarka.Contains("Sardes"))
            {
                markayazısı = "Sardes,uzun yıllardır yerli üretim yapan üretici firmadır.";
            }

            else if (sonmarka.Contains("Mann"))
            {
                markayazısı = "Mann, yüksek performanslı, hassas mühendislik ürünleri üreten firmadır.";
            }

            else if (sonmarka.Contains("Filtron"))
            {
                markayazısı = "Filtron, orijinal ekipman üretimi yapan firma mann+hummel grubunun bünyesinde üretim yapmaktadır.";
            }

            else if (sonmarka.Contains("Kruger"))
            {
                markayazısı = "Kruger, atak taşıt güvencesiyle Türkiye pazarında kendini kanıtlamış markadır.";
            }

            else if (sonmarka.Contains("Delphi"))
            {
                markayazısı = "Delphi, yakıt alanında kendini kanıtlamış markadır.";
            }

            else if (sonmarka.Contains("Kraftvoll"))
            {
                markayazısı = "Kraftvoll, dinamik otomotiv güvencesinde Türkiye pazarında önemini her geçen gün çeşitli ürün ağıyla sağlamaktadır.";
            }

            else if (sonmarka.Contains("Fomoco"))
            {
                markayazısı = "Fomoco, Ford Otosan Sanayi orijinal yedek parça markasıdır.";
            }
            

            return markayazısı;
        }









        // ARABA MODEL AYIKLAMA METODU
        public static string modelmetod(string arabaninyili)
        {
            string modelyılı = "";

            if (arabaninyili.Contains('-'))
            {
                modelyılı += arabaninyili + " model yılı ve arasında ";
            }

            else if (arabaninyili.EndsWith("→"))
            {
                string mmm = arabaninyili;
                for (int i = 0; i < mmm.Length - 1; i++)
                {
                    modelyılı += mmm[i];
                }
                modelyılı += " model yılı ve sonrasında ";
            }

            else if (arabaninyili.StartsWith("→"))
            {
                string mmm = arabaninyili;
                for (int i = 1; i < mmm.Length; i++)
                {
                    modelyılı += mmm[i];
                }
                modelyılı += " model yılı ve öncesinde ";
            }

            else
            {
                modelyılı += arabaninyili + " model yılında ";
            }




            return modelyılı;
        }








        // ELİMİZDEKİ MEVCUT MARKALAR İÇİN METOD
        public static string elimizdekimetod(string textbox3)
        {
            string mevcut = "";
            string virgul = "";
            if (textbox3.Contains(" "))
            {
                string[] mdizi = textbox3.Split(' ');

                foreach (var item in mdizi)
                {
                    mevcut += virgul + item;
                    virgul = ", ";
                }
                mevcut += " marka seçeneklerimiz mevcuttur.";
            }
            else mevcut += textbox3 + " marka seçeneğimiz mevcuttur.";



            return mevcut;
        }










        // MOTOR KODU YAZDIRMAK İÇİN METOD
        public static string motokodmetod(string textbox2)
        {
            string motoyaz = "";
            string virgül = "";
            if (textbox2.Contains('-'))
            {
                string[] mot = textbox2.ToUpper().Split('-');

                foreach (var item in mot)
                {
                    if (item != " ")
                    {
                        motoyaz += virgül + item;
                        virgül = ", ";
                    }
                }
            }
            else motoyaz = textbox2.ToUpper();


            return motoyaz;
        }











        // UYUMLU MODELLER İŞLEMİ İÇİN METOD
        public static string uyumlumodelmetod(string model5)
        {
            string amodel = model5;

            string msayac = "";
            string myılsayac = "";

            string sonyil = "";


            string newmetn = model5;
            string bul = "";
            for (int i = 1; i < model5.Length - 2; i++)
            {
                bul += newmetn[i];
            }




            // OK EĞER SADECE YIL İLE SONRASIYSA VEYA ÖNCESİYSE
            string a = model5;
            string sonc = "";
            if (a.Length == 5)
            {
                if (a.StartsWith("→"))
                {
                    for (int i = 1; i < 5; i++)
                    {
                        sonc += a[i];
                    }

                    sonyil = " " + sonc + " Model Yılı Ve Öncesi";


                }


                else if (a.EndsWith("→"))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sonc += a[i];
                    }

                    sonyil = " " + sonc + " Model Yılı Ve Sonrası";
                }
            }






            else if (amodel.Length == 9)
            {
                sonyil = amodel + " Model Yılı Ve Arası";
            }





            // BAŞLIYORSA
            else if (amodel.StartsWith("→"))
            {
                for (int i = 1; i < 3; i++)
                {
                    msayac += amodel[i];
                }


                for (int j = 4; j < 8; j++)
                {
                    myılsayac += amodel[j];
                }



                if (msayac == "01")
                {
                    sonyil = "Ocak " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "02")
                {
                    sonyil = "Şubat " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "03")
                {
                    sonyil = "Mart " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "04")
                {
                    sonyil = "Nisan " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "05")
                {
                    sonyil = "Mayıs " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "06")
                {
                    sonyil = "Haziran " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "07")
                {
                    sonyil = "Şubat " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "07")
                {
                    sonyil = "Temmuz " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "08")
                {
                    sonyil = "Ağustos " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "09")
                {
                    sonyil = "Eylül " + myılsayac + " Model Yılı Ve Öncesi";
                }



                else if (msayac == "10")
                {
                    sonyil = "Ekim " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "11")
                {
                    sonyil = "Kasım " + myılsayac + " Model Yılı Ve Öncesi";
                }


                else if (msayac == "12")
                {
                    sonyil = "Aralık " + myılsayac + " Model Yılı Ve Öncesi";
                }
            }



            // BİTİYORSA
            else if (amodel.EndsWith("→"))
            {

                for (int i = 0; i < 2; i++)
                {
                    msayac += amodel[i];
                }


                for (int j = 3; j < 7; j++)
                {
                    myılsayac += amodel[j];
                }



                if (msayac == "01")
                {
                    sonyil = "Ocak " + myılsayac + " Model Yılı Ve Sonrası";
                }


                else if (msayac == "02")
                {
                    sonyil = "Şubat " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "03")
                {
                    sonyil = "Mart " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "04")
                {
                    sonyil = "Nisan " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "05")
                {

                    sonyil = "Mayıs " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "06")
                {
                    sonyil = "Haziran " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "07")
                {
                    sonyil = "Temmuz " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "08")
                {
                    sonyil = "Ağustos " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "09")
                {
                    sonyil = "Eylül " + myılsayac + " Model Yılı Ve Sonrası";
                }


                else if (msayac == "10")
                {
                    sonyil = "Ekim " + myılsayac + " Model Yılı Ve Sonrası";
                }



                else if (msayac == "11")
                {
                    sonyil = "Kasım " + myılsayac + " Model Yılı Ve Sonrası";
                }


                else if (msayac == "12")
                {
                    sonyil = "Aralık " + myılsayac + " Model Yılı Ve Sonrası";
                }
            }


            // OK ARASINDAYSA
            else if (bul.Contains("→") || bul.Contains("-"))
            {
                string ikincimsayac = "";
                string ikincimyılsayac = "";

                string sonyılsayac = "";


                // İLK AY
                for (int i = 0; i < 2; i++)
                {
                    msayac += amodel[i];
                }

                // İLK YIL
                for (int j = 3; j < 7; j++)
                {
                    myılsayac += amodel[j];
                }


                if (msayac == "01")
                {
                    sonyılsayac += "Ocak " + myılsayac + " ve ";
                }

                else if (msayac == "02")
                {
                    sonyılsayac += "Şubat " + myılsayac + " ve ";
                }

                else if (msayac == "03")
                {
                    sonyılsayac += "Mart " + myılsayac + " ve ";
                }

                else if (msayac == "04")
                {
                    sonyılsayac += "Nisan " + myılsayac + " ve ";
                }

                else if (msayac == "05")
                {
                    sonyılsayac += "Mayıs " + myılsayac + " ve ";
                }

                else if (msayac == "06")
                {
                    sonyılsayac += "Haziran " + myılsayac + " ve ";
                }

                else if (msayac == "07")
                {
                    sonyılsayac += "Temmuz " + myılsayac + " ve ";
                }

                else if (msayac == "08")
                {
                    sonyılsayac += "Ağustos " + myılsayac + " ve ";
                }

                else if (msayac == "09")
                {
                    sonyılsayac += "Eylül " + myılsayac + " ve ";
                }

                else if (msayac == "10")
                {
                    sonyılsayac += "Ekim " + myılsayac + " ve ";
                }

                else if (msayac == "11")
                {
                    sonyılsayac += "Kasım " + myılsayac + " ve ";
                }

                else if (msayac == "12")
                {
                    sonyılsayac += "Aralık " + myılsayac + " ve ";
                }






                // İKİNCİ AY
                for (int i = 8; i < 10; i++)
                {
                    ikincimsayac += amodel[i];
                }


                // İKİNCİ YIL
                for (int i = 11; i < 15; i++)
                {
                    ikincimyılsayac += amodel[i];
                }


                if (ikincimsayac == "01")
                {
                    sonyılsayac += "Ocak " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "02")
                {
                    sonyılsayac += "Şubat " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "03")
                {
                    sonyılsayac += "Mart " + ikincimyılsayac + " Model Yılları Arası";
                }


                else if (ikincimsayac == "04")
                {
                    sonyılsayac += "Nisan " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "05")
                {
                    sonyılsayac += "Mayıs " + ikincimyılsayac + " Model Yılları Arası";
                }


                else if (ikincimsayac == "06")
                {
                    sonyılsayac += "Haziran " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "07")
                {
                    sonyılsayac += "Temmuz " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "08")
                {
                    sonyılsayac += "Ağustos " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "09")
                {
                    sonyılsayac += "Eylül " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "10")
                {
                    sonyılsayac += "Ekim " + ikincimyılsayac + " Model Yılları Arası";
                }


                else if (ikincimsayac == "11")
                {
                    sonyılsayac += "Kasım " + ikincimyılsayac + " Model Yılları Arası";
                }

                else if (ikincimsayac == "12")
                {
                    sonyılsayac += "Aralık " + ikincimyılsayac + " Model Yılları Arası";
                }
                sonyil = sonyılsayac;
            }
            else sonyil = model5 + " Model Yılı";



            return sonyil;
        }








        // YIL ARASI YAZ METOD
        public static string yazmodelimetod(string metin5, string sonyil)
        {
            string sonson = metin5;
            string yazsonson = "";
            if (sonson.StartsWith("→"))
            {
                for (int i = 1; i <= sonson.Length - 1; i++)
                {
                    yazsonson += sonson[i];
                }
            }
            else if (sonson.EndsWith("→"))
            {
                for (int i = 0; i <= sonson.Length - 2; i++)
                {
                    yazsonson += sonson[i];
                }
            }
            else yazsonson = metin5;



            string yyyaz = "";


            if (metin5.Length == 5)
            {
                yyyaz = "";
                yazsonson = sonyil;
            }

            else if (metin5.Contains('/'))
            {
                yyyaz = " (" + sonyil + ")";
            }

            else yyyaz = " Model Yılı Ve Arası";



            return yazsonson + yyyaz;
        }

















        // HAVA FİLTRESİ İŞLEMİ
        private void BtnHava_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // AUDİ MODELİ HAVA FİLTRESİ
            if (TxtAracBslk.Text.ToUpper().Contains("AUDİ"))
            {
                // Audi A6(4F/C6) 2.0TDI Hava Filtresi 10/2008→ (100KW-136HP)Bosch







                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Hava"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);   // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);   // metod çağrıldı






                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }







                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);   // metod çağrıldı







                            // MODEL YILI YAZISI
                            string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı







                            // MARKA İŞLEMİ
                            string markayazısı = markaciklamametod(sonmarka);   // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ
                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);   // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5].ToString());    // metod çağrıldı








                            // eğer arasıysa model yılı

                            string yazmodeli = yazmodelimetod(metindizi[5], sonyil);   // metod çağrıldı









                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazmodeli + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>: " + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu hava filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " hava filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Yakıtın tepkimeye girebilmesi için gerekli havayı süzer.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek motor içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Yanma odasına temiz hava göndererek yakıtın daha kolay tepkimeye girmesini sağlar.</li>\n" +
                            "<li>Yakıtın çiğ atılmasını engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Düzenli hava karışımı yakıt tasarrufu sağlar.</li>\n" +
                            "<li>Motorun daha sessiz ve gürültüsüz çalışmasını sağlar.</li>\n" +
                            "<li>Araç performansını ve çekişini arttırır.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Hava Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }










            // BMW MODELİ HAVA FİLTRESİ

            else if (TxtAracBslk.Text.ToUpper().Contains("BMW"))
            {

                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[1], model2 = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];





                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Hava"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);   // metod çağrıldı






                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı



                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }







                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ
                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);     // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);     // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + model2 + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;








                            // UYUMLU MODELLER İŞLEMİ

                            string sonyil = uyumlumodelmetod(metindizi[5].ToString());         // metod çağrıldı








                            // eğer arasıysa model yılı

                            string sonson = yazmodelimetod(metindizi[5], sonyil);        // metod çağrıldı












                            // ARAÇ YAZISI
                            string baslangıc = model[0].ToString();
                            string uyumluarac = "BMW " + baslangıc + " Serisi";








                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + uyumluarac + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + sonson + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>: " + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu hava filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " hava filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Yakıtın tepkimeye girebilmesi için gerekli havayı süzer.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek motor içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Yanma odasına temiz hava göndererek yakıtın daha kolay tepkimeye girmesini sağlar.</li>\n" +
                            "<li>Yakıtın çiğ atılmasını engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Düzenli hava karışımı yakıt tasarrufu sağlar.</li>\n" +
                            "<li>Motorun daha sessiz ve gürültüsüz çalışmasını sağlar.</li>\n" +
                            "<li>Araç performansını ve çekişini arttırır.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;






                        }
                        else MessageBox.Show("Girdiğiniz Ürün Hava Filtresine Ait Değildir");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi");
            }












            // CHEVROLET - CITROEN - DACIA HAVA FİLTRESİ

            else if (TxtAracBslk.Text.ToUpper().Contains("CHEVROLET") || TxtAracBslk.Text.ToUpper().Contains("CITROEN") || TxtAracBslk.Text.ToUpper().Contains("DACIA"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Hava"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);    // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı




                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }







                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                            // MARKA İŞLEMİ
                            string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);    // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(arabaninyili);    // metod çağrıldı







                            // eğer arasıysa model yılı

                            string uyumum = yazmodelimetod(arabaninyili, sonyil);    // metod çağrıldı






                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + uyumum + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>: " + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + araba + " " + model + " araçlara uyumlu hava filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " hava filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Yakıtın tepkimeye girebilmesi için gerekli havayı süzer.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek motor içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Yanma odasına temiz hava göndererek yakıtın daha kolay tepkimeye girmesini sağlar.</li>\n" +
                            "<li>Yakıtın çiğ atılmasını engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Düzenli hava karışımı yakıt tasarrufu sağlar.</li>\n" +
                            "<li>Motorun daha sessiz ve gürültüsüz çalışmasını sağlar.</li>\n" +
                            "<li>Araç performansını ve çekişini arttırır.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Hava Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }











            // FORD MODELİ HAVA FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("FORD"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba, model, motor, uruncesidi, arabaninyili, kwsı;

                // Ford Focus I 1.6 / 16V Hava Filtresi 1998-2004 (74KW-100HP)Sardes
                // Ford Fiesta VI / Fiesta VII 1.25 Hava Filtresi 2008→ (60KW-82HP)Sardes
                // Ford Fiesta V / Fiesta VI 1.4 16V Hava Filtresi 2002-2008 (59KW-80HP)Bosch

                // Ford Focus II 1.6TDCİ Hava Filtresi →03/2007 (80KW-109HP)Sardes

                // Ford Mondeo IV 2.0İ Hava Filtresi 1996→2000 (96KW-130HP)Sardes

                // Ford Tourneo Connect 1.8TDCİ TurboDiesel Hava Filtresi 2011-2015 (110KW-150HP)Delphi 

                // Ford Transit Tourneo Courier 1.8TDCİ Hava Filtresi 2011-2015 (110KW-150HP)Delphi

                string ölcüm = metindizi[2];

                if (TxtAracBslk.Text.ToUpper().Contains("MONDEO"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("RANGER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("CONNECT"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("COURİER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("FİESTA"))
                {
                    if (TxtAracBslk.Text.ToUpper().Contains("16V"))
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6] + " " + metindizi[7];
                        uruncesidi = metindizi[8] + " " + metindizi[9];
                        arabaninyili = metindizi[10];
                        kwsı = metindizi[11];
                    }
                    else
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6];
                        uruncesidi = metindizi[7] + " " + metindizi[8];
                        arabaninyili = metindizi[9];
                        kwsı = metindizi[10];
                    }
                    
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("TDCİ") || TxtAracBslk.Text.ToUpper().Contains("ECOBOOST")) //dizel
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("III"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("FOCUS"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    motor = metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    uruncesidi = metindizi[6] + " " + metindizi[7];
                    arabaninyili = metindizi[8];
                    kwsı = metindizi[9];
                }

                else //benzinli normal
                {
                    araba = metindizi[0];
                    model = metindizi[1];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }




                if (TxtMevcutMrk.Text != "")
                {
                    if (uruncesidi.Contains("Hava"))
                    {







                        // KWHP
                        string kwhp = kwhpmetot(kwsı);    // metod çağrıldı








                        // BEYGİR BULMA İŞLEMİ
                        string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı




                        string kwwhpp = "";
                        for (int i = 1; i <= kwhp.Length - 2; i++)
                        {
                            kwwhpp += kwhp[i];
                        }







                        // ÜRÜN MARKA BÖLME İŞLEMİ
                        string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                        // MODEL YILI YAZISI

                        string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                        // MARKA İŞLEMİ
                        string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                        // MEVCUT MARKA İŞLEMİ

                        string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                        // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                        string motoyaz = "";
                        if (TxtMotorKod.Text == "")
                        {
                            motoyaz = "";
                        }
                        else motoyaz =
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                        "<td class=\"\">:" + " " + TxtMotorKod.Text + " " + "</td>\n" +
                        "</tr>\n";






                        // BAŞLIK YAZDIRMA İŞLEMİ
                        string baslık = TxtAracBslk.Text;










                        // UYUMLU MODELLER İŞLEMİ
                        string sonyil = uyumlumodelmetod(arabaninyili);    // metod çağrıldı







                        // eğer arasıysa model yılı

                        string uyumum = yazmodelimetod(arabaninyili, sonyil);    // metod çağrıldı




                        string kelimeeki;
                        if (sonyil.Contains("Öncesi"))
                        {
                            kelimeeki = "nde";
                        }
                        else
                        {
                            kelimeeki = "nda";
                        }



                        // SON YAZDIRMA İŞLEMİ

                        string metin =
                        "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                        "<div>\n" +
                        "<table style=\"border-collapse: collapse;\">\n" +
                        "<tbody>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                        "<td>: " + araba + " " + model + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                        "<td>: " + sonyil + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                        "<td>: " + " " + motor + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                        "<td>:" + " " + kwwhpp + "</td>\n" +
                        "</tr>\n" +
                        motoyaz +
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                        "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                        "</tr>\n" +
                        "</tbody>\n" +
                        "</table>\n" +
                        "</div>\n" +
                        "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + araba + " " + model + " araçlara uyumlu hava filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                        "<ul>\n" +
                        "<li>" + markayazısı + "</li>\n" +
                        "<li>" + araba + " " + model + " hava filtresi için " + mevcut + "</li>\n" +
                        "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                        "</ul>\n" +
                        "<div></div>\n" +
                        "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Ne İşe Yarar ?</span><br />\n" +
                        "<ul>\n" +
                        "<li>Yakıtın tepkimeye girebilmesi için gerekli havayı süzer.</li>\n" +
                        "<li>Dışarıdan aldığı havayı filtreleyerek motor içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                        "<li>Yanma odasına temiz hava göndererek yakıtın daha kolay tepkimeye girmesini sağlar.</li>\n" +
                        "<li>Yakıtın çiğ atılmasını engeller.</li>\n" +
                        "</ul>\n" +
                        "<div></div>\n" +
                        "<div></div>\n" +
                        "<span style=\"font-weight: bold;\">" + araba + " " + model + " Hava Filtresi Faydaları</span><br />\n" +
                        "<ul>\n" +
                        "<li>Düzenli hava karışımı yakıt tasarrufu sağlar.</li>\n" +
                        "<li>Motorun daha sessiz ve gürültüsüz çalışmasını sağlar.</li>\n" +
                        "<li>Araç performansını ve çekişini arttırır.</li>\n" +
                        "</ul>\n" +
                        "<div> </div>\n" +
                        "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        richTextBox1.Text = metin;
                    }
                    else MessageBox.Show("Girdiğiniz Ürün Hava Filtresine Ait Değildir !!!");
                }
                else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
            }


        }














        // YAĞ FİLTRESİ İŞLEMİ
        private void BtnYag_Click(object sender, EventArgs e)
        {
            // Audi A6(4F/C6) 2.0TDI Hava Filtresi 10/2008→ (100KW-136HP)Bosch


            richTextBox1.Clear();







            // AUDİ YAĞ FİLTRESİ
            if (TxtAracBslk.Text.ToUpper().Contains("AUDİ"))
            {

                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];

                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi.Contains("Yağ"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);      // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);      // metod çağrıldı



                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);      // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);      // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);      // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);      // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);      // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;











                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);      // metod çağrıldı







                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(arabaninyili, sonyil);      // metod çağrıldı







                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu yağ filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yağ filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Otomobil motorları ağırlıklı olarak  metal (piston-krank-gömlek vb.) parçalardan oluşur. Hepsi bir biriyle bağlantılı çalıştığı için sürtünme oluşur.</li>\n" +
                            "<li>Bu sürtünmeyi azaltmak ve en aza indirmek için motor yağı kullanılır. Sürtünme ne olursa olsun devam ettiği için aşınan metal parçalar, demir tozları oluşur.</li>\n" +
                            "<li>Metal parçaları ve tozları devridaim sırasında yağ filtresinden geçerek  yağın daha temiz motora ulaşmasını sağlar .</li>\n" +
                            "<li>Yağ filtresini periyodik bakımlarınızda değiştiriniz.</li>\n" +
                            "<li>Yağ filtrelerinin içerisinde bulunan kağıt Artık yağı süzemeyecek duruma geldiği zaman süzemediği parçacıkları ve demir tozlarını motorun içerisine göndermeye başlayacak ve motor içerisinde bulunan yedek parçaları daha fazla aşındırma yapacaktır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Motor aşınmasını en aza indirir</li>\n" +
                            "<li>Motor içindeki yağın daha temiz dolaşımını sağlar.</li>\n" +
                            "<li>Motor ömrünü uzatır.</li>\n" +
                            "<li>Motor performansını artırır.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar. </li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yağ Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }










            // BMW YAĞ FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("BMW"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[1], model2 = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];



                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi.Contains("Yağ"))
                        {

                            // BMW 3.20i (F30/F31) Yağ Filtresi(Karbonlu) 2012-2016 (125KW-170HP)Filtron


                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);        // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);        // metod çağrıldı


                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);       // metod çağrıldı








                            // MODEL YILI YAZISI
                            string modelyılı = modelmetod(arabaninyili);       // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);       // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);       // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);       // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + model2 + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;











                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);       // metod çağrıldı







                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);








                            // ARAÇ YAZISI
                            string baslangıc = model[0].ToString();
                            string uyumluarac = "BMW " + baslangıc + " Serisi";






                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + uyumluarac + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu yağ filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yağ filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Otomobil motorları ağırlıklı olarak  metal (piston-krank-gömlek vb.) parçalardan oluşur. Hepsi bir biriyle bağlantılı çalıştığı için sürtünme oluşur.</li>\n" +
                            "<li>Bu sürtünmeyi azaltmak ve en aza indirmek için motor yağı kullanılır. Sürtünme ne olursa olsun devam ettiği için aşınan metal parçalar, demir tozları oluşur.</li>\n" +
                            "<li>Metal parçaları ve tozları devridaim sırasında yağ filtresinden geçerek  yağın daha temiz motora ulaşmasını sağlar .</li>\n" +
                            "<li>Yağ filtresini periyodik bakımlarınızda değiştiriniz.</li>\n" +
                            "<li>Yağ filtrelerinin içerisinde bulunan kağıt Artık yağı süzemeyecek duruma geldiği zaman süzemediği parçacıkları ve demir tozlarını motorun içerisine göndermeye başlayacak ve motor içerisinde bulunan yedek parçaları daha fazla aşındırma yapacaktır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Motor aşınmasını en aza indirir</li>\n" +
                            "<li>Motor içindeki yağın daha temiz dolaşımını sağlar.</li>\n" +
                            "<li>Motor ömrünü uzatır.</li>\n" +
                            "<li>Motor performansını artırır.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar. </li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yağ Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");




            }










            // CHEVROLET - CITROEN - DACIA YAĞ FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("CHEVROLET") || TxtAracBslk.Text.ToUpper().Contains("CITROEN") || TxtAracBslk.Text.ToUpper().Contains("DACIA"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];

                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi.Contains("Yağ"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);     // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);     // metod çağrıldı


                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);     // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);     // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);     // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);     // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);     // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;











                            // UYUMLU MODELLER İŞLEMİ 
                            string sonyil = uyumlumodelmetod(metindizi[5]);      // metod çağrıldı







                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);      // metod çağrıldı







                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + araba + " " + model + " araçlara uyumlu yağ filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yağ filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Otomobil motorları ağırlıklı olarak  metal (piston-krank-gömlek vb.) parçalardan oluşur. Hepsi bir biriyle bağlantılı çalıştığı için sürtünme oluşur.</li>\n" +
                            "<li>Bu sürtünmeyi azaltmak ve en aza indirmek için motor yağı kullanılır. Sürtünme ne olursa olsun devam ettiği için aşınan metal parçalar, demir tozları oluşur.</li>\n" +
                            "<li>Metal parçaları ve tozları devridaim sırasında yağ filtresinden geçerek  yağın daha temiz motora ulaşmasını sağlar .</li>\n" +
                            "<li>Yağ filtresini periyodik bakımlarınızda değiştiriniz.</li>\n" +
                            "<li>Yağ filtrelerinin içerisinde bulunan kağıt Artık yağı süzemeyecek duruma geldiği zaman süzemediği parçacıkları ve demir tozlarını motorun içerisine göndermeye başlayacak ve motor içerisinde bulunan yedek parçaları daha fazla aşındırma yapacaktır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Motor aşınmasını en aza indirir</li>\n" +
                            "<li>Motor içindeki yağın daha temiz dolaşımını sağlar.</li>\n" +
                            "<li>Motor ömrünü uzatır.</li>\n" +
                            "<li>Motor performansını artırır.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar. </li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yağ Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }










            // FORD MODELİ YAĞ FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("FORD"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba, model, motor, uruncesidi, arabaninyili, kwsı;


                
                // Ford Mondeo IV 2.0İ Hava Filtresi 1996→2000 (96KW-130HP)Sardes


                string ölcüm = metindizi[2];

                if (TxtAracBslk.Text.ToUpper().Contains("MONDEO"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("RANGER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("CONNECT"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("COURİER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("FİESTA"))
                {
                    if (TxtAracBslk.Text.ToUpper().Contains("16V"))
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6] + " " + metindizi[7];
                        uruncesidi = metindizi[8] + " " + metindizi[9];
                        arabaninyili = metindizi[10];
                        kwsı = metindizi[11];
                    }
                    else
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6];
                        uruncesidi = metindizi[7] + " " + metindizi[8];
                        arabaninyili = metindizi[9];
                        kwsı = metindizi[10];
                    }

                }

                else if (TxtAracBslk.Text.ToUpper().Contains("TDCİ") || TxtAracBslk.Text.ToUpper().Contains("ECOBOOST")) //dizel
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("III"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("FOCUS"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    motor = metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    uruncesidi = metindizi[6] + " " + metindizi[7];
                    arabaninyili = metindizi[8];
                    kwsı = metindizi[9];
                }


                else //benzinli normal
                {
                    araba = metindizi[0];
                    model = metindizi[1];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }




                if (TxtMevcutMrk.Text != "")
                {
                    if (uruncesidi.Contains("Yağ"))
                    {
                        // Ford Focus I 1.6 / 16V Hava Filtresi 1998-2004 (74KW-100HP)Sardes
                        // Ford Fiesta VI / Fiesta VII 1.25 Hava Filtresi 2008→ (60KW-82HP)Sardes






                        // KWHP
                        string kwhp = kwhpmetot(kwsı);    // metod çağrıldı








                        // BEYGİR BULMA İŞLEMİ
                        string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı




                        string kwwhpp = "";
                        for (int i = 1; i <= kwhp.Length - 2; i++)
                        {
                            kwwhpp += kwhp[i];
                        }







                        // ÜRÜN MARKA BÖLME İŞLEMİ
                        string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                        // MODEL YILI YAZISI

                        string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                        // MARKA İŞLEMİ
                        string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                        // MEVCUT MARKA İŞLEMİ

                        string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                        // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                        string motoyaz = "";
                        if (TxtMotorKod.Text == "")
                        {
                            motoyaz = "";
                        }
                        else motoyaz =
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                        "<td class=\"\">:" + " " + TxtMotorKod.Text + " " + "</td>\n" +
                        "</tr>\n";






                        // BAŞLIK YAZDIRMA İŞLEMİ
                        string baslık = TxtAracBslk.Text;










                        // UYUMLU MODELLER İŞLEMİ
                        string sonyil = uyumlumodelmetod(arabaninyili);    // metod çağrıldı







                        // eğer arasıysa model yılı

                        string uyumum = yazmodelimetod(arabaninyili, sonyil);    // metod çağrıldı





                        string kelimeeki;

                        if (sonyil.Contains("Öncesi"))
                        {
                            kelimeeki = "nde";
                        }
                        else
                        {
                            kelimeeki = "nda";
                        }



                        // SON YAZDIRMA İŞLEMİ

                        string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + sonyil + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            motoyaz +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + araba + " " + model + " araçlara uyumlu yağ filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yağ filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Otomobil motorları ağırlıklı olarak metal (piston-krank-gömlek vb.) parçalardan oluşur. Hepsi bir biriyle bağlantılı çalıştığı için sürtünme oluşur.</li>\n" +
                            "<li>Bu sürtünmeyi azaltmak ve en aza indirmek için motor yağı kullanılır. Sürtünme ne olursa olsun devam ettiği için aşınan metal parçalar, demir tozları oluşur.</li>\n" +
                            "<li>Metal parçaları ve tozları devridaim sırasında yağ filtresinden geçerek  yağın daha temiz motora ulaşmasını sağlar .</li>\n" +
                            "<li>Yağ filtresini periyodik bakımlarınızda değiştiriniz.</li>\n" +
                            "<li>Yağ filtrelerinin içerisinde bulunan kağıt Artık yağı süzemeyecek duruma geldiği zaman süzemediği parçacıkları ve demir tozlarını motorun içerisine göndermeye başlayacak ve motor içerisinde bulunan yedek parçaları daha fazla aşındırma yapacaktır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yağ Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Motor aşınmasını en aza indirir</li>\n" +
                            "<li>Motor içindeki yağın daha temiz dolaşımını sağlar.</li>\n" +
                            "<li>Motor ömrünü uzatır.</li>\n" +
                            "<li>Motor performansını artırır.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar. </li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        richTextBox1.Text = metin;
                    }
                    else MessageBox.Show("Girdiğiniz Ürün Yağ Filtresine Ait Değildir !!!");
                }
                else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
            }

        }













        // YAKIT FİLTRESİ İŞLEMİ
        private void BtnYakıt_Click(object sender, EventArgs e)
        {
            // Audi A6(4F/C6) 2.0TDI Yakıt Filtresi 10/2008→ (100KW-136HP) Bosch


            richTextBox1.Clear();





            // AUDİ YAKIT FİLTRESİ
            if (TxtAracBslk.Text.ToUpper().Contains("AUDİ"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Yakıt"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);        // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);        // metod çağrıldı


                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);        // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);        // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);        // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);        // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);        // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);        // metod çağrıldı







                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);        // metod çağrıldı









                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">: " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu yakıt filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yakıt filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Zamanla yakıt içerisinde oluşabilecek katı partikülleri süzmeye yarar.</li>\n" +
                            "<li>Enjeksiyon sistemine temiz yakıt gelmesini sağlar.</li>\n" +
                            "<li>Araç motorunun daha düzenli çalışmasını sağlar.</li>\n" +
                            "<li>Yanma odasındaki yakıtın tepkimeye girmesini kolaylaştırır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Araç çekiş ve performansını arttırır.</li>\n" +
                            "<li>Yakıt sisteminde bulunan yedek parça ömrünü uzatır.</li>\n" +
                            "<li>Aracın rolanti dengesini sağlar.</li>\n" +
                            "<li>Aracın rahat çalışmasını sağlar.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yakıt Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }











            // BMW YAKIT FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("BMW"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[1], model2 = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Yakıt"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);         // metod çağrıldı


                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);         // metod çağrıldı








                            // MODEL YILI YAZISI
                            string modelyılı = modelmetod(arabaninyili);         // metod çağrıldı








                            // MARKA İŞLEMİ
                            string markayazısı = markaciklamametod(sonmarka);         // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ
                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);         // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);         // metod çağrıldı












                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);         // metod çağrıldı







                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);         // metod çağrıldı




                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + model2 + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;






                            // ARAÇ YAZISI
                            string baslangıc = model[0].ToString();
                            string uyumluarac = "BMW " + baslangıc + " Serisi";





                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + uyumluarac + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">: " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu yakıt filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yakıt filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Zamanla yakıt içerisinde oluşabilecek katı partikülleri süzmeye yarar.</li>\n" +
                            "<li>Enjeksiyon sistemine temiz yakıt gelmesini sağlar.</li>\n" +
                            "<li>Araç motorunun daha düzenli çalışmasını sağlar.</li>\n" +
                            "<li>Yanma odasındaki yakıtın tepkimeye girmesini kolaylaştırır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Araç çekiş ve performansını arttırır.</li>\n" +
                            "<li>Yakıt sisteminde bulunan yedek parça ömrünü uzatır.</li>\n" +
                            "<li>Aracın rolanti dengesini sağlar.</li>\n" +
                            "<li>Aracın rahat çalışmasını sağlar.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yakıt Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }










            // CHEVROLET - CITROEN - DACIA YAKIT FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("CHEVROLET") || TxtAracBslk.Text.ToUpper().Contains("CITROEN") || TxtAracBslk.Text.ToUpper().Contains("DACIA"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Yakıt"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);       // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);       // metod çağrıldı


                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);       // metod çağrıldı








                            // MODEL YILI YAZISI
                            string modelyılı = modelmetod(arabaninyili);       // metod çağrıldı








                            // MARKA İŞLEMİ
                            string markayazısı = markaciklamametod(sonmarka);       // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ
                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);       // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);       // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);










                            // eğer arasıysa model yılı
                            string yazdır = yazmodelimetod(metindizi[5], sonyil);       // metod çağrıldı









                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">: " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + araba + " " + model + " araçlara uyumlu yakıt filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " yakıt filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Zamanla yakıt içerisinde oluşabilecek katı partikülleri süzmeye yarar.</li>\n" +
                            "<li>Enjeksiyon sistemine temiz yakıt gelmesini sağlar.</li>\n" +
                            "<li>Araç motorunun daha düzenli çalışmasını sağlar.</li>\n" +
                            "<li>Yanma odasındaki yakıtın tepkimeye girmesini kolaylaştırır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Araç çekiş ve performansını arttırır.</li>\n" +
                            "<li>Yakıt sisteminde bulunan yedek parça ömrünü uzatır.</li>\n" +
                            "<li>Aracın rolanti dengesini sağlar.</li>\n" +
                            "<li>Aracın rahat çalışmasını sağlar.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Yakıt Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }









            // FORD YAKIT FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("FORD"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba, model, motor, uruncesidi, arabaninyili, kwsı;



                
                // Ford Mondeo IV 2.0İ Hava Filtresi 1996→2000 (96KW-130HP)Sardes


                string ölcüm = metindizi[2];

                if (TxtAracBslk.Text.ToUpper().Contains("MONDEO"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("RANGER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("CONNECT"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("COURİER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("FİESTA"))
                {
                    if (TxtAracBslk.Text.ToUpper().Contains("16V"))
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6] + " " + metindizi[7];
                        uruncesidi = metindizi[8] + " " + metindizi[9];
                        arabaninyili = metindizi[10];
                        kwsı = metindizi[11];
                    }
                    else
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6];
                        uruncesidi = metindizi[7] + " " + metindizi[8];
                        arabaninyili = metindizi[9];
                        kwsı = metindizi[10];
                    }

                }

                else if (TxtAracBslk.Text.ToUpper().Contains("TDCİ") || TxtAracBslk.Text.ToUpper().Contains("ECOBOOST")) //dizel
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("III"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("FOCUS"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    motor = metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    uruncesidi = metindizi[6] + " " + metindizi[7];
                    arabaninyili = metindizi[8];
                    kwsı = metindizi[9];
                }


                else //benzinli normal
                {
                    araba = metindizi[0];
                    model = metindizi[1];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }




                if (TxtMevcutMrk.Text != "")
                {
                    if (uruncesidi.Contains("Yakıt"))
                    {
                        // Ford Focus I 1.6 / 16V Yakıt Filtresi 1998-2004 (74KW-100HP)Sardes
                        // Ford Fiesta VI / Fiesta VII 1.25 Yakıt Filtresi 2008→ (60KW-82HP)Sardes






                        // KWHP
                        string kwhp = kwhpmetot(kwsı);    // metod çağrıldı








                        // BEYGİR BULMA İŞLEMİ
                        string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı




                        string kwwhpp = "";
                        for (int i = 1; i <= kwhp.Length - 2; i++)
                        {
                            kwwhpp += kwhp[i];
                        }







                        // ÜRÜN MARKA BÖLME İŞLEMİ
                        string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                        // MODEL YILI YAZISI

                        string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                        // MARKA İŞLEMİ
                        string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                        // MEVCUT MARKA İŞLEMİ

                        string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                        // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                        string motoyaz = "";
                        if (TxtMotorKod.Text == "")
                        {
                            motoyaz = "";
                        }
                        else motoyaz =
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                        "<td class=\"\">:" + " " + TxtMotorKod.Text + " " + "</td>\n" +
                        "</tr>\n";






                        // BAŞLIK YAZDIRMA İŞLEMİ
                        string baslık = TxtAracBslk.Text;










                        // UYUMLU MODELLER İŞLEMİ
                        string sonyil = uyumlumodelmetod(arabaninyili);    // metod çağrıldı







                        // eğer arasıysa model yılı

                        string uyumum = yazmodelimetod(arabaninyili, sonyil);    // metod çağrıldı




                        string kelimeeki;

                        if (sonyil.Contains("Öncesi"))
                        {
                            kelimeeki = "nde";
                        }
                        else
                        {
                            kelimeeki = "nda";
                        }




                        // SON YAZDIRMA İŞLEMİ

                        string metin =
                           "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                           "<div>\n" +
                           "<table style=\"border-collapse: collapse;\">\n" +
                           "<tbody>\n" +
                           "<tr>\n" +
                           "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                           "<td>: " + araba + " " + model + "</td>\n" +
                           "</tr>\n" +
                           "<tr>\n" +
                           "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                           "<td>: " + sonyil + "</td>\n" +
                           "</tr>\n" +
                           "<tr>\n" +
                           "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                           "<td>:" + " " + motor + "</td>\n" +
                           "</tr>\n" +
                           "<tr>\n" +
                           "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                           "<td>:" + " " + kwwhpp + "</td>\n" +
                           "</tr>\n" +
                           motoyaz +
                           "<tr>\n" +
                           "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                           "<td class=\"\">: " + sonmarka.ToUpper() + "</td>\n" +
                           "</tr>\n" +
                           "</tbody>\n" +
                           "</table>\n" +
                           "</div>\n" +
                           "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + araba + " " + model + " araçlara uyumlu yakıt filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                           "<ul>\n" +
                           "<li>" + markayazısı + "</li>\n" +
                           "<li>" + araba + " " + model + " yakıt filtresi için " + mevcut + "</li>\n" +
                           "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                           "</ul>\n" +
                           "<div></div>\n" +
                           "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Ne İşe Yarar ?</span><br />\n" +
                           "<ul>\n" +
                           "<li>Zamanla yakıt içerisinde oluşabilecek katı partikülleri süzmeye yarar.</li>\n" +
                           "<li>Enjeksiyon sistemine temiz yakıt gelmesini sağlar.</li>\n" +
                           "<li>Araç motorunun daha düzenli çalışmasını sağlar.</li>\n" +
                           "<li>Yanma odasındaki yakıtın tepkimeye girmesini kolaylaştırır.</li>\n" +
                           "</ul>\n" +
                           "<div></div>\n" +
                           "<div></div>\n" +
                           "<span style=\"font-weight: bold;\">" + araba + " " + model + " Yakıt Filtresi Faydaları</span><br />\n" +
                           "<ul>\n" +
                           "<li>Araç çekiş ve performansını arttırır.</li>\n" +
                           "<li>Yakıt sisteminde bulunan yedek parça ömrünü uzatır.</li>\n" +
                           "<li>Aracın rolanti dengesini sağlar.</li>\n" +
                           "<li>Aracın rahat çalışmasını sağlar.</li>\n" +
                           "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar.</li>\n" +
                           "</ul>\n" +
                           "<div> </div>\n" +
                           "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        richTextBox1.Text = metin;
                    }
                    else MessageBox.Show("Girdiğiniz Ürün Yakıt Filtresine Ait Değildir !!!");
                }
                else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
            }


        }
        











        // POLEN FİLTRESİ İŞLEMİ
        private void BtnPolen_Click(object sender, EventArgs e)
        {
            // Audi A6(4F/C6) 2.0TDI Hava Filtresi 10/2008→ (100KW-136HP) Bosch


            richTextBox1.Clear();




            // AUDİ POLEN FİLTRESİ
            if (TxtAracBslk.Text.ToUpper().Contains("AUDİ"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Polen"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);      // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);      // metod çağrıldı



                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);      // metod çağrıldı








                            // MODEL YILI YAZISI
                            string modelyılı = modelmetod(arabaninyili);      // metod çağrıldı








                            // MARKA İŞLEMİ
                            string markayazısı = markaciklamametod(sonmarka);      // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);      // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);      // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);      // metod çağrıldı









                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);      // metod çağrıldı








                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">:" + " " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu polen filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " polen filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Kabin içerisine girecek havayı temizler.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek araç içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Kalorifer ve klima sisteminin daha kuvvetli üflemesini sağlar.</li>\n" +
                            "<li>Araç içirisinde oluşabilecek tozlanmayı engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Klima ve kalorifer sisteminin daha temiz ve verimli çalışmasını sağlar.</li>\n" +
                            "<li>Araç içi temiz havalandırma sağlar.</li>\n" +
                            "<li>Araç içerisinde oluşabilecek kötü kokuları engeller.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Polen Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }









            // BMW POLEN FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("BMW"))
            {

                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[1], model2 = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Polen"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);          // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);         // metod çağrıldı



                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);          // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);           // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);           // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);          // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);          // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + model2 + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);          // metod çağrıldı









                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);          // metod çağrıldı








                            // ARAÇ YAZISI
                            string baslangıc = model[0].ToString();
                            string uyumluarac = "BMW " + baslangıc + " Serisi";






                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + uyumluarac + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">:" + " " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + motoyaz + "</span> motor kodu ile başlayan,  " + araba + " " + model + " araçlara uyumlu polen filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " polen filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Kabin içerisine girecek havayı temizler.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek araç içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Kalorifer ve klima sisteminin daha kuvvetli üflemesini sağlar.</li>\n" +
                            "<li>Araç içirisinde oluşabilecek tozlanmayı engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Klima ve kalorifer sisteminin daha temiz ve verimli çalışmasını sağlar.</li>\n" +
                            "<li>Araç içi temiz havalandırma sağlar.</li>\n" +
                            "<li>Araç içerisinde oluşabilecek kötü kokuları engeller.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Polen Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }










            // CHEVROLET - CITROEN - DACIA POLEN FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("CHEVROLET") || TxtAracBslk.Text.ToUpper().Contains("CITROEN") || TxtAracBslk.Text.ToUpper().Contains("DACIA"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba = metindizi[0], model = metindizi[1], motor = metindizi[2], uruncesidi = metindizi[3] + " " + metindizi[4], arabaninyili = metindizi[5];




                if (TxtMotorKod.Text != "")
                {
                    if (TxtMevcutMrk.Text != "")
                    {
                        if (metindizi[3].Contains("Polen"))
                        {




                            // KWHP
                            string kwhp = kwhpmetot(metindizi[6]);          // metod çağrıldı








                            // BEYGİR BULMA İŞLEMİ
                            string sonbeygir = beygirbulmetod(kwhp);          // metod çağrıldı





                            string kwwhpp = "";
                            for (int i = 1; i <= kwhp.Length - 2; i++)
                            {
                                kwwhpp += kwhp[i];
                            }








                            // ÜRÜN MARKA BÖLME İŞLEMİ
                            string sonmarka = sonmarkametod(TxtAracBslk.Text);          // metod çağrıldı








                            // MODEL YILI YAZISI

                            string modelyılı = modelmetod(arabaninyili);          // metod çağrıldı








                            // MARKA İŞLEMİ

                            string markayazısı = markaciklamametod(sonmarka);          // metod çağrıldı







                            // MEVCUT MARKA İŞLEMİ

                            string mevcut = elimizdekimetod(TxtMevcutMrk.Text);          // metod çağrıldı








                            // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                            string motoyaz = motokodmetod(TxtMotorKod.Text);          // metod çağrıldı









                            // BAŞLIK YAZDIRMA İŞLEMİ
                            string baslık = araba + " " + model + " " + motor + " " + uruncesidi + " " + arabaninyili + " " + kwhp + " " + sonmarka;










                            // UYUMLU MODELLER İŞLEMİ
                            string sonyil = uyumlumodelmetod(metindizi[5]);          // metod çağrıldı






                            // YILYAZ
                            string ilkyazdır = "";
                            string metyaz = metindizi[5];
                            for (int i = 0; i <= metyaz.Length - 1; i++)
                            {
                                if (metyaz[i] != '→')
                                {
                                    ilkyazdır += metyaz[i];
                                }
                            }





                            // eğer arasıysa model yılı

                            string yazdır = yazmodelimetod(metindizi[5], sonyil);          // metod çağrıldı








                            // SON YAZDIRMA İŞLEMİ

                            string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + yazdır + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                            "<td class=\"\">:" + " " + TxtMotorKod.Text.ToUpper() + " " + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">:" + " " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " " + motor + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + "</span> üretilen, <span style=\"color: #ff0000;\">" + araba + " " + model + " araçlara uyumlu polen filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br />\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " polen filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Kabin içerisine girecek havayı temizler.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek araç içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Kalorifer ve klima sisteminin daha kuvvetli üflemesini sağlar.</li>\n" +
                            "<li>Araç içirisinde oluşabilecek tozlanmayı engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Klima ve kalorifer sisteminin daha temiz ve verimli çalışmasını sağlar.</li>\n" +
                            "<li>Araç içi temiz havalandırma sağlar.</li>\n" +
                            "<li>Araç içerisinde oluşabilecek kötü kokuları engeller.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                            richTextBox1.Text = metin;
                        }
                        else MessageBox.Show("Girdiğiniz Ürün Polen Filtresine Ait Değildir !!!");
                    }
                    else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
                }
                else MessageBox.Show("Motor Kodu Girilmedi !!!");
            }








            // FORD POLEN FİLTRESİ
            else if (TxtAracBslk.Text.ToUpper().Contains("FORD"))
            {
                string[] metindizi = TxtAracBslk.Text.Split(' ');

                string araba, model, motor, uruncesidi, arabaninyili, kwsı;



                // Ford Focus I 1.6 / 16V Polen Filtresi 1998-2004 (74KW-100HP)Sardes
                // Ford Fiesta VI / Fiesta VII 1.25 Polen Filtresi 2008→ (60KW-82HP)Sardes
                // Ford Focus III 1.6 Tİ-VCT Polen Filtresi 2011→ (92KW-125HP)Sardes
                // Ford Focus II 1.6TDCİ Hava Filtresi →03/2007 (80KW-109HP)Sardes
                // Ford Mondeo II 2.0İ Hava Filtresi 1996→2000 (96KW-130HP)Sardes


                string ölcüm = metindizi[2];

                if (TxtAracBslk.Text.ToUpper().Contains("MONDEO"))
                {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                        motor = metindizi[3];
                        uruncesidi = metindizi[4] + " " + metindizi[5];
                        arabaninyili = metindizi[6];
                        kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("RANGER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("CONNECT"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("COURİER"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }


                else if (TxtAracBslk.Text.ToUpper().Contains("FİESTA"))
                {
                    if (TxtAracBslk.Text.ToUpper().Contains("16V"))
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6] + " " + metindizi[7];
                        uruncesidi = metindizi[8] + " " + metindizi[9];
                        arabaninyili = metindizi[10];
                        kwsı = metindizi[11];
                    }
                    else
                    {
                        araba = metindizi[0];
                        model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                        motor = metindizi[6];
                        uruncesidi = metindizi[7] + " " + metindizi[8];
                        arabaninyili = metindizi[9];
                        kwsı = metindizi[10];
                    }

                }

                else if (TxtAracBslk.Text.ToUpper().Contains("TDCİ") || TxtAracBslk.Text.ToUpper().Contains("ECOBOOST")) //dizel
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3];
                    motor = metindizi[3];
                    uruncesidi = metindizi[4] + " " + metindizi[5];
                    arabaninyili = metindizi[6];
                    kwsı = metindizi[7];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("III"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4];
                    motor = metindizi[3] + " " + metindizi[4];
                    uruncesidi = metindizi[5] + " " + metindizi[6];
                    arabaninyili = metindizi[7];
                    kwsı = metindizi[8];
                }

                else if (TxtAracBslk.Text.ToUpper().Contains("FOCUS"))
                {
                    araba = metindizi[0];
                    model = metindizi[1] + " " + metindizi[2] + " " + metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    motor = metindizi[3] + " " + metindizi[4] + " " + metindizi[5];
                    uruncesidi = metindizi[6] + " " + metindizi[7];
                    arabaninyili = metindizi[8];
                    kwsı = metindizi[9];
                }


                else //benzinli normal
                {
                    araba = metindizi[0];
                    model = metindizi[1];
                    motor = metindizi[2];
                    uruncesidi = metindizi[3] + " " + metindizi[4];
                    arabaninyili = metindizi[5];
                    kwsı = metindizi[6];
                }




                if (TxtMevcutMrk.Text != "")
                {
                    if (uruncesidi.Contains("Polen"))
                    {
                        





                        // KWHP
                        string kwhp = kwhpmetot(kwsı);    // metod çağrıldı








                        // BEYGİR BULMA İŞLEMİ
                        string sonbeygir = beygirbulmetod(kwhp);    // metod çağrıldı




                        string kwwhpp = "";
                        for (int i = 1; i <= kwhp.Length - 2; i++)
                        {
                            kwwhpp += kwhp[i];
                        }







                        // ÜRÜN MARKA BÖLME İŞLEMİ
                        string sonmarka = sonmarkametod(TxtAracBslk.Text);    // metod çağrıldı








                        // MODEL YILI YAZISI

                        string modelyılı = modelmetod(arabaninyili);    // metod çağrıldı








                        // MARKA İŞLEMİ
                        string markayazısı = markaciklamametod(TxtAracBslk.Text);    // metod çağrıldı







                        // MEVCUT MARKA İŞLEMİ

                        string mevcut = elimizdekimetod(TxtMevcutMrk.Text);    // metod çağrıldı








                        // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                        string motoyaz = "";
                        if (TxtMotorKod.Text == "")
                        {
                            motoyaz = "";
                        }
                        else motoyaz =
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                        "<td class=\"\">:" + " " + TxtMotorKod.Text + " " + "</td>\n" +
                        "</tr>\n";






                        // BAŞLIK YAZDIRMA İŞLEMİ
                        string baslık = TxtAracBslk.Text;










                        // UYUMLU MODELLER İŞLEMİ
                        string sonyil = uyumlumodelmetod(arabaninyili);    // metod çağrıldı







                        // eğer arasıysa model yılı

                        string uyumum = yazmodelimetod(arabaninyili, sonyil);    // metod çağrıldı



                        string kelimeeki;

                        if (sonyil.Contains("Öncesi"))
                        {
                            kelimeeki = "nde";
                        }
                        else
                        {
                            kelimeeki = "nda";
                        }



                        // SON YAZDIRMA İŞLEMİ

                        string metin =
                            "<h2><span style=\"color: #002892;\">" + baslık + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + araba + " " + model + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + sonyil + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motor + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            motoyaz +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">:" + " " + sonmarka.ToUpper() + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + sonmarka + " marka olup " + araba + " " + model + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + araba + " " + model + " araçlara uyumlu polen filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + araba + " " + model + " polen filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Kabin içerisine girecek havayı temizler.</li>\n" +
                            "<li>Dışarıdan aldığı havayı filtreleyerek araç içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                            "<li>Kalorifer ve klima sisteminin daha kuvvetli üflemesini sağlar.</li>\n" +
                            "<li>Araç içirisinde oluşabilecek tozlanmayı engeller.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + araba + " " + model + " Polen Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Klima ve kalorifer sisteminin daha temiz ve verimli çalışmasını sağlar.</li>\n" +
                            "<li>Araç içi temiz havalandırma sağlar.</li>\n" +
                            "<li>Araç içerisinde oluşabilecek kötü kokuları engeller.</li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        richTextBox1.Text = metin;
                    }
                    else MessageBox.Show("Girdiğiniz Ürün Polen Filtresine Ait Değildir !!!");
                }
                else MessageBox.Show("Elinizdeki Mevcut Markalar Girilmedi !!!");
            }

        }
       







        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
