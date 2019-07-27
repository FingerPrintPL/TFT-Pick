using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DisplayChampions : MonoBehaviour
{
    public GameObject champBoxRef;
    public GameObject button;
    public GameObject menuButton;
    public GameObject moreButton;

    void Start()
    {
        name = "StartButton";
    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        ChampionBox champRef = champBoxRef.GetComponent<ChampionBox>();
        champBoxRef.GetComponent<ChampionBox>().more = false;
        StartCoroutine(champRef.DisplayChampions1(0f));
        Instantiate(menuButton);
        Instantiate(moreButton);
        SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].enabled = false;
        }
        Destroy(gameObject, 0.1f);
    }
}
