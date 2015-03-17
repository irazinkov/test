using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uEyeDotNET_Sequence_EngineeringSample
{
    public partial class uEye_DotNet_Sequence_EngineeringSample : Form
    {
        private uEye.Camera Camera;
        IntPtr displayHandle = IntPtr.Zero;
        int SequenceCount = 0;

        //private uEye.Info.Camera info_camera;
        uEye.Defines.Status statusRet = 0;

        public uEye_DotNet_Sequence_EngineeringSample()
        {
            InitializeComponent();

            displayHandle = DisplayWindow.Handle;
            InitCamera();
        }

        private void InitCamera()
        {
            Camera = new uEye.Camera();

            // Open Camera
            statusRet = Camera.Init();
            if (statusRet != uEye.Defines.Status.Success)
            {
                MessageBox.Show("Camera initializing failed");
                Environment.Exit(-1);
            }

            // Allocate Memory
            for (int i = 0; i < 10; i++)
            {
                statusRet = Camera.Memory.Allocate(true);
            }

            // Get Memory List
            int[] idList;
            statusRet = Camera.Memory.GetList(out idList);

            // Add memory list to sequence
            statusRet = Camera.Memory.Sequence.Add(idList);

            // Start Live Video
            statusRet = Camera.Acquisition.Capture();

            // Connect on events
            Camera.EventFrame += onFrameEvent;
            Camera.EventSequence += onSequenceEvent; 


        }

        private void onFrameEvent(object sender, EventArgs e)
        {
            uEye.Camera Camera = sender as uEye.Camera;

            // Get active sequence memory
            int s32SeqID;
            statusRet = Camera.Memory.Sequence.GetLast(out s32SeqID);

            Camera.Display.Render(s32SeqID, displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);

            
            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.Invoke((MethodInvoker)delegate()
                {
                    this.progressBar1.Value = s32SeqID;
                }
                );
            }

            if (this.txt_SeqID.InvokeRequired)
            {
                this.txt_SeqID.Invoke((MethodInvoker)delegate()
                {
                    this.txt_SeqID.Text = s32SeqID.ToString();
                }
                );
            }

        }

        private void onSequenceEvent(object sender, EventArgs e)
        {
            uEye.Camera Camera = sender as uEye.Camera;
            SequenceCount++;

            if (this.txt_SequenceCount.InvokeRequired)
            {
                this.txt_SequenceCount.Invoke((MethodInvoker)delegate()
                {
                    this.txt_SequenceCount.Text = SequenceCount.ToString();
                });
            }
        }

        private void btn_StartLiveVideo_Click(object sender, EventArgs e)
        {
            statusRet = Camera.Acquisition.Capture();
            displayHandle = DisplayWindow.Handle;
        }

        private void btn_StopLiveVideo_Click(object sender, EventArgs e)
        {
            Camera.Acquisition.Stop();
        }

        private void btn_FreezeVideo_Click(object sender, EventArgs e)
        {
            Camera.Acquisition.Freeze();
            displayHandle = DisplayWindow.Handle;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Camera.Exit();
            Close();
        }

        private void btn_StopAndReplay_Click(object sender, EventArgs e)
        {
            // Stop image acquisition
            statusRet = Camera.Acquisition.Stop(uEye.Defines.DeviceParameter.Wait);

            // Get Sequence Mem List
            int[] idList;
            statusRet = Camera.Memory.Sequence.GetList(out idList);

            int[] s32MemID = new int[10];
            for (int i = 0; i < 10; i++)
            {
                statusRet = Camera.Memory.Sequence.ToMemoryID(idList[i], out s32MemID[i]);
            }

            // Display MemID 1 - 5
            displayHandle = pictureBox1.Handle;
            Camera.Display.Render(s32MemID[1], displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
            displayHandle = pictureBox2.Handle;
            Camera.Display.Render(s32MemID[2], displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
            displayHandle = pictureBox3.Handle;
            Camera.Display.Render(s32MemID[3], displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
            displayHandle = pictureBox4.Handle;
            Camera.Display.Render(s32MemID[4], displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
            displayHandle = pictureBox5.Handle;
            Camera.Display.Render(s32MemID[5], displayHandle, uEye.Defines.DisplayRenderMode.FitToWindow);
        }

        ///Ivan's edits
        private void DisplayWindow_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            MessageBox.Show(coordinates.ToString());
        }

        private void btn_GetCameraList_Click(object sender, EventArgs e)
        {
           uEye.Types.CameraInformation[] CameraList;
           uEye.Info.Camera.GetCameraList(out CameraList);
           MessageBox.Show(CameraList[0].SerialNumber);
        }

    }
}
