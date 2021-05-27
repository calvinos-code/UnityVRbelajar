using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointWays : MonoBehaviour
{
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetVTarget(){
        if(playerMovement.isMove == false){
            playerMovement.vTarget = transform.position;
            playerMovement.vTarget.y = 1f;
        }


    }
}
