namespace PartSearchAPI.Repository
{
    public interface IPartSearchRepository
    {
        Task<(List<Database_Model.Part> Parts, int TotalCount)> SearchyParts(
            string PartNumber,
            int skip,
            int take,
            CancellationToken ct = default);
    }
}
