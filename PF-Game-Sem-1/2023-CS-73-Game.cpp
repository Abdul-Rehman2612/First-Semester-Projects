#include <iostream>
#include <conio.h>
#include <windows.h>
#include <ctime>
#include <random>
using namespace std;

void header();     // prints the header of the game
void printBoard(); // prints the board 1

// printing and movements of enemy 1
void printEnemy1();                   // prints the enemy 1 on map
void eraseEnemy1();                   // erases the enemy 1 from map
void moveEnemy1(string);              // moves enemy 1 on the map in horizontal position
string changeDirectionEnemy1(string); // changes direction of the enemy 1 from right to left and vice versa!

// printing and movements of enemy 2
void printEnemy2();                   // prints the enemy 2 on map
void eraseEnemy2();                   // erases the enemy 2 from map
void moveEnemy2(string);              // moves enemy 2 on map in diagonal position
string changeDirectionEnemy2(string); // changes direction of the enemy 2 from diagonal down to diagonal up and vice versa!

// printing and movements of enemy 3
void printEnemy3();                   // prints the enemy 3 on map
void eraseEnemy3();                   // erases the enemy 3 from map
void moveEnemy3(string);              // moves enemy 3 on the map in vertical position
string changeDirectionEnemy3(string); // changes direction of the enemy

// printing and movements of final enemy boss
void printBoss();
void eraseBoss();                   // erases the enemy 3 from map
void moveBoss(string);              // moves enemy 3 on the map in vertical position
string changeBossDirection(string); // changes the direction of the boss

// printing and movements of player
void printPlayer();     // prints player at a specific coordinate
void erasePlayer();     // erases player where recently player was printed
void movePlayer();      // controls overall movements of the player
void movePlayerLeft();  // moves player to it's left by 1
void movePlayerRight(); // moves player to it's right by 1
void movePlayerUp();    // moves player upwards by 1
void movePlayerDown();  // moves player downwards by 1

void scorePill();        // increments score by 1
void generatePill();     // generates pills at random places in the game
void generateGun(int);   // places the gun G of the player at random place in the game
string printMenu();      // prints the satrt menu of the game
void InstructionsMenu(); // prints the instructions of the game

// system functions
void gotoxy(int, int);                  // checks the coordinates of players and enemies
char getCharAtxy(short int, short int); // checks character at a given coordinate

// bullets firing functions
void playerBulletsFiring();                                    // player fires bullet if space is pressed
void moveBullet(string, string, string);                       // moves bullets of enemies and player in upward and left right direction
void enemy1Firing(string);                                     // enemy 1 fire bullets
void enemy2Firing(string);                                     // enemy 2 fire bullets
void enemy3Firing(string);                                     // enemy 3 fire bullets
void bossFiring(string);                                       // boss fire bullets
void bulletCollisionEnmeies(int, int, string, string, string); // enemies collision with the bullets
void moveBulletDown();                                         // bullets move downwards
void gameWin();                                                // prints the game win if palyeer win the game
void gamelose();                                               // prints the game lose if player losses the game
// health system functions
void printHealth(); // prints the enemies and players healths

// board
char board[50][121] = {
    "########################################################################################################################",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##              ########################                     ###########################                              ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                #                                                   ##",
    "##                                                                #                                                   ##",
    "##                                        #########################                                                   ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##===================================================                          ===========================#########   ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##                                                                                                                    ##",
    "##    %%%%%%%%%%%%%%%    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%      ##",
    "##             ##                                                                                                     ##",
    "##             ##                                                                                                     ##",
    "##             ##                                                                                                     ##",
    "##             ##                                                                                                     ##",
    "##             ##        %%%%%%%%%                        %%%%%%%                                             ##      ##",
    "##             ##                                         ##   ##                                             ##      ##",
    "##             ##                                                               %%%%%%%                               ##",
    "##%%%%%%%%     ##                                                               ##   ##                               ##",
    "##             %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%                                                                 ##",
    "##                                                 ##                                                  %%%%%%%%    #####",
    "##                                                 ##                                                  ##          #####",
    "##      ##                                         %%%%%%%%      %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%             ##",
    "##      ##                                                       ##((G))#                                             ##",
    "##      ##                                                       ##((U))#                                             ##",
    "##      ##                                                       ##((N))#                                             ##",
    "########################################################################################################################",
};

