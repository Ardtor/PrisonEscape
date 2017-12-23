using System;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    private enum States {cell,sheets_0,sheets_1, mirror, cell_mirror, lock_0,lock_1,freedom} // sets the various states available for the cell
    private States mystate; 
    public Text text; // makes the text available to everyone


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
        else if (mystate == States.mirror)
        {
            State_Mirror();
        }
        else if (mystate == States.cell_mirror)
        {
            State_Cell_Mirror();
        }
        else if (mystate == States.lock_0)
        {
            State_Lock_0();
        }
        else if (mystate == States.lock_1)
        {
            State_Lock_1();
        }
        else if (mystate == States.sheets_1)
        {
            State_Sheets_1();
        }
        else if (mystate == States.freedom)
        {
            State_Freedom();
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

        else if (Input.GetKeyDown("m"))
        {
            mystate = States.mirror;
        }

        else if (Input.GetKeyDown("l"))
        {
            mystate = States.lock_0;
        }

    }

    void State_Sheets_0()
    {
        text.text =
            "Looking at the state of the sheets you're suprised you didn't catch anything from them, they're yellow and covered in stains of blood and other..things.\n" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n";

        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell;
        }
    }

    void State_Mirror()
    {
        text.text =
            "You approach the mirror, it's been cleaned recently. Possibly by the sheets on the bed, it doesn't look to be mounted well against the wall possibly you could" +
            "take it with you. \n" +
            "\n" +
            "Press T to [T]ake the mirror from the wall\n" +
            "Press [R] to [R]eturn to looking at your cell\n";

        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell;
        }

        else if (Input.GetKeyDown("t"))
        {
            mystate = States.cell_mirror;
        }

    }

    void State_Lock_0()
    {
        text.text =
            "You approach the imposing wooden door set into the the wall. Having seen better days, the door is rusted and worn with iron bars set into it that you can see the " +
            "corridor outside through but you realise you'd not be able to break it down without breaking something important in your body, you try to reach outside to move" +
            "the deadbolt that's stopping the door but swinging your arm just leaves your shoulder tired.  \n" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n";

        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell;
        }
    }



    void State_Cell_Mirror()
    {
        text.text =
            "With the mirror back in hand you return to the cell, looking about you still see the sheets from earlier, a dark patch on the wall shows where the mirror used " +
            "to be. You can see the door from your current spot. \n" +
            "\n" +
            "Press [S] to view the [S]heets \n" +
            "Press [L] to view the door and [L]ock\n";

        if (Input.GetKeyDown("s"))
        {
            mystate = States.sheets_1;
        }

        else if (Input.GetKeyDown("l"))
        {
            mystate = States.lock_1;
        }

    }

    void State_Sheets_1()
    {
        text.text =
            "You walk over to the sheets and attempt to direct the light from outside the door onto them to start a fire, maybe if you found a magnifying glass?\n" +
            "(Hint: There isn't any reason to be here)" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n";


        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell_mirror;
        }

    }

}
