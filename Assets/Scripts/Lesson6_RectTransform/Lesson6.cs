using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�õ�RectTransform �̳���transform ������F12����RectTransform
        print((this.transform as RectTransform).sizeDelta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
