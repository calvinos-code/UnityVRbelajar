using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public bool timerOn = false;
    public float timerLimit, counter;
    public bool isMove = false;

    //public Transform target;
    public Vector3 vTarget;
    public float speed;

    public Image loading;

    // Start is called before the first frame update
    void Start()
    {
        //counter = timerLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn == true){
            counter += Time.deltaTime;
            if(isMove == false){
                loading.fillAmount = counter / timerLimit;
            }
            if(counter>3f){
                isMove = true;
            }
        }
        if(isMove == true){
            float step = speed * Time.deltaTime;
            //vTarget = target.position;
            //vTarget.y = 1f;
            transform.position = Vector3.MoveTowards(transform.position, vTarget, step);

            if(transform.position == vTarget){
                isMove = false;
            }
        }
    }

    public void TimerOn(bool isOn){
        timerOn = isOn;
        if(isOn == false){
            counter = 0;
            loading.fillAmount = 0;
        }
    }
}
