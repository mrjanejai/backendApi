using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.ErOperCodes;
using WebApi.Authorization;
using AutoMapper;

namespace WebApi.Services
{
    public interface IErOperCodeService
    {
        Task SyncAsync();
    }

    public class ErOperCodeSync : IErOperCodeService 
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public ErOperCodeSync(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }
        public async Task SyncAsync()
        {
            var sourceErOperCodes = await _hisContext.er_oper_code.AsNoTracking().ToListAsync();
            var targetErOperCodes = await _dataContext.er_oper_code.AsNoTracking().ToListAsync();

            foreach (var sourceErOperCode in sourceErOperCodes)
            {
                var targetErOperCode = targetErOperCodes.FirstOrDefault(i => i.ErOperCode == sourceErOperCode.ErOperCode);

                if (targetErOperCode == null)
                {
                    var newErOperCode = new ErOperCodeE
                    {
                        ErOperCode = sourceErOperCode.ErOperCode,
                        Name = sourceErOperCode.Name,
                        Icode = sourceErOperCode.Icode,
                        Icd9cm = sourceErOperCode.Icd9cm,
                        Price = sourceErOperCode.Price,
                        Price2 = sourceErOperCode.Price2,
                        Price3 = sourceErOperCode.Price3,
                        ErOperCodeGuid = sourceErOperCode.ErOperCodeGuid,
                        ActiveStatus = sourceErOperCode.ActiveStatus,
                        HasAreaCode = sourceErOperCode.HasAreaCode,
                        Icd10tm = sourceErOperCode.Icd10tm,
                        ExportProced = sourceErOperCode.ExportProced,
                        HosGuid = sourceErOperCode.HosGuid,
                        DurationMinute = sourceErOperCode.DurationMinute,
                        ErOperCodeTypeId = sourceErOperCode.ErOperCodeTypeId,
                        SearchKeyword = sourceErOperCode.SearchKeyword,
                        UseOpiPrice = sourceErOperCode.UseOpiPrice,
                        IsInvestigation = sourceErOperCode.IsInvestigation
                        // Copy all the properties here...
                    };
                    _dataContext.er_oper_code.Add(newErOperCode);
                }
                else
                {
                    targetErOperCode.Name = sourceErOperCode.Name;
                    targetErOperCode.Icode = sourceErOperCode.Icode;
                    targetErOperCode.Icd9cm = sourceErOperCode.Icd9cm;
                    targetErOperCode.Price = sourceErOperCode.Price;
                    targetErOperCode.Price2 = sourceErOperCode.Price2;
                    targetErOperCode.Price3 = sourceErOperCode.Price3;
                    targetErOperCode.ErOperCodeGuid = sourceErOperCode.ErOperCodeGuid;
                    targetErOperCode.ActiveStatus = sourceErOperCode.ActiveStatus;
                    targetErOperCode.HasAreaCode = sourceErOperCode.HasAreaCode;
                    targetErOperCode.Icd10tm = sourceErOperCode.Icd10tm;
                    targetErOperCode.ExportProced = sourceErOperCode.ExportProced;
                    targetErOperCode.HosGuid = sourceErOperCode.HosGuid;
                    targetErOperCode.DurationMinute = sourceErOperCode.DurationMinute;
                    targetErOperCode.ErOperCodeTypeId = sourceErOperCode.ErOperCodeTypeId;
                    targetErOperCode.SearchKeyword = sourceErOperCode.SearchKeyword;
                    targetErOperCode.UseOpiPrice = sourceErOperCode.UseOpiPrice;
                    targetErOperCode.IsInvestigation = sourceErOperCode.IsInvestigation;
                    // Update all the properties here...
                    _dataContext.er_oper_code.Update(targetErOperCode);
                }
            }
            await _dataContext.SaveChangesAsync();
        }
    }
}
