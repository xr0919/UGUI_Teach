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

        //�����ṩ�ĵ����� �õ����ڼ���״̬��Toggle
        foreach(Toggle item in togGroup.ActiveToggles()) {
            
        }

        //�¼�����
        //1.�Ͻű�
        //2.�������(ͨ��������ӿ���private)
        tog.onValueChanged.AddListener(ChangeValue2);
        //�������ʽ
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
