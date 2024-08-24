namespace Two_Dice_Pig
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            richTextBox_instruction = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox_instruction
            // 
            richTextBox_instruction.Enabled = false;
            richTextBox_instruction.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_instruction.Location = new Point(12, 41);
            richTextBox_instruction.Name = "richTextBox_instruction";
            richTextBox_instruction.Size = new Size(776, 389);
            richTextBox_instruction.TabIndex = 0;
            richTextBox_instruction.Text = resources.GetString("richTextBox_instruction.Text");
            // 
            // Instruction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_instruction);
            Name = "Instruction";
            Text = "Instruction";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_instruction;
    }
}