using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------WEEK -2-(13.08.2023)------------------------------//
            // About = Collections
            //**************************************************************************************//

            /* ArrayList a1 = new ArrayList();

            string str = "sadsadasdsadsa";          

            int x = 7;                                  //Standart diziler aynı veri tipindeki elemanları içermektedir.
            DateTime d = DateTime.Parse("8-oct-1995");  //Örneğin int tipinde oluşturduğumuz bir dizide sadece tam sayı tutabiliriz.
                                                        //Ancak ArrayList’de böyle bir kısıtlama bulunmamaktadır.
            a1.Add(str);                                //Farklı veri tipindeki öğeleri ArrayList’e ekleyebiliriz.
            a1.Add(d);
            a1.Add(x);

            foreach (object o in a1)
            {
                Console.WriteLine(o);
                Console.WriteLine("*************");
            }*/


            /*Hashtable ht = new Hashtable();     
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");         ///Hashtable koleksiyonunda ise Anahtar(Key) ve Değer(Value) olmak üzere iki kavram karşımıza çıkmakta.
            ht.Add("cs", "cs.net");         //Konuyu daha anlaşılır kılmak açısından; standart dizilere eklediğimiz elemanları "Değer",
            ht.Add("asp", "asp.net");       //o elemanlara erişmek için kullandığımız indeksleri de ""Anahtar"" olarak düşünebilirsiniz.

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " --> " + d.Value);
                Console.WriteLine("*********");
            }*/

            //-----------------------HASTABLE UYGULAMA---------------------//

            /*Hashtable Car = new Hashtable();
            //Car.Ad(anahtar,Değer)
            Car.Add("41 ABC 123", "Alfa Romeo");
            Car.Add("56 ABC 456", "Audi");
            Car.Add("25 ABC 789", "Mercedes-Benz");

            Console.WriteLine("Plaka Giriniz");
            string NumberPlate  = Console.ReadLine();

            if (Car.ContainsKey(NumberPlate)) 
            {
                Console.WriteLine(Car[NumberPlate]);
            }
            else
                Console.WriteLine("Araç Bulunamadı.");*/


            /*SortedList ht = new SortedList();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");                                 //Anahtar-Değer çiftleri ekrana, Anahtar(Key) 
            ht.Add("asp", "asp.net");                               //değerlerine göre sıralı bir şekilde yazılacaktır.
            //***** Kütüphane Listesi yapar iken kullanılabilir  
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " --> " + d.Value);
                Console.WriteLine("*********");
            }*/

            //-----------------------------SortedList Uygulama-----------------------------//
            /* SortedList SiraliKoleksiyon = new SortedList();
             // SiraliKoleksiyon.Add(Eklenecek_Anahtar,Eklenecek_Değer);
             SiraliKoleksiyon.Add(41, "Kocaeli");
             SiraliKoleksiyon.Add(54, "Adana");
             SiraliKoleksiyon.Add(25, "Erzurum");
             ICollection Anahtarlar = SiraliKoleksiyon.Keys;
             foreach (var Anahtar in Anahtarlar)
             Console.WriteLine("Anahtar:{0} - Değer:{1}", Anahtar, SiraliKoleksiyon[Anahtar]);*/

            Console.ReadLine(); 
        }
    }
}
