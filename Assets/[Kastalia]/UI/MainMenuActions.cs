using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public void Play(){
        //Debug.Log("Play");
        SceneManager.LoadScene("Mapa"); 
    }

    public void Quit(){
        //Debug.Log("Quit");
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
        
    }
}
