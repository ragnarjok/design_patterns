namespace Facade {
	class FirstComponentImpl {
		public void FirstComponentRelatedMethod();
	}

	class SecondComponentImpl {
		public void SecondComponentRelatedMethod();
	}

	class ThirdComponentImpl {
		public void ThirdComponentRelatedMethod();
	}

	public class Facade {
		private FirstComponentImpl _firstInstance;
		private SecondComponentImpl _secondInstance;
		private ThirdComponentImpl _thirdInstance;

		public void ProvideClientFunctionality()
		{
			// TODO: some inner logic
			_firstInstance.FirstComponentRelatedMethod();
			_secondInstance.SecondComponentRelatedMethod();
			_thirdInstance.ThirdComponentRelatedMethod();
		}
	}

}