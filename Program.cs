var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure default file to serve "wwwroot/pmclib/index.html"
var options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("index.html");
app.UseDefaultFiles();

// Serve static files (CSS, JS, images, etc.)
app.UseStaticFiles();

app.Run();
