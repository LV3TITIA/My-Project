using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOverUI;

    public static GameOverManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            //Debug.LogWarning("Il y a plus d'une instance dans de GameOverManager dans la scène");
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
    public void Loose()
    {
        GameOverUI.SetActive(true);
    }

    public void RetryButton()
    {
        //Recommencer le niveau
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("SampleScene");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
