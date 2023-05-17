namespace FoodMoodApp
{
    partial class FoodMoodForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.cbMood = new System.Windows.Forms.ComboBox();
            this.btCheckMood = new System.Windows.Forms.Button();
            this.dtFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.recommendationLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ratingListButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.dtMood = new System.Windows.Forms.DataGridView();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.lbRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtFood)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMood)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(34, 86);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Food Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Of Food:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "The Mood:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(132, 133);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 4;
            // 
            // cbMood
            // 
            this.cbMood.FormattingEnabled = true;
            this.cbMood.Items.AddRange(new object[] {
            "Happy",
            "Sad",
            "Tired",
            "Stressed",
            "Other"});
            this.cbMood.Location = new System.Drawing.Point(132, 268);
            this.cbMood.Name = "cbMood";
            this.cbMood.Size = new System.Drawing.Size(121, 23);
            this.cbMood.TabIndex = 5;
            // 
            // btCheckMood
            // 
            this.btCheckMood.Location = new System.Drawing.Point(123, 393);
            this.btCheckMood.Name = "btCheckMood";
            this.btCheckMood.Size = new System.Drawing.Size(145, 23);
            this.btCheckMood.TabIndex = 6;
            this.btCheckMood.Text = "Check Mood";
            this.btCheckMood.UseVisualStyleBackColor = true;
            this.btCheckMood.Click += new System.EventHandler(this.btCheckMood_Click);
            // 
            // dtFood
            // 
            this.dtFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFood.Location = new System.Drawing.Point(448, 51);
            this.dtFood.Name = "dtFood";
            this.dtFood.RowHeadersWidth = 51;
            this.dtFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFood.Size = new System.Drawing.Size(554, 324);
            this.dtFood.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "The Time:";
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(132, 175);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(100, 22);
            this.txtPor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "The Portion Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.recommendationLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dtFood);
            this.groupBox1.Controls.Add(this.txtPor);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.cbMood);
            this.groupBox1.Controls.Add(this.btCheckMood);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 544);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Food Advice:";
            // 
            // recommendationLabel
            // 
            this.recommendationLabel.AutoSize = true;
            this.recommendationLabel.Location = new System.Drawing.Point(120, 321);
            this.recommendationLabel.Name = "recommendationLabel";
            this.recommendationLabel.Size = new System.Drawing.Size(0, 15);
            this.recommendationLabel.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 573);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "The Food Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "The Mood Rating";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ratingListButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRate);
            this.groupBox2.Controls.Add(this.dtMood);
            this.groupBox2.Controls.Add(this.cbRate);
            this.groupBox2.Controls.Add(this.lbRank);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 538);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // ratingListButton
            // 
            this.ratingListButton.Location = new System.Drawing.Point(114, 306);
            this.ratingListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ratingListButton.Name = "ratingListButton";
            this.ratingListButton.Size = new System.Drawing.Size(145, 24);
            this.ratingListButton.TabIndex = 21;
            this.ratingListButton.Text = "Rating List";
            this.ratingListButton.UseVisualStyleBackColor = true;
            this.ratingListButton.Click += new System.EventHandler(this.ratingListButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "(10 : Highest - 1: Lowest)";
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(114, 268);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(145, 23);
            this.btnRate.TabIndex = 18;
            this.btnRate.Text = "Rate Food";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // dtMood
            // 
            this.dtMood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMood.Location = new System.Drawing.Point(478, 59);
            this.dtMood.Name = "dtMood";
            this.dtMood.ReadOnly = true;
            this.dtMood.RowHeadersWidth = 51;
            this.dtMood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMood.Size = new System.Drawing.Size(405, 324);
            this.dtMood.TabIndex = 8;
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRate.Location = new System.Drawing.Point(192, 133);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(121, 27);
            this.cbRate.TabIndex = 19;
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Location = new System.Drawing.Point(0, 136);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(179, 19);
            this.lbRank.TabIndex = 16;
            this.lbRank.Text = "Rate The Food After Eating:";
            // 
            // FoodMoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "FoodMoodForm";
            this.Text = "FoodMoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtFood)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.ComboBox cbMood;
        private System.Windows.Forms.Button btCheckMood;
        private System.Windows.Forms.DataGridView dtFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label recommendationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.DataGridView dtMood;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ratingListButton;
    }
}

