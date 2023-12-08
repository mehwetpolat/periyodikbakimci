using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace periyodikbakimci
{
    public partial class PeriyodikCode : Form
    {
        public PeriyodikCode()
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

            else if (sonmarka.Contains("BluePrint"))
            {
                markayazısı = "BluePrint, Asya ve Avrupa otomobilleri için yüksek kaliteli yedek parça üreticisidir.";
            }

            else if (sonmarka.Contains("Sion"))
            {
                markayazısı = "Sion; otomotiv, binek, hafif ticari ve ticari araçların tüm filtre çeşitlerini 20 yılı aşkın süredir üreten firmadır.";
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




        // ARAÇ MODEL AYIKLAMA
        public static string aracmodel(string baslik)
        {
            string[] dz = baslik.Split(' ');

            string model = "";


            for (int i = 1; i < dz.Length; i++)
            {
                if (i == 1)
                {
                    model += dz[i] + " ";
                }
                else model += " " + dz[i];
            }

            return model;
        }













        // arac model yazdırma
        public static string aramarkamodel(string baslk)
        {
            string modelim = "";

            string[] dz = baslk.Split(' ');



            for(int i = 1; i <= dz.Length; i++)
            {
                if (!dz[i].Contains("."))
                {
                    if (i == 1)
                    {
                        modelim += dz[i];
                    }
                    else modelim += " " + dz[i];
                }

                else break;
            }
            return modelim;
        }




        // motor tipi
        public static string motortipim(string mtr)
        {
            string[] dz = mtr.Split(' ');

            string motortip = "";
            

            for(int i = 1; i < dz.Length; i++)
            {
                if (dz[i].Contains('.'))
                {
                    motortip += dz[i];


                    for(int j = i+1; j < dz.Length; j++)
                    {

                        if (!dz[j].Contains("Polen") & !dz[j].Contains("Hava") & !dz[j].Contains("Yakıt") & !dz[j].Contains("Yağ"))
                        {
                            motortip += " " + dz[j];
                        }
                        else break;
                    }
                    break;
                }
            }
            return motortip;
        }



        // filtre tipi
        public static string filtretp(string filtr)
        {
            string fltp = "";

            if(filtr.Contains("Polen"))
            {
                fltp = "Polen Filtresi";
            }
            else if (filtr.Contains("Hava"))
            {
                fltp = "Hava Filtresi";
            }
            else if (filtr.Contains("Yağ"))
            {
                fltp = "Yağ Filtresi";
            }
            else if (filtr.Contains("Yakıt"))
            {
                fltp = "Yakıt Filtresi";
            }
            return fltp;
        }



        // model yili
        public static string modelyil(string mdl)
        {
            string mdlyl = "";


            string[] dz = mdl.Split(' ');

            for(int i = 2; i < dz.Length; i++)
            {
                if (dz[i] == "Filtresi")
                {
                    mdlyl = dz[i + 1];

                    break;
                }
            }

            return mdlyl;
        }



        // gücbeygir bulma
        static string gucbeygr(string kwbyg)
        {

            string[] dz = kwbyg.Split(' ');

            int cnt = dz.Length -1;

            string kwhpp = dz[cnt];



            string sonkw = "";

            foreach(var item in kwhpp)
            {
                sonkw += item;

                if (item == ')')
                {
                    break;
                }
            }

            return sonkw;
        }




        // filtrenin markası
        static string fltrmarkam(string flmrk)
        {
            string[] dz = flmrk.Split(' ');

            int cnt = dz.Length -1;

            string mrktek = dz[cnt];


            string sonflmrk = "";



            for (int i = 2; i < mrktek.Length; i++)
            {
                if (mrktek[i] == ')')
                {
                    for(int j = i +1; j < mrktek.Length; j++)
                    {
                        sonflmrk += mrktek[j];
                    }
                }
            }
            return sonflmrk;

        }



        private void btn_yazdır_Click(object sender, EventArgs e)
        {

            

            if (txt_baslik.Text != "")
            {
                if(txt_mvctmrk.Text != "")
                {
                    // TANIMLAMALAR

                    string[] basl = txt_baslik.Text.Split(' ');




                    string
                        anabaslik = txt_baslik.Text,
                        aracmarkamodel = basl[0] + " " + (aramarkamodel(txt_baslik.Text)),
                        motortipi = motortipim(txt_baslik.Text),
                        fltripi = filtretp(txt_baslik.Text),
                        motorkodu = txt_motorkod.Text,
                        amodel = aracmodel(anabaslik),
                        modelyili = modelyil(txt_baslik.Text),
                        gücbeygir = gucbeygr(txt_baslik.Text),
                        fltrmarka = fltrmarkam(txt_baslik.Text);





                    // ARAÇ MODEL
                    string model = aracmodel(anabaslik);


                    // KWHP
                    string kwhp = kwhpmetot(gücbeygir);


                    // Beygir bulma işlemi
                    string sonbeygir = beygirbulmetod(kwhp);



                    string kwwhpp = "";
                    for (int i = 1; i <= kwhp.Length - 2; i++)
                    {
                        kwwhpp += kwhp[i];
                    }




                    // MODEL YILI YAZISI
                    string modelyıl = modelmetod(modelyili);




                    // MARKA YAZISI İŞLEMİ
                    string markayazısı = markaciklamametod(fltrmarka);




                    // MEVCUT MARKA İŞLEMİ
                    string mevcut = elimizdekimetod(txt_mvctmrk.Text);



                    // MOTOR KODU VİRGÜLLÜ YAZDIRMA
                    string motoyaz = "";
                    if (txt_motorkod.Text == "")
                    {
                        motoyaz = "";
                    }
                    else motoyaz =
                    "<tr>\n" +
                    "<td class=\"\"><span style=\"font-weight: bold;\">Motor Kodu</span></td>\n" +
                    "<td class=\"\">:" + " " + txt_motorkod.Text + " " + "</td>\n" +
                    "</tr>\n";





                    // UYUMLU MODELLER İŞLEMİ
                    string sonyil = uyumlumodelmetod(modelyili);






                    // eğer arasıysa model yılı
                    string uyumum = yazmodelimetod(modelyili, sonyil);



                    string kelimeeki;
                    if (sonyil.Contains("Öncesi"))
                    {
                        kelimeeki = "nde";
                    }
                    else
                    {
                        kelimeeki = "nda";
                    }



                    




                    // YAZDIRMA İŞLEMLERİ:





                    // POLEN FİLTRESİ İŞLEMİ
                    if (txt_baslik.Text.Contains("Polen"))
                    {
                        string metin =
                    "<h2><span style=\"color: #002892;\">" + anabaslik + "</span></h2>\n" +
                    "<div>\n" +
                    "<table style=\"border-collapse: collapse;\">\n" +
                    "<tbody>\n" +
                    "<tr>\n" +
                    "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                    "<td>: " + aracmarkamodel + "</td>\n" +
                    "</tr>\n" +
                    "<tr>\n" +
                    "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                    "<td>: " + sonyil + "</td>\n" +
                    "</tr>\n" +
                    "<tr>\n" +
                    "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                    "<td>:" + " " + motortipi + "</td>\n" +
                    "</tr>\n" +
                    "<tr>\n" +
                    "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                    "<td>:" + " " + kwwhpp + "</td>\n" +
                    "</tr>\n" +
                    motoyaz +
                    "<tr>\n" +
                    "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                    "<td class=\"\">:" + " " + fltrmarka + "</td>\n" +
                    "</tr>\n" +
                    "</tbody>\n" +
                    "</table>\n" +
                    "</div>\n" +
                    "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + fltrmarka + " marka olup " + aracmarkamodel + " " + motortipi + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + aracmarkamodel + " " + motortipi + " araçlara uyumlu polen filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                    "<ul>\n" +
                    "<li>" + markayazısı + "</li>\n" +
                    "<li>" + aracmarkamodel + " polen filtresi için " + mevcut + "</li>\n" +
                    "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                    "</ul>\n" +
                    "<div></div>\n" +
                    "<br /><span style=\"font-weight: bold;\">" + aracmarkamodel + " Polen Filtresi Ne İşe Yarar ?</span><br />\n" +
                    "<ul>\n" +
                    "<li>Kabin içerisine girecek havayı temizler.</li>\n" +
                    "<li>Dışarıdan aldığı havayı filtreleyerek araç içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                    "<li>Kalorifer ve klima sisteminin daha kuvvetli üflemesini sağlar.</li>\n" +
                    "<li>Araç içirisinde oluşabilecek tozlanmayı engeller.</li>\n" +
                    "</ul>\n" +
                    "<div></div>\n" +
                    "<div></div>\n" +
                    "<span style=\"font-weight: bold;\">" + aracmarkamodel + " Polen Filtresi Faydaları</span><br />\n" +
                    "<ul>\n" +
                    "<li>Klima ve kalorifer sisteminin daha temiz ve verimli çalışmasını sağlar.</li>\n" +
                    "<li>Araç içi temiz havalandırma sağlar.</li>\n" +
                    "<li>Araç içerisinde oluşabilecek kötü kokuları engeller.</li>\n" +
                    "</ul>\n" +
                    "<div> </div>\n" +
                    "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        rch_text.Text = metin;


                        txt_acıklama.Text = basl[0] + " / " + aramarkamodel(txt_baslik.Text) + " / " + motortipi + " / " + sonyil + " / " + kwwhpp + " / " + "Polen Filtresi / Çeşitli Marka ve Ödeme Seçenekleri ile Periyodikbakimci.com'da";

                        lbl_snc.Text = "Polen Filtresi: " + fltrmarka.ToUpper();
                        lbl_snc.Visible = true;
                    }

                    // HAVA FİLTRESİ İŞLEMİ
                    else if (txt_baslik.Text.Contains("Hava"))
                    {

                        string metin =
                        "<h2><span style=\"color: #002892;\">" + anabaslik + "</span></h2>\n" +
                        "<div>\n" +
                        "<table style=\"border-collapse: collapse;\">\n" +
                        "<tbody>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                        "<td>: " + aracmarkamodel + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                        "<td>: " + sonyil + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                        "<td>: " + " " + motortipi + "</td>\n" +
                        "</tr>\n" +
                        "<tr>\n" +
                        "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                        "<td>:" + " " + kwwhpp + "</td>\n" +
                        "</tr>\n" +
                        motoyaz +
                        "<tr>\n" +
                        "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                        "<td class=\"\">: " + fltrmarka + "</td>\n" +
                        "</tr>\n" +
                        "</tbody>\n" +
                        "</table>\n" +
                        "</div>\n" +
                        "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + fltrmarka + " marka olup " + aracmarkamodel + " " + motortipi + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + aracmarkamodel + " " + motortipi + " araçlara uyumlu hava filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                        "<ul>\n" +
                        "<li>" + markayazısı + "</li>\n" +
                        "<li>" + aracmarkamodel + " hava filtresi için " + mevcut + "</li>\n" +
                        "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                        "</ul>\n" +
                        "<div></div>\n" +
                        "<br /><span style=\"font-weight: bold;\">" + aracmarkamodel + " Hava Filtresi Ne İşe Yarar ?</span><br />\n" +
                        "<ul>\n" +
                        "<li>Yakıtın tepkimeye girebilmesi için gerekli havayı süzer.</li>\n" +
                        "<li>Dışarıdan aldığı havayı filtreleyerek motor içerisine daha temiz hava dağıtımını sağlar.</li>\n" +
                        "<li>Yanma odasına temiz hava göndererek yakıtın daha kolay tepkimeye girmesini sağlar.</li>\n" +
                        "<li>Yakıtın çiğ atılmasını engeller.</li>\n" +
                        "</ul>\n" +
                        "<div></div>\n" +
                        "<div></div>\n" +
                        "<span style=\"font-weight: bold;\">" + aracmarkamodel + " Hava Filtresi Faydaları</span><br />\n" +
                        "<ul>\n" +
                        "<li>Düzenli hava karışımı yakıt tasarrufu sağlar.</li>\n" +
                        "<li>Motorun daha sessiz ve gürültüsüz çalışmasını sağlar.</li>\n" +
                        "<li>Araç performansını ve çekişini arttırır.</li>\n" +
                        "</ul>\n" +
                        "<div> </div>\n" +
                        "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        rch_text.Text = metin;



                        txt_acıklama.Text = basl[0] + " / " + aramarkamodel(txt_baslik.Text) + " / " + motortipi + " / " + sonyil + " / " + kwwhpp + " / " + "Hava Filtresi / Çeşitli Marka ve Ödeme Seçenekleri ile Periyodikbakimci.com'da";


                        lbl_snc.Text = "Hava Filtresi: " + fltrmarka.ToUpper();
                        lbl_snc.Visible = true;
                    }

                    // YAĞ FİLTRESİ İŞLEMİ
                    else if (txt_baslik.Text.Contains("Yağ"))
                    {

                        string metin =
                            "<h2><span style=\"color: #002892;\">" + anabaslik + "</span></h2>\n" +
                            "<div>\n" +
                            "<table style=\"border-collapse: collapse;\">\n" +
                            "<tbody>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                            "<td>: " + aracmarkamodel + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                            "<td>: " + sonyil + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                            "<td>:" + " " + motortipi + "</td>\n" +
                            "</tr>\n" +
                            "<tr>\n" +
                            "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                            "<td>:" + " " + kwwhpp + "</td>\n" +
                            "</tr>\n" +
                            motoyaz +
                            "<tr>\n" +
                            "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                            "<td class=\"\">: " + fltrmarka + "</td>\n" +
                            "</tr>\n" +
                            "</tbody>\n" +
                            "</table>\n" +
                            "</div>\n" +
                            "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + fltrmarka + " marka olup " + aracmarkamodel + " " + motortipi + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + aracmarkamodel + " " + motortipi + " araçlara uyumlu yağ filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                            "<ul>\n" +
                            "<li>" + markayazısı + "</li>\n" +
                            "<li>" + aracmarkamodel + " yağ filtresi için " + mevcut + "</li>\n" +
                            "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<br /><span style=\"font-weight: bold;\">" + aracmarkamodel + " Yağ Filtresi Ne İşe Yarar ?</span><br />\n" +
                            "<ul>\n" +
                            "<li>Otomobil motorları ağırlıklı olarak metal (piston-krank-gömlek vb.) parçalardan oluşur. Hepsi bir biriyle bağlantılı çalıştığı için sürtünme oluşur.</li>\n" +
                            "<li>Bu sürtünmeyi azaltmak ve en aza indirmek için motor yağı kullanılır. Sürtünme ne olursa olsun devam ettiği için aşınan metal parçalar, demir tozları oluşur.</li>\n" +
                            "<li>Metal parçaları ve tozları devridaim sırasında yağ filtresinden geçerek  yağın daha temiz motora ulaşmasını sağlar .</li>\n" +
                            "<li>Yağ filtresini periyodik bakımlarınızda değiştiriniz.</li>\n" +
                            "<li>Yağ filtrelerinin içerisinde bulunan kağıt Artık yağı süzemeyecek duruma geldiği zaman süzemediği parçacıkları ve demir tozlarını motorun içerisine göndermeye başlayacak ve motor içerisinde bulunan yedek parçaları daha fazla aşındırma yapacaktır.</li>\n" +
                            "</ul>\n" +
                            "<div></div>\n" +
                            "<div></div>\n" +
                            "<span style=\"font-weight: bold;\">" + aracmarkamodel + " Yağ Filtresi Faydaları</span><br />\n" +
                            "<ul>\n" +
                            "<li>Motor aşınmasını en aza indirir</li>\n" +
                            "<li>Motor içindeki yağın daha temiz dolaşımını sağlar.</li>\n" +
                            "<li>Motor ömrünü uzatır.</li>\n" +
                            "<li>Motor performansını artırır.</li>\n" +
                            "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar. </li>\n" +
                            "</ul>\n" +
                            "<div> </div>\n" +
                            "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        rch_text.Text = metin;

                        txt_acıklama.Text = basl[0] + " / " + aramarkamodel(txt_baslik.Text) + " / " + motortipi + " / " + sonyil + " / " + kwwhpp + " / " + "Yağ Filtresi / Çeşitli Marka ve Ödeme Seçenekleri ile Periyodikbakimci.com'da";

                        lbl_snc.Text = "Yağ Filtresi: " + fltrmarka.ToUpper();
                        lbl_snc.Visible = true;


                    }

                    // YAKIT FİLTRESİ İŞLEMİ
                    else if (txt_baslik.Text.Contains("Yakıt"))
                    {
                        string metin =
                   "<h2><span style=\"color: #002892;\">" + anabaslik + "</span></h2>\n" +
                   "<div>\n" +
                   "<table style=\"border-collapse: collapse;\">\n" +
                   "<tbody>\n" +
                   "<tr>\n" +
                   "<td><span style=\"font-weight: bold;\">Uyumlu Araç                   </span><span style=\"font-weight: bold;\"><br /></span></td>\n" +
                   "<td>: " + aracmarkamodel + "</td>\n" +
                   "</tr>\n" +
                   "<tr>\n" +
                   "<td><span style=\"font-weight: bold;\">Uyumlu Modeller     </span></td>\n" +
                   "<td>: " + sonyil + "</td>\n" +
                   "</tr>\n" +
                   "<tr>\n" +
                   "<td><span style=\"font-weight: bold;\">Motor Tipi <br /></span></td>\n" +
                   "<td>:" + " " + motortipi + "</td>\n" +
                   "</tr>\n" +
                   "<tr>\n" +
                   "<td><span style=\"font-weight: bold;\">Motor Gücü <br /></span></td>\n" +
                   "<td>:" + " " + kwwhpp + "</td>\n" +
                   "</tr>\n" +
                   motoyaz +
                   "<tr>\n" +
                   "<td class=\"\"><span style=\"font-weight: bold;\">Ürün Markası</span></td>\n" +
                   "<td class=\"\">: " + fltrmarka + "</td>\n" +
                   "</tr>\n" +
                   "</tbody>\n" +
                   "</table>\n" +
                   "</div>\n" +
                   "<br /><br /><span style=\"font-size: 10pt;\"><span style=\"font-weight: bold; font-size: 10pt;\">Ürünümüz " + fltrmarka + " marka olup " + aracmarkamodel + " " + motortipi + " motor, " + sonbeygir + " beygir , <span style=\"color: #ff0000;\">" + sonyil + kelimeeki + " </span>üretilen, <span style=\"color: #000000;\">" + aracmarkamodel + " " + motortipi + " araçlara uyumlu yakıt filtresidir. </span></span><span style=\"font-weight: bold;\"><br /></span><br /><br /><span style=\"font-weight: bold;\">Notlar</span><br /></span></span>\n" +
                   "<ul>\n" +
                   "<li>" + markayazısı + "</li>\n" +
                   "<li>" + aracmarkamodel + " yakıt filtresi için " + mevcut + "</li>\n" +
                   "<li>Sipariş verdikten sonra müşteri temsilcimiz doğru ürünlerin teyidi için sizinle irtibata geçecektir.</li>\n" +
                   "</ul>\n" +
                   "<div></div>\n" +
                   "<br /><span style=\"font-weight: bold;\">" + aracmarkamodel + " Yakıt Filtresi Ne İşe Yarar ?</span><br />\n" +
                   "<ul>\n" +
                   "<li>Zamanla yakıt içerisinde oluşabilecek katı partikülleri süzmeye yarar.</li>\n" +
                   "<li>Enjeksiyon sistemine temiz yakıt gelmesini sağlar.</li>\n" +
                   "<li>Araç motorunun daha düzenli çalışmasını sağlar.</li>\n" +
                   "<li>Yanma odasındaki yakıtın tepkimeye girmesini kolaylaştırır.</li>\n" +
                   "</ul>\n" +
                   "<div></div>\n" +
                   "<div></div>\n" +
                   "<span style=\"font-weight: bold;\">" + aracmarkamodel + " Yakıt Filtresi Faydaları</span><br />\n" +
                   "<ul>\n" +
                   "<li>Araç çekiş ve performansını arttırır.</li>\n" +
                   "<li>Yakıt sisteminde bulunan yedek parça ömrünü uzatır.</li>\n" +
                   "<li>Aracın rolanti dengesini sağlar.</li>\n" +
                   "<li>Aracın rahat çalışmasını sağlar.</li>\n" +
                   "<li>Aracın gürültüsüz ve sessiz çalışmasını sağlar.</li>\n" +
                   "</ul>\n" +
                   "<div> </div>\n" +
                   "<div style=\"text-align: center;\"><img src=\"/class/INNOVAEditor/assets/logo.png\" alt=\"logo\" style=\"margin: 0px;\" border=\"0\" /> </div>";

                        rch_text.Text = metin;

                        txt_acıklama.Text = basl[0] + " / " + aramarkamodel(txt_baslik.Text) + " / " + motortipi + " / " + sonyil + " / " + kwwhpp + " / " + "Yakıt Filtresi / Çeşitli Marka ve Ödeme Seçenekleri ile Periyodikbakimci.com'da";


                        lbl_snc.Text = "Yakıt Filtresi: " + fltrmarka.ToUpper();
                        lbl_snc.Visible = true;
                        
                    }

                }
                else MessageBox.Show("Elinizdeki Mevcut Markaları Giriniz");
            }
            else MessageBox.Show("Araç Başlığı Giriniz");
        }




        private void prydkclosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PeriyodikCode_Load(object sender, EventArgs e)
        {
        }

    }
}
