using KanbanServer.Dtos;
using KanbanServer.Models.KanbanModels;
using KanbanServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KanbanServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KanbanBoardController : ControllerBase
    {
        private readonly IKanbanBoardService boardService;
            
         public KanbanBoardController(IKanbanBoardService service)
        {
            this.boardService = service;
        }

        [HttpGet]
        public async Task<IEnumerable<KanbanBoard>> GetAll() {
            return await boardService.GetAllKanbanBoards();
        }

        [HttpPost]
        public async Task<KanbanBoard> Create([FromBody] KanbanBoardDto kanbanBoard) 
        {
            if (kanbanBoard == null) throw new Exception();
            return await boardService.Create(kanbanBoard);
        }


    }


}
