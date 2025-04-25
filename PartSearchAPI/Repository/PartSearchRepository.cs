using Microsoft.EntityFrameworkCore;
using PartSearchAPI.Database_Model;

namespace PartSearchAPI.Repository
{
    public class PartSearchRepository : IPartSearchRepository
    {
        protected readonly PartDBContext _dbContext;

        public PartSearchRepository(PartDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<(List<Part> Parts, int TotalCount)> SearchyParts(
             string PartNumber,
             int skip,
             int take,
             CancellationToken ct = default
        )
        {
            try
            {
                var query = _dbContext.Parts
                           .AsQueryable();            

                if (PartNumber != null && PartNumber.Any())
                {
                    query = query.Where(p => p.PartNumber != null && PartNumber.Contains(p.PartNumber));
                }

                //Total count of relevant records
                int totalCount = await query.CountAsync(ct);

                //Pagination
                var parts = await query.Skip(skip).Take(take).ToListAsync(ct);
                
                return (parts, totalCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return (new List<Part>(), 0);
            }
        }
    }
}
