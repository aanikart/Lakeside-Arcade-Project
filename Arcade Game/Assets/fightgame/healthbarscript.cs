using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    public fightscript fightscript;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = fightscript.maxhealth;
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        else if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }
        float fill = fightscript.health;
        if (fill <= slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        else if (fill > slider.maxValue / 3)
        {
            fillImage.color = new Color (153, 0, 255, 255);
        }
        slider.value = fill;
    }
}
