﻿namespace ACME.LearningCenter_Platform.Profiles;

public class CreateProfileCommandFromResourceAssembler
{
    public static CreateProfileCommand ToCommandFromResource(CreateProfileResource resource)
    {
        return new CreateProfileCommand(resource.FirstName, resource.LastName,
            resource.Email,
            resource.Street, resource.Number, resource.City,
            resource.PostalCode, resource.Country, resource.PhoneNumber, resource.vehicleName);
    }
}