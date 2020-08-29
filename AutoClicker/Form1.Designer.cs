namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Record = new System.Windows.Forms.Button();
            this.btn_Launch = new System.Windows.Forms.Button();
            this.Lb_PosX = new System.Windows.Forms.Label();
            this.Lb_PosY = new System.Windows.Forms.Label();
            this.Val_PosX = new System.Windows.Forms.Label();
            this.Val_PosY = new System.Windows.Forms.Label();
            this.Lbl_stopped = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lv_Actions = new System.Windows.Forms.ListView();
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pos_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pos_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_Record
            // 
            this.btn_Record.Location = new System.Drawing.Point(251, 415);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(286, 23);
            this.btn_Record.TabIndex = 0;
            this.btn_Record.Text = "Record";
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // btn_Launch
            // 
            this.btn_Launch.Location = new System.Drawing.Point(546, 415);
            this.btn_Launch.Name = "btn_Launch";
            this.btn_Launch.Size = new System.Drawing.Size(242, 23);
            this.btn_Launch.TabIndex = 1;
            this.btn_Launch.Text = "Launch";
            this.btn_Launch.UseVisualStyleBackColor = true;
            this.btn_Launch.Click += new System.EventHandler(this.btn_Launch_Click);
            // 
            // Lb_PosX
            // 
            this.Lb_PosX.AutoSize = true;
            this.Lb_PosX.Location = new System.Drawing.Point(248, 12);
            this.Lb_PosX.Name = "Lb_PosX";
            this.Lb_PosX.Size = new System.Drawing.Size(59, 13);
            this.Lb_PosX.TabIndex = 2;
            this.Lb_PosX.Text = "position X :";
            // 
            // Lb_PosY
            // 
            this.Lb_PosY.AutoSize = true;
            this.Lb_PosY.Location = new System.Drawing.Point(426, 12);
            this.Lb_PosY.Name = "Lb_PosY";
            this.Lb_PosY.Size = new System.Drawing.Size(59, 13);
            this.Lb_PosY.TabIndex = 3;
            this.Lb_PosY.Text = "position Y :";
            // 
            // Val_PosX
            // 
            this.Val_PosX.AutoSize = true;
            this.Val_PosX.Location = new System.Drawing.Point(308, 12);
            this.Val_PosX.Name = "Val_PosX";
            this.Val_PosX.Size = new System.Drawing.Size(28, 13);
            this.Val_PosX.TabIndex = 4;
            this.Val_PosX.Text = "valX";
            // 
            // Val_PosY
            // 
            this.Val_PosY.AutoSize = true;
            this.Val_PosY.Location = new System.Drawing.Point(491, 12);
            this.Val_PosY.Name = "Val_PosY";
            this.Val_PosY.Size = new System.Drawing.Size(28, 13);
            this.Val_PosY.TabIndex = 5;
            this.Val_PosY.Text = "valY";
            // 
            // Lbl_stopped
            // 
            this.Lbl_stopped.AutoSize = true;
            this.Lbl_stopped.ForeColor = System.Drawing.Color.Red;
            this.Lbl_stopped.Location = new System.Drawing.Point(490, 202);
            this.Lbl_stopped.Name = "Lbl_stopped";
            this.Lbl_stopped.Size = new System.Drawing.Size(47, 13);
            this.Lbl_stopped.TabIndex = 6;
            this.Lbl_stopped.Text = "Stopped";
            this.Lbl_stopped.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lv_Actions
            // 
            this.Lv_Actions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Action,
            this.Pos_X,
            this.Pos_Y});
            this.Lv_Actions.FullRowSelect = true;
            this.Lv_Actions.GridLines = true;
            this.Lv_Actions.HideSelection = false;
            this.Lv_Actions.Location = new System.Drawing.Point(12, 12);
            this.Lv_Actions.Name = "Lv_Actions";
            this.Lv_Actions.Size = new System.Drawing.Size(213, 426);
            this.Lv_Actions.TabIndex = 7;
            this.Lv_Actions.UseCompatibleStateImageBehavior = false;
            this.Lv_Actions.View = System.Windows.Forms.View.Details;
            // 
            // Action
            // 
            this.Action.Text = "Action";
            this.Action.Width = 100;
            // 
            // Pos_X
            // 
            this.Pos_X.Text = "Pos X";
            // 
            // Pos_Y
            // 
            this.Pos_Y.Text = "Pos Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lv_Actions);
            this.Controls.Add(this.Lbl_stopped);
            this.Controls.Add(this.Val_PosY);
            this.Controls.Add(this.Val_PosX);
            this.Controls.Add(this.Lb_PosY);
            this.Controls.Add(this.Lb_PosX);
            this.Controls.Add(this.btn_Launch);
            this.Controls.Add(this.btn_Record);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btn_Launch;
        private System.Windows.Forms.Label Lb_PosX;
        private System.Windows.Forms.Label Lb_PosY;
        private System.Windows.Forms.Label Val_PosX;
        private System.Windows.Forms.Label Val_PosY;
        private System.Windows.Forms.Label Lbl_stopped;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView Lv_Actions;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.ColumnHeader Pos_X;
        private System.Windows.Forms.ColumnHeader Pos_Y;
    }
}

