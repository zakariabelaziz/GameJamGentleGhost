using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{

    public Slider _loadingBar;
    public GameObject _loadingImage;


    private AsyncOperation async;


    public void ClickAsync(int level)
    {
        _loadingImage.SetActive(true);
        StartCoroutine(LoadLevelWithBar(level));
    }

    public void OnQuit()
    {
        Application.Quit();
    }


    IEnumerator LoadLevelWithBar(int level)
    {
        async = Application.LoadLevelAsync(level);
        while (!async.isDone)
        {
            _loadingBar.value = async.progress;
            yield return new WaitForSeconds(10.0f);
        }
    }
}
