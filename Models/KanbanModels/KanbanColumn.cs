using System.ComponentModel.DataAnnotations.Schema;


namespace KanbanServer.Models.KanbanModels
{
    [Table("kanban_column")]
    public class KanbanColumn
    {

        public KanbanColumn() { }
        public KanbanColumn(string title,int position,long kanbanBoardId,bool finalColumn) {
                
            Title = title;
            Position = position;
            this.KanbanBoardId=kanbanBoardId;
            this.FinalColumn = finalColumn;
            this.color = "#ffff";

        }


        public long Id { get; set; }

        public string Title { get; set; }

        public int Position { get; set; }

        [ForeignKey("KanbanBoardId")]
        public KanbanBoard Board { get; set; }

        public long KanbanBoardId { get; set; }

        public List<KanbanTask> Tasks { get; set; }

        public bool FinalColumn { get; set; }

        public string color { get; set; }
    }
}
