using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    
    
    public float bulletSpeed;

    void Update()
    { 
        transform.position -= new Vector3(bulletSpeed * Time.deltaTime, 0);
    }

    
    
}
