using System.Data;

namespace KanbanServer.Models.Config
{
    public class ServiceConfiguration
    {
        public User CurrentUser { get; set; }

        public IDbTransaction Transaction { get; set; }

    }
}
