
namespace Exodus_1._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.execute = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.Button();
            this.textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.scriptbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a_SimplerDnm", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exodus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 30);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("a_SimplerDnm", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(801, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "v 0.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // execute
            // 
            this.execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.execute.FlatAppearance.BorderSize = 0;
            this.execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.execute.ForeColor = System.Drawing.Color.White;
            this.execute.Location = new System.Drawing.Point(12, 36);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(91, 30);
            this.execute.TabIndex = 5;
            this.execute.Text = "Execute";
            this.execute.UseVisualStyleBackColor = false;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(12, 72);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 30);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // savefile
            // 
            this.savefile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.savefile.FlatAppearance.BorderSize = 0;
            this.savefile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savefile.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savefile.ForeColor = System.Drawing.Color.White;
            this.savefile.Location = new System.Drawing.Point(12, 108);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(91, 30);
            this.savefile.TabIndex = 7;
            this.savefile.Text = "Save File";
            this.savefile.UseVisualStyleBackColor = false;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // openfile
            // 
            this.openfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.openfile.FlatAppearance.BorderSize = 0;
            this.openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfile.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openfile.ForeColor = System.Drawing.Color.White;
            this.openfile.Location = new System.Drawing.Point(12, 144);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(91, 30);
            this.openfile.TabIndex = 8;
            this.openfile.Text = "Open File";
            this.openfile.UseVisualStyleBackColor = false;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // attach
            // 
            this.attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.attach.FlatAppearance.BorderSize = 0;
            this.attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attach.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attach.ForeColor = System.Drawing.Color.White;
            this.attach.Location = new System.Drawing.Point(13, 273);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(90, 26);
            this.attach.TabIndex = 9;
            this.attach.Text = "Attach";
            this.attach.UseVisualStyleBackColor = false;
            this.attach.Click += new System.EventHandler(this.button7_Click);
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.AutoCompleteBrackets = true;
            this.textbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.textbox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.textbox.AutoScrollMinSize = new System.Drawing.Size(419, 70);
            this.textbox.BackBrush = null;
            this.textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textbox.BookmarkColor = System.Drawing.Color.Red;
            this.textbox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.textbox.CaretColor = System.Drawing.Color.Coral;
            this.textbox.CharHeight = 14;
            this.textbox.CharWidth = 8;
            this.textbox.CommentPrefix = "--";
            this.textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textbox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.textbox.ForeColor = System.Drawing.Color.White;
            this.textbox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textbox.IsReplaceMode = false;
            this.textbox.Language = FastColoredTextBoxNS.Language.Lua;
            this.textbox.LeftBracket = '(';
            this.textbox.LeftBracket2 = '{';
            this.textbox.LineNumberColor = System.Drawing.Color.Coral;
            this.textbox.Location = new System.Drawing.Point(109, 36);
            this.textbox.Name = "textbox";
            this.textbox.Paddings = new System.Windows.Forms.Padding(0);
            this.textbox.RightBracket = ')';
            this.textbox.RightBracket2 = '}';
            this.textbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("textbox.ServiceColors")));
            this.textbox.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.textbox.Size = new System.Drawing.Size(615, 263);
            this.textbox.TabIndex = 10;
            this.textbox.Text = "--[[\r\nExodus v0.1\r\nby Temka\r\nGithub: https://github.com/Exload1/Exodus-Project\r\n]" +
    "]--";
            this.textbox.Zoom = 100;
            this.textbox.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // scriptbox
            // 
            this.scriptbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.scriptbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scriptbox.ForeColor = System.Drawing.Color.White;
            this.scriptbox.FormattingEnabled = true;
            this.scriptbox.Location = new System.Drawing.Point(732, 72);
            this.scriptbox.Name = "scriptbox";
            this.scriptbox.Size = new System.Drawing.Size(144, 195);
            this.scriptbox.TabIndex = 11;
            this.scriptbox.SelectedIndexChanged += new System.EventHandler(this.scriptbox_SelectedIndexChanged);
            this.scriptbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.scriptbox_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(732, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Script Hub";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("a_SimplerDnm", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(732, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(885, 310);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scriptbox);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(901, 349);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exodus Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button attach;
        private FastColoredTextBoxNS.FastColoredTextBox textbox;
        private System.Windows.Forms.ListBox scriptbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

