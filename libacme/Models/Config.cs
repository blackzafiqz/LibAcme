namespace LibAcme.Models;

public record Config
{
    public string? AcmeDirectoryUrl { get; init; }
    public string? AccountKeyPath { get; init; }
    public string? AccountEmail { get; init; }
    public string[]? Domains { get; init; }
    public string? CertificatePath { get; init; }
    public string? CertificateKeyPath { get; init; }
    public string? ChallengeType { get; init; }
    public Dictionary<string, string>? ChallengeParameters { get; init; }
}