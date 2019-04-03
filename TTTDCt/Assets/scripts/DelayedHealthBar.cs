using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayedHealthBar : MonoBehaviour
{
    //maxHealth, curHealth, delayHealth
    public float maxHealth;
    public float curHealth;
    public float delayHealth;
    public float speed;

    //Speed in which health drops
    //refernces to foreground curHealthSlider (fill)
    public Slider curHealthSlider;
      //reference to background delayHealthSlider (background fill)
    public Slider delayHealthSlider;
    public Image delayHealthfill;

    private void Update()
    {
        delayHealthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
        if(delayHealth > curHealth)
        {
            delayHealth -= Time.deltaTime * speed;
        }
        delayHealthSlider.value = Mathf.Clamp01(delayHealth / maxHealth);
    }

    void ManageHealthBar()
    {

    }
    //Health slider value updates when current health changes but needs to stay between 0 an Max
    //if our delay health is going to be less than our current health we need to bring the health down by speed over time (same for increase)
    //delay sliders value to be set to the delay health amount between its min and max
    //To manage the health bar make sure foreground fill is disabled upon death and enabled on revive
    //once delayHealth is empty turn off background fill
    //apon revive turn on background fill and make sure delay health and slider value are full
}
