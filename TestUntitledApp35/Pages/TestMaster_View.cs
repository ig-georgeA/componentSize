using Bunit;
using Microsoft.Extensions.DependencyInjection;
using UntitledApp35.Pages;

namespace TestUntitledApp35
{
	[Collection("UntitledApp35")]
	public class TestMaster_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Master_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
