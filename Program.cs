using Microsoft.EntityFrameworkCore;
using QuizApp;
using QuizApp.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QuizDbContext>(options => options.UseInMemoryDatabase("QuizDb"));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<QuizDbContext>();
    Seed(dbContext);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
void Seed(QuizDbContext context)
{
    if (!context.Questions.Any())
    {
        var questions = new List<Question>
        {
            new Question
            {
                Title = "Kas yra Lietuvos sostinė",
                Type = "Radio",
                Options = "Vilnius,Kaunas,Klaipėda,Londonas",
                Answer = "Vilnius"
            },
            new Question
            {
                Title = "Kurie miestai yra Lietuvos?",
                Type = "Checkbox",
                Options = "Vilnius,Kaunas,Alytus,Varšuva",
                Answer = "Vilnius,Kaunas,Alytus"
            },
            new Question
            {
                Title = "Kaip verčiasi iš anglų kalbos žodis milk?",
                Type = "Textbox",
                Options = "",
                Answer = "pienas"
            },
            new Question
            {
                Title = "Kiek bus 10+10=?",
                Type = "Radio",
                Options = "15,30,21,20",
                Answer = "20"
            },
            new Question
            {
                Title = "Kiek bus 2+2*2=?",
                Type = "Radio",
                Options = "6,8,4,10",
                Answer = "6"
            },
            new Question
            {
                Title = "Pažymėkite virtuvės baldus",
                Type = "Checkbox",
                Options = "Lova,Šaldytuvas,Stalas,Televizorius",
                Answer = "Šaldytuvas,Stalas"
            },
            new Question
            {
                Title = "Kaip į anglų kalba verčiasi žodis medis",
                Type = "Textbox",
                Options = "",
                Answer = "tree"
            },
            new Question
            {
                Title = "Pažymėkite paukščius",
                Type = "Checkbox",
                Options = "Gandras,Šaldytuvas,Varna,Upėtakis",
                Answer = "Gandras,Varna"
            },
            new Question
            {
                Title = "Vokietijos sostinė yra?",
                Type = "Radio",
                Options = "Vilnius,Kaunas,Berlynas,Londonas",
                Answer = "Berlynas"
            },
            new Question
            {
                Title = "Pažymėkite miestą kuris prasideda L raide",
                Type = "Radio",
                Options = "Vilnius,Kaunas,Berlynas,Londonas",
                Answer = "Londonas"
            },
        };

        context.Questions.AddRange(questions);
        context.SaveChanges();
    }
}