char bullet[5] = {'|', '<', '>', '^', 'v'};                                // bullets fired by players and enemies
int eX1 = 40, eY1 = 35;                                                    // coordinates of enemy 1
int eX2 = 10, eY2 = 7;                                                     // coordinates of enemy 2
int eX3 = 111, eY3 = 1;                                                    // coordinates of enemy 3
int pX = 3, pY = 46;                                                       // coordinates of player
int score = 0;                                                             // score of player
int playerHealth = 100;                                                    // health of the player
int eBX = 50, eBY = 12;                                                    // coordinates of the boss
char playerGun = 'I';                                                      // player gun
int health[4] = {100, 150, 200, 0};                                        // enemies health
bool bosshelth = false;                                                    //  boss health check variable
string menu[4] = {"Play Game", "Instructions", "Exit", "Enter option..."}; // menu of the game
main()
{
    while (true)
    {
        string directionEnemy1 = "right", directionEnemy2 = "movediagdown", directionEnemy3 = "movedown", bossDirection = "right";

        bool en1 = true;                 // enemy 1 health check
        bool en2 = true;                 // enemy 2 health check
        bool en3 = true;                 // enemy 3 health check
        bool bossArrival = false;        // boss health check
        int enemy1FireCount = 0;         // enemy 1 bullets timer
        int enemy2FireCount = 0;         // enemy 2 bullets timer
        int enemy3FireCount = 0;         // enemy 3 bullets timer
        int bossFireCount=0;             // boss bullets timer
        bool enemy1FireFlag = false;     // enemy 1 fire flag check
        bool enemy2FireFlag = false;     // enemy 2 fire flag check
        bool enemy3FireFlag = false;     // enemy 3 fire flag check
        bool playerGunPlacement = false; // player gun placement check
        bool playerShootType = false;    // player fire timer in case player has simple gun
        bool pillGeneration = false;     // score pills generation checker
        system("cls");
        header();
        string option="0";
        option = printMenu(); // asks user for its choice

        if (option == "1") // if user enters 1 game starts
        {
            eX1 = 40, eY1 = 35;
            eX2 = 10, eY2 = 7; 
            eX3 = 111, eY3 = 1;
            pX = 3, pY = 46;

            // enemies health
            health[0] = 100;
            health[1] = 150;
            health[2] = 200;
            health[3] = 0;
            playerHealth = 100;

            system("cls");

            // print board and player
            printBoard();
            printPlayer();
            int count = 0;
            while (true)
            {
                if (GetAsyncKeyState(VK_LSHIFT)) // game pauses if player presses shift
                {
                    while (true)
                    {
                        if (GetAsyncKeyState(VK_RSHIFT))
                        {
                            break;
                        }
                    }
                }
                printHealth(); // prints health bar
                scorePill();   // prints score board

                // bullets movement
                moveBullet(directionEnemy1, directionEnemy2, directionEnemy3);
                moveBulletDown();
                if (playerGun == 'G' || playerGun == 'M') // player firing
                {
                    if (playerShootType == true || playerGun == 'M')
                    {
                        playerBulletsFiring();
                    }
                }
                if (enemy1FireCount % 4 == 0) // enemy 1 firing
                {
                    enemy1Firing(directionEnemy1);
                    enemy1FireCount = 0;
                }
                if (enemy2FireCount % 7 == 0) // enemy 2 firing
                {
                    enemy2Firing(directionEnemy2);
                    enemy2FireCount = 0;
                }
                if (enemy2FireCount % 10 == 0) // enemy 3 firing
                {
                    enemy3Firing(directionEnemy3);
                    enemy3FireCount = 0;
                }
                if(bossFireCount%6==0)
                {
                    bossFiring(bossDirection);
                    bossFireCount=0;
                }
                // player movement
                movePlayer();

                if (health[0] > 0 && en1 == true) // checks and prints enemy if its health is greater than 0
                {
                    moveEnemy1(directionEnemy1);
                    directionEnemy1 = changeDirectionEnemy1(directionEnemy1);
                }
                else if (en1 == true && health[0] <= 0) // erases enemy 1 from screen permanently if enemy die
                {
                    en1 = false;
                    health[0] = 0;
                    eraseEnemy1();
                    board[eY1][eX1] = 'M';
                    gotoxy(eX1, eY1);
                    cout << board[eY1][eX1];
                }
                if (en2 == true && health[1] > 0) // checks and prints enemy if its health is greater than 0
                {
                    moveEnemy2(directionEnemy2);
                    directionEnemy2 = changeDirectionEnemy2(directionEnemy2);
                }
                else if (en2 == true && health[1] <= 0) // erases enemy 2 from screen permanently if enemy die
                {
                    en2 = false;
                    health[1] = 0;
                    eraseEnemy2();
                }
                if (en3 == true && health[2] > 0) // checks and prints enemy if its health is greater than 0
                {
                    moveEnemy3(directionEnemy3);
                    directionEnemy3 = changeDirectionEnemy3(directionEnemy3);
                }
                else if (en3 == true && health[2] <= 0) // erases enemy 3 from screen permanently if enemy die
                {
                    en3 = false;
                    health[2] = 0;
                    eraseEnemy3();
                    board[eY3][eX3] = 'S';
                    gotoxy(eX3, eY3);
                    cout << board[eY3][eX3];
                }

                // if any of 2 enemies die the boss arrives
                if (((health[0] == 0 && health[1] == 0) || (health[0] == 0 && health[2] == 0) || (health[1] == 0 && health[2] == 0)) && health[3] == 0 && bosshelth == false)
                {
                    health[3] = 500;
                    bossArrival = true;
                    bosshelth = true;
                }
                if (bossArrival == true && health[3] > 0) // checks and prints boss if its health is greater than 0
                {
                    moveBoss(bossDirection);
                    bossDirection = changeBossDirection(bossDirection);
                }
                if (health[3] <= 0 && bossArrival == true) // erases boss from screen permanently if enemy die
                {
                    health[3] = 0;
                    bossArrival = false;
                    eraseBoss();
                }
                if (playerGunPlacement == false && count >= 30) // places gun randomly in the map after a specific time
                {
                    generateGun(20);
                    playerGunPlacement = true;
                }
                if (playerGun != 'M' || playerGun == 'G') // checks player weapon and determine time
                {
                    if (count % 4 == 0)
                    {
                        playerShootType = true;
                    }
                    else
                    {
                        playerShootType = false;
                    }
                }
                count++;
                if (playerHealth <= 0) // if player dies game ends
                {
                    system("cls");
                    gamelose();
                    Sleep(1000);
                    getch();
                    break;
                }
                if ((health[0] == 0 && health[1] == 0 && health[2] == 0 && health[3] == 0)) // if enemies die player wins
                {
                    system("cls");
                    gameWin();
                    Sleep(1000);
                    getch();
                    break;
                }
                if (pillGeneration == false) // genetrates pills if pills are not present on the board
                {
                    generatePill();
                    pillGeneration = true;
                }
                enemy1FireCount++;
                enemy2FireCount++;
                enemy3FireCount++;
                bossFireCount++;
                Sleep(30);
            }
        }
        else if (option == "2") // if player enters 2 insrtuctions menu appears
        {
            system("cls");
            InstructionsMenu();
        }
        else if (option == "3") // is player enters 3 game ends
        {
            return 0;
        }
    }
}
void header()
{
    cout << "\e[1;33m" << endl;
    cout << "===================================================================" << endl;
    cout << "||##########    #######    #### ##########  @@@@@@@@   ###    ## ||" << endl;
    cout << "||###########   ##    ##    ##   ##        @@      @@  ####   ## ||" << endl;
    cout << "||###     ####  ##    ##    ##     ##     @@  @@@@  @@ ## ##  ## ||" << endl;
    cout << "||###     ####  #######     ##       ##   @@  @@@@  @@ ##  ## ## ||" << endl;
    cout << "||###########   ##    ##    ##         ##  @@      @@  ##   #### ||" << endl;
    cout << "||##########    ##     ##  #### ##########  @@@@@@@@   ##    ### ||" << endl;
    cout << "||###------------------------------------------------------------||" << endl;
    cout << "||###  ######  #######   ####### ####### ######  ######          ||" << endl;
    cout << "||###  ##     ##        ##       ##   ## ##   ## ##              ||" << endl;
    cout << "||###  ######  ######  ##        ####### ######  ######          ||" << endl;
    cout << "||###  ##           ##  ##       ##   ## ##      ##              ||" << endl;
    cout << "||###  ###### #######    ####### ##   ## ##      ######          ||" << endl;
    cout << "===================================================================" << endl;
}
void gameWin()
{
    cout << "\e[1;32m" << endl;
    cout << "/$$      /$$ /$$                  /$$$$$$                                    " << endl;
    cout << "| $$  /$ | $$|__/                 /$$__  $$                                  " << endl;
    cout << "| $$ /$$$| $$ /$$ /$$$$$$$       | $$  \\__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$ " << endl;
    cout << "| $$/$$ $$ $$| $$| $$__  $$      | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$" << endl;
    cout << "| $$$$_  $$$$| $$| $$  \\ $$      | $$|_  $$  /$$$$$$$| $$ \\ $$ \\ $$| $$$$$$$$" << endl;
    cout << "| $$$/ \\  $$$| $$| $$  | $$      | $$  \\ $$ /$$__  $$| $$ | $$ | $$| $$_____/" << endl;
    cout << "| $$/   \\  $$| $$| $$  | $$      |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$" << endl;
    cout << "|__/     \\__/|__/|__/  |__/       \\______/  \\_______/|__/ |__/ |__/ \\_______/" << endl;
}
void gamelose()
{
    cout << "\e[1;31m" << endl;
    cout << " /$$                             /$$            /$$$$$$                                   " << endl;
    cout << "| $$                            | $$           /$$__  $$                                  " << endl;
    cout << "| $$        /$$$$$$   /$$$$$$$ /$$$$$$        | $$  \\__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$ " << endl;
    cout << "| $$       /$$__  $$ /$$_____/|_  $$_/        | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$" << endl;
    cout << "| $$      | $$  \\ $$|  $$$$$$   | $$          | $$|_  $$  /$$$$$$$| $$ \\ $$ \\ $$| $$$$$$$$" << endl;
    cout << "| $$      | $$  | $$ \\____  $$  | $$ /$$      | $$  \\ $$ /$$__  $$| $$ | $$ | $$| $$_____/" << endl;
    cout << "| $$$$$$$$|  $$$$$$/ /$$$$$$$/  |  $$$$/      |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$" << endl;
    cout << "|________/ \\______/ |_______/    \\___/         \\______/  \\_______/|__/ |__/ |__/ \\_______/" << endl;

    getch();
}
void InstructionsMenu()
{
    cout << "\e[1;35m" << endl;
    cout << " /$$$$$$                       /$$                                     /$$     /$$                              " << endl;
    cout << "|_  $$_/                      | $$                                    | $$    |__/                              " << endl;
    cout << "  | $$   /$$$$$$$   /$$$$$$$ /$$$$$$    /$$$$$$  /$$   /$$  /$$$$$$$ /$$$$$$   /$$  /$$$$$$  /$$$$$$$   /$$$$$$$" << endl;
    cout << "  | $$  | $$__  $$ /$$_____/|_  $$_/   /$$__  $$| $$  | $$ /$$_____/|_  $$_/  | $$ /$$__  $$| $$__  $$ /$$_____/" << endl;
    cout << "  | $$  | $$  \\ $$|  $$$$$$   | $$    | $$  \\__/| $$  | $$| $$        | $$    | $$| $$  \\ $$| $$  \\ $$|  $$$$$$ " << endl;
    cout << "  | $$  | $$  | $$ \\____  $$  | $$ /$$| $$      | $$  | $$| $$        | $$ /$$| $$| $$  | $$| $$  | $$ \\____  $$" << endl;
    cout << " /$$$$$$| $$  | $$ /$$$$$$$/  |  $$$$/| $$      |  $$$$$$/|  $$$$$$$  |  $$$$/| $$|  $$$$$$/| $$  | $$ /$$$$$$$/" << endl;
    cout << "|______/|__/  |__/|_______/    \\___/  |__/       \\______/  \\_______/   \\___/  |__/ \\______/ |__/  |__/|_______/ " << endl;
    cout << endl
         << endl
         << endl;
    cout << "\e[1;34m" << endl;
    cout << "Use up, down, left and right keys to moveplayer." << endl;
    cout << "Press space to fire player bullets." << endl;
    cout << "Collect G to get gun." << endl;
    cout << "Collect M to collect machien gun." << endl;
    cout << "Collect S to get shield." << endl;
    cout << "Collect @ to increment score." << endl;
    cout << "Kill all enemies to win the game." << endl;
    cout << "Press any key to continue!" << endl;
    getch();
}
string printMenu()
{
    cout << "\e[1;31m";
    int Y = 17;
    for (int i = 0; i < 4; i++)
    {
        gotoxy(20, Y + i);
        cout << i + 1 << "." << menu[i];
    }
    string option;
    while (!(option.length() >= 1) && (option != "1" || option != "2" || option != "3")) // loop takes input till it is not valid option
    {
        getline(cin, option);
    }
    return option;
}

