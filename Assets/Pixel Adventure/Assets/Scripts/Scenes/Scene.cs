using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
     [SerializeField] private string nameScene;
     [SerializeField] private GameObject tela1;
     [SerializeField] private GameObject tela2;
     [SerializeField] private GameObject music;

    public Button button;
    public AudioSource audioSource;


    public string NameScene { get => nameScene; set => nameScene = value; }

    void Start()
    {
        // Adiciona um listener para o evento de clique do botão
        button.onClick.AddListener(PlaySound);
    }

    public void BottonBack()
    {
        ControllerScene.SetScene(nameScene);
    }
    public void SetScene() 
    {
        music.SetActive(false);
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

    void PlaySound()
    {
        // Verifica se há um AudioSource associado e um AudioClip
        if (audioSource && audioSource.clip)
        {
            // Reproduz o som
            audioSource.PlayOneShot(audioSource.clip);
        }
    }

}
