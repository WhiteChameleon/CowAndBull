using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StartGame()
    {
        print("test");
        AppearAnimal.cowsCount[0] += 2;
        AppearAnimal.bullsCount[0] += 1;
        SceneManager.LoadScene("Game");
    }
    public void GoMarket()
    {
        SceneManager.LoadScene("Market");
    }
    public void OpenMiniGame()
    {
        SceneManager.LoadScene("MiniGame");
    }
    public void Back()
    {
        SceneManager.LoadScene("Market");
    }
    public void Farm()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
