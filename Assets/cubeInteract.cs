using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeInteract : MonoBehaviour
{
    
    bool pointerDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pointerDown == true){
            transform.Rotate(Vector3.up * 15f * Time.deltaTime);
        }
        
    }
    public void PointerEnter(){
        Debug.Log("Pointer Masuk kedalam Object");
    }
    public void PointerExit(){
        Debug.Log("Pointer Keluar dari object");
    }
    public void PointerClick(){
        Debug.Log("Pointer masuk dan diClick");
    }
    public void PointerUp(){
        pointerDown = false;
    }
    public void PointerDown(){
        pointerDown = true;
    }

    public void jadiMerah(){
        GetComponent<Renderer>().material.color = Color.red;
    }
}
