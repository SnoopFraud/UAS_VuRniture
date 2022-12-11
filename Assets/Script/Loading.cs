using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject LoadingBar;
    public Slider slider;

    private void Awake()
    {
        LoadLevel("Menu");
    }

    // Start is called before the first frame update
    public void LoadLevel(string Scene)
    {
        StartCoroutine(LoadAsync(Scene));
        
    }

    IEnumerator LoadAsync(string indexscene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(indexscene);
        LoadingBar.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
