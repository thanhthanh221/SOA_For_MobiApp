namespace CatchingRedis.Services
{
    public interface IReposeCacheService
    {
        Task SetCacheReponseAsync(string cacheKey, object response, TimeSpan timeOut);
        Task<string> GetCacheReponseAsync(string cacheKey);
        Task<List<string>> GetAllCacheReponseAsync(string partern);
        Task RemoveCacheResponseAsync(string partern);
    }
}
