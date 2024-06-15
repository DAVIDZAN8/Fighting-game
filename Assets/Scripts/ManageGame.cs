using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageGame : MonoBehaviour {

public void ComeBack()
    {
        SceneManager.LoadScene("Menu_Scene");
    }
}
