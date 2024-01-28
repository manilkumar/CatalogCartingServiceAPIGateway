using CatalogCartingServiceAPIGateway.Models.DbModels;

namespace CatalogCartingServiceAPIGateway.Data
{
    public class CatalogItemsData
    {
        public static Dictionary<string, List<CatalogItemDetails>> GetCatalogItems()
        {
            return new Dictionary<string, List<CatalogItemDetails>>()
            {
                { "Samsung", new List<CatalogItemDetails>() { new CatalogItemDetails {ItemId=1, ModelName = "S10", ModelColor = "Red" },
                new CatalogItemDetails {ItemId=1, ModelName = "A54", ModelColor = "Black" },
                new CatalogItemDetails {ItemId=1, ModelName = "M51", ModelColor = "Blue" }
                } },
                { "Motorola", new List<CatalogItemDetails>() { new CatalogItemDetails {ItemId=2, ModelName = "Edge Neo", ModelColor = "Green" },
                new CatalogItemDetails {ItemId=2, ModelName = "G40", ModelColor = "Grey" },
                new CatalogItemDetails {ItemId=2, ModelName = "Neo40", ModelColor = "Red" }
                } },
                { "Iphone", new List<CatalogItemDetails>() { new CatalogItemDetails {ItemId=3, ModelName = "13", ModelColor = "Red" },
                new CatalogItemDetails {ItemId=3, ModelName = "14", ModelColor = "Blue" },
                new CatalogItemDetails {ItemId=3, ModelName = "15", ModelColor = "Silver" }
                } }
            };

        }

    }
}
