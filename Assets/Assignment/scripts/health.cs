using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float healthbar;
    public Slider slider;
    public void HitTaken(float damage)
    {
        Debug.Log("done");
        slider.value -= damage;

    }
}