void printEnemy1()
{
    gotoxy(eX1, eY1);
    cout << "\e[1;31m\\./";
    gotoxy(eX1, eY1 + 1);
    cout << "-G-";
    gotoxy(eX1, eY1 + 2);
    cout << "/-\\";
}
void eraseEnemy1()
{
    gotoxy(eX1, eY1);
    cout << "   ";
    gotoxy(eX1, eY1 + 1);
    cout << "   ";
    gotoxy(eX1, eY1 + 2);
    cout << "   ";
}
void moveEnemy1(string directionEnemy1)
{
    eraseEnemy1();
    if (directionEnemy1 == "right" && (getCharAtxy(eX1 + 3, eY1) == ' ' && getCharAtxy(eX1 + 3, eY1 + 1) == ' ' && getCharAtxy(eX1 + 3, eY1 + 2) == ' ')) // checks if there is nothing in front of enemy moves it forward by 1
    {
        eX1 = eX1 + 1;
    }
    else if (directionEnemy1 == "right" && ((getCharAtxy(eX1 + 3, eY1) == bullet[0] || getCharAtxy(eX1 + 3, eY1 + 1) == bullet[0] || getCharAtxy(eX1 + 3, eY1 + 2) == bullet[0]))) // checks if there is bullet decreses health
    {
        eX1 = eX1 + 1;
        health[0] = health[0] - 10;
    }
    if (directionEnemy1 == "left" && (getCharAtxy(eX1 - 1, eY1) == ' ' && getCharAtxy(eX1 - 1, eY1 + 1) == ' ' && getCharAtxy(eX1 - 1, eY1 + 2) == ' ')) // checks if there is nothing back of enemy moves it backwar
    {
        eX1 = eX1 - 1;
    }
    else if (directionEnemy1 == "left" && (getCharAtxy(eX1 - 1, eY1) == bullet[0] || getCharAtxy(eX1 - 1, eY1 + 1) == bullet[0] || getCharAtxy(eX1 - 1, eY1 + 2) == bullet[0])) // checks if there is bullet decreses health
    {
        health[0] = health[0] - 10;
        eX1 = eX1 - 1;
    }
    printEnemy1();
}
string changeDirectionEnemy1(string directionEnemy1)
{
    // changes the direction of enemy if hits the walls
    if ((getCharAtxy(eX1 - 1, eY1) == '#' || getCharAtxy(eX1 - 1, eY1 + 1) == '#' || getCharAtxy(eX1 - 1, eY1 + 2) == '#') || (getCharAtxy(eX1 - 1, eY1) == '%' || getCharAtxy(eX1 - 1, eY1 + 1) == '%' || getCharAtxy(eX1 - 1, eY1 + 2) == '%'))
    {
        directionEnemy1 = "right";
    }
    if ((getCharAtxy(eX1 + 3, eY1) == '#' || getCharAtxy(eX1 + 3, eY1 + 1) == '#' && getCharAtxy(eX1 + 3, eY1 + 2) == '#') || (getCharAtxy(eX1 + 3, eY1) == '%' || getCharAtxy(eX1 + 3, eY1 + 1) == '%' && getCharAtxy(eX1 + 3, eY1 + 2) == '%'))
    {
        directionEnemy1 = "left";
    }
    return directionEnemy1;
}

