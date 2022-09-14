using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString()+"/3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRemovePoint(int point)
    {
	score += point;
	scoreText.text = score.ToString()+"/3";
	
	int canOpen = CanOpenDoor();

	if(canOpen == 1){
		int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
 		SceneManager.LoadScene(nextSceneIndex);
	}
    }

    public int CanOpenDoor()
    {
	return score == 3 ? 1 : 0;
    }
}
