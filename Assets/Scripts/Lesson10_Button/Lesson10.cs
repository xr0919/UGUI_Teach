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
        print("��ť���1 ͨ���ϴ�����ʽ11");
        
    }
    private void ClickBtn2()
    {
        print("��ť���2 ͨ���ϴ�����ʽ22");

    }
}
