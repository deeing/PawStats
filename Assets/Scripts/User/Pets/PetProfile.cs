using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PetProfile
{
    public string callName;
    public string registrationName;
    public string description;
    public string gender;
    public bool isNeutered;
    public int age;
    public DateTime birthday;
    public float heightInInches;
    public List<Title> titlesEarned;
    public List<Organization> registeredOrganizations;
    public List<RegistrationNumber> registrationNumbers;
    public List<Goal> goals;
}
