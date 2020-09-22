using Xunit;

namespace Messaging.Tests
{
	public class Create
	{
		[Fact]
		public void WHEN_happy_path_EXPECT_Content_TO_EQUAL_input()
		{
			// Arrange
			var input = "foo";
			// Act
			var sut = Message.Create(input);
			// Assert
			Assert.Equal("foo", sut.Content);
		}
	}
}
