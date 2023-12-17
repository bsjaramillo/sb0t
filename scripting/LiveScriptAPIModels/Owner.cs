using Newtonsoft.Json;
using System;

public class Owner
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("login_name")]
    public string LoginName { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("is_admin")]
    public bool IsAdmin { get; set; }

    [JsonProperty("last_login")]
    public DateTime LastLogin { get; set; }

    [JsonProperty("created")]
    public DateTime Created { get; set; }

    [JsonProperty("restricted")]
    public bool Restricted { get; set; }

    [JsonProperty("active")]
    public bool Active { get; set; }

    [JsonProperty("prohibit_login")]
    public bool ProhibitLogin { get; set; }

    [JsonProperty("location")]
    public string Location { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("visibility")]
    public string Visibility { get; set; }

    [JsonProperty("followers_count")]
    public int FollowersCount { get; set; }

    [JsonProperty("following_count")]
    public int FollowingCount { get; set; }

    [JsonProperty("starred_repos_count")]
    public int StarredReposCount { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }
}
