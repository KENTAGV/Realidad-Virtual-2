using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // 10 VARIABLES
    public int counter = 0;
    public int health = 100;
    public int lives = 3;
    public int score = 0;
    public int level = 1;

    public float speed = 5f;
    public float jumpForce = 10f;

    public bool isGameOver = false;

    public string playerName = "Player";

    public float timer = 0f;

    // ACTION EVENTS
    public event Action OnCounterChanged;
    public event Action OnHealthChanged;
    public event Action OnLivesChanged;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    // METODOS
    public void AddCounter()
    {
        counter++;
        OnCounterChanged?.Invoke();
    }

    public void AddHealth()
    {
        health += 10;
        OnHealthChanged?.Invoke();
    }

    public void RemoveLife()
    {
        lives--;
        OnLivesChanged?.Invoke();
    }

    // 3 METODOS CON 2 ARGUMENTOS
    public int SumValues(int a, int b)
    {
        return a + b;
    }

    public int MultiplyValues(int a, int b)
    {
        return a * b;
    }

    public void SetStats(int healthValue, int livesValue)
    {
        health = healthValue;
        lives = livesValue;
    }

    // 3 METODOS CON RETORNO
    public int GetCounterPlus(int amount)
    {
        return counter + amount;
    }

    public int GetHealthMinus(int damage)
    {
        return health - damage;
    }

    public bool HasLives(int amount)
    {
        return lives >= amount;
    }
}
