using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        initPlayerControl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void initLastData()
    {

    }

    private void initPlayerControl()
    {
        GameObject obj = Resources.Load<GameObject>("Entity/playerControl");
        var player = Instantiate(obj);
        player.name = "playerControl";
        player.transform.position = GameData.Data.LastBornPos;
        var src = player.GetComponent<MainControl>();
        src.initData();
    }

}
