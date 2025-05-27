using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options): DbContext(options)
{

    public DbSet<AppUser> Users => Set<AppUser>();

    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    public DbSet<Photo> Photos => Set<Photo>();

    public DbSet<Like> Likes => Set<Like>();

    public DbSet<Message> Messages => Set<Message>();

    public DbSet<Group> Groups => Set<Group>();
}
