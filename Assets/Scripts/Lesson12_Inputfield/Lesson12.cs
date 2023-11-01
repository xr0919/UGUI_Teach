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

        //������� 2.�������
        input.onValueChange.AddListener((str) => {
            print("�������1");
        });
        input.onEndEdit.AddListener((str) => {
            print("�������2");
        });
    }
    //1.�Ͻű�
    public void ChangeValue(string str)
    {
        print("changed:" + str);
    }
    //�����༭ʱ���� ���س����߹����ʧ
    public void EndInput(string str)
    {
        print("end input:" + str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