void printEnemy2()
{
    gotoxy(eX2, eY2);
    cout << "\e[1;31m/^\\";
    gotoxy(eX2, eY2 + 1);
    cout << "|O|";
    gotoxy(eX2, eY2 + 2);
    cout << "\\#/";
}
void eraseEnemy2()
{
    gotoxy(eX2, eY2);
    cout << "   ";
    gotoxy(eX2, eY2 + 1);
    cout << "   ";
    gotoxy(eX2, eY2 + 2);
    cout << "   ";
}
void moveEnemy2(string directionEnemy2)
{
    eraseEnemy2();
    if (directionEnemy2 == "movediagdown" && getCharAtxy(eX2 + 1, eY2 + 3) == ' ' && getCharAtxy(eX2 + 2, eY2 + 3) == ' ' && getCharAtxy(eX2 + 3, eY2 + 2) == ' ' && getCharAtxy(eX2 + 3, eY2 + 1) == ' ' && getCharAtxy(eX2 + 3, eY2 + 2) == ' ') // if free space found increases enemy position by one diiagonally downwards
    {
        eX2 = eX2 + 1;
        eY2 = eY2 + 1;
    }
    else if (directionEnemy2 == "movediagdown" && (getCharAtxy(eX2 + 1, eY2 + 3) == bullet[0] || getCharAtxy(eX2 + 2, eY2 + 3) == bullet[0] || getCharAtxy(eX2 + 3, eY2 + 2) == bullet[0] || getCharAtxy(eX2 + 3, eY2 + 1) == bullet[0] || getCharAtxy(eX2 + 3, eY2 + 2) == bullet[0])) // if bullet found decreases enemy health
    {
        health[1] = health[1] - 10;
        eX2 = eX2 + 1;
        eY2 = eY2 + 1;
    }
    if (directionEnemy2 == "movediagup" && getCharAtxy(eX2 - 1, eY2) == ' ' && getCharAtxy(eX2 - 1, eY2 + 1) == ' ' && getCharAtxy(eX2 - 1, eY2 - 1) == ' ' && getCharAtxy(eX2, eY2 - 1) == ' ' && getCharAtxy(eX2 + 1, eY2 - 1) == ' ')
    {
        eX2 = eX2 - 1;
        eY2 = eY2 - 1;
    }
    else if (directionEnemy2 == "movediagup" && (getCharAtxy(eX2 - 1, eY2) == bullet[0] || getCharAtxy(eX2 - 1, eY2 + 1) == bullet[0] || getCharAtxy(eX2 - 1, eY2 - 1) == bullet[0] || getCharAtxy(eX2, eY2 - 1) == bullet[0] || getCharAtxy(eX2 + 1, eY2 - 1) == bullet[0]))
    {
        health[1] = health[1] - 10;
        eX2 = eX2 - 1;
        eY2 = eY2 - 1;
    }
    printEnemy2();
}
string changeDirectionEnemy2(string directionEnemy2)
{
    // changes the direction of enemy if hits the walls
    if (directionEnemy2 == "movediagdown" && (getCharAtxy(eX2 + 1, eY2 + 3) == '=' || getCharAtxy(eX2 + 2, eY2 + 3) == '=' || getCharAtxy(eX2 + 3, eY2 + 2) == '=' || getCharAtxy(eX2 + 3, eY2 + 1) == '=' || getCharAtxy(eX2 + 3, eY2 + 2) == '='))
    {
        directionEnemy2 = "movediagup";
    }
    if (directionEnemy2 == "movediagup" && (getCharAtxy(eX2 - 1, eY2) == '#' || getCharAtxy(eX2 - 1, eY2 + 1) == '#' || getCharAtxy(eX2 - 1, eY2 - 1) == '#' || getCharAtxy(eX2, eY2 - 1) == '#' || getCharAtxy(eX2 + 1, eY2 - 1) == '#'))
    {
        directionEnemy2 = "movediagdown";
    }
    return directionEnemy2;
}

