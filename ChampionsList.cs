using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[System.Serializable]
public class ChampionsList : MonoBehaviour
{
    [SerializeField]
    public List<Champion> champions;
    public Champion selectedChamp;
    //      Declaring Champion Origins
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

    //      Declaring Champion Classes


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
            new Champion("Darius", 1, imp, null, kni, null),
            new Champion("Elise", 1, dem, null, sha, null),
            new Champion("Fiora", 1, nob, null, bla, null),
            new Champion("Garen", 1, nob, null, kni, null),
            new Champion("Graves", 1, pir, null, gun, null),
            new Champion("Kassadin", 1, voi, null, sor, null),
            new Champion("Kha'Zix", 1, voi, null, ass, null),
            new Champion("Mordekaiser", 1, pha, null, kni, null),
            new Champion("Nidalee", 1, wil, null, sha, null),
            new Champion("Tristana", 1, yor, null, gun, null),
            new Champion("Vayne", 1, nob, null, ran, null),
            new Champion("Warwick", 1, wil, null, bra, null),
            new Champion("Ahri", 2, wil, null, sor, null),
            new Champion("Blitzcrank", 2, rob, null, bra, null),
            new Champion("Braum", 2, gla, null, gua, null),
            new Champion("Lissandra", 2, gla, null, ele, null),
            new Champion("Lucian", 2, nob, null, gun, null),
            new Champion("Lulu", 2, yor, null, sor, null),
            new Champion("Pyke", 2, pir, null, ass, null),
            new Champion("Rek'Sai", 2, voi, null, bra, null),
            new Champion("Shen", 2, nin, null, bla, null),
            new Champion("Twisted Fate", 2, pir, null, sor, null),
            new Champion("Varus", 2, dem, null, ran, null),
            new Champion("Zed", 2, nin, null, ass, null),
            new Champion("Aatrox", 3, dem, null, bla, null),
            new Champion("Ashe", 3, gla, null, ran, null),
            new Champion("Evelynn", 3, dem, null, ass, null),
            new Champion("Gangplanck", 3, pir, null, gun, bla),
            new Champion("Katarina", 3, imp, null, ass, null),
            new Champion("Kennen", 3, nin, yor, ele, null),
            new Champion("Morgana", 3, dem, null, sor, null),
            new Champion("Poppy", 3, yor, null, kni, null),
            new Champion("Rengar", 3, wil, null, ass, null),
            new Champion("Shyvana", 3, dra, null, sha, null),
            new Champion("Veigar", 3, yor, null, sor, null),
            new Champion("Volibear", 3, gla, null, bra, null),
            new Champion("Akali", 4, nin, null, ass, null),
            new Champion("Aurelion Sol", 4, dra, null, sor, null),
            new Champion("Brand", 4, dem, null, ele, null),
            new Champion("Cho'Gath", 4, voi, null, bra, null),
            new Champion("Draven", 4, imp, null, bla, null),
            new Champion("Gnar", 4, yor, wil, sha, null),
            new Champion("Kindred", 4, pha, null, ran, null),
            new Champion("Leona", 4, nob, null, gua, null),
            new Champion("Sejuani", 4, gla, null, kni, null),
            new Champion("Anivia", 5, gla, null, ele, null),
            new Champion("Karthus", 5, pha, null, sor, null),
            new Champion("Kayle", 5, nob, null, kni, null),
            new Champion("Miss Fortune", 5, pir, null, gun, null),
            new Champion("Swain", 5, imp, dem, sha, null),
            new Champion("Yasuo", 5, exi, null, bla, null)
        };
    }
    private void ChampionSelected() //      Find Synergies for selected Champion
    {
        Champion selectedChamp = champions.Find(x => x.champName == "Miss Fortune"); //     Placeholder for assigning Selected Champion
            if (selectedChamp.champOrigin != "Robot") //        Stops logging champ.Origin of "Robot" Origin, as there is only one "Robot"
            Debug.Log(selectedChamp.champOrigin);
        foreach (Champion temp in champions)
        {

            //      Get Origin Synergie

            if (temp.champOrigin == selectedChamp.champOrigin || temp.champOrigin2 == selectedChamp.champOrigin)
            {
                if (temp.champName == selectedChamp.champName) ; //     Do not display selected Champion as Synergie
                else
                {
                    Debug.Log(temp.champName + " " + temp.champCost + " " + temp.champOrigin + " " + temp.champOrigin2 + " " + temp.champClass + " " + temp.champClass2);
                    //      Display Champion Origin Synergies
                }
            }
        }
            if (selectedChamp.champOrigin2 != null) Debug.Log(selectedChamp.champOrigin2);
            foreach (Champion temp in champions)
            {
                //      Get Origin2 Synergie if not null

                if (selectedChamp.champOrigin2 != null && (temp.champOrigin == selectedChamp.champOrigin2 || temp.champOrigin2 == selectedChamp.champOrigin2))
                {
                    if (temp.champName == selectedChamp.champName) ; //     Do not display selected Champion as Synergie
                    else
                    {
                        Debug.Log(temp.champName + " " + temp.champCost + " " + temp.champOrigin + " " + temp.champOrigin2 + " " + temp.champClass + " " + temp.champClass2);
                        //      Display Champion Origin2 Synergies
                    }
                }
            }
            Debug.Log(selectedChamp.champClass);
        foreach (Champion temp in champions)
        {
            //      Get Class Synergie

            if (temp.champClass == selectedChamp.champClass || temp.champClass2 == selectedChamp.champClass)
            {
                if (temp.champName == selectedChamp.champName) ; //     Do not display selected Champion as Synergie
                else
                {
                    Debug.Log(temp.champName + " " + temp.champCost + " " + temp.champOrigin + " " + temp.champOrigin2 + " " + temp.champClass + " " + temp.champClass2);
                    //      Display Champion Class Synergies
                }
            }
        }
            if (selectedChamp.champClass2 != null) Debug.Log(selectedChamp.champClass2);
        foreach (Champion temp in champions)
        {
            //      Get Class2 Synergie if not null

            if (selectedChamp.champClass2 != null && (temp.champClass == selectedChamp.champClass2 || temp.champClass2 == selectedChamp.champClass2))
            {
                if (temp.champName == selectedChamp.champName) ; //     Do not display selected Champion as Synergie
                else
                {
                    Debug.Log(temp.champName + " " + temp.champCost + " " + temp.champOrigin + " " + temp.champOrigin2 + " " + temp.champClass + " " + temp.champClass2);
                    //      Display Champion Class2 Synergies
                }
            }
        }
    }
    private void Update() //        On Champion Selection
    {
        if (Input.GetKeyDown(KeyCode.I)) ChampionSelected();
    }
}
