using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour {

	public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
