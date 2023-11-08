

using LibraryManagement.Application;
using LibraryManagement.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers;

[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookRepository;
    public BookController(IBookService bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    [Route("api/books")]
    public async Task<IActionResult> GetBookAsync()
    {
        return Ok(await _bookRepository.GetBookAsync());
    }

    [HttpGet]
    [Route("api/books/{id}")]
    public async Task<IActionResult> GetBookAsync(int id)
    {
        return Ok(await _bookRepository.GetBookAsync(id));
    }

    [HttpPost]
    [Route("api/books")]
    public async Task<IActionResult> CreateBookAsync([FromBody] Book book)
    {
        return Ok(await _bookRepository.CreateBookAsync(book));
    }

    [HttpPut]
    [Route("api/books/{id}")]
    public async Task<IActionResult> CreateBookAsync(int id, [FromBody] Book book)
    {
        return Ok(await _bookRepository.UpdateBookAsync(id, book));
    }

    [HttpDelete]
    [Route("api/books/{id}")]
    public async Task<IActionResult> RemoveBookAsync(int id)
    {
        return Ok(await _bookRepository.RemoveBookAsync(id));
    }
}