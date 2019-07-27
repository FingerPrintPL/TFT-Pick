using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionBox : MonoBehaviour
{
    public GameObject champBox;
    Sprite mySprite;
    string spriteName;
    public GameObject box;
    public GameObject startButton;
    float x;
    float y;
    public bool more = false;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(startButton, new Vector3(0,-1f,0), Quaternion.identity);
    }

    public IEnumerator DisplayChampions1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (!more)
        {
            y = 3.37f;
            for (int i = 0; i < 36; i++) //     Displaying all Champions Icons
            {
                if (i == 0 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45) x = -1.95f;
                if (i == 5 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50) x = -1.4625f;
                if (i == 5 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50) y -= 0.88f;
                GameObject camera = GameObject.Find("Main Camera");
                ChampionsList list = camera.GetComponent<ChampionsList>();
                List<Champion> champs = list.champions;
                spriteName = champs[i].champName;
                mySprite = Resources.Load<Sprite>("ChampionsIcons/" + spriteName);
                box.GetComponent<SpriteRenderer>().sprite = mySprite;
                var newIcon = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
                newIcon.name = spriteName; //     Naming instantiated GameObjects with Champion name
                x += 0.975f;
            }
        }
        else if (more)
        {
            GameObject[] boxToDest = GameObject.FindGameObjectsWithTag("Box");
            foreach (GameObject box in boxToDest)
                Destroy(box);
            y = 3.37f;
            for (int i = 36; i < 50; i++) //     Displaying all Champions Icons
            {
                if (i == 0 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45) x = -1.95f;
                if (i == 5 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50) x = -1.4625f;
                if (i == 5 || i == 9 || i == 18 || i == 27 || i == 36 || i == 45 || i == 14 || i == 23 || i == 32 || i == 41 || i == 50) y -= 0.88f;
                GameObject camera = GameObject.Find("Main Camera");
                ChampionsList list = camera.GetComponent<ChampionsList>();
                List<Champion> champs = list.champions;
                spriteName = champs[i].champName;
                mySprite = Resources.Load<Sprite>("ChampionsIcons/" + spriteName);
                box.GetComponent<SpriteRenderer>().sprite = mySprite;
                var newIcon = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
                newIcon.name = spriteName; //     Naming instantiated GameObjects with Champion name
                x += 0.975f;
            }
        }
    }
}
