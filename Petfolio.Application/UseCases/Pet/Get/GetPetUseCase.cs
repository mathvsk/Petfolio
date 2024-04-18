using Petfolio.Communication.Enum;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Get;
public class GetPetUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        { 
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Rex",
                    Pet = PetEum.DOG
                },
                new ResponseShortPetJson
                {
                    Id = 2,
                    Name = "Mia",
                    Pet = PetEum.CAT
                }
            }
        };
    }
}
