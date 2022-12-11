using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace http
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wbcl = new WebClient();
            Application.DoEvents();
            string getir = wbcl.DownloadString(textBox2.Text);
            textBox1.Text = getir;
        }



        /*   HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://www.yoursite.com/resource/file.htm");

            using (StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream(), Encoding.UTF8))
            {
                streamWriter.Write(requestData);
            }

            string responseData = string.Empty;
            HttpWebResponse httpResponse = (HttpWebResponse)webRequest.GetResponse();
            using (StreamReader responseReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                responseData = responseReader.ReadToEnd();
            }

        /*void cozumle(string adres)
        {
            WebClient client = new WebClient();
            string htmlString = client.DownloadString(adres);

            HtmlAgilityPack.HtmlDocument htmlBelgesi = new HtmlAgilityPack.HtmlDocument();
            htmlBelgesi.OptionFixNestedTags = true;
            htmlBelgesi.LoadHtml(htmlString);
            HtmlAgilityPack.HtmlNodeCollection secilenler = htmlBelgesi.DocumentNode.SelectNodes("");
4
5
6
7
8
9        /*
          string adres = "https://listing-external-sit.hepsiburada.com/listings/merchantid/8539ad62-8148-4357-b5c1-4a7954db120a?offset=0&limit=2000&salable-listings=true";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenbilgiler.ReadToEnd();

            int baslikbaslangic = gelen.IndexOf("<title>") + 7;
            int baslikbitis = gelen.Substring(baslikbaslangic).IndexOf("</title>");
            string baslik = gelen.Substring(baslikbaslangic, baslikbitis);
            MessageBox.Show(baslik);*/
10
 
          /* void cozumle(string adres)
        {
            // Bir WebClient ile sayfanın tamamını string olarak al.
            WebClient client = new WebClient();
            string htmlString = client.DownloadString(adres);

            // htmlBelgesiument nesnesi oluştur.
            HtmlAgilityPack.HtmlDocument htmlBelgesi = new HtmlAgilityPack.HtmlDocument();

            // Etiket kapatma hatalarını düzeltsin.
            htmlBelgesi.OptionFixNestedTags = true;

            // Belgeyi çözümle
            htmlBelgesi.LoadHtml(htmlString);

            // id özellik değeri contract olan etiketin içindeki 6. img etiketinden sonra gelen ilk
            // metin düğümünü bul ve secilenler isimli koleksiyona ata.
            HtmlAgilityPack.HtmlNodeCollection secilenler = htmlBelgesi.DocumentNode.SelectNodes("(/p[@id='contract']//img)[6]/following-sibling::text()");

            if (secilenler != null) // Etiket bulabildiyse ... (Şarta uyan etiket bulunamadıysa null döndürüyor.)
            {
                // Aranan secilenler'in ilk elemanıdır. Bunun InnerText özellik değerini label1'in
                // Text özelliğine ata.
                label1.Text = secilenler[0].InnerText;
            }
        }
          */
        /*
         string adres = "https://www.google.com/";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler=new StreamReader(cevap.GetResponseStream());
            string gelen=donenbilgiler.ReadToEnd();

            int baslikbaslangic = gelen.IndexOf("<title>")+7;
            int baslikbitis = gelen.Substring(baslikbaslangic).IndexOf("</title>");
            string baslik=gelen.Substring(baslikbaslangic,baslikbitis);
            MessageBox.Show(baslik);*/
    }
}
