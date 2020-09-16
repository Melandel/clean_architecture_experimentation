using System;

namespace HelloWorld
{
	internal class UserInterfaceImpl : UserInterface
	{
		private GetHelloWorldController GetHelloWorldController { get; }

		public UserInterfaceImpl(GetHelloWorldController getHelloWorldController)
		{
			GetHelloWorldController = getHelloWorldController;
		}

		void UserInterface.Display()
		{
			var request = GetHelloWorldController.Request.Create();
			var response = GetHelloWorldController.Process(request);
			Console.WriteLine(response.Message);
		}
	}
}
