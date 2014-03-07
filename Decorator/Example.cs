namespace Decorator {


abstract class Component
  {
    public abstract void DoSomething();
  }
 

  class ComponentFirstImpl : Component
  {
    private int _additionalInfo;
 
    // Constructor
    public ComponentFirstImpl(int additionalInfo)
    {
    	_additionalInfo = additionalInfo;
    }
 
    public override void DoSomething()
    {
      Console.WriteLine(_additionalInfo);
    }
  }
 
  
  class ComponentSecondImpl : Component
  {
    private string _id;
    
    public ComponentSecondImpl(string id)
    {
      _id = id;
    }
 
    public override void DoSomething()
    {
      Console.WriteLine(_id);
    }
  }
 
  abstract class Decorator : Component
  {
    protected Component WrappedComponent;
 
    // Constructor
    public Decorator(Component component)
    {
      WrappedComponent = component;
    }
 
    public override void DoSomething()
    {
      WrappedComponent.DoSomething();
    }
  }
 
  class DecoratorImpl : Decorator
  {
    protected List<string> decorativeElements = new List<string>();
 
    // Constructor
    public DecoratorImpl(Component component)
      : base(component)
    {
    }
 
    public void DoDecorate(string name)
    {
      decorativeElements.Add(name);
    }
 
 
    public override void DoSomething()
    {
      base.DoSomething();
 
      foreach (string decorativeElement in decorativeElements)
      {
        Console.WriteLine(" use: " + decorativeElement);
      }
    }
  }
}
