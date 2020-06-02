using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataManager.getInstance().start();
        SceneManager.getInstance().start();
    }

    // Update is called once per frame
    void Update()
    {
        DataManager.getInstance().update();
        SceneManager.getInstance().update();
    }
}
