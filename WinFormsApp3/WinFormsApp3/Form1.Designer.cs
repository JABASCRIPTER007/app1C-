
using System;

namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HarmonicMean = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.GeometricMean = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Median = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.input = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Range = new System.Windows.Forms.Label();
            this.allValues = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Визначити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Середнє арифметичне:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Медіана:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Середнє геометричне:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Максимальне значення:";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(321, 203);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(0, 20);
            this.Average.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Середнє гармонічне:";
            // 
            // HarmonicMean
            // 
            this.HarmonicMean.AutoSize = true;
            this.HarmonicMean.Location = new System.Drawing.Point(329, 349);
            this.HarmonicMean.Name = "HarmonicMean";
            this.HarmonicMean.Size = new System.Drawing.Size(0, 20);
            this.HarmonicMean.TabIndex = 13;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(329, 277);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(0, 20);
            this.Min.TabIndex = 12;
            // 
            // GeometricMean
            // 
            this.GeometricMean.AutoSize = true;
            this.GeometricMean.Location = new System.Drawing.Point(329, 384);
            this.GeometricMean.Name = "GeometricMean";
            this.GeometricMean.Size = new System.Drawing.Size(0, 20);
            this.GeometricMean.TabIndex = 11;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(329, 320);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(0, 20);
            this.Max.TabIndex = 10;
            // 
            // Median
            // 
            this.Median.AutoSize = true;
            this.Median.Location = new System.Drawing.Point(321, 237);
            this.Median.Name = "Median";
            this.Median.Size = new System.Drawing.Size(0, 20);
            this.Median.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Мінімальне значення:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Додати значення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddValue);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(63, 61);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(331, 27);
            this.input.TabIndex = 16;
            // 
            // textMessage
            // 
            this.textMessage.AutoSize = true;
            this.textMessage.Location = new System.Drawing.Point(116, 21);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(195, 20);
            this.textMessage.TabIndex = 17;
            this.textMessage.Text = "Статистичний Калькулятор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Діапазон:";
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Location = new System.Drawing.Point(329, 422);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(0, 20);
            this.Range.TabIndex = 19;
            // 
            // allValues
            // 
            this.allValues.AutoSize = true;
            this.allValues.Location = new System.Drawing.Point(240, 102);
            this.allValues.Name = "allValues";
            this.allValues.Size = new System.Drawing.Size(0, 20);
            this.allValues.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Послідовність: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 575);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.allValues);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HarmonicMean);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.GeometricMean);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Median);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HarmonicMean;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label GeometricMean;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Median;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label textMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.Label allValues;
        private System.Windows.Forms.Label label7;
    }
}

