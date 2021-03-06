﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobotCtrl;
using Baymax.Control;
using System.Threading;

namespace Testat
{

    class parcour
    {

        #region members
        private RobotConsole robotConsole;
        private Radar radar;
        public int numberOfObjects;
        #endregion


        /// <summary>
        /// Startet den Roboter
        /// </summary>
        public void driveParcour(Robot robot)
        {
            int i = 0;
            numberOfObjects = 0;
            
            //Robot robot = new Robot();
            robot.Drive.Power = true;
            this.radar = new Radar(Constants.IORadarSensor);

            // gerade aus fahren
            robot.Drive.RunLine(2.5f, 0.3f, 0.5f);
            while(!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
                
                // start with measuring
                if(radar.Distance < 1 && i == 0)
                {
                    // begining Object
                    i = 1;  // set beginning of Object
                    robot.RobotConsole[Leds.Led1].LedEnabled = true;
                    robot.RobotConsole[Leds.Led3].LedEnabled = true;
                    robot.RobotConsole[Leds.Led2].LedEnabled = false;
                    robot.RobotConsole[Leds.Led4].LedEnabled = false;

                }

                if(radar.Distance > 1.5f && i == 1)
                {
                    numberOfObjects = numberOfObjects + 1; // increment number of Objects
                    i = 0;  // reset help variable for next Objects
                    robot.RobotConsole[Leds.Led1].LedEnabled = false;
                    robot.RobotConsole[Leds.Led3].LedEnabled = false;
                    robot.RobotConsole[Leds.Led2].LedEnabled = true;
                    robot.RobotConsole[Leds.Led4].LedEnabled = true;
                }
            }

            robot.Drive.RunTurn(-90.0f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gedreht
                Thread.Sleep(100);
            }

            // gerade aus fahren 1.5m
            robot.Drive.RunLine(1.5f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
            }

            robot.Drive.RunTurn(-90.0f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gedreht
                Thread.Sleep(100);
            }

            // gerade aus fahren 1.5m
            robot.Drive.RunLine(1.5f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
            }

            // Kreis fahren
            robot.Drive.RunArcRight(1.0f, 90.0f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
            }

            // gerade aus fahren 1.5m
            robot.Drive.RunLine(0.2f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
            }

            robot.Drive.RunTurn(-90.0f, 0.3f, 0.5f);
            while (!robot.Drive.Done)
            {
                // warten bis fertig gedreht
                Thread.Sleep(100);
            }

            // Roboter stoppen
            robot.Drive.Stop();

        }
    }

    
}
