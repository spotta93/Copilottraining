// Controllers/SalesController.cs
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Dapper;
[ApiController]
[Route("[controller]")]
public class SalesController : ControllerBase
{
    private readonly DatabaseContext _context;

    public SalesController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Sales>> GetSales()
    {
        using (IDbConnection conn = _context.Connection)
        {
            string sQuery = "select i.billingcountry, sum(total) as 'TotalSales' from invoice as i group by billingcountry order by totalsales desc ";
            conn.Open();
            var result = await conn.QueryAsync<Sales>(sQuery);
            return result;
        }
    }
}

