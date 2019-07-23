using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using TMPro;


public class ChampionsList : MonoBehaviour
{
    public List<Champion> champions;
    public Champion selectedChamp;
    private string selectedName;
    public string SelectedName { get; set; }
    public GameObject box;
    public GameObject Names;
    public GameObject Attributes;
    public GameObject canvas;
    Sprite mySprite;
    float x;
    float y;
    
    //      Declaring Champion Attributes
    string imp = "Imperial";
    string dem = "Demon";
    string dra = "Dragon";
    string exi = "Exile";
    string gla = "Glacial";
    string nob = "Noble";
    string nin = "Ninja";
    string pir = "Pirate";
    string pha = "Phantom";
    string rob = "Robot";
    string voi = "Void";
    string wil = "Wild";
    string yor = "Yordle";
    string ass = "Assasin";
    string bla = "Blademaster";
    string bra = "Brawler";
    string ele = "Elementalist";
    string gua = "Guardian";
    string gun = "Gunslinger";
    string kni = "Knight";
    string ran = "Ranger";
    string sha = "Shapeshifter";
    string sor = "Sorcerer";


    void Start()
    {
        //      Creating List of Champions

        champions = new List<Champion>(51)
        {
            new Champion("Darius", 1, imp, kni, null),
            new Champion("Elise", 1, dem, sha, null),
            new Champion("Fiora", 1, nob, bla, null),
            new Champion("Garen", 1, nob, kni, null),
            new Champion("Graves", 1, pir, gun, null),
            new Champion("Kassadin", 1, voi, sor, null),
            new Champion("Kha'Zix", 1, voi, ass, null),
            new Champion("Mordekaiser", 1, pha, kni, null),
            new Champion("Nidalee", 1, wil, sha, null),
            new Champion("Tristana", 1, yor, gun, null),
            new Champion("Vayne", 1, nob, ran, null),
            new Champion("Warwick", 1, wil, bra, null),
            new Champion("Ahri", 2, wil, sor, null),
            new Champion("Blitzcrank", 2, rob, bra, null),
            new Champion("Braum", 2, gla, gua, null),
            new Champion("Lissandra", 2, gla, ele, null),
            new Champion("Lucian", 2, nob, gun, null),
            new Champion("Lulu", 2, yor, sor, null),
            new Champion("Pyke", 2, pir, ass, null),
            new Champion("Rek'Sai", 2, voi, bra, null),
            new Champion("Shen", 2, nin, bla, null),
            new Champion("Twisted Fate", 2, pir, sor, null),
            new Champion("Varus", 2, dem, ran, null),
            new Champion("Zed", 2, nin, ass, null),
            new Champion("Aatrox", 3, dem, bla, null),
            new Champion("Ashe", 3, gla, ran, null),
            new Champion("Evelynn", 3, dem, ass, null),
            new Champion("Gangplank", 3, pir, gun, bla),
            new Champion("Katarina", 3, imp, ass, null),
            new Champion("Kennen", 3, nin, yor, ele),
            new Champion("Morgana", 3, dem, sor, null),
            new Champion("Poppy", 3, yor, kni, null),
            new Champion("Rengar", 3, wil, ass, null),
            new Champion("Shyvana", 3, dra, sha, null),
            new Champion("Veigar", 3, yor, sor, null),
            new Champion("Volibear", 3, gla, bra, null),
            new Champion("Akali", 4, nin, ass, null),
            new Champion("Aurelion Sol", 4, dra, sor, null),
            new Champion("Brand", 4, dem, ele, null),
            new Champion("Cho'Gath", 4, voi, bra, null),
            new Champion("Draven", 4, imp, bla, null),
            new Champion("Gnar", 4, yor, wil, sha),
            new Champion("Kindred", 4, pha, ran, null),
            new Champion("Leona", 4, nob, gua, null),
            new Champion("Sejuani", 4, gla, kni, null),
            new Champion("Anivia", 5, gla, ele, null),
            new Champion("Karthus", 5, pha, sor, null),
            new Champion("Kayle", 5, nob, kni, null),
            new Champion("Miss Fortune", 5, pir, gun, null),
            new Champion("Swain", 5, imp, dem, sha),
            new Champion("Yasuo", 5, exi, bla, null)
        };
    }

