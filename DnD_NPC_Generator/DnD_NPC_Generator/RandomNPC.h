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
	private: System::Windows::Forms::Panel^ panel1;
	protected:
	private: System::Windows::Forms::Panel^ panel2;
	private: System::Windows::Forms::Label^ lbl_RandomNPC_Title;
	private: System::Windows::Forms::Panel^ panel3;


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
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->panel2 = (gcnew System::Windows::Forms::Panel());
			this->lbl_RandomNPC_Title = (gcnew System::Windows::Forms::Label());
			this->panel3 = (gcnew System::Windows::Forms::Panel());
			this->panel1->SuspendLayout();
			this->SuspendLayout();
			// 
			// panel1
			// 
			this->panel1->Controls->Add(this->lbl_RandomNPC_Title);
			this->panel1->Location = System::Drawing::Point(221, 116);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(200, 66);
			this->panel1->TabIndex = 0;
			// 
			// panel2
			// 
			this->panel2->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->panel2->Location = System::Drawing::Point(221, 188);
			this->panel2->Name = L"panel2";
			this->panel2->Size = System::Drawing::Size(200, 100);
			this->panel2->TabIndex = 1;
			// 
			// lbl_RandomNPC_Title
			// 
			this->lbl_RandomNPC_Title->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)), static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->lbl_RandomNPC_Title->Dock = System::Windows::Forms::DockStyle::Top;
			this->lbl_RandomNPC_Title->Font = (gcnew System::Drawing::Font(L"Algerian", 36, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lbl_RandomNPC_Title->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)),
				static_cast<System::Int32>(static_cast<System::Byte>(228)), static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->lbl_RandomNPC_Title->Location = System::Drawing::Point(0, 0);
			this->lbl_RandomNPC_Title->Name = L"lbl_RandomNPC_Title";
			this->lbl_RandomNPC_Title->Size = System::Drawing::Size(200, 23);
			this->lbl_RandomNPC_Title->TabIndex = 0;
			this->lbl_RandomNPC_Title->Text = L"NPC Generator";
			this->lbl_RandomNPC_Title->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// panel3
			// 
			this->panel3->Location = System::Drawing::Point(221, 80);
			this->panel3->Name = L"panel3";
			this->panel3->Size = System::Drawing::Size(200, 30);
			this->panel3->TabIndex = 2;
			// 
			// RandomNPC
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1044, 661);
			this->Controls->Add(this->panel3);
			this->Controls->Add(this->panel2);
			this->Controls->Add(this->panel1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"RandomNPC";
			this->Text = L"RandomNPC";
			this->Load += gcnew System::EventHandler(this, &RandomNPC::RandomNPC_Load);
			this->panel1->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void RandomNPC_Load(System::Object^ sender, System::EventArgs^ e) {
	}
	};
}
