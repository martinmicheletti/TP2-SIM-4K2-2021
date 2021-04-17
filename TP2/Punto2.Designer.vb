<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Punto2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.graficarBTN = New System.Windows.Forms.Button()
        Me.Ktxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SerieDatos = New System.Windows.Forms.TabPage()
        Me.lst_SerieDatos = New System.Windows.Forms.ListBox()
        Me.GraficoFrecuencias = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TestChiCuadrado = New System.Windows.Forms.TabPage()
        Me.lblV = New System.Windows.Forms.Label()
        Me.dtgvChiCuadrado = New System.Windows.Forms.DataGridView()
        Me.Intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDeClase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xCuadradoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgvKolmogorov = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.SerieDatos.SuspendLayout()
        Me.GraficoFrecuencias.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestChiCuadrado.SuspendLayout()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvKolmogorov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(395, 6)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(105, 27)
        Me.btnLimpiar.TabIndex = 31
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'graficarBTN
        '
        Me.graficarBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.graficarBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graficarBTN.Location = New System.Drawing.Point(284, 6)
        Me.graficarBTN.Name = "graficarBTN"
        Me.graficarBTN.Size = New System.Drawing.Size(105, 27)
        Me.graficarBTN.TabIndex = 30
        Me.graficarBTN.Text = "Graficar"
        Me.graficarBTN.UseVisualStyleBackColor = False
        '
        'Ktxt
        '
        Me.Ktxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ktxt.Location = New System.Drawing.Point(135, 6)
        Me.Ktxt.Name = "Ktxt"
        Me.Ktxt.Size = New System.Drawing.Size(122, 20)
        Me.Ktxt.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "N° de intervalos (k)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SerieDatos)
        Me.TabControl1.Controls.Add(Me.GraficoFrecuencias)
        Me.TabControl1.Controls.Add(Me.TestChiCuadrado)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(4, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(770, 430)
        Me.TabControl1.TabIndex = 27
        '
        'SerieDatos
        '
        Me.SerieDatos.Controls.Add(Me.lst_SerieDatos)
        Me.SerieDatos.Location = New System.Drawing.Point(4, 22)
        Me.SerieDatos.Name = "SerieDatos"
        Me.SerieDatos.Size = New System.Drawing.Size(661, 404)
        Me.SerieDatos.TabIndex = 2
        Me.SerieDatos.Text = "Serie de Datos"
        Me.SerieDatos.UseVisualStyleBackColor = True
        '
        'lst_SerieDatos
        '
        Me.lst_SerieDatos.FormattingEnabled = True
        Me.lst_SerieDatos.Location = New System.Drawing.Point(3, 4)
        Me.lst_SerieDatos.Name = "lst_SerieDatos"
        Me.lst_SerieDatos.Size = New System.Drawing.Size(732, 329)
        Me.lst_SerieDatos.TabIndex = 0
        '
        'GraficoFrecuencias
        '
        Me.GraficoFrecuencias.Controls.Add(Me.Chart1)
        Me.GraficoFrecuencias.Location = New System.Drawing.Point(4, 22)
        Me.GraficoFrecuencias.Name = "GraficoFrecuencias"
        Me.GraficoFrecuencias.Padding = New System.Windows.Forms.Padding(3)
        Me.GraficoFrecuencias.Size = New System.Drawing.Size(661, 404)
        Me.GraficoFrecuencias.TabIndex = 0
        Me.GraficoFrecuencias.Text = "Grafico de Frecuencias"
        Me.GraficoFrecuencias.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(22, 6)
        Me.Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Observado"
        Series6.ChartArea = "ChartArea1"
        Series6.Legend = "Legend1"
        Series6.Name = "Esperado"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(555, 275)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TestChiCuadrado
        '
        Me.TestChiCuadrado.Controls.Add(Me.lblV)
        Me.TestChiCuadrado.Controls.Add(Me.dtgvChiCuadrado)
        Me.TestChiCuadrado.Location = New System.Drawing.Point(4, 22)
        Me.TestChiCuadrado.Name = "TestChiCuadrado"
        Me.TestChiCuadrado.Padding = New System.Windows.Forms.Padding(3)
        Me.TestChiCuadrado.Size = New System.Drawing.Size(661, 404)
        Me.TestChiCuadrado.TabIndex = 1
        Me.TestChiCuadrado.Text = "Test Chi Cuadrado"
        Me.TestChiCuadrado.UseVisualStyleBackColor = True
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(18, 12)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(93, 13)
        Me.lblV.TabIndex = 24
        Me.lblV.Text = "Grados de libertad"
        '
        'dtgvChiCuadrado
        '
        Me.dtgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvChiCuadrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Intervalo, Me.MarcaDeClase, Me.Observada, Me.Esperada, Me.xCuadradoI})
        Me.dtgvChiCuadrado.Location = New System.Drawing.Point(21, 28)
        Me.dtgvChiCuadrado.Name = "dtgvChiCuadrado"
        Me.dtgvChiCuadrado.Size = New System.Drawing.Size(551, 370)
        Me.dtgvChiCuadrado.TabIndex = 0
        '
        'Intervalo
        '
        Me.Intervalo.HeaderText = "Intervalo"
        Me.Intervalo.Name = "Intervalo"
        Me.Intervalo.ReadOnly = True
        '
        'MarcaDeClase
        '
        Me.MarcaDeClase.HeaderText = "Marca de Clase"
        Me.MarcaDeClase.Name = "MarcaDeClase"
        Me.MarcaDeClase.ReadOnly = True
        '
        'Observada
        '
        Me.Observada.HeaderText = "Observada"
        Me.Observada.Name = "Observada"
        Me.Observada.ReadOnly = True
        '
        'Esperada
        '
        Me.Esperada.HeaderText = "Frecuencia Esperada"
        Me.Esperada.Name = "Esperada"
        Me.Esperada.ReadOnly = True
        '
        'xCuadradoI
        '
        Me.xCuadradoI.HeaderText = "((Fo-Fe)^2)/Fe"
        Me.xCuadradoI.Name = "xCuadradoI"
        Me.xCuadradoI.ReadOnly = True
        '
        'dtgvKolmogorov
        '
        Me.dtgvKolmogorov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvKolmogorov.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column2})
        Me.dtgvKolmogorov.Location = New System.Drawing.Point(-7, 0)
        Me.dtgvKolmogorov.Name = "dtgvKolmogorov"
        Me.dtgvKolmogorov.Size = New System.Drawing.Size(773, 333)
        Me.dtgvKolmogorov.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dtgvKolmogorov)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(762, 404)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Test Kolmovorov"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Intervalo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fre Obs"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fre Obs Acum"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Prob Obs"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prob Obs Acum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prob Esp Acum"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "POA - PEA"
        Me.Column2.Name = "Column2"
        '
        'Punto2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 487)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.graficarBTN)
        Me.Controls.Add(Me.Ktxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Punto2"
        Me.Text = "Punto2"
        Me.TabControl1.ResumeLayout(False)
        Me.SerieDatos.ResumeLayout(False)
        Me.GraficoFrecuencias.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestChiCuadrado.ResumeLayout(False)
        Me.TestChiCuadrado.PerformLayout()
        CType(Me.dtgvChiCuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvKolmogorov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents graficarBTN As Button
    Friend WithEvents Ktxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SerieDatos As TabPage
    Friend WithEvents lst_SerieDatos As ListBox
    Friend WithEvents GraficoFrecuencias As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TestChiCuadrado As TabPage
    Friend WithEvents lblV As Label
    Friend WithEvents dtgvChiCuadrado As DataGridView
    Friend WithEvents Intervalo As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDeClase As DataGridViewTextBoxColumn
    Friend WithEvents Observada As DataGridViewTextBoxColumn
    Friend WithEvents Esperada As DataGridViewTextBoxColumn
    Friend WithEvents xCuadradoI As DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dtgvKolmogorov As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
