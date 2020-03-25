Public Class Recherche

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
                .Text = "Wilaya de naissance en Francais"
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

        ' fin initilize recherche form
    End Sub

End Class