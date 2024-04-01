using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Service.Validation;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrlController : ControllerBase
    {
        private readonly IUrlService _urlService;
        private readonly Validacoes _urlValidationService;

        public UrlController(IUrlService urlServico, Validacoes urlValidationService)
        {
            _urlService = urlServico;
            _urlValidationService = urlValidationService;
        }

        [HttpPost("/api/CreateUrl")]
        [Produces("application/json")]
        public async Task<ActionResult<Url>> CreateUrl([FromBody] Url url)
        {
            if (!_urlValidationService.IsUrlValid(url.Link, out var validationErrors))
            {
                foreach (var error in validationErrors)
                {
                    ModelState.AddModelError(error.Key, error.Value);
                }

                return BadRequest(ModelState);
            }

            var savedUrl = await _urlService.AddAsync(url);
            return CreatedAtAction(nameof(GetUrlById), new { id = savedUrl.Id }, savedUrl);
        }


        [HttpDelete("/api/DeleteUrl/{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUrl(int id)
        {
            var url = await _urlService.GetByIdAsync(id);
            if (url == null)
            {
                return NotFound();
            }

            await _urlService.DeleteAsync(id);
            return Ok();
        }

        [HttpGet("/api/ListarUrls")]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Url>>> ListarUrls()
        {
            var urls = await _urlService.ListUrlsAsync();
            return Ok(urls);
        }

        [HttpGet("/api/GetUrlById/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult<Url>> GetUrlById(int id)
        {
            var url = await _urlService.GetByIdAsync(id);
            if (url == null)
            {
                return NotFound();
            }
            return Ok(url);
        }

        [HttpPut("/api/UpdateUrl/{id}")]
        public async Task<IActionResult> UpdateUrl(int id, [FromBody] Url url)
        {
            var existingUrl = await _urlService.GetByIdAsync(id);
            if (existingUrl == null)
            {
                return NotFound();
            }

            if (!_urlValidationService.IsUrlValid(url.Link, out var validationErrors))
            {
                foreach (var error in validationErrors)
                {
                    ModelState.AddModelError(error.Key, error.Value);
                }

                return BadRequest(ModelState);
            }


            existingUrl.Link = url.Link;

            await _urlService.UpdateAsync(existingUrl);

            return Ok();
        }



    }
}
