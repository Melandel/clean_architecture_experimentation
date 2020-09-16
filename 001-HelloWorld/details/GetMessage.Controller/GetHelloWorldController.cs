namespace HelloWorld
{
	public interface GetHelloWorldController
	{
		Response Process(Request req);

		public class Request {
			public static Request Create() => new Request();
			private Request() { }
		}

		public class Response {
			public string Message { get; }
			public static Response Create(string message) => new Response(message ?? "");
			private Response(string message) {
				Message = message;
			}
		}
	}
}
