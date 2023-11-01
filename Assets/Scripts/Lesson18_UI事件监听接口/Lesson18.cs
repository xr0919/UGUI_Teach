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
        print("鼠标（触摸屏）按下");
        print(eventData.position);
        print(eventData.pressPosition);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("鼠标进入，手机触摸屏不存在");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("鼠标离开，手机触摸屏不存在");

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("鼠标（触摸屏）抬起");
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
