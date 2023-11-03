using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// ������ť�ű� �ṩ�����¼����ⲿ ���ⲿȥ�����Ӧ���߼�
/// </summary>
public class LongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //ͨ��ί�л����¼����߼��׳�ȥ
    public event UnityAction upEvent;
    public event UnityAction downEvent;

    public void OnPointerDown(PointerEventData eventData)
    {
        downEvent?.Invoke();//�����Ϊ����ִ��
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        upEvent?.Invoke();//���Ϊ����ִ��
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
