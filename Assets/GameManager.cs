using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float slowDown = 10f;
    public void EndGame()
    {
        StartCoroutine(restartLevel());   
    }

    IEnumerator restartLevel()
    {
        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;
        //before 1 sec 
        yield return new WaitForSeconds(1f / slowDown);

        Time.timeScale = 1f ;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;
        //after 1 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
