using SearchAndRescue.Search.Contracts.Services;
using SearchAndRescue.Search.Dtos;

namespace SearchAndRescue.Search.Services
{
    public static class SearchServiceFactory
    {
        private static readonly Dictionary<string, Type> _serviceMap = new()
        {
            { "entities", typeof(ISearchResponseService<EntitiesSearchResult>) },
            { "products", typeof(ISearchResponseService<ProductsSearchResult>) }
        };

        public static object ExecuteSearch(string identifier, IServiceProvider serviceProvider)
        {
            var serviceType = _serviceMap[identifier];

            object? result = null;
            var service = serviceProvider.GetService(serviceType);

            // Use reflection to invoke the SearchAsync method
            var methodInfo = service.GetType().GetMethod("Execute");
            if (methodInfo != null)
            {
                result = methodInfo.Invoke(service, null);
            }
            return result;
        }
    }

}
