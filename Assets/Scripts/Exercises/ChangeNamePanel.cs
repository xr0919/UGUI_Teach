using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNamePanel : MonoBehaviour
{
    public static ChangeNamePanel instance;
    //���������
    public InputField inputName;
    //ȷ����ť
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        this.gameObject.SetActive(false);

        btn.onClick.AddListener(() => {
            //���������������� ��ֵ�� ��Ϸ���� ���ֿؼ�
            GamePanel.instance.txtName.text = inputName.text;
            //��ȷ���������
            this.gameObject.SetActive(false);
        });
    }

    public string EndEdit(string str)
    {
        return str;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
