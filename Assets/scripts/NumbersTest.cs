using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersTest : MonoBehaviour
{
    // Start is called before the first frame update

    int number;

    void Start()
    {
        number = 55;
    }

    // Update is called once per frame
    void Update()
    {
        number++;
        print(number);
    }
}
