namespace ConsoleApp2
{
    internal class Program
    {
        //class Hesabla     //Compile-time Polymorphism (Statik Polimorfizm) — Metod overload (aşırı yükləmə)
        //{
        //    public int topla(int x, int y) 
        //    {
        //        return x + y;
        //    }
        //    public int topla(int x,int y, int z)
        //    { return x + y + z; }
        //}
        //static void Main(string[] args)
        //{
        //    Hesabla h = new Hesabla();
        //    Console.WriteLine(h.topla(155,444));
        //    Console.WriteLine(h.topla(-122,3333,4444));

        //}
        //class Heyvan //Runtime Polymorphism(Dinamik Polimorfizm) — Virtual metodlar və override
        //{
        //    public virtual void Sescixar()
        //    {
        //        Console.WriteLine("Heyvan ses cixarir.");
        //    }
        //}
        //class It : Heyvan
        //{
        //    public override void Sescixar() 
        //    {
        //        Console.WriteLine("It:Hav-hav!!");
        //    }
        //}
        //class Pisik : Heyvan
        //{
        //    public override void Sescixar()
        //    {
        //        Console.WriteLine("Pisik:miyavvvv");
        //    }
        //}
        //static void Main()
        //{
        //    Heyvan heyvan1 = new It();
        //    Heyvan heyvan2 = new Pisik();

        //    heyvan1.Sescixar();
        //    heyvan2.Sescixar();

        //}

        //class Yazdir
        //{
        //    public void MesajYaz()
        //    {
        //        Console.WriteLine("Salam Dunya");
        //    }
        //    public void MesajYaz(string mesaj)
        //    {
        //        Console.WriteLine(mesaj);
        //    }
        //    public void MesajYaz(string mesaj,int say)
        //    {
        //        Console.WriteLine($"{ say}defe: { mesaj}");
        //    }
        //}
        //static void Main()
        //{
        //    Yazdir yazdir = new Yazdir();

        //    yazdir.MesajYaz();
        //    yazdir.MesajYaz("Necesen");
        //    yazdir.MesajYaz("Xos geldin",3);
        //}
        //class Heyvan
        //{
        //    public virtual void SesCixar()
        //    {
        //        Console.WriteLine("Heyvan ses cixarir.");
        //    }
        //    class It : Heyvan 
        //    {
        //        public override void SesCixar() 
        //        {
        //            Console.WriteLine("It:Hav-hav");
        //        }
        //    }
        //    class Pisik : Heyvan
        //    {
        //        public override void SesCixar()
        //        {
        //            Console.WriteLine("Pisik:miyav miyavv!!");
        //        }
        //    }
        //    class At : Heyvan
        //    {
        //        public override void SesCixar()
        //        {
        //            Console.WriteLine("At:Ihhaa!!");
        //        }
        //    }
        //    static void Main()
        //    {
        //        Heyvan heyvan1 = new It();
        //        Heyvan heyvan2 = new Pisik();
        //        Heyvan heyvan3 = new At();
        //        heyvan1.SesCixar();
        //        heyvan2.SesCixar();
        //        heyvan3.SesCixar();
        //    }
        //}
        //class Sekil
        //{
        //    public virtual void Ciz()
        //    {
        //        Console.WriteLine("Fiqurlar cizilsin.");
        //    }
        //}
        //class Daire : Sekil
        //{
        //    public override void Ciz() 
        //    {
        //        Console.WriteLine("Daire cizildi");
        //    }
        //}
        //class Kvadrat : Sekil
        //{
        //    public override void Ciz()
        //    {
        //        Console.WriteLine("Kvadrat cizildi");
        //    }
        //}
        //class Ucbucaq: Sekil
        //{
        //    public override void Ciz()
        //    {
        //        Console.WriteLine("Ucbucaq cizildi");
        //    }
        //}
        //static void Main()
        //{
        //    Sekil daire = new Daire();
        //    daire.Ciz();
        //    Sekil kvadrat = new Kvadrat();
        //    kvadrat.Ciz();
        //    Sekil ucbucaq = new Ucbucaq();
        //    ucbucaq.Ciz();

