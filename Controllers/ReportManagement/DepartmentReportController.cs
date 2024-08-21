using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.ReportManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentReportController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHost;

        public DepartmentReportController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        [AllowAnonymous]
        [HttpGet, Route("GenerateDepartmentReport")]
        public IActionResult GenerateDepartmentReport()
        {
            try
            {
                WebReport webReport = new WebReport();

                // Load the .frx report file
                webReport.Report.Load(_webHost.ContentRootPath + "\\Reports\\DepartmentReport.frx");

                // Set up the database connection with the provided connection string
                MsSqlDataConnection sqlConnection = new MsSqlDataConnection
                {
                    ConnectionString = "Server=(localdb)\\mssqllocaldb; Database=HRAndPayrollDB; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"
                };

                // Register the connection
                webReport.Report.Dictionary.Connections[0].ConnectionString = sqlConnection.ConnectionString;

                // Prepare and export the report to a MemoryStream
                webReport.Report.Prepare();
                PDFSimpleExport export = new PDFSimpleExport();
                using MemoryStream ms = new MemoryStream();
                webReport.Report.Export(export, ms);
                ms.Position = 0;

                return File(ms.ToArray(), "application/pdf", "DepartmentReport.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
