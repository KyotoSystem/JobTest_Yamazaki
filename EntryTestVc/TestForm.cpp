//
// TestForm.cpp : テストフォームの実装ファイル
//

#include "stdafx.h"
#include "TestForm.h"


using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

namespace EntryTestVc {

	Void InitializeTable(DataGridView^ pGrid);
		
	/// <summary>
	/// コンストラクタ
	/// </summary>
	TestForm::TestForm(void)
	{
		InitializeComponent();
		//
		// ここにコンストラクタ コードを追加します
		//
		InitializeTable(this->MultiplicationTableView);
		this->DispLabel->Text = "";
		this->WorkLabel->Text = "";
	}

	/// <summary>
	/// 使用中のリソースをすべてクリーンアップします。
	/// </summary>
	TestForm::~TestForm()
	{
		if (components)
		{
			delete components;
		}
	}

#pragma region 九九表の実装
	/// <summary>
	/// 九九表セットボタン
	/// </summary>
	System::Void TestForm::CalculateButton_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		//
		//TODO: ここに九九表を埋める コードを追加します
		// 例)
		//this->MultiplicationTableView[1, 1]->Value = 1;
		// this->MultiplicationTableView[9, 9]->Value = 81;

		int i,j;
		for(i =1; i<=9; i++){
			for(j = 1; j<= 9; j++){
				int x= i*j;

				cout << x << "\n;
			





	}
		}
			
		}
		return 0;
	}
#pragma endregion
	

#pragma region 電卓の実装
	///
	/// TODO: ここに電卓 コードを実装します
	/// ※このregion内にボタンのイベントが集約されてます。
	/// ※別クラスを作成、別ファイルに処理を実装してもかまいません。（自由に実装して下さい）
	/// ※結果はDispLabelとWorkLabelに表示して下さい。
	// 例)
	// this->WorkLabel->Text = "10×10=";
	// this->DispLabel->Text = "100";
	///
#pragma region 演算ボタン
	/// <summary>
	/// ÷ボタン
	/// </summary>
	System::Void TestForm::btnDivision_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ×ボタン
	/// </summary>
	System::Void TestForm::btnMultiple_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// －ボタン
	/// </summary>
	System::Void TestForm::btnSub_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＋ボタン
	/// </summary>
	System::Void TestForm::btnAdd_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＝ボタン
	/// </summary>
	System::Void TestForm::btnEqual_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region 数値ボタン
	/// <summary>
	/// ０ボタン
	/// </summary>
	System::Void TestForm::btn0_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// １ボタン
	/// </summary>
	System::Void TestForm::btn1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ２ボタン
	/// </summary>
	System::Void TestForm::btn2_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ３ボタン
	/// </summary>
	System::Void TestForm::btn3_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ４ボタン
	/// </summary>
	System::Void TestForm::btn4_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ５ボタン
	/// </summary>
	System::Void TestForm::btn5_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ６ボタン
	/// </summary>
	System::Void TestForm::btn6_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ７ボタン
	/// </summary>
	System::Void TestForm::btn7_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ８ボタン
	/// </summary>
	System::Void TestForm::btn8_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ９ボタン
	/// </summary>
	System::Void TestForm::btn9_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ．ボタン
	/// </summary>
	System::Void TestForm::btnDot_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＋／－ボタン
	/// </summary>
	System::Void TestForm::btnSign_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region 機能ボタン
	/// <summary>
	/// ％ボタン
	/// </summary>
	System::Void TestForm::btnPercent_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＜－×ボタン
	/// </summary>
	System::Void TestForm::btnUndo_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// １／Ｘボタン
	/// </summary>
	System::Void TestForm::btnInverse_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// Ｘ２ボタン
	/// </summary>
	System::Void TestForm::btnSquare_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// √xボタン
	/// </summary>
	System::Void TestForm::btnRoot_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＣＥボタン
	/// </summary>
	System::Void TestForm::btnCE_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// Ｃボタン
	/// </summary>
	System::Void TestForm::btnClear_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region メモリーボタン
	/// <summary>
	/// ＭＣボタン
	/// </summary>
	System::Void TestForm::btnMC_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＭＲボタン
	/// </summary>
	System::Void TestForm::btnMR_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// Ｍ＋ボタン
	/// </summary>
	System::Void TestForm::btnMplus_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// Ｍ－ボタン
	/// </summary>
	System::Void TestForm::btnMminus_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ＭＳボタン
	/// </summary>
	System::Void TestForm::btnMS_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// Ｍメモリボタン
	/// </summary>
	System::Void TestForm::btnMmemory_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma endregion

	/// <summary>
	/// 九九表の初期化
	/// </summary>
	Void InitializeTable(DataGridView^ pGrid)
	{
		pGrid->ColumnCount = 10;
		pGrid->ColumnHeadersHeight = 48; // 460
		pGrid->RowHeadersWidth = 62; // 620
		pGrid->SelectionMode = DataGridViewSelectionMode::CellSelect;
		pGrid->AllowUserToAddRows = false;
		pGrid->RowsDefaultCellStyle->SelectionBackColor = Color::White;

		for(int i = 0; i < pGrid->ColumnCount; i++)
		{
			pGrid->Rows->Add();
			pGrid->Rows[i]->Height = (i == 0) ? 0 : 48;
			pGrid->Rows[i]->HeaderCell->Value = String::Format("{0:D}", i);
		}
		for(int i = 0; i < pGrid->ColumnCount; i++)
		{
			pGrid->Columns[i]->Width = (i == 0) ? 0 : 62;
			pGrid->Columns[i]->HeaderText = String::Format("{0:D}", i);
		}
	}
}
