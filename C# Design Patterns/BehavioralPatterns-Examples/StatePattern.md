#State Pattern/Шаблон за състояние

Когато поведението на даден обект трябва да бъде променено според състоянието се прилага state шаблонът. Състоянията се имплементират като отделни обекти, а преходите между отделните състояния се правят в самите състояния. Това, което можем да правим в отделно състояние е метод в него.

###Предимсво
Логиката на състоянието е енкапсулирана в самото състояние.

###Недостатък
Всяко състояне знае за друго състояние(силен coupling).

###Пример
	abstract class State
  	{
    	public abstract void Handle(Context context);
  	}

  	class ConcreteStateA : State
  	{
    	public override void Handle(Context context)
    	{
      	context.State = new ConcreteStateB();
    	}
  	}

  	class ConcreteStateB : State
  	{
    	public override void Handle(Context context)
    	{
 			context.State = new ConcreteStateA();
    	}
  	}

  	class Context
  	{
    	private State _state;

    	public Context(State state)
    	{
      		this.State = state;
    	}

    	public State State
    	{
      		get { return _state; }
      		set 
			{ 
				_state = value;
    			Console.WriteLine("State: " + _state.GetType().Name);
      		}
    	}

    	public void Request()
    	{
      		_state.Handle(this);
    	}
  	}
