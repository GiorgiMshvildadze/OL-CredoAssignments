namespace ToDoMigrations.Db.Entities
{
    public class ToDoEntity
    {
        public int Id { get; set; }
        public string Task {  get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
