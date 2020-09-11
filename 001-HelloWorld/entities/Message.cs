namespace HelloWorld
{
	public class Message {
		public string Content { get; }
		private Message(string content) {
			Content = content;
		}

		public static Message Create(string content) {
			return new Message(content?.Trim() ?? "");
		}
	}
}
