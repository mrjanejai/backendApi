using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Entities.HIS;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IHisService
    {
        Task OvstSyncAsync<T>(DbSet<T> sourceTable, DbSet<T> targetTable, DateTime startDate, DateTime endDate, string KeyId, string WhereKey)
            where T : class;

        Task OpItemrecceSyncAsync<T>(DbSet<T> sourceTable, DbSet<T> targetTable, DateTime startDate, DateTime endDate, string KeyId, string WhereKey)
            where T : class;

        Task SyncHisData(DateTime startDate, DateTime endDate, string pRoom);

    }

    public class HisService : IHisService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;
        private readonly IMapper _mapper;

        public HisService(DataContext dataContext, HisContext hisContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
            _mapper = mapper;
        }

        public async Task SyncHisData(DateTime startDate, DateTime endDate, string pRoom)
        {
            // Call the stored procedure SyncHisData using _dataContext
            _dataContext.Database.SetCommandTimeout(300);

            await _dataContext.Database.ExecuteSqlRawAsync("CALL SyncHisData({0}, {1}, {2})", startDate, endDate,pRoom);
        }

        public async Task OvstSyncAsync<T>(DbSet<T> sourceTable, DbSet<T> targetTable, DateTime startDate, DateTime endDate, string KeyId, string WhereKey)
            where T : class
        {
            var sourceOvsts = await GetHospitalData(sourceTable, startDate, endDate, WhereKey);
            var targetOvsts = await GetProgramData(targetTable, startDate, endDate, WhereKey);

            foreach (var sourceOvst in sourceOvsts)
            {
                var sourceKeyValue = sourceOvst.GetType().GetProperty(KeyId).GetValue(sourceOvst, null).ToString();
                var targetOvst = targetOvsts.FirstOrDefault(i => i.GetType().GetProperty(KeyId).GetValue(i, null).ToString() == sourceKeyValue);

                if (targetOvst == null)
                {
                    targetOvst = _mapper.Map<T>(sourceOvst);
                    targetTable.Add(targetOvst);
                }
                else
                {
                    _mapper.Map(sourceOvst, targetOvst);
                    targetTable.Update(targetOvst);
                }
            }

            // Add new records
            var newOvsts = sourceOvsts.Where(s => !targetOvsts.Any(t => t.GetType().GetProperty(KeyId).GetValue(t, null).ToString() == s.GetType().GetProperty(KeyId).GetValue(s, null).ToString()));
            foreach (var newOvst in newOvsts)
            {
                var ovst = _mapper.Map<T>(newOvst);
                targetTable.Add(ovst);
            }

            await _dataContext.SaveChangesAsync();
        }

        public async Task OpItemrecceSyncAsync<T>(DbSet<T> sourceTable, DbSet<T> targetTable, DateTime startDate, DateTime endDate, string KeyId, string WhereKey)
            where T : class
        {
            var sourceOvsts = await GetHospitalData(sourceTable, startDate, endDate, WhereKey);
            var targetOvsts = await GetProgramData(targetTable, startDate, endDate, WhereKey);

            foreach (var sourceOvst in sourceOvsts)
            {
                var sourceKeyValue = sourceOvst.GetType().GetProperty(KeyId).GetValue(sourceOvst, null).ToString();
                var targetOvst = targetOvsts.FirstOrDefault(i => i.GetType().GetProperty(KeyId).GetValue(i, null).ToString() == sourceKeyValue);

                if (targetOvst == null)
                {
                    targetOvst = _mapper.Map<T>(sourceOvst);
                    targetTable.Add(targetOvst);
                }
                else
                {
                    _mapper.Map(sourceOvst, targetOvst);
                    targetTable.Update(targetOvst);
                }
            }

            // Add new records
            var newOvsts = sourceOvsts.Where(s => !targetOvsts.Any(t => t.GetType().GetProperty(KeyId).GetValue(t, null).ToString() == s.GetType().GetProperty(KeyId).GetValue(s, null).ToString()));
            foreach (var newOvst in newOvsts)
            {
                var ovst = _mapper.Map<T>(newOvst);
                targetTable.Add(ovst);
            }

            await _dataContext.SaveChangesAsync();
        }

        private async Task<List<T>> GetHospitalData<T>(DbSet<T> sourceTable, DateTime startDate, DateTime endDate, string WhereKey)
            where T : class
        {
            return await sourceTable
                .Where(o => EF.Property<DateTime?>(o, WhereKey) >= startDate && EF.Property<DateTime?>(o, WhereKey) <= endDate)
                .AsNoTracking()
                .ToListAsync();
        }

        private async Task<List<T>> GetProgramData<T>(DbSet<T> targetTable, DateTime startDate, DateTime endDate, string WhereKey)
            where T : class
        {
            return await targetTable
                .Where(o => EF.Property<DateTime?>(o, WhereKey) >= startDate && EF.Property<DateTime?>(o, WhereKey) <= endDate)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
