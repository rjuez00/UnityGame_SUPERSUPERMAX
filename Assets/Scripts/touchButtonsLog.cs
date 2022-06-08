using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchButtonsLog : MonoBehaviour
{
    public float verticalTouch = 0;
    public float horizontalTouch = 0;

    public bool boostTouch = false;
    public bool handBrakeTouch = false;
    public bool gearUpTouch = false;
    public bool gearDownTouch = false;


    public void gotoHomePress(){
        string sceneName = SceneManager.GetActiveScene().name;
        if ((sceneName.Contains("Menu") || sceneName.Contains("Loading") || sceneName.Contains("awake")))
        {
            return;
        }
        else if (sceneName.Contains("Lobby") == true)
        {
            Application.Quit();
        }

        else
        {
            SceneLoader.LoadLevel("Lobby");
        }
    }
    
    public void reloadScenePress(){
        string sceneName = SceneManager.GetActiveScene().name;
        if (!(sceneName.Contains("Menu") || sceneName.Contains("Loading") || sceneName.Contains("awake")))
        {
            SceneLoader.LoadLevel(sceneName);
        }
    }





    public void positiveVerticalPress(){
        verticalTouch = 1;
    }
    public void verticalUnpress(){
        verticalTouch = 0;
    }
    public void negativeVerticalPress(){
        verticalTouch = -1;
    }





    public void positiveHorizontalPress(){
        horizontalTouch = 1;
    }
    public void horizontalUnpress(){
        horizontalTouch = 0;
    }
    public void negativeHorizontalPress(){
        horizontalTouch = -1;
    }



    public void boostPress(){
        boostTouch = true;
    }
    public void boostUnpress(){
        boostTouch = false;
    }



    public void handbrakePress(){
        handBrakeTouch = true;
    }
    public void handbrakeUnpress(){
        handBrakeTouch = false;
    }



    public void gearUpPress(){
        gearUpTouch = true;
    }

    public void gearUpUnpress(){
        gearUpTouch = false;
    }




    public void gearDownPress(){
        gearDownTouch = true;
    }
    public void gearDownUnpress(){
        gearDownTouch = false;
    }




    

}
