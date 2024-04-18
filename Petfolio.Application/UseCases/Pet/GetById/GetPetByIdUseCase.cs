using Petfolio.Communication.Enum;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetPetByIdUseCase
{
    public ResponseGetPetJson Execute(int id)
    {
        return new ResponseGetPetJson
        {
            Id = id,
            Name = "Nathan",
            Birthday = new DateTime(year: 1999 , month:4 , day: 9),
            Pet = PetEum.CAT
        };
    }
}
