using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //加载图集，需要引用命名空间
        SpriteAtlas sa = Resources.Load<SpriteAtlas>("MyAtlas");
        //从图集中加载指定名字的小图
        sa.GetSprite("bk");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