        //}
        //class Transport
        //{
        //    public virtual void HərəkətEt()
        //    {
        //        Console.WriteLine();
        //    }
        //    class Avtomobil : Transport
        //    {
        //        public override void HərəkətEt()
        //        {
        //            Console.WriteLine("Avtomobil yolda hərəkət edir");
        //        }
        //    }
        //    class Qatar : Transport
        //    {
        //        public override void HərəkətEt()
        //        {
        //            Console.WriteLine("Qatar rels üzərində hərəkət edir");
        //        }
        //    }
        //    class Təyyarə : Transport
        //    {
        //        public override void HərəkətEt()
        //        {
        //            Console.WriteLine("Təyyarə havada hərəkət edir");
        //        }
        //    }
        //    static void Main()
        //    {
        //        List<Transport> vasiteler = new List<Transport>
        //        {
        //            new Avtomobil(),
        //            new Qatar(),
        //            new Təyyarə()
        //        };

        //        foreach (Transport vasite in vasiteler) 
        //        {
        //            vasite.HərəkətEt();
        //        }
        //    }
        //}
        //class Hesabla
        //{
        //    public int Topla(int a, int b)
        //    {
        //        return a + b;
        //    }
        //    public int Topla(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }
        //    public double Topla(double a, double b)
        //    {
        //        return a + b;
        //    }
        //    public string Topla(string a, string b) 
        //    {
        //        return a + b;
        //    }
        //}
        //static void Main()
        //{
        //    Hesabla h = new Hesabla();

        //    Console.WriteLine(h.Topla(3,5));
        //    Console.WriteLine(h.Topla(1,2,3));
        //    Console.WriteLine(h.Topla(2.5, 4.5));
        //    Console.WriteLine(h.Topla("12", "34"));

        //}
        //class Shexs
        //{
        //    private string ad;
        //    private int yas;

        //    public string Ad
        //    {
        //        get { return ad; }
        //        set { ad = value; }
        //    }
        //    public int Yas
        //    {
        //        get { return yas; }
        //        set 
        //        {
        //            if (value >=0 &&  value <= 150)
        //            {
        //                yas= value;
        //            }
        //            else 
        //            {
        //                Console.WriteLine("Yas 0 ile 150 arasinda olmalidir!");
        //            }
        //        }
        //    }
        //}

        //static void Main()
        //{
        //    Shexs s= new Shexs();
        //    s.Ad = "Taleh";
        //    s.Yas = 23;
        //    Console.WriteLine($"Ad: {s.Ad}");
        //    Console.WriteLine($"Yas: {s.Yas}");
        //    s.Yas = -5;   
        //    s.Yas = 200;
        //}
        //abstract class Vehicle
        //{
        //    protected string Brand;
        //    protected string Model;

        //    public Vehicle(string brand,string model) 
        //    {
        //        Brand = brand;
        //        Model = model;
        //    }
        //    public virtual void ShowInfo()
        //    {
        //        Console.WriteLine($"Vehicle Info :{Brand} {Model}");
        //    }
        //    public abstract void Drive();
        //}
        //class Car : Vehicle
        //{
        //    public Car (string brand,string model) : base(brand,model) { }
        //    public override void Drive() 
        //    {
        //        Console.WriteLine("Driving the car on the highway...");
        //    }
        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine($"Car Info: {Brand} {Model}");
        //    }
        //}
        //class Bike : Vehicle
        //{
        //    public Bike (string brand, string model) : base(brand,model)
        //    {

        //    }
        //    public override void Drive() 
        //    {
        //        Console.WriteLine("Riding the bike on a mountain trail...");
        //    }
        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine($"Bike Info: {Brand} {Model}");
        //    }
        //}


        //    static void Main(string[]arg) 
        //    {
        //        Car car = new Car("BMW", "M5");
        //        Bike bike = new Bike("Yamaha", "R6");

