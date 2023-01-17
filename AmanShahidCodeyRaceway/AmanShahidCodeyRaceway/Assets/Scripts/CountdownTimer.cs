using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codey;

    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTime > 0) {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codey.Speed = 0;
        } else if (totalCountdownTime <= 0 && totalLapTime > 0) {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            codey.Speed = 15;
        } else {
            SceneManager.LoadScene(1);
        }    
        
    }
}
