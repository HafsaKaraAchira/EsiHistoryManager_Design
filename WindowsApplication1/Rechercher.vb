Public Class Rechercher

    Private dtp_changed As Boolean

    ' initialize the language button in the search form
    Private Sub ARButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARButton1.CheckedChanged
        If ARButton1.Checked Then
            With ARButton1
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With FRButton1
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard
            End With
            With LB_NOMA
                .Text = "Nom en Arabe"
            End With
            With LB_PRENOMA
                .Text = "Prenom en Arabe"
            End With

            With TXT_NOM
                .Enabled = False
                .Visible = False
            End With

            With TXT_NOMA
                .Enabled = True
                .Visible = True
            End With

            With TXT_PRENOM
                .Enabled = False
                .Visible = False
            End With

            With TXT_PRENOMA
                .Enabled = True
                .Visible = True
            End With
        Else
            With ARButton1
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard

            End With
            With FRButton1
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With LB_NOMA
                .Text = "Nom en Francais"
            End With
            With LB_PRENOMA
                .Text = "Prenom en Francais"
            End With

            With TXT_NOM
                .Enabled = True
                .Visible = True
            End With

            With TXT_NOMA
                .Enabled = False
                .Visible = False
            End With

            With TXT_PRENOM
                .Enabled = True
                .Visible = True
            End With

            With TXT_PRENOMA
                .Enabled = False
                .Visible = False
            End With

        End If
    End Sub


    Private Sub ARButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARButton2.CheckedChanged
        If ARButton2.Checked Then
            With ARButton2
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With FRButton2
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard
            End With
            With LB_LIEUNA
                .Text = "Lieu de naissance en Arabe"
            End With

            With TXT_LIEUN
                .Enabled = False
                .Visible = False
            End With

            With TXT_LIEUNA
                .Enabled = True
                .Visible = True
            End With

        Else
            With ARButton2
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard

            End With
            With FRButton2
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With LB_LIEUNA
                .Text = "Lieu de naissance en Francais"
            End With

            With TXT_LIEUN
                .Enabled = True
                .Visible = True
            End With

            With TXT_LIEUNA
                .Enabled = False
                .Visible = False
            End With

        End If
    End Sub

    Private Sub ARButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARButton3.CheckedChanged
        If ARButton3.Checked Then
            With ARButton3
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With FRButton3
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard
            End With
            With LB_WILAYANA
                .Text = "Wilaya de naissance en Arabe"
            End With

            With CB_WILAYAN
                .Enabled = False
                .Visible = False
            End With

            With CB_WILAYANA
                .Enabled = True
                .Visible = True
            End With

        Else
            With ARButton3
                .BackColor = Color.FromArgb(162, 119, 113)
                .FlatStyle = FlatStyle.Standard

            End With
            With FRButton3
                .BackColor = Color.FromArgb(0, 64, 104)
                .FlatStyle = FlatStyle.Popup
            End With
            With LB_WILAYANA
                .Text = "Code de Wilaya de naissance en Francais"
            End With

            With CB_WILAYAN
                .Enabled = True
                .Visible = True
            End With

            With CB_WILAYANA
                .Enabled = False
                .Visible = False
            End With

        End If
    End Sub

    'handle the residence caterorie label click
    Private Sub ResidenceLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResidenceLabel.Click
        SpliterMain.SplitterDistance = IIf(SplitContainer1.Panel2Collapsed, 330, 25)    'adjust the spliter distance
        SplitContainer1.Panel2Collapsed = Not SplitContainer1.Panel2Collapsed           'reverse the collapse state
        ResidenceLabel.ImageIndex = IIf(SplitContainer1.Panel2Collapsed, 0, 1)          'change the arrow image
        RechButtons.Location = New Point(25, RechButtons.Location.Y + IIf(SplitContainer1.Panel2Collapsed, -280, 280)) 'adjust the search button position
    End Sub

    'handle the residence caterorie label click
    Private Sub BACLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACLabel.Click
        SplitContainer2.Panel2Collapsed = Not SplitContainer2.Panel2Collapsed
        BACLabel.ImageIndex = IIf(SplitContainer2.Panel2Collapsed, 0, 1)
        RechButtons.Location = New Point(25, RechButtons.Location.Y + IIf(SplitContainer2.Panel2Collapsed, -170, 170))
        'RechButtons.Location = New Point(25, SplitContainer2.Panel2.ClientRectangle.Bottom)
    End Sub

    Private Sub recherche_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer

        'insialize the worning messages
        Me.worningrech.Visible = False
        Me.IMG_ALERTCODPOS.Visible = False
        Me.IMG_ALERTMAT.Visible = False
        Me.IMG_ALERTMOY.Visible = False
        Me.IMG_ALERTMTB.Visible = False

        'insialize the date time picker to not checked
        Me.dtp_changed = False

        ' initilize recherche form

        splitermain.splitterdistance = 25

        ' make the two containers collapse at the beginning
        With splitcontainer1
            .panel1collapsed = False
            .panel2collapsed = True
        End With

        With splitcontainer2
            .panel1collapsed = False
            .panel2collapsed = True
        End With
        ' make the arabic flanuge checked at the beggining
        RechButtons.Location = New System.Drawing.Point(25, 525)
        arbutton1.checked = True
        arbutton2.checked = True
        ARButton3.Checked = True

        Me.PN_FORUMRECH.Dock = DockStyle.Fill   ' dock the seach form in the parent container

        'inisialiser les wilayas combobox
        Dim wilaya() As String = {"Adrar", "Chlef", "Laghouat", "Oum El Bouaghi", "Batna", "Béjaïa", "Biskra", "Béchar", "Blida", "Bouira", "Tamanrasset", "Tébessa", "Tlemcen", "Tiaret", "Tizi Ouzou", "Alger", "Djelfa", "Jijel", "Sétif", "Saïda", "Skikda", "Sidi Bel Abbès", "Annaba", "Guelma", "Constantine", "Médéa", "Mostaganem", "M'Sila", "Mascara", "Ouargla", "Oran", "El Bayadh", "Illizi", "Bordj Bou Arreridj", "Boumerdès", "El Tarf", "Tindouf", "Tissemsilt", "El Oued", "Khenchela", "Souk Ahras", "Tipaza", "Mila", "Aïn Defla", "Naâma", "Aïn Témouchent", "Ghardaïa", "Relizane"}
        Dim wilayaarabe() As String = {"أدرار", "الشلف", "الأغواط", "أم البواقي", "باتنة", "بجاية", "بسكرة", "بشار", "البليدة", "البويرة", "تمنراست", "تبسة", "تلمسان", "تيارت", "تيزي وزو", "الجزائر العاصمة", "الجلفة", "جيجل", "سطيف", "سعيدة", "سكيكدة", "سيدي بلعباس", "عنابة", "قالمة", "قسنطينة", "المدية", "مستغانم", "المسيلة", "معسكر", "ورقلة", "وهران", "البيض", "إليزي", "برج بوعريريج", "بومرداس", "الطارف", "تندوف", "تيسمسيلت", "الوادي", "خنشلة", "سوق أهراس", "تيبازة", "ميلة", "عين الدفلى", "النعامة", "عين تموشنت", "غرداية", "غليزان"}

        For i = 0 To wilaya.Length - 1
            Me.CB_WILAYAN.Items.Add(i)
            Me.CB_WILAYANA.Items.Add(wilayaarabe(i))
            Me.CB_WILAYAB.Items.Add(wilaya(i))
            Me.CB_WILAYA.Items.Add(wilaya(i))
        Next

        'inisialize sexe combobox 
        Dim sexe() As String = {"Homme", "Femme", "Autre"}

        For i = 0 To sexe.Length - 1
            Me.CB_SEXE.Items.Add(sexe(i))
        Next

        'inisialize seri de bac combobox 

        Dim seribac() As String = {"000", "G00", "0G0", "G04", "G05", "G06", "G07", "G08", "G17", "GO5", "(vides)"}

        For i = 0 To seribac.Length - 1
            Me.CB_SERI.Items.Add(seribac(i))
        Next

        'inisialize annee de bac combobox 

        For i = 1989 To 2011
            Me.CB_ANNEEB.Items.Add(i)
        Next

        ' fin initilize recherche form
    End Sub

    Private Sub BT_LANCERRECH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LANCERRECH.Click

        Dim i As Integer

        If Me.TXT_ADR.Text = "" And Me.TXT_CODEPOS.Text = "" And Me.TXT_LIEUN.Text = "" And Me.TXT_LIEUNA.Text = "" And Me.TXT_MATRICUL.Text = "" And Me.TXT_MATRICULB.Text = "" And Me.TXT_MOYBAC.Text = "" And Me.TXT_NOM.Text = "" And Me.TXT_NOMA.Text = "" And Me.TXT_PRENOM.Text = "" And Me.TXT_PRENOMA.Text = "" And Me.TXT_VILLE.Text = "" And Me.CB_ANNEEB.Text = "" And Me.CB_SERI.Text = "" And Me.CB_SEXE.Text = "" And Me.CB_WILAYA.Text = "" And Me.CB_WILAYAB.Text = "" And Me.CB_WILAYAN.Text = "" And Me.CB_WILAYANA.Text = "" And Me.dtp_changed = False Then
            Me.worningrech.Visible = True
            Me.worningrech.Text = "Vous devez remplir en mois un champs !"
        Else
            If Me.TXT_MATRICUL.Text <> "" Then
                i = 0
                While i < TXT_MATRICUL.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MATRICUL.Text(i) > "9" Or Me.TXT_MATRICUL.Text(i) < "0" Then
                        Me.worningrech.Visible = True
                        Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                        Me.IMG_ALERTMAT.Visible = True
                    End If
                    i = i + 1
                End While
            End If

            If Me.TXT_MATRICULB.Text <> "" Then
                i = 0
                While i < TXT_MATRICULB.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MATRICULB.Text(i) > "9" Or Me.TXT_MATRICULB.Text(i) < "0" Then
                        Me.worningrech.Visible = True
                        Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                        Me.IMG_ALERTMTB.Visible = True
                    End If
                    i = i + 1
                End While
            End If

            If Me.TXT_MOYBAC.Text <> "" Then
                i = 0
                While i < TXT_MOYBAC.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_MOYBAC.Text(i) > "9" Or Me.TXT_MOYBAC.Text(i) < "0" Then
                        Me.worningrech.Visible = True
                        Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                        Me.IMG_ALERTMOY.Visible = True
                    End If
                    i = i + 1
                End While
            End If

            If Me.TXT_CODEPOS.Text <> "" Then
                i = 0
                While i < TXT_CODEPOS.Text.Length And Me.worningrech.Visible = False
                    If Me.TXT_CODEPOS.Text(i) > "9" Or Me.TXT_CODEPOS.Text(i) < "0" Then
                        Me.worningrech.Visible = True
                        Me.worningrech.Text = "Vous devez remplir les champs correctement !"
                        Me.IMG_ALERTCODPOS.Visible = True
                    End If
                    i = i + 1
                End While
            End If

            'filling la collections des crietere

            Dim collection_critere As New List(Of Critere)

            If (Me.worningrech.Visible = False And Me.IMG_ALERTCODPOS.Visible = False And Me.IMG_ALERTMOY.Visible = False And Me.IMG_ALERTMTB.Visible = False And Me.IMG_ALERTMAT.Visible = False) Then

                If Me.TXT_NOM.Text <> "" Then
                    collection_critere.Add(New Critere("NomEtud", Me.TXT_NOM.Text))
                End If

                If Me.TXT_NOMA.Text <> "" Then
                    collection_critere.Add(New Critere("NomEtudA", Me.TXT_NOMA.Text))
                End If

                If Me.TXT_PRENOM.Text <> "" Then
                    collection_critere.Add(New Critere("Prenoms", Me.TXT_PRENOM.Text))
                End If

                If Me.TXT_MATRICULB.Text <> "" Then
                    collection_critere.Add(New Critere("MATRIC_INS", Me.TXT_MATRICULB.Text))
                End If

                If Me.TXT_MATRICUL.Text <> "" Then
                    collection_critere.Add(New Critere("MATRIN", Me.TXT_MATRICUL.Text))
                End If

                If dtp_changed = True Then
                    Label1.Text = Me.DTP_DATEN.Text
                    collection_critere.Add(New Critere("DateNais", Me.DTP_DATEN.Text))
                End If

                If Me.TXT_LIEUNA.Text <> "" Then
                    collection_critere.Add(New Critere("LieuNaisA", Me.TXT_LIEUNA.Text))
                End If

                If Me.TXT_LIEUN.Text <> "" Then
                    collection_critere.Add(New Critere("LieuNais", Me.TXT_LIEUN.Text))
                End If

                If Me.CB_WILAYANA.Text <> "" Then
                    collection_critere.Add(New Critere("WilayaNaisA", Me.CB_WILAYANA.Text))
                End If

                If Me.CB_WILAYAN.Text <> "" Then
                    collection_critere.Add(New Critere("WILNAIS", Me.CB_WILAYAN.Text))
                End If

                If Me.TXT_ADR.Text <> "" Then
                    collection_critere.Add(New Critere("ADRESSE", Me.TXT_ADR.Text))
                End If

                If Me.TXT_VILLE.Text <> "" Then
                    collection_critere.Add(New Critere("VILLE", Me.TXT_VILLE.Text))
                End If

                If Me.CB_WILAYA.Text <> "" Then
                    collection_critere.Add(New Critere("WILAYA", Me.CB_WILAYA.Text))
                End If

                If Me.TXT_CODEPOS.Text <> "" Then
                    collection_critere.Add(New Critere("CODEPOS", Me.TXT_CODEPOS.Text))
                End If

                If Me.CB_SEXE.Text <> "" Then
                    collection_critere.Add(New Critere("SEXE", Me.CB_SEXE.Text))
                End If

                If Me.CB_SERI.Text <> "" Then
                    collection_critere.Add(New Critere("SERIEBAC", Me.CB_SERI.Text))
                End If

                If Me.TXT_MOYBAC.Text <> "" Then
                    collection_critere.Add(New Critere("MOYBAC", Me.TXT_MOYBAC.Text))
                End If

                If Me.CB_ANNEEB.Text <> "" Then
                    collection_critere.Add(New Critere("ANNEEBAC", Me.CB_ANNEEB.Text))
                End If

            End If

            ' appel a traite rechercher



        End If
            'Me.Close()
    End Sub

    Private Sub DTP_DATEN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_DATEN.ValueChanged, DTP_DATEN.GotFocus, DTP_DATEN.Click
        Me.dtp_changed = True
    End Sub

    Private Sub TXT_LIEUN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUN.GotFocus, TXT_LIEUN.TextChanged, TXT_LIEUN.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MATRICUL_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRICUL.GotFocus, TXT_MATRICUL.TextChanged, TXT_MATRICUL.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMAT.Visible = False
    End Sub

    Private Sub TXT_LIEUNA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LIEUNA.GotFocus, TXT_LIEUNA.TextChanged, TXT_LIEUNA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MATRICULB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MATRICULB.GotFocus, TXT_MATRICULB.TextChanged, TXT_MATRICULB.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMTB.Visible = False
    End Sub

    Private Sub TXT_NOM_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOM.GotFocus, TXT_NOM.TextChanged, TXT_NOM.Click
        Me.worningrech.Visible = False
    End Sub


    Private Sub TXT_PRENOM_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.GotFocus, TXT_PRENOM.TextChanged, TXT_PRENOM.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_NOMA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_NOMA.GotFocus, TXT_NOMA.TextChanged, TXT_NOMA.Click
        Me.worningrech.Visible = False
    End Sub


    Private Sub TXT_PRENOMA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOMA.GotFocus, TXT_PRENOMA.TextChanged, TXT_PRENOMA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_SEXE_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SEXE.GotFocus, CB_SEXE.TextChanged, CB_SEXE.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYANA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYANA.GotFocus, CB_WILAYANA.TextChanged, CB_WILAYANA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYAN_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAN.GotFocus, CB_WILAYAN.TextChanged, CB_WILAYAN.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_ADR_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ADR.GotFocus, TXT_ADR.TextChanged, TXT_ADR.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_VILLE_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VILLE.GotFocus, TXT_VILLE.TextChanged, TXT_VILLE.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_WILAYA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYA.GotFocus, CB_WILAYA.TextChanged, CB_WILAYA.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_CODEPOS_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CODEPOS.GotFocus, TXT_CODEPOS.TextChanged, TXT_CODEPOS.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTCODPOS.Visible = False
    End Sub

    Private Sub CB_WILAYAB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_WILAYAB.GotFocus, CB_WILAYAB.TextChanged, CB_WILAYAB.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub TXT_MOYBAC_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MOYBAC.GotFocus, TXT_MOYBAC.TextChanged, TXT_MOYBAC.Click
        Me.worningrech.Visible = False
        Me.IMG_ALERTMOY.Visible = False
    End Sub

    Private Sub CB_SERI_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SERI.GotFocus, CB_SERI.TextChanged, CB_SERI.Click
        Me.worningrech.Visible = False
    End Sub

    Private Sub CB_ANNEEB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_ANNEEB.GotFocus, CB_ANNEEB.TextChanged, CB_ANNEEB.Click
        Me.worningrech.Visible = False
    End Sub

End Class