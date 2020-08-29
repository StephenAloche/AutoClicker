using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        List<CustomAction> listActions;
        Cursor Cursor;

        public Form1()
        {
            Cursor = new Cursor(Cursor.Current.Handle);
            this.KeyPreview = true;
            InitializeComponent();
            listActions = new List<CustomAction>();
        }

        bool isRecording = false;
        bool isRunning = false;

        /// <summary>
        /// ecoute les input utilisateur et les enregistre dans une liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Record_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                isRecording = false;
                btn_Record.Text = "Record";
                Lbl_stopped.Visible = true;
            }
            else
            {
                listActions.Clear();
                Lv_Actions.Items.Clear();
                isRecording = true;
                btn_Record.Text = "Recording";
                Lbl_stopped.Visible = false;
            }
        }

        /// <summary>
        /// recupere la liste des input utiliser par l'utilisateur et les effectue a la suite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Launch_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                Lbl_stopped.Visible = true;
                btn_Launch.Text = "Launch";
                return;
            }
            else
            {
                isRunning = true;
                if (isRecording)
                {
                    isRecording = false;
                }
                btn_Launch.Text = "Running";
                Lbl_stopped.Visible = false;
            }

            int i = 0;
            foreach (CustomAction action in listActions)
            {
                //Lv_Actions.Focus();
                //Lv_Actions.Select();
                //Lv_Actions.Items[i].Focused=true;
                //Lv_Actions.Items[i].Selected = true;
                MoveCursor(action.posX, action.posY);
                if (action.key == Keys.ShiftKey)
                {
                    DoMouseClick(false);
                }
                if (action.key == Keys.ControlKey)
                {
                    DoMouseClick(true);
                }
                if (action.key == Keys.D) // ajout delai
                {
                    Thread.Sleep(action.delay);
                }
                i++;
                Thread.Sleep(500);
            }
        }


        public void MoveCursor(int posx, int posy)
        {

            if (StopProgramme())
            {
                return;
            }

            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(posx, posy);

            Val_PosX.Text = posx.ToString();
            Val_PosY.Text = posy.ToString();
        }
        public void DoMouseClick(bool rightClick)
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            if (rightClick)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
        }
        public bool StopProgramme()
        {
            return false;

            //stop si le curseur n'est pas compris entre 640 et 1280 ni entre 360 et 720
            bool stopped = !(Cursor.Position.X > 640 && Cursor.Position.X < 1280)
                    || !(Cursor.Position.Y > 360 && Cursor.Position.Y < 720);
            Lbl_stopped.Visible = stopped;
            return stopped;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isRecording)
                return;


            CustomAction act = new CustomAction();
            act.posX = Cursor.Position.X;
            act.posY = Cursor.Position.Y;

            if (e.KeyCode == Keys.ShiftKey)
            {
                act.key = Keys.ShiftKey;
                act.Name = "Click";
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                act.key = Keys.ControlKey;
                act.Name = "Right Click";
            }
            if (e.KeyCode == Keys.D)
            {
                act.key = Keys.D;
                int promptValue = Prompt.ShowDialog();
                act.delay = promptValue;
                act.Name = $"Delay {promptValue} ms";
            }
            listActions.Add(act);
            Lv_Actions.Items.Add(new ListViewItem(new string[] {act.Name, act.posX.ToString() ,act.posY.ToString()}));
        }

        public class CustomAction
        {
            public int posX { get; set; }
            public int posY { get; set; }
            public Keys key { get; set; }
            public string Name {get;set; }
            public int delay { get; set; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Val_PosX.Text = Cursor.Position.X.ToString();
            Val_PosY.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class Prompt
        {
            public static int ShowDialog()
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = "Add delay",
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = "delay in ms" };
                NumericUpDown numInput = new NumericUpDown() { Minimum = 0, Maximum=10000, Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(numInput);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? (int)numInput.Value : 0;
            }
        }
    }
}
