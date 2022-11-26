using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayerStats : MonoBehaviour
{

    public float HP = 100;
    private float Ox = 100;
    private float MaxHP = 150;
    public HPBar hpbar;
    [SerializeField]public TextMeshProUGUI HPText;
    // Start is called before the first frame update
    void Start()
    {
        hpbar.InitBar(MaxHP);
        hpbar.SetValue(HP);
        HPText.text = HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         if (HP <= 0)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void TakeDamaged(float TakenDamaged)
    {
        HP -= TakenDamaged;     
        hpbar.SetValue(HP);
        HPText.text = HP.ToString();
        

    }

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
