using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchesWarlocks : MonoBehaviour
{
    static string[] witchwarlockset = new string[] { "Witch", "Warlock", "Crystal Ball", "Staff", "Cloak", "Gold", "HP Potion", "Mana Potion", "Tome", "SpellBook", "Imp", };
    static int[] witchwarlockcollection = new int[11];

    public static void OpenPack()
    {
        int cardopened = Random.Range(0, witchwarlockcollection.Length);
        Debug.Log(witchwarlockset[cardopened]);
        witchwarlockcollection[cardopened] += 1;
        Debug.Log(witchwarlockcollection[cardopened]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
