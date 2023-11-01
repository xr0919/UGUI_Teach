using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject obj = Instantiate(Resources.Load<GameObject>("Bullet"),this.transform.position,this.transform.rotation);
    }
}
