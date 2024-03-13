using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChestType { Villager, Thief, Merchant, Archer}
public class Chest : MonoBehaviour
{
    public Animator animator;
    public ChestType open;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Villager>(out Villager villager))
        {
            if(villager.CanOpen()== open || open == ChestType.Villager)
            {
                animator.SetBool("IsOpened", true);
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
