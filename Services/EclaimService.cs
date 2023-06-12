using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities.eclaim;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IEclaimService
    {
        Task<List<eclaim>> UploadExcel(IFormFile file);
        Task<eclaim> GetEclaimByKey(string eclaimno, string cid);
        Task UpdateEclaim(eclaim updatedEclaim);
        Task DeleteEclaim(eclaim eclaim);
    }

    public class EclaimService : IEclaimService
    {
        private readonly DataContext _dataContext;

        public EclaimService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<eclaim>> UploadExcel(IFormFile file)
        {
            // Read the Excel file
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            using var package = new ExcelPackage(stream);

            var worksheet = package.Workbook.Worksheets.FirstOrDefault();
            if (worksheet == null)
                throw new ArgumentException("Invalid Excel file");

            var rows = worksheet.Dimension.Rows;
            var claims = new List<eclaim>();

            // Process each row in the Excel file
            for (var row = 2; row <= rows; row++) // Assuming the first row is the header row
            {
                var claim = new eclaim
                {
                    key = new eclaimKey
                    {
                        eclaimno = worksheet.Cells[row, 1].Value?.ToString(),
                        cid = worksheet.Cells[row, 3].Value?.ToString()
                    },
                    pttype = worksheet.Cells[row, 2].Value?.ToString(),
                    fname = worksheet.Cells[row, 4].Value?.ToString(),
                    hn = worksheet.Cells[row, 5].Value?.ToString(),
                    an = worksheet.Cells[row, 6].Value?.ToString(),
                    vstdate = GetDateTimeValue(worksheet.Cells[row, 7].Value),
                    dcdate = GetDateTimeValue(worksheet.Cells[row, 8].Value),
                    estatus = worksheet.Cells[row, 9].Value?.ToString(),
                    staffname = worksheet.Cells[row, 10].Value?.ToString(),
                    tranid = worksheet.Cells[row, 11].Value?.ToString(),
                    rep = worksheet.Cells[row, 12].Value?.ToString(),
                    details = worksheet.Cells[row, 13].Value?.ToString(),
                    chanel = worksheet.Cells[row, 14].Value?.ToString()
                };

                claims.Add(claim);
            }

            // Save the claims to the database
            await _dataContext.eclaim.AddRangeAsync(claims);
            await _dataContext.SaveChangesAsync();

            return claims;
        }


        public async Task<eclaim> GetEclaimByKey(string eclaimno, string cid)
        {
            return await _dataContext.eclaim.FindAsync(eclaimno, cid);
        }

        public async Task UpdateEclaim(eclaim updatedEclaim)
        {
            _dataContext.eclaim.Update(updatedEclaim);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteEclaim(eclaim eclaim)
        {
            _dataContext.eclaim.Remove(eclaim);
            await _dataContext.SaveChangesAsync();
        }

        private DateTime? GetDateTimeValue(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return null;

            if (DateTime.TryParse(value.ToString(), out var dateTimeValue))
                return dateTimeValue;

            return null;
        }
    }
}
