using Microsoft.VisualBasic;

namespace ConsoleApp5
{
    class Program
    {
        //public enum YemekNovu
        //{
        //    Baslangic,
        //    EsasYemek,
        //    Desert,
        //    Icki
        //}
        //public enum SifarisStatusu
        //{
        //    QebulEdildi,

        //    Hazirlanir,

        //    Hazirdir,

        //    Catdirildi,

        //    LegvEdildi
        //}
        //class Sifaris
        //{
        //    public string MusteriAdi { get; set; }
        //    public YemekNovu Novu { get; set; }
        //    public SifarisStatusu Status { get; set; }

        //    public Sifaris(string musteriadi, YemekNovu novu, SifarisStatusu status) 
        //    {
        //        MusteriAdi = musteriadi;
        //        Novu = novu;
        //        Status = Status;

        //    }
        //    public void StatusuDeyis(SifarisStatusu yeniStatus)
        //    {
        //        Status = yeniStatus;
        //    }
        //    public void MelumatYazdir()
        //    {
        //        Console.WriteLine($"Müştəri: {MusteriAdi}");
        //        Console.WriteLine($"Yemək növü: {Novu}");
        //        Console.WriteLine($"Status: {Status}");
        //        Console.WriteLine();
        //    }
        //}

        //    static void Main(string[] args)
        //{
        //    Sifaris sifaris1 = new Sifaris("Elvin", YemekNovu.EsasYemek, SifarisStatusu.Hazirlanir);
        //    Sifaris sifaris2 = new Sifaris("Aysel", YemekNovu.Desert, SifarisStatusu.Catdirildi);

        //    // Sifarişləri ekrana yazdır
        //    sifaris1.MelumatYazdir();
        //    sifaris2.MelumatYazdir();

        //    // Status dəyişdirək
        //    sifaris1.StatusuDeyis(SifarisStatusu.Hazirdir);
        //    Console.WriteLine("Elvin'in sifariş statusu dəyişdi:");
        //    sifaris1.MelumatYazdir();
        //}
        //public enum HesabNovu
        //{
        //    Cari,
        //    Depozit,
        //    Valyuta
        //}
        //public enum EmeliyyatNovu
        //{
        //    PulYatir,
        //    PulCek,
        //    BalansiGoster
        //}
        //class BankHesabi
        //{
        //    string SahibAdi { get; set; }

        //    HesabNovu Novu { get; set; }

        //    decimal Balans { get; set; }
        //    public BankHesabi(string sahibAdi, HesabNovu novu) 
        //    {
        //        SahibAdi = sahibAdi;
        //        Novu= novu;
        //        Balans = 0;
        //    }
        //    public void EmeliyyatEt(EmeliyyatNovu emeliyyat, decimal mebleg = 0)
        //    {
        //        switch(emeliyyat) 
        //        {
        //            case EmeliyyatNovu.PulYatir:
        //                Balans += mebleg;
        //                Console.WriteLine($"Musteri:{SahibAdi}");
        //                Console.WriteLine($"Balansa{mebleg}Azn elave olundu.Yeni balans:{Balans}Azn");
        //                break;
        //            case EmeliyyatNovu.PulCek:
        //                if (mebleg <= Balans)
        //                {
        //                    Balans -= mebleg;
        //                    Console.WriteLine($"Musteri:{SahibAdi}");
        //                    Console.WriteLine($"Balasdan{mebleg}Azn cixardildi.Yeni balans:{Balans}Azn");

        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Müştəri: {SahibAdi}");
        //                    Console.WriteLine($"Balans kifayət etmir! Mövcud balans: {Balans} AZN\n");
        //                }
        //                break;
        //            case EmeliyyatNovu.BalansiGoster:
        //                Console.WriteLine($"Müştəri: {SahibAdi}");
        //                Console.WriteLine($"Cari balans: {Balans} AZN\n");
        //                break;
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        BankHesabi hesab1 = new BankHesabi("Taleh", HesabNovu.Depozit);
        //        BankHesabi hesab2 = new BankHesabi("Valeh", HesabNovu.Cari);
        //        hesab1.EmeliyyatEt(EmeliyyatNovu.PulYatir, 500);
        //        hesab1.EmeliyyatEt(EmeliyyatNovu.PulCek, 200);
        //        hesab1.EmeliyyatEt(EmeliyyatNovu.BalansiGoster);

