using System;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod

        string name = "Moist";
        string lastStreamName = "state of play";
        Game streamGame = new Game("Halo CE");
        long  followers = 4800000000;
        bool automod = true;
    }
}