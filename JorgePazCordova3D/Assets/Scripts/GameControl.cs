using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    static public GameControl instance ;
    public CharacterBaseMov3D currentPlayer;
    public UIManager uIManager;
    bool inTransition;

	// Creaciòn de Singleton
	void Awake () {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            if (instance != this) {
                if (gameObject != instance.gameObject){
                    Destroy(gameObject);
                }else{
                    Destroy(this);
                }
            }
        }
	}

	public void StartRespawnProcess() {
        if(!inTransition){
            StartCoroutine(RespawnProcess());
            inTransition = true;
        }
	}

    IEnumerator RespawnProcess () {
        yield return uIManager.FadeProcess(currentPlayer.Respawn);

        while (!currentPlayer.grounded){
            yield return null;
        }
        //yield return new WaitUntil(() => currentPlayer.grounded);
        currentPlayer.EnableInput();
        inTransition = false;
    }
}


// para poder usar un metodo como action debe retornar void y no tener parametros
// tener un metodo en action permite pasar como parametro a otros metodos