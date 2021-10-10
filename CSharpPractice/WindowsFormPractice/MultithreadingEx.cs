using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class MultithreadingEx : Form
    {
        public MultithreadingEx()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            // Code Without new Thread created
            btnTimeConsumingWorkWiyhoutMultiThreaded();

            // Code with new Thread added
            // btnTimeConsumingWorkMultiThreaded();
        }

        private void btnTimeConsumingWorkWiyhoutMultiThreaded()
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }
        
        private void btnTimeConsumingWorkMultiThreaded()
        {
            
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            // Create another THREAD to offload the work of
            // executing the time consuming method to it.
            // As a result the UI thread, is free to execute the
            // rest of the code and our application is more responsive.
            Thread backGroundThread = new Thread(DoTimeConsumingWork);
            backGroundThread.Start();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
            MessageBox.Show("DoTimeConsumingWork exexuted Successfully!!!");

            // txtTimeConsumingWork.Text = "DoTimeConsumingWork exexuted Successfully!!!";
            /* Error :-
             * Cross-thread operation not valid: Control 'txtTimeConsumingWork' 
             * accessed from a thread other than the thread it was created on.'
             * Solution :-
             * Use a shared container to transfer data between threads.
             */

        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MultithreadingEx_Load(object sender, EventArgs e)
        {

        }
    }
}
