using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    
    private GameManager gameManager;
  
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SetDifficulty(int diff)
    {
        MainManager.Instance.difficulty = diff;
    }
  
}
