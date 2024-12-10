namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripArquivo = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            formartarToolStripMenuItem = new ToolStripMenuItem();
            fonteToolStripMenuItem = new ToolStripMenuItem();
            aRIAL12ToolStripMenuItem = new ToolStripMenuItem();
            bOLD12ToolStripMenuItem = new ToolStripMenuItem();
            nEGRITO14ToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStripArquivo.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripArquivo
            // 
            menuStripArquivo.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formartarToolStripMenuItem, ajudaToolStripMenuItem });
            menuStripArquivo.Location = new Point(0, 0);
            menuStripArquivo.Name = "menuStripArquivo";
            menuStripArquivo.Size = new Size(578, 24);
            menuStripArquivo.TabIndex = 0;
            menuStripArquivo.Text = "Arquivo";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(109, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(109, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // formartarToolStripMenuItem
            // 
            formartarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fonteToolStripMenuItem, aRIAL12ToolStripMenuItem, bOLD12ToolStripMenuItem, nEGRITO14ToolStripMenuItem });
            formartarToolStripMenuItem.Name = "formartarToolStripMenuItem";
            formartarToolStripMenuItem.Size = new Size(71, 20);
            formartarToolStripMenuItem.Text = "Formartar";
            // 
            // fonteToolStripMenuItem
            // 
            fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            fonteToolStripMenuItem.Size = new Size(129, 22);
            fonteToolStripMenuItem.Text = "Fonte";
            fonteToolStripMenuItem.Click += fonteToolStripMenuItem_Click;
            // 
            // aRIAL12ToolStripMenuItem
            // 
            aRIAL12ToolStripMenuItem.Name = "aRIAL12ToolStripMenuItem";
            aRIAL12ToolStripMenuItem.Size = new Size(129, 22);
            aRIAL12ToolStripMenuItem.Text = "Arial 12";
            aRIAL12ToolStripMenuItem.Click += aRIAL12ToolStripMenuItem_Click;
            // 
            // bOLD12ToolStripMenuItem
            // 
            bOLD12ToolStripMenuItem.Name = "bOLD12ToolStripMenuItem";
            bOLD12ToolStripMenuItem.Size = new Size(129, 22);
            bOLD12ToolStripMenuItem.Text = "Bold 12";
            bOLD12ToolStripMenuItem.Click += bOLD12ToolStripMenuItem_Click;
            // 
            // nEGRITO14ToolStripMenuItem
            // 
            nEGRITO14ToolStripMenuItem.Name = "nEGRITO14ToolStripMenuItem";
            nEGRITO14ToolStripMenuItem.Size = new Size(129, 22);
            nEGRITO14ToolStripMenuItem.Text = "Negrito 14";
            nEGRITO14ToolStripMenuItem.Click += nEGRITO14ToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(578, 286);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 310);
            Controls.Add(richTextBox1);
            Controls.Add(menuStripArquivo);
            MainMenuStrip = menuStripArquivo;
            Name = "Form1";
            Text = "Form1";
            menuStripArquivo.ResumeLayout(false);
            menuStripArquivo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripArquivo;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem formartarToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem aRIAL12ToolStripMenuItem;
        private ToolStripMenuItem bOLD12ToolStripMenuItem;
        private ToolStripMenuItem nEGRITO14ToolStripMenuItem;
    }
}