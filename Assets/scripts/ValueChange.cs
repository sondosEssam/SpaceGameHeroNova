using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueChange : MonoBehaviour
{
  Image timeBar;
  public float maxTime = 20f;
  float timeleft;
  public GameObject timeUpText;

    void Start()
    {
     timeUpText.SetActive(false);
     timeBar =GetComponent<Image>();
     timeleft = maxTime;    
    }

    // Update is called once per frame
    void Update()
    {
      if(timeleft >3){
        timeleft -= Time.deltaTime;
        timeBar.fillAmount =timeleft / maxTime;
      }  else{
         timeUpText.SetActive(true);
         Time.timeScale =0 ;

      }
    }
}
