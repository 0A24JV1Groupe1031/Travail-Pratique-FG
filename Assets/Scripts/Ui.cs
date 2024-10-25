using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
 public void  ChangerSceneUn(){
    SceneManager.LoadScene("Chambre");
 }
 public void ChangerSceneDeux(){
    SceneManager.LoadScene("Cuisine");
 }
 public void ChangerSceneTrois(){
    SceneManager.LoadScene("SalleAManger");
 }
}
