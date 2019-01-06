using FluentAssertions;
using Xunit;

namespace ItemStore.IntegrationTests
{
	public class UnitTest
	{
		[Fact]
		public void Test()
		{
			true.Should().BeTrue();
		}
	}
}
