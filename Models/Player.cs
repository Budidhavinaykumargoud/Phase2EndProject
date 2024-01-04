namespace Phase2EndProject.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; } = null!;

        public string PlayerType { get; set; } = null!;

        public int? PlayerTeam { get; set; }

        public virtual Team1 PlayerTeamNavigation { get; set; }
    }
}
