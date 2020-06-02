
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : Singleton<SceneManager>
{
    private Scene _scene;
    public void start() {
        replaceScene<StartScene>();
    }

    public void update() {
        if (_scene != null) {
            _scene.update();
        }
    }

    public void replaceScene<T>() where T : Scene, new() {
        if (_scene != null) {
            _scene.onExit();
        }
        _scene = new T();
        _scene.onEnter();
    }

    public Scene getScene() {
        return _scene;
    }
}
