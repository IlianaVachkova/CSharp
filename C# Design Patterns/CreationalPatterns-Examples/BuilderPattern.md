#Builder Pattern/Създаващ шаблон
Служи за създаване на обекти, при които е важна последователността на инициализиране на различните компоненти на обекта. В общия случай различните компоненти са взаимно зависими, което налага определена последователност при създаването им. Целта е да се раздели създаването на сложен обект от неговото представяне (интерфейс), за да може с един и същ процес да се създават обекти с различно представяне. Често в практиката може след прилагането на Factory Method, да се надгради съществуващия код с използването на Builder, който е по-гъвкавият и сложен шаблон за дизайн.

###Пример
public class Manufacturer - играе ролята на Director, който определя последователността oт стъпки, по които трябва да се създаде един мобилен телфон.

	public class Manufacturer
	    {
	        public void Construct(PhoneBuilder phoneBuilder)
	        {
	            phoneBuilder.BuildBattery();            
	            phoneBuilder.BuildScreen();
	            phoneBuilder.BuildOS();
	            phoneBuilder.PutPrice();
	        }
	    }

abstract class PhoneBuilder - играе ролята на Builder, определя от каквo се състои един мобилен телефон.

	public abstract class PhoneBuilder
	    {
	        public Phone Phone { get; set; }
	
	        public abstract void BuildBattery();
	
	        public abstract void BuildScreen();
	
	        public abstract void BuildOS();
	
	        public abstract void PutPrice();
	    }

public class SmartElectronics - наследява Builder-а и дефинира собствените параметри на създавания обект.

	public class SmartElectronics : PhoneBuilder
	    {
	        public SmartElectronics()
	        {
	            this.Phone = new Phone("Smart Electronics");
	        }
	
	        public override void BuildBattery()
	        {
	            this.Phone["battery"] = "Li-Ion 1500 Mah";
	        }
	
	        public override void BuildScreen()
	        {
	            this.Phone["screen"] = "5\" OLDED";
	        }
	
	        public override void BuildOS()
	        {
	            this.Phone["os"] = "Android";
	        }
	
	        public override void PutPrice()
	        {
	            this.Phone["price"] = "$499";
	        }
	    }

public class Phone - продуктът, който се създава.

	public class Phone
	    {
	        private readonly string phoneManufacturer;
	        private readonly Dictionary<string, string> info = new Dictionary<string, string>();
	
	        public Phone(string vehicleType)
	        {
	            this.phoneManufacturer = vehicleType;
	        }
	
	        public string this[string key]
	        {
	            get { return this.info[key]; }
	            set { this.info[key] = value; }
	        }
	
	        public void ShowInfo()
	        {
	            Console.WriteLine(new string('*', 30));
	            Console.WriteLine("Phone Manufacturer: {0}", this.phoneManufacturer);
	            Console.WriteLine(" Battery  : {0}", this.info["battery"]);
	            Console.WriteLine(" Screen : {0}", this.info["screen"]);
	            Console.WriteLine(" OS: {0}", this.info["os"]);
	            Console.WriteLine(" Price : {0}", this.info["price"]);
	            Console.WriteLine(new string('*', 30));
	        }
	    }

Използване от страна на клиента.

	public class Client
	    {
	        public static void Main()
	        {
	            PhoneBuilder builder;
	
	            // We can choose concrete constructor (director)
	            var constructor = new Manufacturer();
	
	            // And we can choose concrete builder
	            builder = new ShinyTech();
	            constructor.Construct(builder);
	            builder.Phone.ShowInfo();
	
	            builder = new SmartElectronics();
	            constructor.Construct(builder);
	            builder.Phone.ShowInfo();
	        }
	    }