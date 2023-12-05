using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimientoNPCJose : MonoBehaviour
{
    //NPC Level
    public int level = 1;
    //NPC Speed
    public float speed = 1.2f;
    //NPC Lives
    public int lives = 1;
    //NPC Position
    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        //Sumar level a lives
        lives += level;
        //Saca por consola la nueva lives
        print (lives);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Multiplica la velocidad por el tiempo en la posición Z
        newPosition.z += speed * Time.deltaTime;
        //El transform es igual a newPosition 
        transform.position = newPosition;
    }
}
