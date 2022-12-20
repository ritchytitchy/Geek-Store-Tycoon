using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveMoney : MonoBehaviour
{

    public void  removemoney()
    {
        MoneyGlobal.Money -= 5;
    }
}
