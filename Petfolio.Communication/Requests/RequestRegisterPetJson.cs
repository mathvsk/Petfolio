﻿using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Requests;
public class RequestRegisterPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetEum Pet { get; set;}
}
