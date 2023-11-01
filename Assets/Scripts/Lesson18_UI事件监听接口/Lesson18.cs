using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson18 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        print(eventData.delta);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("��꣨������������");
        print(eventData.position);
        print(eventData.pressPosition);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("�����룬�ֻ�������������");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("����뿪���ֻ�������������");

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("��꣨��������̧��");
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