        //        car.ShowInfo();
        //        car.Drive();

        //        Console.WriteLine();
        //        bike.ShowInfo();
        //        bike.Drive();
        //        Console.WriteLine();

        //    }
        //abstract class PaymentMethod
        //{
        //    protected string CustomerName;
        //    protected decimal Amount;

        //    public PaymentMethod(string customerName, decimal amount)
        //    {
        //        CustomerName = customerName;
        //        Amount = amount;
        //    }

        //    public virtual void ShowInfo()
        //    {
        //        Console.WriteLine($"Ad: {CustomerName}, Mebleg: {Amount}");
        //    }

        //    public abstract void Pay();
        //}

        // Kredit kartı ödənişi
        //class CreditCardPayment : PaymentMethod
        //{
        //    public CreditCardPayment(string customerName, decimal amount)
        //        : base(customerName, amount)
        //    {
        //    }

        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine("Credit card:");
        //        base.ShowInfo();
        //    }

        //    public override void Pay()
        //    {
        //        Console.WriteLine("Credit karti emal olunur...");
        //    }
        //}

        //// Nağd ödəniş
        //class CashPayment : PaymentMethod
        //{
        //    public CashPayment(string customerName, decimal amount)
        //        : base(customerName, amount)
        //    {
        //    }

        //    public override void ShowInfo()
        //    {
        //        Console.WriteLine("Nağd ödəniş:");
        //        base.ShowInfo();
        //    }

        //    public override void Pay()
        //    {
        //        Console.WriteLine("Nağd ödəniş olunur...");
        //    }
        //}


        //    static void Main(string[] args)
        //    {
        //        PaymentMethod payment1 = new CreditCardPayment("Ali", 150);
        //        payment1.ShowInfo();
        //        payment1.Pay();

        //        Console.WriteLine();

        //        PaymentMethod payment2 = new CashPayment("Aysel", 80);
        //        payment2.ShowInfo();
        //        payment2.Pay();

        //        Console.ReadLine();
        //    }

        //class BankAccount
        //{
        //    private string accountnumber;
        //    private decimal balance;

        //    public BankAccount(string accountNumber)
        //    {
        //        accountnumber = accountNumber; // düzəldildi
        //        balance = 0;
        //    }

        //    public string AccountNumber
        //    {
        //        get { return accountnumber; }
        //    }

        //    public decimal Balance
        //    {
        //        get { return balance; }
        //    }

        //    public void Deposit(decimal amount)
        //    {
        //        if (amount <= 0)
        //        {
        //            Console.WriteLine("Amount menfi və ya sıfır ola bilməz!");
        //            return;
        //        }

        //        balance += amount;
        //        Console.WriteLine($"{amount} AZN yatırıldı. Yeni balans: {balance} AZN");
        //    }

        //    public void Withdraw(decimal amount)
        //    {
        //        if (amount <= 0)
        //        {
        //            Console.WriteLine("Çıxarılan məbləğ sıfırdan böyük olmalıdır!");
        //            return;
        //        }

        //        if (amount > balance)
        //        {
        //            Console.WriteLine("Kifayət qədər vəsait yoxdur!");
        //            return;
        //        }

        //        balance -= amount;
        //        Console.WriteLine($"{amount} AZN çıxarıldı. Yeni balans: {balance} AZN");
        //    }

        //    static void Main(string[] args)
        //    {
        //        BankAccount myAccount = new BankAccount("AZ123456789");

        //        Console.WriteLine($"Hesab nömrəsi: {myAccount.AccountNumber}");
        //        Console.WriteLine($"İlkin balans: {myAccount.Balance} AZN");

        //        myAccount.Deposit(150);
        //        myAccount.Withdraw(50);
        //        myAccount.Withdraw(200); // kifayət qədər vəsait yoxdur

