namespace PartSearchAPI.Controllers
{
    public class PaginationModel
    {
        public int CurrentPage { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 5;
    }
}
