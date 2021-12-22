using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQtoXML1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Ogrenci> ogrencilerim = new List<Ogrenci>();

            //for (int i = 0; i < 50; i++)
            //{

            //    Ogrenci temp = new Ogrenci();
            //    temp.id = Guid.NewGuid();
            //    temp.isim = FakeData.NameData.GetFirstName();
            //    temp.soyisim = FakeData.NameData.GetSurname();
            //    temp.numara = FakeData.NumberData.GetNumber(100, 500);
            //    ogrencilerim.Add(temp);
            //}

            //XDocument doc = new XDocument(

            //    new XDeclaration("1.0", "UTF-8", "yes"),
            //    new XElement("ogrencilerim",ogrencilerim.Select(
            //        i=>new XElement("ogrenci",
            //        new XElement("id",i.id),
            //        new XElement("isim",i.isim),
            //        new XElement("soyisim",i.soyisim),
            //        new XElement("numara",i.numara)
            //        )
            //        )
            //    )

            //);

            //doc.Save(@"C:\XML\FakeData.xml");



            XDocument dockOku = XDocument.Load(@"c:\XML\ornek.xml");
            List<XElement> okunanXelements = dockOku.Descendants("öğrenci").ToList();
            List<Ogrenci> okunanData = new List<Ogrenci>();

            foreach (XElement item in okunanXelements)
            {
                Ogrenci temp = new Ogrenci();
                temp.id = Guid.Parse(item.Element("id").Value);
                temp.isim = item.Element("isim").Value;
                temp.soyisim = item.Element("soyisim").Value;
                temp.numara = int.Parse(item.Element("numara").Value);
                okunanData.Add(temp);
            }


        }
    }
}
