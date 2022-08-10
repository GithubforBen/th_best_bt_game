using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<Item> itemList;

    public Inventory() 
    {
        itemList = new List<Item>();

        Debug.Log("Inventory Created!");
    }

    public void AddItem(Item item) 
    {
        itemList.Add(item);
    }
}
