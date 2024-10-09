using KanbanServer.Data;
using KanbanServer.Dtos;
using KanbanServer.Models.Config;
using KanbanServer.Models.KanbanModels;
using KanbanServer.Services.Interfaces;

namespace KanbanServer.Services
{
    public class KanbanBoardService : IKanbanBoardService
    {

        private readonly ApplicationDbContext _context;
        private readonly IKanbanColumnService _columnService;

        public KanbanBoardService(ApplicationDbContext context,IKanbanColumnService service)
        {
            _context = context;
            this._columnService = service;
        }

        public async Task<KanbanBoard> Create(KanbanBoardDto kanbanBoard)
        {
            try {

                var record = await _context.KanbanBoards.AddAsync(new KanbanBoard(kanbanBoard.Name,kanbanBoard.Description));
                List<KanbanColumn> defaultColumns = await  _columnService.CreateDefaultColumns(record.Entity.Id);
                record.Entity.Columns=defaultColumns;
                await _context.SaveChangesAsync();
                return record.Entity;

            }catch(Exception e)
            {
                
                throw;
            }
        }

        public Task<IEnumerable<KanbanBoard>> GetAllKanbanBoards()
        {

            return Task.FromResult(Enumerable.Empty<KanbanBoard>());

        }

        public Task<IEnumerable<KanbanBoard>> GetKanbanBoardById(long boardId, List<string>? include)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<KanbanBoard>> ListKanabanBoards(Dictionary<string, string>? filter, List<string>? include, int limit = 10, int offset = 0)
        {
            throw new NotImplementedException();
        }
    }
}
