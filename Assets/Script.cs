using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public GameObject panel1; 
    public GameObject panel2;
    public GameObject panel3;
    public GameObject right;
    public GameObject left;
    public GameObject[] alphabets;
    public Text A;
    public Text B;
    public Text C;
    public Text D;
    public Text E;
    public int level;
    public int allscore;
    Vector3 startPosition, targetPosition;
    private Vector3 velocity = Vector3.zero;
    public float time = 1F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (level == 1)
        {
            //レベル1　ゲームスタート
        }
        if (level == 2)
        {
            //レベル2　ゲームスタート
        }
        if (level == 3)
        {
            //レベル3　ゲームスタート
        }
        if (level == 4)
        {
            //レベル4　ゲームスタート
        }
        if (level == 5)
        {
            //レベル5　ゲームスタート
        }
    }
    public void OnClick1()
    {
        panel1.gameObject.SetActive(true);
        if (allscore >= 0)
        {
            A.text = "解放済み";
        }
        else
        {
            A.text = "未解放";
        }
        if(allscore >= 10)
        {
            B.text = "解放済み";
        }
        else
        {
            B.text = "未解放";
        }
        if(allscore >= 20)
        {
            C.text = "解放済み";
        }
        else
        {
            C.text = "未解放";
        }
        if(allscore >= 30)
        {
            D.text = "解放済み";
        }
        else
        {
            D.text = "未解放";
        }
        if(allscore >= 40)
        {
            E.text = "解放済み";
        }
        else
        {
            E.text = "未解放";
        }
    }
    public void OnClick2()
    {
        panel1.gameObject.SetActive(false);
    }
    public void OnClick3()
    {
        panel2.gameObject.SetActive(true);
    }
    public void OnClick4()
    {
        panel2.gameObject.SetActive(false);
    }
    public void OnClick5()
    {
        if (allscore >= 0)
        {
            right.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            left.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
            panel3.gameObject.SetActive(false);
            level = 1;
        }
        else
        {
            A.text = "未解放です!!";
            Invoke("TextA",1);
        }
    }
    public void OnClick6()
    {
        if (allscore >= 100)
        {
            right.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            left.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
            panel3.gameObject.SetActive(false);
            level = 2;
        }
        else
        {
            B.text = "未解放です!!";
            Invoke("TextB", 1);
        }
    }
    public void OnClick7()
    {
        if (allscore >= 100)
        {
            right.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            left.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
            panel3.gameObject.SetActive(false);
            level = 3;
        }
        else
        {
            C.text = "未解放です!!";
            Invoke("TextC", 1);
        }
    }
    public void OnClick8()
    {
        if (allscore >= 100)
        {
            right.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            left.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
            panel3.gameObject.SetActive(false);
            level = 4;
        }
        else
        {
            D.text = "未解放です!!";
            Invoke("TextD", 1);
        }
    }
    public void OnClick9()
    {
        if (allscore >= 100)
        {
            right.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            left.transform.position = Vector3.SmoothDamp(new Vector3(0, 0, 0), targetPosition, ref velocity, time);
            panel1.gameObject.SetActive(false);
            panel2.gameObject.SetActive(false);
            panel3.gameObject.SetActive(false);
            level = 5;
        }
        else
        {
            E.text = "未解放です!!";
            Invoke("TextE", 1);
        }
    }
    void TextA()
    {
        A.text = "未解放";
    }
    void TextB()
    {
        B.text = "未解放";
    }
    void TextC()
    {
        C.text = "未解放";
    }
    void TextD()
    {
        D.text = "未解放";
    }
    void TextE()
    {
        E.text = "未解放";
    }
}
