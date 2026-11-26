namespace PcShop.Services.Builds;

using Dtos.Builds;
using Models.Builds;
using Repositories.Builds;

public class BuildService : IBuildService
{
    private readonly IBuildRepository _builds;

    public BuildService(IBuildRepository builds)
    {
        _builds = builds;
    }

    public async Task<List<BuildDto>> GetAllAsync()
    {
        var builds = await _builds.GetAllAsync();
        return builds.Select(ToDto).ToList();
    }

    public async Task<List<BuildDto>> GetByUserAsync(Guid userId)
    {
        var builds = await _builds.GetByUserAsync(userId);
        return builds.Select(ToDto).ToList();
    }

    public async Task<BuildDto?> GetByIdAsync(Guid id)
    {
        var build = await _builds.GetByIdAsync(id);
        return build is null ? null : ToDto(build);
    }

    public async Task<BuildDto> CreateAsync(CreateBuildDto dto)
    {
        var build = new Build
        {
            UserId = dto.UserId,
            Name = dto.Name
        };

        _builds.Add(build);
        await _builds.SaveChangesAsync();

        return ToDto(build);
    }

    public async Task<BuildDto?> UpdateAsync(Guid id, UpdateBuildDto dto)
    {
        var build = await _builds.GetByIdAsync(id);
        if (build is null) return null;

        build.Name = dto.Name;

        await _builds.SaveChangesAsync();
        return ToDto(build);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var build = await _builds.GetByIdAsync(id);
        if (build is null) return false;

        _builds.Delete(build);
        await _builds.SaveChangesAsync();

        return true;
    }

    public async Task<List<BuildComponentBridgeDto>> GetComponentsAsync(Guid buildId)
    {
        var components = await _builds.GetComponentsAsync(buildId);
        return components.Select(ToDto).ToList();
    }

    private static BuildDto ToDto(Build build) => new()
    {
        Id = build.Id,
        UserId = build.UserId,
        CalculatedPrice = build.CalculatedPrice,
        Name = build.Name,
    };

    private static BuildComponentBridgeDto ToDto(BuildComponentBridge bc) => new()
    {
        BuildId = bc.BuildId,
        ComponentId = bc.ComponentId,
        Quantity = bc.Quantity,
    };

    public async Task<BuildComponentBridgeDto> AddComponentAsync(CreateBuildComponentBridgeDto dto)
    {
        var component = new BuildComponentBridge
        {
            BuildId = dto.BuildId,
            ComponentId = dto.ComponentId,
            Quantity = dto.Quantity,
        };

        _builds.AddComponent(component);
        await _builds.SaveChangesAsync();

        return ToDto(component);
    }

    public async Task<BuildComponentBridgeDto?> UpdateComponentAsync(Guid buildId, Guid componentId, UpdateBuildComponentBridgeDto dto)
    {
        var component = await _builds.GetComponentAsync(buildId, componentId);
        if (component is null) return null;

        component.Quantity = dto.Quantity;

        await _builds.SaveChangesAsync();
        return ToDto(component);
    }

    public async Task<bool> RemoveComponentAsync(Guid buildId, Guid componentId)
    {
        var component = await _builds.GetComponentAsync(buildId, componentId);
        if (component is null) return false;

        _builds.RemoveComponent(component);
        await _builds.SaveChangesAsync();

        return true;
    }
}