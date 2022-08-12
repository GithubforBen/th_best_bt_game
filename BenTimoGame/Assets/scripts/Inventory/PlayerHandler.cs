using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public Inventory inventory;
    [SerializeField] private UI_Inventory UI_Inventory;
    void Awake()
    {
        inventory = new Inventory();
        UI_Inventory.SetInventory(inventory);
    }

    void Update()
    {
        
    }
}
