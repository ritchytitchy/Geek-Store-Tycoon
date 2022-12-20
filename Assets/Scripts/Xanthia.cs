using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xanthia : MonoBehaviour
{
    string[] xanthiaset = new string[] { "Sword", "Warrior", "Dagger", "Staff", "Cloak", "Gold", "HP Potion", "Mana Potion", "Shield", "Dragon", "Goblin", };
    int[] xanthiacollection = new int[11];
    
    public void OpenPack()
    {
        MoneyGlobal.Money -= 5;
        int cardopened = Random.Range(0, xanthiacollection.Length);
        Debug.Log(cardopened);
        Debug.Log(xanthiaset[cardopened]);
        xanthiacollection[cardopened] += 1;
        Debug.Log(xanthiacollection[cardopened]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
