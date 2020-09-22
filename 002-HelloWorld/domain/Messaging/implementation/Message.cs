namespace Messaging
{
	public class Message
	{
		public string Content { get; set; }
		public static Message Create(string content)
		{
			return new Message(content);
		}

		private Message(string content)
		{
			Content = content;
		}
	}
}
