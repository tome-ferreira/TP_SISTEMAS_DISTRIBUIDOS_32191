using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using TP_SISTEMAS_DISTRIBUIDOS_V5.Entities;
namespace TP_SISTEMAS_DISTRIBUIDOS_V5;

public static class WorkerEndpoints
{
    public static void MapWorkerEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Worker").WithTags(nameof(Worker));

        group.MapGet("/", async (ApplicationDbContext db) =>
        {
            return await db.Worker.ToListAsync();
        })
        .WithName("GetAllWorkers")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Worker>, NotFound>> (int id, ApplicationDbContext db) =>
        {
            return await db.Worker.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Worker model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetWorkerById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Worker worker, ApplicationDbContext db) =>
        {
            var affected = await db.Worker
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, worker.Id)
                    .SetProperty(m => m.Name, worker.Name)
                    .SetProperty(m => m.Surname, worker.Surname)
                    .SetProperty(m => m.Department, worker.Department)
                    .SetProperty(m => m.InternalNumber, worker.InternalNumber)
                    .SetProperty(m => m.DateOfBirth, worker.DateOfBirth)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateWorker")
        .WithOpenApi();

        group.MapPost("/", async (Worker worker, ApplicationDbContext db) =>
        {
            db.Worker.Add(worker);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Worker/{worker.Id}",worker);
        })
        .WithName("CreateWorker")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ApplicationDbContext db) =>
        {
            var affected = await db.Worker
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteWorker")
        .WithOpenApi();
    }
}
