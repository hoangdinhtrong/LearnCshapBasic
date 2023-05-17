namespace Collection.Demo.Models
{
    public enum Access
    {
        None,
        Admin,
        Manager
    }

    public class User
    {
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? License { get; set; }
        public virtual Access Access { get => Access.None; }
    }
}
