namespace WebApi.Services
{
    using Microsoft.EntityFrameworkCore;
    using WebApi.Entities;
    using WebApi.Helpers;
    public interface IPttypeService
    {
        Task SyncAsync();
    }
    public class PttypeSyncService : IPttypeService 
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public PttypeSyncService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }
        public async Task SyncAsync()
        {
            var sourceIcds = await _hisContext.pttype.AsNoTracking().ToListAsync();
            var targetIcds = await _dataContext.pttype.AsNoTracking().ToListAsync();

            foreach (var sourceIcd in sourceIcds)
            {
                var targetPttype = targetIcds.FirstOrDefault(i => i.Pttype == sourceIcd.Pttype);

                if (targetPttype == null)
                {
                    var newPttype = new pttype
                    {
                        Pttype = sourceIcd.Pttype,
                        Name = sourceIcd.Name,
                        Editmask = sourceIcd.Editmask,
                        Isuse = sourceIcd.Isuse,
                        Pcode = sourceIcd.Pcode,
                        HipdataCode = sourceIcd.HipdataCode,
                        NhsoCode = sourceIcd.NhsoCode,
                        // Copy all the properties here...
                    };
                    _dataContext.pttype.Add(newPttype);
                }
                else
                {
                    targetPttype.Name = sourceIcd.Name;
                    targetPttype.Editmask = sourceIcd.Editmask;
                    targetPttype.Isuse = sourceIcd.Isuse;
                    targetPttype.Pcode = sourceIcd.Pcode;
                    targetPttype.HipdataCode = sourceIcd.HipdataCode;
                    targetPttype.NhsoCode = sourceIcd.NhsoCode;
                    // Update all the properties here...
                    _dataContext.pttype.Update(targetPttype);
                }
            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
