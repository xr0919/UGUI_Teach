using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scrollbar sb = GetComponent<Scrollbar>();
        print(sb.value);

        //�������2.
        sb.onValueChanged.AddListener((v) =>
        {
            print("lambda���ʽ ������ " + v);
        });
    }
    //1.�Ͻű�
    public void ChangeValue(float v)
    {
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
