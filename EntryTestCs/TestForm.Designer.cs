namespace EntryTestCs
{
    partial class TestForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MultiplicationTableView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WorkLabel = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnMmemory = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMminus = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.DispLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplicationTableView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.MultiplicationTableView);
            this.tabPage1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MultiplicationTable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CalculateButton.Location = new System.Drawing.Point(632, 7);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(110, 54);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MultiplicationTableView
            // 
            this.MultiplicationTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MultiplicationTableView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MultiplicationTableView.Location = new System.Drawing.Point(6, 6);
            this.MultiplicationTableView.MultiSelect = false;
            this.MultiplicationTableView.Name = "MultiplicationTableView";
            this.MultiplicationTableView.ReadOnly = true;
            this.MultiplicationTableView.RowTemplate.Height = 21;
            this.MultiplicationTableView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MultiplicationTableView.Size = new System.Drawing.Size(620, 458);
            this.MultiplicationTableView.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WorkLabel);
            this.tabPage2.Controls.Add(this.btnEqual);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnSub);
            this.tabPage2.Controls.Add(this.btnMultiple);
            this.tabPage2.Controls.Add(this.btnDivision);
            this.tabPage2.Controls.Add(this.btnDot);
            this.tabPage2.Controls.Add(this.btn3);
            this.tabPage2.Controls.Add(this.btn6);
            this.tabPage2.Controls.Add(this.btn9);
            this.tabPage2.Controls.Add(this.btnRoot);
            this.tabPage2.Controls.Add(this.btn0);
            this.tabPage2.Controls.Add(this.btn2);
            this.tabPage2.Controls.Add(this.btn5);
            this.tabPage2.Controls.Add(this.btn8);
            this.tabPage2.Controls.Add(this.btnSquare);
            this.tabPage2.Controls.Add(this.btnUndo);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnCE);
            this.tabPage2.Controls.Add(this.btnSign);
            this.tabPage2.Controls.Add(this.btn1);
            this.tabPage2.Controls.Add(this.btn4);
            this.tabPage2.Controls.Add(this.btn7);
            this.tabPage2.Controls.Add(this.btnInverse);
            this.tabPage2.Controls.Add(this.btnPercent);
            this.tabPage2.Controls.Add(this.btnMmemory);
            this.tabPage2.Controls.Add(this.btnMS);
            this.tabPage2.Controls.Add(this.btnMminus);
            this.tabPage2.Controls.Add(this.btnMplus);
            this.tabPage2.Controls.Add(this.btnMR);
            this.tabPage2.Controls.Add(this.btnMC);
            this.tabPage2.Controls.Add(this.DispLabel);
            this.tabPage2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Caliculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WorkLabel
            // 
            this.WorkLabel.BackColor = System.Drawing.Color.Silver;
            this.WorkLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WorkLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkLabel.Location = new System.Drawing.Point(29, 14);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new System.Drawing.Size(705, 33);
            this.WorkLabel.TabIndex = 63;
            this.WorkLabel.Text = "123+456";
            this.WorkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEqual.Location = new System.Drawing.Point(564, 456);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(170, 55);
            this.btnEqual.TabIndex = 62;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(564, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 55);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "＋";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSub.Location = new System.Drawing.Point(564, 334);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(170, 55);
            this.btnSub.TabIndex = 60;
            this.btnSub.Text = "－";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMultiple.Location = new System.Drawing.Point(564, 273);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(170, 55);
            this.btnMultiple.TabIndex = 59;
            this.btnMultiple.Text = "×";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDivision.Location = new System.Drawing.Point(564, 212);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(170, 55);
            this.btnDivision.TabIndex = 58;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDot.Location = new System.Drawing.Point(388, 456);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(170, 55);
            this.btnDot.TabIndex = 57;
            this.btnDot.Text = "．";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn3.Location = new System.Drawing.Point(388, 395);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(170, 55);
            this.btn3.TabIndex = 56;
            this.btn3.Text = "３";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn6.Location = new System.Drawing.Point(388, 334);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(170, 55);
            this.btn6.TabIndex = 55;
            this.btn6.Text = "６";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn9.Location = new System.Drawing.Point(388, 273);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(170, 55);
            this.btn9.TabIndex = 54;
            this.btn9.Text = "９";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRoot.Location = new System.Drawing.Point(388, 212);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(170, 55);
            this.btnRoot.TabIndex = 53;
            this.btnRoot.Text = "√x";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn0.Location = new System.Drawing.Point(209, 456);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(170, 55);
            this.btn0.TabIndex = 52;
            this.btn0.Text = "０";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn2.Location = new System.Drawing.Point(209, 395);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(170, 55);
            this.btn2.TabIndex = 51;
            this.btn2.Text = "２";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn5.Location = new System.Drawing.Point(209, 334);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(170, 55);
            this.btn5.TabIndex = 50;
            this.btn5.Text = "５";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn8.Location = new System.Drawing.Point(209, 273);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(170, 55);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "８";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSquare.Location = new System.Drawing.Point(209, 212);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(170, 55);
            this.btnSquare.TabIndex = 48;
            this.btnSquare.Text = "X2";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Yellow;
            this.btnUndo.Location = new System.Drawing.Point(565, 151);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(170, 55);
            this.btnUndo.TabIndex = 47;
            this.btnUndo.Text = "<-×";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(387, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 55);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCE.Location = new System.Drawing.Point(209, 151);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(170, 55);
            this.btnCE.TabIndex = 45;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSign.Location = new System.Drawing.Point(31, 456);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(170, 55);
            this.btnSign.TabIndex = 44;
            this.btnSign.Text = "＋／－";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn1.Location = new System.Drawing.Point(31, 395);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(170, 55);
            this.btn1.TabIndex = 43;
            this.btn1.Text = "１";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn4.Location = new System.Drawing.Point(31, 334);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(170, 55);
            this.btn4.TabIndex = 42;
            this.btn4.Text = "４";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn7.Location = new System.Drawing.Point(31, 273);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(170, 55);
            this.btn7.TabIndex = 41;
            this.btn7.Text = "７";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInverse.Location = new System.Drawing.Point(31, 212);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(170, 55);
            this.btnInverse.TabIndex = 40;
            this.btnInverse.Text = "１／Ｘ";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPercent.Location = new System.Drawing.Point(31, 151);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(170, 55);
            this.btnPercent.TabIndex = 39;
            this.btnPercent.Text = "％";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnMmemory
            // 
            this.btnMmemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMmemory.Location = new System.Drawing.Point(626, 107);
            this.btnMmemory.Name = "btnMmemory";
            this.btnMmemory.Size = new System.Drawing.Size(109, 38);
            this.btnMmemory.TabIndex = 38;
            this.btnMmemory.Text = "Mmemory";
            this.btnMmemory.UseVisualStyleBackColor = false;
            this.btnMmemory.Click += new System.EventHandler(this.btnMmemory_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMS.Location = new System.Drawing.Point(507, 107);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(109, 38);
            this.btnMS.TabIndex = 37;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMminus
            // 
            this.btnMminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMminus.Location = new System.Drawing.Point(388, 107);
            this.btnMminus.Name = "btnMminus";
            this.btnMminus.Size = new System.Drawing.Size(109, 38);
            this.btnMminus.TabIndex = 36;
            this.btnMminus.Text = "M-";
            this.btnMminus.UseVisualStyleBackColor = false;
            this.btnMminus.Click += new System.EventHandler(this.btnMminus_Click);
            // 
            // btnMplus
            // 
            this.btnMplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMplus.Location = new System.Drawing.Point(269, 107);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(109, 38);
            this.btnMplus.TabIndex = 35;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = false;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMR.Location = new System.Drawing.Point(150, 107);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(109, 38);
            this.btnMR.TabIndex = 34;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMC.Location = new System.Drawing.Point(31, 107);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(109, 38);
            this.btnMC.TabIndex = 33;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // DispLabel
            // 
            this.DispLabel.BackColor = System.Drawing.Color.White;
            this.DispLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DispLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispLabel.Location = new System.Drawing.Point(30, 47);
            this.DispLabel.Name = "DispLabel";
            this.DispLabel.Size = new System.Drawing.Size(705, 57);
            this.DispLabel.TabIndex = 32;
            this.DispLabel.Text = "1234567890";
            this.DispLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EntryTest";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MultiplicationTableView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridView MultiplicationTableView;
        private System.Windows.Forms.Label WorkLabel;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnMmemory;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMminus;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Label DispLabel;
    }
}

