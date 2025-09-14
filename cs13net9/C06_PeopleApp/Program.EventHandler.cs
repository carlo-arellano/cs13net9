﻿using C06_PacktLibrary;

partial class Program
{
    // A method to handle the Shout event received by the harry object.
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        // If no sender, then do nothing.
        if (sender is null) return;

        // If sender is not a Person, then do nothing.
        if (sender is not Person p) return;

        WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
    }

    // Another method to handle the event received by the harry object.
    private static void Harry_Shout_2(object? sender, EventArgs e)
    {
        WriteLine("Stop it!");
    }
}
