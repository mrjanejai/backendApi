namespace WebApi.Services
{
    using WebApi.Entities;
    using WebApi.Helpers;
    using WebApi.Models.Products;
    using WebApi.Authorization;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IIcdSyncService
    {
        Task SyncAsync();
    }

    public class IcdSyncService : IIcdSyncService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public IcdSyncService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        public async Task SyncAsync()
        {
            var sourceIcds = await _hisContext.icd101.AsNoTracking().ToListAsync();
            var targetIcds = await _dataContext.Icd101.AsNoTracking().ToListAsync();

            foreach (var sourceIcd in sourceIcds)
            {
                var targetIcd = targetIcds.FirstOrDefault(i => i.Code == sourceIcd.Code);

                if (targetIcd == null)
                {
                    var newIcd = new Icd101
                    {
                        Code = sourceIcd.Code,
                        Name = sourceIcd.Name,
                        Spclty = sourceIcd.Spclty,
                        Tname = sourceIcd.Tname,
                        Code3 = sourceIcd.Code3,
                        Code4 = sourceIcd.Code4,
                        Code5 = sourceIcd.Code5,
                        Sex = sourceIcd.Sex,
                        IpdValid = sourceIcd.IpdValid,
                        Icd10compat = sourceIcd.Icd10compat,
                        Icd10tmcompat = sourceIcd.Icd10tmcompat,
                        ActiveStatus = sourceIcd.ActiveStatus,
                        HosGuid = sourceIcd.HosGuid,
                        HosGuidExt = sourceIcd.HosGuidExt
                        // Copy all the properties here...
                    };
                    _dataContext.Icd101.Add(newIcd);
                }
                else
                {
                    targetIcd.Name = sourceIcd.Name;
                    targetIcd.Spclty = sourceIcd.Spclty;
                    targetIcd.Tname = sourceIcd.Tname;
                    targetIcd.Code3 = sourceIcd.Code3;
                    targetIcd.Code4 = sourceIcd.Code4;
                    targetIcd.Code5 = sourceIcd.Code5;
                    targetIcd.Sex = sourceIcd.Sex;
                    targetIcd.IpdValid = sourceIcd.IpdValid;
                    targetIcd.Icd10compat = sourceIcd.Icd10compat;
                    targetIcd.Icd10tmcompat = sourceIcd.Icd10tmcompat;
                    targetIcd.ActiveStatus = sourceIcd.ActiveStatus;
                    targetIcd.HosGuid = sourceIcd.HosGuid;
                    targetIcd.HosGuidExt = sourceIcd.HosGuidExt;
                    // Update all the properties here...
                    _dataContext.Icd101.Update(targetIcd);
                }
            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
