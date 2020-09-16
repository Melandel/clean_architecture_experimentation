namespace HelloWorld
{
	public interface MessageGateway
	{
		Message GetMessage();
	}

	class FakeMessageGateway : MessageGateway
	{
		public int GetMessage_NumberOfCalls { get; private set; }
		private string messageToReturn { get; set; }
		public FakeMessageGateway (string messageToReturn) {
			this.messageToReturn = messageToReturn;
		}
		public Message GetMessage() {
			GetMessage_NumberOfCalls++;
			return Message.Create(messageToReturn);
		}
	}
}
