//using System;
//using System.ComponentModel.Design.Serialization;

//class B�tk�ler
//{
//    public void Fotosentez()
//    {
//        Console.WriteLine("Bitkiler fotosentez yapar");
//    }
//}
//class Kaktusler: B�tk�ler
//{
//    public void Radyasyon()
//    {
//        Console.WriteLine("Kakt�sler radyasyonu emer");
//    }
//}

//class Sukulent: Kaktusler
//{
//    public void D�kens�z()
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
//        Console.WriteLine("�i�ek �zelli�i");
//    }

//    public void Method2()
//    {
//        Console.WriteLine("Diken �zelli�i");

//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        B�tk�ler b�tk�ler1 = new B�tk�ler();
//        b�tk�ler1.Fotosentez();

//        Kaktusler kaktusler1 = new Kaktusler();
//        kaktusler1.Radyasyon();
//        kaktusler1.Fotosentez();

//        Sukulent sukulent1 = new Sukulent();
//        sukulent1.D�kens�z();

//        Cicekciler cicekciler1 = new Cicekciler();
//        cicekciler1.Method1();
//        cicekciler1.Method2();

//    }
//}

//Constructor (Yap�land�r�c�) : Nesneye yeniden �zellik kazand�rmak i�in kullan�l�r.
// �simlendirmesi s�n�fla ayn� olacak.
// Yap�land�r�c� soyut bir kavram olamaz.
// Bir s�n�f i�erisinde yaln�zca bir statik constructor tan�mlanabilir.
// Statik constructor belirttikten sonra herhangi bir say�da constructor tan�mlanabilir.
// 5 tane constructor �e�idi vard�r.
// 1. (Varsay�lan) Default Constructor
// 2. Parametreli Constructor (En az bir parametreye sahip constructor al�r �r�n ekleme yap�labilir.)
// 3. Copy Constructor (Ba�ka bir nesneden bir �zellik kopyalanarak kullan�l�r)
// 4. Private Constructor
// 5. Statik Constructor


// class XYZ
// {
//    .................
//    constructor
//        public Constructor_ad�()
//    {
//        ................
//    }
// }
// �r�n eklemede kullan�labilir verilen e�itimlerde kullan�labilir

//using System;
//namespace ParametreliConstructor
//{
//    class ABC
//    {
//        String name; // parametre
//        int id; // parametre

//        // this k�sm� const olu�turulan alan

//        ABC (string name, int id)
//        {
//            this.name = name;
//            this.id = id;

//        }

//        public static void Main()
//        {
//            ABC orn = new ABC("Berfin", 123);
//            Console.WriteLine("Ki�i ad� = " + orn.name + "Ki�i ID = " + orn.id);
//        }
//    }
//}
// �r�n ad� �r�n�n rengi �r�n�n boyutu int �r�n�n fiyat� float 
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
//            Console.WriteLine("�r�n ad� =" + orn.urunadi + " �r�n�n rengi =" + orn.urunrengi + "�r�n�n Boyutu =" + orn.urunboyutu + "�r�n�n fiyat� =" + orn.urununfiyati);
//        }
//    }
//}
// Copy Constructor ayn� fiyata sahip �r�nleri g�stermek i�in kullan�l�r
// 2 tane nesne olmadan �al��maz
// Cimri.com �rnek verilebilir


//using System;
//namespace CopyCons
//{
//    class XYZ
//    {
//        private String _month; // pratik bir yaz�m i�in _ kullan�l�r
//        private int _year;

//        public XYZ (XYZ s) // kopyalama i�ini yapan �ey s 
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
//            get// okunabilir demek set hem okunabilir hem yaz�labilir
//            {
//                return "Ay:" + _month.ToString() + "\nY�l:" + _year.ToString();
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



