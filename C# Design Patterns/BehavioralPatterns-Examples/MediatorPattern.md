#Mediator Pattern/Пoсреднически шаблон
Шаблонът Mediator се грижи за комуникацията между обектите. Имаме един централен обект, който изпълнява цялата комуникация. Всички обекти които си комуникират знаят само за този междинен обект. Отделя се логиката на самите обекти от логиката, чрез която комуникират с други обекти. Шаблонът се използва в случаите, когато всеки трябва да знае за всеки.

###Предимсва
Цялата логика на комуникация отива в Mediatora-а.
Участниците в комуникацията не знаят един за друг.

###Пример
	using System;
 
	namespace DoFactory.GangOfFour.Mediator.Structural
	{
  		class MainApp
	  	{
			static void Main()
	    	{
	      		ConcreteMediator m = new ConcreteMediator();
	 
	      		ConcreteColleague1 c1 = new ConcreteColleague1(m);
	      		ConcreteColleague2 c2 = new ConcreteColleague2(m);
	 
	      		m.Colleague1 = c1;
	      		m.Colleague2 = c2;
	 
	      		c1.Send("How are you?");
	  	  		c2.Send("Fine, thanks");
	
	      		// Wait for user
	      		Console.ReadKey();
			}
	  	}
 
		abstract class Mediator
		{
			public abstract void Send(string message, Colleague colleague);
		}

  
	  	class ConcreteMediator : Mediator
	  	{
	    	private ConcreteColleague1 _colleague1;
	    	private ConcreteColleague2 _colleague2;
	 
	    	public ConcreteColleague1 Colleague1
	    	{
	      		set { _colleague1 = value; }
	    	}
	 
	    	public ConcreteColleague2 Colleague2
	    	{
	      		set { _colleague2 = value; }
			}
	 
	    	public override void Send(string message, Colleague colleague)
	    	{
	      		if (colleague == _colleague1)
	      		{
	   				_colleague2.Notify(message);
	      		}
	      		else
	      		{
	        		_colleague1.Notify(message);
	      		}
	    	}
	  	}
  
	  	abstract class Colleague
	  	{
	    	protected Mediator mediator;
	 
	    	public Colleague(Mediator mediator)
	    	{
	      		this.mediator = mediator;
	    	}
	  	}
 
	   	class ConcreteColleague1 : Colleague
	  	{
	    	public ConcreteColleague1(Mediator mediator)
	      		: base(mediator)
	    	{
	    	}
	 
	    	public void Send(string message)
	    	{
	      		mediator.Send(message, this);
	    	}
	 
	    	public void Notify(string message)
	    	{
	      		Console.WriteLine("Colleague1 gets message: "
	        		+ message);
	    	}
	  	}
 
	  	class ConcreteColleague2 : Colleague
	  	{
	    	public ConcreteColleague2(Mediator mediator)
	      		: base(mediator)
	    	{
	    	}
	 
	    	public void Send(string message)
	    	{
	      		mediator.Send(message, this);
	    	}
	 
	    	public void Notify(string message)
	    	{
	      		Console.WriteLine("Colleague2 gets message: "
	        		+ message);
	    	}
	  	}
	}