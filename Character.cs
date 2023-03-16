using System.Text.Json.Serialization;

namespace initiation_RelationshipEF
{
    public class Character
    {
        public Character()
        {
            User = new User();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }
        public Weapon Weapon { get; set; }
        //public int WeaponId { get; set; }
        public List<Skill> Skills { get; set; }
    }
} 
