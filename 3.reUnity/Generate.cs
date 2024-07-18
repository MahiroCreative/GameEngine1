using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    GameObject _cube;
    Vector3 _position;


    // Start is called before the first frame update
    void Start()
    {
        //Resources����ACube�v���n�u���擾
        _cube = (GameObject)Resources.Load("Cube");
        //Cube����������Ăق����ꏊ
        _position = new Vector3(0,6,0);
    }

    public void OnClick()
    {
        //Cube�̐���
        Instantiate(_cube,_position,Quaternion.identity);
    }

}
