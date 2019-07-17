using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Champion : IComparable<Champion>
{

    public string champName;
    public int champCost;
    public string champOrigin;
    public string champOrigin2;
    public string champClass;
    public string champClass2;
    public Champion(string newChampName, int newChampCost, string newChampOrigin, string newChampOrigin2, string newChampClass, string newChampClass2)
    {
        champName = newChampName;
        champCost = newChampCost;
        champOrigin = newChampOrigin;
        champOrigin2 = newChampOrigin2;
        champClass = newChampClass;
        champClass2 = newChampClass2;
    }

    public int CompareTo(Champion other)
    {
       if (other == null)
        {
            return 1;
        }
        return champCost - other.champCost;
    }
}
