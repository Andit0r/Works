//using Lection0312;

//Logger.GetInstance().Log("LOG: test singleton");
//Logger.GetInstance().Log($"LOG: {DateTime.Now}");

//Application application = new Application();
//var pdf = application.Create("pdf");

//IUIFactory factory = new WindowsUIFactory();
//IButton button = factory.CreateButton();
//button.Render();

using Lection0312;
using System.Runtime.Serialization;

/*QueryBuilder builder = new("users");

builder = builder
    .Where("age > 18")
    .Select("name, age")
    .OrderBy("name")
    .OrderBy("age");

Console.WriteLine(builder.Build());

var paymentProcessor = new PaymentProcessor(new CardPayment());
paymentProcessor.ProcessPayment(123);

Blogger EdisonPerec = new();
EdisonPerec.PublishVideo("НОВОЕ ВИДЕО ПО МАЙНКРАФТУ ЙОУ");

Subscriber allPeople = new();
EdisonPerec.VideoPublished += allPeople.OnVideoPublished;

EdisonPerec.PublishVideo("ВЫЖИВАНИЕ ОТ БОМЖА ДО МИЛЛИОНЕРА");
EdisonPerec.PublishVideo("ГОНКА ЛАКИ БЛОКОВ. ЛАКИ БЛОКИ ЗЕМЛЯ");


Sensor sensor = new();
sensor.AddObserver(new TemperatureDisplay() { Sensor = sensor });
sensor.AddObserver(new PressureDisplay() { Sensor = sensor });
sensor.Temperature = -5;
sensor.Pressure = 750;
sensor.NotifyObservers();
sensor.NotifyObservers();

Console.WriteLine();


IService service = new DataService();
service.Execute();
Console.WriteLine();

service = new LoggingDecorator(service);
service.Execute();

Console.WriteLine();
*/

IPizza pizza = new BasePizza();

Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()}");

pizza = new Cheese(pizza);
pizza = new Cheese(pizza);
pizza = new Tomato(pizza);
pizza = new Peperoni(pizza);
pizza = new Peperoni(pizza);

Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()}");