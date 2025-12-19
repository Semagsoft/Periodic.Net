Class MainWindow

#Region "Reusable code"

    Private Sub ShowElementWindow(title As String, info As String)
        Dim window As New ElementWindow(title, info)
        window.Owner = Me
        window.WindowStartupLocation = Windows.WindowStartupLocation.CenterOwner
        window.ShowDialog()
    End Sub

#End Region

#Region "MainWindow"

    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If My.Computer.Keyboard.CtrlKeyDown Then
            If e.Key = Key.M Then
                MenuMenuItem_Click(Nothing, Nothing)
            ElseIf e.Key = Key.P Then
                PrintMenuItem_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        If My.Computer.Info.OSVersion >= "6.0" Then
            AppHelper.ExtendGlassFrame(Me, New Thickness(-1, -1, -1, -1))
        End If
        Left = My.Settings.MainWindow_Loc.X
        Top = My.Settings.MainWindow_Loc.Y
        If My.Settings.MainWindow_ShowMenu Then
            MenuMenuItem.IsChecked = True
        Else
            MenuMenuItem.IsChecked = False
            MainMenu.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim loc As New System.Drawing.Point(Left, Top)
        My.Settings.MainWindow_Loc = loc
        My.Settings.MainWindow_ShowMenu = MenuMenuItem.IsChecked
        My.Settings.Save()
    End Sub

#End Region

#Region "MainMenu"

#Region "File"

    Private Sub PrintMenuItem_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles PrintMenuItem.Click
        Dim print As New PrintDialog
        If print.ShowDialog Then
            print.PrintVisual(Me, "Periodic.Net")
        End If
        Focus()
    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles ExitMenuItem.Click
        Close()
    End Sub

#End Region

#Region "View"

    Private Sub MenuMenuItem_Click(sender As Object, e As RoutedEventArgs) Handles MenuMenuItem.Click
        If MenuMenuItem.IsChecked Then
            MenuMenuItem.IsChecked = False
            MainMenu.Visibility = Windows.Visibility.Collapsed
        Else
            MenuMenuItem.IsChecked = True
            MainMenu.Visibility = Windows.Visibility.Visible
        End If
    End Sub

#End Region

#Region "Help"

    Private Sub OnlineHelpMenuItem_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles OnlineHelpMenuItem.Click
        Process.Start("http://periodic.codeplex.com")
    End Sub

    Private Sub WebsiteMenuItem_Click(sender As Object, e As RoutedEventArgs) Handles WebsiteMenuItem.Click
        Process.Start("http://semagsoft.com")
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles AboutMenuItem.Click
        Dim about As New AboutDialog
        about.Owner = Me
        about.ShowDialog()
    End Sub

#End Region

#End Region

