// See https://aka.ms/new-console-template for more information

using KenDB;

bool running = true;
InputHandler inputHandler = new InputHandler();

while (running)
{
    string cmd = Console.ReadLine();
    try
    {
        inputHandler.parseInput(cmd);
    }
    catch
    {
        Console.WriteLine("Input invalid!");
    }

    

}
