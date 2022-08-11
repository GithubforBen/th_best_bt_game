using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<Item> items;

    public Inventory() {
        items = new List<Item>();
    }

    public void AddItem(Item item) {
        items.Add(item);
    }
}
