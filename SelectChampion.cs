using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChampion : MonoBehaviour
{
    private string spriteName;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnMouseUp()
    {
        spriteName = GetComponent<SpriteRenderer>().sprite.name;
        GameObject camera = GameObject.Find("Main Camera");
        ChampionsList list = camera.GetComponent<ChampionsList>();
        list.SelectedName = spriteName;
        Debug.Log(spriteName);
        GameObject[] boxToDest = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject box in boxToDest)
            Destroy(box);
        list.ChampionSelected();
    }
}
