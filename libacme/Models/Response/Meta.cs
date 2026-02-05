namespace LibAcme.Models.Response;

public record Meta
{
    public string? TermsOfService { get; init; }
    public string? Website { get; init; }
    public List<string>? CaaIdentities { get; init; }
    public bool? ExternalAccountRequired { get; init; }
}