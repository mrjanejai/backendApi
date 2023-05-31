namespace WebApi.Services
{
    using WebApi.Entities;
    using WebApi.Helpers;
    using WebApi.Models.KskDepartment;
    using WebApi.Authorization;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IKskdepartmentService
    {
        Task SyncAsync();
    }
    public class KskdepartmentService : IKskdepartmentService
    {
        private readonly DataContext _dataContext;
        private readonly HisContext _hisContext;

        public KskdepartmentService(DataContext dataContext, HisContext hisContext)
        {
            _dataContext = dataContext;
            _hisContext = hisContext;
        }

        public async Task SyncAsync()
        {
            var sourceKsks = await _hisContext.kskdepartment.AsNoTracking().ToListAsync();
            var targetKsks = await _dataContext.kskdepartment.AsNoTracking().ToListAsync();

            foreach (var sourceKsk in sourceKsks)
            {
                var targetKsk = targetKsks.FirstOrDefault(i => i.depcode == sourceKsk.depcode);

                if (targetKsk == null)
                {
                    var newKsk = new kskdepartment
                    {
                        depcode = sourceKsk.depcode,
                        department = sourceKsk.department,
                        roomno = sourceKsk.roomno,
                        doctor_code = sourceKsk.doctor_code,
                        online_time = sourceKsk.online_time,
                        on_desk = sourceKsk.on_desk,
                        spclty = sourceKsk.spclty,
                        depcode_active = sourceKsk.depcode_active,
                        department_active = sourceKsk.department_active
                        // Copy all the properties here...
                    };
                    _dataContext.kskdepartment.Add(newKsk);
                }
                else
                {
                    targetKsk.depcode = sourceKsk.depcode;
                    targetKsk.department = sourceKsk.department;
                    targetKsk.roomno = sourceKsk.roomno;
                    targetKsk.doctor_code = sourceKsk.doctor_code;
                    targetKsk.online_time = sourceKsk.online_time;
                    targetKsk.on_desk = sourceKsk.on_desk;
                    targetKsk.spclty = sourceKsk.spclty;
                    targetKsk.depcode_active = sourceKsk.depcode_active;
                    targetKsk.department_active = sourceKsk.department_active;
                    // Update all the properties here...
                    _dataContext.kskdepartment.Update(targetKsk);
                }
            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
