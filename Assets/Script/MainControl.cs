using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class MainControl : MonoBehaviour
{
    private static MainControl maincontrol=null;
    public static MainControl playerControl
    {
        get
        {
            return maincontrol;
        }
    }

    private Vector2 targetPos;
    private float movespeed;






    public void initData()
    {
        targetPos = transform.position;
        movespeed = 2;
    }


    // Update is called once per frame
    void Update()
    {
        moveListener();
        if (Input.GetKeyDown(KeyCode.A))
        {
            testMethod();
        }
    }

    private void moveListener()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Vector2.Distance(transform.position,targetPos) > 0.1f)
        {
            Vector2 pos = targetPos - (Vector2)transform.position;
            transform.position = (Vector2)transform.position + pos.normalized * movespeed * Time.deltaTime;

        }

    }
















    void testMethod()
    {
        LuaEnv env = new LuaEnv();
        env.DoString("require  'project/textFile' ");
        LuaFunction fun = env.Global.Get<LuaFunction>("ShowGame");
        fun.Call();
    }


}
