using PartSearchAPI.View_Model;

namespace PartSearchAPI.Service
{
    public interface IPartSearchService
    {
        Task<(List<PartSearchViewModel>Parts, int TotalCount)> Search(
            string PartNumber,
            int skip,
            int take,
            CancellationToken ct = default
        );
    }
}
