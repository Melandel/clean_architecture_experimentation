using System;
using System.Collections.Generic;
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

		public static IEnumerable<object[]> InputSpecifiedAsOutOfScope =>
			new List<object[]> {
				new object[] { "😀 😃 😄" }, // Emojis
				new object[] { "     " }, // Weird characters
				new object[] { (new String('x', 2000 + 1)) } // More than 2000 characters
			};

		[Theory]
		[MemberData(nameof(InputSpecifiedAsOutOfScope))]
		public void WHEN_input_is_specified_as_out_of_scope_EXPECT_Method_TO_NOT_throw(string outOfScopeInput)
		{
			// Arrange
			var input = outOfScopeInput;
			// Act
			var sut = Message.Create(input);
			// Assert
			Assert.True(true, "These inputs do not make the code throw");
		}
	}
}
