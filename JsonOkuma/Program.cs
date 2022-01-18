using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOkuma
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jsonOkunanData = File.ReadAllText("C:\\JsonIslemleri\\Personeller.json");
           List<XObject> data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<XObject>>(jsonOkunanData);
            for(int i = 0; i < data.Count;i++)
            {
                Console.WriteLine($"{i+1}. Kayıt : " + data[i]);
            }
            Console.ReadLine();
        }
    }
}
