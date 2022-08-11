using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{

    public static bool IsInventoryOpened = false;
    public static bool newOne = true;
    public GameObject Inv;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("TAB");
            if (IsInventoryOpened)
            {
            }else
            {
                IsInventoryOpened = true;
                newOne = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsInventoryOpened)
            {
                IsInventoryOpened = false;
                newOne = true;
            }
        }

        if (IsInventoryOpened)
        {
            if (newOne)
            {
                Inv.SetActive(true);
                newOne = false;
            }
        }else
        {
            if (newOne)
            {
                Inv.SetActive(false);
                newOne = false;
            }
        }
    }
}
