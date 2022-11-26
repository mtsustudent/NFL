namespace NFLTeams.Models
{
    public class TeamDetailViewModel
    {
        public string ActiveConf { get; set; } = "all";
        public string ActiveDiv { get; set; } = "all";
        public Team Team { get; set; } = new Team();

    }
}
