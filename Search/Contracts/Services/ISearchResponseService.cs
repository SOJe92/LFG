using SearchAndRescue.Search.Contracts.Dtos;
using SearchAndRescue.Search.Dtos;

namespace SearchAndRescue.Search.Contracts.Services
{
    public interface ISearchResponseService<T>
    {
        SearchResponse<T> Execute();
    }
}
