

using LibraryManagement.Application;
using LibraryManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookRepository;

    public BookController(IBookService bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetBookAsync()
    {
        return Ok(await _bookRepository.GetBookAsync());
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetBookAsync(int id)
    {
        return Ok(await _bookRepository.GetBookAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> CreateBookAsync([FromBody] Book book)
    {
        return Ok(await _bookRepository.CreateBookAsync(book));
    }

    [HttpPut]
    public async Task<IActionResult> CreateBookAsync(int id, [FromBody] Book book)
    {
        return Ok(await _bookRepository.UpdateBookAsync(id, book));
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveBookAsync(int id)
    {
        return Ok(await _bookRepository.RemoveBookAsync(id));
    }
}