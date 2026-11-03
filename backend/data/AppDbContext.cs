using backend.models.Base;
using backend.models.Builds;
using backend.models.Components;
using backend.models.FormFactor;
using backend.models.Identity;
using backend.models.Orders;
using backend.models.Ports;

namespace backend.data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // users and orders
    public DbSet<User> Users => Set<User>();
    public DbSet<Order> Orders => Set<Order>();

    //Builds
    public DbSet<Build> Builds => Set<Build>();
    public DbSet<BuildComponentBridge> BuildComponentBridges => Set<BuildComponentBridge>();
    public DbSet<BuildBridge> BuildBridges => Set<BuildBridge>();
    public DbSet<CustomDesign> CustomDesigns => Set<CustomDesign>();

    // Components base and sub
    public DbSet<PcComponent> PcComponents => Set<PcComponent>();
    public DbSet<CPU> CPUs => Set<CPU>();
    public DbSet<GPU> GPUs => Set<GPU>();
    public DbSet<Motherboard> Motherboards => Set<Motherboard>();
    public DbSet<RAM> RAMs => Set<RAM>();
    public DbSet<Storage> Storages => Set<Storage>();
    public DbSet<Case> Cases => Set<Case>();
    public DbSet<Cooling> Coolings => Set<Cooling>();
    public DbSet<PSU> PSUs => Set<PSU>();
    public DbSet<NetworkCard> NetworkCards => Set<NetworkCard>();
    public DbSet<Sticker> Stickers => Set<Sticker>();

    //FormFactors
    public DbSet<BoardFormFactor> BoardFormFactors => Set<BoardFormFactor>();
    public DbSet<StorageFormFactor> StorageFormFactors => Set<StorageFormFactor>();

    //Ports
    public DbSet<Port> Ports => Set<Port>();
    public DbSet<PortsBridge> PortsBridges => Set<PortsBridge>();
}