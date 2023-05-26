namespace WebApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebApi.Entities;
using WebApi.Helpers;

public interface IIptOperCodeService
{
    Task SyncAsync();
}
public class IptOperCodeService : IIptOperCodeService
{
    private readonly DataContext _dataContext;
    private readonly HisContext _hisContext;

    public IptOperCodeService(DataContext dataContext, HisContext hisContext)
    {
        _dataContext = dataContext;
        _hisContext = hisContext;
    }
    public async Task SyncAsync()
    {
        var sourceIcds = await _hisContext.ipt_oper_code.AsNoTracking().ToListAsync();
        var targetIcds = await _dataContext.ipt_oper_code.AsNoTracking().ToListAsync();

        foreach (var sourceIcd in sourceIcds)
        {
            var targetIpt = targetIcds.FirstOrDefault(i => i.ipt_oper_code == sourceIcd.ipt_oper_code);

            if (targetIpt == null)
            {
                var newIpt = new IptOperCodeE
                {
                    ipt_oper_code = sourceIcd.ipt_oper_code,
                    icode = sourceIcd.icode,
                    name = sourceIcd.name,
                    price = sourceIcd.price,
                    use_right = sourceIcd.use_right,
                    must_paid = sourceIcd.must_paid,
                    price2 = sourceIcd.price2,
                    price3 = sourceIcd.price3,
                    billcode = sourceIcd.billcode,
                    icd9cm = sourceIcd.icd9cm,
                    active_status = sourceIcd.active_status,
                    hos_guid = sourceIcd.hos_guid,
                    ipt_oper_code_guid = sourceIcd.ipt_oper_code_guid,
                    duration_minute = sourceIcd.duration_minute,
                    use_opi_price = sourceIcd.use_opi_price,
                    is_investigation = sourceIcd.is_investigation,
                    icd9_priority = sourceIcd.icd9_priority,
                    plot_graph = sourceIcd.plot_graph,
                    search_keyword = sourceIcd.search_keyword
                    // Copy all the properties here...
                };
                _dataContext.ipt_oper_code.Add(newIpt);
            }
            else
            {
                targetIpt.icode = sourceIcd.icode;
                targetIpt.name = sourceIcd.name;
                targetIpt.price = sourceIcd.price;
                targetIpt.use_right = sourceIcd.use_right;
                targetIpt.must_paid = sourceIcd.must_paid;
                targetIpt.price2 = sourceIcd.price2;
                targetIpt.price3 = sourceIcd.price3;
                targetIpt.billcode = sourceIcd.billcode;
                targetIpt.icd9cm = sourceIcd.icd9cm;
                targetIpt.active_status = sourceIcd.active_status;
                targetIpt.hos_guid = sourceIcd.hos_guid;
                targetIpt.ipt_oper_code_guid = sourceIcd.ipt_oper_code_guid;
                targetIpt.duration_minute = sourceIcd.duration_minute;
                targetIpt.use_opi_price = sourceIcd.use_opi_price;
                targetIpt.is_investigation = sourceIcd.is_investigation;
                targetIpt.icd9_priority = sourceIcd.icd9_priority;
                targetIpt.plot_graph = sourceIcd.plot_graph;
                targetIpt.search_keyword = sourceIcd.search_keyword;
                // Update all the properties here...
                _dataContext.ipt_oper_code.Update(targetIpt);
            }
        }

        await _dataContext.SaveChangesAsync();
    }
}

