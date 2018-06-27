namespace CSConfigChanger2._0
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
      this.cfgButton = new System.Windows.Forms.Button();
      this.crossHair1 = new System.Windows.Forms.Button();
      this.crossHair2 = new System.Windows.Forms.Button();
      this.crossHair3 = new System.Windows.Forms.Button();
      this.exit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cfgButton
      // 
      this.cfgButton.Location = new System.Drawing.Point(150, 18);
      this.cfgButton.Name = "cfgButton";
      this.cfgButton.Size = new System.Drawing.Size(207, 72);
      this.cfgButton.TabIndex = 0;
      this.cfgButton.Text = "Config";
      this.cfgButton.UseVisualStyleBackColor = true;
      this.cfgButton.Click += new System.EventHandler(this.cfgButton_Click);
      // 
      // crossHair1
      // 
      this.crossHair1.Location = new System.Drawing.Point(150, 96);
      this.crossHair1.Name = "crossHair1";
      this.crossHair1.Size = new System.Drawing.Size(207, 72);
      this.crossHair1.TabIndex = 1;
      this.crossHair1.Text = "Crosshair #1";
      this.crossHair1.UseVisualStyleBackColor = true;
      this.crossHair1.Click += new System.EventHandler(this.crossHair1_Click);
      // 
      // crossHair2
      // 
      this.crossHair2.Location = new System.Drawing.Point(150, 174);
      this.crossHair2.Name = "crossHair2";
      this.crossHair2.Size = new System.Drawing.Size(207, 72);
      this.crossHair2.TabIndex = 2;
      this.crossHair2.Text = "Crosshair #2";
      this.crossHair2.UseVisualStyleBackColor = true;
      this.crossHair2.Click += new System.EventHandler(this.crossHair2_Click);
      // 
      // crossHair3
      // 
      this.crossHair3.Location = new System.Drawing.Point(150, 252);
      this.crossHair3.Name = "crossHair3";
      this.crossHair3.Size = new System.Drawing.Size(207, 72);
      this.crossHair3.TabIndex = 3;
      this.crossHair3.Text = "Crosshair #3";
      this.crossHair3.UseVisualStyleBackColor = true;
      this.crossHair3.Click += new System.EventHandler(this.crossHair3_Click);
      // 
      // exit
      // 
      this.exit.Location = new System.Drawing.Point(150, 330);
      this.exit.Name = "exit";
      this.exit.Size = new System.Drawing.Size(207, 72);
      this.exit.TabIndex = 4;
      this.exit.Text = "Exit";
      this.exit.UseVisualStyleBackColor = true;
      this.exit.Click += new System.EventHandler(this.exit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 431);
      this.Controls.Add(this.exit);
      this.Controls.Add(this.crossHair3);
      this.Controls.Add(this.crossHair2);
      this.Controls.Add(this.crossHair1);
      this.Controls.Add(this.cfgButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cfgButton;
    private System.Windows.Forms.Button crossHair1;
    private System.Windows.Forms.Button crossHair2;
    private System.Windows.Forms.Button crossHair3;
    private System.Windows.Forms.Button exit;
  }
}

