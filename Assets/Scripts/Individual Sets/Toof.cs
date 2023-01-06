using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toof : MonoBehaviour
{
    static string[] toofset = new string[] { "Toof", "Cat", "Mouse", "Yarn", "Loki", "Henry", "Socks", "Leo", "Scamper", "Cat Tree", "Cat Nip", };
    static int[] toofcollection = new int[11];

    public static void OpenPack()
    {
        int cardopened = Random.Range(0, toofcollection.Length);
        Debug.Log(toofset[cardopened]);
        toofcollection[cardopened] += 1;
        Debug.Log(toofcollection[cardopened]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
