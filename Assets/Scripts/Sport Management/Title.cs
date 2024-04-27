using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Title", menuName = "Sport Management/Title")]  
public class Title : SportManagement
{
    public string abbreviation;
    public Sport sport;
    public float points;
    public int qualifiers;
    public int majors;
    public List<Title> requiredTitles;
    public TitleType titleType = TitleType.Suffix;
}
