using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponsePetJson Execute(RequestPetJson request)
    {
        return new ResponsePetJson
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
