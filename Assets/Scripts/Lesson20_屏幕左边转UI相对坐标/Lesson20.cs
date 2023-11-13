using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lesson20 : MonoBehaviour,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        //方法
        //RectTransformUtility.ScreenPointToLocalPointInRectangle
        //参数1：相对父对象
        //参数2： 屏幕点
        //参数3： 摄像机(做射线检测的相机)
        //参数4： 最终得到的点
        //一般配合拖拽事件使用  摇杆  装备拖拽
        Vector2 nowPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            this.transform.parent as RectTransform,//挂载在圆点上。所以要parent得到父对象
            eventData.position,
            eventData.enterEventCamera,
            out nowPos
            );
        this.transform.localPosition = nowPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        //RectTransformUtility 公共类是RectTransform的辅助类 主要用作坐标转换
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
