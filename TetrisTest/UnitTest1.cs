﻿using System;
using NUnit.Framework;
using System.Drawing;

namespace TetrisTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void HorizontalBombUnitTest()
        {
            HorizontalBomb myBomb = new HorizontalBomb(1);
            int[,] Gridsigns = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 4,0,5,0,0,0,0,0,0,0 },
                                                   { 4,4,5,1,1,3,3,0,0,0 },
                                                   { 4,4,5,1,1,1,3,7,7,0 }};

            int[,] expectedGrids = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 4,0,5,0,0,0,0,0,0,0 },
                                                   { 4,4,5,1,1,3,3,0,0,0 }};

            myBomb.triggerBomb(Gridsigns);
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Assert.AreEqual(expectedGrids[i, j], Gridsigns[i, j]);
                }
            }
        }
        [Test]
        public void ColourBombUnitTest()
        {
            ColourBomb myBomb = new ColourBomb(1);
            myBomb.AddBombColor(Color.FromArgb(255, 67, 92)); //this grids which is 3

            int[,] Gridsigns = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 4,0,5,0,0,0,0,0,0,0 },
                                                   { 4,4,5,1,1,3,3,0,0,0 },
                                                   { 4,4,5,1,1,1,3,0,0,0 }};

            int[,] expectedGrids = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 4,0,5,0,0,0,0,0,0,0 },
                                                   { 4,4,5,1,1,0,0,0,0,0 },
                                                   { 4,4,5,1,1,1,0,0,0,0 }};

            myBomb.triggerBomb(Gridsigns);
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Assert.AreEqual(expectedGrids[i, j], Gridsigns[i, j]);
                }
            }
        }
        [Test]
        public void LargeBombUnitTest()
        {
            LargeBomb myBomb = new LargeBomb(1);
            int[,] Gridsigns = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 2,2,0,0,0,0,0,0,0,0 },
                                                   { 3,1,0,0,0,0,0,0,0,0 },
                                                   { 5,0,0,0,0,0,0,0,0,0 },
                                                   { 6,1,0,0,0,0,0,0,0,0 },
                                                   { 1,2,1,5,1,5,0,0,0,0 },
                                                   { 2,2,1,5,1,1,0,0,0,0 },
                                                   { 3,2,1,5,1,1,2,0,0,0 },
                                                   { 4,5,5,5,1,0,1,1,0,0 },
                                                   { 4,4,5,1,1,3,3,0,0,0 },
                                                   { 4,4,5,1,1,1,3,7,7,0 }};

            int[,] expectedGrids = new int[20, 10]{{ 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 0,0,0,0,0,0,0,0,0,0 },
                                                   { 2,2,0,0,0,0,0,0,0,0 },
                                                   { 3,1,0,0,0,0,0,0,0,0 },
                                                   { 5,0,0,0,0,0,0,0,0,0 },
                                                   { 6,1,0,0,0,0,0,0,0,0 },
                                                   { 1,2,1,5,1,5,0,0,0,0 }};
            myBomb.triggerBomb(Gridsigns);
            for (int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Assert.AreEqual(expectedGrids[i, j], Gridsigns[i, j]);
                }
            }
        }
    }
}
