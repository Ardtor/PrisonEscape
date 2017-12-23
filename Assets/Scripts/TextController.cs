﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    private enum States {cell,sheets_0,sheets_1, mirror, cell_mirror, lock_0,lock_1,freedom}
    private States mystate;
    public Text text;


	// Use this for initialization
	void Start ()
	{
	    mystate = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
    {
       /* the sheet you're lying on his threadbare and the walls are of stone and mortar, a imposing wooden door is set against" +
                        " the wall having seen better days but you realise you'd not be able to break it down without breaking something first */
        print(mystate);
        if (mystate == States.cell)
        {
            State_Cell();
        }
        else if (mystate == States.sheets_0)
        {
            State_Sheets_0();
        }
    }

    void State_Cell()
    {
        text.text =
            "A small bright light pierces your eyelids, a small cackling follows as you groan. \n ''Oh my it's already awake'' you hear it hiss. \n Followed by the " +
            "sound of a clanking door. The lock grates and rings in your ears as you try to sit up. Throat dry you cast about the room looking for the " +
            "noise.\n" +
            "\n" +
            "You see a dark dingy cell, the hissing voice as you woke up speeds up your haste to find out how to escape. Looking about you see the the sheets " +
            "you're resting on the bed with, a mirror on the wall and the door leading to freedom \n" +
            "\n" +
            "Press [S] to view the [S]heets \n" +
            "Press [M] to view the [M]irror\n" +
            "Press [L] to view the door and [L]ock\n";

        if (Input.GetKeyDown("s"))
        {
            mystate = States.sheets_0;
        }

    }

    void State_Sheets_0()
    {
        text.text =
            "Looking at the state of the sheets you're suprised you didn't catch anything from the, they're yellow and covered in stains of blood and other..things.\n" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n";

        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell;
        }
    }
}
