using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Set", menuName = "CardSet")]
public class Cardset : ScriptableObject
{
    static string[] xanthiaset = new string[] { "Sword", "Warrior", "Dagger", "Staff", "Cloak", "Gold", "HP Potion", "Mana Potion", "Shield", "Dragon", "Goblin", };
    static int[] xanthiacollection = new int[11];

    public static void OpenPack()
    {
        int cardopened = Random.Range(0, xanthiacollection.Length);
        Debug.Log(xanthiaset[cardopened]);
        xanthiacollection[cardopened] += 1;
        Debug.Log(xanthiacollection[cardopened]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
