using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson20 : MonoBehaviour,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        //����
        //RectTransformUtility.ScreenPointToLocalPointInRectangle
        //����1����Ը�����
        //����2�� ��Ļ��
        //����3�� �����(�����߼������)
        //����4�� ���յõ��ĵ�
        //һ�������ק�¼�ʹ��  ҡ��  װ����ק
        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            this.transform.parent as RectTransform,//������Բ���ϡ�����Ҫparent�õ�������
            eventData.position,
            eventData.enterEventCamera,
            out nowPos
            );
        this.transform.localPosition = nowPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        //RectTransformUtility ��������RectTransform�ĸ����� ��Ҫ��������ת��
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
