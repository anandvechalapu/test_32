namespace Test32
{
    public class ConfigureGitHubRepository : IConfigureGitHubRepository
    {
        public async Task<ConfigureGitHubModel> GetConfigureGitHubAsync(int id)
        {
            try
            {
                var model = await _context.ConfigureGitHubModel.FirstOrDefaultAsync(x => x.Id == id);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        public async Task<int> CreateConfigureGitHubAsync(ConfigureGitHubModel model)
        {
            try
            {
                model.Id = _context.ConfigureGitHubModel.Max(x => x.Id) + 1;
                _context.ConfigureGitHubModel.Add(model);
                await _context.SaveChangesAsync();
                return model.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        public async Task<bool> UpdateConfigureGitHubAsync(ConfigureGitHubModel model)
        {
            try
            {
                var entity = await _context.ConfigureGitHubModel.FirstOrDefaultAsync(x => x.Id == model.Id);
                entity.GitHubUsername = model.GitHubUsername;
                entity.GitHubPassword = model.GitHubPassword;
                entity.GitHubURL = model.GitHubURL;
                entity.RepositoryName = model.RepositoryName;
                entity.NoOfEntries = model.NoOfEntries;
                entity.Title = model.Title;
                entity.UserName = model.UserName;
                entity.Action = model.Action;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        public async Task<bool> DeleteConfigureGitHubAsync(int id)
        {
            try
            {
                var entity = await _context.ConfigureGitHubModel.FirstOrDefaultAsync(x => x.Id == id);
                _context.ConfigureGitHubModel.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}