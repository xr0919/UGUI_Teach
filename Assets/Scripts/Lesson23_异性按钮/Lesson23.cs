using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson23 : MonoBehaviour
{
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        img.alphaHitTestMinimumThreshold = 0.1f;//像素点alpha值 最小检测区域 小于就不会被射线检测  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
