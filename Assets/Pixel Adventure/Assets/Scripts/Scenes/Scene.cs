using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
     [SerializeField] private string nameScene;
     [SerializeField] private GameObject tela1;
     [SerializeField] private GameObject tela2;


    public string NameScene { get => nameScene; set => nameScene = value; }
    public void BottonBack()
    {
        ControllerScene.SetScene(nameScene);
    }
    public void SetScene() 
    {
        
        StartCoroutine(DelayedSetScene());
       
    }

    IEnumerator DelayedSetScene()
    {
        tela1.SetActive(true);
        
        yield return new WaitForSeconds(12);

        tela2.SetActive(true);

        yield return new WaitForSeconds(12);

        ControllerScene.SetScene(nameScene);
    }
}
