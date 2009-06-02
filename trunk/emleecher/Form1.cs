using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace emleecher {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e) {
      folderBrowserDialog1.ShowDialog();
      textBox1.Text = folderBrowserDialog1.SelectedPath;
    }

    private void button2_Click(object sender, EventArgs e) {
      folderBrowserDialog2.ShowDialog();
      textBox2.Text = folderBrowserDialog2.SelectedPath;
    }

    private void button3_Click(object sender, EventArgs e) {
      Thread thread = new Thread(new ThreadStart(runThaProcess));
      thread.Start();
    }
    private void runThaProcess() {
      DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
      FileInfo[] files = dir.GetFiles();
      int count = 0;
      foreach (FileInfo file in files) {
        count++;
        setProgressBarValue((int)(((double)count / files.Length) * 100), file.FullName);
        try {
          if (file.Extension == ".eml") {
            Console.WriteLine(file.FullName);
            parseEml(file.FullName, textBox2.Text);
          }
        } catch (System.Exception) { }
      }
    }

    delegate void progressBarSetterDelegate(int p, string s);

    private void setProgressBarValue(int p, string label) {
      if (progressBar1.InvokeRequired) {
        progressBar1.Invoke(new progressBarSetterDelegate(setProgressBarValue), p, label);
      } else {
        progressBar1.Value = p;
        label1.Text = label;
      }
    }

    private void setProgressBar2Value(int p, string label) {
      if (progressBar2.InvokeRequired) {
        progressBar2.Invoke(new progressBarSetterDelegate(setProgressBar2Value), p, label);
      } else {
        progressBar2.Value = p;
        label2.Text = label;
      }
    }

    private void parseEml(string sourceFile, string outPath) {
      if (!outPath.EndsWith("\\")) {
        outPath += "\\";
      }
      StreamReader reader = new StreamReader(File.Open(sourceFile, FileMode.Open));
      string read = null;
      string attachmentName = null;
      StringWriter tempString = new StringWriter();
      bool beginRead = false;
      int val=0;
      while ((read = reader.ReadLine()) != null) {
        val = (int)(((double)reader.BaseStream.Position / reader.BaseStream.Length) * 100);
        if (attachmentName == null) {
          if (read.StartsWith("Content-Disposition: attachment; filename=")) {
            attachmentName = read.Substring("Content-Disposition: attachment; filename=".Length).Trim();
            if (attachmentName.StartsWith("\"")) {
              attachmentName = attachmentName.Substring(1);
            }
            if (attachmentName.EndsWith("\"")) {
              attachmentName = attachmentName.Substring(0, attachmentName.Length - 1);
            }
            setProgressBar2Value(val, attachmentName);
            beginRead = false;
          }
        } else {
          if (read.StartsWith("--")) {
            try {
              Stream output = File.Open(outPath + attachmentName, FileMode.CreateNew);
              byte[] ttt = Convert.FromBase64String(tempString.ToString());
              output.Write(ttt, 0, ttt.Length);
              output.Close();
            } catch (System.Exception) {
              Console.WriteLine(outPath + attachmentName +" could not be created");
            }
            tempString = new StringWriter();
            attachmentName = null;
            beginRead = false;
            setProgressBar2Value(val, "");
          } else {
            if (beginRead) {
              tempString.Write(read.Trim());
            } else {
              if (read.Trim() == "") {
                beginRead = true;
              }
            }
          }
        }
      }
      reader.Close();
    }
  }
}
