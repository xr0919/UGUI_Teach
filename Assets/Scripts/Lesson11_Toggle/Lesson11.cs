using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Toggle tog = this.GetComponent<Toggle>();
        tog.isOn = true;

        ToggleGroup togGroup = this.GetComponent<ToggleGroup>();
        togGroup.allowSwitchOff = true;

        //遍历提供的迭代器 得到处于激活状态的Toggle
        foreach(Toggle item in togGroup.ActiveToggles()) {
            
        }

        //事件监听
        //1.拖脚本
        //2.代码添加(通过代码添加可以private)
        tog.onValueChanged.AddListener(ChangeValue2);
        //匿名表达式
        tog.onValueChanged.AddListener((b) => { });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeValue(bool isOn)
    {
        print("changed" + isOn);

    }
    public void ChangeValue2(bool isOn)
    {
        print("Listener changed" + isOn);

    }
}
