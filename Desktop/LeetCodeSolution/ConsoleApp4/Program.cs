namespace ConsoleApp4
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //   Student student = new Student();

        //    student.SetName("Taleh");
        //    student.SetAge(23);
        //    Console.WriteLine("Ad:"+student.GetName());
        //    Console.WriteLine("Yas:"+student.GetAge());
        //}
        //class Student
        //{
        //    private string name;
        //    private int age;

        //    public void SetName(string name) 
        //    {
        //        this.name = name;
        //    } 
        //    public string GetName()
        //    { return this.name; }
        //    public void SetAge(int age)
        //    { 
        //        if(age > 0)
        //        this.age = age; 
        //    }
        //    public int GetAge() { return this.age;}
        //}
        //class Vehicle
        //{
        //    public void Move()
        //    {
        //        Console.WriteLine("Vehicle is moving");
        //    }
        //}
        //class Car : Vehicle
        //{

        //}
        //static void Main(string[] args) 
        //{
        //   Car car = new Car();
        //    car.Move();

        //}
        //class Animal
        //{
        //    public virtual void Speak() 
        //    {
        //        Console.WriteLine("Animal speaks");
        //    }
        //}
        //class Dog : Animal 
        //{
        //    public override void Speak() 
        //    {
        //        Console.WriteLine("Dog Barks");
        //    }
        //}
        //class Cat : Animal
        //{
        //    public override void Speak()
        //    {
        //        Console.WriteLine("Cat meows");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Animal animal = new Animal();
        //    Dog dog = new Dog();
        //    Cat cat = new Cat();
        //    animal.Speak();
        //    cat.Speak();
        //    dog.Speak();

        //}

        //abstract class Shape
        //{
        //    public abstract double GetArea();
        //}

        //class Rectangle : Shape
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }

        //    public Rectangle(double width, double height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public override double GetArea()
        //    {
        //        return Width * Height;
        //    }
        //    class Circle : Shape
        //    {
        //        public double Radius { get; set; }

        //        public Circle(double radius)
        //        {
        //            Radius = radius;
        //        }

        //        public override double GetArea()
        //        {
        //            return Math.PI * Radius * Radius;
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        Shape rect = new Rectangle(5, 10);
        //        Shape circle = new Circle(7);

        //        Console.WriteLine($"Düzbucaqlının sahəsi: {rect.GetArea()}");
        //        Console.WriteLine($"Dairənin sahəsi: {circle.GetArea()}");
        //    }

        //abstract class PaymentMethod
        //{
        //    public abstract void Pay(double amount);    

        //    class CashPayment : PaymentMethod 
        //    {
        //        public override void Pay(double amount)
        //        {
        //            Console.WriteLine($"Nagd odenis: {amount}");
        //            Console.WriteLine("Ödəniş nağd həyata keçirildi.");
        //        }
        //    }
        //    class CreditCardPayment : PaymentMethod
        //    {
        //        public override void Pay(double amount) 
        //        {
        //            Console.WriteLine($"credit karti odenis: {amount}");
        //            Console.WriteLine("Kredit kartı ilə ödəniş edildi.");
        //        }
        //    }
        //    class PayPalPayment : PaymentMethod
        //    {
        //        public override void Pay(double amount)
        //        {
        //            Console.WriteLine($"Paypal ile odenis: {amount}");
        //            Console.WriteLine("PayPal vasitəsilə ödəniş edildi.");
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        PaymentMethod cash = new CashPayment();
        //        PaymentMethod credit = new CreditCardPayment();
        //        PaymentMethod PayPal = new PayPalPayment();

        //        cash.Pay(40);
        //        credit.Pay(144);
        //        PayPal.Pay(134);
        //    }
        //
        //}
        //abstract class Animal
        //{
        //    public string Name { get; set; }
        //    public Animal(string name)
        //    {
        //        Name = name;
        //    }
        //    public abstract void MakeSound();
        //}


        //    class Dog : Animal
        //    {
        //    public Dog(string name) : base(name) { }
        //    public override void MakeSound()
        //        {
        //            Console.WriteLine($"{Name} deyir: Hav-hav");
        //        }
        //    }
        //    class Cat : Animal
        //    {
        //    public Cat(string name) : base(name) { }
        //    public override void MakeSound()
        //        {
        //            Console.WriteLine($"{Name} deyir: Miyavv");
        //        }
        //    }
        //public interface ICanFly
        //{
        //    void Fly();
        //}
        //class Bird : Animal, ICanFly
        //{
        //    public Bird(string name) : base(name) { }
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"{Name} deyir: Cik-cik");
        //    }
        //    public void Fly()
        //    {
        //        Console.WriteLine("Qus uca bilir");
        //    }
        //}


        //    static void Main(string[] args)
        //    {
        //        Dog dog = new Dog("Rex");
        //        dog.MakeSound();
        //        Cat cat = new Cat("Murov");
        //        cat.MakeSound();
        //        Bird bird = new Bird("Bulbul");
        //        bird.MakeSound();
        //        bird.Fly();

        //    }
        //class BankAccount
        //{
        //    private double balance;


        //    public double Balance
        //    {
        //        get { return balance; }
        //    }
        //    public void Deposit(double amount)
        //    {
        //        if (amount > 0)
        //        {
        //            balance += amount;
        //            Console.WriteLine($"{amount} Azn elave olundu.Yeni balans:{balance}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Əlavə olunan məbləğ sıfırdan böyük olmalıdır.");
        //        }
        //    }
        //    public void Withdraw(double amount) 
        //    {
        //       if(amount <= 0) 
        //        {
        //            Console.WriteLine("Elave olunan mebleg sifirdan boyuk olmalidir");
        //        }
        //       else if(amount > balance)
        //        {
        //            Console.WriteLine("Yeterli balans yoxdur");
        //        }
        //       else 
        //        {
        //            balance -= amount;
        //            Console.WriteLine($"{amount}AZN cixarildi.Yeni balans {balance}Azn"); 
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        BankAccount account = new BankAccount();
        //        account.Deposit(100);
        //        account.Withdraw(50);
        //        account.Deposit(100);
        //        Console.WriteLine("Balans:"+account.Balance+"AZN");
        //    }

        //}
    //    class Student
    //    {
    //        private string name;
    //        private int grade;

    //        public string Name
    //        {
    //            get { return name; }
    //            set
    //            {
    //                if (!string.IsNullOrWhiteSpace(value))
    //                {
    //                    name = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Ad boş ola bilməz.");
    //                }
    //            }
    //        }

    //        public int Grade
    //        {
    //            get { return grade; }
    //            set
    //            {
    //                if (value >= 0 && value <= 100)
    //                {
    //                    grade = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Grade 0-100 aralığında olmalıdır.");
    //                }
    //            }
    //        }

    //        public void PrintInfo()
    //        {
    //            Console.WriteLine($"Tələbə: {Name}, Qiymət: {Grade}");
    //        }
    //    }
        
    //static void Main(string[] args)
    //{
    //    Student student = new Student();

    //    student.Name = "Taleh";
    //    student.Grade = 95;
    //    student.PrintInfo();

    //    student.Grade = 120;  // Xəta mesajı çıxacaq
    //    student.Name = "";    // Xəta mesajı çıxacaq
    //}
    //class Person
    //    {
    //        private string Name;
    //        private int Age;
    //        public string name
    //        {
    //            get { return Name; }
    //            set
    //            {
    //                if (!string.IsNullOrWhiteSpace(Name))
    //                {
    //                    Name = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Ad bos ola bilmez.");
    //                }
    //            }
    //        }
    //        public int age
    //        {
    //            get { return Age; }
    //            set 
    //            {
    //                if(value>=0 && value <= 150)
    //                {
    //                    Age = value;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Yas 0-150 araliginda olamalidir");
    //                }
    //            }
    //        }
    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Person:{Name}, Yas:{Age}");
    //        }
    //        static void Main(string[] args)
        //    {
        //        Person p = new Person();
        //        p.Name = "";
        //        p.Age = 30;
        //        p.DisplayInfo();
             
                
        //    }
          
        //}
        class Employee
        {
            private string Name="Taleh";
            private double Salary=3000;
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Ad:{Name},Maas:{Salary}");
            }
        }
        
        class Manager :Employee
        {
            public override void DisplayInfo() 
            {
                Console.WriteLine("Menecer məlumatı göstərilir");
            }
        }
        class Developer : Employee
        {
            public override void DisplayInfo()
            {
                Console.WriteLine("Developer məlumatı göstərilir");
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.DisplayInfo(); // Çıxış: Name: Generic Employee, Salary: 5000

            Employee mgr = new Manager();
            mgr.DisplayInfo(); // Çıxış: Manager Info Displayed

            Employee dev = new Developer();
            dev.DisplayInfo(); // Çıxış: Developer Info Displayed
        }
    }
}