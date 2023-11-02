using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Retry : MonoBehaviour
{
    
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("BlowUp",false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnButtonPress()
    {
       // SceneManager.LoadScene("MainScene");
        StartCoroutine(Pressed());
        
        Debug.Log("click");
    }
    private IEnumerator Pressed()
    {
        Debug.Log("ipress");
        anim = GetComponent<Animator>();
        anim.SetBool("BlowUp", true);
       yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MainScene");
    }
}
