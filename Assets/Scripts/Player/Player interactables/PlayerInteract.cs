using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject Cam;
    [SerializeField] private float Distance = 3f;
    [SerializeField] private LayerMask mask;
    private PlayerUI playerUI;
    private InputManager inputManager;
    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //create a ray from the center of the camera, pointing forward
        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        Debug.DrawRay(ray.origin,ray.direction * Distance);
        RaycastHit hitInfo;//stores the variable collision info
        if(Physics.Raycast(ray, out hitInfo, Distance,mask))// out sets hitInfo // marks gets the Layers from unity
        {
           if(hitInfo.collider.GetComponent<Interactable>() != null)
           {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.MessagePromptl);
                if(Input.GetKeyDown("e"))
                {

                    interactable.BaseInteract();
                }
           } 
        }
    }
}
