namespace KanbanServer.Dtos
{
    public class KanbanColumnDto
    {
        public KanbanColumnDto() { }
        public KanbanColumnDto( string title, int position,bool finalColumn, long kanbanBoardId) {
            this.Title = title;
            this.Position=position;
            this.FinalColumn=finalColumn;
            this.KanbanBoardId=kanbanBoardId;
        }
        public string Title { get; set; }

        public int Position {  get; set; }

        public bool FinalColumn { get; set; }

        public long KanbanBoardId { get; set; }
    }
}
