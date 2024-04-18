using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Responses;
public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetEum Pet { get; set; }
}
