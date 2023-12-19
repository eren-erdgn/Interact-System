using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Cube : MonoBehaviour, IInteractable
{
    
    public string InteractionPrompt { get; }
    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();
        if(inventory == null) return false;
        if (!inventory.HasAnythingOnHand)
        {
            transform.parent = interactor.Hand.transform;
            transform.localPosition = Vector3.zero;
            inventory.HasAnythingOnHand = true;
            return true;
        }
        else
        {
            return false;
        }
    }
}
