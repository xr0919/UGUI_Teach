using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //slide 代码控制
        Slider s = this.GetComponent<Slider>();
        print(s.value);

        //代码控制：2.代码添加
        s.onValueChanged.AddListener((v) =>
        {
            print("代码添加的监听： " + v);
        });
        s.onValueChanged.RemoveAllListeners();
    }
    //1.拖脚本
    //需要传入一个参数，具体是否需要可以从unity面板看到
    public void ChangeValue(float v)
    {
        print(v);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
