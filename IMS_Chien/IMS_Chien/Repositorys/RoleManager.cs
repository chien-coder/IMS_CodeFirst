using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Manager;
using IMS_Chien.Context;
using IMS_Chien.Models;

namespace IMS_Chien.Repositorys
{
    public interface IRoleManager : ICommonManager<Role>
    {
        Task<ICollection<Role>?> GetRoleAsync();
    }

    public class RoleManager : CommonManager<Role>, IRoleManager
    {
        public RoleManager(ApplicationDbContext applicationDbContext) : base(new RoleRepository(applicationDbContext))
        {
            
        }

        public async Task<ICollection<Role>?> GetRoleAsync()
        {
            return await GetAllAsync();
        }
    }
}
