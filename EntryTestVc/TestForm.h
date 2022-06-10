#pragma once


namespace EntryTestVc {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// TestForm の概要
	///
	/// 警告: このクラスの名前を変更する場合、このクラスが依存するすべての .resx ファイルに関連付けられた
	///          マネージ リソース コンパイラ ツールに対して 'Resource File Name' プロパティを
	///          変更する必要があります。この変更を行わないと、
	///          デザイナと、このフォームに関連付けられたローカライズ済みリソースとが、
	///          正しく相互に利用できなくなります。
	/// </summary>
	public ref class TestForm : public System::Windows::Forms::Form
	{
	public:
		TestForm(void);

	protected:
		~TestForm();

	private: System::Windows::Forms::TabControl^  tabControl1;
	protected: 
	private: System::Windows::Forms::TabPage^  tabPage1;
	private: System::Windows::Forms::TabPage^  tabPage2;
	private: System::Windows::Forms::DataGridView^  MultiplicationTableView;
	private: System::Windows::Forms::Button^  CalculateButton;
	private: System::Windows::Forms::Button^  btnMC;

	private: System::Windows::Forms::Label^  DispLabel;
	private: System::Windows::Forms::Button^  btnUndo;
	private: System::Windows::Forms::Button^  btnClear;



	private: System::Windows::Forms::Button^  btnCE;
	private: System::Windows::Forms::Button^  btnSign;



	private: System::Windows::Forms::Button^  btn1;

	private: System::Windows::Forms::Button^  btn4;

	private: System::Windows::Forms::Button^  btn7;

	private: System::Windows::Forms::Button^  btnInverse;

	private: System::Windows::Forms::Button^  btnPercent;

	private: System::Windows::Forms::Button^  btnMmemory;


	private: System::Windows::Forms::Button^  btnMS;

	private: System::Windows::Forms::Button^  btnMminus;
	private: System::Windows::Forms::Button^  btnMplus;




	private: System::Windows::Forms::Button^  btnMR;
	private: System::Windows::Forms::Button^  btnEqual;


	private: System::Windows::Forms::Button^  btnAdd;

	private: System::Windows::Forms::Button^  btnSub;

	private: System::Windows::Forms::Button^  btnMultiple;

	private: System::Windows::Forms::Button^  btnDivision;
	private: System::Windows::Forms::Button^  btnDot;


	private: System::Windows::Forms::Button^  btn3;

	private: System::Windows::Forms::Button^  btn6;

	private: System::Windows::Forms::Button^  btn9;

	private: System::Windows::Forms::Button^  btnRoot;
	private: System::Windows::Forms::Button^  btn0;


	private: System::Windows::Forms::Button^  btn2;

	private: System::Windows::Forms::Button^  btn5;

	private: System::Windows::Forms::Button^  btn8;

	private: System::Windows::Forms::Button^  btnSquare;
	private: System::Windows::Forms::Label^  WorkLabel;






	private:
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		void InitializeComponent(void)
		{
			this->tabControl1 = (gcnew System::Windows::Forms::TabControl());
			this->tabPage1 = (gcnew System::Windows::Forms::TabPage());
			this->CalculateButton = (gcnew System::Windows::Forms::Button());
			this->MultiplicationTableView = (gcnew System::Windows::Forms::DataGridView());
			this->tabPage2 = (gcnew System::Windows::Forms::TabPage());
			this->WorkLabel = (gcnew System::Windows::Forms::Label());
			this->btnEqual = (gcnew System::Windows::Forms::Button());
			this->btnAdd = (gcnew System::Windows::Forms::Button());
			this->btnSub = (gcnew System::Windows::Forms::Button());
			this->btnMultiple = (gcnew System::Windows::Forms::Button());
			this->btnDivision = (gcnew System::Windows::Forms::Button());
			this->btnDot = (gcnew System::Windows::Forms::Button());
			this->btn3 = (gcnew System::Windows::Forms::Button());
			this->btn6 = (gcnew System::Windows::Forms::Button());
			this->btn9 = (gcnew System::Windows::Forms::Button());
			this->btnRoot = (gcnew System::Windows::Forms::Button());
			this->btn0 = (gcnew System::Windows::Forms::Button());
			this->btn2 = (gcnew System::Windows::Forms::Button());
			this->btn5 = (gcnew System::Windows::Forms::Button());
			this->btn8 = (gcnew System::Windows::Forms::Button());
			this->btnSquare = (gcnew System::Windows::Forms::Button());
			this->btnUndo = (gcnew System::Windows::Forms::Button());
			this->btnClear = (gcnew System::Windows::Forms::Button());
			this->btnCE = (gcnew System::Windows::Forms::Button());
			this->btnSign = (gcnew System::Windows::Forms::Button());
			this->btn1 = (gcnew System::Windows::Forms::Button());
			this->btn4 = (gcnew System::Windows::Forms::Button());
			this->btn7 = (gcnew System::Windows::Forms::Button());
			this->btnInverse = (gcnew System::Windows::Forms::Button());
			this->btnPercent = (gcnew System::Windows::Forms::Button());
			this->btnMmemory = (gcnew System::Windows::Forms::Button());
			this->btnMS = (gcnew System::Windows::Forms::Button());
			this->btnMminus = (gcnew System::Windows::Forms::Button());
			this->btnMplus = (gcnew System::Windows::Forms::Button());
			this->btnMR = (gcnew System::Windows::Forms::Button());
			this->btnMC = (gcnew System::Windows::Forms::Button());
			this->DispLabel = (gcnew System::Windows::Forms::Label());
			this->tabControl1->SuspendLayout();
			this->tabPage1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->MultiplicationTableView))->BeginInit();
			this->tabPage2->SuspendLayout();
			this->SuspendLayout();
			// 
			// tabControl1
			// 
			this->tabControl1->Alignment = System::Windows::Forms::TabAlignment::Bottom;
			this->tabControl1->Controls->Add(this->tabPage1);
			this->tabControl1->Controls->Add(this->tabPage2);
			this->tabControl1->Font = (gcnew System::Drawing::Font(L"MS UI Gothic", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(128)));
			this->tabControl1->Location = System::Drawing::Point(12, 12);
			this->tabControl1->Name = L"tabControl1";
			this->tabControl1->SelectedIndex = 0;
			this->tabControl1->Size = System::Drawing::Size(768, 549);
			this->tabControl1->TabIndex = 0;
			// 
			// tabPage1
			// 
			this->tabPage1->Controls->Add(this->CalculateButton);
			this->tabPage1->Controls->Add(this->MultiplicationTableView);
			this->tabPage1->Font = (gcnew System::Drawing::Font(L"MS UI Gothic", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(128)));
			this->tabPage1->Location = System::Drawing::Point(4, 4);
			this->tabPage1->Name = L"tabPage1";
			this->tabPage1->Padding = System::Windows::Forms::Padding(3);
			this->tabPage1->Size = System::Drawing::Size(760, 517);
			this->tabPage1->TabIndex = 0;
			this->tabPage1->Text = L"MultiplicationTable";
			this->tabPage1->UseVisualStyleBackColor = true;
			// 
			// CalculateButton
			// 
			this->CalculateButton->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)), 
				static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->CalculateButton->Location = System::Drawing::Point(632, 7);
			this->CalculateButton->Name = L"CalculateButton";
			this->CalculateButton->Size = System::Drawing::Size(110, 54);
			this->CalculateButton->TabIndex = 1;
			this->CalculateButton->Text = L"Calculate";
			this->CalculateButton->UseVisualStyleBackColor = false;
			this->CalculateButton->Click += gcnew System::EventHandler(this, &TestForm::CalculateButton_Click);
			// 
			// MultiplicationTableView
			// 
			this->MultiplicationTableView->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->MultiplicationTableView->EditMode = System::Windows::Forms::DataGridViewEditMode::EditProgrammatically;
			this->MultiplicationTableView->Location = System::Drawing::Point(6, 6);
			this->MultiplicationTableView->MultiSelect = false;
			this->MultiplicationTableView->Name = L"MultiplicationTableView";
			this->MultiplicationTableView->ReadOnly = true;
			this->MultiplicationTableView->RowTemplate->Height = 21;
			this->MultiplicationTableView->ScrollBars = System::Windows::Forms::ScrollBars::None;
			this->MultiplicationTableView->Size = System::Drawing::Size(620, 458);
			this->MultiplicationTableView->TabIndex = 0;
			// 
			// tabPage2
			// 
			this->tabPage2->Controls->Add(this->WorkLabel);
			this->tabPage2->Controls->Add(this->btnEqual);
			this->tabPage2->Controls->Add(this->btnAdd);
			this->tabPage2->Controls->Add(this->btnSub);
			this->tabPage2->Controls->Add(this->btnMultiple);
			this->tabPage2->Controls->Add(this->btnDivision);
			this->tabPage2->Controls->Add(this->btnDot);
			this->tabPage2->Controls->Add(this->btn3);
			this->tabPage2->Controls->Add(this->btn6);
			this->tabPage2->Controls->Add(this->btn9);
			this->tabPage2->Controls->Add(this->btnRoot);
			this->tabPage2->Controls->Add(this->btn0);
			this->tabPage2->Controls->Add(this->btn2);
			this->tabPage2->Controls->Add(this->btn5);
			this->tabPage2->Controls->Add(this->btn8);
			this->tabPage2->Controls->Add(this->btnSquare);
			this->tabPage2->Controls->Add(this->btnUndo);
			this->tabPage2->Controls->Add(this->btnClear);
			this->tabPage2->Controls->Add(this->btnCE);
			this->tabPage2->Controls->Add(this->btnSign);
			this->tabPage2->Controls->Add(this->btn1);
			this->tabPage2->Controls->Add(this->btn4);
			this->tabPage2->Controls->Add(this->btn7);
			this->tabPage2->Controls->Add(this->btnInverse);
			this->tabPage2->Controls->Add(this->btnPercent);
			this->tabPage2->Controls->Add(this->btnMmemory);
			this->tabPage2->Controls->Add(this->btnMS);
			this->tabPage2->Controls->Add(this->btnMminus);
			this->tabPage2->Controls->Add(this->btnMplus);
			this->tabPage2->Controls->Add(this->btnMR);
			this->tabPage2->Controls->Add(this->btnMC);
			this->tabPage2->Controls->Add(this->DispLabel);
			this->tabPage2->Font = (gcnew System::Drawing::Font(L"MS UI Gothic", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(128)));
			this->tabPage2->Location = System::Drawing::Point(4, 4);
			this->tabPage2->Name = L"tabPage2";
			this->tabPage2->Padding = System::Windows::Forms::Padding(3);
			this->tabPage2->Size = System::Drawing::Size(760, 517);
			this->tabPage2->TabIndex = 1;
			this->tabPage2->Text = L"Calculator";
			this->tabPage2->UseVisualStyleBackColor = true;
			// 
			// WorkLabel
			// 
			this->WorkLabel->BackColor = System::Drawing::Color::Silver;
			this->WorkLabel->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->WorkLabel->Font = (gcnew System::Drawing::Font(L"Courier New", 20.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->WorkLabel->Location = System::Drawing::Point(30, 12);
			this->WorkLabel->Name = L"WorkLabel";
			this->WorkLabel->Size = System::Drawing::Size(705, 33);
			this->WorkLabel->TabIndex = 31;
			this->WorkLabel->Text = L"123+456";
			this->WorkLabel->TextAlign = System::Drawing::ContentAlignment::MiddleRight;
			// 
			// btnEqual
			// 
			this->btnEqual->BackColor = System::Drawing::Color::PaleTurquoise;
			this->btnEqual->Location = System::Drawing::Point(565, 454);
			this->btnEqual->Name = L"btnEqual";
			this->btnEqual->Size = System::Drawing::Size(170, 55);
			this->btnEqual->TabIndex = 30;
			this->btnEqual->Text = L"＝";
			this->btnEqual->UseVisualStyleBackColor = false;
			this->btnEqual->Click += gcnew System::EventHandler(this, &TestForm::btnEqual_Click);
			// 
			// btnAdd
			// 
			this->btnAdd->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)), 
				static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->btnAdd->Location = System::Drawing::Point(565, 393);
			this->btnAdd->Name = L"btnAdd";
			this->btnAdd->Size = System::Drawing::Size(170, 55);
			this->btnAdd->TabIndex = 29;
			this->btnAdd->Text = L"＋";
			this->btnAdd->UseVisualStyleBackColor = false;
			this->btnAdd->Click += gcnew System::EventHandler(this, &TestForm::btnAdd_Click);
			// 
			// btnSub
			// 
			this->btnSub->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)), 
				static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->btnSub->Location = System::Drawing::Point(565, 332);
			this->btnSub->Name = L"btnSub";
			this->btnSub->Size = System::Drawing::Size(170, 55);
			this->btnSub->TabIndex = 28;
			this->btnSub->Text = L"－";
			this->btnSub->UseVisualStyleBackColor = false;
			this->btnSub->Click += gcnew System::EventHandler(this, &TestForm::btnSub_Click);
			// 
			// btnMultiple
			// 
			this->btnMultiple->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)), 
				static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->btnMultiple->Location = System::Drawing::Point(565, 271);
			this->btnMultiple->Name = L"btnMultiple";
			this->btnMultiple->Size = System::Drawing::Size(170, 55);
			this->btnMultiple->TabIndex = 27;
			this->btnMultiple->Text = L"×";
			this->btnMultiple->UseVisualStyleBackColor = false;
			this->btnMultiple->Click += gcnew System::EventHandler(this, &TestForm::btnMultiple_Click);
			// 
			// btnDivision
			// 
			this->btnDivision->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)), 
				static_cast<System::Int32>(static_cast<System::Byte>(0)));
			this->btnDivision->Location = System::Drawing::Point(565, 210);
			this->btnDivision->Name = L"btnDivision";
			this->btnDivision->Size = System::Drawing::Size(170, 55);
			this->btnDivision->TabIndex = 26;
			this->btnDivision->Text = L"÷";
			this->btnDivision->UseVisualStyleBackColor = false;
			this->btnDivision->Click += gcnew System::EventHandler(this, &TestForm::btnDivision_Click);
			// 
			// btnDot
			// 
			this->btnDot->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btnDot->Location = System::Drawing::Point(389, 454);
			this->btnDot->Name = L"btnDot";
			this->btnDot->Size = System::Drawing::Size(170, 55);
			this->btnDot->TabIndex = 25;
			this->btnDot->Text = L"．";
			this->btnDot->UseVisualStyleBackColor = false;
			this->btnDot->Click += gcnew System::EventHandler(this, &TestForm::btnDot_Click);
			// 
			// btn3
			// 
			this->btn3->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn3->Location = System::Drawing::Point(389, 393);
			this->btn3->Name = L"btn3";
			this->btn3->Size = System::Drawing::Size(170, 55);
			this->btn3->TabIndex = 24;
			this->btn3->Text = L"３";
			this->btn3->UseVisualStyleBackColor = false;
			this->btn3->Click += gcnew System::EventHandler(this, &TestForm::btn3_Click);
			// 
			// btn6
			// 
			this->btn6->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn6->Location = System::Drawing::Point(389, 332);
			this->btn6->Name = L"btn6";
			this->btn6->Size = System::Drawing::Size(170, 55);
			this->btn6->TabIndex = 23;
			this->btn6->Text = L"６";
			this->btn6->UseVisualStyleBackColor = false;
			this->btn6->Click += gcnew System::EventHandler(this, &TestForm::btn6_Click);
			// 
			// btn9
			// 
			this->btn9->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn9->Location = System::Drawing::Point(389, 271);
			this->btn9->Name = L"btn9";
			this->btn9->Size = System::Drawing::Size(170, 55);
			this->btn9->TabIndex = 22;
			this->btn9->Text = L"９";
			this->btn9->UseVisualStyleBackColor = false;
			this->btn9->Click += gcnew System::EventHandler(this, &TestForm::btn9_Click);
			// 
			// btnRoot
			// 
			this->btnRoot->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnRoot->Location = System::Drawing::Point(389, 210);
			this->btnRoot->Name = L"btnRoot";
			this->btnRoot->Size = System::Drawing::Size(170, 55);
			this->btnRoot->TabIndex = 21;
			this->btnRoot->Text = L"√x";
			this->btnRoot->UseVisualStyleBackColor = false;
			this->btnRoot->Click += gcnew System::EventHandler(this, &TestForm::btnRoot_Click);
			// 
			// btn0
			// 
			this->btn0->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn0->Location = System::Drawing::Point(210, 454);
			this->btn0->Name = L"btn0";
			this->btn0->Size = System::Drawing::Size(170, 55);
			this->btn0->TabIndex = 20;
			this->btn0->Text = L"０";
			this->btn0->UseVisualStyleBackColor = false;
			this->btn0->Click += gcnew System::EventHandler(this, &TestForm::btn0_Click);
			// 
			// btn2
			// 
			this->btn2->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn2->Location = System::Drawing::Point(210, 393);
			this->btn2->Name = L"btn2";
			this->btn2->Size = System::Drawing::Size(170, 55);
			this->btn2->TabIndex = 19;
			this->btn2->Text = L"２";
			this->btn2->UseVisualStyleBackColor = false;
			this->btn2->Click += gcnew System::EventHandler(this, &TestForm::btn2_Click);
			// 
			// btn5
			// 
			this->btn5->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn5->Location = System::Drawing::Point(210, 332);
			this->btn5->Name = L"btn5";
			this->btn5->Size = System::Drawing::Size(170, 55);
			this->btn5->TabIndex = 18;
			this->btn5->Text = L"５";
			this->btn5->UseVisualStyleBackColor = false;
			this->btn5->Click += gcnew System::EventHandler(this, &TestForm::btn5_Click);
			// 
			// btn8
			// 
			this->btn8->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn8->Location = System::Drawing::Point(210, 271);
			this->btn8->Name = L"btn8";
			this->btn8->Size = System::Drawing::Size(170, 55);
			this->btn8->TabIndex = 17;
			this->btn8->Text = L"８";
			this->btn8->UseVisualStyleBackColor = false;
			this->btn8->Click += gcnew System::EventHandler(this, &TestForm::btn8_Click);
			// 
			// btnSquare
			// 
			this->btnSquare->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnSquare->Location = System::Drawing::Point(210, 210);
			this->btnSquare->Name = L"btnSquare";
			this->btnSquare->Size = System::Drawing::Size(170, 55);
			this->btnSquare->TabIndex = 16;
			this->btnSquare->Text = L"X2";
			this->btnSquare->UseVisualStyleBackColor = false;
			this->btnSquare->Click += gcnew System::EventHandler(this, &TestForm::btnSquare_Click);
			// 
			// btnUndo
			// 
			this->btnUndo->BackColor = System::Drawing::Color::Yellow;
			this->btnUndo->Location = System::Drawing::Point(566, 149);
			this->btnUndo->Name = L"btnUndo";
			this->btnUndo->Size = System::Drawing::Size(170, 55);
			this->btnUndo->TabIndex = 15;
			this->btnUndo->Text = L"<-×";
			this->btnUndo->UseVisualStyleBackColor = false;
			this->btnUndo->Click += gcnew System::EventHandler(this, &TestForm::btnUndo_Click);
			// 
			// btnClear
			// 
			this->btnClear->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnClear->Location = System::Drawing::Point(388, 149);
			this->btnClear->Name = L"btnClear";
			this->btnClear->Size = System::Drawing::Size(170, 55);
			this->btnClear->TabIndex = 14;
			this->btnClear->Text = L"C";
			this->btnClear->UseVisualStyleBackColor = false;
			this->btnClear->Click += gcnew System::EventHandler(this, &TestForm::btnClear_Click);
			// 
			// btnCE
			// 
			this->btnCE->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnCE->Location = System::Drawing::Point(210, 149);
			this->btnCE->Name = L"btnCE";
			this->btnCE->Size = System::Drawing::Size(170, 55);
			this->btnCE->TabIndex = 13;
			this->btnCE->Text = L"CE";
			this->btnCE->UseVisualStyleBackColor = false;
			this->btnCE->Click += gcnew System::EventHandler(this, &TestForm::btnCE_Click);
			// 
			// btnSign
			// 
			this->btnSign->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btnSign->Location = System::Drawing::Point(32, 454);
			this->btnSign->Name = L"btnSign";
			this->btnSign->Size = System::Drawing::Size(170, 55);
			this->btnSign->TabIndex = 12;
			this->btnSign->Text = L"＋／－";
			this->btnSign->UseVisualStyleBackColor = false;
			this->btnSign->Click += gcnew System::EventHandler(this, &TestForm::btnSign_Click);
			// 
			// btn1
			// 
			this->btn1->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn1->Location = System::Drawing::Point(32, 393);
			this->btn1->Name = L"btn1";
			this->btn1->Size = System::Drawing::Size(170, 55);
			this->btn1->TabIndex = 11;
			this->btn1->Text = L"１";
			this->btn1->UseVisualStyleBackColor = false;
			this->btn1->Click += gcnew System::EventHandler(this, &TestForm::btn1_Click);
			// 
			// btn4
			// 
			this->btn4->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn4->Location = System::Drawing::Point(32, 332);
			this->btn4->Name = L"btn4";
			this->btn4->Size = System::Drawing::Size(170, 55);
			this->btn4->TabIndex = 10;
			this->btn4->Text = L"４";
			this->btn4->UseVisualStyleBackColor = false;
			this->btn4->Click += gcnew System::EventHandler(this, &TestForm::btn4_Click);
			// 
			// btn7
			// 
			this->btn7->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(192)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(255)));
			this->btn7->Location = System::Drawing::Point(32, 271);
			this->btn7->Name = L"btn7";
			this->btn7->Size = System::Drawing::Size(170, 55);
			this->btn7->TabIndex = 9;
			this->btn7->Text = L"７";
			this->btn7->UseVisualStyleBackColor = false;
			this->btn7->Click += gcnew System::EventHandler(this, &TestForm::btn7_Click);
			// 
			// btnInverse
			// 
			this->btnInverse->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnInverse->Location = System::Drawing::Point(32, 210);
			this->btnInverse->Name = L"btnInverse";
			this->btnInverse->Size = System::Drawing::Size(170, 55);
			this->btnInverse->TabIndex = 8;
			this->btnInverse->Text = L"１／Ｘ";
			this->btnInverse->UseVisualStyleBackColor = false;
			this->btnInverse->Click += gcnew System::EventHandler(this, &TestForm::btnInverse_Click);
			// 
			// btnPercent
			// 
			this->btnPercent->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)), 
				static_cast<System::Int32>(static_cast<System::Byte>(192)));
			this->btnPercent->Location = System::Drawing::Point(32, 149);
			this->btnPercent->Name = L"btnPercent";
			this->btnPercent->Size = System::Drawing::Size(170, 55);
			this->btnPercent->TabIndex = 7;
			this->btnPercent->Text = L"％";
			this->btnPercent->UseVisualStyleBackColor = false;
			this->btnPercent->Click += gcnew System::EventHandler(this, &TestForm::btnPercent_Click);
			// 
			// btnMmemory
			// 
			this->btnMmemory->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMmemory->Location = System::Drawing::Point(627, 105);
			this->btnMmemory->Name = L"btnMmemory";
			this->btnMmemory->Size = System::Drawing::Size(109, 38);
			this->btnMmemory->TabIndex = 6;
			this->btnMmemory->Text = L"Mmemory";
			this->btnMmemory->UseVisualStyleBackColor = false;
			this->btnMmemory->Click += gcnew System::EventHandler(this, &TestForm::btnMmemory_Click);
			// 
			// btnMS
			// 
			this->btnMS->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMS->Location = System::Drawing::Point(508, 105);
			this->btnMS->Name = L"btnMS";
			this->btnMS->Size = System::Drawing::Size(109, 38);
			this->btnMS->TabIndex = 5;
			this->btnMS->Text = L"MS";
			this->btnMS->UseVisualStyleBackColor = false;
			this->btnMS->Click += gcnew System::EventHandler(this, &TestForm::btnMS_Click);
			// 
			// btnMminus
			// 
			this->btnMminus->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMminus->Location = System::Drawing::Point(389, 105);
			this->btnMminus->Name = L"btnMminus";
			this->btnMminus->Size = System::Drawing::Size(109, 38);
			this->btnMminus->TabIndex = 4;
			this->btnMminus->Text = L"M-";
			this->btnMminus->UseVisualStyleBackColor = false;
			this->btnMminus->Click += gcnew System::EventHandler(this, &TestForm::btnMminus_Click);
			// 
			// btnMplus
			// 
			this->btnMplus->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMplus->Location = System::Drawing::Point(270, 105);
			this->btnMplus->Name = L"btnMplus";
			this->btnMplus->Size = System::Drawing::Size(109, 38);
			this->btnMplus->TabIndex = 3;
			this->btnMplus->Text = L"M+";
			this->btnMplus->UseVisualStyleBackColor = false;
			this->btnMplus->Click += gcnew System::EventHandler(this, &TestForm::btnMplus_Click);
			// 
			// btnMR
			// 
			this->btnMR->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMR->Location = System::Drawing::Point(151, 105);
			this->btnMR->Name = L"btnMR";
			this->btnMR->Size = System::Drawing::Size(109, 38);
			this->btnMR->TabIndex = 2;
			this->btnMR->Text = L"MR";
			this->btnMR->UseVisualStyleBackColor = false;
			this->btnMR->Click += gcnew System::EventHandler(this, &TestForm::btnMR_Click);
			// 
			// btnMC
			// 
			this->btnMC->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(224)), static_cast<System::Int32>(static_cast<System::Byte>(224)), 
				static_cast<System::Int32>(static_cast<System::Byte>(224)));
			this->btnMC->Location = System::Drawing::Point(32, 105);
			this->btnMC->Name = L"btnMC";
			this->btnMC->Size = System::Drawing::Size(109, 38);
			this->btnMC->TabIndex = 1;
			this->btnMC->Text = L"MC";
			this->btnMC->UseVisualStyleBackColor = false;
			this->btnMC->Click += gcnew System::EventHandler(this, &TestForm::btnMC_Click);
			// 
			// DispLabel
			// 
			this->DispLabel->BackColor = System::Drawing::Color::White;
			this->DispLabel->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->DispLabel->Font = (gcnew System::Drawing::Font(L"Courier New", 20.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->DispLabel->Location = System::Drawing::Point(31, 45);
			this->DispLabel->Name = L"DispLabel";
			this->DispLabel->Size = System::Drawing::Size(705, 57);
			this->DispLabel->TabIndex = 0;
			this->DispLabel->Text = L"1234567890";
			this->DispLabel->TextAlign = System::Drawing::ContentAlignment::MiddleRight;
			// 
			// TestForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(792, 573);
			this->Controls->Add(this->tabControl1);
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"TestForm";
			this->Text = L"EntryTest";
			this->tabControl1->ResumeLayout(false);
			this->tabPage1->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->MultiplicationTableView))->EndInit();
			this->tabPage2->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void CalculateButton_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMC_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMR_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMplus_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMminus_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMS_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMmemory_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnPercent_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnCE_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnClear_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnUndo_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnInverse_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnSquare_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnRoot_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnDivision_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnMultiple_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnSub_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnAdd_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnEqual_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnDot_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btnSign_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn0_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn1_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn2_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn3_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn4_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn5_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn6_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn7_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn8_Click(System::Object^  sender, System::EventArgs^  e);
	private: System::Void btn9_Click(System::Object^  sender, System::EventArgs^  e);
};
}

