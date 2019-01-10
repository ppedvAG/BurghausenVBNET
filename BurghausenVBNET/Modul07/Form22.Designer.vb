<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSumme = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtBezeichnung = New System.Windows.Forms.TextBox()
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.txtPreis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.bntLaden = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirma
        '
        Me.txtFirma.Location = New System.Drawing.Point(43, 36)
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(204, 31)
        Me.txtFirma.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Firma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Summe"
        '
        'lblSumme
        '
        Me.lblSumme.AutoSize = True
        Me.lblSumme.Location = New System.Drawing.Point(258, 42)
        Me.lblSumme.Name = "lblSumme"
        Me.lblSumme.Size = New System.Drawing.Size(19, 25)
        Me.lblSumme.TabIndex = 3
        Me.lblSumme.Text = "-"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1032, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 54)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1116, 248)
        Me.DataGridView1.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(750, 178)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Einfügen"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBezeichnung
        '
        Me.txtBezeichnung.Location = New System.Drawing.Point(235, 185)
        Me.txtBezeichnung.Name = "txtBezeichnung"
        Me.txtBezeichnung.Size = New System.Drawing.Size(398, 31)
        Me.txtBezeichnung.TabIndex = 10
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Location = New System.Drawing.Point(43, 185)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(73, 31)
        Me.txtAnzahl.TabIndex = 8
        '
        'txtPreis
        '
        Me.txtPreis.Location = New System.Drawing.Point(147, 185)
        Me.txtPreis.Name = "txtPreis"
        Me.txtPreis.Size = New System.Drawing.Size(68, 31)
        Me.txtPreis.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Anzahl"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Preis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bezeichung"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1054, 178)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 38)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Löschen"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(1017, 182)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(20, 31)
        Me.txtID.TabIndex = 14
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(970, 182)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(32, 25)
        Me.lblId.TabIndex = 15
        Me.lblId.Text = "ID"
        '
        'bntLaden
        '
        Me.bntLaden.Location = New System.Drawing.Point(1032, 78)
        Me.bntLaden.Name = "bntLaden"
        Me.bntLaden.Size = New System.Drawing.Size(127, 47)
        Me.bntLaden.TabIndex = 16
        Me.bntLaden.Text = "laden"
        Me.bntLaden.UseVisualStyleBackColor = True
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 789)
        Me.Controls.Add(Me.bntLaden)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPreis)
        Me.Controls.Add(Me.txtAnzahl)
        Me.Controls.Add(Me.txtBezeichnung)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSumme)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirma)
        Me.Name = "Form22"
        Me.Text = "Form22"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSumme As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtBezeichnung As TextBox
    Friend WithEvents txtAnzahl As TextBox
    Friend WithEvents txtPreis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents bntLaden As Button
End Class
