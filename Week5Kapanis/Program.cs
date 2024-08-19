using Week5Kapanis;

internal class Program
{
    public static void Main(string[] args)
    {   
        List<Car> cars = new List<Car>();                                                               //Araba listi oluşturuldu
       

        while (true)
        {
            Console.WriteLine("Araba üretmek ister misiniz ? (e / h)");
            string answer = Console.ReadLine().ToLower();

            if (answer == "e")
            {
                ask2:  Car car = new Car();

                Console.WriteLine("Üretim Tarihi : " + car.ProductionOfDate);

                Console.Write("Seri numarasını giriniz : ");
                car.SerialNumber = Console.ReadLine();

                Console.Write("Markasını giriniz : ");
                car.Brand = Console.ReadLine();

                Console.Write("Modelini giriniz : ");
                car.Model = Console.ReadLine();

                Console.Write("Rengini giriniz : ");
                car.Color = Console.ReadLine();
              
                ask: Console.Write("Kapı sayısını giriniz : ");                                             //Kapı sayısına doğru veri türü girilip girilmediği kontrol edilerek kullanıcıya uyarı veriliyor
                try
                {
                   
                    car.NumberOfDoors = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {

                    Console.WriteLine("Sayısal olmayan bir değer girdiniz !");
                    goto ask;
                }

                cars.Add(car);                  //oluşturulan arabalar listeye eklendi

                Console.Write("Başka araba üretmek ister misiniz ? (e / h) ");
                string answer2 = Console.ReadLine();

                if (answer2 == "e")
                {
                    goto ask2;
                }
                else if (answer2 == "h")
                {
                    foreach (Car c in cars)                                                 //Liste foreach ile dönülerek ekrana yazdırıldı
                    {

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Arabanın seri numarası : " + c.SerialNumber + " Markası : " + c.Brand);          
                    }
                    break;
                }

            }
            else if (answer == "h")                                                                         //cevap hayırsa programdan çıkılır
            {
                Console.WriteLine("Program sonlandırıldı.");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz bir cevap girdiniz.Lütfen tekrar girin :  ");                   
            }

        }
        
    }
}