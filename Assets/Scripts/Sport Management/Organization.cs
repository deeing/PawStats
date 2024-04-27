using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Organization", menuName = "Sport Management/Organization")]  
public class Organization : SportManagement
{
    public string abbreviation;
    public List<Sport> sports;
}
