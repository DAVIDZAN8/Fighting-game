using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {

    private GameObject[] characterList;

    private int Index;

    private void Start()
    {

        Index = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }


        foreach(GameObject go in characterList)
        {
            go.SetActive(false);
        }

        if (characterList[Index])
            characterList[Index].SetActive(true);
    }

    public void ToggleLeft()
    {
        characterList[Index].SetActive(false);

        Index--;

        if (Index < 0)
            Index = characterList.Length - 1;

        characterList[Index].SetActive(true);


    }

    public void ToogleRight()
    {
        characterList[Index].SetActive(false);

        Index++;

        if (Index == characterList.Length)
            Index = 0;

        characterList[Index].SetActive(true);
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", Index);
        SceneManager.LoadScene("Menu");
    }

    public void ConfirmButton2()
    {
        PlayerPrefs.SetInt("CharacterSelected", Index);
        SceneManager.LoadScene("PVE");
    }
}
