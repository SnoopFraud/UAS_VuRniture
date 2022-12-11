using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UiManagement : MonoBehaviour
{
    //Objects
    public GameObject textObj;

    //Game Var
    public string objek_price;
    public string url;

    //Component
    TextMeshProUGUI tmptext;

    private void Awake()
    {
        tmptext = textObj.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmptext.text = objek_price;
    }

    public void UrlClick()
    {
        Application.OpenURL(url);
    }

    public void BackButton(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
