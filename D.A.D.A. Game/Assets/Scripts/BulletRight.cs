using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRight : MonoBehaviour
{
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(bulletSpeed * Time.deltaTime, 0);
    }
}
