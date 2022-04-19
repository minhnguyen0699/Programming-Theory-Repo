using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    [SerializeField] private float speed;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        speed = 40.0f * MainManager.Instance.difficulty;
    }

   

    void Update()
    {
        MoveForward();
    }
    public virtual void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    protected abstract void ControlPlayer(); 
}
