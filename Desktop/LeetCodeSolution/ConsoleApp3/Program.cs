namespace ConsoleApp3
{
    //enum Status
    //{
    //    Aktiv=0,
    //    Passiv = 2,
    //    Banlanib = 3,
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Status userStatus = Status.Aktiv;

    //        if (userStatus == Status.Aktiv) 
    //        {
    //            Console.WriteLine("Istifadeci aktivdir.");
    //        }
    //        userStatus = Status.Passiv;
    //        if(userStatus == Status.Passiv)
    //        {
    //            Console.WriteLine("Istifadeci passivdir.");
    //        }
    //        int statusCode = (int)Status.Aktiv;
    //        Console.WriteLine(statusCode);
    //        int status =(int)Status.Passiv;
    //        Console.WriteLine(status);
    //    }
    //}
    //enum IstifadeciRolu
    //{
    //    Admin = 1,
    //    Moderator = 2,
    //    Istifadeci = 3,
    //    Qonaq = 4
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Zəhmət olmasa istifadəçi rolunu daxil edin (1-4): ");
    //        string input = Console.ReadLine();

    //        // Daxil edilən dəyəri int-ə çevirməyə çalışırıq
    //        bool isValid = int.TryParse(input, out int rolKodu);

    //        if (isValid && rolKodu >= 1 && rolKodu <= 4)
    //        {
    //            // Ədədi enum-a çeviririk
    //            IstifadeciRolu rol = (IstifadeciRolu)rolKodu;

    //            // Rola uyğun mesaj göstəririk
    //            switch (rol)
    //            {
    //                case IstifadeciRolu.Admin:
    //                    Console.WriteLine("Sistemdə tam hüquqlu giriş icazəniz var.");
    //                    break;

    //                case IstifadeciRolu.Moderator:
    //                    Console.WriteLine("Moderator hüquqları ilə daxil oldunuz.");
    //                    break;

    //                case IstifadeciRolu.Istifadeci:
    //                    Console.WriteLine("Standart istifadəçi kimi daxil oldunuz.");
    //                    break;

    //                case IstifadeciRolu.Qonaq:
    //                    Console.WriteLine("Qonaq kimi daxil oldunuz. Məhdud funksiyalar aktivdir.");
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Belə bir rol mövcud deyil!");
    //        }
    //    }
    //enum Gun
    //    {
    //        Bazarertesi ,
    //        CersenbeAxsami,
    //        Cersenbe,
    //        CumeAxsami,
    //        Cume,
    //        Senbe,
    //        Bazar
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("1 - dən 7 - yə qədər bir rəqəm daxil et:");
    //            string input = Console.ReadLine();

    //            bool isValid = int.TryParse(input, out int gundeyeri);

    //            if (isValid && gundeyeri >=1 && gundeyeri <= 7) 
    //            {
    //                Gun gun = (Gun)gundeyeri;
    //                switch (gun)
    //                {
    //                case Gun.Bazarertesi:
    //                     Console.WriteLine("Həftənin işə başlama günüdür.");
    //                    break;
    //                case Gun.CersenbeAxsami:
    //                        Console.WriteLine("Yeni həftənin ritmi tutulur.");
    //                    break;
    //                 case Gun.CumeAxsami:
    //                        Console.WriteLine("Həftə sonuna az qalıb.");
    //                    break;
    //                    case Gun.Cersenbe:
    //                        Console.WriteLine("Həftənin ortasıdır, davam et!");
    //                        break;
    //                        case Gun.Cume: Console.WriteLine("Yekun işlər üçün son gündür.");
    //                        break;
    //                    case Gun.Senbe:
    //                        Console.WriteLine("İstirahət günüdür!");
    //                        break;
    //                    case Gun.Bazar:
    //                        Console.WriteLine("Tam istirahət günü, dincəl!");
    //                        break;
    //                }
    //            }
    //            else 
    //            {
    //                Console.WriteLine("Bele bir gun movcud deyil!!!"); 
    //            }
    //        }
    //    }
    //enum Gunler
    //{
    //    Bazarertesi,
    //    Cersenbe,
    //    Cume,
    //    Bazar
    //}
    //class Program
    //{
    //    static void Main(string[] args) 
    //    {
    //        Gunler gun = Gunler.Cume;

    //        Console.WriteLine(gun);
    //    }
    //}
    //enum Reng
    //{
    //    Qirmizi = 1,
    //    Yasil = 2, 
    //    Mavi = 3
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("1-den 3-e qeder reqem secin:");
    //        string input = Console.ReadLine();
    //        bool ugurlu = int.TryParse(input, out int secim);
    //        if (ugurlu) {
    //            switch (secim)
    //            {
    //                case (int)Reng.Qirmizi:
    //                    Console.WriteLine("Siz Qirmizi reng daxil etmisiniz.");
    //                    break;
    //                case (int)Reng.Yasil:
    //                    Console.WriteLine("Siz Yasil reng daxil etmisiniz.");
    //                    break;
    //                case (int)Reng.Mavi:
    //                    Console.WriteLine("Siz Mavi reng daxil etmisiniz.");
    //                    break;
    //                    default: Console.WriteLine("Siz Yanlis reqem daxil etmisiniz!!!");
    //                    break;
    //            }
    //        }
    //        else {
    //            Console.WriteLine("Zehmet olmasa duzgun reqem daxil edin.");
    //                }
    //    }
    //}
    // enum Status
    // {
    //     Aktiv,
    //     Passiv
    // }
    //class Program
    // {
    //     static void Main(string[] args) 
    //     {
    //         Status status = Status.Passiv;
    //         if (status == Status.Aktiv) 
    //         {
    //             Console.WriteLine("Istifadeci Aktivdir");
    //         }
    //         else 
    //         {
    //             Console.WriteLine("Istifadeci Passivdir");
    //         }
    //     }
    // }
    //enum Aylar
    // {
    //     Yanvar = 1,
    //     Fevral = 2,
    //     Mart = 3
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Aylar aylar = Aylar.Mart;
    //         int aynomresi =(int) aylar;
    //         Console.WriteLine("Mart ayinin nomresi:"+aynomresi);
    //     }
    // }
    enum IstifadeciRolu
    {
        Admin = 1, 
        Moderator = 2, 
        Istifadeci = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-3 arasi reqem yaz:");
            string input = Console.ReadLine();
            bool ugurlu = int.TryParse(input, out int secim);
            if (ugurlu)
            {
                switch (secim)
                {
                    case (int)IstifadeciRolu.Admin:
                        Console.WriteLine("Admin girişi edildi");
                        break;
                        case (int)IstifadeciRolu .Moderator:
                        Console.WriteLine("Moderator girisi edildi.");
                        break;
                    case (int)IstifadeciRolu.Istifadeci:
                        Console.WriteLine("Sadə istifadəçi girişi edildi");
                        break;

                    default:
                        Console.WriteLine("Belə bir rol mövcud deyil!");
                        break;
                }
            }
        }
    }
}
