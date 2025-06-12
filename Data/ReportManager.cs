using Microsoft.EntityFrameworkCore;

namespace SnackisApi.Data
{
    public class ReportManager
    {
        private readonly Models.MyDbContext _context;

        public ReportManager(Models.MyDbContext context)
        {
            _context = context;
        }

        public async Task AddReport(Models.Report report)
        {
            await _context.Reports.AddAsync(report);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Models.Report>> GetReports()
        {
            List<Models.Report> reports = await _context.Reports.ToListAsync();
            return reports;
        }

        public async Task RemoveReport(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            _context.Reports.Remove(report);
            await _context.SaveChangesAsync();
        }
    }
}
