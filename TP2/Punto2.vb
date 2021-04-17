Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Punto2

    Dim count As Integer = 0
    Dim sum As Integer = 0
    Dim media_intervalo As Double
    Dim fileReader
    Dim lista_alturas As New List(Of Double)
    Dim k As Integer
    Dim intervalos As Double
    Dim media As Double
    Dim var As Double
    Dim desv As Double
    Dim acum_dif_media As Double
    Dim probObs As Double
    Dim frecuenciaObsAcumulada As Integer
    Dim probObsAcum As Double
    Dim probEsperada As Double
    Dim probEspAcum As Double
    Dim fe As Double 'esperada
    Dim marca_clase As Double
    Dim acum As Double
    Dim xCuadradoCalculado As Double = 0 '
    Dim xCuadrado As Double

    Public listaChipcuadrada() As String = {"3,84", "5,99", "7,81", "9,49", "11,14", "12,6", "14,1", "15,5", "16,9", "18,3", "19,7", "21,0", "22,4", "23,7", "25,0", "26.3", "26,3",
                            "27,6", "28,9", "30,1", "31,4", "32,7", "33.9", "35,2", "36,4", "37,7", "38,9", "40,1", "41,3", "42,6", "43,8", "", "", "", "", "", "", "", "", "", "55,8",
                            "", "", "", "", "", "", "", "", "", "67,5", "", "", "", "", "", "", "", "", "", "79,1", "", "", "", "", "", "", "", "", "", "90,5", "", "", "", "", "", "",
                            "", "", "", "101,9", "", "", "", "", "", "", "", "", "", "113,1", "", "", "", "", "", "", "", "", "", "124,3"}

    Private Function valdacion() As Boolean
        Dim validacion As Boolean

        If (Ktxt.Text = "" Or Ktxt.Text = "") Then
            validacion = False
        Else
            validacion = True
        End If
        Return validacion
    End Function

    Private Sub graficarBTN_Click(sender As Object, e As EventArgs) Handles graficarBTN.Click
        Dim fila As Integer = 0
        Dim fila1 As Integer = 0
        probObs = 0
        probObsAcum = 0
        probEsperada = 0
        probEspAcum = 0
        frecuenciaObsAcumulada = 0

        If valdacion() = False Then
            MsgBox("Por favor ingrese todos los valores solicitados")
        Else
            k = Ktxt.Text ''numero de intervalos 
            fileReader = File.OpenText("C:\Users\Martin\Downloads\TP2_Constantini, Loza, Micheletti, Soaje (1)\TP2_Constantini, Loza, Micheletti, Soaje\Altura_Sudeste_Asia.txt")

            While fileReader.Peek <> -1
                Dim altura As Double
                altura = fileReader.ReadLine()

                lista_alturas.Add(altura)

            End While
            Dim listaValores(k - 1) As Double
            intervalos = (DeterminarMayor(lista_alturas) - DeterminarMenor(lista_alturas)) / k

            intervalos = Math.Round(intervalos, 4) + 0.001

            For i As Double = DeterminarMenor(lista_alturas) To DeterminarMayor(lista_alturas) Step intervalos
                sum = 0
                acum_dif_media = 0
                acum = 0
                For count = 0 To (lista_alturas.Count - 1) ''iteramos desde 0 hasta la cantidad de muestras solicitadas
                    If i <= lista_alturas(count) Then ''si el numero pseudo-aleaotrio es mayor que el limite inferior del intervalo 
                        If lista_alturas(count) < (i + intervalos) Then ''y menor que el limite superior del intervalo
                            sum = sum + 1 ''incremento de la frecuencia de aparicion en dicho intervalo
                        End If
                    End If
                    acum = acum + lista_alturas(count)
                    sum = Math.Round(sum, 4)
                    i = Math.Round(i, 4)
                Next count

                frecuenciaObsAcumulada = Math.Round(frecuenciaObsAcumulada + sum, 4)
                media = acum / lista_alturas.Count

                probObs = sum / lista_alturas.Count ''probabilidad observada de cada intevalo
                probObsAcum = Math.Round(probObsAcum + probObs, 4) ''probabilidad observada
                probEsperada = (lista_alturas.Count / k) / lista_alturas.Count
                probEspAcum = Math.Round((probEspAcum + probEsperada), 4)
                For count = 0 To (lista_alturas.Count - 1)
                    Dim diff As Double = 0

                    diff = Math.Pow((lista_alturas(count) - media), 2)
                    diff = Math.Round(diff, 4)

                    acum_dif_media = acum_dif_media + diff

                Next

                var = acum_dif_media / lista_alturas.Count
                desv = Math.Sqrt(var)


                marca_clase = (i + (i + intervalos)) / 2

                Dim numerador As Double = 0
                Dim denominador As Double = 0
                Dim exponente As Double = 0

                exponente = ((marca_clase - media) / desv) ^ 2

                exponente = -0.5 * exponente

                exponente = Math.Round(exponente, 4)

                numerador = Math.Pow(Math.E, exponente)

                denominador = (desv * Math.Sqrt(2 * Math.PI))

                fe = (numerador / denominador) * intervalos * lista_alturas.Count

                fe = Math.Round(fe, 4)
                Chart1.Series("Observado").Points.AddXY((i + intervalos), sum)
                Chart1.Series("Esperado").Points.AddXY((i + intervalos), fe)


                dtgvChiCuadrado.Rows.Add() ''agregamos una fila por cada ciclo
                dtgvChiCuadrado.Rows((fila)).Cells(0).Value = i.ToString() + " - " + (i + intervalos).ToString ''agregamos el rango del intervalo a la grilla
                dtgvChiCuadrado.Rows((fila)).Cells(1).Value = marca_clase.ToString
                dtgvChiCuadrado.Rows((fila)).Cells(2).Value = sum.ToString ''agregamos la frecuencia observada
                dtgvChiCuadrado.Rows((fila)).Cells(3).Value = fe.ToString ''agregamos la frecuencia observada

                xCuadrado = Math.Round((Math.Pow(sum - fe, 2)) / fe, 4)
                dtgvChiCuadrado.Rows((fila)).Cells(4).Value = xCuadrado

                xCuadradoCalculado = xCuadradoCalculado + xCuadrado

                fila = fila + 1
                fe = 0

                'SMIRNOV-KLMOGOROV 
                dtgvKolmogorov.Rows.Add() ''agregamos una fila por cada ciclo
                dtgvKolmogorov.Rows((fila1)).Cells(0).Value = i.ToString() + " - " + (i + intervalos).ToString ''agregamos los intervalos
                dtgvKolmogorov.Rows((fila1)).Cells(1).Value = sum.ToString ''agregamos la frecuencia observada
                dtgvKolmogorov.Rows((fila1)).Cells(2).Value = frecuenciaObsAcumulada.ToString ''agregamos la frecuencia acumulada
                dtgvKolmogorov.Rows((fila1)).Cells(3).Value = probObs.ToString '' agregamos la probabilidad observada de ese intevalo
                dtgvKolmogorov.Rows((fila1)).Cells(4).Value = probObsAcum.ToString '' agregamos la probabilidad acumulada
                dtgvKolmogorov.Rows((fila1)).Cells(5).Value = probEspAcum.ToString '' agregamos la probabilidad esperada acumulada
                Dim valorAbsoluto As Double
                valorAbsoluto = Math.Round(Math.Abs(probObsAcum - probEspAcum), 2)
                dtgvKolmogorov.Rows((fila1)).Cells(6).Value = valorAbsoluto.ToString
                listaValores(fila1) = valorAbsoluto
                fila1 = fila1 + 1



            Next



            lst_SerieDatos.DataSource = lista_alturas

            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila)).Cells(3).Value = "Xi Cuadrado calculado"
            dtgvChiCuadrado.Rows((fila)).Cells(4).Value = xCuadradoCalculado.ToString ''agregamos el xi cuadrado a la grilla

            lblV.Text = "Grados de libertad: " + (k - 1).ToString
            dtgvChiCuadrado.Rows.Add()
            dtgvChiCuadrado.Rows((fila + 1)).Cells(3).Value = "Xi cudrado Tabulado"

            Dim xiTabulado As String = listaChipcuadrada(k - 2).ToString()

            If xiTabulado Is "" Then ''si la posicion del vector no tiene valores, cambia el string xiTabulado
                xiTabulado = "No hay valores para esos grados de libertad"
                dtgvChiCuadrado.Rows((fila + 1)).Cells(4).Value = xiTabulado.ToString
            Else
                dtgvChiCuadrado.Rows((fila + 1)).Cells(4).Value = xiTabulado.ToString

                '' Valida que la muestra provenga de una distribución uniforme

                If Convert.ToDouble(xiTabulado.ToString) > xCuadradoCalculado Then
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(2).Value = "No Rechazado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(2).Style.BackColor = Color.Green
                Else
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(2).Value = "Rechazado"
                    dtgvChiCuadrado.Rows((fila + 1)).Cells(2).Style.BackColor = Color.Red
                End If
            End If

            ''prueba de kolmogorov parte final
            Dim mayor As Double '' mayor valor de la diferencia POA Y PEA
            mayor = 0
            For j = 0 To (k - 1)
                mayor = Math.Max(mayor, listaValores(j)) ''busco el mayor valor 
            Next

            Dim testKolmogorov As Double
            ''
            testKolmogorov = 1.36 / Math.Sqrt(lista_alturas.Count) '' 1/raizcuadrada(n) ---> nivel de significación de alfa 0.05
            dtgvKolmogorov.Rows.Add()
            dtgvKolmogorov.Rows((fila1)).Cells(3).Value = "Valor calculado"
            dtgvKolmogorov.Rows((fila1)).Cells(4).Value = mayor.ToString ''agregamos el valor calculado a la grilla

            dtgvKolmogorov.Rows.Add()
            dtgvKolmogorov.Rows((fila1 + 1)).Cells(3).Value = "Valor Tabulado"
            dtgvKolmogorov.Rows((fila1 + 1)).Cells(4).Value = testKolmogorov.ToString ''agregamos el valor tabulado a la grilla
            If testKolmogorov > mayor Then
                dtgvKolmogorov.Rows((fila1 + 1)).Cells(2).Value = "Aceptado"
                dtgvKolmogorov.Rows((fila1 + 1)).Cells(2).Style.BackColor = Color.Green
            Else
                dtgvKolmogorov.Rows((fila1 + 1)).Cells(2).Value = "Rechazado"
                dtgvKolmogorov.Rows((fila1 + 1)).Cells(2).Style.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Function DeterminarMayor(ByVal lista As List(Of Double)) As Double
        Dim mayor As Double


        For i As Integer = 0 To lista.Count - 1
            If i = 0 Then
                mayor = lista(i)

            Else
                If lista(i) > mayor Then
                    mayor = lista(i)
                End If

            End If


        Next

        Return mayor



    End Function

    Private Function DeterminarMenor(ByVal lista As List(Of Double)) As Double
        Dim menor As Double


        For i As Integer = 0 To lista.Count - 1
            If i = 0 Then
                menor = lista(i)

            Else
                If lista(i) < menor Then
                    menor = lista(i)
                End If

            End If


        Next

        Return menor



    End Function

    Private Sub Punto1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Ktxt.Text = ""
        lst_SerieDatos.DataSource = Nothing
        lst_SerieDatos.Show()
        dtgvChiCuadrado.Rows.Clear()
        lblV.Text = ""
        graficarBTN.Enabled = True
    End Sub
End Class