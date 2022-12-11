using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionScripts : MonoBehaviour
{
   [SerializeField] private Dropdown ResDropDown;
   public void OptionBack()
   {
      SceneManager.LoadScene(0);
   }

   public void ResChange()
   {


     var RDD = ResDropDown;

      string selectedvalue = RDD.options[RDD.value].text;

      if (selectedvalue == "1920x1080")
      {
         Screen.SetResolution(1920, 1080, true);
      }
      
      else if (selectedvalue == "1280x768")
      {
         Screen.SetResolution(1280, 768, true);
      }
      
      else if (selectedvalue == "1024x768")
      {
         Screen.SetResolution(1024, 768, true);
      }
   }
}
