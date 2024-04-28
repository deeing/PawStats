using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsPage : MonoBehaviour
{
    [SerializeField] 
    private Transform petProfilesContainer;

    [SerializeField] 
    private GameObject petProfilePrefab;
    
    private void Awake()
    {
        SetupPetProfiles();
    }

    private void SetupPetProfiles()
    {
        List<Pet> pets = SaveData.GetPets(SaveData.TEST_USER);

        foreach (Pet pet in pets)
        {
            GameObject petObj = Instantiate(petProfilePrefab, petProfilesContainer);
            PetProfile petProfile = petObj.GetComponent<PetProfile>();
            petProfile.Init(pet.callName);
        }
    }

    public void SavePet(Pet newPet)
    {
        SaveData.AddPet(SaveData.TEST_USER, newPet);
    }
}
