using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoulderTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent boulderTrigger;

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            boulderTrigger.Invoke();
        }
    }

}
