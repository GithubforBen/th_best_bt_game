using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Inventory inventory;

    void Awake() {
        inventory = new Inventory();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("dsa");
        }
    }
}
