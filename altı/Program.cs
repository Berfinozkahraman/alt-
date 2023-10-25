//using System;
//using System.ComponentModel.Design.Serialization;

//class Býtkýler
//{
//    public void Fotosentez()
//    {
//        Console.WriteLine("Bitkiler fotosentez yapar");
//    }
//}
//class Kaktusler: Býtkýler
//{
//    public void Radyasyon()
//    {
//        Console.WriteLine("Kaktüsler radyasyonu emer");
//    }
//}

//class Sukulent: Kaktusler
//{
//    public void Dýkensýz()
//    {
//        Console.WriteLine("Sukulentler dikensizdir");

//    }
//}

//interface I1
//{
//    void Method1();
//}
// interface I2
//{
//    void Method2();
//}

//class Cicekciler: I1, I2
//{
//    public void Method1()
//    {
//        Console.WriteLine("Çiçek Özelliði");
//    }

//    public void Method2()
//    {
//        Console.WriteLine("Diken Özelliði");

//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Býtkýler býtkýler1 = new Býtkýler();
//        býtkýler1.Fotosentez();

//        Kaktusler kaktusler1 = new Kaktusler();
//        kaktusler1.Radyasyon();
//        kaktusler1.Fotosentez();

//        Sukulent sukulent1 = new Sukulent();
//        sukulent1.Dýkensýz();

//        Cicekciler cicekciler1 = new Cicekciler();
//        cicekciler1.Method1();
//        cicekciler1.Method2();

//    }
//}

//Constructor (Yapýlandýrýcý) : Nesneye yeniden özellik kazandýrmak için kullanýlýr.
// Ýsimlendirmesi sýnýfla ayný olacak.
// Yapýlandýrýcý soyut bir kavram olamaz.
// Bir sýnýf içerisinde yalnýzca bir statik constructor tanýmlanabilir.
// Statik constructor belirttikten sonra herhangi bir sayýda constructor tanýmlanabilir.
// 5 tane constructor çeþidi vardýr.
// 1. (Varsayýlan) Default Constructor
// 2. Parametreli Constructor (En az bir parametreye sahip constructor alýr ürün ekleme yapýlabilir.)
// 3. Copy Constructor (Baþka bir nesneden bir özellik kopyalanarak kullanýlýr)
// 4. Private Constructor
// 5. Statik Constructor


// class XYZ
// {
//    .................
//    constructor
//        public Constructor_adý()
//    {
//        ................
//    }
// }
// ürün eklemede kullanýlabilir verilen eðitimlerde kullanýlabilir

//using System;
//namespace ParametreliConstructor
//{
//    class ABC
//    {
//        String name; // parametre
//        int id; // parametre

//        // this kýsmý const oluþturulan alan

//        ABC (string name, int id)
//        {
//            this.name = name;
//            this.id = id;

//        }

//        public static void Main()
//        {
//            ABC orn = new ABC("Berfin", 123);
//            Console.WriteLine("Kiþi adý = " + orn.name + "Kiþi ID = " + orn.id);
//        }
//    }
//}
// ürün adý ürünün rengi ürünün boyutu int ürünün fiyatý float 
//using System;
//namespace ParametreliConstructor
//{
//    class ABC
//    {
//        String urunadi;
//        String urunrengi;
//        int urunboyutu;
//        float urununfiyati;

//        ABC(String urunadi, String urunrengi, int urunboyutu, float urununfiyati)
//        {
//            this.urunadi = urunadi;
//            this.urunrengi = urunrengi;
//            this.urunboyutu = urunboyutu;
//            this.urununfiyati = urununfiyati;
//        }

//        public static void Main()
//        {
//            ABC orn = new ABC("Ceket", "Siyah", 2, (float)860.45);
//            Console.WriteLine("Ürün adý =" + orn.urunadi + " Ürünün rengi =" + orn.urunrengi + "Ürünün Boyutu =" + orn.urunboyutu + "Ürünün fiyatý =" + orn.urununfiyati);
//        }
//    }
//}
// Copy Constructor ayný fiyata sahip ürünleri göstermek için kullanýlýr
// 2 tane nesne olmadan çalýþmaz
// Cimri.com örnek verilebilir


//using System;
//namespace CopyCons
//{
//    class XYZ
//    {
//        private String _month; // pratik bir yazým için _ kullanýlýr
//        private int _year;

//        public XYZ (XYZ s) // kopyalama iþini yapan þey s 
//        {
//            _month = s._month;
//            _year = s._year;
//        }
           
//        public XYZ (String _month,int _year)
//        {
//            this._month = _month;
//            this._year = _year;
//        }
            
//        public String Yazilanlar
//        {
//            get// okunabilir demek set hem okunabilir hem yazýlabilir
//            {
//                return "Ay:" + _month.ToString() + "\nYýl:" + _year.ToString();
//            }
       
//        }
//        public static void Main ()
//        {
//            XYZ nesne1 = new XYZ("Ocak", 2024);

//            XYZ nesne2 = new XYZ(nesne1);

//            Console.WriteLine(nesne2.Yazilanlar);
//        }
//    }
//}



