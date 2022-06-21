using EF.Core.Repository.Interface.Manager;
using EF.Core.Repository.Manager;
using MemberProjects_API.Data;
using MemberProjects_API.Dtos;
using MemberProjects_API.Models;

namespace MemberProjects_API.Repository
{
    public interface IMemberProjectsManager: ICommonManager<MemberProjects>
    {
        Task<ICollection<MemberProjects>?> GetAllMemberProjectsAsync();
        Task<MemberProjects?> GetMemberProjectsByIdAsync(string id);
        Task AddMemberProjectsAsync(MemberProjects memberProjects);
        Task UpdateMemberProjectsAsync(MemberProjects memberProjects);
        Task DeleteMemberProjectsAsync(MemberProjects memberProjects);
    }

    public class MemberProjectsManager: CommonManager<MemberProjects>, IMemberProjectsManager
    {
        public MemberProjectsManager(MyDbContext myDbContext): base(new MemberprojectsRepository(myDbContext))
        {
        }

        public async Task AddMemberProjectsAsync(MemberProjects memberProjects)
        {
            await AddAsync(memberProjects);
        }

        public async Task DeleteMemberProjectsAsync(MemberProjects memberProjects)
        {
            await DeleteAsync(memberProjects);
        }

        public async Task<ICollection<MemberProjects>?> GetAllMemberProjectsAsync()
            => await GetAllAsync();


        public async Task<MemberProjects?> GetMemberProjectsByIdAsync(string id)
            => await GetFirstOrDefaultAsync(mp => mp.Id == Guid.Parse(id));

        public async Task UpdateMemberProjectsAsync(MemberProjects memberProjects)
        {
            await UpdateAsync(memberProjects);
        }
    }
}
