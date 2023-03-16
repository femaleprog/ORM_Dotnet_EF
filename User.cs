namespace initiation_RelationshipEF
{
    
    public class User
    {
        public User()
        {
            Characters = new List<Character>();
        }
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public List<Character> Characters { get; set; }
    }
}