using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOvertime : MonoBehaviour
{
    public float lifetime = 1.5f;
    
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }

    void Update()
    {
        
    }
}