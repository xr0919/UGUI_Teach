using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.transition = Selectable.Transition.None;

        Image img = this.GetComponent<Image>();

        btn.onClick.AddListener(ClickBtn2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBtn1()
    {
        print("按钮点击1 通过拖代码形式11");
        
    }
    private void ClickBtn2()
    {
        print("按钮点击2 通过拖代码形式22");

    }
}
