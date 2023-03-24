using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject bomb;
    public GameObject powerup;
    private float PosY = 4.5f;
    private float PosXRange = 7f;
    private float PosYRange = 1f;
    private float repeatTimeBomb = 2;
    private float repeatTimePowerup = 7;
    private float delayTimeB = 2;
    private float delayTimeP = 7;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateBomb", delayTimeB, repeatTimeBomb);
        InvokeRepeating("GeneratePowerup", delayTimeP, repeatTimePowerup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GerRamPosBomb()
    {
        Vector3 Pos = new Vector3(Random.Range(-PosXRange, PosXRange), PosY, 0);
        return Pos;
    }

    Vector3 GerRamPosPowerup()
    {
        Vector3 Pos = new Vector3(Random.Range(-PosXRange, PosXRange), Random.Range(-PosYRange, PosYRange), 0);
        return Pos;
    }

    void GenerateBomb()
    {
        Instantiate<GameObject>(bomb, GerRamPosBomb(), bomb.transform.rotation);
    }

    void GeneratePowerup()
    {
        Instantiate<GameObject>(powerup, GerRamPosPowerup(), powerup.transform.rotation);
    }
}
