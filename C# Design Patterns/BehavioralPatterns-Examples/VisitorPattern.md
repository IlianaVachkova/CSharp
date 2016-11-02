#Visitor Pattern/Посетител шаблон
Целта на този шаблон е open/close принципа от SOLID принципите да се имплементира по подразбиране. Visitor позволява да дефинираме операция в самия клас, която може да се прилага върху неговата структурата. Когато правим дизайна на нашия клас решаваме че ще приемаме visitоr-и, на които ще подаваме някакви данни и те ще ни връщат резултат. Нашият клас съдържа метод, който приема Visitor, подава му данни, които той обработва и връща резултат, който ние прилагаме някъде. По този начин операциите, които правим върху данните и самите данни са разкачени едни от други. Можем лесно да подменяме функционалност в visitor-ите и да им добавяме нова или да добавяме цели нови visitor-и.

###Пример
	public interface IVisitor {
	  void Visit(PlainText docPart);
	  void Visit(BoldText docPart);
	  void Visit(Hyperlink docPart);
	}

	public class HtmlVisitor : IVisitor {
	  public string Output { 
	    get { return this.m_output; }
	  }
	  private string m_output = "";
	
	  public void Visit(PlainText docPart) {
	    this.Output += docPart.Text;
	  }
	
	  public void Visit(BoldText docPart) {
	    this.m_output += "<b>" + docPart.Text + "</b>";
	  }
	
	  public void Visit(Hyperlink docPart) {
	    this.m_output += "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
	  }
	}

	public abstract class DocumentPart {
	  public string Text { get; private set; }
	  public abstract void Accept(IVisitor visitor);
	}

	public class PlainText : DocumentPart { 
	  public override void Accept(IVisitor visitor) {
	    visitor.Visit(this);
	  }
	}

	public class BoldText : DocumentPart { 
	  public override void Accept(IVisitor visitor) {
	    visitor.Visit(this);
	  }
	}

	public class Hyperlink : DocumentPart {
	  public string Url { get; private set; }
	
	  public override void Accept(IVisitor visitor) {
	    visitor.Visit(this);
	  }
	}

	public class Document {
	  private List<DocumentPart> m_parts;
	
	  public void Accept(IVisitor visitor) {
	    foreach (DocumentPart part in this.m_parts) {
	      part.Accept(visitor);
	    }
	  }
	}