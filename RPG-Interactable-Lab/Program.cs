using System;
using System.Collections.Generic;

interface IInteractable
{
    void Interact();
}

class Door : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("The wooden door opens with a creaking sound.");
    }
}

class TreasureChest : IInteractable
{
    private bool isOpened = false;

    public void Interact()
    {
        if (isOpened)
        {
            Console.WriteLine("The chest is already empty. Look elsewhere.");
        }
        else
        {
            Console.WriteLine("You opened the chest! You found 100 Gold and a Legendary Sword.");
            isOpened = true;
        }
    }
}

class NPC : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Greetings, traveler! I have a new quest for you.");
    }
}

class Program
{
    static void Main()
    {
        Door door = new Door();
        TreasureChest chest = new TreasureChest();
        NPC npc = new NPC();

        List<IInteractable> interactableObjects = new List<IInteractable>();

        interactableObjects.Add(door);
        interactableObjects.Add(chest);
        interactableObjects.Add(npc);

        Console.WriteLine("Player presses E for the first time:");
        foreach (IInteractable obj in interactableObjects)
        {
            obj.Interact();
        }

        Console.WriteLine();

        Console.WriteLine("Player presses E again:");
        foreach (IInteractable obj in interactableObjects)
        {
            obj.Interact();
        }
    }
}