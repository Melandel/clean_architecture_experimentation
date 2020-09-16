namespace HelloWorld
{
	internal class MessageGatewayImpl : MessageGateway
	{
		public Message GetMessage() {
			return Message.Create("Hello World");
		}
	}
}
