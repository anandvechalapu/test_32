namespace Test32.Service
{
    using Test32.DTO;

    public interface IConfigureGitHubService
    {
        Task<ConfigureGitHubModel> GetConfigureGitHubAsync(int id);
        Task<int> CreateConfigureGitHubAsync(ConfigureGitHubModel model);
        Task<bool> UpdateConfigureGitHubAsync(ConfigureGitHubModel model);
        Task<bool> DeleteConfigureGitHubAsync(int id);
    }
}