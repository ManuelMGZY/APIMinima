namespace APIMinima
{
    public class TodoitemDTO
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoitemDTO() { }
        public TodoitemDTO(Todo TodoItem) =>
            (Id, Name, IsComplete) = (TodoItem.Id, TodoItem.Name, TodoItem.IsComplete);
    }
}
