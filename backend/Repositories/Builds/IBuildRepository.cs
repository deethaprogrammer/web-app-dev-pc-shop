namespace PcShop.Repositories.Builds;

using Models.Builds;

public interface IBuildRepository : IRepository<Build>
{
    Task<List<Build>> GetByUserAsync(Guid userId);
    Task<BuildComponentBridge?> GetComponentAsync(Guid buildId, Guid componentId);
    Task<List<BuildComponentBridge>> GetComponentsAsync(Guid buildId);
    void AddComponent(BuildComponentBridge buildComponent);
    void UpdateComponent(Guid buildId, Guid componentId, BuildComponentBridge buildComponent);
    void RemoveComponent(BuildComponentBridge component);
}