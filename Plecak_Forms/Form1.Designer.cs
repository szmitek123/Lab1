namespace Plecak_Forms
{
    partial class PlecakForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Run = new System.Windows.Forms.Button();
            this.tbSeed = new System.Windows.Forms.TextBox();
            this.tbLiczba = new System.Windows.Forms.TextBox();
            this.tbPojemnosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.przedmioty_listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(59, 212);
            this.Run.Margin = new System.Windows.Forms.Padding(4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(100, 28);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click_1);
            // 
            // tbSeed
            // 
            this.tbSeed.BackColor = System.Drawing.SystemColors.Info;
            this.tbSeed.Location = new System.Drawing.Point(59, 33);
            this.tbSeed.Margin = new System.Windows.Forms.Padding(4);
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.Size = new System.Drawing.Size(132, 22);
            this.tbSeed.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbSeed, "wpisz seed!");
            this.tbSeed.TextChanged += new System.EventHandler(this.tbSeed_TextChanged);
            // 
            // tbLiczba
            // 
            this.tbLiczba.BackColor = System.Drawing.SystemColors.Info;
            this.tbLiczba.Location = new System.Drawing.Point(59, 91);
            this.tbLiczba.Margin = new System.Windows.Forms.Padding(4);
            this.tbLiczba.Name = "tbLiczba";
            this.tbLiczba.Size = new System.Drawing.Size(132, 22);
            this.tbLiczba.TabIndex = 2;
            this.toolTip2.SetToolTip(this.tbLiczba, "wpisz liczbę przedmiotów, musi być liczba całkowita!");
            // 
            // tbPojemnosc
            // 
            this.tbPojemnosc.BackColor = System.Drawing.SystemColors.Info;
            this.tbPojemnosc.Location = new System.Drawing.Point(59, 154);
            this.tbPojemnosc.Margin = new System.Windows.Forms.Padding(4);
            this.tbPojemnosc.Name = "tbPojemnosc";
            this.tbPojemnosc.Size = new System.Drawing.Size(132, 22);
            this.tbPojemnosc.TabIndex = 3;
            this.toolTip3.SetToolTip(this.tbPojemnosc, "wpisz jaką pojemność ma mieć plecak!");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "liczba przedmiotow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "pojemność";
            // 
            // przedmioty_listBox
            // 
            this.przedmioty_listBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.przedmioty_listBox.FormattingEnabled = true;
            this.przedmioty_listBox.ItemHeight = 16;
            this.przedmioty_listBox.Location = new System.Drawing.Point(353, 273);
            this.przedmioty_listBox.Name = "przedmioty_listBox";
            this.przedmioty_listBox.Size = new System.Drawing.Size(233, 308);
            this.przedmioty_listBox.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 308);
            this.listBox1.TabIndex = 10;
            // 
            // PlecakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 599);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.przedmioty_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPojemnosc);
            this.Controls.Add(this.tbLiczba);
            this.Controls.Add(this.tbSeed);
            this.Controls.Add(this.Run);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlecakForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox tbSeed;
        private System.Windows.Forms.TextBox tbLiczba;
        private System.Windows.Forms.TextBox tbPojemnosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox przedmioty_listBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

