using KanbanServer.Dtos;
using KanbanServer.Models.KanbanModels;

namespace KanbanServer.Services.Interfaces
{
    public interface IKanbanColumnService
    {
        Task<IEnumerable<KanbanColumn>> GetByBoardId(string kanbanBoardId);
        Task<KanbanColumn> Create(KanbanColumnDto column);
       Task<List<KanbanColumn>> CreateDefaultColumns(long KanbanBoardId);
    }
}
