using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{

    // Reference to health
    [Header("Reference to Health")]
    // Players maximum health
    public float maxHealth;
    // Players current health
    public float curHealth;
    [Header("Reference to UI elements")]
    // Reference to slider
    public Slider healthSlider;
    // Reference to Fill
    public Image healthFill;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
        ManageHealthBar();


    }
    void ManageHealthBar()
    {
        if (curHealth <= 0 && healthFill.enabled)
        {
            Debug.Log("Dead");
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            healthFill.enabled = enabled;
        }
    }


}
