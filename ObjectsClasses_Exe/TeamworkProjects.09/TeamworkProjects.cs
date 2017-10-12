using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TeamworkProjects
{
    internal class TeamworkProjects
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var output = new StringBuilder();
            var teamsByName = new Dictionary<string, Team>();
            var teamsByCreator = new Dictionary<string, Team>();
            for (int i = 0; i < count; i++)
            {
                var data = Console.ReadLine().Split('-');
                var user = data[0];
                var teamName = data[1];
                if (TeamExists(teamName, teamsByName))
                {
                    output.Append($"Team {teamName} was already created!").Append(Environment.NewLine);
                }
                else
                {
                    if (UserHasCreatedTeam(user, teamsByCreator))
                    {
                        output.Append($"{user} cannot create another team!").Append(Environment.NewLine);
                    }
                    else
                    {
                        output.Append($"Team {teamName} has been created by {user}!").Append(Environment.NewLine);
                        var team = new Team(teamName, user);
                        teamsByName.Add(teamName, team);
                        teamsByCreator.Add(user, team);
                    }
                }
            }

            var input = Console.ReadLine();
            while (input != null && input != "end of assignment")
            {
                var data = Regex.Split(input, "->");
                var user = data[0];
                var teamName = data[1];
                if (!TeamExists(teamName, teamsByName))
                {
                    output.Append($"Team {teamName} does not exist!").Append(Environment.NewLine);
                }
                else
                {
                    if (UserHasTeam(user, teamsByName.Values))
                    {
                        output.Append($"Member {user} cannot join team {teamName}!").Append(Environment.NewLine);
                    }
                    else
                    {
                        teamsByName[teamName].Members.Add(user);
                    }
                }
                
                input = Console.ReadLine();
            }
            
            teamsByName.Values
                .Where(t => t.Members.Count > 1)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList()
                .ForEach(team =>
                {
                    output.Append(team.Name).Append(Environment.NewLine);
                    output.Append($"- {team.Creator}").Append(Environment.NewLine);
                    team.Members
                        .Where(member => member != team.Creator)
                        .OrderBy(member => member)
                        .ToList()
                        .ForEach(member => output.Append($"-- {member}").Append(Environment.NewLine));
                });
            output.Append("Teams to disband:");
            teamsByName.Values
                .Where(t => t.Members.Count == 1)
                .OrderBy(t => t.Name)
                .ToList()
                .ForEach(team => output.Append(Environment.NewLine).Append(team.Name));
            Console.Write(output);
        }

        private static bool UserHasTeam(string user, IEnumerable<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.HasMember(user))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool UserHasCreatedTeam(string user, Dictionary<string, Team> teamsByCreator)
        {
            return teamsByCreator.ContainsKey(user);
        }

        private static bool TeamExists(string name, Dictionary<string, Team> teamsByName)
        {
            return teamsByName.ContainsKey(name);
        }
    }

    internal class Team
    {
        public string Name { get; }
        public string Creator { get; }
        public HashSet<string> Members { get; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new HashSet<string>{ creator };
        }

        public bool HasMember(string user)
        {
            return Members.Contains(user);
        }
    }
}