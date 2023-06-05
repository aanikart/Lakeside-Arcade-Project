using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenhealthbarscript : MonoBehaviour
{
    public greenfightscript greenfightscript;
    public Image fillImage;
    private Slider slider;

    public static bool isplayerdead;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isplayerdead == false)
        {


            slider.maxValue = greenfightscript.maxhealth;
            if (slider.value <= slider.minValue)
            {
                fillImage.enabled = false;
            }
            else if (slider.value > slider.minValue && !fillImage.enabled)
            {
                fillImage.enabled = true;
            }
            float fill = greenfightscript.health;
            if (fill <= slider.maxValue / 3)
            {
                fillImage.color = Color.red;
            }
            else if (fill > slider.maxValue / 3)
            {
                fillImage.color = new Color(0, 130, 30, 255);
            }
            slider.value = fill;
        }
    }
}
