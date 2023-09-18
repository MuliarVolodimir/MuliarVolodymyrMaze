using System;

namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int _playerX = 2, _playerY = 2;

            char[,] _map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            }; // карта створена не рандомно

            while (true)
            {
                

                DrawMap();
                DrawPlayer();

                void DrawMap()
                {
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i < _map.GetLength(0); i++)
                    {
                        for (int j = 0; j < _map.GetLength(1); j++)
                        {
                            Console.Write(_map[i, j]);
                        }
                        Console.WriteLine();
                    }
                }

                void DrawPlayer()
                {
                    Console.SetCursorPosition(_playerY, _playerX);
                    Console.Write('@');
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (_map[_playerX - 1, _playerY] != '#')
                            {
                                _playerX--;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (_map[_playerX + 1, _playerY] != '#')
                            {
                                _playerX++;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (_map[_playerX, _playerY - 1] != '#')
                            {
                                _playerY--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (_map[_playerX, _playerY + 1] != '#')
                            {
                                _playerY++;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }

    }
}
