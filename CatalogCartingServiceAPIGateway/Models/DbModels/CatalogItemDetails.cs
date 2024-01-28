namespace CatalogCartingServiceAPIGateway.Models.DbModels
{
    public class CatalogItemDetails
    {
        public int ItemId { get; set; }
        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public string ModelDescription { get; set; }

        public decimal ModelPrice { get; set; }

        public string ModelColor { get; set; }
    }
}
