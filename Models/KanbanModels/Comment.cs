using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanServer.Models.KanbanModels
{
    public class Comment
    {

        public long Id { get; set; }

        public string Content { get; set; }

        public KanbanTask Task { get; set; }


        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
