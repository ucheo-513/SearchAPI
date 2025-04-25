using Newtonsoft.Json;
using PartSearchAPI.Database_Model;
using PartSearchAPI.View_Model;

namespace PartSearchAPI.Service
{
    public static class PartSearchMapper
    {
        public enum PartStatuses
        {
            Draft = 1,
            AwaitingTechnicalReview = 2,
            AwaitingDisposition = 3,
            Approved = 4,
            Rejected = 5
        }

        /// <summary>
        /// Maps the part search database model to the view model
        /// </summary>
        /// <param name="part">Part</param>
        /// <returns>Corresponding PartSearchViewModel</returns>
        public static PartSearchViewModel MapDatabaseModelToViewModel(Part part)
        {
            PartStatuses status = (PartStatuses)part.StatusId;
            string partStatusName;

            switch (status)
            {
                case PartStatuses.Draft:
                    partStatusName = "Draft";
                    break;
                case PartStatuses.AwaitingTechnicalReview:
                    partStatusName = "Awaiting Technical Review";
                    break;
                case PartStatuses.AwaitingDisposition:
                    partStatusName = "Awaiting Disposition";
                    break;
                case PartStatuses.Approved:
                    partStatusName =  "Approved";
                    break;
                case PartStatuses.Rejected:
                    partStatusName = "Rejected";
                    break;
                default:
                    partStatusName = "Draft";
                    break;
            }


            return new PartSearchViewModel
            {
                Id = part.Id,
                Name = part.Name,
                ImageUrl = part.ImageUrl,
                PartNumber = part.PartNumber,                
                Status = partStatusName                
            };
        }

        /// <summary>
        /// Maps form data to the part search view model
        /// </summary>
        /// <param name="searchModel">SearchViewModelFormData</param>
        /// <returns>Corresponding SearchViewModel</returns>
        public static SearchViewModel MapFormDataToViewModel(SearchViewModelFormData searchModel)
        {
            var deserializedName = JsonConvert.DeserializeObject(searchModel.NameJson);
            var deserializedPartNumber = JsonConvert.DeserializeObject(searchModel.PartNumberJson);

            return new SearchViewModel
            {
                Name = deserializedName != null ? deserializedName.ToString() : "",
                PartNumber = deserializedPartNumber != null ? deserializedPartNumber.ToString() : ""
            };
        }

        public class SearchCategory
        {
            public string Value { get; set; }
            public string Label { get; set; }
            public bool IsSelected { get; set; }
        }


    }

}