void printEnemy3()
{
    gotoxy(eX3, eY3);
    cout << "\e[1;31m\\|/";
    gotoxy(eX3, eY3 + 1);
    cout << "=S=";
    gotoxy(eX3, eY3 + 2);
    cout << "/+\\";
}
void eraseEnemy3()
{
    gotoxy(eX3, eY3);
    cout << "   ";
    gotoxy(eX3, eY3 + 1);
    cout << "   ";
    gotoxy(eX3, eY3 + 2);
    cout << "   ";
}
void moveEnemy3(string directionEnemy3)
{
    eraseEnemy3();
    if (directionEnemy3 == "down" && (getCharAtxy(eX3, eY3 + 3) == ' ' && getCharAtxy(eX3 + 1, eY3 + 3) == ' ' && getCharAtxy(eX3 + 2, eY3 + 3) == ' '))
    {
        eY3 = eY3 + 1;
    }
    if (directionEnemy3 == "up" && (getCharAtxy(eX3, eY3 - 1) == ' ' && getCharAtxy(eX3 + 1, eY3 - 1) == ' ' && getCharAtxy(eX3 + 2, eY3 - 1) == ' '))
    {
        eY3 = eY3 - 1;
    }
    printEnemy3();
}
string changeDirectionEnemy3(string directionEnemy3)
{
    // changes the direction of enemy if hits the walls
    if ((getCharAtxy(eX3, eY3 + 3) == '#' || getCharAtxy(eX3 + 1, eY3 + 3) == '#' || getCharAtxy(eX3 + 2, eY3 + 3) == '#') || (getCharAtxy(eX3, eY3 + 3) == '%' || getCharAtxy(eX3 + 1, eY3 + 3) == '%' || getCharAtxy(eX3 + 2, eY3 + 3) == '%') || (getCharAtxy(eX3, eY3 + 3) == '=' || getCharAtxy(eX3 + 1, eY3 + 3) == '=' || getCharAtxy(eX3 + 2, eY3 + 3) == '='))
    {
        directionEnemy3 = "up";
    }
    if ((getCharAtxy(eX3, eY3 - 1) == '#' || getCharAtxy(eX3 + 1, eY3 - 1) == '#' || getCharAtxy(eX3 + 2, eY3 - 1) == '#') || (getCharAtxy(eX3, eY3 - 1) == '%' || getCharAtxy(eX3 + 1, eY3 - 1) == '%' || getCharAtxy(eX3 + 2, eY3 - 1) == '%') || (getCharAtxy(eX3, eY3 - 1) == '=' || getCharAtxy(eX3 + 1, eY3 - 1) == '=' || getCharAtxy(eX3 + 2, eY3 - 1) == '='))
    {
        directionEnemy3 = "down";
    }
    return directionEnemy3;
}

