// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static List<string> todoList = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("🚀 Welcome to the Beginner's Toolkit in .NET!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Greeting");
        Console.WriteLine("2. Calculator");
        Console.WriteLine("3. To-Do List");
        Console.WriteLine("4. Random Joke Generator");
        Console.WriteLine("5. Exit");

        while (true)
        {
            Console.Write("\nEnter choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Greeting();
                    break;
                case "2":
                    Calculator();
                    break;
                case "3":
                    ToDoList();
                    break;
                case "4":
                    JokeGenerator();
                    break;
                case "5":
                    Console.WriteLine("👋 Goodbye!");
                    return;
                default:
                    Console.WriteLine("❌ Invalid choice, try again.");
                    break;
            }
        }
    }

    // Feature 1: Greeting
    static void Greeting()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to .NET Toolkit 🚀");
    }

    // Feature 2: Calculator
    static void Calculator()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*": result = num1 * num2; break;
            case "/": result = num2 != 0 ? num1 / num2 : double.NaN; break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }

    // Feature 3: To-Do List
    static void ToDoList()
    {
        while (true)
        {
            Console.WriteLine("\n📋 To-Do List Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Back to Main Menu");

            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter new task: ");
                string task = Console.ReadLine();
                todoList.Add(task);
                Console.WriteLine("✅ Task added.");
            }
            else if (input == "2")
            {
                Console.WriteLine("\nYour Tasks:");
                if (todoList.Count == 0)
                    Console.WriteLine("No tasks yet.");
                else
                    for (int i = 0; i < todoList.Count; i++)
                        Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
            else if (input == "3")
            {
                Console.Write("Enter task number to remove: ");
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                if (index >= 0 && index < todoList.Count)
                {
                    Console.WriteLine($"❌ Removed: {todoList[index]}");
                    todoList.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    // Feature 4: Joke Generator
    static void JokeGenerator()
    {
        string[] jokes = {
            "Why do programmers prefer dark mode? Because light attracts bugs!",
            "How do you comfort a JavaScript bug? You console it!",
            "Why did the computer show up at work late? It had a hard drive!",
            "What's a programmer’s favorite place to hang out? The Foo Bar."
        };

        Random rand = new Random();
        int index = rand.Next(jokes.Length);
        Console.WriteLine($"😂 Joke: {jokes[index]}");
    }
}

