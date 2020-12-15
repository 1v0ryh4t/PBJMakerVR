using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collidable : MonoBehaviour
{
    public GameObject specialObj;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public UnityEvent onTriggerStay;
    public UnityEvent onCollisionEnter;
    public UnityEvent onCollisionStay;
    public UnityEvent onCollisionExit;


    private void OnTriggerEnter(Collider other)
    {
        if (specialObj == null || other == specialObj.GetComponent<Collider>())
            onTriggerEnter.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        if (specialObj == null || other == specialObj.GetComponent<Collider>())
            onTriggerStay.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (specialObj == null || other == specialObj.GetComponent<Collider>())
            onTriggerExit.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (specialObj == null || collision.collider == specialObj.GetComponent<Collider>())
            onCollisionEnter.Invoke();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (specialObj == null || collision.collider == specialObj.GetComponent<Collider>())
            onCollisionStay.Invoke();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (specialObj == null || collision.collider == specialObj.GetComponent<Collider>())
            onCollisionExit.Invoke();
    }
}
