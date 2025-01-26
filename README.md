# 🎮 Hero vs Monster Battle Game

A simple console-based turn battle simulator between a hero and a monster, built with C# and .NET 9.

## 📖 Table of Contents
- [Features](#-features)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [How to Play](#-how-to-play)
- [Game Logic](#-game-logic)
- [Project Structure](#-project-structure)

## 🚀 Features
- ⚔️ Turn-based combat system
- 🎲 Random damage calculation (0-10 per attack)
- ❤️ Health tracking for both characters
- 🏆 Clear win/lose conditions
- 📊 Battle history logging

## 📋 Requirements
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git (for cloning repository)
- Console terminal

## 📥 Installation
1. Clone the repository:
```bash
git clone https://github.com/arun-timalsina/hero_monoster_game.git

## 🕹️ How to Play
- Game starts automatically with both characters at 100 health
- Each turn:
- Hero attacks first with random damage (0-10)
- Monster retaliates with random damage (0-10)
- Battle continues until one character's health reaches 0
- Winner is declared based on remaining health


## 🧠 Game Logic
```bash
// Core battle loop from Hero.cs
int heroHealth = 100;
int monsterHealth = 100;

Random random = new();

while (heroHealth > 0 && monsterHealth > 0)
{
    int heroAttack = random.Next(0, 11);
    int monsterAttack = random.Next(0, 11);
    
    monsterHealth -= heroAttack;
    heroHealth -= monsterAttack;
    
    Console.WriteLine($"Hero attack: {heroAttack} | Monster health: {monsterHealth}");
    Console.WriteLine($"Monster counter: {monsterAttack} | Hero health: {heroHealth}\n");
}


## 📂 Project Structure
```bash
hero_monoster_game/
├── Hero.cs            # Main game logic
├── TestProject.csproj # Project configuration
├── TestProject.sln    # Solution file
├── README.md          # This documentation
└── .gitignore         # Ignore build artifacts





