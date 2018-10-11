using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    static public GameControl instance;

    //Definicion de las variables
    //enteros representados por palabras
    public enum LevelObjective
    {
        Collect,
        Destroy,
        ReachPoint
    }

    public LevelObjective levelObjective;
    public int objectiveCount;

    public List<MonoBehaviour> objectiveInstances = new List<MonoBehaviour>();

    void Awake()
    {
        if (!instance) { instance = this; }
    }

    void Start()
    {
        Init();
    }

    void Init()
    {
        if (levelObjective == LevelObjective.Collect)
        {
            ReselectInstances(typeof(CollectableObject));
        }
        else if (levelObjective == LevelObjective.Destroy)
        {
            ReselectInstances(typeof(DestroyableObject));
        }
    }

    void ReselectInstances(System.Type type)
    {
        objectiveInstances = objectiveInstances.FindAll(script => script.GetType() == type);
        foreach (var script in objectiveInstances)
        {
            objectiveCount++;
        }
    }

    public void CheckInstantPoint(MonoBehaviour script)
    {
        if (objectiveInstances.Contains(script))
        {
            objectiveInstances.Remove(script);
            objectiveCount--;
        }
        CheckLevelObjectives();
    }

    void CheckLevelObjectives()
    {
        if (objectiveCount <= 0)
        {
            NextLevel();
        }
    }

    public void RestartLevel()
    {
        SwitchScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SwitchScene(null);
    }

    void SwitchScene(string sceneName)
    {
        ClearSceneData();
        if (string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void ClearSceneData()
    {
        objectiveCount = 0;
    }
}
