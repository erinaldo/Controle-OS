Module AcaoExMi

        Public tmVelAnimacao As New Timer

        ''' <summary>
        ''' Animação para expandir dock´s
        ''' </summary>
        ''' <param name="Grupo">Group que será usado como dock</param>
        ''' <param name="Hmax">largura maxima para expansão</param>
        ''' <param name="Velocidade">Velocidade de animação do dock (miliseg.) Padrão 10000</param>
        Public Sub AnimacaoEx(Grupo As GroupBox, Hmax As Integer, Velocidade As Double)
                Grupo.BringToFront()
                tmVelAnimacao.Enabled = True
                tmVelAnimacao.Interval = Velocidade
                Do Until Grupo.Height >= Hmax
                        Grupo.Height = Grupo.Height + 4
                Loop
                tmVelAnimacao.Enabled = False
        End Sub

        ''' <summary>
        ''' Animação para minimizar dock´s
        ''' </summary>
        ''' <param name="Grupo">Group que será usado como dock</param>
        ''' <param name="Hmin">largura maxima para minimizar</param>
        ''' <param name="Velocidade">Velocidade de animação do dock (miliseg.)  Padrão 10000</param>
        Public Sub AnimacaoMin(Grupo As GroupBox, Hmin As Integer, Velocidade As Double)
                tmVelAnimacao.Enabled = True
                tmVelAnimacao.Interval = Velocidade
                Do Until Grupo.Height <= Hmin
                        Grupo.Height = Grupo.Height - 4
                Loop
                tmVelAnimacao.Enabled = False
        End Sub

End Module