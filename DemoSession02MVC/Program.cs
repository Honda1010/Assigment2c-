namespace DemoSession02MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			#region Registe services in DI Container
			builder.Services.AddControllersWithViews();
			#endregion

			var app = builder.Build();




			#region Maps
			app.MapGet("/mohannad", () => "Hello mohannad"); //static route
															 //dynamic route
			app.MapGet("/{name}", async (context) =>
			{
				var name = context.GetRouteValue("name");
				await context.Response.WriteAsync($"Hello {name}");
			});
			// Mixed route
			app.MapGet("/miss{name}", async (context) =>
			{
				var name = context.GetRouteValue("name");
				await context.Response.WriteAsync($"Hello miss {name}");
			});
			#endregion

			app.UseStaticFiles(); // to enable wwwroot

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id:int?}"
				);





			app.Run();
        }
    }
}
