namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("пто");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("системных проектов");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("сервисный");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("бухгалтерия");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("администратция");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("закупки");
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, -1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "пто";
            treeNode2.Name = "Узел1";
            treeNode2.Text = "системных проектов";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "сервисный";
            treeNode4.Name = "Узел3";
            treeNode4.Text = "бухгалтерия";
            treeNode5.Name = "Узел4";
            treeNode5.Text = "администратция";
            treeNode6.Name = "Узел5";
            treeNode6.Text = "закупки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(367, 238);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Соединиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Обмен сообщениями";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

