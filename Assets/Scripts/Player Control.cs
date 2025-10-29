using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.PlayerSettings;
public class NewBehaviourScript : MonoBehaviour
{
    //public InputAction LeftAct;
    public InputAction MoveAct;
    Rigidbody2D rigidbody2d;
    public int maxHealth = 5;
    int currentHealth;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
        //LeftAct.Enable();
        MoveAct.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        move = MoveAct.ReadValue<Vector2>();
        Debug.Log(move);
        /**Vector2 move = MoveAct.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;**/
        /**float hori = 0.0f, ver = 0.0f;
        if(LeftAct.IsPressed())
        {
            hori = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            hori = 1.0f;
        }
        

        if (Keyboard.current.upArrowKey.isPressed)
        {
            ver=1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            ver = -1.0f;
        }
        Debug.Log(ver);
        pos.x = pos.x + 0.01f * hori;
        pos.y = pos.y + 0.01f * ver;
        transform.position = pos;**/
    }
    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * 3.0f * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
