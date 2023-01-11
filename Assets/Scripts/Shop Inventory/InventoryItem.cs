using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public GameObject SelectedSet;
    [Serialize Field] SetSelector setselector;
    [Serialize Field] InventorySets inventorysets;
    private int current = inventorysets.i
}

    // Update is called once per frame
    void Update()
    {
        SelectedSet.GetComponent<TextMeshProUGUI>().text = sets[currentset];
    }
}
