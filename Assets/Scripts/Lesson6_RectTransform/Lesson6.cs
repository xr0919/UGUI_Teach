using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //得到RectTransform 继承自transform 高亮后F12进入RectTransform
        print((this.transform as RectTransform).sizeDelta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
