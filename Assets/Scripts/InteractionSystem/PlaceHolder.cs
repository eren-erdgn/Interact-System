using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class PlaceHolder : MonoBehaviour , IInteractable
{
    
    [SerializeField] private string[] placeableTags;
    [SerializeField] private Transform holderTransform;
    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();
        if(inventory == null) return false;
        if (inventory.HasAnythingOnHand == false) return false;
        if(holderTransform.childCount != 0) return false;
        var playersHand = interactor.Hand.transform.GetChild(0);
        var itemHeld = playersHand.tag;
        if (placeableTags.All(tags => tags != itemHeld)) return false;
        playersHand.parent = holderTransform.transform;
        playersHand.transform.localPosition = Vector3.zero;
        inventory.HasAnythingOnHand = false;
        return true;
    }
}
