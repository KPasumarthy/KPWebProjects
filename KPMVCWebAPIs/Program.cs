using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(name: "api/values",
                pattern: "{ controller = Values}"
                );


//app.MapGet("/todoitems", async (TodoDb db) =>
//    await db.Todos.ToListAsync());

//app.MapGet("/todoitems/complete", async (TodoDb db) =>
//    await db.Todos.Where(t => t.IsComplete).ToListAsync());

//app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
//    await db.Todos.FindAsync(id)
//        is Todo todo
//            ? Results.Ok(todo)
//            : Results.NotFound());

//app.MapGet("/", () => "KP : Hello World!");
app.MapGet("/Value", () => "KP : KPMVCWebAPIs :  Hello World!");

// Getting the string form of the current date
// in a format, i.e, 07/27/2024 07:29:00 AM          
string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
String input = "KP : Today's Date : " + currentDate;
Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

app.MapGet("/DateTimeNow", () => "KP : KPMVCWebAPIs : DateTimeNow : " + currentDate);


app.Run();
