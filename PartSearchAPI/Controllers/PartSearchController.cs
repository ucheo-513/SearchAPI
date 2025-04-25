using Microsoft.AspNetCore.Mvc;
using PartSearchAPI.Service;
using PartSearchAPI.View_Model;


namespace PartSearchAPI.Controllers
{
    public class PartSearchController : Controller
    {
        private readonly IPartSearchService _partSearchService;

        public PartSearchController(IPartSearchService partSearchService)
        {
            _partSearchService = partSearchService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Search([FromForm] SearchViewModelFormData model, [FromQuery] PaginationModel pagination, CancellationToken ct = default)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var mappedModel = PartSearchMapper.MapFormDataToViewModel(model);

                
                int skip = (pagination.CurrentPage - 1) * pagination.ItemsPerPage;
                int take = pagination.ItemsPerPage;

                var (result, totalCount) = await _partSearchService.Search(mappedModel.PartNumber, skip, take, ct);


                if (result == null)
                {
                    ModelState.AddModelError("", "Failed to search parts.");
                    return BadRequest(ModelState);
                }

                return Ok(new
                {
                    Parts = result,
                    TotalCount = totalCount,
                    CurrentPage = pagination.CurrentPage,
                    PageSize = pagination.ItemsPerPage,
                    TotalPages = (int)Math.Ceiling((double)totalCount / pagination.ItemsPerPage)
                });
            }

            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "There was an error processing your request.");
            }
        }        
    }
}
