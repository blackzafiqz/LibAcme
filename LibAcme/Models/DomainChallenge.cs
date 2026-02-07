using LibAcme.Enums;

namespace LibAcme.Models;

public class DomainChallenge
{
    public required string Domain { get; init; }
    public required ChallengeType Type{ get; init; }
}