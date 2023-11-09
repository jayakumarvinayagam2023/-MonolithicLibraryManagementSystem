

using LibraryManagement.Application;
using LibraryManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers;

[ApiController]
public class GenreController : ControllerBase
{
    private readonly IGenreService _GenreRepository;
    public GenreController(IGenreService GenreRepository)
    {
        _GenreRepository = GenreRepository;
    }

    [HttpGet]
    [Route("api/genres")]
    public async Task<IActionResult> GetGenreAsync()
    {
        return Ok(await _GenreRepository.GetGenreAsync());
    }

    [HttpGet]
    [Route("api/genres/{id}")]
    public async Task<IActionResult> GetGenreAsync(int id)
    {
        return Ok(await _GenreRepository.GetGenreAsync(id));
    }

    [HttpPost]
    [Route("api/genres")]
    public async Task<IActionResult> CreateGenreAsync([FromBody] Genre Genre)
    {
        return Ok(await _GenreRepository.CreateGenreAsync(Genre));
    }

    [HttpPut]
    [Route("api/genres/{id}")]
    public async Task<IActionResult> CreateGenreAsync(int id, [FromBody] Genre Genre)
    {
        return Ok(await _GenreRepository.UpdateGenreAsync(id, Genre));
    }

    [HttpDelete]
    [Route("api/genres/{id}")]
    public async Task<IActionResult> RemoveGenreAsync(int id)
    {
        return Ok(await _GenreRepository.RemoveGenreAsync(id));
    }
}