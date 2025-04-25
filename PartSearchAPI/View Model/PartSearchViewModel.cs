namespace PartSearchAPI.View_Model
{
    public class PartSearchViewModel
    {
        /// <summary>
        /// Part Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the part
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL for part image
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Part Number
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Part's Status 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Part's Status Id 
        /// </summary>
        public int StatusId { get; set; }
    }
}

