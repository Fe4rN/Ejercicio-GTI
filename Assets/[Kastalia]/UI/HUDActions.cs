using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDActions : MonoBehaviour
{
    public void Pause() {
        SceneManager.LoadScene("Pausa", LoadSceneMode.Additive);
        
    }

    public void Resume(){
        SceneManager.UnloadSceneAsync("Pausa");
    }
}
