using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagPanel : MonoBehaviour
{
    public static BagPanel instance;
    public ScrollRect svItems;
    public Button btnClose;
    //public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        this.gameObject.SetActive(false);
        //动态创建多个图标
        for(int i = 0; i<30;i++)
        {
            GameObject item = Instantiate(Resources.Load<GameObject>("item"));
            item.transform.SetParent(svItems.content, false);
            //设置格子位置
            item.transform.localPosition = new Vector3(10, -10, 0) + new Vector3(160 * (i % 4), -160 * (i / 4), 0);
        }
        //设置content的高
        svItems.content.sizeDelta = new Vector2 (0, Mathf.CeilToInt(30/4f) * 160);

        //关闭背包
        btnClose.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
        });
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
