namespace JuanApp.Services.Interfaces
{
    public interface IBlogService
    {
        Task<string?> GetAllAsync();
        Task<string?> GetByIdAsync(int id);
    }
}
