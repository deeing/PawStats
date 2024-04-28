using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewPetModal : MonoBehaviour
{
    [SerializeField] 
    private TMP_InputField petName;

    [SerializeField] 
    private PetsPage petsPage;
    
    public void BTN_AddNewPet()
    {
        Pet newPet = new()
        {
            callName = petName.text
        };

        petsPage.SavePet(newPet);
    }
}
