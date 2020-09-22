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

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void WHEN_input_is_null_or_empty_EXPECT_Content_TO_BE_empty(string edgeCaseInput)
		{
			// Arrange
			var input = edgeCaseInput;
			// Act
			var sut = Message.Create(input);
			// Assert
			Assert.Equal(string.Empty, sut.Content);
		}


	}
}
