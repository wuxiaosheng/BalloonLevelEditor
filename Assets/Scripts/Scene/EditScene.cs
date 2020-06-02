using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditScene : Scene
{
    public override void onEnter()
    {
        base.onEnter();
        replacePanel<EditPanel>("EditPanel");
    }
}
