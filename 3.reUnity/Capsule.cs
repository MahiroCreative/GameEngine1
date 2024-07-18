using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    GameObject _cap;

    // Start is called before the first frame update
    void Start()
    {
        _cap = GameObject.Find("Capsule");
    }

    private void Update()
    {
        //���[�J���X�P�[����1��菬����������A�傫���Ȃ�
        if(_cap.transform.localScale.x < 1)
        {
            _cap.transform.localScale += new Vector3(0.002f, 0.002f, 0.002f);
        }
    }


    public void OnCK()
    {
        _cap.transform.localScale = new Vector3(0.9f,0.9f,0.9f);
    }
}
