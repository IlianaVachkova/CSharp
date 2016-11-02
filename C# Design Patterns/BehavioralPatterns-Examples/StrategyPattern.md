#Srategy Pattern/Стратегически шаблон
Този шаблон се използва когато искаме да направим абстракция на алгоритъм. За целта си правим интерфейс, който описва входните и изходните данни на всеки метод в алгоритъма. Така в класа където използваме strategy-то разчитаме на абстракция и спазваме DIP от SOLID принципите. Този шаблон се прилага когато имаме прекалено много if-else случаи в дадена логика. Тази логика може да се изнесе в strategy като всяка логика от if-else случаите се намира в отделен метов в отделен клас.

###Предимства
Прави кода лесен за тестване.
Логиката живее в отделни класове.
Добавянето на ново strategy е лесно.Спазва OCP от SOLID принципите.

###Пример
	abstract class SortStrategy {
   		public abstract void Sort(IList<object> list);
	}
	
	class QuickSort : SortStrategy {
   		public override void Sort(IList<object> list) { ... }
	}
		
	class MergeSort : SortStrategy {
   		public override void Sort(IList<object> list) { ... }
	}
	
	class SortedList {
   		private IList<object> list = new List<object>();

   		public void Sort(SortStrategy strategy) {
      		// sortStrategy can be passed in constructor
      		sortStrategy.Sort(list);
   		}
	}