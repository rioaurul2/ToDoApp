using DesignPatternsPractice.Behavioral.State;
using DesignPatternsPractice.Creational.Builder;
using DesignPatternsPractice.Structural.Adapter;
using DesignPatternsPractice.Structural.Decorator;
using DesignPatternsPractice.Structural.Facade;
using DesignPatternsPractice.Structural.Proxy;


namespace DesignPatternsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("🔹 Singleton Pattern Demo 🔹\n");

            //    var logger1 = Logger.Instance;
            //    var logger2 = Logger.Instance;


            //    logger1.Log("First log message");
            //    logger2.Log("Second log message");

            //    Console.WriteLine("\nSame instance? " + (logger1 == logger2));

            //Console.WriteLine("🔹 Factory Pattern Demo 🔹\n");

            //    Console.Write("Enter animal type (dog/cat): ");

            //    var input = Console.ReadLine();

            //    try
            //    {
            //        var animal = AnimalFactory.CreateAnimal(input);
            //        animal.Speak();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }

            //Console.WriteLine("🔹 Abstract Factory Pattern Demo 🔹\n");

            //    Console.Write("Enter animal type (dog/cat): ");
            //    string? input2 = Console.ReadLine()?.ToLower();

            //    IAnimalFactory factory = input2 switch
            //    {
            //        "dog" => new DogFactory(),
            //        "cat" => new CatFactory(),
            //        _ => throw new ArgumentException("Invalid animal type")
            //    };

            //    var animal2 = factory.CreateAnimal();
            //    var habitat = factory.CreateHabitat();

            //    animal2.Speak();
            //    habitat.Describe();


            //Console.WriteLine("🔹 Strategy Pattern Demo 🔹\n");

            //    Console.Write("Enter payment method (card/paypal/crypto): ");
            //    var input3 = Console.ReadLine()?.ToLower();

            //    IPaymentStrategy strategy = input3 switch
            //    {
            //        "card" => new CreditCardPayment(),
            //        "paypal" => new PayPalPayment(),
            //        "crypto" => new CryptoPayment(),
            //        _ => throw new ArgumentException("Invalid payment method")
            //    };

            //    var processor = new PaymentProcessor(strategy);

            //    Console.Write("Enter amount to pay: ");
            //    var amount = decimal.Parse(Console.ReadLine()!);

            //    processor.ExecutePayment(amount);

            ////decorator example

            //var simple = new SimpleMessage();
            //Console.WriteLine(simple.GetContent());

            //var encrypted = new EncryptedMessage(simple);
            //Console.WriteLine(encrypted.GetContent());

            ////Adapter example

            //IOldWeatherProvider weather = new WeatherAdapter(new NewWeatherService());
            //Console.WriteLine(weather.GetWeather()); // Output: 24°C and sunny

            ////Command example

            //var light = new Light();

            //var turnOn = new TurnOnLightCommand(light);
            //var turnOff = new TurnOffLightCommand(light);

            //var remote = new RemoteControl();

            //remote.SetCommand(turnOn);
            //remote.PressButton(); // Output: Light is ON

            //remote.SetCommand(turnOff);
            //remote.PressButton(); // Output: Light is OFF

            ////Observer Pattern

            //var station = new WeatherStation();

            //var phone1 = new PhoneDisplay("Phone1");
            //var phone2 = new PhoneDisplay("Phone2");

            //station.Attach(phone1);
            //station.Attach(phone2);

            //station.SetTemperature(23.5f);
            //// Output: Phone1 Display: Temperature updated to 23.5°C
            ////         Phone2 Display: Temperature updated to 23.5°C

            //station.Detach(phone2);
            //station.SetTemperature(26.0f);
            //// Output: Phone1 Display: Temperature updated to 26°C
            ///

            //Builder Pattern

            var builder = new PizzaBuilder();
            var director = new PizzaDirector();

            var margherita = director.BuildMargherita(builder);
            Console.WriteLine(margherita);

            var pepperoni = director.BuildPepperoni(new PizzaBuilder());
            Console.WriteLine(pepperoni);

            // Sau construiești tu direct:
            var customPizza = new PizzaBuilder()
                .WithSize("XXL")
                .WithCheese()
                .AddToppings(["bacon", "ceapa"])
                .Build();

            Console.WriteLine(customPizza);

            //Facade Pattern

            Console.WriteLine();

            var booking = new BookingFacade();
            booking.BookTicket("Marin Pop", "Concert Linkin Park");

            //Proxy Pattern

            Console.WriteLine();

            IDocument doc1 = new DocumentProxy("confidential.pdf", "User");
            doc1.Display(); // Access denied

            IDocument doc2 = new DocumentProxy("confidential.pdf", "Admin");
            doc2.Display(); // Load + Display
            doc2.Display(); // Just Display (lazy loading)

            //State pattern

            Console.WriteLine();

            var atm = new AtmContext();

            atm.WithdrawCash();
            atm.InsertCard();
            atm.WithdrawCash();
            atm.EjectCard();     



        }
    }
}
