using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreButton : MonoBehaviour
{
    public GameObject championBox;
    // Start is called before the first frame update
    void Start()
    {
        name = "MoreButton";
    }
    private void OnMouseDown()
    {
        if (!championBox.GetComponent<ChampionBox>().more) championBox.GetComponent<ChampionBox>().more = true;
        else championBox.GetComponent<ChampionBox>().more = false;
        GameObject[] boxToDest = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject box in boxToDest)
            Destroy(box);
        ChampionBox champRef = championBox.GetComponent<ChampionBox>();
        StartCoroutine(champRef.DisplayChampions1(0f));
    }
}
