using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Champion : IComparable<Champion>
{

    public string champName;
    public int champCost;
    public string champAtt1;
    public string champAtt2;
    public string champAtt3;
    public Champion(string newChampName, int newChampCost, string newChampAtt1, string newChampAtt2, string newChampAtt3)
    {
        champName = newChampName;
        champCost = newChampCost;
        champAtt1 = newChampAtt1;
        champAtt2 = newChampAtt2;
        champAtt3 = newChampAtt3;
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
