using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    public void SetInventory(Inventory inventory) {

        itemSlotContainer = transform.Find("itemSlotContainer");

        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");

        this.inventory = inventory;
        RefreshInventoryItems();
    }

    public void RefreshInventoryItems() 
    {
        int x = -2;
        int y = -3;
        int baba = 0;
        float itemSlotCellSize = 60f;
        foreach (Item item in inventory.GetItemList()) 
        {
            if (baba > 35)
            {
                UnityEngine.Debug.LogError("inventory too small");
                return;
            }
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();

            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            x++;
            baba++;
            if (x > 3)
            {
                x = -2;
                y ++;
            }
        }
    }
}
