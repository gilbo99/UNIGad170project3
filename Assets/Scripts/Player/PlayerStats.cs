using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerStats : MonoBehaviour
{
    private SceneController sceneController;
    public float HP = 100;
    public float MaxHP = 150;
    public HPBar hpbar;
    [SerializeField]private TextMeshProUGUI HPText;
    // Start is called before the first frame update
    void Awake()
    {
        //sets hpbars max hp and opens a new SceneController
        sceneController = new SceneController();
        hpbar.InitBar(MaxHP);
        hpbar.SetValue(HP);
        HPText.text = HP.ToString();    
    }

    // relaods ReloadScene when hp is lower than 0
    void Update()
    {
         if (HP <= 0)
        {
            sceneController.ReloadScene();
        }
    }
    //takes damaged and sets hp bar
    public void TakeDamaged(float TakenDamaged)
    {
        HP -= TakenDamaged;     
        hpbar.SetValue(HP);
        HPText.text = HP.ToString();
        

    }
    //heals and sets bar
    public void Healing(float Healing)
    {   
        HP += Healing;
        if(HP >= MaxHP)
        {
            HP = MaxHP;
            
        }
        hpbar.SetValue(HP);
        HPText.text = HP.ToString();
    }
    
    
}
