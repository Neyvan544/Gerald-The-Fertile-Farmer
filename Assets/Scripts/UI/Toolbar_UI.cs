using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar_UI: MonoBehaviour
{
    public List<Slot_UI> toolbarSlots = new List<Slot_UI>();

    private Slot_UI selectedSlot;

    private void Start()
    {
        SelectSlot(0);
    }

    private void Update()
    {
        CheckAlphaNumericKeys();
    }

    public void SelectSlot(Slot_UI slot)
    {
        SelectSlot(slot.slotID);
    }

    public void SelectSlot(int index)
    {
        if(toolbarSlots.Count == 9)
        {
            if(selectedSlot != null)
            {
                selectedSlot.SetHighlight(false);
            }
            selectedSlot = toolbarSlots[index];
            selectedSlot.SetHighlight(true);

            GameManager.instance.player.inventoryManager.toolbar.SelectSlot(index);
        }
    }

    private void CheckAlphaNumericKeys()
    {
        for (int i = 0; i < toolbarSlots.Count; i++)
        {

            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                SelectSlot(i);
                break;
            }
        }
    }
}
