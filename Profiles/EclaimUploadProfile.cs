using AutoMapper;
using OfficeOpenXml;
using WebApi.Entities.eclaim;

namespace WebApi.Profiles
{
    public class EclaimUploadProfile : Profile
    {
        public EclaimUploadProfile()
        {
            CreateMap<ExcelWorksheet, List<eclaim>>()
                .ConvertUsing((worksheet, claims, context) =>
                {
                    var rows = worksheet.Dimension.Rows;

                    for (var row = 2; row <= rows; row++)
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

                    return claims;
                });
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