void printBoss()
{
    gotoxy(eBX, eBY);
    cout << "\e[0;31m\\ ^ /";
    gotoxy(eBX, eBY + 1);
    cout << "<=H=>";
    gotoxy(eBX, eBY + 2);
    cout << "/ v \\";
}
void eraseBoss()
{
    gotoxy(eBX, eBY);
    cout << "     ";
    gotoxy(eBX, eBY + 1);
    cout << "     ";
    gotoxy(eBX, eBY + 2);
    cout << "     ";
}
void moveBoss(string bossDirection)
{
    // moves enemy left right on the bases of its position
    eraseBoss();
    if (getCharAtxy(eBX + 5, eBY) == ' ' && getCharAtxy(eBX + 5, eBY + 1) == ' ' && getCharAtxy(eBX + 5, eBY + 2) == ' ' && bossDirection == "right")
    {
        eBX = eBX + 1;
    }
    else if ((getCharAtxy(eBX + 5, eBY) == bullet[0] || getCharAtxy(eBX + 5, eBY + 1) == bullet[0] || getCharAtxy(eBX + 5, eBY + 2) == bullet[0]) && bossDirection == "right")
    {
        health[3] = health[3] - 10;
        eBX = eBX + 1;
    }
    if (getCharAtxy(eBX - 1, eBY) == ' ' && getCharAtxy(eBX - 1, eBY + 1) == ' ' && getCharAtxy(eBX - 1, eBY + 2) == ' ' && bossDirection == "left")
    {
        eBX = eBX - 1;
    }
    else if ((getCharAtxy(eBX - 1, eBY) == bullet[0] || getCharAtxy(eBX - 1, eBY + 1) == bullet[0] || getCharAtxy(eBX - 1, eBY + 2) == bullet[0]) && bossDirection == "left")
    {
        health[3] = health[3] - 10;
        eBX = eBX - 1;
    }
    printBoss();
}
string changeBossDirection(string bossDirection)
{
    // changes enemy direction if hits wall
    if ((getCharAtxy(eBX + 5, eBY) == '#' || getCharAtxy(eBX + 5, eBY + 1) == '#' || getCharAtxy(eBX + 5, eBY + 2) == '#') && bossDirection == "right")
    {
        bossDirection = "left";
    }
    else if ((getCharAtxy(eBX - 1, eBY) == '#' || getCharAtxy(eBX - 1, eBY + 1) == '#' || getCharAtxy(eBX - 1, eBY + 2) == '#') && bossDirection == "left")
    {
        bossDirection = "right";
    }
    return bossDirection;
}
void printPlayer()
{
    gotoxy(pX, pY);
    cout << "\e[1;32m\\o/";
    gotoxy(pX, pY + 1);
    cout << "-P-";
    gotoxy(pX, pY + 2);
    cout << "/-\\";
}
void erasePlayer()
{
    gotoxy(pX, pY);
    cout << "   ";
    gotoxy(pX, pY + 1);
    cout << "   ";
    gotoxy(pX, pY + 2);
    cout << "   ";
}
void movePlayer()
{
    if (GetAsyncKeyState(VK_LEFT))
    {
        movePlayerLeft();
    }
    if (GetAsyncKeyState(VK_RIGHT))
    {
        movePlayerRight();
    }
    if (GetAsyncKeyState(VK_DOWN))
    {
        movePlayerDown();
    }
    if (GetAsyncKeyState(VK_UP))
    {
        movePlayerUp();
    }
}
void movePlayerLeft()
{
    // if left key pressed moves player left
    if (getCharAtxy(pX - 1, pY) == ' ' && getCharAtxy(pX - 1, pY + 1) == ' ' && getCharAtxy(pX - 1, pY + 2) == ' ')
    {
        erasePlayer();
        pX = pX - 1;
        printPlayer();
    }
    else if (getCharAtxy(pX - 1, pY) == '@' || getCharAtxy(pX - 1, pY + 1) == '@' || getCharAtxy(pX - 1, pY + 2) == '@')
    {
        erasePlayer();
        pX = pX - 1;
        score = score + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX - 1, pY) == 'G' || getCharAtxy(pX - 1, pY + 1) == 'G' || getCharAtxy(pX - 1, pY + 2) == 'G')
    {
        erasePlayer();
        pX = pX - 1;
        playerGun = 'G';
        printPlayer();
    }
    else if (getCharAtxy(pX - 1, pY) == 'M' || getCharAtxy(pX - 1, pY + 1) == 'M' || getCharAtxy(pX - 1, pY + 2) == 'M')
    {
        erasePlayer();
        pX = pX - 1;
        playerGun = 'M';
        printPlayer();
    }
    else if (getCharAtxy(pX - 1, pY) == 'S' || getCharAtxy(pX - 1, pY + 1) == 'S' || getCharAtxy(pX - 1, pY + 2) == 'S')
    {
        erasePlayer();
        pX = pX - 1;
        playerHealth = playerHealth + 100;
        printPlayer();
    }
}
void movePlayerRight()
{
    // if right key pressed moves player right
    if (getCharAtxy(pX + 3, pY) == ' ' && getCharAtxy(pX + 3, pY + 1) == ' ' && getCharAtxy(pX + 3, pY + 2) == ' ')
    {
        erasePlayer();
        pX = pX + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX + 3, pY) == '@' || getCharAtxy(pX + 3, pY + 1) == '@' || getCharAtxy(pX + 3, pY + 2) == '@')
    {
        erasePlayer();
        pX = pX + 1;
        score = score + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX + 3, pY) == 'G' || getCharAtxy(pX + 3, pY + 1) == 'G' || getCharAtxy(pX + 3, pY + 2) == 'G')
    {
        erasePlayer();
        pX = pX + 1;
        playerGun = 'G';
        printPlayer();
    }
    else if (getCharAtxy(pX + 3, pY) == 'M' || getCharAtxy(pX + 3, pY + 1) == 'M' || getCharAtxy(pX + 3, pY + 2) == 'M')
    {
        erasePlayer();
        pX = pX + 1;
        playerGun = 'M';
        printPlayer();
    }
    else if (getCharAtxy(pX + 3, pY) == 'S' || getCharAtxy(pX + 3, pY + 1) == 'S' || getCharAtxy(pX + 3, pY + 2) == 'S')
    {
        erasePlayer();
        pX = pX + 1;
        playerHealth = playerHealth + 100;
        printPlayer();
    }
}
void movePlayerDown()
{
    // if down key pressed moves player down
    if (getCharAtxy(pX, pY + 3) == ' ' && getCharAtxy(pX + 1, pY + 3) == ' ' && getCharAtxy(pX + 2, pY + 3) == ' ')
    {
        erasePlayer();
        pY = pY + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX, pY + 3) == '@' || getCharAtxy(pX + 1, pY + 3) == '@' || getCharAtxy(pX + 2, pY + 3) == '@')
    {
        erasePlayer();
        pY = pY + 1;
        score = score + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX, pY + 3) == 'G' || getCharAtxy(pX + 1, pY + 3) == 'G' || getCharAtxy(pX + 2, pY + 3) == 'G')
    {
        erasePlayer();
        pY = pY + 1;
        playerGun = 'G';
        printPlayer();
    }
    else if (getCharAtxy(pX, pY + 3) == 'M' || getCharAtxy(pX + 1, pY + 3) == 'M' || getCharAtxy(pX + 2, pY + 3) == 'M')
    {
        erasePlayer();
        pY = pY + 1;
        playerGun = 'G';
        printPlayer();
    }
    else if (getCharAtxy(pX, pY + 3) == 'S' || getCharAtxy(pX + 1, pY + 3) == 'S' || getCharAtxy(pX + 2, pY + 3) == 'S')
    {
        erasePlayer();
        pY = pY + 1;
        playerHealth = playerHealth + 100;
        printPlayer();
    }
}
void movePlayerUp()
{
    // if up key pressed moves player up
    if (getCharAtxy(pX, pY - 1) == ' ' && getCharAtxy(pX + 1, pY - 1) == ' ' && getCharAtxy(pX + 2, pY - 1) == ' ')
    {
        erasePlayer();
        pY = pY - 1;
        printPlayer();
    }
    else if (getCharAtxy(pX, pY - 1) == '@' || getCharAtxy(pX + 1, pY - 1) == '@' || getCharAtxy(pX + 2, pY - 1) == '@')
    {
        erasePlayer();
        pY = pY - 1;
        score = score + 1;
        printPlayer();
    }
    else if (getCharAtxy(pX, pY - 1) == 'G' || getCharAtxy(pX + 1, pY - 1) == 'G' || getCharAtxy(pX + 2, pY - 1) == 'G')
    {
        erasePlayer();
        pY = pY - 1;
        playerGun = 'G';
        printPlayer();
    }
    else if (getCharAtxy(pX, pY - 1) == 'M' || getCharAtxy(pX + 1, pY - 1) == 'M' || getCharAtxy(pX + 2, pY - 1) == 'M')
    {
        erasePlayer();
        pY = pY - 1;
        playerGun = 'M';
        printPlayer();
    }
    else if (getCharAtxy(pX, pY - 1) == 'S' || getCharAtxy(pX + 1, pY - 1) == 'S' || getCharAtxy(pX + 2, pY - 1) == 'S')
    {
        erasePlayer();
        pY = pY - 1;
        playerHealth = playerHealth + 100;
        printPlayer();
    }
}

