using Microsoft.EntityFrameworkCore;
using PasswordManagerApi.Models;

namespace PasswordManagerApi.Database;

class PasswordManagerContext : DbContext
{
    public PasswordManagerContext(DbContextOptions<PasswordManagerContext> options)
        : base(options) { }

    public DbSet<PasswordModel> Passwords => Set<PasswordModel>();

    public DbSet<User> Users => Set<User>();
}