using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsPage : MonoBehaviour
{

    public void SavePet(PetProfile newPet)
    {
        SaveData.AddPet(SaveData.TEST_USER, newPet);
    }
}
