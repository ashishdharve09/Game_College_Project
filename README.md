# College Game Project - HopBunny
 ## Overview
 Welcome to the Unity Game Project! This game was developed using Unity 3D and is intended for submission as part of a college project. The game features brief description of gameplay mechanics, e.g.,"a simple 2D platformer with obstacles".

This README file provides an overview of how to set up the project, understand the code, and run the game.

## Table of Contents
1. [Features](#features).
2. [Getting Started](#getting-started).
3. [Game Setup](#game-setup).
4. [Understanding the Code](#understanding-the-code).
5. [LevelController Script](#levelcontroller-script).
6. [PlayerController Script](#playercontroller-script).
7. [Spike Script](#spikes-script).
8. [Saw Script](#saw-script).
9. [How to Play](#how-to-play).
10. [Technologies Used](#technologies-used).
11. [Notes](#notes).

## Features
### Player Movement 
 - __Walking and Running__ : The character can walk and run across the platforms using the arrow keys or WASD .


* __Jumping__ : Players can make the character jump between platforms or over obstacles.

### Level Design 
* __Multiple Levels__ : A series of challenging levels with increasing difficulty.
* __Moving Platforms__ : Platforms that move horizontally, vertically, or rotate, adding timing-based challenges.
* __Traps and Hazards__ : Spikes, spikeheads, Moving Saws that cause damage to the player.
### Collectibles
* __Kiwis__ : Kiwi(collectibles) that contribute to the score.

### UI and HUD
* __Health Bar__ : Display the player's remaining health or lives.
* __Score Counter__ : Track the player’s score based on collected items.

## Getting Started
To run the project, follow the instructions below. No prior knowledge of Unity is required.
 * To run the project, just follow this link to github repository to download the game [Here](https://github.com/ashishdharve09/Platformer_Game_Project).

To edit or built on the project, follow the insturctions below.
### Prerequisites 
* __Unity__ : You will need Unity Hub and the appropriate version of Unity (suggested version: [Unity 2022.3.45f1]) installed. You can download Unity Hub [Here](https://unity.com/download).
* __Git__ : Install Git to clone the repository. Download Git [Here](https://git-scm.com/downloads).

## Game Setup
1. Clone the repository :
   * Open a terminal or command prompt and navigate to the directory where you want to store the project.
   * Run the following command : git clone https://github.com/[YourUsername]/[YourRepoName].git
2. Open the project in Unity :
   * Launch Unity Hub.
   * Click on the "Add" button and select the folder where you cloned the repository.
   * Unity will load the project.
3. Play the game :
   * Once the project is loaded in Unity, press the "Play" button at the top of the Unity editor to start the game.
   * 
## Understanding the Code
 Here are some important scripts used in the game. These scripts control the game logic, player actions, and interactions between game elements.
 
## LevelController Script
 !![image](https://github.com/user-attachments/assets/ab12c34d-d033-43e3-aff2-e29f70f44026)
* SceneManager is a part of Unity that manages the different scenes (levels or screens) in game.
* LoadScene(1) tells unity to load the next scene after the current scene in build index.
  
## PlayerController Script
!![image](https://github.com/user-attachments/assets/3514748e-516c-4773-96c8-e14a95cc4e90)
This script is for controlling a player character in a 2D game using Unity.

* __Update function__ : This runs every frame (e.g., 60 times per second). Under this function whatever the code written in this section will run every frame.
* __Horizontal Movement__ : Input.GetAxis("Horizontal") gets the player's input (left or right arrow key, or A/D keys).
* The player's Rigidbody2D velocity is adjusted by multiplying the horizontal input by moveSpeed and maintaining the current vertical velocity (gravity).
* __Jumping__ : Physics2D.Raycast() checks if there’s ground beneath the player by shooting an invisible line downward from groundCheck.This function is also used to create shooting bullets through guns in games.
* If the player is on the ground and presses the Space key, their vertical velocity is set to jumpForce, causing them to jump.
  


## Spikes Script
!![image](https://github.com/user-attachments/assets/b0a4f4e9-05b7-4ea3-aaa8-9b2e68b87c19)

* __OnTriggerEnter2D(Collider2D collision)__ : This functions is triggered when a object enters the triggerzone of the object attached with this script in this case spikes .
* __if (collision.tag == "Player")__ : This functions helps to detect if the object entered is player or not , it compares tag of the gameobject.
* __collision.GetComponent<Health>().TakeDamage(damage);__ : This function takes the health script of player and give damage mentioned in script to player's health.

## Saw Script
!![image](https://github.com/user-attachments/assets/7fec78ab-d591-4ffb-bb47-dfa6acd7a6ca)
* This Code makes the object move left and right, if object is reached the left side it will switch to moving to right side and vice versa, this also checks if object reached the other side if not it will first reach the target side.

## How to Play
* __Objective__ : Avoid obstacles and collect the kiwi's to score and reach the goal site to clear the level and reach the next level.
* __Controls_ :
   - Use left or right arrow key, or A/D keys to move.
   - Use SpaceBar to Jump.
   - Use 'Esc button' to open pause menu.
## Technologies Used
 * __Unity__ : The game engine used for the project. It handles everything from graphics rendering to physics and game object management.
 * __C#__ : The primary programming language used to script the game logic.
 * __Git__ : Used for version control and collaboration on the project.

## Notes 
* If you have any issues setting up or running the project, feel free to open an issue on GitHub.
* For detailed instructions on Unity or any questions about this project, check out the official [Unity Documentation](https://docs.unity.com/).
