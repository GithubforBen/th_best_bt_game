using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public Inventory inventory;
    void Awake()
    {
        inventory = new Inventory();
    }
}
