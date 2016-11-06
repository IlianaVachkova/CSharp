#Factory Method Pattern
При Factory Method шаблонът се задава базов принцип за създаване на обекти, като се оставя всеки един подклас да прецени кои обекти да създаде. Множество класове може да имплементират този шаблон, като се оставя на клиента да си избере с кой точно доставчик на обекти иска да работи.

###Употреба
 - Когато гъвкавостта е важна.
 - Когато обектите могат да бъдат наследени/доразвити в подкласове.
 - Когато клиентът делегира отговорности на подкласовете в паралелни йерархии.
 - Когато добавянето на нови класове не нарушава Open/Closed Principle.

###Пример
Клиентът получава различно питие, в зависимост от това кое Factory си е избрал

Abstract class Distillery – играе ролята на Creator, който задава базовите принципи.

	public abstract class Distillery
	    {
	        public abstract AlcoholicBeverage MakeDrink();
	    } 

Concreate Creator NorthWildScotts – сам преценява какви обекти да създаде.

	public class NorthWildScotts : Distillery
	    {
	        public override AlcoholicBeverage MakeDrink()
	        {
	            var drink = new Whisky { Taste = "Very Smoky", YearsMatured = 12 };
	            return drink;
	        }
	    }

Abstract Class AlcoholicBeverage.

	public abstract class AlcoholicBeverage
	    {
	        public string Taste { get; set; }
	
	        public int YearsMatured { get; set; }
	
	        public string CountryOfOrigin { get; protected set; }
	
	        public override string ToString()
	        {
	            var drinkAsString = new StringBuilder();
	            drinkAsString.AppendFormat("Drink type: {0}", this.GetType().Name);
	            drinkAsString.AppendLine();
	            drinkAsString.AppendFormat("Tastes: {0}", this.Taste);
	            drinkAsString.AppendLine();
	            drinkAsString.AppendFormat("Matured for: {0} years", this.YearsMatured);
	            drinkAsString.AppendLine();
	            drinkAsString.AppendFormat("Made in: {0}", this.CountryOfOrigin);
	            return drinkAsString.ToString();
	        }
	    } 

Concreate Creator Whisky.

	public class Whisky : AlcoholicBeverage
	    {
	        public Whisky()
	        {
	            this.CountryOfOrigin = "Scotland";
	        }
	    } 

####Използване 
Клиента получава различен резултат в зависимост от това с кое Factory си е избрал да работи.

	public class Client
	    {    
	        public static void Main()
	        {
	            GetDrinkFromDistilley(new EireOld());
	            LineSeparator();
	
	            GetDrinkFromDistilley(new NorthWildScotts());
	            LineSeparator();
	
	            GetDrinkFromDistilley(new TennesseeFinest());
	            LineSeparator();
	        }
	
	        private static void GetDrinkFromDistilley(Distillery distillery)
	        {
	            var drink = distillery.MakeDrink();
	            Console.WriteLine(drink.ToString());
	        }
	
	        private static void LineSeparator()
	        {
	            Console.WriteLine(new string('-', 60));
	        }
	    } 