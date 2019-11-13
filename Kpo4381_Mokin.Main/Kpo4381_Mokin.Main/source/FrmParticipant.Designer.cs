namespace Kpo4381_Mokin.Main
{
    partial class FrmParticipant
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
            this.tb_place = new System.Windows.Forms.TextBox();
            this.tb_number_of_balls = new System.Windows.Forms.TextBox();
            this.tb_team_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_place
            // 
            this.tb_place.Location = new System.Drawing.Point(161, 92);
            this.tb_place.Name = "tb_place";
            this.tb_place.Size = new System.Drawing.Size(100, 20);
            this.tb_place.TabIndex = 11;
            // 
            // tb_number_of_balls
            // 
            this.tb_number_of_balls.Location = new System.Drawing.Point(161, 61);
            this.tb_number_of_balls.Name = "tb_number_of_balls";
            this.tb_number_of_balls.Size = new System.Drawing.Size(100, 20);
            this.tb_number_of_balls.TabIndex = 10;
            // 
            // tb_team_name
            // 
            this.tb_team_name.Location = new System.Drawing.Point(161, 29);
            this.tb_team_name.Name = "tb_team_name";
            this.tb_team_name.Size = new System.Drawing.Size(100, 20);
            this.tb_team_name.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Место в итоге";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во баллов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Команда";
            // 
            // FrmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.tb_place);
            this.Controls.Add(this.tb_number_of_balls);
            this.Controls.Add(this.tb_team_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmParticipant";
            this.Text = "Участник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_place;
        private System.Windows.Forms.TextBox tb_number_of_balls;
        private System.Windows.Forms.TextBox tb_team_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}