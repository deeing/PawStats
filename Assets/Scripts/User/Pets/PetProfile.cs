using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PetProfile : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text callName;


    public void Init(string petName)
    {
        callName.text = petName;
    }
}
