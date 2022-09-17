var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddYamlFile("config.main.yaml", optional: false, reloadOnChange: true)
    .AddYamlFile("config.serial.yaml", optional: false, reloadOnChange: true)
    .AddYamlFile("config.network.yaml", optional: false, reloadOnChange: true);
builder.Services.AddRazorPages();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
