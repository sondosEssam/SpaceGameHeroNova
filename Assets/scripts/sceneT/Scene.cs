using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene: MonoBehaviour
{
    public string scenetoLoad;
    public void OnTriggerEnter2D(Collider2D other){
  if(other.CompareTag("Player")&& !other.isTrigger){
    SceneManager.LoadScene(scenetoLoad);
  }

    }
    // Start is called before the first frame update
  
}
