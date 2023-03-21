#pragma once

namespace DnDNPCGenerator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de MainForm
	/// </summary>
	public ref class MainForm : public System::Windows::Forms::Form
	{
	public:
		MainForm(void)
		{
			InitializeComponent();

			this->MinimumSize = System::Drawing::Size(1260, 700);
			this->MaximumSize = System::Drawing::Size(1260, 700);
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~MainForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ panelLateral;
	protected:
	private: System::Windows::Forms::Panel^ panelCentral;
	private: System::Windows::Forms::Panel^ panel_Icono;
	private: System::Windows::Forms::Panel^ panel_Titulo;
	private: System::Windows::Forms::Button^ btn_ajustes;
	private: System::Windows::Forms::Button^ btn_list;
	private: System::Windows::Forms::Button^ btn_npc;
	private: System::Windows::Forms::PictureBox^ pictureBox1;



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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MainForm::typeid));
			this->panelLateral = (gcnew System::Windows::Forms::Panel());
			this->btn_ajustes = (gcnew System::Windows::Forms::Button());
			this->btn_list = (gcnew System::Windows::Forms::Button());
			this->btn_npc = (gcnew System::Windows::Forms::Button());
			this->panel_Icono = (gcnew System::Windows::Forms::Panel());
			this->panelCentral = (gcnew System::Windows::Forms::Panel());
			this->panel_Titulo = (gcnew System::Windows::Forms::Panel());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->panelLateral->SuspendLayout();
			this->panel_Icono->SuspendLayout();
			this->panelCentral->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// panelLateral
			// 
			this->panelLateral->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->panelLateral->Controls->Add(this->btn_ajustes);
			this->panelLateral->Controls->Add(this->btn_list);
			this->panelLateral->Controls->Add(this->btn_npc);
			this->panelLateral->Controls->Add(this->panel_Icono);
			this->panelLateral->Dock = System::Windows::Forms::DockStyle::Left;
			this->panelLateral->Location = System::Drawing::Point(0, 0);
			this->panelLateral->Name = L"panelLateral";
			this->panelLateral->Size = System::Drawing::Size(200, 661);
			this->panelLateral->TabIndex = 0;
			// 
			// btn_ajustes
			// 
			this->btn_ajustes->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->btn_ajustes->Cursor = System::Windows::Forms::Cursors::Hand;
			this->btn_ajustes->Dock = System::Windows::Forms::DockStyle::Top;
			this->btn_ajustes->FlatAppearance->BorderColor = System::Drawing::Color::Black;
			this->btn_ajustes->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btn_ajustes->Location = System::Drawing::Point(0, 300);
			this->btn_ajustes->Name = L"btn_ajustes";
			this->btn_ajustes->Size = System::Drawing::Size(200, 50);
			this->btn_ajustes->TabIndex = 3;
			this->btn_ajustes->Text = L"Settings";
			this->btn_ajustes->UseVisualStyleBackColor = false;
			this->btn_ajustes->MouseEnter += gcnew System::EventHandler(this, &MainForm::btn_ajustes_MouseEnter);
			this->btn_ajustes->MouseLeave += gcnew System::EventHandler(this, &MainForm::btn_ajustes_MouseLeave);
			// 
			// btn_list
			// 
			this->btn_list->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->btn_list->Cursor = System::Windows::Forms::Cursors::Hand;
			this->btn_list->Dock = System::Windows::Forms::DockStyle::Top;
			this->btn_list->FlatAppearance->BorderColor = System::Drawing::Color::Black;
			this->btn_list->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btn_list->Location = System::Drawing::Point(0, 250);
			this->btn_list->Name = L"btn_list";
			this->btn_list->Size = System::Drawing::Size(200, 50);
			this->btn_list->TabIndex = 2;
			this->btn_list->Text = L"List of NPC\'s";
			this->btn_list->UseVisualStyleBackColor = false;
			this->btn_list->MouseEnter += gcnew System::EventHandler(this, &MainForm::btn_list_MouseEnter);
			this->btn_list->MouseLeave += gcnew System::EventHandler(this, &MainForm::btn_list_MouseLeave);
			// 
			// btn_npc
			// 
			this->btn_npc->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
				static_cast<System::Int32>(static_cast<System::Byte>(79)));
			this->btn_npc->Cursor = System::Windows::Forms::Cursors::Hand;
			this->btn_npc->Dock = System::Windows::Forms::DockStyle::Top;
			this->btn_npc->FlatAppearance->BorderColor = System::Drawing::Color::Black;
			this->btn_npc->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btn_npc->Location = System::Drawing::Point(0, 200);
			this->btn_npc->Name = L"btn_npc";
			this->btn_npc->Size = System::Drawing::Size(200, 50);
			this->btn_npc->TabIndex = 1;
			this->btn_npc->Text = L"Random NPC";
			this->btn_npc->UseVisualStyleBackColor = false;
			this->btn_npc->MouseEnter += gcnew System::EventHandler(this, &MainForm::btn_npc_MouseEnter);
			this->btn_npc->MouseLeave += gcnew System::EventHandler(this, &MainForm::btn_npc_MouseLeave);
			// 
			// panel_Icono
			// 
			this->panel_Icono->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(44)), static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(51)));
			this->panel_Icono->Controls->Add(this->pictureBox1);
			this->panel_Icono->Dock = System::Windows::Forms::DockStyle::Top;
			this->panel_Icono->Location = System::Drawing::Point(0, 0);
			this->panel_Icono->Name = L"panel_Icono";
			this->panel_Icono->Size = System::Drawing::Size(200, 200);
			this->panel_Icono->TabIndex = 0;
			// 
			// panelCentral
			// 
			this->panelCentral->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(203)), static_cast<System::Int32>(static_cast<System::Byte>(228)),
				static_cast<System::Int32>(static_cast<System::Byte>(222)));
			this->panelCentral->Controls->Add(this->panel_Titulo);
			this->panelCentral->Dock = System::Windows::Forms::DockStyle::Fill;
			this->panelCentral->Location = System::Drawing::Point(200, 0);
			this->panelCentral->Name = L"panelCentral";
			this->panelCentral->Size = System::Drawing::Size(1044, 661);
			this->panelCentral->TabIndex = 1;
			// 
			// panel_Titulo
			// 
			this->panel_Titulo->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(44)), static_cast<System::Int32>(static_cast<System::Byte>(51)),
				static_cast<System::Int32>(static_cast<System::Byte>(51)));
			this->panel_Titulo->Dock = System::Windows::Forms::DockStyle::Top;
			this->panel_Titulo->Location = System::Drawing::Point(0, 0);
			this->panel_Titulo->Name = L"panel_Titulo";
			this->panel_Titulo->Size = System::Drawing::Size(1044, 30);
			this->panel_Titulo->TabIndex = 0;
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->ImageLocation = L"";
			this->pictureBox1->InitialImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.InitialImage")));
			this->pictureBox1->Location = System::Drawing::Point(12, 12);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(182, 182);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 0;
			this->pictureBox1->TabStop = false;
			// 
			// MainForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1244, 661);
			this->Controls->Add(this->panelCentral);
			this->Controls->Add(this->panelLateral);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"MainForm";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"MainForm";
			this->panelLateral->ResumeLayout(false);
			this->panel_Icono->ResumeLayout(false);
			this->panelCentral->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
//Con estas funciones, cambiamos el color del boton cuando pasamos por encima con el raton
private: System::Void btn_npc_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
	this->btn_npc->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(14)), static_cast<System::Int32>(static_cast<System::Byte>(131)),
		static_cast<System::Int32>(static_cast<System::Byte>(136)));
}
private: System::Void btn_npc_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
	this->btn_npc->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
		static_cast<System::Int32>(static_cast<System::Byte>(79)));
}
private: System::Void btn_list_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
	this->btn_list->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(14)), static_cast<System::Int32>(static_cast<System::Byte>(131)),
		static_cast<System::Int32>(static_cast<System::Byte>(136)));
}
private: System::Void btn_list_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
	this->btn_list->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
		static_cast<System::Int32>(static_cast<System::Byte>(79)));
}
private: System::Void btn_ajustes_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
	this->btn_ajustes->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(14)), static_cast<System::Int32>(static_cast<System::Byte>(131)),
		static_cast<System::Int32>(static_cast<System::Byte>(136)));
}
private: System::Void btn_ajustes_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
	this->btn_ajustes->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(46)), static_cast<System::Int32>(static_cast<System::Byte>(79)),
		static_cast<System::Int32>(static_cast<System::Byte>(79)));
}
};
}
