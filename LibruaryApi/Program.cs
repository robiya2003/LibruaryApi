
using LibruaryApi.Repositories.ClassRepository;
using LibruaryApi.Repositories.InterfaceRepository;

namespace LibruaryApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ILibruary_FloorRepository, Libruary_FloorRepository>();
            builder.Services.AddScoped<IDepartmentsRepository,DepartmentsRepository>();
            builder.Services.AddScoped<IShelfsRepository,ShelfsRepository>();
            builder.Services.AddScoped<IShelf_floorsRepository,Shelf_floorsRepository>();
            builder.Services.AddScoped<IShelf_floor_seriousRepository,Shelf_floor_seriousRepository>();

            builder.Services.AddScoped<IAuthersRepository,AuthersRepository>();
            builder.Services.AddScoped<IBooksRepository,BooksRepository>();
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
        }
    }
}
