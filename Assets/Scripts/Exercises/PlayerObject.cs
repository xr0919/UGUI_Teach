using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public AudioClip ac;

    public float moveSpeed = 10;
    public float roundSpeed = 40;
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

        //move()
        if (nowMoveDir != Vector3.zero)
        {
            //��Ŀ�귽��ת��
            //this.transform.rotation=Quaternion.LookRotation(nowMoveDir);
            this.transform.rotation=Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(nowMoveDir), roundSpeed * Time.deltaTime);
            //���泯���ƶ�
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        }

    }

    //�ƶ�
    private Vector3 nowMoveDir = Vector3.zero;
    public void Move(Vector2 dir)
    {
        nowMoveDir.x = dir.x;
        nowMoveDir.y = 0;
        nowMoveDir.z = dir.y;
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