        //        hesab2.EmeliyyatEt(EmeliyyatNovu.PulYatir, 200);
        //        hesab2.EmeliyyatEt(EmeliyyatNovu.PulCek, 250); // kifayət etmir
        //        hesab2.EmeliyyatEt(EmeliyyatNovu.BalansiGoster);
        //    }
        //}
        //public static void Increment(ref int a,ref int b)
        //{
        //   int temp = a;
        //    a = b;
        //    b = temp;

        //}
        //static void Main(string[] args)
        //{
        //    int x = 100;
        //    int y = 200;
        //    Increment(ref x, ref y);
        //    Console.WriteLine($"x={x},y={y}");
        //}
        //public static void GetValues(out int a,out int b)
        //{
        //    a= 10; 
        //    b = 20;    
        //}
        //static void Main(string[] args)
        //{
        //    int x, y;
        //    GetValues(out x,out y);
        //    Console.WriteLine(x+" "+y);
        //}
        //static void Main()
        //{
        //    for (int i = 0; i < 10; i++)
        //        new Misal(i);
        //    Console.WriteLine("**********");
        //    GC.Collect();


        //    Console.Read();
        //}
        // class Misal
        //{
        //    int nomre;
        //    public Misal(int id)

        //    {
        //        nomre = id;
        //        Console.WriteLine(nomre +"Cisim yaradildi");
        //    }

        //    ~Misal() 
        //    {
        //        Console.WriteLine(nomre + "Cisim silindi.");
        //    }
        //}
        //public class CayStakani : IDisposable
        //{
        //    public CayStakani()
        //    {
        //        Console.WriteLine("Stəkan götürüldü, çay içilməyə hazırdır.");
        //    }

        //    public void Ic()
        //    {
        //        Console.WriteLine("Çay içilir...");
        //    }

        //    public void Dispose()
        //    {
        //        Console.WriteLine("Stəkan yuyuldu, iş bitdi.");
        //    }
        //    static void Main()
        //    {
        //        using (var cay = new CayStakani())
        //        {
        //            cay.Ic();
        //        }

        //        // Burda Dispose() avtomatik çağırılır
        //    }
        //}
        //public class TestObyekt
        //{
        //    public TestObyekt()
        //    {
        //        Console.WriteLine("Obyekt yaradıldı.");
        //    }

        //    ~TestObyekt()
        //    {
        //        Console.WriteLine("Obyekt silindi (GC tərəfindən).");
        //    }
        //}


        //    static void Main()
        //    {
        //        TestObyekt obyekt = new TestObyekt();

        //        obyekt = null;  // Obyekti əlçatanlıqdan çıxarırıq

        //        GC.Collect();   // CLR-in Garbage Collector-unu çağırırıq
        //        GC.WaitForPendingFinalizers();  // Destructor-un işləməsini gözləyirik

        //        Console.WriteLine("Proqram bitdi.");
        //    }
        //public static void Increment(ref int x)
        //{
        //    x++;
        //}

        //public static void Main(string[] args)
        //{
        //    int a = 5;
        //    Increment(ref a);
        //    Console.WriteLine(a); // nəticə: 6
        //}
        // public static void Increment(int x) 
        // {
        //     x++;
        // }    
        //static void Main(string[] args) 
        // {
        //     int a = 5;
        //     Increment(a);
        //     Console.WriteLine(a);
        // }
        //public static void GetValues(out int x, out int y,out int z )
        // {
        //     x = 10;
        //     y= 20;
        //     z= 30;
        // }
        // static void Main(string[] args) 
        // {
        //     int a, b;
        //     int c;
        //     GetValues(out a , out b, out c);
        //     Console.WriteLine(a);
        //     Console.WriteLine(b);
        //     Console.WriteLine(c);
        // }
        //enum Gunler
        // {
        //     Bazarertesi,
        //     CersenbeAxsami,
        //     Cersenbe,
        //     CumeAxsami,
        //     Cume,
        //     Senbe,
        //     Bazar
        //        }
        // static void Main(string[] args)
        // {
        //    Array values = Enum.GetValues(typeof(Gunler));
        //     foreach (var value in values) 
        //     {
        //         Console.WriteLine($"{value} = {(int)value}");
        //     }
        // }
        //public enum Status : byte 
        // {
        //   Pending=1,
        //   Approved=2,
        //   Rejected =3,

