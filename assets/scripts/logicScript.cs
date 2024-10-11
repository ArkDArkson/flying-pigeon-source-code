using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

public class logicScript : MonoBehaviour
{
public string scene;

void Start() {
    scene = SceneManager.GetActiveScene().name;
}
    public int score;
    public Text text;

public float timer;

public float timetoWait = 3;

    public GameObject bird;
[ContextMenu("Increase Score")]
    public void scoreAdd() {
        score++;
        text.text = score.ToString();
    }

[ContextMenu("Kill Bird")]
    public void killBird() {
    Destroy(bird);
if (timer < timetoWait) {
    timer = timer + Time.deltaTime;
}

else {
SceneManager.LoadScene(scene);
}
    }

}
