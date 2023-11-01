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
        //������Ч
        if(MusicData.SoundIsOpen == true)
        {
            AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
            audioSource.clip = ac;
            audioSource.Play();

            //�ı�������С
            audioSource.volume = MusicData.SoundValue;

            Destroy(audioSource, 0.8f);//��̬ɾ�����
        }
        

        //��̬�����ӵ�����
        GameObject obj = Instantiate(Resources.Load<GameObject>("Bullet"),this.transform.position,this.transform.rotation);

    }
}
