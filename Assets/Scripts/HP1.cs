using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HP1 : MonoBehaviour
{
    int HP= 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnScore(int num)// 外部ファイルから、ＨＰが減る命令を受け取る。
    {
        HP -= num;
        Text HP1 = gameObject.GetComponent<Text>();
        HP1.text = HP.ToString();

    }


}
