//
// TestForm.cpp : �e�X�g�t�H�[���̎����t�@�C��
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
	/// �R���X�g���N�^
	/// </summary>
	TestForm::TestForm(void)
	{
		InitializeComponent();
		//
		// �����ɃR���X�g���N�^ �R�[�h��ǉ����܂�
		//
		InitializeTable(this->MultiplicationTableView);
		this->DispLabel->Text = "";
		this->WorkLabel->Text = "";
	}

	/// <summary>
	/// �g�p���̃��\�[�X�����ׂăN���[���A�b�v���܂��B
	/// </summary>
	TestForm::~TestForm()
	{
		if (components)
		{
			delete components;
		}
	}

#pragma region ���\�̎���
	/// <summary>
	/// ���\�Z�b�g�{�^��
	/// </summary>
	System::Void TestForm::CalculateButton_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		//
		//TODO: �����ɋ��\�𖄂߂� �R�[�h��ǉ����܂�
		// ��)
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
	

#pragma region �d��̎���
	///
	/// TODO: �����ɓd�� �R�[�h���������܂�
	/// ������region���Ƀ{�^���̃C�x���g���W�񂳂�Ă܂��B
	/// ���ʃN���X���쐬�A�ʃt�@�C���ɏ������������Ă����܂��܂���B�i���R�Ɏ������ĉ������j
	/// �����ʂ�DispLabel��WorkLabel�ɕ\�����ĉ������B
	// ��)
	// this->WorkLabel->Text = "10�~10=";
	// this->DispLabel->Text = "100";
	///
#pragma region ���Z�{�^��
	/// <summary>
	/// ���{�^��
	/// </summary>
	System::Void TestForm::btnDivision_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �~�{�^��
	/// </summary>
	System::Void TestForm::btnMultiple_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �|�{�^��
	/// </summary>
	System::Void TestForm::btnSub_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �{�{�^��
	/// </summary>
	System::Void TestForm::btnAdd_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ���{�^��
	/// </summary>
	System::Void TestForm::btnEqual_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region ���l�{�^��
	/// <summary>
	/// �O�{�^��
	/// </summary>
	System::Void TestForm::btn0_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �P�{�^��
	/// </summary>
	System::Void TestForm::btn1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �Q�{�^��
	/// </summary>
	System::Void TestForm::btn2_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �R�{�^��
	/// </summary>
	System::Void TestForm::btn3_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �S�{�^��
	/// </summary>
	System::Void TestForm::btn4_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �T�{�^��
	/// </summary>
	System::Void TestForm::btn5_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �U�{�^��
	/// </summary>
	System::Void TestForm::btn6_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �V�{�^��
	/// </summary>
	System::Void TestForm::btn7_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �W�{�^��
	/// </summary>
	System::Void TestForm::btn8_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �X�{�^��
	/// </summary>
	System::Void TestForm::btn9_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �D�{�^��
	/// </summary>
	System::Void TestForm::btnDot_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �{�^�|�{�^��
	/// </summary>
	System::Void TestForm::btnSign_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region �@�\�{�^��
	/// <summary>
	/// ���{�^��
	/// </summary>
	System::Void TestForm::btnPercent_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ���|�~�{�^��
	/// </summary>
	System::Void TestForm::btnUndo_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �P�^�w�{�^��
	/// </summary>
	System::Void TestForm::btnInverse_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �w�Q�{�^��
	/// </summary>
	System::Void TestForm::btnSquare_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// ��x�{�^��
	/// </summary>
	System::Void TestForm::btnRoot_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �b�d�{�^��
	/// </summary>
	System::Void TestForm::btnCE_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �b�{�^��
	/// </summary>
	System::Void TestForm::btnClear_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma region �������[�{�^��
	/// <summary>
	/// �l�b�{�^��
	/// </summary>
	System::Void TestForm::btnMC_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �l�q�{�^��
	/// </summary>
	System::Void TestForm::btnMR_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �l�{�{�^��
	/// </summary>
	System::Void TestForm::btnMplus_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �l�|�{�^��
	/// </summary>
	System::Void TestForm::btnMminus_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �l�r�{�^��
	/// </summary>
	System::Void TestForm::btnMS_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
	/// <summary>
	/// �l�������{�^��
	/// </summary>
	System::Void TestForm::btnMmemory_Click(System::Object^  sender, System::EventArgs^  e) 
	{
	}
#pragma endregion
#pragma endregion

	/// <summary>
	/// ���\�̏�����
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
