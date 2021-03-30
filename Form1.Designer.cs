
namespace ShaDeter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.create_new = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.open_draw_window = new System.Windows.Forms.ToolStripMenuItem();
            this.close_open_window = new System.Windows.Forms.ToolStripMenuItem();
            this.Инструмент = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tool = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.Инструмент.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.save,
            this.create_new});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "файл";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(180, 22);
            this.load.Text = "загрузить";
            // 
            // save
            // 
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "сохранить как";
            // 
            // create_new
            // 
            this.create_new.Name = "create_new";
            this.create_new.Size = new System.Drawing.Size(180, 22);
            this.create_new.Text = "создать новый";
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_draw_window,
            this.close_open_window});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(38, 20);
            this.View.Text = "вид";
            // 
            // open_draw_window
            // 
            this.open_draw_window.Name = "open_draw_window";
            this.open_draw_window.Size = new System.Drawing.Size(211, 22);
            this.open_draw_window.Text = "открыть окно рисования";
            // 
            // close_open_window
            // 
            this.close_open_window.Name = "close_open_window";
            this.close_open_window.Size = new System.Drawing.Size(211, 22);
            this.close_open_window.Text = "закрыть окно рисования";
            // 
            // Инструмент
            // 
            this.Инструмент.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tool});
            this.Инструмент.Location = new System.Drawing.Point(0, 428);
            this.Инструмент.Name = "Инструмент";
            this.Инструмент.Size = new System.Drawing.Size(801, 22);
            this.Инструмент.TabIndex = 1;
            this.Инструмент.Text = "statusStrip1";
            this.Инструмент.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tool
            // 
            this.tool.Name = "tool";
            this.tool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tool.Size = new System.Drawing.Size(72, 17);
            this.tool.Text = "инструмент";
            this.tool.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 404);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Инструмент);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Инструмент.ResumeLayout(false);
            this.Инструмент.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem create_new;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem open_draw_window;
        private System.Windows.Forms.ToolStripMenuItem close_open_window;
        private System.Windows.Forms.StatusStrip Инструмент;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tool;
        private System.Windows.Forms.Panel panel1;
    }
}

