using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySets : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private List<InventoryItem> inventorygrid = new List<InventoryItem>();
    //[SerializeField] private InventoryItem inventorybuy;
        InventoryItem inventoryitem;
    [SerializeField] private RectTransform contentPanel;
    //SetSelector setselector;
    private GameObject cset;
    public void InitializeInventoryUI(int inventorysize)
    {
        for (int i = 0; i < inventorysize; i++)
        {
            InventoryItem uiItem =
                Instantiate(inventorygrid[i], Vector3.zero, Quaternion.identity);
            inventorygrid[i] = uiItem;
            uiItem.transform.SetParent(contentPanel);
            //uiItem.transform.SetParent(contentPanel);
            //inventorygrid.Add(uiItem);
            //   settext(i);
            //  
            /*  uiItem.OnItemClicked += HandleItemSelection;
              uiItem.OnItemBeginDrag += HandleBeginDrag;
              uiItem.OnItemDroppedOn += HandleSwap;
              uiItem.OnItemEndDrag += HandleEndDrag;
              uiItem.OnRightMouseBtnClick += HandleShowItemActions; */
        }


    }
}


      // Update is called once per frame
      /*  public void SpawnSets()
        {
            int x = 0;
            setselector = GetComponent<SetSelector>();
            int y = setselector.sets.Length;


            if (x <= y) {

                Instantiate(inventorybuy, inventorygrid[x].position);

                x+=1;
            }
            else
            {
                Debug.Log("Sets have been spawned");
            }
        } */
        