void scorePill()
{
    gotoxy(130, 20);
    cout << "\e[0;32mScore:\e[0;34m " << score;
}
void generatePill()
{
    srand(time(NULL));
    char pill = '@';
    int row = 0;
    int column = 0;
    for (int i = 0; i < 6; i++)
    {
        while (board[row][column] != ' ' && getCharAtxy(column, row) != ' ') // keeps checking place till founds some free space then places pills
        {
            row = rand() % 50;
            column = rand() % 121;
            if (board[row][column] == ' ' && getCharAtxy(column, row) == ' ' && (column != eX3 && column != eX3 + 1 && column != eX3 + 2)) // if free spaces found places pill
            {
                board[row][column] = pill;
                gotoxy(column, row);
                cout << "\e[0;35m" << board[row][column];
                break;
            }
        }
    }
}
void generateGun(int y)
{
    srand(time(NULL));
    char Gun = 'G';
    int row = 0;
    int column = 0;
    while (true)
    {
        row = rand() % 50;
        column = rand() % 121;
        if (board[row][column] == ' ' && getCharAtxy(column, row) == ' ' && (row != eY1 && row != eY1 + 1 && row != eY1 + 2) && row > 30 && column > 10) // if free space found places gun
        {
            cout << "\e[1;35m";
            board[row][column] = Gun;
            gotoxy(column, row);
            cout << board[row][column];
            break;
        }
    }
}

void printBoard()
{
    for (int i = 0; i < 50; i++)
    {
        for (int j = 0; j < 121; j++)
        {
            if (board[i][j] == '%')
            {
                cout << "\e[1;33m";
            }
            if (board[i][j] == '#')
            {
                cout << "\e[1;36m";
            }
            if (board[i][j] == '=')
            {
                cout << "\e[1;35m";
            }
            cout << board[i][j];
        }
        cout << endl;
    }
}

