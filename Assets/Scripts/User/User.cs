using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

[System.Serializable]
public class User
{
    public string name = "Test";
    public string username = "test";
    public List<PetProfile> pets = new();
    public List<SportEvent> events = new();
}
