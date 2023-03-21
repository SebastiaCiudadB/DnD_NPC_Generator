#pragma once

namespace DnDNPCGenerator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de Settings
	/// </summary>
	public ref class Settings : public System::Windows::Forms::Form
	{
	public:
		Settings(void)
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
		~Settings()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ pnl_central;
	protected:
	private: System::Windows::Forms::Panel^ pnl_titulo;
	private: System::Windows::Forms::Panel^ pnl_correccion;
	private: System::Windows::Forms::Label^ lbl_titulo;

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
			this->pnl_central = (gcnew System::Windows::Forms::Panel());
			this->pnl_titulo = (gcnew System::Windows::Forms::Panel());
			this->pnl_correccion = (gcnew System::Windows::Forms::Panel());
			this->lbl_titulo = (gcnew System::Windows::Forms::Label());
			this->pnl_titulo->SuspendLayout();
			this->SuspendLayout();
			// 
			// pnl_central
			// 
			this->pnl_central->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->pnl_central->Dock = System::Windows::Forms::DockStyle::Fill;
			this->pnl_central->Location = System::Drawing::Point(0, 90);
			this->pnl_central->Name = L"pnl_central";
			this->pnl_central->Size = System::Drawing::Size(1044, 571);
			this->pnl_central->TabIndex = 5;
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
			this->pnl_titulo->TabIndex = 4;
			// 
			// pnl_correccion
			// 
			this->pnl_correccion->Dock = System::Windows::Forms::DockStyle::Top;
			this->pnl_correccion->Location = System::Drawing::Point(0, 0);
			this->pnl_correccion->Name = L"pnl_correccion";
			this->pnl_correccion->Size = System::Drawing::Size(1044, 30);
			this->pnl_correccion->TabIndex = 3;
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
			this->lbl_titulo->Text = L"Settings";
			this->lbl_titulo->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// Settings
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1044, 661);
			this->Controls->Add(this->pnl_central);
			this->Controls->Add(this->pnl_titulo);
			this->Controls->Add(this->pnl_correccion);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"Settings";
			this->Text = L"Settings";
			this->pnl_titulo->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}
