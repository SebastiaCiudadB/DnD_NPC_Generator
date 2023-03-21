#pragma once

namespace DnDNPCGenerator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de NPCList
	/// </summary>
	public ref class NPCList : public System::Windows::Forms::Form
	{
	public:
		NPCList(void)
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
		~NPCList()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ lbl_Prueba;
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
			this->lbl_Prueba = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// lbl_Prueba
			// 
			this->lbl_Prueba->AutoSize = true;
			this->lbl_Prueba->Location = System::Drawing::Point(82, 124);
			this->lbl_Prueba->Name = L"lbl_Prueba";
			this->lbl_Prueba->Size = System::Drawing::Size(44, 13);
			this->lbl_Prueba->TabIndex = 1;
			this->lbl_Prueba->Text = L"NPC list";
			// 
			// NPCList
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1044, 661);
			this->Controls->Add(this->lbl_Prueba);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"NPCList";
			this->Text = L"NPCList";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	};
}
