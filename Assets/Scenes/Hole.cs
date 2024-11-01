using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;

    bool isHolding;

    public bool IsHolding{
        get
        {return isHolding;}
    }
    //public bool IsHolding(){
    //    return isHolding;
    //}

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag==targetTag){
            isHolding = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag==targetTag){
            isHolding=false;
        }        
    }

    void OnTriggerStay(Collider other){
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        if(other.gameObject.CompareTag(targetTag)){
            r.velocity*=0.9f;
            r.AddForce(direction* -20.0f, ForceMode.Acceleration);
        }else{
            r.AddForce(direction * 80.0f, ForceMode.Acceleration);
        }
    }

}
