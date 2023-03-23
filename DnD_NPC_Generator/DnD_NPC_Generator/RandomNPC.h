#pragma once

#include "CharacterClasses.cpp";

namespace DnDNPCGenerator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de RandomNPC
	/// </summary>
	public ref class RandomNPC : public System::Windows::Forms::Form
	{
	public:
		RandomNPC(void)
		{
			InitializeComponent();

			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~RandomNPC()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ pnl_correccion;
	protected:
	private: System::Windows::Forms::Panel^ pnl_titulo;
	private: System::Windows::Forms::Panel^ pnl_central;
	private: System::Windows::Forms::Label^ lbl_titulo;
	private: System::Windows::Forms::Panel^ pnl_bottom;
	private: System::Windows::Forms::Panel^ pnl_middle;
	private: System::Windows::Forms::Panel^ pnl_top;
	private: System::Windows::Forms::Label^ lbl_sOrientation;

	private: System::Windows::Forms::Label^ lbl_gender;
	private: System::Windows::Forms::Label^ lbl_age;




	private: System::Windows::Forms::Label^ lbl_race;
	private: System::Windows::Forms::Label^ lbl_sOrientation_output;
	private: System::Windows::Forms::Label^ lbl_age_output;
	private: System::Windows::Forms::Label^ lbl_gender__output;
	private: System::Windows::Forms::Label^ lbl_race_output;
	private: System::Windows::Forms::Label^ lbl_height_output;

	private: System::Windows::Forms::Label^ lbl_constitution_output;
	private: System::Windows::Forms::Label^ lbl_weight_output;


	private: System::Windows::Forms::Label^ lbl_size;
	private: System::Windows::Forms::Label^ lbl_weight;
	private: System::Windows::Forms::Label^ lbl_size_output;



	private: System::Windows::Forms::Label^ lbl_constitution;
	private: System::Windows::Forms::Label^ lbl_height;
	private: System::Windows::Forms::Label^ lbl_hairStile_output;

	private: System::Windows::Forms::Label^ lbl_eyeColor_output;

	private: System::Windows::Forms::Label^ lbl_HairStile;
	private: System::Windows::Forms::Label^ lbl_hairColor_output;


	private: System::Windows::Forms::Label^ lbl_eyeColor;

	private: System::Windows::Forms::Label^ lbl_skinColor;
	private: System::Windows::Forms::Label^ lbl_skinColor_output;


	private: System::Windows::Forms::Label^ lbl_hairColor;





	protected:





	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			System::Windows::Forms::Button^ btn_generate_npc;
			this->pnl_correccion = (gcnew System::Windows::Forms::Panel());
			this->pnl_titulo = (gcnew System::Windows::Forms::Panel());
			this->lbl_titulo = (gcnew System::Windows::Forms::Label());
			this->pnl_central = (gcnew System::Windows::Forms::Panel());
			this->pnl_bottom = (gcnew System::Windows::Forms::Panel());
			this->pnl_middle = (gcnew System::Windows::Forms::Panel());
			this->pnl_top = (gcnew System::Windows::Forms::Panel());
			this->lbl_sOrientation_output = (gcnew System::Windows::Forms::Label());
			this->lbl_age_output = (gcnew System::Windows::Forms::Label());
			this->lbl_gender__output = (gcnew System::Windows::Forms::Label());
			this->lbl_race_output = (gcnew System::Windows::Forms::Label());
			this->lbl_sOrientation = (gcnew System::Windows::Forms::Label());
			this->lbl_gender = (gcnew System::Windows::Forms::Label());
			this->lbl_age = (gcnew System::Windows::Forms::Label());
			this->lbl_race = (gcnew System::Windows::Forms::Label());
			this->lbl_height_output = (gcnew System::Windows::Forms::Label());
			this->lbl_weight_output = (gcnew System::Windows::Forms::Label());
			this->lbl_constitution_output = (gcnew System::Windows::Forms::Label());
			this->lbl_size_output = (gcnew System::Windows::Forms::Label());
			this->lbl_height = (gcnew System::Windows::Forms::Label());
			this->lbl_constitution = (gcnew System::Windows::Forms::Label());
			this->lbl_weight = (gcnew System::Windows::Forms::Label());
			this->lbl_size = (gcnew System::Windows::Forms::Label());
			this->lbl_hairStile_output = (gcnew System::Windows::Forms::Label());
			this->lbl_eyeColor_output = (gcnew System::Windows::Forms::Label());
			this->lbl_hairColor_output = (gcnew System::Windows::Forms::Label());
			this->lbl_skinColor = (gcnew System::Windows::Forms::Label());
			this->lbl_hairColor = (gcnew System::Windows::Forms::Label());
			this->lbl_skinColor_output = (gcnew System::Windows::Forms::Label());
			this->lbl_eyeColor = (gcnew System::Windows::Forms::Label());
			this->lbl_HairStile = (gcnew System::Windows::Forms::Label());
			btn_generate_npc = (gcnew System::Windows::Forms::Button());
			this->pnl_titulo->SuspendLayout();
			this->pnl_central->SuspendLayout();
			this->pnl_bottom->SuspendLayout();
			this->pnl_middle->SuspendLayout();
			this->pnl_top->SuspendLayout();
			this->SuspendLayout();
			// 
			// btn_generate_npc
			// 
			btn_generate_npc->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			btn_generate_npc->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(14)),
				static_cast<System::Int32>(static_cast<System::Byte>(131)), static_cast<System::Int32>(static_cast<System::Byte>(136)));
			btn_generate_npc->FlatAppearance->BorderSize = 0;
			btn_generate_npc->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(14)),
				static_cast<System::Int32>(static_cast<System::Byte>(131)), static_cast<System::Int32>(static_cast<System::Byte>(136)));
			btn_generate_npc->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			btn_generate_npc->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			btn_generate_npc->Location = System::Drawing::Point(441, 483);
			btn_generate_npc->Name = L"btn_generate_npc";
			btn_generate_npc->Size = System::Drawing::Size(162, 61);
			btn_generate_npc->TabIndex = 2;
			btn_generate_npc->Text = L"Generate NPC";
			btn_generate_npc->UseVisualStyleBackColor = false;
			btn_generate_npc->Click += gcnew System::EventHandler(this, &RandomNPC::btn_generate_npc_Click);
			// 
			// pnl_correccion
			// 
			this->pnl_correccion->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_correccion->Location = System::Drawing::Point(0, 0);
			this->pnl_correccion->Name = L"pnl_correccion";
			this->pnl_correccion->Size = System::Drawing::Size(1044, 30);
			this->pnl_correccion->TabIndex = 0;
			// 
			// pnl_titulo
			// 
			this->pnl_titulo->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->pnl_titulo->Controls->Add(this->lbl_titulo);
			this->pnl_titulo->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_titulo->Location = System::Drawing::Point(0, 30);
			this->pnl_titulo->Name = L"pnl_titulo";
			this->pnl_titulo->Size = System::Drawing::Size(1044, 60);
			this->pnl_titulo->TabIndex = 1;
			// 
			// lbl_titulo
			// 
			this->lbl_titulo->Dock = System::Windows::Forms::DockStyle::Fill;
			this->lbl_titulo->Font = (gcnew System::Drawing::Font(L"Algerian", 36, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_titulo->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_titulo->Location = System::Drawing::Point(0, 0);
			this->lbl_titulo->Name = L"lbl_titulo";
			this->lbl_titulo->Size = System::Drawing::Size(1044, 60);
			this->lbl_titulo->TabIndex = 0;
			this->lbl_titulo->Text = L"NPC Generator";
			this->lbl_titulo->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// pnl_central
			// 
			this->pnl_central->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->pnl_central->Controls->Add(this->pnl_bottom);
			this->pnl_central->Controls->Add(this->pnl_middle);
			this->pnl_central->Controls->Add(this->pnl_top);
			this->pnl_central->Controls->Add(btn_generate_npc);
			this->pnl_central->Font = (gcnew System::Drawing::Font(L"Algerian", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->pnl_central->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->pnl_central->Location = System::Drawing::Point(0, 90);
			this->pnl_central->Name = L"pnl_central";
			this->pnl_central->Size = System::Drawing::Size(1044, 571);
			this->pnl_central->TabIndex = 2;
			// 
			// pnl_bottom
			// 
			this->pnl_bottom->Controls->Add(this->lbl_hairStile_output);
			this->pnl_bottom->Controls->Add(this->lbl_eyeColor_output);
			this->pnl_bottom->Controls->Add(this->lbl_HairStile);
			this->pnl_bottom->Controls->Add(this->lbl_hairColor_output);
			this->pnl_bottom->Controls->Add(this->lbl_eyeColor);
			this->pnl_bottom->Controls->Add(this->lbl_skinColor);
			this->pnl_bottom->Controls->Add(this->lbl_skinColor_output);
			this->pnl_bottom->Controls->Add(this->lbl_hairColor);
			this->pnl_bottom->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_bottom->Location = System::Drawing::Point(0, 280);
			this->pnl_bottom->Name = L"pnl_bottom";
			this->pnl_bottom->Size = System::Drawing::Size(1044, 160);
			this->pnl_bottom->TabIndex = 6;
			// 
			// pnl_middle
			// 
			this->pnl_middle->Controls->Add(this->lbl_height_output);
			this->pnl_middle->Controls->Add(this->lbl_constitution_output);
			this->pnl_middle->Controls->Add(this->lbl_weight_output);
			this->pnl_middle->Controls->Add(this->lbl_size);
			this->pnl_middle->Controls->Add(this->lbl_weight);
			this->pnl_middle->Controls->Add(this->lbl_size_output);
			this->pnl_middle->Controls->Add(this->lbl_constitution);
			this->pnl_middle->Controls->Add(this->lbl_height);
			this->pnl_middle->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_middle->Location = System::Drawing::Point(0, 140);
			this->pnl_middle->Name = L"pnl_middle";
			this->pnl_middle->Size = System::Drawing::Size(1044, 140);
			this->pnl_middle->TabIndex = 5;
			// 
			// pnl_top
			// 
			this->pnl_top->Controls->Add(this->lbl_sOrientation_output);
			this->pnl_top->Controls->Add(this->lbl_age_output);
			this->pnl_top->Controls->Add(this->lbl_gender__output);
			this->pnl_top->Controls->Add(this->lbl_race_output);
			this->pnl_top->Controls->Add(this->lbl_sOrientation);
			this->pnl_top->Controls->Add(this->lbl_gender);
			this->pnl_top->Controls->Add(this->lbl_age);
			this->pnl_top->Controls->Add(this->lbl_race);
			this->pnl_top->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_top->Location = System::Drawing::Point(0, 0);
			this->pnl_top->Name = L"pnl_top";
			this->pnl_top->Size = System::Drawing::Size(1044, 140);
			this->pnl_top->TabIndex = 3;
			// 
			// lbl_sOrientation_output
			// 
			this->lbl_sOrientation_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_sOrientation_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_sOrientation_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_sOrientation_output->Location = System::Drawing::Point(677, 95);
			this->lbl_sOrientation_output->Name = L"lbl_sOrientation_output";
			this->lbl_sOrientation_output->Size = System::Drawing::Size(258, 30);
			this->lbl_sOrientation_output->TabIndex = 7;
			this->lbl_sOrientation_output->Text = L".........................................";
			this->lbl_sOrientation_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_age_output
			// 
			this->lbl_age_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_age_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_age_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_age_output->Location = System::Drawing::Point(548, 38);
			this->lbl_age_output->Name = L"lbl_age_output";
			this->lbl_age_output->Size = System::Drawing::Size(258, 30);
			this->lbl_age_output->TabIndex = 6;
			this->lbl_age_output->Text = L".........................................";
			this->lbl_age_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_gender__output
			// 
			this->lbl_gender__output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_gender__output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_gender__output->ForeColor = System::Drawing::Color::Black;
			this->lbl_gender__output->Location = System::Drawing::Point(144, 95);
			this->lbl_gender__output->Name = L"lbl_gender__output";
			this->lbl_gender__output->Size = System::Drawing::Size(258, 30);
			this->lbl_gender__output->TabIndex = 5;
			this->lbl_gender__output->Text = L".........................................";
			this->lbl_gender__output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_race_output
			// 
			this->lbl_race_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_race_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_race_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_race_output->Location = System::Drawing::Point(122, 38);
			this->lbl_race_output->Name = L"lbl_race_output";
			this->lbl_race_output->Size = System::Drawing::Size(258, 30);
			this->lbl_race_output->TabIndex = 4;
			this->lbl_race_output->Text = L".........................................";
			this->lbl_race_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_sOrientation
			// 
			this->lbl_sOrientation->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_sOrientation->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_sOrientation->ForeColor = System::Drawing::Color::Black;
			this->lbl_sOrientation->Location = System::Drawing::Point(487, 95);
			this->lbl_sOrientation->Name = L"lbl_sOrientation";
			this->lbl_sOrientation->Size = System::Drawing::Size(184, 30);
			this->lbl_sOrientation->TabIndex = 3;
			this->lbl_sOrientation->Text = L"Sexual Orientation:";
			this->lbl_sOrientation->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_gender
			// 
			this->lbl_gender->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_gender->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_gender->ForeColor = System::Drawing::Color::Black;
			this->lbl_gender->Location = System::Drawing::Point(56, 95);
			this->lbl_gender->Name = L"lbl_gender";
			this->lbl_gender->Size = System::Drawing::Size(82, 30);
			this->lbl_gender->TabIndex = 2;
			this->lbl_gender->Text = L"Gender:";
			this->lbl_gender->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_age
			// 
			this->lbl_age->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_age->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_age->ForeColor = System::Drawing::Color::Black;
			this->lbl_age->Location = System::Drawing::Point(487, 38);
			this->lbl_age->Name = L"lbl_age";
			this->lbl_age->Size = System::Drawing::Size(55, 30);
			this->lbl_age->TabIndex = 1;
			this->lbl_age->Text = L"Age:";
			this->lbl_age->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_race
			// 
			this->lbl_race->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_race->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_race->ForeColor = System::Drawing::Color::Black;
			this->lbl_race->Location = System::Drawing::Point(56, 38);
			this->lbl_race->Name = L"lbl_race";
			this->lbl_race->Size = System::Drawing::Size(60, 30);
			this->lbl_race->TabIndex = 0;
			this->lbl_race->Text = L"Race:";
			this->lbl_race->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_height_output
			// 
			this->lbl_height_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_height_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_height_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_height_output->Location = System::Drawing::Point(579, 87);
			this->lbl_height_output->Name = L"lbl_height_output";
			this->lbl_height_output->Size = System::Drawing::Size(258, 30);
			this->lbl_height_output->TabIndex = 15;
			this->lbl_height_output->Text = L".........................................";
			this->lbl_height_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_weight_output
			// 
			this->lbl_weight_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_weight_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_weight_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_weight_output->Location = System::Drawing::Point(579, 30);
			this->lbl_weight_output->Name = L"lbl_weight_output";
			this->lbl_weight_output->Size = System::Drawing::Size(258, 30);
			this->lbl_weight_output->TabIndex = 14;
			this->lbl_weight_output->Text = L".........................................";
			this->lbl_weight_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_constitution_output
			// 
			this->lbl_constitution_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_constitution_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_constitution_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_constitution_output->Location = System::Drawing::Point(190, 87);
			this->lbl_constitution_output->Name = L"lbl_constitution_output";
			this->lbl_constitution_output->Size = System::Drawing::Size(258, 30);
			this->lbl_constitution_output->TabIndex = 13;
			this->lbl_constitution_output->Text = L".........................................";
			this->lbl_constitution_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_size_output
			// 
			this->lbl_size_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_size_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_size_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_size_output->Location = System::Drawing::Point(122, 30);
			this->lbl_size_output->Name = L"lbl_size_output";
			this->lbl_size_output->Size = System::Drawing::Size(258, 30);
			this->lbl_size_output->TabIndex = 12;
			this->lbl_size_output->Text = L".........................................";
			this->lbl_size_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_height
			// 
			this->lbl_height->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_height->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_height->ForeColor = System::Drawing::Color::Black;
			this->lbl_height->Location = System::Drawing::Point(487, 87);
			this->lbl_height->Name = L"lbl_height";
			this->lbl_height->Size = System::Drawing::Size(86, 30);
			this->lbl_height->TabIndex = 11;
			this->lbl_height->Text = L"Height:";
			this->lbl_height->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_constitution
			// 
			this->lbl_constitution->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_constitution->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_constitution->ForeColor = System::Drawing::Color::Black;
			this->lbl_constitution->Location = System::Drawing::Point(56, 87);
			this->lbl_constitution->Name = L"lbl_constitution";
			this->lbl_constitution->Size = System::Drawing::Size(128, 30);
			this->lbl_constitution->TabIndex = 10;
			this->lbl_constitution->Text = L"Constitution:";
			this->lbl_constitution->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_weight
			// 
			this->lbl_weight->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_weight->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_weight->ForeColor = System::Drawing::Color::Black;
			this->lbl_weight->Location = System::Drawing::Point(487, 30);
			this->lbl_weight->Name = L"lbl_weight";
			this->lbl_weight->Size = System::Drawing::Size(86, 30);
			this->lbl_weight->TabIndex = 9;
			this->lbl_weight->Text = L"Weight:";
			this->lbl_weight->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_size
			// 
			this->lbl_size->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_size->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_size->ForeColor = System::Drawing::Color::Black;
			this->lbl_size->Location = System::Drawing::Point(56, 30);
			this->lbl_size->Name = L"lbl_size";
			this->lbl_size->Size = System::Drawing::Size(60, 30);
			this->lbl_size->TabIndex = 8;
			this->lbl_size->Text = L"Size:";
			this->lbl_size->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_hairStile_output
			// 
			this->lbl_hairStile_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_hairStile_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_hairStile_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_hairStile_output->Location = System::Drawing::Point(597, 87);
			this->lbl_hairStile_output->Name = L"lbl_hairStile_output";
			this->lbl_hairStile_output->Size = System::Drawing::Size(258, 30);
			this->lbl_hairStile_output->TabIndex = 23;
			this->lbl_hairStile_output->Text = L".........................................";
			this->lbl_hairStile_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_eyeColor_output
			// 
			this->lbl_eyeColor_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_eyeColor_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_eyeColor_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_eyeColor_output->Location = System::Drawing::Point(168, 87);
			this->lbl_eyeColor_output->Name = L"lbl_eyeColor_output";
			this->lbl_eyeColor_output->Size = System::Drawing::Size(258, 30);
			this->lbl_eyeColor_output->TabIndex = 21;
			this->lbl_eyeColor_output->Text = L".........................................";
			this->lbl_eyeColor_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_hairColor_output
			// 
			this->lbl_hairColor_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_hairColor_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_hairColor_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_hairColor_output->Location = System::Drawing::Point(597, 30);
			this->lbl_hairColor_output->Name = L"lbl_hairColor_output";
			this->lbl_hairColor_output->Size = System::Drawing::Size(258, 30);
			this->lbl_hairColor_output->TabIndex = 22;
			this->lbl_hairColor_output->Text = L".........................................";
			this->lbl_hairColor_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_skinColor
			// 
			this->lbl_skinColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_skinColor->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_skinColor->ForeColor = System::Drawing::Color::Black;
			this->lbl_skinColor->Location = System::Drawing::Point(56, 30);
			this->lbl_skinColor->Name = L"lbl_skinColor";
			this->lbl_skinColor->Size = System::Drawing::Size(106, 30);
			this->lbl_skinColor->TabIndex = 16;
			this->lbl_skinColor->Text = L"Skin Color:";
			this->lbl_skinColor->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_hairColor
			// 
			this->lbl_hairColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_hairColor->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_hairColor->ForeColor = System::Drawing::Color::Black;
			this->lbl_hairColor->Location = System::Drawing::Point(487, 30);
			this->lbl_hairColor->Name = L"lbl_hairColor";
			this->lbl_hairColor->Size = System::Drawing::Size(104, 30);
			this->lbl_hairColor->TabIndex = 17;
			this->lbl_hairColor->Text = L"Hair Color:";
			this->lbl_hairColor->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_skinColor_output
			// 
			this->lbl_skinColor_output->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_skinColor_output->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_skinColor_output->ForeColor = System::Drawing::Color::Black;
			this->lbl_skinColor_output->Location = System::Drawing::Point(168, 30);
			this->lbl_skinColor_output->Name = L"lbl_skinColor_output";
			this->lbl_skinColor_output->Size = System::Drawing::Size(258, 30);
			this->lbl_skinColor_output->TabIndex = 20;
			this->lbl_skinColor_output->Text = L".........................................";
			this->lbl_skinColor_output->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_eyeColor
			// 
			this->lbl_eyeColor->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_eyeColor->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_eyeColor->ForeColor = System::Drawing::Color::Black;
			this->lbl_eyeColor->Location = System::Drawing::Point(56, 87);
			this->lbl_eyeColor->Name = L"lbl_eyeColor";
			this->lbl_eyeColor->Size = System::Drawing::Size(106, 30);
			this->lbl_eyeColor->TabIndex = 18;
			this->lbl_eyeColor->Text = L"Eye Color:";
			this->lbl_eyeColor->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// lbl_HairStile
			// 
			this->lbl_HairStile->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_HairStile->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_HairStile->ForeColor = System::Drawing::Color::Black;
			this->lbl_HairStile->Location = System::Drawing::Point(487, 87);
			this->lbl_HairStile->Name = L"lbl_HairStile";
			this->lbl_HairStile->Size = System::Drawing::Size(104, 30);
			this->lbl_HairStile->TabIndex = 19;
			this->lbl_HairStile->Text = L"Hair Stile:";
			this->lbl_HairStile->TextAlign = System::Drawing::ContentAlignment::BottomLeft;
			// 
			// RandomNPC
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1044, 661);
			this->Controls->Add(this->pnl_titulo);
			this->Controls->Add(this->pnl_correccion);
			this->Controls->Add(this->pnl_central);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"RandomNPC";
			this->Text = L"RandomNPC";
			this->Load += gcnew System::EventHandler(this, &RandomNPC::RandomNPC_Load);
			this->pnl_titulo->ResumeLayout(false);
			this->pnl_central->ResumeLayout(false);
			this->pnl_bottom->ResumeLayout(false);
			this->pnl_middle->ResumeLayout(false);
			this->pnl_top->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void RandomNPC_Load(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void btn_generate_npc_Click(System::Object^ sender, System::EventArgs^ e) {
		human character;
		character.setHuman();

		lbl_race_output->Text = gcnew String(character.race.c_str());
		lbl_gender__output->Text = gcnew String(character.gender.c_str());
		lbl_sOrientation_output->Text = gcnew String(character.sexOrientation.c_str());
		lbl_age_output->Text = gcnew String(to_string(character.age).c_str());
	}
};
}