        // }
        // static void Main(string[] args)
        // {
        //     Status status = Status.Pending;
        //     Console.WriteLine(status);
        // }
        //public enum Priority
        // {
        //     Low=5,
        //     Medium,
        //     High,
        // }
        // static void Main(string[] args) 
        // {
        //     Priority priority = Priority.High;
        //     Console.WriteLine((int)priority);

        // }
        //enum Gunler 
        // {
        //     Bazar,
        //     Bazarertesi,
        //     CersenbeAxsami,
        //     Cersenbe,
        //     CumeAxsami,
        //     Cume,
        //     Senbe

        // }
        // static void Main(string[] args)
        // {
        //     Gunler gunler1 = (Gunler)Enum.Parse(typeof(Gunler), "Bazar");

        //     if (Enum.TryParse("Cume", out Gunler gunler2))
        //     {
        //         Console.WriteLine(gunler2);
        //     }
        // }
        //public enum Priority {  Low,Medium , High}
        //static void Main(string[] args) 

        // {
        //     Priority priority = Priority.High;
        //     priority = (Priority)100;
        //     Console.WriteLine(priority);
        // }

        //public record Person(string Name, string LastName);


        //static void Main(string[] args) 
        //{
        //    Person person = new Person("Taleh","Ibrahimli");
        //    Console.WriteLine(person.Name + "" +person.LastName);

        //}
        //record Person 
        //    {
        //        public string Name { get; init; }
        //        public int Age { get; init; }
        //    }
        //    static void Main(string[] args)
        //    {

        //        var person = new Person
        //        {
        //            Name = "Taleh",
        //            Age = 25
        //        };

        //        Console.WriteLine($"{person.Name},{person.Age}");

        //    }
        //static void Main(string[] args) 
        //    {
        //        Queue<string> queue = new Queue<string>();
        //        queue.Enqueue("Taleh");
        //        queue.Enqueue("Valeh");
        //        queue.Enqueue("Saleh");
        //        Console.WriteLine(queue.Dequeue());
        //        Console.WriteLine(queue.Dequeue());
        //    }
        //}
        //static void Main(string[] args) 
        //{
        //    Stack <string> stack = new Stack<string>();
        //    stack.Push("Aytac");
        //    stack.Push("Taleh");
        //    stack.Push("Valeh");
        //    Console.WriteLine(stack.Pop());
        //    Console.WriteLine(stack.Pop());
        //}
        //class Student
        //{
        //    public string Name;
        //    public int Age;

        //    public Student() : this("Namelum", 0)
        //    {
        //        Console.WriteLine("Bos constructor cagirildi");
        //    }
        //    public Student(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //        Console.WriteLine("Parametrlerle constructor cagirildi.");
        //    }
        //}
        //static void Main(string[] args) 
        //{
        //    Student student = new Student();
        //    Student student2 = new Student("Taleh",23);
        //    Console.WriteLine(student2.Name + " " + student2.Age);
        //}
        //public class Student
        //{
        //    public string Name;
        //    public int Age;

        //    public Student(string name, int age) 
        //    {

        //        Name = name;
        //        Age = age;
        //        Console.WriteLine("Paramert cagirildi");
        //    }
        //    public Student(string name , ) : this(name)
        //    {

        //        Console.WriteLine("Bos constuctor");
        //    }
        //}
        //static void Main(string[] args) 
        //{
        //    Student s = new Student();
        //    Stu
        //}
    }


}