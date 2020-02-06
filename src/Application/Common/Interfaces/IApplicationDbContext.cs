using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Tool> Tools { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
