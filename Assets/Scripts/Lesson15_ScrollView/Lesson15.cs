using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ע����ScrollRect
        ScrollRect sr = GetComponent<ScrollRect>();
        //�ı����ݴ�С ��������϶��٣��ǳ���Ҫ��������
        sr.content.sizeDelta = new Vector2(400, 400);
        //�ı���ʾ�ľ���λ�� �ٷֱ�
        sr.normalizedPosition = new Vector2(0, 0.5f);

        //������� 2.���ټ���scrollview
        sr.onValueChanged.AddListener((vec) =>
        {
            print(vec);
        });
    }

    //1.
    public void ChangeValue(Vector2 v)
    {
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
