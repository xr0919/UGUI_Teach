using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //slide �������
        Slider s = this.GetComponent<Slider>();
        print(s.value);

        //������ƣ�2.�������
        s.onValueChanged.AddListener((v) =>
        {
            print("������ӵļ����� " + v);
        });
        s.onValueChanged.RemoveAllListeners();
    }
    //1.�Ͻű�
    //��Ҫ����һ�������������Ƿ���Ҫ���Դ�unity��忴��
    public void ChangeValue(float v)
    {
        print(v);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
