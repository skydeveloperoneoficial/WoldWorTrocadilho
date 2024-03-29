using UnityEngine;
using System.Threading.Tasks;
public enum stateMachine
{
    START,
    PAUSED,
    PLAY,
    WIN,
    DEAD,
    NULL
}

public class GameController : MonoBehaviour
{
    private stateMachine currentState = stateMachine.START;
    private stateMachine lastState = stateMachine.NULL;

    public CharacterMoviment moviment;
    public AnimationCharacter animationCharacter;
    public GameObject Winneer, gameOver, Paused, character;
    public static bool RestartSO = false;





    private void Update()
    {
        HandleStateMachine();
    }

    private void HandleStateMachine()
    {
        switch (currentState)
        {
            case stateMachine.START:
                StartStateLogic();
                break;

            case stateMachine.PAUSED:
                PausedStateLogic();
                break;

            case stateMachine.PLAY:
                PlayStateLogic();
                break;

            case stateMachine.WIN:
                WinStateLogic();
                break;

            case stateMachine.DEAD:
                DeadStateLogic();
                break;
        }
    }

    private void StartStateLogic()
    {
        // reinicia o Windows ativado
        RestartSO = true;
        // Configura��es iniciais e transi��o para o estado PLAY.
        SwitchState(stateMachine.PLAY);
    }

    private void PausedStateLogic()
    {

        // Mostra o menu de pausa e manipula entradas b�sicas.
        BasicInputs();
        
        Paused.SetActive(true);
    }

    private void PlayStateLogic()
    {

        // Atualiza o movimento do personagem e outras a��es do jogo.



        moviment.HandleMovement();
        moviment.HandleInput();
        animationCharacter.PlayAnimation();
        BasicInputs();
        gameOver.SetActive(false);
        Paused.SetActive(false);
        Winneer.SetActive(false);

    }

    private void WinStateLogic()
    {

        // Mostra uma tela de vit�ria e executa a��es relacionadas � vit�ria.
        BasicInputs();

        // Outras a��es relacionadas � vit�ria.
    }

    private void DeadStateLogic()
    {

        // Mostra uma tela de derrota e desativa o personagem.
        gameOver.SetActive(true);
        character.SetActive(false);
        // Reiniciar
        ReiniciarSo();

        
        
    }

    public void SwitchState(stateMachine nextState)
    {
        lastState = currentState;
        currentState = nextState;
    }

    public stateMachine GetCurrentState()
    {
        return currentState;
    }
    public static void ReiniciarSo()
    {
        if (RestartSO)
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0");
        }
        
    }
    //
    public static void DesableRestart() 
    {
        RestartSO = false;
    }
    private void BasicInputs()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            DesableRestart();
        }
        if (Input.GetKeyDown(KeyCode.Pause) && currentState == stateMachine.PLAY)
        {
            SwitchState(stateMachine.PAUSED);
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Pause) && currentState == stateMachine.PAUSED)
        {
            SwitchState(stateMachine.PLAY);
            Time.timeScale = 1;
        }
    }
}
