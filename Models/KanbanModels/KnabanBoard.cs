using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanServer.Models.KanbanModels
{
    [Table("kanban_board")]
    public class KanbanBoard
    {

        public KanbanBoard() { }
        public KanbanBoard(string name,string description) {
            this.Name = name;
            this.Description= description;
            this.Columns = [];
            this.Users = [];
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<KanbanColumn> Columns { get; set; }

        public List<User> Users { get; set; }



    }
}
