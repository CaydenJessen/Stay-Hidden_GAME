using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Level : MonoBehaviour
{

    public void Restart () 
    {
         Debug.Log("Restart");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  
    // Start is called before the first frame update
   // void Start()
  //  {
        
   // }

    // Update is called once per frame
  //  void Update()
  //  {
        
  //  }
}
