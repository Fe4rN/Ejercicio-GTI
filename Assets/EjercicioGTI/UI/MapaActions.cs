using UnityEngine;
using UnityEngine.SceneManagement;

public class MapaActions : MonoBehaviour
{
    public void Level0(int level){
        SceneManager.LoadScene($"Level{level}");
    }
}
