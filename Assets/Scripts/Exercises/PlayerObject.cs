using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
            Fire();
        }
    }

    public void Fire()
    {
        //播放音效
        if(MusicData.SoundIsOpen == true)
        {
            AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
            audioSource.clip = ac;
            audioSource.Play();

            //改变音量大小
            audioSource.volume = MusicData.SoundValue;

            Destroy(audioSource, 0.8f);//动态删除组件
        }
        

        //动态创建子弹对象
        GameObject obj = Instantiate(Resources.Load<GameObject>("Bullet"),this.transform.position,this.transform.rotation);

    }
}
