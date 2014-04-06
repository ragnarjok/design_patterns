using System;

namespace Proxy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
	public interface IContract {
		void DoSomething();
	}

	public class Contract: IContract
	{
		public void DoSomething(){
			Console.WriteLine("Actual action");
		}
	}

	public class ContractProxy:IContract{
		private Contract actualContract = new Contract();

		public void DoSomething(){
			actualContract.DoSomething();
		}
	}
}
