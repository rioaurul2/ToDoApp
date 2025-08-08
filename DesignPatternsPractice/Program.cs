using DesignPatternsPractice.Behavioral.ChainOfResponsibility;
using DesignPatternsPractice.Behavioral.Mediator;
using DesignPatternsPractice.Behavioral.State;
using DesignPatternsPractice.Behavioral.TemplateMethod;
using DesignPatternsPractice.Creational.Builder;
using DesignPatternsPractice.Creational.Factory.Exercitii._1;
using DesignPatternsPractice.Creational.Factory.Exercitii._2;
using DesignPatternsPractice.Creational.Factory.Exercitii._3;
using DesignPatternsPractice.Creational.Factory.Exercitii._3.Interface;
using DesignPatternsPractice.Structural.Adapter;
using DesignPatternsPractice.Structural.Decorator;
using DesignPatternsPractice.Structural.Decorator.Exercises._1.Interface;
using DesignPatternsPractice.Structural.Decorator.Exercises._2;
using DesignPatternsPractice.Structural.Decorator.Exercises._2.Decorator;
using DesignPatternsPractice.Structural.Decorator.Exercises._2.Interface;
using DesignPatternsPractice.Structural.Facade;
using DesignPatternsPractice.Structural.Proxy;
using DesignPatternsPractice.Structural.Singleton.Exercitii._1;


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

            //var builder = new PizzaBuilder();
            //var director = new PizzaDirector();

            //var margherita = director.BuildMargherita(builder);
            //Console.WriteLine(margherita);

            //var pepperoni = director.BuildPepperoni(new PizzaBuilder());
            //Console.WriteLine(pepperoni);

            //// Sau construiești tu direct:
            //var customPizza = new PizzaBuilder()
            //    .WithSize("XXL")
            //    .WithCheese()
            //    .AddToppings(["bacon", "ceapa"])
            //    .Build();

            //Console.WriteLine(customPizza);

            ////Facade Pattern

            //Console.WriteLine();

            //var booking = new BookingFacade();
            //booking.BookTicket("Marin Pop", "Concert Linkin Park");

            ////Proxy Pattern

            //Console.WriteLine();

            //IDocument doc1 = new DocumentProxy("confidential.pdf", "User");
            //doc1.Display(); // Access denied

            //IDocument doc2 = new DocumentProxy("confidential.pdf", "Admin");
            //doc2.Display(); // Load + Display
            //doc2.Display(); // Just Display (lazy loading)

            ////State pattern

            //Console.WriteLine();

            //var atm = new AtmContext();

            //atm.WithdrawCash();
            //atm.InsertCard();
            //atm.WithdrawCash();
            //atm.EjectCard();

            ////Template Method Pattern
            //Console.WriteLine();

            //OrderProcessor online = new OnlineOrderProcessor();
            //online.ProcessOrder();

            //Console.WriteLine();

            //OrderProcessor inStore = new InStoreOrderProcessor();
            //inStore.ProcessOrder();

            ////Chain of responsability pattern

            //var teamLeader = new TeamLeader();
            //var manager = new Manager();
            //var CORdirector = new Director();

            //teamLeader.SetNext(manager);
            //manager.SetNext(CORdirector);

            //var request1 = new ExpenseRequest("Mouse nou", 300);
            //var request2 = new ExpenseRequest("Licență Visual Studio", 1200);
            //var request3 = new ExpenseRequest("Laptop performant", 8500);

            //teamLeader.Approve(request1);
            //teamLeader.Approve(request2);
            //teamLeader.Approve(request3);

            ////Mediator pattern

            //Console.WriteLine();

            //var textBox = new TextBox();
            //var button = new Button(null!);
            //var checkbox = new Checkbox(null!);

            //// Se instanțiază mediatorul
            //var mediator = new DialogMediator(button, textBox, checkbox);

            //button.SetMediator(mediator);
            //checkbox.SetMediator(mediator);

            //// Simulări
            //checkbox.Toggle();   
            //button.Click();      

            //checkbox.Toggle();   
            //button.Click();      


            ////Exercitii

            //Singleton instance1 = Singleton.Instance;
            //Singleton instance2 = Singleton.Instance;

            //// Ambele referințe ar trebui să fie la aceeași instanță
            //Console.WriteLine(ReferenceEquals(instance1, instance2)); // True

            //// Apelăm o metodă pe instanța Singleton
            //instance1.DoSomething(); // Singleton method called!

            //var car = VehicleParkFactory.CreateVehicle(VehicleType.Car);

            //car.Drive();

            //IPaymentProcessor factory = new PaymentProcessor() { };

            //try
            //{
            //    IPayment payment = factory.PayMethod(PaymentType.Card);
            //    payment.Pay();
            //}
            //catch (NotSupportedException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ////////////////////////////////////////

            //IBeverage coffee = new SimpleCoffee();
            //Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} RON");

            //coffee = new MilkDecorator(coffee);
            //Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} RON");

            //if (false)
            //{
            //    coffee = new WhippedCreamDecorator(coffee);
            //    Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} RON");
            //}

            //coffee = new ChocolateDecorator(coffee);
            //Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} RON");

            ///////////////////////////////////////

            IText text = new SimpleText();

            text = new NameDecorator(text);
            text = new FeelingDecorator(text);

            Console.WriteLine(text.GetText());

            //////////////////////////////////////
        }
    }
}
