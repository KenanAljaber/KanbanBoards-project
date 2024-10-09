using KanbanServer.Dtos;
using KanbanServer.Models.KanbanModels;

namespace KanbanServer.Services.Interfaces
{
    public interface IKanbanBoardService
    {
        Task<IEnumerable<KanbanBoard>> GetAllKanbanBoards();
        Task<IEnumerable<KanbanBoard>> GetKanbanBoardById(long boardId,List<String>? include);
        Task<KanbanBoard> Create(KanbanBoardDto kanbanBoard);
        Task<IEnumerable<KanbanBoard>> ListKanabanBoards(Dictionary<String, String>? filter, List<String>? include, int limit = 10, int offset=0);
    }
}
