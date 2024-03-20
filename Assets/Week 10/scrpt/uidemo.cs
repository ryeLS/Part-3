using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uidemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpol;
    public void SliderValueHasChanged(Single value){
        Debug.Log(value);
    }
    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpol/60));
        
    }
    public void DropdownChange(Int32 value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
