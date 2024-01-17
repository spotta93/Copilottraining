// Controllers/InvoicesController.cs
[ApiController]
[Route("[controller]")]
public class InvoicesController : ControllerBase
{
    private readonly DatabaseContext _context;

    public InvoicesController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Invoices>> GetInvoices()
    {
        using (IDbConnection conn = _context.Connection)
        {
            string sQuery = "SELECT BillingCountry, InvoiceCount FROM Invoices";
            conn.Open();
            var result = await conn.QueryAsync<Invoices>(sQuery);
            return result;
        }
    }
}