using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // VARIABLES (10)
    public int counter = 0;
    public int health = 100;
    public int lives = 3;

    public float playerSpeed = 5f;
    public float jumpForce = 10f;
    public bool isGameOver = false;
    public string playerName = "Player";
    public int score = 0;
    public int level = 1;
    public float timer = 0f;

    // EVENTOS ACTION
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

    // METODOS CON ARGUMENTOS
    public void AddScore(int value)
    {
        score += value;
    }

    public void SetLevel(int newLevel)
    {
        level = newLevel;
    }

    public void SetPlayerName(string newName)
    {
        playerName = newName;
    }

    // METODOS CON RETORNO
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
