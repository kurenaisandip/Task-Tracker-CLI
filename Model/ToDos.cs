public class ToDos
{

    public int Id { get; set; }
    public string? name { get; set; }
    public string? description { get; set; }
    public string? status { get; set; } = "todo"; // defaault status is todo
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
}
