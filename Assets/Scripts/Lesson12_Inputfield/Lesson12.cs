using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputField input = this.GetComponent<InputField>();
        print(input.text);
        input.text = "156165";

        //代码控制 2.代码添加
        input.onValueChange.AddListener((str) => {
            print("代码添加1");
        });
        input.onEndEdit.AddListener((str) => {
            print("代码添加2");
        });
    }
    //1.拖脚本
    public void ChangeValue(string str)
    {
        print("changed:" + str);
    }
    //结束编辑时调用 按回车或者光标消失
    public void EndInput(string str)
    {
        print("end input:" + str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
