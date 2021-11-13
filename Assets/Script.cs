using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public GameObject[] gameobject;//0~2はパネル、3~4は枠組み、5~31はアルファベット;
    public Text[] text;//0~4は選択画面の右側のテキスト
    public int[] Int;//0はレベル、1は今までの合計スコア、2はゲーム開始画面に出るやつに使うやつの時間
    public float[] Float;//0~1はゲーム開始画面に出るやつに使うやつの距離、2はーム開始画面に出るやつに使うやつの速度
    private Vector3 Tarpos = new Vector3(5.5f, 0, 0);
    private Vector3 Tarpos2 = new Vector3(-5.5f, 0, 0);
    private Vector3 Defpos = new Vector3(0, 0, 0);
    private Vector3 Defpos2 = new Vector3(0, 0, 0);
    private bool trigar = false;
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        Float[0] = Vector3.Distance(Tarpos, Defpos);
        Float[1] = Vector3.Distance(Tarpos2, Defpos2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Int[0] == 1)
        {
            //レベル1　ゲームスタート
        }
        if (Int[0] == 2)
        {
            //レベル2　ゲームスタート
        }
        if (Int[0] == 3)
        {
            //レベル3　ゲームスタート
        }
        if (Int[0] == 4)
        {
            //レベル4　ゲームスタート
        }
        if (Int[0] == 5)
        {
            //レベル5　ゲームスタート
        }
        if (trigar == true)
        {
            gameobject[3].transform.position = Vector3.Lerp(Tarpos, Defpos, t*Float[2]/Float[0]);
            gameobject[4].transform.position = Vector3.Lerp(Tarpos2, Defpos2, t * Float[2] / Float[1]); ;
            t+=0.1f*Time.deltaTime;
        }
    }
    public void OnClick1()
    {
        gameobject[0].gameObject.SetActive(true);
        if (Int[1] >= 0)
        {
            text[0].text = "解放済み";
        }
        else
        {
            text[0].text = "未解放";
        }
        if(Int[1] >= 10)
        {
            text[1].text = "解放済み";
        }
        else
        {
            text[1].text = "未解放";
        }
        if(Int[1] >= 20)
        {
            text[2].text = "解放済み";
        }
        else
        {
            text[2].text = "未解放";
        }
        if(Int[1] >= 30)
        {
            text[3].text = "解放済み";
        }
        else
        {
            text[3].text = "未解放";
        }
        if(Int[1] >= 40)
        {
            text[4].text = "解放済み";
        }
        else
        {
            text[4].text = "未解放";
        }
    }
    public void OnClick2()
    {
        gameobject[0].gameObject.SetActive(false);
    }
    public void OnClick3()
    {
        gameobject[1].gameObject.SetActive(true);
    }
    public void OnClick4()
    {
        gameobject[1].gameObject.SetActive(false);
    }
    public void OnClick5()
    {
        if (Int[1] >= 0)
        {
            trigar = true;
            gameobject[0].gameObject.SetActive(false);
            gameobject[1].gameObject.SetActive(false);
            gameobject[2].gameObject.SetActive(false);
            Int[0] = 1;
        }
        else
        {
            text[0].text = "未解放です!!";
            Invoke("TextA",1);
        }
    }
    public void OnClick6()
    {
        if (Int[1] >= 100)
        {
            trigar = true;
            gameobject[0].gameObject.SetActive(false);
            gameobject[1].gameObject.SetActive(false);
            gameobject[2].gameObject.SetActive(false);
            Int[0] = 2;
        }
        else
        {
            text[1].text = "未解放です!!";
            Invoke("TextB", 1);
        }
    }
    public void OnClick7()
    {
        if (Int[1] >= 100)
        {
            trigar = true;
            gameobject[0].gameObject.SetActive(false);
            gameobject[1].gameObject.SetActive(false);
            gameobject[2].gameObject.SetActive(false);
            Int[0] = 3;
        }
        else
        {
            text[2].text = "未解放です!!";
            Invoke("TextC", 1);
        }
    }
    public void OnClick8()
    {
        if (Int[1] >= 100)
        {
            trigar = true;
            gameobject[0].gameObject.SetActive(false);
            gameobject[1].gameObject.SetActive(false);
            gameobject[2].gameObject.SetActive(false);
            Int[0] = 4;
        }
        else
        {
            text[3].text = "未解放です!!";
            Invoke("TextD", 1);
        }
    }
    public void OnClick9()
    {
        if (Int[1] >= 100)
        {
            gameobject[0].gameObject.SetActive(false);
            gameobject[1].gameObject.SetActive(false);
            gameobject[2].gameObject.SetActive(false);
            Int[0] = 5;
        }
        else
        {
            text[4].text = "未解放です!!";
            Invoke("TextE", 1);
        }
    }
    void TextA()
    {
        text[0].text = "未解放";
    }
    void TextB()
    {
        text[1].text = "未解放";
    }
    void TextC()
    {
        text[2].text = "未解放";
    }
    void TextD()
    {
        text[3].text = "未解放";
    }
    void TextE()
    {
        text[4].text = "未解放";
    }
}
