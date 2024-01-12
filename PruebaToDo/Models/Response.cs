namespace PruebaToDo.Models
{
    public class Response
    {
        public List<TaskModel> Todos { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }

}
