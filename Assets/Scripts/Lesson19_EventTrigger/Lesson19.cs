using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson19 : MonoBehaviour
{
    public EventTrigger et;
    // Start is called before the first frame update
    void Start()
    {
        //2.代码添加
        //声明一个希望监听的事件对象
        EventTrigger.Entry entry = new EventTrigger.Entry();
        //声明 事件的类型
        entry.eventID = EventTriggerType.PointerUp;
        //监听函数关联
        entry.callback.AddListener((data) =>
        {
            print("抬起");
        });

        //把声明好的事件对象 加入到EventTrigger中
        et.triggers.Add(entry);
    }
    //1.拖脚本
    public void TestPointerEnter(BaseEventData data)
    {
        print("enter");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
