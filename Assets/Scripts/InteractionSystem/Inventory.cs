using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool HasKey = false;
    public bool HasAnythingOnHand = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            HasKey = !HasKey;
        }
    }
}