    public void ChampionSelected() //      Find Synergies for selected Champion
    {
        selectedName = SelectedName;
        Champion selectedChamp = champions.Find(x => x.champName == selectedName); //    Assigning Selected Champion
        x = -1.95f;
        y = 3.45f;
        mySprite = Resources.Load<Sprite>("ChampionsIcons/" + selectedName);
        box.GetComponent<SpriteRenderer>().sprite = mySprite;
        var newIcon = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
        newIcon.name = selectedName;
        TextMeshProUGUI mTextNames = Names.GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI mTextAttributes = Attributes.GetComponent<TextMeshProUGUI>();
        mTextNames.text = selectedName;
        (Instantiate(Names, new Vector3(x, y + 0.7f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
        mTextAttributes.text = "Synergy" + System.Environment.NewLine + "for:";
        (Instantiate(Attributes, new Vector3(x, y + 1.1f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
        if (selectedChamp.champAtt1 != rob && selectedChamp.champAtt1 != exi) //        Stops logging champAtt1 of "Robot" Attribute, as there is only one "Robot"
        {
            if (selectedChamp.champAtt3 != null) x = -0.65f;
            else x = -0.4f;
            mTextAttributes.text = selectedChamp.champAtt1;
            (Instantiate(Attributes, new Vector3(x, y + 1.1f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
            Debug.Log(selectedChamp.champAtt1);
        }

        foreach (Champion temp in champions)
        {

            //      Get Origin Synergie

            if (selectedChamp.champAtt1 != rob && temp.champName != selectedName && (temp.champAtt1 == selectedChamp.champAtt1 || temp.champAtt2 == selectedChamp.champAtt1 || temp.champAtt3 == selectedChamp.champAtt1))
            {                   
                    if (selectedChamp.champAtt3 != null) x = -0.65f;
                    else x = -0.4f;
                    mySprite = Resources.Load<Sprite>("ChampionsIcons/" + temp.champName);
                    box.GetComponent<SpriteRenderer>().sprite = mySprite;
                    var newIcons = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
                    newIcon.name = temp.champName;
                    mTextNames.text = temp.champName;
                    (Instantiate(Names, new Vector3(x, y + 0.7f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
                    Debug.Log(temp.champName);
                    y -= 1.4f;
                    //      Display Champion Attribute1 Synergies
            }
        }
        if (selectedChamp.champAtt1 == rob || selectedChamp.champAtt1 == exi) x = -0.4f;
        else if (selectedChamp.champAtt3 != null) x = 0.65f;
        else x = 1.15f;
        y = 3.45f;
        mTextAttributes.text = selectedChamp.champAtt2;
        (Instantiate(Attributes, new Vector3(x, y + 1.1f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
        Debug.Log(selectedChamp.champAtt2);
        foreach (Champion temp in champions)
            {
                //      Get Att2 Synergie if not null

                if (temp.champName != selectedChamp.champName && (temp.champAtt1 == selectedChamp.champAtt2 || temp.champAtt2 == selectedChamp.champAtt2 || temp.champAtt3 == selectedChamp.champAtt2))
                {
                     if (selectedChamp.champAtt1 == rob || selectedChamp.champAtt1 == exi) x = -0.4f;
                     else if (selectedChamp.champAtt3 != null) x = 0.65f;
                     else x = 1.15f;
                     mySprite = Resources.Load<Sprite>("ChampionsIcons/" + temp.champName);
                     box.GetComponent<SpriteRenderer>().sprite = mySprite;
                     var newIcons = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
                     newIcon.name = temp.champName;
                     mTextNames.text = temp.champName;
                     (Instantiate(Names, new Vector3(x, y + 0.7f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
                     Debug.Log(temp.champName);
                     y -= 1.4f;
                     Debug.Log(temp.champName);
                        //      Display Champion Origin2 Synergies
                }
            }
        if (selectedChamp.champAtt3 != null)
        {
            Debug.Log(selectedChamp.champAtt3);
            y = 3.45f;
            x = 1.75f;
            mTextAttributes.text = selectedChamp.champAtt3;
            (Instantiate(Attributes, new Vector3(x, y + 1.1f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
        }
        foreach (Champion temp in champions)
        {
            //      Get Class Synergie

            if (selectedChamp.champAtt3 != null && temp.champName != selectedChamp.champName && (temp.champAtt1 == selectedChamp.champAtt3 || temp.champAtt2 == selectedChamp.champAtt3 || temp.champAtt3 == selectedChamp.champAtt3))
            {
                /* if (selectedChamp.champAtt1 == rob || selectedChamp.champAtt1 == exi) x = -0.4f;
                 else if (selectedChamp.champAtt3 != null) x = 0.77f;
                 else x = 1.15f; */
                x = 1.95f;
                mySprite = Resources.Load<Sprite>("ChampionsIcons/" + temp.champName);
                box.GetComponent<SpriteRenderer>().sprite = mySprite;
                var newIcons = (GameObject)Instantiate(box, new Vector3(x, y, 0), Quaternion.identity);
                newIcon.name = temp.champName;
                mTextNames.text = temp.champName;
                (Instantiate(Names, new Vector3(x, y + 0.7f, 0), Quaternion.identity) as GameObject).transform.parent = canvas.transform;
                Debug.Log(temp.champName);
                y -= 1.4f;
                Debug.Log(temp.champName);
                Debug.Log(temp.champName);
                    //      Display Champion Class Synergies
            }
        }
    }

    private void Update() //        On Champion Selection
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            selectedName = SelectedName;
            Debug.Log(selectedName);
            ChampionSelected(); //     Placeholder for Selecting Champion
        }
    }
}
