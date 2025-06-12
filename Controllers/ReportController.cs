using Microsoft.AspNetCore.Mvc;
using SnackisApi.Data;


namespace SnackisApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ReportController : ControllerBase
    {
        private readonly ReportManager _reportManager;

        public ReportController(ReportManager reportManager)
        {
            _reportManager = reportManager;
        }

        [HttpGet]
        public async Task<List<Models.Report>> GetReport()
        {
            var reports = await _reportManager.GetReports();
            return reports;
        }


        [HttpPost]
        public async Task PostReport([FromBody] Models.Report report)
        {
            await _reportManager.AddReport(report);
        }

        [HttpDelete("{id}")]
        public async Task RemoveReport(int id)
        {
            await _reportManager.RemoveReport(id);
        }

    }
}
