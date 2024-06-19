using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> targets;

    float spawnRate = 1.0f;

    [SerializeField] TextMeshProUGUI scoreText;
    int score;


    private void Start()
    {
        score = 0;

        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, targets.Count);

            Instantiate(targets[index]);
        }
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

}
