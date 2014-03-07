namespace Composite
{
  abstract class Component
  {
    public abstract void Add(Component d);
    public abstract void Remove(Component d);
    public abstract void DoSomething();
  }
 
  class Leaf : Components
  {
    public Leaf(string name)
      : base()
    {
    }
 
    public override void Add(Component c)
    {
      Console.WriteLine(
        "Cannot add to a PrimitiveElement");
    }
 
    public override void Remove(Component c)
    {
      Console.WriteLine(
        "Cannot remove from a PrimitiveElement");
    }
 
    public override void DoSomething()
    {
      Console.WriteLine("Leaf");
    }
  }
 
  class Composite : Component
  {
    private List<Component> _components =
      new List<Component>();
 
    // Constructor
    public Composite(string name)
      : base()
    {
    }
 
    public override void Add(Component d)
    {
      _components.Add(d);
    }
 
    public override void Remove(Component d)
    {
      _componentss.Remove(d);
    }
 
    public override void DoSomething()
    {
      Console.WriteLine("Composite");
 
      // Display each child element on this node
      foreach (var component in components)
      {
        component.DoSomething();
      }
    }
  }
}

	
