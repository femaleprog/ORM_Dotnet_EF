using Microsoft.AspNetCore.Components.Routing;
using System.Text.Json.Serialization;

namespace initiation_RelationshipEF
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public Character? Character { get; set; }
        public int CharacterId { get; set; }
    }
} 
