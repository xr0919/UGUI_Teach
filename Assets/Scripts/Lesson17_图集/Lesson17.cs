using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //����ͼ������Ҫ���������ռ�
        SpriteAtlas sa = Resources.Load<SpriteAtlas>("MyAtlas");
        //��ͼ���м���ָ�����ֵ�Сͼ
        sa.GetSprite("bk");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
