using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //注意是ScrollRect
        ScrollRect sr = GetComponent<ScrollRect>();
        //改变内容大小 具体可以拖多少（非常重要！！！）
        sr.content.sizeDelta = new Vector2(400, 400);
        //改变显示的具体位置 百分比
        sr.normalizedPosition = new Vector2(0, 0.5f);

        //代码控制 2.很少监听scrollview
        sr.onValueChanged.AddListener((vec) =>
        {
            print(vec);
        });
    }

    //1.
    public void ChangeValue(Vector2 v)
    {
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
