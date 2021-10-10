using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class AsyncAndAwait : Form
    {
        public AsyncAndAwait()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            // Create a StreamReader and point it to the file to read
            using (StreamReader reader = new StreamReader("D:\\C_Workspaces_Repositories\\GitHub_Repositories" +
                "\\DotNetCodePractice\\gradebook\\Scott's Grade Book.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                // Make the program look busy for 5 seconds
                Thread.Sleep(5000);
            }

            return count;
        }

        private void btnProcessFIleNormal_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Processing file. Please wait...";
            int count = CountCharacters();
            lblCount.Text = count.ToString() + " characters in file";
        }

        // Make the method async by using the async keyword
        private async void btnProcessFIleAsync_Click(object sender, EventArgs e)
        {
            // Create a task to execute CountCharacters() function
            // CountCharacters() function returns int, so we created Task<int>
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblCount.Text = "Processing file. Please wait...";
            // Wait until the long running task completes
            int count = await task;
            lblCount.Text = count.ToString() + " characters in file";
        }

        // While the application is busy processning the file,
        // the UI is blocked i.e we cannot move the form around or resize it.
        private void btnProcessFileThreadJoin_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() => { count = CountCharacters(); });
            thread.Start();

            lblCount.Text = "Processing file. Please wait...";
            // Join() blocks the Main thread (UI Thread)
            thread.Join();
            lblCount.Text = count.ToString() + " characters in file";
        }

        // You may be thinking why can't we move the code that updates the label control Text property
        // into the worker thread as shown below. 
        // This is dangerous because, the thread that has created the control must modify the control.
        // In our case the Main thread (i.e UI Thread) is the thread that has created the label control
        // so only the Main thread should set it's Text property and not the worker thread. 
        // If you run the application it may or may not work as expected.
        // If it is working, it is only working by blind luck.
        /*
         Error:
            System.InvalidOperationException: 'Cross-thread operation not valid: 
            Control 'lblCount' accessed from a thread other than the thread it was created on.'
         */
        private void btnProcessFileThreadWithoutJoin_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() =>
            {
                count = CountCharacters();
                // This is dangerous
                lblCount.Text = count.ToString() + " characters in file";
            });
            thread.Start();

            lblCount.Text = "Processing file. Please wait...";
        }

        // The right way to achieve this is by using BeginInvoke() method as shown below.
        // BeginInvoke() method asks the UI thread to set the Text property of the label control in a type safe manner.
        // Here we have used Lambda Expression
        private void btnProcessFileBeingInvokeLambda_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() =>
            {
                count = CountCharacters();
                Action action = () => lblCount.Text = count.ToString() + " characters in file";
                this.BeginInvoke(action);
            });
            thread.Start();

            lblCount.Text = "Processing file. Please wait...";
        }

        private void btnProcessFileBeingInvokeWithoutLambda_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                characterCount = CountCharacters();
                // Action delegate points to SetLabelTextProperty method
                // Signature of SetLabelTextProperty() method should match
                // with the signature of Action delegate
                Action action = new Action(SetLabelTextProperty);
                this.BeginInvoke(action);
            });
            thread.Start();

            lblCount.Text = "Processing file. Please wait...";
        }

        int characterCount = 0;

        private void SetLabelTextProperty()
        {
            lblCount.Text = characterCount.ToString() + " characters in file";
        }

        // Re-write the above code using explicit outer method
    }
}
