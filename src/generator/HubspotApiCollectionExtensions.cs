using System.Linq;

namespace xtellurian.HubSpot.Generator
{
    public static class HubspotApiCollectionExtensions
    {
        public static Result GetResultByName(this HubspotApiCollection apiCollection, string name)
        {
            return apiCollection.Results.FirstOrDefault(_ => _.Name == name);
        }
        
        public static Result GetFeature(this HubspotApiCollection apiCollection, string name)
        {
            return apiCollection.Results.FirstOrDefault(_ => _.Name == name);
        }
    }
}