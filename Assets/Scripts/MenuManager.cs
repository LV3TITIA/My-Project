using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject WinUI;

    [SerializeField]
    private GameObject LooseUI;

    public static MenuManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            //Debug.LogWarning("Il y a plus d'une instance dans de MenuManager dans la scène");
            return;
        }

        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnPlayerWin()
    {
        WinUI.SetActive(true);
    }

    public void OnPlayerLoose() 
    {
        LooseUI.SetActive(true);
    }

    public void RetryButton()
    {
        //Recommencer le niveau
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Recharger la scène
    }
    
    public void MainMenuButton()
    {

    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
