#pragma once

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
			btn_generate_npc = (gcnew System::Windows::Forms::Button());
			this->pnl_titulo->SuspendLayout();
			this->pnl_central->SuspendLayout();
			this->SuspendLayout();
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
			// btn_generate_npc
			// 
			btn_generate_npc->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			btn_generate_npc->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)), static_cast<System::Int32>(static_cast<System::Byte>(79)));
			btn_generate_npc->FlatAppearance->BorderSize = 0;
			btn_generate_npc->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			btn_generate_npc->Font = (gcnew System::Drawing::Font(L"Calibri", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			btn_generate_npc->Location = System::Drawing::Point(441, 483);
			btn_generate_npc->Name = L"btn_generate_npc";
			btn_generate_npc->Size = System::Drawing::Size(162, 61);
			btn_generate_npc->TabIndex = 2;
			btn_generate_npc->Text = L"Generate NPC";
			btn_generate_npc->UseVisualStyleBackColor = false;
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
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void RandomNPC_Load(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
