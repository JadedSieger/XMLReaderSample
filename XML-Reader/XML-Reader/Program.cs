using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("./profiles.xml");

            XmlNodeList profiles = doc.GetElementsByTagName("profile");


            Console.WriteLine("Profile List:\n");

            foreach (XmlNode profile in profiles)
            {
                string name = profile["name"] != null ? profile["name"].InnerText : "";
                string age = profile["age"] != null ? profile["age"].InnerText : "";
                string address = profile["address"] != null ? profile["address"].InnerText : "";
                string email = profile["email"] != null ? profile["email"].InnerText : "";



                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Address: {0}", address);
                Console.WriteLine("Email: {0}", email);
                Console.WriteLine("-----------------------------------------------");
            }


            Console.Write("Press enter to exit");

            Console.ReadKey();
            
        }
    }
}
