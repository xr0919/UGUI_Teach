using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObject : MonoBehaviour
{
    public float moveSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        //ÑÓ³ÙÉ¾³ý¶ÔÏó
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(moveSpeed * Vector3.forward * Time.deltaTime);
    }
}
