using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetSelector : MonoBehaviour
{
    public GameObject SelectedSet;
    string[] sets = new string[] { "Xanthia", "Witches & Warlocks"};
    public static int currentset = 0;
    public void NextSelection()
    {
        if (currentset >= 1)
    { 
            currentset = 0;
    }
        else
        {
            currentset += 1;
        }
    }
    public void PreviousSelection()
    {
        if (currentset <= 0)
        {
           
            currentset = 1;
        }
        else
        {
            currentset -= 1;
    
        }
    }

    public void OPENDAPACK()
    {
        MoneyGlobal.Money -= 5;
        if (currentset == 0)
        {
            Xanthia.OpenPack();
        }
        if (currentset == 1)
        {

            WitchesWarlocks.OpenPack();
        }
        else
        {
            Debug.Log("Borked");
        }
    }

    // Update is called once per frame
    void Update()
    {
        SelectedSet.GetComponent<TextMeshProUGUI>().text = sets[currentset];
    }
}
