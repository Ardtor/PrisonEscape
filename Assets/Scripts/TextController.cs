using System;
using UnityEngine;
using UnityEngine.UI;


// Closet, courtyard and game over need doing

public class TextController : MonoBehaviour
{
    private enum States // sets the various states available for the cell
    {
        cell,
        sheets_0,
        sheets_1,
        mirror,
        cell_mirror,
        lock_0,
        lock_1,
        freedom,
        stairs_0,
        stairs_1,
        stairs_2,
        corridor_0,
        corridor_1,
        corridor_2,
        corridor_3,
        closet_door,
        in_closet,
        floor,
        courtyard,
        gameover

    } 
    private States mystate; 
    public Text text; // makes the text available to everyone
    public Text GameOverText;
    public int GameStateOver = 0;


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
	    switch (mystate)
	    {
	        case States.cell:
	            State_Cell();
	            break;
	        case States.sheets_0:
	            State_Sheets_0();
	            break;
	        case States.mirror:
	            State_Mirror();
	            break;
	        case States.cell_mirror:
	            State_Cell_Mirror();
	            break;
	        case States.lock_0:
	            State_Lock_0();
	            break;
	        case States.lock_1:
	            State_Lock_1();
	            break;
	        case States.sheets_1:
	            State_Sheets_1();
	            break;
	        case States.stairs_0:
	            State_Stairs_0();
                break;
	        case States.stairs_1:
	            State_Stairs_1();
	            break;
	        case States.stairs_2:
	            State_Stairs_2();
	            break;
            case States.corridor_0:
	            State_Corridor_0();
	            break;
	        case States.corridor_1:
	            State_Corridor_1();
	            break;
	        case States.corridor_2:
	            State_Corridor_2();
	            break;
	        case States.corridor_3:
	            State_Corridor_3();
	            break;
	        case States.closet_door:
	            State_Closet_Door();
	            break;
            case States.in_closet:
                State_In_Closet(); //oo err
                break;
            case States.floor:
	            State_Floor();
	            break;
            case States.courtyard:
                State_Courtyard();
                break;
            case States.gameover:
                State_Gameover();
                break;
            case States.freedom:
	            State_Freedom();
	            break;
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
            "Press [T] to [T]ake the mirror from the wall\n" +
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
            "(Hint: There isn't any reason to be here)\n" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n";


        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell_mirror;
        }

    }

    void State_Lock_1()
    {
        text.text =
            "You walk over to the door with the mirror in your hand, maybe if you angled the mirror you could see down the bar on the door?\n" +
            "\n" +
            "Press [R] to [R]eturn to looking at your cell\n" +
            "Press [T] to [T]ry the mirror";


        if (Input.GetKeyDown("r"))
        {
            mystate = States.cell_mirror;
        }

        if (Input.GetKeyDown("t"))
        {
            mystate = States.freedom;
        }

    }

    void State_Freedom()
    {
        text.text =
            "Angling the mirror you spot the bar on the door, stretching on your tip toes you catch it with your hand and tug for a few minutes as the bar squeals open " +
            "success! However in your haste to get the door open you drop the mirror, cracks run down it and when you pick it up again it shatters in your hand. \n" +
            "You push the door open and look about you, there's just your cell down here and a short corridor that ends in another room, at the other end a set of stairs" +
            "something glints in the torch light half way down towards the other room\n\n" +
            "Press [I] to [I]nspect the floor\n" +
            "Press [A] to [A]pproach the door\n" +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("i"))
        {
            mystate = States.floor;
        }

        if (Input.GetKeyDown("a"))
        {
            mystate = States.closet_door;
        }

        if (Input.GetKeyDown("h"))
        {
            mystate = States.stairs_0;
        }
    }

    void State_Corridor_0()
    {
        text.text =
            "You're standing back at the exit of your cell, the door standing wide open. The mirror fallen on the floor is spread out in shards in front of it. \n" +
            "Looking about you see something other than the glass glinting on the floor, to your south is a yet unopened door and to the north the stairs.\n\n "+
            "Press [I] to [I]nspect the floor\n" +
            "Press [A] to [A]pproach the door\n" +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("i"))
        {
            mystate = States.floor;
        }

        if (Input.GetKeyDown("a"))
        {
            mystate = States.closet_door;
        }

        if (Input.GetKeyDown("h"))
        {
            mystate = States.stairs_0;
        }
    }

    void State_Corridor_1()
    {
        text.text =
            "You're standing back at the exit of your cell, the door standing wide open. The mirror fallen on the floor is spread out in shards in front of it. \n" +
            "Looking about you see the door to your south, yet unexplored and to the north the stairs.\n\n " +
            "Press [A] to [A]pproach the door, maybe you can pick the lock\n" +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("a"))
        {
            mystate = States.in_closet;
        }

        if (Input.GetKeyDown("h"))
        {
            mystate = States.stairs_2;
        }
    }

    void State_Corridor_2()
    {
        text.text =
            "You're standing back at the exit of your cell, the door standing wide open. The mirror fallen on the floor is spread out in shards in front of it. \n" +
            "Looking about you see the open door to your south for the guards barracks room and to the north the stairs.\n\n " +
            "Press [E] to [E]nter the guards barracks\n" +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("e"))
        {
            mystate = States.in_closet;
        }

        if (Input.GetKeyDown("h"))
        {
            mystate = States.stairs_1;
        }
    }

    void State_Corridor_3()
    {
        text.text =
            "You're done everything you can now to insure your success, time to put it to the test \n" +
            "\n " +
            "Press [H] to [H]ead towards the stairs";


       if (Input.GetKeyDown("h"))
        {
            mystate = States.courtyard;
        }
    }

    void State_Stairs_0()
    {
        text.text =
            "You slowly approach the stairs they circle up in a tight circle, they're well worn with time and a groove is made in the middle from all the people going up and down," +
            " the flames on the torches flicker threatening to plug you into darkness.\n\n" +
            "You creep to the top and look out, the darkness threatens to swamp you as you start to creep forward, but a noise stops you mid stride.\n" +
            "*Zzzzzzzzz, Zzzzzzz*\n" +
            "It's a sleeping guard, you sigh in relief you can easily slip past the tired guard but notice that there's several lights moving around in the courtyard. More guards? Maybe risking it now is a bad " +
            "idea\n\n" +
            "Press [H] to [H]ead down the stairs";


        if (Input.GetKeyDown("h"))
        {
            mystate = States.corridor_0;
        }
    }

    void State_Stairs_1()
    {
        text.text =
            "You head back up the stairs, maybe the guard has moved on? You peer around the corner the guard is awake! You quickly hide back around the corner, you're going to need a way to get across without" +
            "being challenged. Maybe the room downstairs has something to use\n" +
            "\n " +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("h"))
        {
            mystate = States.corridor_2;
        }
    }

    void State_Stairs_2()
    {
        text.text =
            "The guard is still asleep, the light's are wandering closer to the entrance, you dart backwards quickly.\n" +
            "\n " +
            "Press [H] to [H]ead towards the stairs";


        if (Input.GetKeyDown("h"))
        {
            mystate = States.corridor_1;
        }
    }

    void State_Closet_Door()
    {
        text.text =
            "You head towards the door, twisting the handle it stops part way. Looks to be locked, it's a sturdy door and the chance of you breaking it down would lead to far to much noise. You" +
            " look through the keyhole to see inside, it looks to be a guard barracks. Maybe you can find a weapon or something to help you out inside there but you'll need something to try picking the" +
            " lock with\n" +
            "\n " +
            "Press [R] to [R]eturn return to the corridor";


        if (Input.GetKeyDown("r"))
        {
            mystate = States.corridor_0;
        }
    }

    void State_In_Closet()
    {
        text.text =
            "You head towards the door, twisting the handle it stops part way. Looks to be locked, it's a sturdy door and the chance of you breaking it down would lead to far to much noise. You" +
            " look through the keyhole to see inside, it looks to be a guard barracks. With the bobby pins in hand you fashion some picks, placing your ear against the door you can't hear anything\n" +
            "After a few minutes you pick the lock open and enter inside the barracks, looking about you see nothing of note baring some shoddy leather armour in what appears to be the caste lords livery " +
            "\n\n " +
            "Press [T] to take the armour and livery\n" +
            "Press [R] to [R]eturn return to the corridor";


        if (Input.GetKeyDown("r"))
        {
            mystate = States.corridor_2;
        }
        if (Input.GetKeyDown("t"))
        {
            mystate = States.corridor_3;
        }
    }




    void State_Floor()
    {
        text.text =
            "You kneel down avoiding the shards of glass and see some fallen bobby pins, these could be useful. Maybe as a lock pick? You do know the art, even if it's been a while.\n\n" +
            "Press [T] to [T]ake the bobby pins\n" +
            "Press [R] to [R]eturn to the door and do nothing\n";


       if (Input.GetKeyDown("t"))
        {
            mystate = States.corridor_1;
        }

        if (Input.GetKeyDown("r"))
        {
            mystate = States.corridor_0;
        }
    }

    void State_Courtyard()
    {
        text.text =
            "You stride out into the courtyard, the guard back to snoring. You stride across it towards the door set into the Castle gate. Glad it's dark as the leather is awkward to walk in and chafing." +
            " You pass another guard a few feet away and he nods at you as you pass, you nod back a little to quickly but he's turned away by that point and and moved on.\n" +
            "You grab the door handle and open it, stepping through you turn around to pull the door\n" +
            "You feel a warm breath against your ear and that hissing voice whispers''So close, yet so far my pretty''\n\n" +
            "The world turns black\n" +
            "Press [C] to [C]ontinue";

        



        if (Input.GetKeyDown(KeyCode.C))
        {
           GameStateOver = GameStateOver + 1;
           if (GameStateOver < 3)
            mystate = States.cell;
            else if (GameStateOver == 3)
           {
               mystate = States.gameover;
           }
        }

    }

    void State_Gameover()
    {
        text.text =
            "Three times you've done this, <b>THREE TIMES</b> and yet you cannot leave this castle, that accursed voice whipsering to you when you try to leave. What does it <i>want?</i> \n" +
            "A piercing hiss reaches you from behind ''You will <i>never</i> leave me my pretty, <b>never again</b>. You broke my heart once and it'll never happen again''\n" +
            "You scream in fustration as everything fades to black once again\n" +
            "\n" +
            "\n" +
            "<center><B><size=50>GAME OVER</size></B></center>";
        GameOverText.text = "<B><size=75>GAME OVER</size></B>";

        GameStateOver = GameStateOver + 1;



        if (GameStateOver <= 3)
        {
            mystate = States.cell;
        }

        else if (GameStateOver == 3)
        {
            mystate = States.gameover;
        }
    }


}
