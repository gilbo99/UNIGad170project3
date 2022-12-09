using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSwitch : MonoBehaviour
{
    public GameObject Gas;
    public bool gasonoff;
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.SwitchGasButtons += GasSwitchfunc;
    }
    private void GasSwitchfunc()
    {

        Gas.SetActive(gasonoff);
        gasonoff = !gasonoff;
    }


    void OnDestroy() 
    {
        EventBus.Current.SwitchGasButtons -= GasSwitchfunc;
    }
    
}
