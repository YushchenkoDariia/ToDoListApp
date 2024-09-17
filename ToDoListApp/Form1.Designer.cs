namespace ToDoListApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.markCompleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(21, 94);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(233, 22);
            this.taskTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(21, 138);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 16;
            this.taskListBox.Location = new System.Drawing.Point(420, 47);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(314, 372);
            this.taskListBox.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(147, 138);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // markCompleteButton
            // 
            this.markCompleteButton.BackColor = System.Drawing.Color.Moccasin;
            this.markCompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markCompleteButton.Location = new System.Drawing.Point(21, 188);
            this.markCompleteButton.Name = "markCompleteButton";
            this.markCompleteButton.Size = new System.Drawing.Size(233, 32);
            this.markCompleteButton.TabIndex = 4;
            this.markCompleteButton.Text = "Mark as done";
            this.markCompleteButton.UseVisualStyleBackColor = false;
            this.markCompleteButton.Click += new System.EventHandler(this.markCompleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the task:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markCompleteButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();
            // Add Button
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // Delete Button
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);

            // Mark Complete Button
            this.markCompleteButton.Click += new System.EventHandler(this.markCompleteButton_Click);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button markCompleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskTextBox;
    }
}

