using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTimer : MonoBehaviour
{
    public float delay = 5f;
    public string sceneName;

    void Start()
    {
        StartCoroutine(LoadSceneAfterTime());
    }

    IEnumerator LoadSceneAfterTime()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
