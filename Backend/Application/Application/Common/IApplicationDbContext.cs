using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Common;

public interface IApplicationDbContext
{
    public DbSet<User> User { get; }
}
