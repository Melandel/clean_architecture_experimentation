using Xunit;

namespace HelloWorld {
	public sealed class GetMessageTest : GetMessage.Behavior.ShouldReturnMessage
	{
		protected override GetMessage CreateSystemUnderTest(string storedMessage) { 
			var messageGateway = new FakeMessageGateway(storedMessage);
			var sut = new GetMessageImpl(messageGateway);
			return sut;
		}
		protected override void AssertCorrectUseOfDependencies(GetMessage sut) {
			var concreteSut = sut as GetMessageImpl;
			var fakeMessageGateway = concreteSut.MessageGateway as FakeMessageGateway;
			Assert.Equal(1, fakeMessageGateway.GetMessage_NumberOfCalls);
		}
	}

	internal class GetMessageImpl : GetMessage
	{
		internal MessageGateway MessageGateway { get; }
		public GetMessageImpl(MessageGateway messageGateway) {
			MessageGateway = messageGateway;
		}
		public GetMessage.Response Process(GetMessage.Request req) {
			var message = MessageGateway.GetMessage();
			var response = GetMessage.Response.Create(message.Content);
			return response;
		}
	}
}
