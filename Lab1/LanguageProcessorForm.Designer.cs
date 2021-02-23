﻿namespace Lab1
{
    partial class LanguageProcessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageProcessorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelp = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile,
            this.StripMenuEdit,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuFile
            // 
            this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuCreate,
            this.StripMenuOpen,
            this.StripMenuSave,
            this.StripMenuSaveAs,
            this.StripMenuExit});
            this.StripMenuFile.Name = "StripMenuFile";
            this.StripMenuFile.Size = new System.Drawing.Size(48, 20);
            this.StripMenuFile.Text = "Файл";
            // 
            // StripMenuCreate
            // 
            this.StripMenuCreate.Name = "StripMenuCreate";
            this.StripMenuCreate.Size = new System.Drawing.Size(153, 22);
            this.StripMenuCreate.Text = "Создать";
            this.StripMenuCreate.Click += new System.EventHandler(this.StripMenuCreate_Click);
            // 
            // StripMenuOpen
            // 
            this.StripMenuOpen.Name = "StripMenuOpen";
            this.StripMenuOpen.Size = new System.Drawing.Size(153, 22);
            this.StripMenuOpen.Text = "Открыть";
            this.StripMenuOpen.Click += new System.EventHandler(this.StripMenuOpen_Click);
            // 
            // StripMenuSave
            // 
            this.StripMenuSave.Name = "StripMenuSave";
            this.StripMenuSave.Size = new System.Drawing.Size(153, 22);
            this.StripMenuSave.Text = "Сохранить";
            this.StripMenuSave.Click += new System.EventHandler(this.StripMenuSave_Click);
            // 
            // StripMenuSaveAs
            // 
            this.StripMenuSaveAs.Name = "StripMenuSaveAs";
            this.StripMenuSaveAs.Size = new System.Drawing.Size(153, 22);
            this.StripMenuSaveAs.Text = "Сохранить как";
            this.StripMenuSaveAs.Click += new System.EventHandler(this.StripMenuSaveAs_Click);
            // 
            // StripMenuExit
            // 
            this.StripMenuExit.Name = "StripMenuExit";
            this.StripMenuExit.Size = new System.Drawing.Size(153, 22);
            this.StripMenuExit.Text = "Выход";
            this.StripMenuExit.Click += new System.EventHandler(this.StripMenuExit_Click);
            // 
            // StripMenuEdit
            // 
            this.StripMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuUndo,
            this.StripMenuRedo,
            this.StripMenuCut,
            this.StripMenuCopy,
            this.StripMenuPaste,
            this.StripMenuDelete,
            this.StripMenuSelectAll});
            this.StripMenuEdit.Name = "StripMenuEdit";
            this.StripMenuEdit.Size = new System.Drawing.Size(59, 20);
            this.StripMenuEdit.Text = "Правка";
            // 
            // StripMenuUndo
            // 
            this.StripMenuUndo.Name = "StripMenuUndo";
            this.StripMenuUndo.Size = new System.Drawing.Size(148, 22);
            this.StripMenuUndo.Text = "Отменить";
            this.StripMenuUndo.Click += new System.EventHandler(this.StripMenuUndo_Click);
            // 
            // StripMenuRedo
            // 
            this.StripMenuRedo.Name = "StripMenuRedo";
            this.StripMenuRedo.Size = new System.Drawing.Size(148, 22);
            this.StripMenuRedo.Text = "Повторить";
            this.StripMenuRedo.Click += new System.EventHandler(this.StripMenuRedo_Click);
            // 
            // StripMenuCut
            // 
            this.StripMenuCut.Name = "StripMenuCut";
            this.StripMenuCut.Size = new System.Drawing.Size(148, 22);
            this.StripMenuCut.Text = "Вырезать";
            this.StripMenuCut.Click += new System.EventHandler(this.StripMenuCut_Click);
            // 
            // StripMenuCopy
            // 
            this.StripMenuCopy.Name = "StripMenuCopy";
            this.StripMenuCopy.Size = new System.Drawing.Size(148, 22);
            this.StripMenuCopy.Text = "Копировать";
            this.StripMenuCopy.Click += new System.EventHandler(this.StripMenuCopy_Click);
            // 
            // StripMenuPaste
            // 
            this.StripMenuPaste.Name = "StripMenuPaste";
            this.StripMenuPaste.Size = new System.Drawing.Size(148, 22);
            this.StripMenuPaste.Text = "Вставить";
            this.StripMenuPaste.Click += new System.EventHandler(this.StripMenuPaste_Click);
            // 
            // StripMenuDelete
            // 
            this.StripMenuDelete.Name = "StripMenuDelete";
            this.StripMenuDelete.Size = new System.Drawing.Size(148, 22);
            this.StripMenuDelete.Text = "Удалить";
            this.StripMenuDelete.Click += new System.EventHandler(this.StripMenuDelete_Click);
            // 
            // StripMenuSelectAll
            // 
            this.StripMenuSelectAll.Name = "StripMenuSelectAll";
            this.StripMenuSelectAll.Size = new System.Drawing.Size(148, 22);
            this.StripMenuSelectAll.Text = "Выделить все";
            this.StripMenuSelectAll.Click += new System.EventHandler(this.StripMenuSelectAll_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            this.классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            this.классификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            // 
            // диагностикаИНейтрализацияОшибокToolStripMenuItem
            // 
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Name = "диагностикаИНейтрализацияОшибокToolStripMenuItem";
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.пускToolStripMenuItem.Text = "Пуск";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuHelp,
            this.StripMenuAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(156, 22);
            this.StripMenuHelp.Text = "Вызов справки";
            this.StripMenuHelp.Click += new System.EventHandler(this.StripMenuHelp_Click);
            // 
            // StripMenuAbout
            // 
            this.StripMenuAbout.Name = "StripMenuAbout";
            this.StripMenuAbout.Size = new System.Drawing.Size(156, 22);
            this.StripMenuAbout.Text = "О программе";
            this.StripMenuAbout.Click += new System.EventHandler(this.StripMenuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreate,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripCut,
            this.toolStripSeparator2,
            this.toolStripPlay,
            this.toolStripSeparator3,
            this.toolStripHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripCreate
            // 
            this.toolStripCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCreate.Image")));
            this.toolStripCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCreate.Name = "toolStripCreate";
            this.toolStripCreate.Size = new System.Drawing.Size(28, 28);
            this.toolStripCreate.Text = "Create";
            this.toolStripCreate.Click += new System.EventHandler(this.toolStripCreate_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(28, 28);
            this.toolStripOpen.Text = "Open";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(28, 28);
            this.toolStripSave.Text = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(28, 28);
            this.toolStripUndo.Text = "Undo";
            this.toolStripUndo.Click += new System.EventHandler(this.toolStripUndo_Click);
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(28, 28);
            this.toolStripRedo.Text = "Redo";
            this.toolStripRedo.Click += new System.EventHandler(this.toolStripRedo_Click);
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopy.Image")));
            this.toolStripCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(28, 28);
            this.toolStripCopy.Text = "Copy";
            this.toolStripCopy.Click += new System.EventHandler(this.toolStripCopy_Click);
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaste.Image")));
            this.toolStripPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(28, 28);
            this.toolStripPaste.Text = "Paste";
            this.toolStripPaste.Click += new System.EventHandler(this.toolStripPaste_Click);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCut.Image")));
            this.toolStripCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(28, 28);
            this.toolStripCut.Text = "Cut";
            this.toolStripCut.Click += new System.EventHandler(this.toolStripCut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripPlay
            // 
            this.toolStripPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlay.Image")));
            this.toolStripPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlay.Name = "toolStripPlay";
            this.toolStripPlay.Size = new System.Drawing.Size(28, 28);
            this.toolStripPlay.Text = "Play";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelp.Image")));
            this.toolStripHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(28, 28);
            this.toolStripHelp.Text = "Help";
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 192);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 267);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(775, 160);
            this.textBox2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripSeparator4,
            this.StatusStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 431);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Value = 100;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // StatusStripLabel1
            // 
            this.StatusStripLabel1.Name = "StatusStripLabel1";
            this.StatusStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.StatusStripLabel1.Text = "Все работает";
            // 
            // LanguageProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LanguageProcessorForm";
            this.Text = "Language Processor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem StripMenuCreate;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuUndo;
        private System.Windows.Forms.ToolStripMenuItem StripMenuRedo;
        private System.Windows.Forms.ToolStripMenuItem StripMenuCut;
        private System.Windows.Forms.ToolStripMenuItem StripMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem StripMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem StripMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИНейтрализацияОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripCreate;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel StatusStripLabel1;
    }
}

