using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> items;

    public Inventory() {
        items = new List<Item>();
        AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });
        AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });
        AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });AddItem(new Item {
            itemType = Item.ItemType.Coin,
            amount = 1
        });
    }

    public void AddItem(Item item) {
        items.Add(item);
    }

    public List<Item> GetItemList() {
        return items;
    }
}
