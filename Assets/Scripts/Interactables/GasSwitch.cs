using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSwitch : MonoBehaviour
{
    public GameObject Gas;
    public bool gasonoff;
    // subs the GasSwitchfunc function too the EventBus trigger
    void Start()
    {
        EventBus.Current.SwitchGasButtons += GasSwitchfunc;
    }
    private void GasSwitchfunc()
    {

        Gas.SetActive(gasonoff);
        gasonoff = !gasonoff;
    }

    // unsubs the GasSwitchfunc function too the EventBus trigger
    void OnDestroy() 
    {
        EventBus.Current.SwitchGasButtons -= GasSwitchfunc;
    }
    
}
