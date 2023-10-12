using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PouseMenu : MonoBehaviour
{
    bool IsGameisPouse=false;
    public GameObject PouseMenuUI;
   
    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if (IsGameisPouse)
            {
                Resume();
            }
            else
            {
                Pouse();
            }
        }
    }
  public void Resume()
    {
        PouseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsGameisPouse = false;
    }
     void Pouse()
    {
        PouseMenuUI.SetActive(true);    
        Time.timeScale = 0f;
        IsGameisPouse = true;   
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");   
    }
    public void QuitFun()
    {
        Application.Quit();
        Debug.Log("Quiting .. . . .");
    }
   
}
