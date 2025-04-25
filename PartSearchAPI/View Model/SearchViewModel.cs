namespace PartSearchAPI.View_Model
{
    public class SearchViewModel
    {
        ///<summary>
        /// Part Number
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// Name of the part
        /// </summary>
        public string Name { get; set; }
        
    }

    /// <summary>
    /// Search view model from data
    /// </summary>
    public class SearchViewModelFormData : SearchViewModel
    {
        /// <summary>
        /// Search form data Part number
        /// </summary>
        public string PartNumberJson { get; set; }

        /// <summary>
        /// Search form data Name
        /// </summary>
        public string NameJson { get; set; }
    }
}
