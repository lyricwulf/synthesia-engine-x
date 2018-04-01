/* 
 * HELLO! Thank you for reading the source code!
 * This was a fun April Fool's joke for 2018 on the LyricWulf channel.
 * Here is the trailer demonstrating what it should do https://youtu.be/pikPcw3A0Ow
 * Join the Discord server for more fun http://piano.dog/discord
 * Love,
 * Lyric
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynthesiaX2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
