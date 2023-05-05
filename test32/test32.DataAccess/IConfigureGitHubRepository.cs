using Test32.DTO;

namespace Test32.Service
{
    public interface IConfigureGitHubRepository
    {
        Task<ConfigureGitHubModel> GetConfigureGitHubAsync(int id);
        Task<int> CreateConfigureGitHubAsync(ConfigureGitHubModel model);
        Task<bool> UpdateConfigureGitHubAsync(ConfigureGitHubModel model);
        Task<bool> DeleteConfigureGitHubAsync(int id);
    }
}