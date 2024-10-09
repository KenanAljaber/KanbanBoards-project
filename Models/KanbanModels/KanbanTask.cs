using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanServer.Models.KanbanModels
  
{
    public class KanbanTask
    {

        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int size { get; set; }


        public long KanbanColumnId { get; set; }
        [ForeignKey("KanbanColumnId")]
        public KanbanColumn Column { get; set; }

        public List<Comment> Comments { get; set; }


        public List<User> Users { get; set; }


        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}