void playerBulletsFiring()
{
    // if spaces pressed player fires bullet
    if (GetAsyncKeyState(VK_SPACE) && getCharAtxy(pX + 1, pY - 1) == ' ')
    {
        board[pY - 1][pX + 1] = bullet[0];
        gotoxy(pX + 1, pY - 1);
        cout << board[pY - 1][pX + 1];
    }
}
void enemy1Firing(string directionEnemy1)
{
    // enemy 1 fires bullets
    if (health[0] > 0)
    {
        if (getCharAtxy(eX1 - 1, eY1 + 1) == ' ')
        {
            if (pY >= 33 && pX < eX1 && pX > 16 && pY <= eY1 + 1)
            {
                board[eY1 + 1][eX1 - 1] = bullet[1];
            }
        }
        if (getCharAtxy(eX1 + 3, eY1 + 1) == ' ')
        {
            if (pY >= 33 && pX > eX1 && pY <= eY1 + 1)
            {
                board[eY1 + 1][eX1 + 3] = bullet[2];
            }
        }
        if (getCharAtxy(eX1 + 1, eY1 + 3) == ' ')
        {
            if (pY > eY1 && pX > 16)
            {
                board[eY1 + 3][eX1 + 1] = bullet[4];
            }
        }
    }
}
void enemy2Firing(string directionEnemy2)
{ // enemy 2 fires bullets
    if (health[1] > 0)
    {
        if ((getCharAtxy(eX2 - 1, eY2 + 1) == ' '))
        {
            if (pX < eX2 && pY < 33)
            {
                board[eY2 + 1][eX2 - 1] = bullet[1];
            }
        }
        if ((getCharAtxy(eX2 + 5, eY2 + 1) == ' '))
        {
            if (pX > eX2 && pY < 33)
            {
                board[eY2 + 1][eX2 + 5] = bullet[2];
            }
        }
        if (getCharAtxy(eX2 + 1, eY2 - 1) == ' ')
        {
            if (pY < 33 && pY < eY2 && eY2 > 3)
            {
                board[eY2 - 1][eX2 + 1] = bullet[3];
            }
        }
        if (getCharAtxy(eX2 + 1, eY2 + 3) == ' ')
        {
            if (pY < 33 && pY < eY2)
            {
                board[eY2 - 1][eX2 + 1] = bullet[3];
            }
        }
    }
}
void enemy3Firing(string directionEnemy3)
{
    // enemy 3 fires bullets
    if (health[2] > 0)
    {
        if ((getCharAtxy(eX3 - 1, eY3 + 1) == ' '))
        {
            if (pX < eX3 && pY < 33)
            {

                board[eY3 + 1][eX3 - 1] = bullet[1];
            }
        }
        if (getCharAtxy(eX3 + 1, eY3 - 1) == ' ' && eY3 > 3)
        {
            if (pY<eY3)
            {

                board[eY3 - 1][eX3 + 1] = bullet[3];
            }
        }
         if (getCharAtxy(eX3 + 1, eY3 + 3) == ' ')
        {
            if (pY > eY3 && pY<33)
            {
                board[eY3 + 3][eX3 + 1] = bullet[4];
            }
        }
    }
}
void bossFiring(string)
{
    // boss fires bullets
    if (health[3] > 0)
    {
        if (getCharAtxy(eBX - 1, eBY + 1) == ' ')
        {
            if (pX < eBX && pY < 33)
            {
                board[eBY + 1][eBX - 1] = bullet[1];
            }
        }
        if (getCharAtxy(eBX + 5, eBY + 1) == ' ')
        {
            if (pX > eBX && pY < 33)
            {
                board[eBY + 1][eBX + 5] = bullet[2];
            }
        }
        if (getCharAtxy(eBX + 2, eBY + 3) == ' ')
        {
            if (pY > eBY)
            {
                board[eBY + 3][eBX + 2] = bullet[4];
            }
        }
        if (getCharAtxy(eBX + 2, eBY - 1) == ' ')
        {
            if (pY < eBY)
            {
                board[eBY - 1][eBX + 2] = bullet[3];
            }
        }
    }
}
void moveBullet(string directionEnemy1, string directionEnemy2, string directionEnemy3)
{
    for (int i = 0; i < 50; i++)
    {
        for (int j = 0; j < 121; j++)
        {
            // moves player bullets upwards
            if (board[i][j] == bullet[0] && getCharAtxy(j, i - 1) == ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << "\e[1;34m" << board[i][j];
                board[i - 1][j] = bullet[0];
                gotoxy(j, i - 1);
                cout << "\e[1;34m" << board[i - 1][j];
            }
            else if (board[i][j] == bullet[0] && getCharAtxy(j, i - 1) != ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                bulletCollisionEnmeies(i, j, directionEnemy1, directionEnemy2, directionEnemy3);
            }
            // moves enemy bullets upwards
            if (board[i][j] == bullet[3] && getCharAtxy(j, i - 1) == ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << "\e[1;34m" << board[i][j];
                board[i - 1][j] = bullet[3];
                gotoxy(j, i - 1);
                cout << "\e[1;34m" << board[i - 1][j];
            }
            else if (board[i][j] == bullet[3] && getCharAtxy(j, i - 1) != ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                if ((j == pX || j == pX + 1 || j == pX + 2) && (i == pY - 1))
                {
                    playerHealth = playerHealth - 5;
                }
            }
            // moves enemy bullets left
            if (board[i][j] == bullet[1] && getCharAtxy(j - 1, i) == ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << "\e[1;34m" << board[i][j];
                board[i][j - 1] = bullet[1];
                gotoxy(j - 1, i);
                cout << "\e[1;34m" << board[i][j - 1];
            }
            else if (board[i][j] == bullet[1] && getCharAtxy(j - 1, i) != ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                if (j - 3 == pX && (i == pY || i == pY + 1 || i == pY + 2))
                {
                    playerHealth = playerHealth - 5;
                }
            }
            // moves enemy bullets right
            if (board[i][j] == bullet[2] && getCharAtxy(j + 1, i) == ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << "\e[1;34m" << board[i][j];
                board[i][j + 1] = bullet[2];
                gotoxy(j + 1, i);
                cout << "\e[1;34m" << board[i][j + 1];
                j = j + 1;
            }
            else if (board[i][j] == bullet[2] && getCharAtxy(j + 1, i) != ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                if (j + 1 == pX && (i == pY || i == pY + 1 || i == pY + 2))
                {
                    playerHealth = playerHealth - 5;
                }
            }
        }
    }
}
void moveBulletDown()
{
    for (int i = 49; i >= 0; i--)
    {
        for (int j = 120; j >= 0; j--)
        {
            // moves enemy bullets downwards
            if (board[i][j] == bullet[4] && getCharAtxy(j, i + 1) == ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                board[i + 1][j] = bullet[4];
                gotoxy(j, i + 1);
                cout << board[i + 1][j];
            }
            else if (board[i][j] == bullet[4] && getCharAtxy(j, i + 1) != ' ')
            {
                board[i][j] = ' ';
                gotoxy(j, i);
                cout << board[i][j];
                if ((j == pX || j == pX + 1 || j == pX + 2) && (i == pY - 1))
                {
                    playerHealth = playerHealth - 5;
                }
            }
        }
    }
}
void bulletCollisionEnmeies(int i, int j, string directionEnemy1, string directionEnemy2, string directionEnemy3)
{
    // decreses enemy health if bullet hits it
    if ((j == eX1 || j == eX1 + 1 || j == eX1 + 2) && (i == eY1 + 3))
    {
        health[0] = health[0] - 10;
    }
    if ((j == eX2 || j == eX2 + 1 || j == eX2 + 2) && (i == eY2 + 3))
    {
        health[1] = health[1] - 10;
    }
    if ((j == eX3 || j == eX3 + 1 || j == eX3 + 2) && (i == eY3 + 3))
    {
        health[2] = health[2] - 5;
    }
    if ((j == eBX || j == eBX + 1 || j == eBX + 2 || j == eBX + 3 || j == eBX + 4) && i == eBY + 3)
    {
        health[3] = health[3] - 10;
    }
}
void printHealth()
{
    if (playerHealth > 20)
    {
        cout << "\e[1;32m";
    }
    else
    {
        cout << "\e[1;31m";
    }
    gotoxy(130, 10);
    cout << "Player Health: " << playerHealth << "%  ";
    gotoxy(130, 11);
    cout << "Enemy1 Health: " << health[0] << "%  ";
    gotoxy(130, 12);
    cout << "Enemy2 Health: " << health[1] << "%  ";
    gotoxy(130, 13);
    cout << "Enemy3 Health: " << health[2] << "%  ";
    gotoxy(130, 14);
    cout << "Boss Health: " << health[3] << "% ";
}
char getCharAtxy(short int x, short int y)
{
    CHAR_INFO ci;
    COORD xy = {0, 0};
    SMALL_RECT rect = {x, y, x, y};
    COORD coordBufSize;
    coordBufSize.X = 1;
    coordBufSize.Y = 1;
    return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), &ci, coordBufSize, xy, &rect) ? ci.Char.AsciiChar : ' ';
}
void gotoxy(int x, int y)
{
    COORD coordinates;
    coordinates.X = x;
    coordinates.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
}