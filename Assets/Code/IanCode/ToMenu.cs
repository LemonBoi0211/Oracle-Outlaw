using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMenu : MonoBehaviour
{
    
    public void OnButtonPress()
    {
       
       
        SceneManager.LoadScene("StartScreen");
        
        Debug.Log("Button clicked ");
    }
}
