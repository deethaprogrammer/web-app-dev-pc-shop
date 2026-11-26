namespace PcShop.Repositories.Builds;

using Data;
using Models.Builds;
using Microsoft.EntityFrameworkCore;

public class BuildRepository : Repository<Build>, IBuildRepository
{
    private readonly AppDbContext _context;
    public BuildRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Build>> GetByUserAsync(Guid userId)
        => await _context.Builds
            .Where(b => b.UserId == userId)
            .ToListAsync();

    public async Task<BuildComponentBridge?> GetComponentAsync(Guid buildId, Guid componentId)
        => await _context.BuildComponentBridges
            .FirstOrDefaultAsync(bc => bc.BuildId == buildId && bc.ComponentId == componentId);

    public async Task<List<BuildComponentBridge>> GetComponentsAsync(Guid buildId)
        => await _context.BuildComponentBridges
            .Where(bc => bc.BuildId == buildId)
            .ToListAsync();

    public void AddComponent(BuildComponentBridge buildComponent)
        => _context.BuildComponentBridges.Add(buildComponent);

    public void UpdateComponent(Guid buildId, Guid componentId, BuildComponentBridge buildComponent)
        => _context.BuildComponentBridges.Update(buildComponent);

    public void RemoveComponent(BuildComponentBridge component)
        => _context.BuildComponentBridges.Remove(component);
}