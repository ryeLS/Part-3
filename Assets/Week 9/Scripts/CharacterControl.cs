using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI className;
    public ChestType type;
    public static CharacterControl Instance;
    public static Villager SelectedVillager { get; private set; }
    public static string namey;

    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        //namey = villager.name;
        Instance.className.text = villager.ToString();
    }
    private void Start()
    {
        //namey = "Not Selected";
        Instance = this;
    }


}
