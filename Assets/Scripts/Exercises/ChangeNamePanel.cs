using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNamePanel : MonoBehaviour
{
    public static ChangeNamePanel instance;
    //输入的名字
    public InputField inputName;
    //确定按钮
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        this.gameObject.SetActive(false);

        btn.onClick.AddListener(() => {
            //把输入框输入的内容 赋值给 游戏面板的 名字控件
            GamePanel.instance.txtName.text = inputName.text;
            //点确定隐藏面板
            this.gameObject.SetActive(false);
        });
    }

    public string EndEdit(string str)
    {
        return str;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
