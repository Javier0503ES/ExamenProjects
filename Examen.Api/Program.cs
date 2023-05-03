using Examen.Api.Data;
using Examen.Entities.DbEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.Adds
builder.Services.AddDbContext<ExamenDbContext>();
// Add services to the container.

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/api/GetUserValid", async (string userName, string password, ExamenDbContext dbContext) =>
{
    Usuario x = await dbContext.TblUsuarios.Where(q => q.Login.ToUpper().Equals(userName.ToUpper())).FirstOrDefaultAsync();
    return x != null ? Results.Ok(x) : Results.NotFound();
}).Produces<Usuario>();




app.MapGet("/api/GetExamen", async (int idUser, ExamenDbContext dbContext) =>
{
    var x = await dbContext.TblUsuarios.ToListAsync();

    return Results.Ok(x);
}).Produces<IEnumerable<Usuario>>();

//record BitarocaModel(int idUsuario, int accion,string descripcion );
app.MapPost("/api/AddItemBitacora", async (Bitacora bitacora, ExamenDbContext dbContext) =>
{
    dbContext.TblBitacora.Add(new Bitacora
    {
        IdAccion = bitacora.IdAccion,
        IdUsuario = bitacora.IdUsuario,
        Observacion = bitacora.Observacion
    });
    await dbContext.SaveChangesAsync();

    return Results.Ok();
}).Produces(StatusCodes.Status200OK);


app.Run();

