using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// 长按按钮脚本 提供两个事件给外部 让外部去处理对应的逻辑
/// </summary>
public class LongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //通过委托或者事件把逻辑抛出去
    public event UnityAction upEvent;
    public event UnityAction downEvent;

    public void OnPointerDown(PointerEventData eventData)
    {
        downEvent?.Invoke();//如果不为空则执行
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        upEvent?.Invoke();//如果为空则不执行
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
