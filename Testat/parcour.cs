using System;
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

        /// <summary>
        /// Startet den Roboter
        /// </summary>
        public static void driveParcour()
        {
            Robot robot = new Robot();
            robot.Drive.Power = true;

            // gerade aus fahren
            robot.Drive.RunLine(2.5f, 0.3f, 0.5f);
            while(!robot.Drive.Done)
            {
                // warten bis fertig gefahren
                Thread.Sleep(100);
                // Hier Messen
            }

            robot.Drive.RunTurn(90.0f, 0.3f, 0.5f);
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

            robot.Drive.RunTurn(90.0f, 0.3f, 0.5f);
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

            // Roboter stoppen
            robot.Drive.Stop();

        }
    }

    
}
