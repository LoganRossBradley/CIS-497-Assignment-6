using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 40;
    public float turnTimer = 4f;

    public GameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        if (!gm.gameOver && speed != 0)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
    }

    // Start is called before the first frame update
    IEnumerator Movement()
    {
        yield return new WaitForSeconds(turnTimer);

        while (!gm.gameOver)
        {
            transform.Rotate(0, 180, 0);
            yield return new WaitForSeconds(turnTimer);
        }

    }
}
