/* 
 * HELLO! Thank you for reading the source code!
 * This was a fun April Fool's joke for 2018 on the LyricWulf channel.
 * Here is the trailer demonstrating what it should do https://youtu.be/pikPcw3A0Ow
 * Join the Discord server for more fun http://piano.dog/discord
 * Love,
 * Lyric
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynthesiaX2.Properties;
using Microsoft.VisualBasic.Devices;

namespace SynthesiaX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lockWatch();
            disableButtons();

            Random rnd = new Random();
            this.seedControl.Text = rnd.Next(10000, 99999).ToString();

            this.rendering = false;
            this.locked = false;
            renderLabel.BackColor = System.Drawing.Color.Transparent;
            renderLabel.Visible = false;
            etaLabel.Visible = false;

            disableButtons();
            startWindow();
            disableButtons();
        }

        private void color1_Focus(object sender, EventArgs e)
        {
            color1.Enabled = false;
            color1.Enabled = true;
        }

        private void color2_Focus(object sender, EventArgs e)
        {
            color2.Enabled = false;
            color2.Enabled = true;
        }

        async private void renderWatch()
        {
            while (true)
            {
                if (this.rendering)
                {

                    timer_Start();
                    sw_Start();

                    pictureBox1.Enabled = true;
                    progress.Visible = true;
                    renderLabel.Visible = true;
                    etaLabel.Visible = true;
                    fileOpenButton.Enabled = false;
                    disableButtons();
                    disableBrowse();

                    this.Size = new System.Drawing.Size(400, 515);
                }
                else
                {
                    pictureBox1.Enabled = false;
                    progress.Visible = false;
                    renderLabel.Visible = false;
                    etaLabel.Visible = false;
                    progress.Value = 0;
                    this.locked = false;
                }

                await Task.Delay(10);
            }
        }

        async private void lockWatch()
        {
            while (true)
            {
                if (this.locked)
                {
                    fileOpenButton.Enabled = false;
                    disableButtons();
                    disableBrowse();
                }
                else
                {
                }

                await Task.Delay(1);
            }
        }

        async private void startWindow()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Size = new System.Drawing.Size(640, 360);
            this.CenterToScreen();

            await Task.Delay(3000);

            splashScreen.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // this.Size = new System.Drawing.Size(398, 502);
            this.Size = new System.Drawing.Size(798, 515);
            this.CenterToScreen();
            renderWatch();
        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            // int size = -1;
            openFileDialog1.Filter = "MIDI files (*.mid)|*.mid";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    fileTextBox.Text = file;
                    // string text = File.ReadAllText(file);
                    // size = text.Length;
                }
                catch (IOException)
                {
                }
            }

            // Console.WriteLine(size); // <-- Shows file size in debugging mode.
            // Console.WriteLine(result); // <-- For debugging use.
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "MP4 video files (*.mp4)|*.mp4";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            // int size = -1;
            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                try
                {
                    savePath.Text = file;
                    // string text = File.ReadAllText(file);
                    // size = text.Length;
                }
                catch (IOException)
                {
                }
            }

            // Console.WriteLine(size); // <-- Shows file size in debugging mode.
            // Console.WriteLine(result); // <-- For debugging use.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Check_boxes();
        }

        private void savePath_TextChanged(object sender, EventArgs e)
        {
            Check_boxes();
        }

        private void Check_boxes()
        {
            if (fileTextBox.Text == "" || savePath.Text == "")
            {
                disableButtons();
            }
            else
            {
                enableButtons();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        async private void renderButton_Click(object sender, EventArgs e)
        {
            this.locked = true;

            string midiPath = fileTextBox.Text;
            string outPath = savePath.Text;

            disableButtons();
            disableBrowse();
            this.Size = new System.Drawing.Size(400, 515);

            logTextBox.AppendText("Starting render instance");
            disableButtons();
            disableBrowse();
            await Task.Delay(400);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText(".");
            await Task.Delay(400);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText(".");
            await Task.Delay(400);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText("."); ;
            await Task.Delay(200);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("Instance start success!");
            await Task.Delay(100);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText("\r\n");

            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("Reading file");
            await Task.Delay(500);
            disableButtons();
            disableBrowse();
            logTextBox.AppendText(".");
            await Task.Delay(500);
            disableButtons();
            disableBrowse();
            if (Path.GetExtension(midiPath) == ".mid" && File.Exists(midiPath))
            {
                logTextBox.AppendText(".");
                await Task.Delay(500);

                FileInfo info = new FileInfo(midiPath);

                if (info.Length > 192000)
                {
                    await Task.Delay(1000);
                    render_Cancel("Error!\r\nCould not read MIDI file. Please verify that \"" + midiPath + "\" is a valid MIDI file.\r\n(Exit code -0x00594321)");
                    return;
                }

                logTextBox.AppendText(".");
                await Task.Delay(200);
                logTextBox.AppendText("\r\nSuccessfully imported file \"" + midiPath + "\"");
                await Task.Delay(1000);
                logTextBox.AppendText("\r\n\r\n");
            }
            else
            {
                await Task.Delay(1000);
                render_Cancel("Error!\r\nCould not read MIDI file. Please verify that \"" + midiPath + "\" is a valid MIDI file.\r\n(Exit code -0x00594320)");
                return;
            }

            logTextBox.AppendText("--- BEGIN RENDER SEQUENCE ---");
            await Task.Delay(1000);

            if ((!(velocityControl.Text == "auto")) && (Convert.ToInt32(velocityControl.Text) > 500 || Convert.ToInt32(velocityControl.Text) < 0))
            {
                await Task.Delay(1000);
                render_Cancel("Error!\r\nInvalid velocity offset. Please ensure the velocity offset is either set to \"auto\" or within the range 0-500\r\n(Exit code -0x00994320)");
                return;
            }

            if (Convert.ToInt32(seedControl.Text) > 99999 || Convert.ToInt32(seedControl.Text) < 1)
            {
                await Task.Delay(1000);
                render_Cancel("Error!\r\nInvalid random seed. Please ensure the seed is within the range 1-99999\r\n(Exit code -0x00994320)");
                return;
            }

            if (!hasWriteAccess(outPath))
            {
                await Task.Delay(1000);
                render_Cancel("Error!\r\nInvalid save path. Please verify that \"" + outPath + "\" is a valid save path that you have access to.\r\n(Exit code -0x00694320)");
                return;
            }

            this.rendering = true;

            logTextBox.AppendText("\r\n");

            MemoryStream m1 = new MemoryStream(Properties.Resources.video);
            MemoryStream m2 = new MemoryStream(Properties.Resources.video);
            MemoryStream m3 = new MemoryStream(Properties.Resources.video);
            MemoryStream m4 = new MemoryStream(Properties.Resources.video);
            MemoryStream m5 = new MemoryStream(Properties.Resources.video);
            MemoryStream m6 = new MemoryStream(Properties.Resources.video);
            MemoryStream m7 = new MemoryStream(Properties.Resources.video);
            MemoryStream m8 = new MemoryStream(Properties.Resources.video);

            string[] tasks = {"Rendering audio previews", "Normalizing audio levels", "Creating effects database", "Compiling assets", "Determining M tick resolution",
                "Optimizing target bitrate", "Rendering video sector 1", "Rendering video sector 2", "Combining files", "Rendering video sector 3",
                "Combining files", "Rendering video sector 4", "Combining files", "Rendering video sector 5", "Combining files",
                "Rendering control sequence", "Generating composite effects", "Combining files", "Scanning for errors", "Cleaning up"};

            var queue = new Queue(tasks);

            List<TimeSpan> timeSpans = new List<TimeSpan>();
            for (int i = 0; i < tasks.Length; i++)
            {
                Stopwatch watch = Stopwatch.StartNew();
                //do stuff
                timeSpans.Add(watch.Elapsed);
                long ticksLeft = timeSpans.Sum(ts => ts.Ticks) * (tasks.Length - i) / timeSpans.Count;
                logTextBox.AppendText("\r\n");

                logTextBox.AppendText((string) queue.Peek());
          
                // logTextBox.AppendText("Finished in: " +
                //    DateTime.Now.AddTicks(ticksLeft));
                int delay = 1000 * (int) (69/2 + Math.Abs(Math.Round(69 * 1 * Math.Sin(i/6.9))));
                Dots(delay);
                await Task.Delay(delay);
                logTextBox.AppendText("\r\n");
                logTextBox.AppendText((string)queue.Peek() + " complete!");
                logTextBox.AppendText("\r\n");

                queue.Dequeue();
                step();
            }

            logTextBox.AppendText("Finalizing render");
            Dots(3000);
            copyVideo();

            m1.Close();
            m2.Close();
            m3.Close();
            m4.Close();
            m5.Close();
            m6.Close();
            m7.Close();
            m8.Close();

            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("Render complete!");
            logTextBox.AppendText("\r\n");
            logTextBox.AppendText("Opening output folder!\r\n");
            await Task.Delay(3000);
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", outPath));

            rendering = false;
            enableButtons();

            MessageBox.Show("File folder has been opened. Use headphones for best experience.", "Render complete",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);
        }

        private void render_Cancel(string errorMessage)
        {
            this.rendering = false;
            logTextBox.AppendText("\r\n\r\n--------------------\r\n" + errorMessage + "\r\n--------------------\r\n\r\n");
            enableButtons();
            this.Size = new System.Drawing.Size(798, 515);
        }

        private void disableButtons()
        {
            renderButton.BackColor = Color.Gray;
            renderButton.Enabled = false;

        }

        private void disableBrowse()
        {
            fileOpenButton.BackColor = Color.Gray;
            fileOpenButton.Enabled = false;
            saveButton.BackColor = Color.Gray;
            saveButton.Enabled = false;
        }

        private void enableButtons()
        {
            renderButton.Enabled = true;
            renderButton.BackColor = Color.FromArgb(255, 30, 30, 30);
            fileOpenButton.BackColor = Color.FromArgb(255, 30, 30, 30);
            fileOpenButton.Enabled = true;
            saveButton.BackColor = Color.FromArgb(255, 30, 30, 30);
            saveButton.Enabled = true;
        }

        private void step()
        {
            progress.PerformStep();
        }

        async private void Dots(int interval)
        {
            int cpuUsage = 1;
            int time = 1;


            await Task.Delay(interval/20);
            int span = interval / 10;

            for (int i = 0; i < 9; i++)
            {
                logTextBox.AppendText(".");
                for (int j = 0; j < 1; j++)
                {
                    List<Thread> threads = new List<Thread>();
                    for (int k = 0; k < Environment.ProcessorCount; k++)
                    {
                        Thread t = new Thread(new ParameterizedThreadStart(CPUKill));
                        t.Start(cpuUsage);
                        threads.Add(t);
                    }
                    Thread.Sleep(time);
                    foreach (var t in threads)
                    {
                        t.Abort();
                    }
                    await Task.Delay(interval / 5);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void copyVideo()
        {
            var byteArray = Properties.Resources.video;
            File.WriteAllBytes(@savePath.Text, byteArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool hasWriteAccess(string folderPath)
        {
            try
            {
                string fullPath = Path.GetDirectoryName(Path.GetFullPath(folderPath));

                // Attempt to get a list of security permissions from the folder. 
                // This will raise an exception if the path is read only or do not have access to view the permissions. 
                System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(fullPath);
                Debug.WriteLine(ds);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            } catch (Exception)
            {
                return false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public bool CloseCancel()
        {
            if (this.rendering)
            {
                const string message = "All current render progress will be permanently lost.";
                const string caption = "Close LW Synthesia Engine X?";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    return true;
                else
                    return false;
            } else
            {
                return true;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }


        Random rng = new Random();

        private bool sw_started = false;

        private async void sw_Start()
        {
            if (!sw_started)
            {
                sw_started = true;
                int swCounter = 0;
                while (true)
                {
                    swCounter++;
                    renderLabel.Text = string.Format("Rendering... {0}", TimeSpan.FromSeconds(swCounter).ToString());
                    await Task.Delay(1000);
                }
            }
        }
        //                 

        private bool timer_started = false;

        // COUNTDOWN (ETA)
        private async void timer_Start()
        {
            if (!timer_started)
            {
                timer_started = true;
                int timerCounter = 1092;
                int timerDelay = 1000;
                while (true)
                {
                    timerCounter--;
                    etaLabel.Text = string.Format("Estimated time left... {0}", TimeSpan.FromSeconds(timerCounter).ToString());
                    await Task.Delay(timerDelay);
                    timerDelay += 1;
                }
            }

        }

        public static void CPUKill(object cpuUsage)
        {
            Parallel.For(0, 1, new Action<int>((int i) =>
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                while (true)
                {
                    if (watch.ElapsedMilliseconds > (int)cpuUsage)
                    {
                        Thread.Sleep(100 - (int)cpuUsage);
                        watch.Reset();
                        watch.Start();
                    }
                }
            }));

        }

        public void Slow()
        {
            long nthPrime = FindPrimeNumber(50000); //set higher value for more time
        }

        public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            Debug.WriteLine(--a);
            return (--a);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // SETTINGS

        private void color1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color1.BackColor = colorDialog1.Color;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color2.BackColor = colorDialog1.Color;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void velocityControl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
