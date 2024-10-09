using KanbanServer.Models.KanbanModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanServer.Models
{
    public class User
    {

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string lastName { get; set; }

        public string Email { get; set; }

        [NotMapped]
        public string FullName { get; set; }

        public string Password { get; set; }

        public string? PhotoUrl { get; set; }

        public List<KanbanBoard> Boards { get; set; }

        public List<KanbanTask> Tasks { get; set; }

        public List<Comment> Comments { get; set; }

        public User() {
            this.FullName = this.FirstName + " " + this.lastName;
        }
    }
}
