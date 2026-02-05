namespace LibAcme.Models.Response;

public record Directory
{
    public required string NewNonce { get; init; }
    public required string NewAccount { get; init; }
    public required string NewOrder { get; init; }
    public string? NewAuthz { get; init; }
    public required string RevokeCert { get; init; }
    public required string KeyChange { get; init; }
    public Meta? Meta { get; init; }
}