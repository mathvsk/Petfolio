using Petfolio.Communication.Requests;
using System.Diagnostics;

namespace Petfolio.Application.UseCases.Pet.Update;
public class UpdatePetUseCase
{
    public void Execute(int id, RequestPetJson request)
    {
        Debug.WriteLine($"Pet {id} updated with name {request.Name}");
    }
}
