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
        //2.�������
        //����һ��ϣ���������¼�����
        EventTrigger.Entry entry = new EventTrigger.Entry();
        //���� �¼�������
        entry.eventID = EventTriggerType.PointerUp;
        //������������
        entry.callback.AddListener((data) =>
        {
            print("̧��");
        });

        //�������õ��¼����� ���뵽EventTrigger��
        et.triggers.Add(entry);
    }
    //1.�Ͻű�
    public void TestPointerEnter(BaseEventData data)
    {
        print("enter");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
