namespace HelloWorld
{
	internal class GetHelloWorldControllerImpl : GetHelloWorldController
	{
		private GetMessage GetMessage  { get; }

		public GetHelloWorldControllerImpl(GetMessage getMessage)
		{
			GetMessage = getMessage;
		}

		GetHelloWorldController.Response GetHelloWorldController.Process(GetHelloWorldController.Request req)
		{
			var appRq = GetMessage.Request.Create();
			var appRs = GetMessage.Process(appRq);
			return GetHelloWorldController.Response.Create(appRs.Message);
		}
	}
}
