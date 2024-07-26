using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{ 
    Rigidbody rb;
    public GameObject arrow;//стрелка показывающая направление
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//если нажали по экрану
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.gameObject.tag=="bird")//если нажали на экран а там птичка
                {
                    rb.isKinematic=false;
                    rb.AddForce(arrow.transform.up * 1600f);//птичка полетела
                    Score_player.instance.bird++;
                }
            }
        }
    }
}