#Region "Elements"

    Private Sub HydrogenButton_Click(sender As Object, e As RoutedEventArgs) Handles HydrogenButton.Click
        ShowElementWindow("Hydrogen", "Hydrogen is a chemical element with symbol H and atomic number 1. With an atomic weight of 1.00794 u (1.007825 u for hydrogen-1), hydrogen is the lightest element and its monatomic form (H1) is the most abundant chemical substance, constituting roughly 75% of the Universe's baryonic mass. Non-remnant stars are mainly composed of hydrogen in its plasma state.")
    End Sub

    Private Sub HeliumButton_Click(sender As Object, e As RoutedEventArgs) Handles HeliumButton.Click
        ShowElementWindow("Helium", "Helium is a chemical element with symbol He and atomic number 2. It is a colorless, odorless, tasteless, non-toxic, inert, monatomic gas that heads the noble gas group in the periodic table. Its boiling and melting points are the lowest among the elements and it exists only as a gas except in extreme conditions.")
    End Sub

    Private Sub LithiumButton_Click(sender As Object, e As RoutedEventArgs) Handles LithiumButton.Click
        ShowElementWindow("Lithium", "Lithium (from Greek lithos 'stone') is a soft, silver-white metal with symbol Li and atomic number 3. It belongs to the alkali metal group of chemical elements. Under standard conditions it is the lightest metal and the least dense solid element. Like all alkali metals, lithium is highly reactive and flammable. For this reason, it is typically stored in mineral oil. When cut open, lithium exhibits a metallic luster, but contact with moist air corrodes the surface quickly to a dull silvery gray, then black tarnish. Because of its high reactivity, lithium never occurs freely in nature, and instead, only appears in compounds, which are usually ionic. Lithium occurs in a number of pegmatitic minerals, but due to its solubility as an ion is present in ocean water and is commonly obtained from brines and clays. On a commercial scale, lithium is isolated electrolytically from a mixture of lithium chloride and potassium chloride.")
    End Sub

    Private Sub BerylliumButton_Click(sender As Object, e As RoutedEventArgs) Handles BerylliumButton.Click
        ShowElementWindow("Beryllium", "Beryllium is the chemical element with the symbol Be and atomic number 4. Because any beryllium synthesized in stars is short-lived, it is a relatively rare element in both the universe and in the crust of the Earth. It is a divalent element which occurs naturally only in combination with other elements in minerals. Notable gemstones which contain beryllium include beryl (aquamarine, emerald) and chrysoberyl. As a free element it is a steel-gray, strong, lightweight and brittle alkaline earth metal.")
    End Sub

    Private Sub BoronButton_Click(sender As Object, e As RoutedEventArgs) Handles BoronButton.Click
        ShowElementWindow("Boron", "Boron is a chemical element with chemical symbol B and atomic number 5. Because boron is produced entirely by cosmic ray spallation and not by stellar nucleosynthesis, it is a low-abundance element in both the solar system and the Earth's crust. Boron is concentrated on Earth by the water-solubility of its more common naturally occurring compounds, the borate minerals. These are mined industrially as evaporites, such as borax and kernite.")
    End Sub

    Private Sub CarbonButton_Click(sender As Object, e As RoutedEventArgs) Handles CarbonButton.Click
        ShowElementWindow("Carbon", "Carbon (from Latin: carbo coal) is the chemical element with symbol C and atomic number 6. As a member of group 14 on the periodic table, it is nonmetallic and tetravalent—making four electrons available to form covalent chemical bonds. There are three naturally occurring isotopes, with 12C and 13C being stable, while 14C is radioactive, decaying with a half-life of about 5,730 years. Carbon is one of the few elements known since antiquity.")
    End Sub

    Private Sub NitrogenButton_Click(sender As Object, e As RoutedEventArgs) Handles NitrogenButton.Click
        ShowElementWindow("Nitrogen", "Nitrogen is a chemical element with symbol N and atomic number 7. Elemental nitrogen is a colorless, odorless, tasteless, and mostly inert diatomic gas at standard conditions, constituting 78.09% by volume of Earth's atmosphere. The element nitrogen was discovered as a separable component of air, by Scottish physician Daniel Rutherford, in 1772. It belongs to the pnictogen family.")
    End Sub

    Private Sub OxygenButton_Click(sender As Object, e As RoutedEventArgs) Handles OxygenButton.Click
        ShowElementWindow("Oxygen", "Oxygen is a chemical element with symbol O and atomic number 8. Its name derives from the Greek roots ὀξύς (oxys) (acid, literally sharp, referring to the sour taste of acids) and -γόνος (-gοnos) (producer, literally begetter), because at the time of naming, it was mistakenly thought that all acids required oxygen in their composition. At standard temperature and pressure, two atoms of the element bind to form dioxygen, a colorless, odorless, tasteless diatomic gas with the formula O2. This substance is an important part of the atmosphere, and is necessary to sustain most terrestrial life.")
    End Sub

    Private Sub FluorineButton_Click(sender As Object, e As RoutedEventArgs) Handles FluorineButton.Click
        ShowElementWindow("Fluorine", "Fluorine (symbol F) is the chemical element with atomic number 9. It is the lightest halogen. At standard pressure and temperature, fluorine is a pale yellow gas composed of diatomic molecules, F2. Fluorine is the most electronegative element and is extremely reactive, requiring great care in handling. It has a single stable isotope, fluorine-19.")
    End Sub

    Private Sub NeonButton_Click(sender As Object, e As RoutedEventArgs) Handles NeonButton.Click
        ShowElementWindow("Neon", "Neon is a chemical element with symbol Ne and atomic number 10. It is in group 18 (noble gases) of the periodic table. Neon is a colorless, odorless monatomic gas under standard conditions, with about two-thirds the density of air. It was discovered (along with krypton and xenon) in 1898 as one of the three residual rare inert elements remaining in dry air, after nitrogen, oxygen, argon and carbon dioxide are removed. Neon was the second of these three rare gases to be discovered, and was immediately recognized as a new element from its bright red emission spectrum. Neon's name is derived from Greek words meaning new one. Neon is chemically inert and forms no uncharged chemical compounds.")
    End Sub

    Private Sub SodiumButton_Click(sender As Object, e As RoutedEventArgs) Handles SodiumButton.Click
        ShowElementWindow("Sodium", "Sodium is a chemical element with the symbol Na (from Latin: natrium) in the periodic table and atomic number 11. It is a soft, silvery-white, highly reactive metal and is a member of the alkali metals; its only stable isotope is 23Na. The free metal does not occur in nature, but instead must be prepared from its compounds; it was first isolated by Humphry Davy in 1807 by the electrolysis of sodium hydroxide. Sodium is the sixth most abundant element in the Earth's crust, and exists in numerous minerals such as feldspars, sodalite and rock salt. Many salts of sodium are highly water-soluble, and their sodium has been leached by the action of water so that chloride and sodium are the most common dissolved elements by weight in the Earth's bodies of oceanic water.")
    End Sub

    Private Sub MagnesiumButton_Click(sender As Object, e As RoutedEventArgs) Handles MagnesiumButton.Click
        ShowElementWindow("Magnesium", "Magnesium is a chemical element with symbol Mg and atomic number 12. Its common oxidation number is +2. It is an alkaline earth metal and the eighth most abundant element in the Earth's crust and ninth in the known universe as a whole. Magnesium is the fourth most common element in the Earth as a whole (behind iron, oxygen and silicon), making up 13% of the planet's mass and a large fraction of the planet's mantle. The relative abundance of magnesium is related to the fact that it is easily built up in supernova stars from a sequential addition of three helium nuclei to carbon (which in turn is made from three helium nuclei). Due to magnesium ion's high solubility in water, it is the third most abundant element dissolved in seawater.")
    End Sub

    Private Sub AluminiumButton_Click(sender As Object, e As RoutedEventArgs) Handles AluminiumButton.Click
        ShowElementWindow("Aluminium", "Aluminium (or aluminum) is a chemical element in the boron group with symbol Al and atomic number 13. It is silvery white, and it is not soluble in water under normal circumstances.")
    End Sub

    Private Sub SiliconButton_Click(sender As Object, e As RoutedEventArgs) Handles SiliconButton.Click
        ShowElementWindow("Silicon", "Silicon, a tetravalent metalloid, is a chemical element with the symbol Si and atomic number 14. It is less reactive than its chemical analog carbon, the nonmetal directly above it in the periodic table, but more reactive than germanium, the metalloid directly below it in the table. Controversy about silicon's character dates to its discovery: silicon was first prepared and characterized in pure form in 1824, and given the name silicium (from Latin: silicis, flints), with an -ium word-ending to suggest a metal, a name which the element retains in several non-English languages. However, its final English name, suggested in 1831, reflects the more physically similar elements carbon and boron.")
    End Sub

    Private Sub PhosphorusButton_Click(sender As Object, e As RoutedEventArgs) Handles PhosphorusButton.Click
        ShowElementWindow("Phosphorus", "Phosphorus is a chemical element with symbol P and atomic number 15. A multivalent nonmetal of the nitrogen group, phosphorus as a mineral is almost always present in its maximally oxidised state, as inorganic phosphate rocks. Elemental phosphorus exists in two major forms—white phosphorus and red phosphorus—but due to its high reactivity, phosphorus is never found as a free element on Earth.")
    End Sub

    Private Sub SulfurButton_Click(sender As Object, e As RoutedEventArgs) Handles SulfurButton.Click
        ShowElementWindow("Sulfur", "Sulfur or sulphur (British English; see spelling below) is a chemical element with symbol S and atomic number 16. It is an abundant, multivalent non-metal. Under normal conditions, sulfur atoms form cyclic octatomic molecules with chemical formula S8. Elemental sulfur is a bright yellow crystalline solid when at room temperature. Chemically, sulfur can react as either an oxidant or reducing agent. It oxidizes most metals and several nonmetals, including carbon, which leads to its negative charge in most organosulfur compounds, but it reduces several strong oxidants, such as oxygen and fluorine.")
    End Sub

    Private Sub ChlorineButton_Click(sender As Object, e As RoutedEventArgs) Handles ChlorineButton.Click
        ShowElementWindow("Chlorine", "Chlorine is a chemical element with symbol Cl and atomic number 17. Chlorine is in the halogen group (17) and is the second lightest halogen after fluorine. The element is a yellow-green gas under standard conditions, where it forms diatomic molecules. It has the highest electron affinity and the third highest electronegativity of all the elements; for this reason, chlorine is a strong oxidizing agent. Free chlorine is rare on Earth, and is usually a result of direct or indirect oxidation by oxygen.")
    End Sub

    Private Sub ArgonButton_Click(sender As Object, e As RoutedEventArgs) Handles ArgonButton.Click
        ShowElementWindow("Argon", "Argon is a chemical element with symbol Ar and atomic number 18. It is in group 18 (noble gases) of the periodic table. Argon is the third most common gas in the Earth's atmosphere, at 0.93% (9,300 ppm), making it approximately 23.8 times as abundant as next most common atmospheric gas, carbon dioxide (390 ppm), and more than 500 times as abundant as the next most common noble gas, neon (18 ppm). Nearly all of this argon is radiogenic argon-40 derived from the decay of potassium-40 in the Earth's crust. In the universe, argon-36 is by far the most common argon isotope, being the preferred argon isotope produced by stellar nucleosynthesis in supernovas.")
    End Sub

    Private Sub PotassiumButton_Click(sender As Object, e As RoutedEventArgs) Handles PotassiumButton.Click
        ShowElementWindow("Potassium", "Potassium is a chemical element with symbol K (from Neo-Latin kalium) and atomic number 19. Elemental potassium is a soft silvery-white alkali metal that oxidizes rapidly in air and is very reactive with water, generating sufficient heat to ignite the hydrogen emitted in the reaction.")
    End Sub

    Private Sub CalciumButton_Click(sender As Object, e As RoutedEventArgs) Handles CalciumButton.Click
        ShowElementWindow("Calcium", "Calcium is the chemical element with symbol Ca and atomic number 20. Calcium is a soft gray alkaline earth metal, and is the fifth-most-abundant element by mass in the Earth's crust. Calcium is also the fifth-most-abundant dissolved ion in seawater by both molarity and mass, after sodium, chloride, magnesium, and sulfate.")
    End Sub

    Private Sub ScandiumButton_Click(sender As Object, e As RoutedEventArgs) Handles ScandiumButton.Click
        ShowElementWindow("Scandium", "Scandium is a chemical element with symbol Sc and atomic number 21. A silvery-white metallic transition metal, it has historically been sometimes classified as a rare earth element, together with yttrium and the lanthanoids. It was discovered in 1879 by spectral analysis of the minerals euxenite and gadolinite from Scandinavia.")
    End Sub

    Private Sub TitaniumButton_Click(sender As Object, e As RoutedEventArgs) Handles TitaniumButton.Click
        ShowElementWindow("Titanium", "Titanium is a chemical element with the symbol Ti and atomic number 22. It has a low density and is a strong, lustrous, corrosion-resistant (including sea water, aqua regia and chlorine) transition metal with a silver color.")
    End Sub

    Private Sub VanadiumButton_Click(sender As Object, e As RoutedEventArgs) Handles VanadiumButton.Click
        ShowElementWindow("Vanadium", "Vanadium is a chemical element with the symbol V and atomic number 23. It is a hard, silvery gray, ductile and malleable transition metal. The element is found only in chemically combined form in nature, but once isolated artificially, the formation of an oxide layer stabilizes the free metal somewhat against further oxidation. Andrés Manuel del Río discovered compounds of vanadium in 1801 by analyzing a new lead-bearing mineral he called brown lead, and presumed its qualities were due to the presence of a new element, which he named erythronium (Greek for red) since, upon heating, most of its salts turned from their initial color to red. Four years later, however, he was convinced by other scientists that erythronium was identical to chromium. Chlorides of vanadium were generated in 1830 by Nils Gabriel Sefström who thereby proved that a new element was involved, which he named vanadium after the Germanic goddess of beauty and fertility, Vanadís (Freyja). Both names were attributed to the wide range of colors found in vanadium compounds. Del Rio's lead mineral was later renamed vanadinite for its vanadium content. Although Berzelius claimed to have first isolated vanadium in the 1830s, in 1867 Henry Enfield Roscoe showed that he had only obtained the oxide, and finally in 1869 Roscoe demonstrated a method to obtain the pure element.")
    End Sub

    Private Sub ChromiumButton_Click(sender As Object, e As RoutedEventArgs) Handles ChromiumButton.Click
        ShowElementWindow("Chromium", "Chromium is a chemical element which has the symbol Cr and atomic number 24. It is the first element in Group 6. It is a steely-gray, lustrous, hard metal that takes a high polish and has a high melting point. It is also odorless, tasteless, and malleable. The name of the element is derived from the Greek word chrōma (χρώμα), meaning colour, because many of its compounds are intensely coloured.")
    End Sub

    Private Sub ManganeseButton_Click(sender As Object, e As RoutedEventArgs) Handles ManganeseButton.Click
        ShowElementWindow("Manganese", "Manganese is a chemical element, designated by the symbol Mn. It has the atomic number 25. It is found as a free element in nature (often in combination with iron), and in many minerals. Manganese is a metal with important industrial metal alloy uses, particularly in stainless steels.")
    End Sub

    Private Sub IronButton_Click(sender As Object, e As RoutedEventArgs) Handles IronButton.Click
        ShowElementWindow("Iron", "Iron is a chemical element with the symbol Fe (from Latin: ferrum) and atomic number 26. It is a metal in the first transition series. It is the most common element (by mass) forming the planet Earth as a whole, forming much of Earth's outer and inner core. It is the fourth most common element in the Earth's crust. Iron's very common presence in rocky planets like Earth is due to its abundant production as a result of fusion in high-mass stars, where the production of nickel-56 (which decays to the most common isotope of iron) is the last nuclear fusion reaction that is exothermic. This causes radioactive nickel to become the last element to be produced before collapse of a supernova leads to the explosive events that scatter this precursor radionuclide of iron abundantly into space.")
    End Sub

    Private Sub CobaltButton_Click(sender As Object, e As RoutedEventArgs) Handles CobaltButton.Click
        ShowElementWindow("Cobalt", "Cobalt is a chemical element with symbol Co and atomic number 27. It is found naturally only in chemically combined form. The free element, produced by reductive smelting, is a hard, lustrous, silver-gray metal.")
    End Sub

    Private Sub NickelButton_Click(sender As Object, e As RoutedEventArgs) Handles NickelButton.Click
        ShowElementWindow("Nickel", "Nickel is a chemical element with the chemical symbol Ni and atomic number 28. It is a silvery-white lustrous metal with a slight golden tinge. Nickel belongs to the transition metals and is hard and ductile. Pure nickel shows a significant chemical activity that can be observed when nickel is powdered to maximize the exposed surface area on which reactions can occur, but larger pieces of the metal are slow to react with air at ambient conditions due to the formation of a protective oxide surface. Even then, nickel is reactive enough with oxygen so that native nickel is rarely found on Earth's surface, being mostly confined to the interiors of larger nickel–iron meteorites that were protected from oxidation during their time in space. On Earth, such native nickel is always found in combination with iron, a reflection of those elements' origin as major end products of supernova nucleosynthesis. An iron–nickel mixture is thought to compose Earth's inner core.")
    End Sub

    Private Sub CopperButton_Click(sender As Object, e As RoutedEventArgs) Handles CopperButton.Click
        ShowElementWindow("Copper", "Copper is a chemical element with the symbol Cu (from Latin: cuprum) and atomic number 29. It is a ductile metal with very high thermal and electrical conductivity. Pure copper is soft and malleable; a freshly exposed surface has a reddish-orange color. It is used as a conductor of heat and electricity, a building material, and a constituent of various metal alloys.")
    End Sub

    Private Sub ZincButton_Click(sender As Object, e As RoutedEventArgs) Handles ZincButton.Click
        ShowElementWindow("Zinc", "Zinc, in commerce also spelter, is a metallic chemical element; it has the symbol Zn and atomic number 30. It is the first element of group 12 of the periodic table. Zinc is, in some respects, chemically similar to magnesium, because its ion is of similar size and its only common oxidation state is +2. Zinc is the 24th most abundant element in the Earth's crust and has five stable isotopes. The most common zinc ore is sphalerite (zinc blende), a zinc sulfide mineral. The largest mineable amounts are found in Australia, Asia, and the United States. Zinc production includes froth flotation of the ore, roasting, and final extraction using electricity (electrowinning).")
    End Sub

    Private Sub GalliumButton_Click(sender As Object, e As RoutedEventArgs) Handles GalliumButton.Click
        ShowElementWindow("Gallium", "Gallium is a chemical element with symbol Ga and atomic number 31. Elemental gallium does not occur in nature, but as the gallium(III) compounds in trace amounts in bauxite and zinc ores. A soft silvery metallic poor metal, elemental gallium is a brittle solid at low temperatures. Held long enough, gallium will melt in the hand as it liquefies at temperature of 29.77 °C (85.59 °F) (slightly above room temperature). Its melting point is used as a temperature reference point. The alloy Galinstan (68.5% Ga, 21.5% In, 10% Sn) has an even lower melting point of −19 °C (−2 °F). From its discovery in 1875 until the semiconductor era, gallium was used primarily as an agent to make low-melting alloys.")
    End Sub

    Private Sub GermaniumButton_Click(sender As Object, e As RoutedEventArgs) Handles GermaniumButton.Click
        ShowElementWindow("Germanium", "Germanium is a chemical element with symbol Ge and atomic number 32. It is a lustrous, hard, grayish-white metalloid in the carbon group, chemically similar to its group neighbors tin and silicon. Purified germanium is a semiconductor, with an appearance most similar to elemental silicon. Like silicon, germanium naturally reacts and forms complexes with oxygen in nature. Unlike silicon, it is too reactive to be found naturally on Earth in the free (native) state.")
    End Sub

    Private Sub ArsenicButton_Click(sender As Object, e As RoutedEventArgs) Handles ArsenicButton.Click
        ShowElementWindow("Arsenic", "Arsenic is a chemical element with symbol As and atomic number 33. Arsenic occurs in many minerals, usually in conjunction with sulfur and metals, and also as a pure elemental crystal. It was first documented by Albertus Magnus in 1250. Arsenic is a metalloid. It can exist in various allotropes, although only the gray form has important use in industry.")
    End Sub

    Private Sub SeleniumButton_Click(sender As Object, e As RoutedEventArgs) Handles SeleniumButton.Click
        ShowElementWindow("Selenium", "Selenium is a chemical element with symbol Se and atomic number 34. It is a nonmetal with properties that are intermediate between those of its periodic table column-adjacent chalcogen elements sulfur and tellurium. It rarely occurs in its elemental state in nature, or as pure ore compounds. Selenium (Greek σελήνη selene meaning Moon) was discovered in 1817 by Jöns Jakob Berzelius, who noted the similarity of the new element to the previously-known tellurium (named for the Earth).")
    End Sub

    Private Sub BromineButton_Click(sender As Object, e As RoutedEventArgs) Handles BromineButton.Click
        ShowElementWindow("Bromine", "Bromine (from Greek: βρῶμος, brómos, meaning stench (of he-goats)) is a chemical element with the symbol Br, and atomic number of 35. It is in the halogen group (17). The element was isolated independently by two chemists, Carl Jacob Löwig and Antoine Jerome Balard, in 1825–1826. Elemental bromine is a fuming red-brown liquid at room temperature, corrosive and toxic, with properties between those of chlorine and iodine. Free bromine does not occur in nature, but occurs as colorless soluble crystalline mineral halide salts, analogous to table salt.")
    End Sub

    Private Sub KryptonButton_Click(sender As Object, e As RoutedEventArgs) Handles KryptonButton.Click
        ShowElementWindow("Krypton", "Krypton (from Greek: κρυπτός kryptos the hidden one) is a chemical element with symbol Kr and atomic number 36. It is a member of group 18 (noble gases) elements. A colorless, odorless, tasteless noble gas, krypton occurs in trace amounts in the atmosphere, is isolated by fractionally distilling liquified air, and is often used with other rare gases in fluorescent lamps. Krypton is inert for most practical purposes.")
    End Sub

    Private Sub RubidiumButton_Click(sender As Object, e As RoutedEventArgs) Handles RubidiumButton.Click
        ShowElementWindow("Rubidium", "Rubidium is a chemical element with the symbol Rb and atomic number 37. Rubidium is a soft, silvery-white metallic element of the alkali metal group, with an atomic mass of 85.4678. Elemental rubidium is highly reactive, with properties similar to those of other elements in Group 1, such as very rapid oxidation in air. Rubidium has only one stable isotope, 85Rb, with the isotope 87Rb, which composes almost 28% of naturally occurring rubidium, being slightly radioactive with a half-life of 49 billion years—more than three times longer than the estimated age of the universe.")
    End Sub

    Private Sub StrontiumButton_Click(sender As Object, e As RoutedEventArgs) Handles StrontiumButton.Click
        ShowElementWindow("Strontium", "Strontium (play /ˈstrɒntiəm/ STRON-tee-əm) is a chemical element with symbol Sr and atomic number 38. An alkaline earth metal, strontium is a soft silver-white or yellowish metallic element that is highly reactive chemically. The metal turns yellow when exposed to air. It occurs naturally in the minerals celestine and strontianite. While natural strontium is stable, the synthetic 90Sr isotope is present in radioactive fallout and has a half-life of 28.90 years.")
    End Sub

    Private Sub YttriumButton_Click(sender As Object, e As RoutedEventArgs) Handles YttriumButton.Click
        ShowElementWindow("Yttrium", "Yttrium is a chemical element with symbol Y and atomic number 39. It is a silvery-metallic transition metal chemically similar to the lanthanides and it has often been classified as a rare earth element. Yttrium is almost always found combined with the lanthanides in rare earth minerals and is never found in nature as a free element. Its only stable isotope, 89Y, is also its only naturally occurring isotope.")
    End Sub

    Private Sub ZirconiumButton_Click(sender As Object, e As RoutedEventArgs) Handles ZirconiumButton.Click
        ShowElementWindow("Zirconium", "Zirconium is a chemical element with the symbol Zr, atomic number 40 and atomic mass of 91.224. The name of zirconium is taken from the mineral zircon, the most important source of zirconium. It is a lustrous, grey-white, strong transition metal that resembles titanium. Zirconium is mainly used as a refractory and opacifier, although minor amounts are used as alloying agent for its strong resistance to corrosion. Zirconium forms a variety of inorganic and organometallic compounds such as zirconium dioxide and zirconocene dichloride, respectively. Five isotopes occur naturally, three of which are stable. Zirconium compounds have no known biological role.")
    End Sub

    Private Sub NiobiumButton_Click(sender As Object, e As RoutedEventArgs) Handles NiobiumButton.Click
        ShowElementWindow("Niobium", "Niobium, formerly columbium, is a chemical element with the symbol Nb and atomic number 41. It is a soft, grey, ductile transition metal, which is often found in the pyrochlore mineral, the main commercial source for niobium, and columbite. The name comes from Greek mythology: Niobe, daughter of Tantalus.")
    End Sub

    Private Sub MolybdenumButton_Click(sender As Object, e As RoutedEventArgs) Handles MolybdenumButton.Click
        ShowElementWindow("Molybdenum", "Molybdenum is a Group 6 chemical element with the symbol Mo and atomic number 42. The name is from Neo-Latin Molybdaenum, from Ancient Greek Μόλυβδος molybdos, meaning lead, since its ores were confused with lead ores.[4] Molybdenum minerals have been known into prehistory, but the element was discovered (in the sense of differentiating it as a new entity from the mineral salts of other metals) in 1778 by Carl Wilhelm Scheele. The metal was first isolated in 1781 by Peter Jacob Hjelm.")
    End Sub

    Private Sub TechnetiumButton_Click(sender As Object, e As RoutedEventArgs) Handles TechnetiumButton.Click
        ShowElementWindow("Technetium", "Technetium is the chemical element with atomic number 43 and symbol Tc. It is the lowest atomic number element without any stable isotopes; every form of it is radioactive. Nearly all technetium is produced synthetically and only minute amounts are found in nature. Naturally occurring technetium occurs as a spontaneous fission product in uranium ore or by neutron capture in molybdenum ores. The chemical properties of this silvery gray, crystalline transition metal are intermediate between rhenium and manganese.")
    End Sub

    Private Sub RutheniumButton_Click(sender As Object, e As RoutedEventArgs) Handles RutheniumButton.Click
        ShowElementWindow("Ruthenium", "Ruthenium is a chemical element with symbol Ru and atomic number 44. It is a rare transition metal belonging to the platinum group of the periodic table. Like the other metals of the platinum group, ruthenium is inert to most chemicals. The Baltic German scientist Karl Ernst Claus discovered the element in 1844 and named it after Ruthenia, the Latin word for Rus' (ancient Russia). Ruthenium usually occurs as a minor component of platinum ores and its annual production is only about 20 tonnes. Most ruthenium is used for wear-resistant electrical contacts and the production of thick-film resistors. A minor application of ruthenium is its use in some platinum alloys.")
    End Sub

    Private Sub RhodiumButton_Click(sender As Object, e As RoutedEventArgs) Handles RhodiumButton.Click
        ShowElementWindow("Rhodium", "Rhodium is a chemical element that is a rare, silvery-white, hard, and chemically inert transition metal and a member of the platinum group. It has the chemical symbol Rh and atomic number 45. It is composed of only one naturally-occurring isotope, 103Rh. Naturally occurring rhodium is usually found as the free metal, alloyed with similar metals, and rarely as a chemical compound in minerals such as bowieite and rhodplumsite. It is one of the rarest precious metals.")
    End Sub

    Private Sub PalladiumButton_Click(sender As Object, e As RoutedEventArgs) Handles PalladiumButton.Click
        ShowElementWindow("Palladium", "Palladium is a chemical element with the chemical symbol Pd and an atomic number of 46. It is a rare and lustrous silvery-white metal discovered in 1803 by William Hyde Wollaston. He named it after the asteroid Pallas, which was itself named after the epithet of the Greek goddess Athena, acquired by her when she slew Pallas. Palladium, platinum, rhodium, ruthenium, iridium and osmium form a group of elements referred to as the platinum group metals (PGMs). These have similar chemical properties, but palladium has the lowest melting point and is the least dense of them.")
    End Sub

    Private Sub SilverButton_Click(sender As Object, e As RoutedEventArgs) Handles SilverButton.Click
        ShowElementWindow("Silver", "Silver is a metallic chemical element with the chemical symbol Ag (Greek: άργυρος <árgyros>, Latin: argentum, both from the Indo-European root *arg- for grey or shining) and atomic number 47. A soft, white, lustrous transition metal, it has the highest electrical conductivity of any element and the highest thermal conductivity of any metal. The metal occurs naturally in its pure, free form (native silver), as an alloy with gold and other metals, and in minerals such as argentite and chlorargyrite. Most silver is produced as a byproduct of copper, gold, lead, and zinc refining.")
    End Sub

    Private Sub CadmiumButton_Click(sender As Object, e As RoutedEventArgs) Handles CadmiumButton.Click
        ShowElementWindow("Cadmium", "Cadmium is a chemical element with the symbol Cd and atomic number 48. This soft, bluish-white metal is chemically similar to the two other stable metals in group 12, zinc and mercury. Like zinc, it prefers oxidation state +2 in most of its compounds and like mercury it shows a low melting point compared to transition metals. Cadmium and its congeners are not always considered transition metals, in that they do not have partly filled d or f electron shells in the elemental or common oxidation states. The average concentration of cadmium in the Earth's crust is between 0.1 and 0.5 parts per million (ppm). It was discovered in 1817 simultaneously by Stromeyer and Hermann, both in Germany, as an impurity in zinc carbonate.")
    End Sub

    Private Sub IndiumButton_Click(sender As Object, e As RoutedEventArgs) Handles IndiumButton.Click
        ShowElementWindow("Indium", "Indium is a chemical element with symbol In and atomic number 49. This rare, very soft, malleable and easily fusible post-transition metal is chemically similar to gallium and thallium, and shows intermediate properties between these two. Indium was discovered in 1863 and named for the indigo blue line in its spectrum that was the first indication of its existence in zinc ores, as a new and unknown element. The metal was first isolated in the following year. Zinc ores continue to be the primary source of indium, where it is found in compound form. Very rarely the element can be found as grains of native (free) metal, but these are not of commercial importance.")
    End Sub

    Private Sub TinButton_Click(sender As Object, e As RoutedEventArgs) Handles TinButton.Click
        ShowElementWindow("Tin", "Tin is a chemical element with symbol Sn (for Latin: stannum) and atomic number 50. It is a main group metal in group 14 of the periodic table. Tin shows chemical similarity to both neighboring group-14 elements, germanium and lead and has two possible oxidation states, +2 and the slightly more stable +4. Tin is the 49th most abundant element and has, with 10 stable isotopes, the largest number of stable isotopes in the periodic table. Tin is obtained chiefly from the mineral cassiterite, where it occurs as tin dioxide, SnO2.")
    End Sub

    Private Sub AntimonyButton_Click(sender As Object, e As RoutedEventArgs) Handles AntimonyButton.Click
        ShowElementWindow("Antimony", "Antimony (Latin: stibium) is a chemical element with symbol Sb and atomic number 51. A lustrous gray metalloid, it is found in nature mainly as the sulfide mineral stibnite (Sb2S3). Antimony compounds have been known since ancient times and were used for cosmetics; metallic antimony was also known, but it was erroneously identified as lead. It was established to be an element around the 17th century.")
    End Sub

    Private Sub TelluriumButton_Click(sender As Object, e As RoutedEventArgs) Handles TelluriumButton.Click
        ShowElementWindow("Tellurium", "Tellurium is a chemical element with symbol Te and atomic number 52. A brittle, mildly toxic, rare, silver-white metalloid which looks similar to tin, tellurium is chemically related to selenium and sulfur. It is occasionally found in native form, as elemental crystals. Tellurium is far more common in the universe as a whole than it is on Earth. Its extreme rarity in the Earth's crust, comparable to that of platinum, is partly due to its high atomic number, but also due to its formation of a volatile hydride which caused the element to be lost to space as a gas during the hot nebular formation of the planet.")
    End Sub

    Private Sub IodineButton_Click(sender As Object, e As RoutedEventArgs) Handles IodineButton.Click
        ShowElementWindow("Iodine", "Iodine is a chemical element with symbol I and atomic number 53. The name is from Greek ἰοειδής ioeidēs, meaning violet or purple, due to the color of elemental iodine vapor.")
    End Sub

    Private Sub XenonButton_Click(sender As Object, e As RoutedEventArgs) Handles XenonButton.Click
        ShowElementWindow("Xenon", "Xenon is a chemical element with the symbol Xe and atomic number 54. It is a colorless, heavy, odorless noble gas, that occurs in the Earth's atmosphere in trace amounts. Although generally unreactive, xenon can undergo a few chemical reactions such as the formation of xenon hexafluoroplatinate, the first noble gas compound to be synthesized.")
    End Sub

    Private Sub CaesiumButton_Click(sender As Object, e As RoutedEventArgs) Handles CaesiumButton.Click
        ShowElementWindow("Caesium", "Caesium or cesium is a chemical element with symbol Cs and atomic number 55. It is a soft, silvery-gold alkali metal with a melting point of 28 °C (82 °F), which makes it one of only five elemental metals that are liquid at (or near) room temperature. Caesium is an alkali metal and has physical and chemical properties similar to those of rubidium and potassium. The metal is extremely reactive and pyrophoric, reacting with water even at −116 °C (−177 °F). It is the least electronegative element having a stable isotope, caesium-133. Caesium is mined mostly from pollucite, while the radioisotopes, especially caesium-137, a fission product, are extracted from waste produced by nuclear reactors.")
    End Sub

    Private Sub BariumButton_Click(sender As Object, e As RoutedEventArgs) Handles BariumButton.Click
        ShowElementWindow("Barium", "Barium is a chemical element with symbol Ba and atomic number 56. It is the fifth element in Group 2, a soft silvery metallic alkaline earth metal. Because of its high chemical reactivity barium is never found in nature as a free element. Its hydroxide was known in pre-modern history as baryta; this substance does not occur as a mineral, but can be prepared by heating barium carbonate.")
    End Sub

    Private Sub LanthanumButton_Click(sender As Object, e As RoutedEventArgs) Handles LanthanumButton.Click
        ShowElementWindow("Lanthanum", "Lanthanum is a chemical element with the symbol La and atomic number 57. Lanthanum is a silvery white metallic element that belongs to group 3 of the periodic table and is the first element of the lanthanide series. It is found in some rare-earth minerals, usually in combination with cerium and other rare earth elements. Lanthanum is a malleable, ductile, and soft metal that oxidizes rapidly when exposed to air. It is produced from the minerals monazite and bastnäsite using a complex multistage extraction process. Lanthanum compounds have numerous applications as catalysts, additives in glass, carbon lighting for studio lighting and projection, ignition elements in lighters and torches, electron cathodes, scintillators, and others. Lanthanum carbonate (La2(CO3)3) was approved as a medication against renal failure.")
    End Sub

    Private Sub CeriumButton_Click(sender As Object, e As RoutedEventArgs) Handles CeriumButton.Click
        ShowElementWindow("Cerium", "Cerium is a chemical element with symbol Ce and atomic number 58. It is a soft, silvery, ductile metal which easily oxidizes in air. Cerium was named after the dwarf planet Ceres (itself named for the Roman goddess of agriculture). Cerium is the most abundant of the rare earth elements, making up about 0.0046% of the Earth's crust by weight. It is found in a number of minerals, the most important being monazite and bastnasite. Commercial applications of cerium are numerous. They include catalysts, additives to fuel to reduce emissions and to glass and enamels to change their color. Cerium oxide is an important component of glass polishing powders and phosphors used in screens and fluorescent lamps. It is also used in the flint (actually ferrocerium) of lighters.")
    End Sub

    Private Sub PraseodymiumButton_Click(sender As Object, e As RoutedEventArgs) Handles PraseodymiumButton.Click
        ShowElementWindow("Praseodymium", "Praseodymium is a chemical element that has the symbol Pr and atomic number 59. Praseodymium is a soft, silvery, malleable and ductile metal in the lanthanide group. It is too reactive to be found in native form, and when artificially prepared, it slowly develops a green oxide coating.")
    End Sub

    Private Sub NeodymiumButton_Click(sender As Object, e As RoutedEventArgs) Handles NeodymiumButton.Click
        ShowElementWindow("Neodymium", "Neodymium is a chemical element with the symbol Nd and atomic number 60. It is a soft silvery metal that tarnishes in air. Neodymium was discovered in 1885 by the Austrian chemist Carl Auer von Welsbach. It is present in significant quantities in the ore minerals monazite and bastnäsite. Neodymium is not found naturally in metallic form or unmixed with other lanthanides, and it is usually refined for general use. Although neodymium is classed as a rare earth, it is no rarer than cobalt, nickel, and copper ore, and is widely distributed in the Earth's crust. Most of the world's neodymium is mined in China.")
    End Sub

    Private Sub PromethiumButton_Click(sender As Object, e As RoutedEventArgs) Handles PromethiumButton.Click
        ShowElementWindow("Promethium", "Promethium, originally prometheum, is a chemical element with the symbol Pm and atomic number 61. All of its isotopes are radioactive; it is one of only two such elements that are followed in the periodic table by elements with stable forms, a distinction shared with technetium. Chemically, promethium is a lanthanide, which forms salts when combined with other elements. Promethium shows only one stable oxidation state of +3; however, a few +2 compounds may exist.")
    End Sub

    Private Sub SamariumButton_Click(sender As Object, e As RoutedEventArgs) Handles SamariumButton.Click
        ShowElementWindow("Samarium", "Samarium is a chemical element with symbol Sm and atomic number 62. It is a moderately hard silvery metal which readily oxidizes in air. Being a typical member of the lanthanide series, samarium usually assumes the oxidation state +3. Compounds of samarium(II) are also known, most notably the monoxide SmO, monochalcogenides SmS, SmSe and SmTe, as well as samarium(II) iodide. The last compound is a common reducing agent in chemical synthesis. Samarium has no significant biological role and is only slightly toxic.")
    End Sub

    Private Sub EuropiumButton_Click(sender As Object, e As RoutedEventArgs) Handles EuropiumButton.Click
        ShowElementWindow("Europium", "Europium is a chemical element with the symbol Eu and atomic number 63. It is named after the continent of Europe. It is a moderately hard, silvery metal which readily oxidizes in air and water. Being a typical member of the lanthanide series, europium usually assumes the oxidation state +3, but the oxidation state +2 is also common: all europium compounds with oxidation state +2 are slightly reducing. Europium has no significant biological role and is relatively non-toxic compared to other heavy metals. Most applications of europium exploit the phosphorescence of europium compounds.")
    End Sub

    Private Sub GadoliniumButton_Click(sender As Object, e As RoutedEventArgs) Handles GadoliniumButton.Click
        ShowElementWindow("Gadolinium", "Gadolinium is a chemical element with symbol Gd and atomic number 64. It is a silvery-white, malleable and ductile rare-earth metal. It is found in nature only in combined (salt) form. Gadolinium was first detected spectroscopically in 1880 by de Marignac who separated its oxide and is credited with its discovery. It is named for gadolinite, one of the minerals in which it was found, in turn named for chemist Johan Gadolin. The metal was isolated by Lecoq de Boisbaudran in 1886.")
    End Sub

    Private Sub TerbiumButton_Click(sender As Object, e As RoutedEventArgs) Handles TerbiumButton.Click
        ShowElementWindow("Terbium", "Terbium is a chemical element with the symbol Tb and atomic number 65. It is a silvery-white rare earth metal that is malleable, ductile and soft enough to be cut with a knife. Terbium is never found in nature as a free element, but it is contained in many minerals, including cerite, gadolinite, monazite, xenotime and euxenite.")
    End Sub

    Private Sub DysprosiumButton_Click(sender As Object, e As RoutedEventArgs) Handles DysprosiumButton.Click
        ShowElementWindow("Dysprosium", "Dysprosium is a chemical element with the symbol Dy and atomic number 66. It is a rare earth element with a metallic silver luster. Dysprosium is never found in nature as a free element, though it is found in various minerals, such as xenotime. Naturally occurring dysprosium is composed of 7 isotopes, the most abundant of which is 164Dy.")
    End Sub

    Private Sub HolmiumButton_Click(sender As Object, e As RoutedEventArgs) Handles HolmiumButton.Click
        ShowElementWindow("Holmium", "Holmium is a chemical element with the symbol Ho and atomic number 67. Part of the lanthanide series, holmium is a rare earth element. Holmium was discovered by Swedish chemist Per Theodor Cleve. Its oxide was first isolated from rare earth ores in 1878 and the element was named after the city of Stockholm.")
    End Sub

    Private Sub ErbiumButton_Click(sender As Object, e As RoutedEventArgs) Handles ErbiumButton.Click
        ShowElementWindow("Erbium", "Erbium is a chemical element in the lanthanide series, with the symbol Er and atomic number 68. A silvery-white solid metal when artificially isolated, natural erbium is always found in chemical combination with other elements on Earth. As such, it is a rare earth element which is associated with several other rare elements in the mineral gadolinite from Ytterby in Sweden.")
    End Sub

    Private Sub ThuliumButton_Click(sender As Object, e As RoutedEventArgs) Handles ThuliumButton.Click
        ShowElementWindow("Thulium", "Thulium is a chemical element that has the symbol Tm and atomic number 69. Thulium is the second least abundant of the lanthanides (promethium is only found in trace quantities on Earth). It is an easily workable metal with a bright silvery-gray luster. Despite its high price and rarity, thulium is used as the radiation source in portable X-ray devices and in solid-state lasers.")
    End Sub

    Private Sub YtterbiumButton_Click(sender As Object, e As RoutedEventArgs) Handles YtterbiumButton.Click
        ShowElementWindow("Ytterbium", "Ytterbium is a chemical element with symbol Yb and atomic number 70. It is the fourteenth and penultimate element in the lanthanide series, or last element in the f-block, which is the basis of the relative stability of the +2 oxidation state. However, like the other lanthanides, the most common oxidation state is +3, seen in its oxide, halides and other compounds. In aqueous solution, like compounds of other late lanthanides, soluble ytterbium compounds form complexes with nine water molecules. Due to its closed-shell electron configuration, some of its properties, such as its density and melting and boiling points, show differences from those of the other lanthanides.")
    End Sub

    Private Sub LutetiumButton_Click(sender As Object, e As RoutedEventArgs) Handles LutetiumButton.Click
        ShowElementWindow("Lutetium", "Lutetium is a chemical element with the symbol Lu and atomic number 71. It is a silvery white metal which resists corrosion in dry, but not moist, air. It is the last element in the lanthanide series, and traditionally counted among the rare earths.")
    End Sub

    Private Sub HafniumButton_Click(sender As Object, e As RoutedEventArgs) Handles HafniumButton.Click
        ShowElementWindow("Hafnium", "Hafnium is a chemical element with the symbol Hf and atomic number 72. A lustrous, silvery gray, tetravalent transition metal, hafnium chemically resembles zirconium and is found in zirconium minerals. Its existence was predicted by Dmitri Mendeleev in 1869. Hafnium was the penultimate stable isotope element to be discovered (rhenium was identified two years later). Hafnium is named after Hafnia, the Latin name for Copenhagen, where it was discovered.")
    End Sub

    Private Sub TantalumButton_Click(sender As Object, e As RoutedEventArgs) Handles TantalumButton.Click
        ShowElementWindow("Tantalum", "Tantalum is a chemical element with the symbol Ta and atomic number 73. Previously known as tantalium, the name comes from Tantalus, a character from Greek mythology.[3] Tantalum is a rare, hard, blue-gray, lustrous transition metal that is highly corrosion resistant. It is part of the refractory metals group, which are widely used as minor component in alloys. The chemical inertness of tantalum makes it a valuable substance for laboratory equipment and a substitute for platinum, but its main use today is in tantalum capacitors in electronic equipment such as mobile phones, DVD players, video game systems and computers. Tantalum, always together with the chemically similar niobium, occurs in the minerals tantalite, columbite and coltan (a mix of columbite and tantalite).")
    End Sub

    Private Sub TungstenButton_Click(sender As Object, e As RoutedEventArgs) Handles TungstenButton.Click
        ShowElementWindow("Tungsten", "Tungsten, also known as wolfram, is a chemical element with the chemical symbol W and atomic number 74. The word tungsten comes from the Swedish language tung sten directly translatable to heavy stone, though the name is volfram in Swedish to distinguish it from Scheelite, in Swedish alternatively named tungsten.")
    End Sub

    Private Sub RheniumButton_Click(sender As Object, e As RoutedEventArgs) Handles RheniumButton.Click
        ShowElementWindow("Rhenium", "Rhenium is a chemical element with the symbol Re and atomic number 75. It is a silvery-white, heavy, third-row transition metal in group 7 of the periodic table. With an estimated average concentration of 1 part per billion (ppb), rhenium is one of the rarest elements in the Earth's crust. The free element has the third-highest melting point and highest boiling point of any element. Rhenium resembles manganese chemically and is obtained as a by-product of molybdenum and copper ore's extraction and refinement. Rhenium shows in its compounds a wide variety of oxidation states ranging from −1 to +7.")
    End Sub

    Private Sub OsmiumButton_Click(sender As Object, e As RoutedEventArgs) Handles OsmiumButton.Click
        ShowElementWindow("Osmium", "Osmium is a chemical element with the symbol Os and atomic number 76. It is a hard, brittle, blue-gray or blue-black transition metal in the platinum family and is the densest naturally occurring element, with a density of 22.59 g/cm3 (slightly greater than that of iridium and twice that of lead). It is found in nature as an alloy, mostly in platinum ores; its alloys with platinum, iridium, and other platinum group metals are employed in fountain pen tips, electrical contacts, and other applications where extreme durability and hardness are needed.")
    End Sub

    Private Sub IridiumButton_Click(sender As Object, e As RoutedEventArgs) Handles IridiumButton.Click
        ShowElementWindow("Iridium", "Iridium is the chemical element with atomic number 77, and is represented by the symbol Ir. A very hard, brittle, silvery-white transition metal of the platinum family, iridium is the second-densest element (after osmium) and is the most corrosion-resistant metal, even at temperatures as high as 2000 °C. Although only certain molten salts and halogens are corrosive to solid iridium, finely divided iridium dust is much more reactive and can be flammable.")
    End Sub

    Private Sub PlatinumButton_Click(sender As Object, e As RoutedEventArgs) Handles PlatinumButton.Click
        ShowElementWindow("Platinum", "Platinum is a chemical element with the chemical symbol Pt and an atomic number of 78. Its name is derived from the Spanish term platina, which is literally translated into little silver. It is a dense, malleable, ductile, precious, gray-white transition metal.")
    End Sub

    Private Sub GoldButton_Click(sender As Object, e As RoutedEventArgs) Handles GoldButton.Click
        ShowElementWindow("Gold", "Gold is a dense, soft, shiny, malleable and ductile metal. It is a chemical element with the symbol Au and atomic number 79. Gold has a bright yellow color and luster traditionally considered attractive, which it maintains without oxidizing in air or water. Chemically, gold is a transition metal and a group 11 element. It is one of the least reactive chemical elements solid under standard conditions. The metal therefore occurs often in free elemental (native) form, as nuggets or grains in rocks, in veins and in alluvial deposits. Less commonly, it occurs in minerals as gold compounds, usually with tellurium.")
    End Sub

    Private Sub MercuryButton_Click(sender As Object, e As RoutedEventArgs) Handles MercuryButton.Click
        ShowElementWindow("Mercury", "Mercury is a chemical element with the symbol Hg and atomic number 80. It is also known as quicksilver or hydrargyrum ( < Greek hydr- water and argyros silver). A heavy, silvery d-block element, mercury is the only metal that is liquid at standard conditions for temperature and pressure; the only other element that is liquid under these conditions is bromine, though metals such as caesium, gallium, and rubidium melt just above room temperature. With a freezing point of −38.83 °C and boiling point of 356.73 °C, mercury has one of the narrowest ranges of its liquid state of any metal.")
    End Sub

    Private Sub ThalliumButton_Click(sender As Object, e As RoutedEventArgs) Handles ThalliumButton.Click
        ShowElementWindow("Thallium", "Thallium is a chemical element with symbol Tl and atomic number 81. This soft gray poor metal is not found free in nature. When isolated, it resembles tin, but discolors when exposed to air. Chemists William Crookes and Claude-Auguste Lamy discovered thallium independently in 1861, in residues of sulfuric acid production. Both used the newly developed method of flame spectroscopy, in which thallium produces a notable green spectral line. Thallium, from Greek θαλλός, thallos, meaning a green shoot or twig, was named by Crookes. It was isolated by electrolysis a year later, by Lamy.")
    End Sub

    Private Sub LeadButton_Click(sender As Object, e As RoutedEventArgs) Handles LeadButton.Click
        ShowElementWindow("Lead", "Lead is a chemical element in the carbon group with symbol Pb (from Latin: plumbum) and atomic number 82. Lead is a soft, malleable poor metal. It is also counted as one of the heavy metals. Metallic lead has a bluish-white color after being freshly cut, but it soon tarnishes to a dull grayish color when exposed to air. Lead has a shiny chrome-silver luster when it is melted into a liquid.")
    End Sub

    Private Sub BismuthButton_Click(sender As Object, e As RoutedEventArgs) Handles BismuthButton.Click
        ShowElementWindow("Bismuth", "Bismuth is a chemical element with symbol Bi and atomic number 83. Bismuth, a pentavalent poor metal, chemically resembles arsenic and antimony. Elemental bismuth may occur naturally, although its sulfide and oxide form important commercial ores. The free element is 86% as dense as lead. It is a brittle metal with a silvery white color when freshly produced, but is often seen in air with a pink tinge owing to surface oxidation. Bismuth is the most naturally diamagnetic and has one of the lowest values of thermal conductivity among metals.")
    End Sub

    Private Sub PoloniumButton_Click(sender As Object, e As RoutedEventArgs) Handles PoloniumButton.Click
        ShowElementWindow("Polonium", "Polonium is a chemical element with the symbol Po and atomic number 84, discovered in 1898 by Marie and Pierre Curie. A rare and highly radioactive element with no stable isotopes, polonium is chemically similar to bismuth and tellurium, and it occurs in uranium ores. Applications of polonium are few, and include heaters in space probes, antistatic devices, and sources of neutrons and alpha particles. Because of its position in the periodic table, polonium is sometimes referred to as a metalloid, however others note that on the basis of its properties and behavior it is unambiguously a metal.")
    End Sub

    Private Sub AstatineButton_Click(sender As Object, e As RoutedEventArgs) Handles AstatineButton.Click
        ShowElementWindow("Astatine", "Radon is a chemical element with symbol Rn and atomic number 86. It is a radioactive, colorless, odorless, tasteless[1] noble gas, occurring naturally as an indirect decay product of uranium or thorium. Its most stable isotope, 222Rn, has a half-life of 3.8 days. Radon is one of the densest substances that remains a gas under normal conditions. It is also the only gas under normal conditions that only has radioactive isotopes, and is considered a health hazard due to its radioactivity. Intense radioactivity has also hindered chemical studies of radon and only a few compounds are known.")
    End Sub

    Private Sub RadonButton_Click(sender As Object, e As RoutedEventArgs) Handles RadonButton.Click
        ShowElementWindow("Radon", "Radon is a chemical element with symbol Rn and atomic number 86. It is a radioactive, colorless, odorless, tasteless noble gas, occurring naturally as an indirect decay product of uranium or thorium. Its most stable isotope, 222Rn, has a half-life of 3.8 days. Radon is one of the densest substances that remains a gas under normal conditions. It is also the only gas under normal conditions that only has radioactive isotopes, and is considered a health hazard due to its radioactivity. Intense radioactivity has also hindered chemical studies of radon and only a few compounds are known.")
    End Sub

    Private Sub FranciumButton_Click(sender As Object, e As RoutedEventArgs) Handles FranciumButton.Click
        ShowElementWindow("Francium", "Francium is a chemical element with symbol Fr and atomic number 87. It was formerly known as eka-caesium and actinium K. It is one of the two least electronegative elements, the other being caesium. Francium is a highly radioactive metal that decays into astatine, radium, and radon. As an alkali metal, it has one valence electron.")
    End Sub

    Private Sub RadiumButton_Click(sender As Object, e As RoutedEventArgs) Handles RadiumButton.Click
        ShowElementWindow("Radium", "Radium is a chemical element with symbol Ra and atomic number 88. Radium is an almost pure-white alkaline earth metal, but it readily oxidizes on exposure to air, becoming black in color. All isotopes of radium are highly radioactive, with the most stable isotope being radium-226, which has a half-life of 1601 years and decays into radon gas. Because of such instability, radium is luminescent, glowing a faint blue.")
    End Sub

    Private Sub ActiniumButton_Click(sender As Object, e As RoutedEventArgs) Handles ActiniumButton.Click
        ShowElementWindow("Actinium", "Actinium is a radioactive chemical element with symbol Ac (not to be confused with the abbreviation for an acetyl group) and has the atomic number 89, which was discovered in 1899. It was the first non-primordial radioactive element to be isolated. Polonium, radium and radon were observed before actinium, but they were not isolated until 1902. Actinium gave the name to the actinide series, a group of 15 similar elements between actinium and lawrencium in the periodic table.")
    End Sub

    Private Sub ThoriumButton_Click(sender As Object, e As RoutedEventArgs) Handles ThoriumButton.Click
        ShowElementWindow("Thorium", "Thorium is a naturally occurring radioactive chemical element with the symbol Th and atomic number 90. It was discovered in 1828 by the Norwegian mineralogist Morten Thrane Esmark and identified by the Swedish chemist Jons Jakob Berzelius and named after Thor, the Norse god of thunder.")
    End Sub

    Private Sub ProtactiniumButton_Click(sender As Object, e As RoutedEventArgs) Handles ProtactiniumButton.Click
        ShowElementWindow("Protactinium", "Protactinium is a chemical element with the symbol Pa and atomic number 91. It is a dense, silvery-gray metal which readily reacts with oxygen, water vapor and inorganic acids. It forms various chemical compounds where protactinium is usually present in the oxidation state +5, but can also assume +4 and even +2 or +3 states. The average concentrations of protactinium in the Earth's crust is typically on the order of a few parts per trillion, but may reach up to a few parts per million in some uraninite ore deposits. Because of the scarcity, high radioactivity and high toxicity, there are currently no uses for protactinium outside of scientific research, and for this purpose, protactinium is mostly extracted from spent nuclear fuel.")
    End Sub

    Private Sub UraniumButton_Click(sender As Object, e As RoutedEventArgs) Handles UraniumButton.Click
        ShowElementWindow("Uranium", "Uranium is a silvery-white metallic chemical element in the actinide series of the periodic table, with symbol U and atomic number 92. A uranium atom has 92 protons and 92 electrons, of which 6 are valence electrons. Uranium is weakly radioactive because all its isotopes are unstable. The most common isotopes of uranium are uranium-238 (which has 146 neutrons) and uranium-235 (which has 143 neutrons). Uranium has the second highest atomic weight of the primordially occurring elements, lighter only than plutonium. Its density is about 70% higher than that of lead, but not as dense as gold or tungsten. It occurs naturally in low concentrations of a few parts per million in soil, rock and water, and is commercially extracted from uranium-bearing minerals such as uraninite.")
    End Sub

    Private Sub NeptuniumButton_Click(sender As Object, e As RoutedEventArgs) Handles NeptuniumButton.Click
        ShowElementWindow("Neptunium", "Neptunium is a chemical element with the symbol Np and atomic number 93. A radioactive metal, neptunium is the first transuranic element, and belongs to the actinide series. Its most stable isotope, 237Np, is a by-product of nuclear reactors and plutonium production, and it can be used as a component in neutron detection equipment. Neptunium is also found in trace amounts in uranium ores due to transmutation reactions.")
    End Sub

    Private Sub PlutoniumButton_Click(sender As Object, e As RoutedEventArgs) Handles PlutoniumButton.Click
        ShowElementWindow("Plutonium", "Plutonium is a transuranic radioactive chemical element with the symbol Pu and atomic number 94. It is an actinide metal of silvery-gray appearance that tarnishes when exposed to air, forming a dull coating when oxidized. The element normally exhibits six allotropes and four oxidation states. It reacts with carbon, halogens, nitrogen, and silicon. When exposed to moist air, it forms oxides and hydrides that expand the sample up to 70% in volume, which in turn flake off as a powder that can spontaneously ignite. It is also radioactive and can accumulate in the bones. These properties make the handling of plutonium dangerous.")
    End Sub

    Private Sub AmericiumButton_Click(sender As Object, e As RoutedEventArgs) Handles AmericiumButton.Click
        ShowElementWindow("Americium", "Americium (/ˌæməˈrɪsiəm/ AM-ə-RIS-ee-əm) is a transuranic radioactive chemical element that has the symbol Am and atomic number 95. This transuranic element of the actinide series is located in the periodic table below the lanthanide element europium, and thus by analogy was named after another continent, America.")
    End Sub

    Private Sub CuriumButton_Click(sender As Object, e As RoutedEventArgs) Handles CuriumButton.Click
        ShowElementWindow("Curium", "Curium is a transuranic radioactive chemical element with the symbol Cm and atomic number 96. This element of the actinide series was named after Marie Skłodowska-Curie and her husband Pierre Curie - both were known for their research on radioactivity. Curium was first intentionally produced and identified in July 1944 by the group of Glenn T. Seaborg at the University of California, Berkeley. The discovery was kept secret and only released to the public in November 1945. Most curium is produced by bombarding uranium or plutonium with neutrons in nuclear reactors – one tonne of spent nuclear fuel contains about 20 grams of curium.")
    End Sub

    Private Sub BerkeliumButton_Click(sender As Object, e As RoutedEventArgs) Handles BerkeliumButton.Click
        ShowElementWindow("Berkelium", "Berkelium is a transuranic radioactive chemical element with the symbol Bk and atomic number 97, a member of the actinide and transuranium element series. It is named after the city of Berkeley, California, the location of the University of California Radiation Laboratory where it was discovered in December 1949. This was the fifth transuranium element discovered after neptunium, plutonium, curium and americium.")
    End Sub

    Private Sub CaliforniumButton_Click(sender As Object, e As RoutedEventArgs) Handles CaliforniumButton.Click
        ShowElementWindow("Californium", "Californium is a radioactive metallic chemical element with the symbol Cf and atomic number 98. The element was first made at the University of California, Berkeley in 1950 by bombarding curium with alpha particles (helium-4 ions). It is an actinide element, the sixth transuranium element to be synthesized, and has the second-highest atomic mass of all the elements that have been produced in amounts large enough to see with the unaided eye (after einsteinium). The element was named after California and the University of California. It is the heaviest element to occur naturally on Earth; heavier elements can only be produced by synthesis.")
    End Sub

    Private Sub EinsteiniumButton_Click(sender As Object, e As RoutedEventArgs) Handles EinsteiniumButton.Click
        ShowElementWindow("Einsteinium", "Einsteinium is a synthetic element with the symbol Es and atomic number 99. It is the seventh transuranic element, and an actinide. Einsteinium was discovered as a component of the debris of the first hydrogen bomb explosion in 1952, and named after Albert Einstein. Its most common isotope einsteinium-253 (half life 20.47 days) is produced artificially from decay of californium-252 in a few dedicated high-power nuclear reactors with a total yield on the order of one milligram per year. The reactor synthesis is followed by a complex procedure of separating einsteinium-253 from other actinides and products of their decay. Other isotopes are synthesized in various laboratories, but at much smaller amounts, by bombarding heavy actinide elements with light ions. Owing to the small amounts of produced einsteinium and the short half-life of its most easily produced isotope, there are currently almost no practical applications for it outside of basic scientific research. In particular, einsteinium was used to synthesize, for the first time, 17 atoms of the new element mendelevium in 1955.")
    End Sub

    Private Sub FermiumButton_Click(sender As Object, e As RoutedEventArgs) Handles FermiumButton.Click
        ShowElementWindow("Fermium", "Fermium is a synthetic element with symbol Fm and atomic number 100. It is a member of the actinide series. It is the heaviest element that can be formed by neutron bombardment of lighter elements, and hence the last element that can be prepared in macroscopic quantities, although pure fermium metal has not yet been prepared. A total of 19 isotopes are known, with 257Fm being the longest-lived one with a half-life of 100.5 days.")
    End Sub

    Private Sub MendeleviumButton_Click(sender As Object, e As RoutedEventArgs) Handles MendeleviumButton.Click
        ShowElementWindow("Mendelevium", "Mendelevium is a synthetic element with the symbol Md (formerly Mv) and the atomic number 101. A metallic radioactive transuranic element in the actinide series, mendelevium is usually synthesized by bombarding einsteinium with alpha particles. It was named after Dmitri Ivanovich Mendeleev, who created the Periodic Table. Mendeleev's periodic system is the fundamental way to classify all the chemical elements. The name mendelevium was accepted by the International Union of Pure and Applied Chemistry (IUPAC). On the other hand, the proposed symbol Mv submitted by the discoverers was not accepted, and IUPAC changed the symbol to Md in 1963.")
    End Sub

    Private Sub NobeliumButton_Click(sender As Object, e As RoutedEventArgs) Handles NobeliumButton.Click
        ShowElementWindow("Nobelium", "Nobelium is a synthetic element with the symbol No and atomic number 102. It was first correctly identified in 1966 by scientists at the Flerov Laboratory of Nuclear Reactions in Dubna, Soviet Union. Little is known about the element but limited chemical experiments have shown that it forms a stable divalent ion in solution as well as the predicted trivalent ion that is associated with its presence as one of the actinides.")
    End Sub

    Private Sub LawrenciumButton_Click(sender As Object, e As RoutedEventArgs) Handles LawrenciumButton.Click
        ShowElementWindow("Lawrencium", "Lawrencium is a radioactive synthetic chemical element with the symbol Lr (formerly Lw) and atomic number 103. In the periodic table of the elements, it is a period 7 d-block element and the last element of the actinide series. Chemistry experiments have confirmed that lawrencium behaves as the heavier homologue to lutetium and is chemically similar to other actinides.")
    End Sub

    Private Sub RutherfordiumButton_Click(sender As Object, e As RoutedEventArgs) Handles RutherfordiumButton.Click
        ShowElementWindow("Rutherfordium", "Rutherfordium is a chemical element with symbol Rf and atomic number 104, named in honor of New Zealand physicist Ernest Rutherford. It is a synthetic element (an element that can be created in a laboratory but is not found in nature) and radioactive; the most stable known isotope, 267Rf, has a half-life of approximately 1.3 hours.")
    End Sub

    Private Sub DubniumButton_Click(sender As Object, e As RoutedEventArgs) Handles DubniumButton.Click
        ShowElementWindow("Dubnium", "Dubnium is a chemical element with the symbol Db and atomic number 105, named after the town of Dubna in Russia, where it was first produced. It is a synthetic element (an element that can be created in a laboratory but is not found in nature) and radioactive; the most stable known isotope, dubnium-268, has a half-life of approximately 28 hours.")
    End Sub

    Private Sub SeaborgiumButton_Click(sender As Object, e As RoutedEventArgs) Handles SeaborgiumButton.Click
        ShowElementWindow("Seaborgium", "Seaborgium is a synthetic chemical element with the symbol Sg and atomic number 106. Seaborgium is a synthetic element whose most stable isotope 271Sg has a half-life of 1.9 minutes. A new isotope 269Sg has a potentially slightly longer half-life (ca. 2.1 min) based on the observation of a single decay. Chemistry experiments with seaborgium have firmly placed it in group 6 as a heavier homologue to tungsten.")
    End Sub

    Private Sub BohriumButton_Click(sender As Object, e As RoutedEventArgs) Handles BohriumButton.Click
        ShowElementWindow("Bohrium", "Bohrium is a chemical element with symbol Bh and atomic number 107, named in honor of Danish physicist Niels Bohr. It is a synthetic element (an element that can be created in a laboratory but is not found in nature) and radioactive; the most stable known isotope, 270Bh, has a half-life of approximately 61 seconds.")
    End Sub

    Private Sub HassiumButton_Click(sender As Object, e As RoutedEventArgs) Handles HassiumButton.Click
        ShowElementWindow("Hassium", "Hassium is a chemical element with symbol Hs and atomic number 108, named in honor of the German state of Hesse. It is a synthetic element (an element that can be created in a laboratory but is not found in nature) and radioactive; the most stable known isotope, 269Hs, has a half-life of approximately 9.7 seconds, although an unconfirmed metastable state, 277mHs, may have a longer half-life of about 11 minutes. More than 100 atoms of hassium have been synthesized to date.")
    End Sub

    Private Sub MeitneriumButton_Click(sender As Object, e As RoutedEventArgs) Handles MeitneriumButton.Click
        ShowElementWindow("Meitnerium", "Meitnerium is a chemical element with the symbol Mt and atomic number 109. It is an extremely radioactive synthetic element (an element that can be created in a laboratory but is not found in nature); the most stable known isotope, meitnerium-278, has a half-life of 7.6 seconds. Meitnerium was first created in 1982 by the GSI Helmholtz Centre for Heavy Ion Research near Darmstadt, Germany. It is named after the physicist Lise Meitner.")
    End Sub

    Private Sub DarmstadtiumButton_Click(sender As Object, e As RoutedEventArgs) Handles DarmstadtiumButton.Click
        ShowElementWindow("Darmstadtium", "Darmstadtium is a chemical element with the symbol Ds and atomic number 110. It is an extremely radioactive synthetic element (an element that can be created in a laboratory but is not found in nature). The most stable known isotope, darmstadtium-281, has a half-life of approximately 11 seconds, but it is possible that this darmstadtium isotope may have an isomer with a longer half-life, 3.7 minutes. Darmstadtium was first created in 1994 by the GSI Helmholtz Centre for Heavy Ion Research in Darmstadt-Arheilgen near Darmstadt, Germany. It was named after the city of Darmstadt, where it was discovered.")
    End Sub

    Private Sub RoentgeniumButton_Click(sender As Object, e As RoutedEventArgs) Handles RoentgeniumButton.Click
        ShowElementWindow("Roentgenium", "Roentgenium is a chemical element with the symbol Rg and atomic number 111. It is an extremely radioactive synthetic element (an element that can be created in a laboratory but is not found in nature); the most stable known isotope, roentgenium-281, has a half-life of 26 seconds. Roentgenium was first created in 1994 by the GSI Helmholtz Centre for Heavy Ion Research near Darmstadt, Germany. It is named after the physicist Wilhelm Röntgen (also spelled Roentgen).")
    End Sub

    Private Sub CoperniciumButton_Click(sender As Object, e As RoutedEventArgs) Handles CoperniciumButton.Click
        ShowElementWindow("Copernicium", "Copernicium is a chemical element with symbol Cn and atomic number 112. It is an extremely radioactive synthetic element that can only be created in a laboratory. The most stable known isotope, copernicium-285, has a half-life of approximately 29 seconds, but it is possible that this copernicium isotope may have an isomer with a longer half-life, 8.9 min. Copernicium was first created in 1996 by the GSI Helmholtz Centre for Heavy Ion Research near Darmstadt, Germany. It is named after the astronomer Nicolaus Copernicus.")
    End Sub

    Private Sub UnuntriumButton_Click(sender As Object, e As RoutedEventArgs) Handles UnuntriumButton.Click
        ShowElementWindow("Ununtrium", "Ununtrium is the temporary name of a chemical element with the temporary symbol Uut and atomic number 113. It is an extremely radioactive synthetic element (an element that can be created in a laboratory but is not found in nature); the most stable known isotope, ununtrium-286, has a half-life of 20 seconds. Ununtrium was first created in 2003 by the Joint Institute for Nuclear Research in Dubna, Russia.")
    End Sub

    Private Sub FleroviumButton_Click(sender As Object, e As RoutedEventArgs) Handles FleroviumButton.Click
        ShowElementWindow("Flerovium", "Flerovium is the radioactive chemical element with the symbol Fl and atomic number 114. The element is named after Russian physicist Georgy Flyorov, the founder of the Joint Institute for Nuclear Research in Dubna, Russia, where the element was discovered. The name was adopted by IUPAC on May 30, 2012.")
    End Sub

    Private Sub UnunpentiumButton_Click(sender As Object, e As RoutedEventArgs) Handles UnunpentiumButton.Click
        ShowElementWindow("Ununpentium", "Ununpentium is the temporary name of a synthetic superheavy element in the periodic table that has the temporary symbol Uup and has the atomic number 115.")
    End Sub

    Private Sub LivermoriumButton_Click(sender As Object, e As RoutedEventArgs) Handles LivermoriumButton.Click
        ShowElementWindow("Livermorium", "Livermorium is the synthetic superheavy element with the symbol Lv and atomic number 116. The name was adopted by IUPAC on May 31, 2012.")
    End Sub

    Private Sub UnunseptiumButton_Click(sender As Object, e As RoutedEventArgs) Handles UnunseptiumButton.Click
        ShowElementWindow("Ununseptium", "Ununseptium is the temporary name of a superheavy artificial chemical element with temporary symbol Uus and atomic number 117. The element, also known as eka-astatine or simply element 117, is the second-heaviest of all the elements that have been reportedly created so far and is the second-to-last element of the 7th period of the periodic table. Its discovery was first announced in 2010—synthesis was claimed in Dubna, Russia, by a joint Russian–American collaboration, thus making it the most recently discovered element. Another experiment in 2011 created one of its daughter isotopes using a different method, partially confirming the results of the discovery experiment, and the original experiment was repeated successfully in 2012. The IUPAC/IUPAP Joint Working Party (JWP), however, has made no comment yet on whether or not the element can be recognized as discovered.")
    End Sub

#End Region

End Class