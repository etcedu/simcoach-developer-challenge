using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DozerGameManager : MonoBehaviour
{
    public int currentStage;
    public Text currentStageLabel;

    public GameObject dirtPilePrefab;
    
    int dirtRemaining;

    // Start is called before the first frame update
    void Start()
    {
        currentStage = 1;
        SpawnDirt(currentStage);        
    }

    // Update is called once per frame
    void Update()
    {
        currentStageLabel.text = "Stage: " + currentStage.ToString();
    }

    void SpawnDirt(int numDirt)
    {
        dirtRemaining = 0;
        for (int i = 0; i < numDirt; i++)
        {
            GameObject newDirt = Instantiate(dirtPilePrefab);
            newDirt.transform.position = new Vector3(Random.Range(-28f, 28f), 1, Random.Range(-20f, 20f));
            dirtRemaining++;
        }
    }

    public void HitDirt()
    {
        dirtRemaining--;
        if (dirtRemaining <= 0)
        {
            currentStage++;
            SpawnDirt(currentStage);
        }
    }
}
