using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
public class ToMenu : MonoBehaviour
{
    int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnButtonPress()
    {
        n++;
        SceneManager.LoadScene("StartScreen");
        Debug.Log("Button clicked " + n + " times.");
    }
}
