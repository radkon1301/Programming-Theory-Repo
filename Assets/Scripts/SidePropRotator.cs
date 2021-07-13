using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePropRotator : MainPropRotator // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        // different rotation speed than the other propeller
        // later in the project the main propeller could behave differently upon death
        //     for example by detaching from helicopter, unlike the side propeller
        rotationSpeed = 360.0f; // POLYMORPHISM
    }
}
