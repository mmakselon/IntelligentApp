using IntelligentApp.Components;

namespace IntelligentApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var openAiApiKey = builder.Configuration["OpenAI:ApiKey"];
            var openAiEndpoint = builder.Configuration["OpenAI:Endpoint"];

            var azureApiKey = builder.Configuration["AzureAI:ApiKey"];
            var azureEndpoint = builder.Configuration["AzureAI:Endpoint"];
            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
