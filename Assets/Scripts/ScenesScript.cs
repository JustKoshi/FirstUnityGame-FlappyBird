using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesScript : MonoBehaviour
{
    public static ScenesScript Instance;
    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        MainMenu,
        Game
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
    
    public void LoadNewGame() {
        SceneManager.LoadScene(Scene.Game.ToString());
    }
    
}
