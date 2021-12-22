using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQtoXML
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument XDoc = new XDocument(
                    new XDeclaration("1.0", "UTF-8", "yes"),
                    new XComment("Yorum satırı"),
                    new XElement("Personellerim",
                    new XElement("personel", new XAttribute("ID", "1"),
                    new XElement("isim", "Ahmet"),
                    new XElement("soyisim", "koç"),
                    new XElement("emailadres", "ahmetkoc@gmail.com")
                    ),
               
                    new XElement("personel", new XAttribute("ID", "2"),
                    new XElement("isim", "salih"),
                    new XElement("soyisim", "koç"),
                    new XElement("emailadres", "salihkoc@gmail.com")
                    )
                )

             );
            XDoc.Save(@"C:\XML\ornek.xml");

        }
    }
}
