using KanbanServer.Data;
using KanbanServer.Dtos;
using KanbanServer.Models.KanbanModels;
using KanbanServer.Services.Interfaces;

namespace KanbanServer.Services
{
    public class KanbanColumnService : IKanbanColumnService
    {

        private readonly ApplicationDbContext _context;

        public KanbanColumnService (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<KanbanColumn> Create(KanbanColumnDto column)
        {
            var record = await this.CreateOneColumn(column);
            await _context.SaveChangesAsync();
            return record;
        }

        private async Task<KanbanColumn> CreateOneColumn(KanbanColumnDto column) {
            var record = await _context.KanbanColumns.AddAsync(
                new KanbanColumn(
                    column.Title
                    , column.Position
                    , column.KanbanBoardId
                    , column.FinalColumn
                    ));
            return record.Entity;
        }

        public async Task<List<KanbanColumn>> CreateDefaultColumns(long KanbanBoardId)
        {
            List<KanbanColumn> columns = [];
            List<String> titles = ["To Do", "Doing", "Done"];
            for (int i = 0; i < 3; i++) {
                var currentColumn = await this.CreateOneColumn(new KanbanColumnDto(titles[i],i,i==2, KanbanBoardId));
                columns.Add(currentColumn);
            }
            //await _context.SaveChangesAsync();
            return columns;
        }

        public Task<IEnumerable<KanbanColumn>> GetByBoardId(string kanbanBoardId)
        {
            throw new NotImplementedException();
        }
    }
}
