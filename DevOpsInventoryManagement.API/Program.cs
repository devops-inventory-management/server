using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.BLL.Services;
using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Fixtures;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("DevOpsInventoryManagement.API")
        )
);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IExpenseService, ExpenseService>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<IExpenseByCategoryService, ExpenseByCategoryService>();
builder.Services.AddScoped<IExpenseByCategoryRepository, ExpenseByCategoryRepository>();
builder.Services.AddScoped<IExpenseSummaryService, ExpenseSummaryService>();
builder.Services.AddScoped<IExpenseSummaryRepository, ExpenseSummaryRepository>();
builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddScoped<IPurchaseSummaryService, PurchaseSummaryService>();
builder.Services.AddScoped<IPurchaseSummaryRepository, PurchaseSummaryRepository>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<ISaleRepository, SaleRepository>();
builder.Services.AddScoped<ISaleSummaryService, SaleSummaryService>();
builder.Services.AddScoped<ISaleSummaryRepository, SaleSummaryRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<DbSeeder>();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<DbSeeder>();
    await seeder.SeedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/healthz");

app.Run();
