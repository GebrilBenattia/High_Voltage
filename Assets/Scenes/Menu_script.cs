using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_script : MonoBehaviour
{
    [SerializeField] private GameObject[] MenuPageList;
    void Start()
    {
        foreach(GameObject Page in MenuPageList)
        {
            Page.SetActive(false);
            RectTransform PageRect = Page.GetComponent<RectTransform>();
            PageRect.anchorMin = Vector2.zero;
            PageRect.anchorMax = Vector2.one;
        }
        MenuPageList[0].SetActive(true); 
    }
    public void SwitchPage(int index)
    {
        foreach(GameObject Page in MenuPageList)
        {
            Page.SetActive(false);
        }
        MenuPageList[index].SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}