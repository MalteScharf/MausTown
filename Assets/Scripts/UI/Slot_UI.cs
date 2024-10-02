using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Microsoft.Unity.VisualStudio.Editor;

public class Slot_UI : MonoBehaviour
{
    public UnityEngine.UI.Image itemIcon;
    public TextMeshProUGUI quantityText;

    public void SetItem(Inventory.Slot slots)
    {
        if(slots!= null)
        {
            itemIcon.sprite = slots.icon;
            itemIcon.color = new Color(1,1,1,1);
            quantityText.text = slots.count.ToString();

        }
    }

    public void SetEmpty()
    {
        itemIcon.sprite = null;
        itemIcon.color = new Color(1,1,1,0); 
        quantityText.text ="";
    }
}
