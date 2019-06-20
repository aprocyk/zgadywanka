namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.buttonPoddanie = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.textBoxZakresMax = new System.Windows.Forms.TextBox();
            this.textBoxZakresMin = new System.Windows.Forms.TextBox();
            this.groupBoxPropozycja = new System.Windows.Forms.GroupBox();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInformacje = new System.Windows.Forms.GroupBox();
            this.labelinformacje = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxPropozycja.SuspendLayout();
            this.groupBoxInformacje.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // buttonPoddanie
            // 
            this.buttonPoddanie.Location = new System.Drawing.Point(453, 12);
            this.buttonPoddanie.Name = "buttonPoddanie";
            this.buttonPoddanie.Size = new System.Drawing.Size(75, 23);
            this.buttonPoddanie.TabIndex = 1;
            this.buttonPoddanie.Text = "Poddaję się";
            this.buttonPoddanie.UseVisualStyleBackColor = true;
            this.buttonPoddanie.Visible = false;
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(12, 415);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 2;
            this.buttonHistoria.Text = "Historia gry";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Visible = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(452, 415);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Informacje";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresMax);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresMin);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 64);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(515, 133);
            this.groupBoxLosowanie.TabIndex = 4;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(255, 35);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Losuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(6, 68);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 3;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(7, 25);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 2;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // textBoxZakresMax
            // 
            this.textBoxZakresMax.Location = new System.Drawing.Point(76, 61);
            this.textBoxZakresMax.Name = "textBoxZakresMax";
            this.textBoxZakresMax.Size = new System.Drawing.Size(133, 20);
            this.textBoxZakresMax.TabIndex = 1;
            // 
            // textBoxZakresMin
            // 
            this.textBoxZakresMin.Location = new System.Drawing.Point(76, 19);
            this.textBoxZakresMin.Name = "textBoxZakresMin";
            this.textBoxZakresMin.Size = new System.Drawing.Size(133, 20);
            this.textBoxZakresMin.TabIndex = 0;
            // 
            // groupBoxPropozycja
            // 
            this.groupBoxPropozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBoxPropozycja.Controls.Add(this.buttonSprawdz);
            this.groupBoxPropozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBoxPropozycja.Controls.Add(this.label1);
            this.groupBoxPropozycja.Location = new System.Drawing.Point(12, 204);
            this.groupBoxPropozycja.Name = "groupBoxPropozycja";
            this.groupBoxPropozycja.Size = new System.Drawing.Size(515, 163);
            this.groupBoxPropozycja.TabIndex = 5;
            this.groupBoxPropozycja.TabStop = false;
            this.groupBoxPropozycja.Text = "Odgadnij";
            this.groupBoxPropozycja.Visible = false;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(10, 84);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(35, 13);
            this.labelOdpowiedz.TabIndex = 3;
            this.labelOdpowiedz.Text = "label2";
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(182, 57);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(10, 57);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(155, 20);
            this.textBoxPropozycja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba wylosowana, odgadnij ją!";
            // 
            // groupBoxInformacje
            // 
            this.groupBoxInformacje.Controls.Add(this.labelinformacje);
            this.groupBoxInformacje.Location = new System.Drawing.Point(12, 373);
            this.groupBoxInformacje.Name = "groupBoxInformacje";
            this.groupBoxInformacje.Size = new System.Drawing.Size(516, 36);
            this.groupBoxInformacje.TabIndex = 6;
            this.groupBoxInformacje.TabStop = false;
            this.groupBoxInformacje.Text = "Informacje";
            this.groupBoxInformacje.Visible = false;
            // 
            // labelinformacje
            // 
            this.labelinformacje.AutoSize = true;
            this.labelinformacje.Location = new System.Drawing.Point(11, 19);
            this.labelinformacje.Name = "labelinformacje";
            this.labelinformacje.Size = new System.Drawing.Size(290, 13);
            this.labelinformacje.TabIndex = 0;
            this.labelinformacje.Text = "Tutaj powinny zostać zawarte różne informacje odnośnie gry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.groupBoxInformacje);
            this.Controls.Add(this.groupBoxPropozycja);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.buttonPoddanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxPropozycja.ResumeLayout(false);
            this.groupBoxPropozycja.PerformLayout();
            this.groupBoxInformacje.ResumeLayout(false);
            this.groupBoxInformacje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.Button buttonPoddanie;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.TextBox textBoxZakresMax;
        private System.Windows.Forms.TextBox textBoxZakresMin;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.GroupBox groupBoxPropozycja;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInformacje;
        private System.Windows.Forms.Label labelinformacje;
    }
}

