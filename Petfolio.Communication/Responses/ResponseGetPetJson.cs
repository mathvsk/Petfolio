using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Responses;
public class ResponseGetPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetEum Pet { get; set; }
}
