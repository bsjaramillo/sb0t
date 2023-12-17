using Newtonsoft.Json;
using System;

public class Repository
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("empty")]
    public bool Empty { get; set; }

    [JsonProperty("private")]
    public bool Private { get; set; }

    [JsonProperty("fork")]
    public bool Fork { get; set; }

    [JsonProperty("template")]
    public bool Template { get; set; }

    [JsonProperty("parent")]
    public object Parent { get; set; } // Adjust the type as needed based on your data

    [JsonProperty("mirror")]
    public bool Mirror { get; set; }

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("languages_url")]
    public string LanguagesUrl { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("ssh_url")]
    public string SshUrl { get; set; }

    [JsonProperty("clone_url")]
    public string CloneUrl { get; set; }

    [JsonProperty("original_url")]
    public string OriginalUrl { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("stars_count")]
    public int StarsCount { get; set; }

    [JsonProperty("forks_count")]
    public int ForksCount { get; set; }

    [JsonProperty("watchers_count")]
    public int WatchersCount { get; set; }

    [JsonProperty("open_issues_count")]
    public int OpenIssuesCount { get; set; }

    [JsonProperty("open_pr_counter")]
    public int OpenPrCounter { get; set; }

    [JsonProperty("release_counter")]
    public int ReleaseCounter { get; set; }

    [JsonProperty("default_branch")]
    public string DefaultBranch { get; set; }

    [JsonProperty("archived")]
    public bool Archived { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("archived_at")]
    public DateTime ArchivedAt { get; set; }

    [JsonProperty("permissions")]
    public Permissions Permissions { get; set; }

    [JsonProperty("has_issues")]
    public bool HasIssues { get; set; }

    [JsonProperty("internal_tracker")]
    public InternalTracker InternalTracker { get; set; } // Adjust the type as needed based on your data

    [JsonProperty("has_wiki")]
    public bool HasWiki { get; set; }

    [JsonProperty("has_pull_requests")]
    public bool HasPullRequests { get; set; }

    [JsonProperty("has_projects")]
    public bool HasProjects { get; set; }

    [JsonProperty("has_releases")]
    public bool HasReleases { get; set; }

    [JsonProperty("has_packages")]
    public bool HasPackages { get; set; }

    [JsonProperty("has_actions")]
    public bool HasActions { get; set; }

    [JsonProperty("ignore_whitespace_conflicts")]
    public bool IgnoreWhitespaceConflicts { get; set; }

    [JsonProperty("allow_merge_commits")]
    public bool AllowMergeCommits { get; set; }

    [JsonProperty("allow_rebase")]
    public bool AllowRebase { get; set; }

    [JsonProperty("allow_rebase_explicit")]
    public bool AllowRebaseExplicit { get; set; }

    [JsonProperty("allow_squash_merge")]
    public bool AllowSquashMerge { get; set; }

    [JsonProperty("allow_rebase_update")]
    public bool AllowRebaseUpdate { get; set; }

    [JsonProperty("default_delete_branch_after_merge")]
    public bool DefaultDeleteBranchAfterMerge { get; set; }

    [JsonProperty("default_merge_style")]
    public string DefaultMergeStyle { get; set; }

    [JsonProperty("default_allow_maintainer_edit")]
    public bool DefaultAllowMaintainerEdit { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("internal")]
    public bool Internal { get; set; }

    [JsonProperty("mirror_interval")]
    public string MirrorInterval { get; set; }

    [JsonProperty("mirror_updated")]
    public DateTime MirrorUpdated { get; set; }

    [JsonProperty("repo_transfer")]
    public object RepoTransfer { get; set; } // Adjust the type as needed based on your data
}