using MassTransit;
using ConsumerApi.Consumers;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar MassTransit
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<TextMessageConsumer>();
    x.AddConsumer<ChatMessageConsumer>();

    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });

        // cfg.ReceiveEndpoint("text-message-queue", e =>
        // {
        //     e.ConfigureConsumer<TextMessageConsumer>(context);
        // });

        cfg.ReceiveEndpoint("chat-message-queue", e =>
        {
            e.ConfigureConsumer<ChatMessageConsumer>(context);
        });
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
