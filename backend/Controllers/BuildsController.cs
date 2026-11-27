using Microsoft.AspNetCore.Mvc;
using PcShop.Data;
using PcShop.Dtos.Builds;
using PcShop.Services.Builds;

namespace PcShop.Controllers;

[ApiController]
[Route("api/builds")]
public class BuildsController : ControllerBase
{
    private readonly IBuildService _build;

    public BuildsController(IBuildService build)
    {
        _build = build;
    }

    [HttpGet]
    public async Task<ActionResult<List<BuildDto>>> GetAll() =>
        Ok(await _build.GetAllAsync());

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<BuildDto>> GetById(Guid id)
    {
        var build = await _build.GetByIdAsync(id);
        return build is null ? NotFound() : Ok(build);
    }

    [HttpPost]
    public async Task<ActionResult> Create(CreateBuildDto dto)
    {
        var created = await _build.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateBuildDto dto) =>
        await _build.UpdateAsync(id, dto) is null ? NotFound() : NoContent();

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id) =>
        await _build.DeleteAsync(id) ? NoContent() : NotFound();

}
