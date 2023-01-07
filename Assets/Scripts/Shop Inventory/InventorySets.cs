using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySets : MonoBehaviour
{
    // Start is called before the first frame update

        public List<InventoryItem> inventorygrid = new List<InventoryItem>();
    [SerializeField] private InventoryItem inventorybuy;
        SetSelector setselector;
    [SerializeField] private RectTransform contentPanel;

        public void InitializeInventoryUI(int inventorysize)
    {
        for (int i = 0; i < inventorysize; i++)
        {
            InventoryItem uiItem =
                Instantiate(inventorybuy, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            inventorygrid.Add(uiItem);
            /*  uiItem.OnItemClicked += HandleItemSelection;
              uiItem.OnItemBeginDrag += HandleBeginDrag;
              uiItem.OnItemDroppedOn += HandleSwap;
              uiItem.OnItemEndDrag += HandleEndDrag;
              uiItem.OnRightMouseBtnClick += HandleShowItemActions; */
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
        }
