using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
  public void MainMenuExit()
  {
    Application.Quit();
  }
  
 public void NewGame()
  {
        
  }

 public void LoadGame()
  {
      SceneManager.LoadScene(1);
  }

 public void MainMenuOption()
  {
        
  }
  
}
