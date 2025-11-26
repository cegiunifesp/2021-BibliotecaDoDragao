using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Platform Specific Objects")]
    public GameObject webGLObject;
    public GameObject desktopAndroidObject;

    void Start()
    {
        // Ensure both are disabled initially to avoid conflicts
        if (webGLObject != null) webGLObject.SetActive(false);
        if (desktopAndroidObject != null) desktopAndroidObject.SetActive(false);

        #if UNITY_WEBGL
            // Logic for WebGL
            if (webGLObject != null) webGLObject.SetActive(true);
        #elif UNITY_ANDROID || UNITY_STANDALONE
            // Logic for Android or Desktop (Windows/Mac/Linux)
            if (desktopAndroidObject != null) desktopAndroidObject.SetActive(true);
        #endif
    }

    // Start is called before the first frame update
    public void StartGameEasy()
    {
        //Chamada função jogo
        print("Start");
    }

    public void StartGameMedium()
    {
        //Chamada função jogo
        print("Start");
    }

    public void StartGameHard()
    {
        //Chamada função jogo
        print("Start");
    }

    public void QuitButton()
    {
        //Chamada sair do jogo
        Application.Quit();
        print("Quit");
    }

    public void ButtonPressSound()
    {
        //Play no som de botão
        print("Click");
    }

}
