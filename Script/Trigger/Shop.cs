using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("MiniGame");
    }
}
