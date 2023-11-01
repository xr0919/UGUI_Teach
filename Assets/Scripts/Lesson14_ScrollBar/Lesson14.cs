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

        //代码控制2.
        sb.onValueChanged.AddListener((v) =>
        {
            print("lambda表达式 监听： " + v);
        });
    }
    //1.拖脚本
    public void ChangeValue(float v)
    {
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
