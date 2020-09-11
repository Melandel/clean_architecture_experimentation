using Xunit;

namespace HelloWorld
{
	public interface GetMessage
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

		public class Behavior {
			public abstract class ShouldReturnMessage {
				[Theory]
				[InlineData("Hello World",   "Hello World")]
				[InlineData("Bonjour Monde", "Bonjour Monde")]
				public void Validate(string storedMessage, string expectedMessage) {
					// Arrange
					var request = Request.Create();
					var SUT = CreateSystemUnderTest(storedMessage);
					// Act
					var response = SUT.Process(request);
					// Assert
					Assert.Equal(expectedMessage, response.Message);
					AssertCorrectUseOfDependencies(SUT);
				}
				protected abstract GetMessage CreateSystemUnderTest(string storedMessage);
				protected abstract void       AssertCorrectUseOfDependencies(GetMessage sut);
			}
		}
	}
}
