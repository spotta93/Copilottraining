// Controllers/SalesController.cs
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
            string sQuery = "SELECT BillingCountry, TotalSales FROM Sales";
            conn.Open();
            var result = await conn.QueryAsync<Sales>(sQuery);
            return result;
        }
    }
}

