using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject DeathPanel;
    public GameObject levelPanel;
    public GameObject menuPanel;
    public GameObject PausePanel;
    public GameObject PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
// quit game button
public void QuitGame(){
    Application.Quit();
}
    // quit levels button
public void QuitLevel(){

        SceneManager.LoadScene(0);
        
    }
    // play again button
public void PlayAgain(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        DeathPanel.SetActive(false);
        Time.timeScale = 1;
    }
    // loads level difficulty panel

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        PlayButton.SetActive(true);
    }

    public void Levels(){
        levelPanel.SetActive(true);
        menuPanel.SetActive(false);
}
// loads easy level
public void EasyLevel(){
        SceneManager.LoadScene(1);
}
 // loads medium level
public void MediumLevel(){
        SceneManager.LoadScene(2);
}
// loads hard level
public void HardLevel(){
        SceneManager.LoadScene(3);
    }   
}
