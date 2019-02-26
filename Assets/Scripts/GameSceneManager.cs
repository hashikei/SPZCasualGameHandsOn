using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    private float elapsedTime;

    [SerializeField] GameObject playerObj;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f) {
            elapsedTime = 0f;

            var obj = Instantiate(playerObj);
            var pos = obj.transform.position;
            pos.x = Random.Range(-3f, 3f);
            pos.z = Random.Range(-3f, 3f);
            obj.transform.position = pos;
            var meshRenderer = obj.GetComponent<MeshRenderer>();
            var color = meshRenderer.material.color;
            color.r = Random.Range(0f, 1f);
            color.g = Random.Range(0f, 1f);
            color.b = Random.Range(0f, 1f);
            meshRenderer.material.color = color;
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene("Result");
        }
    }
}
