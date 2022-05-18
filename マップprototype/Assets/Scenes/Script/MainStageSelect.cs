using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStageSelect : MonoBehaviour
{

    private bool check;
    private GameObject stage1;
    private GameObject stage2;
    private GameObject stage3;

    void Awake()
    {
        check = true;
        stage1 = GameObject.Find("StageSelect1");
        stage2 = GameObject.Find("StageSelect2");
        //stage3 = GameObject.Find("StageSelect3");
        stage1.SetActive(false);
        stage2.SetActive(false);
        //stage3.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Button_B"))
        //{
        //    SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
        //}
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                stage1.SetActive(true);
                this.gameObject.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                stage2.SetActive(true);
                this.gameObject.SetActive(false);

            }
        //if (Input.GetKey(KeyCode.Alpha3))
        //{
        //    stage3.SetActive(true);
        //    check = false;
        //}

    }
}
