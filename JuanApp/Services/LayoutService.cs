using JuanApp.Data;

namespace JuanApp.Services
{
    public class LayoutService(JuanAppDbContext _context)
    {
        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(x => x.Key, x => x.Value.ToString());
        }
    }
}
