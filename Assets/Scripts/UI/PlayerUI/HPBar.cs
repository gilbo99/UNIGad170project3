using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    
    public Slider hpSlider;
    // Start is called before the first frame update
    public void InitBar(float maxValue)
    {
        hpSlider.maxValue = maxValue;
          

    }

    public void SetValue(float hp) {
        hpSlider.value = hp;
        
    }
}
