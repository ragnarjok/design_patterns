namespace Flyweight
{
  class FlyweightFactory
  {
    private Dictionary<char, Flyweight> _initialized =
      new Dictionary<char, Flyweight>();
 
    public Flyweight GetByKey(char key)
    {
      // Uses "lazy initialization"
      Flyweight valueByKay = null;
      if (_initialized.ContainsKey(key))
      {
        valueByKay = _initialized[key];
      }
      else
      {
        switch (key)
        {
          case 'A': valueByKay = new FlyweightForAImpl(); break;
          case 'B': valueByKay = new FlyweightForBImpl(); break;
          //...
          case 'Z': valueByKay = new FlyweightForZImpl(); break;
        }
        _initialized.Add(key, valueByKay);
      }
      return valueByKay;
    }
  }
 
  abstract class Flyweight
  {
    public abstract void DoAction();
  }
 
  class FlyweightForAImpl : Flyweight
  {
    public override void DoAction()
    {
      
    }
  }

  class FlyweightForBImpl : Flyweight
  {
    public override void DoAction()
    {
      
    }
  }

  class FlyweightForZImpl : Flyweight
  {
    public override void DoAction()
    {
      
    }
  }

}
	
