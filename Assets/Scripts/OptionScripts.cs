using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionScripts : MonoBehaviour
{
 
   public void OptionBack()
   {
      SceneManager.LoadScene(0);
   }

  /* public void ResChange()
   {
      resolutions = Screen.resolutions;

      ResDropDown = GetComponent<Dropdown>();

      UnityAction<int> action = OnValueChanged;
      
      ResDropDown.onValueChanged.AddListener(action);
   }
   */

  public void OnValueChanged(int value)
   {
      Debug.Log(value.ToString());
      
      if (value.ToString() == "0")
      {
       Screen.SetResolution(1920, 1080, (FullScreenMode)60);   
      }
      
      else if (value.ToString() == "1")
      {
         Screen.SetResolution(1280, 768, (FullScreenMode)60);  
      }
      
      else if (value.ToString() == "2")
      {
         Screen.SetResolution(1024, 768, (FullScreenMode)60);
      }
      
      
   }
}
