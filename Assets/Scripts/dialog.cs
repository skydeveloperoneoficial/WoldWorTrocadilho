using TMPro;
using UnityEngine;

public class dialog : MonoBehaviour
{
    public Canvas canvasParaDesativar;
    public float tempoParaDesativar = 8f;
    public GameObject objeto;
    public TextMeshProUGUI pergunta;
    public TextMeshProUGUI resposta;

    void Start()
    {
        resposta.enabled = false;
        // Chama o método DesativarCanvas após o tempo especificado
        Invoke("DesativarrCanvas", tempoParaDesativar);
    }

    void DesativarrCanvas()
    {
        // Desativa o Canvas
        canvasParaDesativar.enabled = false;
    }

    private void Update()
    {
        if (objeto == null)
        {
            canvasParaDesativar.enabled = true;
            pergunta.enabled = false;
            resposta.enabled = true;
        }
    }
}
