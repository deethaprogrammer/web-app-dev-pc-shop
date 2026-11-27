namespace PcShop.Services.Builds;

using Dtos.Builds;

public interface IBuildService
{
    Task<List<BuildDto>> GetAllAsync();
    Task<List<BuildDto>> GetByUserAsync(Guid userId);
    Task<BuildDto?> GetByIdAsync(Guid id);
    Task<BuildDto> CreateAsync(CreateBuildDto dto);
    Task<BuildDto?> UpdateAsync(Guid id, UpdateBuildDto dto);
    Task<bool> DeleteAsync(Guid id);

    Task<List<BuildComponentBridgeDto>> GetComponentsAsync(Guid buildId);
    Task<BuildComponentBridgeDto> AddComponentAsync(CreateBuildComponentBridgeDto dto);
    Task<BuildComponentBridgeDto?> UpdateComponentAsync(Guid buildId, Guid componentId, UpdateBuildComponentBridgeDto dto);
    Task<bool> RemoveComponentAsync(Guid buildId, Guid componentId);
}
