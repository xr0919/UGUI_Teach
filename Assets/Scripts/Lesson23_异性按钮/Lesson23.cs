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
        img.alphaHitTestMinimumThreshold = 0.1f;//���ص�alphaֵ ��С������� С�ھͲ��ᱻ���߼��  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
