using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{   
    public string nextScene;
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(nextScene);
    }
}