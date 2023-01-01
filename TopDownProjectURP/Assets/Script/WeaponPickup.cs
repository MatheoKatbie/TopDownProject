using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponPickup : MonoBehaviour
{
    public int index;

    public TextMeshProUGUI textMeshH;
    public WeaponInventory weaponInventory;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            textMeshH.text = "Pick up " + this.gameObject.name;
        }
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.E))
            {
                weaponInventory.SetupWeapon(index);
                textMeshH.text = "";
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            textMeshH.text = "";
        }
    }
}
