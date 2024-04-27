using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Sport", menuName = "Sport Management/Sport")]  
public class Sport : SportManagement
{
   public List<Title> titles;
   public Organization organization;
}
