using PartSearchAPI.View_Model;
using PartSearchAPI.Repository;

namespace PartSearchAPI.Service
{
    public class PartSearchService : IPartSearchService
    {
        private readonly IPartSearchRepository _partSearchRepository;
        public async Task<(List<PartSearchViewModel> Parts, int TotalCount)> Search(string PartNumber, int skip, int take, CancellationToken ct = default)
        {
            var (parts, totalCount) = await _partSearchRepository.SearchyParts(PartNumber, skip, take, ct);

            var partSearchViewModel = parts.Select(p => PartSearchMapper.MapDatabaseModelToViewModel(p)).ToList();
            return (partSearchViewModel, totalCount);
        }
    }
}
