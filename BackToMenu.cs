using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject playButton;
    void Start()
    {
        name = "MenuButton";
    }

    private void OnMouseDown()
    {
        GameObject[] boxToDest = GameObject.FindGameObjectsWithTag("Box");
        foreach (GameObject box in boxToDest)
            Destroy(box);
        GameObject[] moreToDest = GameObject.FindGameObjectsWithTag("More");
        foreach (GameObject more in moreToDest)
            Destroy(more);
        Instantiate(playButton);
        Destroy(gameObject);
    }
}
