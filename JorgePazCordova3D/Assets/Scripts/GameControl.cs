using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    static public GameControl instance ;
    public CharacterBaseMov3D currentPlayer;
    bool inTransition;

	// Creaciòn de Singleton
	void Awake () {
        if (instance == null) {
            instance = this;
        }
        else {
            if (instance != null) {
                Destroy(this);
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
        yield return new WaitForSeconds(3f);
        currentPlayer.Respawn();
        while (!currentPlayer.grounded){
            yield return null;
        }
        //yield return new WaitUntil(() => currentPlayer.grounded);
        inTransition = false;
    }
}