        //        Console.ReadLine();
        //    }
        //public class Calculator
        //{
        //    public int Add(int a, int b)
        //    {
        //        return a + b;
        //    }
        //    public double Add(double a, double b)
        //    {
        //        return a + b;
        //    }
        //    public int Add(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Calculator calculator = new Calculator();
        //    int result1 = calculator.Add(1, 2);
        //    double result2 = calculator.Add(2.5, 3.5);
        //    int result3 = calculator.Add(3, 4, 5);
        //    Console.WriteLine(result1);

        //    Console.WriteLine(result2);

        //    Console.WriteLine(result3);

        //    Console.WriteLine();
        //}


        //public class Point
        //{
        //    public int X, Y;

        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }

        //    // + operatorunun overload edilməsi
        //    public static Point operator +(Point p1, Point p2)
        //    {
        //        return new Point(p1.X + p2.X, p1.Y + p2.Y);
        //    }

        //    // Nəticəni rahat çap etmək üçün ToString metodu
        //    public override string ToString()
        //    {
        //        return $"({X}, {Y})";
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    Point p1 = new Point(2, 3);
        //    Point p2 = new Point(4, 5);

        //    Point result = p1 + p2;  // operator + istifadə olunur

        //    Console.WriteLine("Nəticə: " + result);  // Ekranda: (6, 8)

        //    Console.ReadLine(); // Konsolun açıq qalması üçün
        //}
        //public class MathOperations
        //{
        //    public int Add(int a,int b)
        //    {
        //        return a + b;
        //    }
        //    public int Add(int a, int b,int c) 
        //    {
        //        return a + b + c;
        //    }
        //    public double Add(double a, double b)
        //    { 
        //        return a + b; 
        //    }

        //}
        //static void Main(string[] args)
        //{
        //    MathOperations mathOperations = new MathOperations();
        //    int result1 = mathOperations.Add(1,2);
        //    int result2 = mathOperations.Add(2,3);  
        //    double result3 = mathOperations.Add(3,4);
        //    Console.WriteLine("Result1:"+result1);
        //    Console.WriteLine("Result2:"+result2);
        //    Console.WriteLine("Result3:"+result3);

        //}
        //public class Box
        //    {
        //    public double Length { get; set; }
        //    public double Width {  get; set; }
        //    public double Height { get; set; }
        //    public Box(double length, double width, double height) 
        //    {
        //        Length = length;
        //        Width = width;
        //        Height = height;
        //    }
        //    public static Box operator +(Box b1, Box b2)
        //    {
        //        return new Box(
        //            b1.Length + b2.Length,
        //            b1.Width + b2.Width,
        //            b1.Height + b2.Height
        //            );
        //    }
        //    public override string ToString() 
        //    {
        //        return $"Length = {Length}, Width={Width}, Height ={Height}";
        //    }
        //    static void Main(string[] args)
        //    {
        //        Box box1=new Box(1, 2, 3);
        //        Box box2=new Box(2, 3, 4);

        //        Box result = box1 + box2;

        //        Console.WriteLine("Box 1: " + box1);
        //        Console.WriteLine("Box 2: " + box2);
        //        Console.WriteLine("Result: " + result);

        //        Console.ReadLine();
        //    }
        //    }
        //class Animal
        //{
        //    public virtual void MakeSound()
        //    {
        //        Console.WriteLine("Animal speaks");
        //    }
        //    class Dog : Animal
        //    {
        //        public override void MakeSound() 
        //        {
        //            Console.WriteLine("Dog barks");
        //        }
        //    }
        //    class Cat : Animal 
        //    {
        //        public override void MakeSound() 
        //        {
        //            Console.WriteLine("Cat meows");
        //        }
        //    }
        //    class Cow : Animal
        //    {
        //        public override void MakeSound()
        //        {
        //            Console.WriteLine("Cow moos");   
        //        }
        //    }

        //    static void Main(string[] args) 
        //    {
        //        Animal[] animal = {new Dog(), new Cat(),new Cow()};
        //        foreach (var animals in animal) 
        //        {
        //          animals.MakeSound();

        //        }
        //    }
        //}
       

        

    }
}



