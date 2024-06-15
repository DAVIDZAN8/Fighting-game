using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingCamera : MonoBehaviour {

    public Transform[] playerTransform;
   

    private void Start()
    {
     
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player1");
        playerTransform = new Transform[allPlayers.Length];

        for(int i = 0; i < allPlayers.Length; i++)
        {
            playerTransform[i] = allPlayers[i].transform;
        }
    }

    public float yOffSet = 2.0f;
    public float minDistance = 7.5f;

    private float xMin, xMax, yMin, yMax;

    private void LateUpdate()
    {
        if(playerTransform.Length == 0)
        {
            return;
        }

        xMin = xMax = playerTransform[0].position.x;
        yMin = yMax = playerTransform[0].position.y;

        for (int i = 1; i < playerTransform.Length; i++)
        {
            if (playerTransform[i].position.x < xMin)
                xMin = playerTransform[i].position.x;

            if (playerTransform[i].position.x > xMax)
                xMax = playerTransform[i].position.x;

            if (playerTransform[i].position.y < yMin)
                yMin = playerTransform[i].position.y;

            if (playerTransform[i].position.y < yMax)
                yMax = playerTransform[i].position.y;
        }

        float xMiddle = (xMin + xMax) / 2;
        float yMiddle = (yMin + yMax) / 2;
        float distance = xMax - xMin;
        if (distance < minDistance)
            distance = minDistance;

        transform.position = new Vector3(xMiddle, yMiddle + yOffSet, -distance);
    }
}
