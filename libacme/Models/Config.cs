namespace LibAcme.Models;

public record Config
{
    public string? AcmeDirectoryUrl { get; init; }
    public string? AccountEmail { get; init; }
    public List<DomainChallenge>? DomainChallenges { get; init; }
    public string? AccountKeyPath { get; init; }
} 