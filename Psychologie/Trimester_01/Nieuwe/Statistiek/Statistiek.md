# Module 1: Inleiding
## Hoorcollege 1: Statistiek in Onderzoek
### Wat is onderzoek?
- Wetenschappelijke onderzoek
	- Een doelgericht proces, waarbij een onderzoeker op systematische manier betrouwbare en valide gegevens (of data) verzamelt en analyseert om onderzoekvragen te beantwoorden en zo een uitspraak te doen over een werkelijkheid
- Psychologisch onderzoek
	- Kennis genereren over de psychologische werkelijkheid

- De Empirische cyclus: Fasen in onderzoek 
	- Fase 1 - Probleemstelling & onderzoekvragen
		- Identificeren van het probleem
		- Vagen formuleren die onderzocht moeten worden om het probleem op te lossen
	- Fase 2 - Literatuurstudie
		- Literatuur raadplegen om meer te weten te komen over het onderzoeksonderwerp
		- Stand van zaken huidige wetenschappelijke kennis in welbepaald domein
	- Fase 3 - Onderzoekontwerp
		- Plan van aanpak opstellen: wat wordt onderzocht en hoe wordt dat onderzocht? 
		- Waar en wanneer zal het onderzoek plaatvinden? 
	- Fase 4 - Dataverzameling
		- Data (Gegevens) verzamelen om antwoord te bieden op de onderzoeksvraag
		- Hoe data worden verzameld wordt vastgelegd in het onderzoek ontwerp
	- Fase 5 - Data-analyse
		- Verzamelde gegevens analyseren om antwoord te bieden op de onderzoeksvraag
		- Welke analyse worden uitgevoerd wordt vastgelegd in het onderzoek ontwerp
	- Fase 6 - Rapporteren
		- Resultaten / inzichten communiceren
		- Verschillende vormen van rapportage

### Wat is Statistiek?
- Statistiek = Wetenschap van het verzamelen, classificeren, samenvatten, organiseren, analyseren, interpreteren en rapporteren van onderzoeksgevens
- Doel = Algemeen geldende uitspraken doen over wetmatigheden in de steekproef of populatie op basis van waarnemingen

#### Steekproef Vs Populatie
- steekproef
	- Een representatieve selectie van individuen uit de populatie die daadwerkelijk wordt onderzocht met als doel betrouwbare informatie te verkrijgen over de populatie
	- ![[Pasted image 20250923094257.png]]
- Populatie
	- Het geheel van individuen waarvoor de onderzoeker een uitspraak wil doen

### beschrijvende en inductieve statistiek?
- Beschrijvende Statistiek
	- Het samenvattend beschrijven van de kenmerken van de groep onderzoekseenheden die je onderzocht hebt
- Inductieve Statistiek
	- Op basis van de steekproefgegevens uitspraken trachten te doen over de populatie4

## Hoorcollege 2: Basiselementen uit de datamatrix
### De datamatrix
![[Pasted image 20251007113229.png]]

### Onderzoekseenheden
- *Onderzoekseenheden* over wie/wat wil je op basis van je onderzoek een uitspraak doen?
- Onderzoekseenheden zijn niet altijd een personen! Kunnen ook huishoudens, zake, gebeurtenissen, bedrijven... zijn

### Variabelen 
- *Variabelen*: Kenmerken van de onderzoeksheden die onderzocht worden
	- Een variabele varieert tussen de verschillende onderzoekseenheden, anders zou het niet interessant zijn om te bestuderen.
	- Voorbeelden: Leeftijd, geslacht, inkomen, studiekeuze, mentale problemen
	- Meestal worden in een studie meerdere variabelen onderzocht, waarbij het ook vaak interessant is om te kijken naar de relatie tussen de variabelen

### (Meet)waarden
- *Waarden* verwijzen naar specefiek getal of categorieen die een variable kan aanemen
- *Meetwaarden* zijn de daadwerkelijke getallen of data die worden verzameld als  resultaat van een meting

![[Pasted image 20251007113935.png]]
## Hoorcollege 3: Data voorbereiden voor kwantitatieve data-analyse
### 3.1 Data Verzamelen

#### Fase 4: Dataverzameling
- Gegevens verzamelen om onderzoeksvraag te beantwoorden.  
- Methode vastgelegd in onderzoeksontwerp (enquête, interview, test, ...).  
- In Statistiek 1: focus op **surveydata**.

#### 3.1.1 Dataverzameling: Surveydata
> “Een survey is een systematische ondervraging van personen op een groot aantal vraagpunten met identieke vragen.”  
**Fasen surveyonderzoek:**
1. Vragen opstellen  
2. Respondenten bevragen  
3. Antwoorden ontvangen (data)  
4. Data cleanen  
5. Data analyseren (bv. in SPSS)  
6. Rapporteren van resultaten

#### 3.1.2 Opstellen van een Survey
**Belangrijke aandachtspunten:**
1. **Onderzoeksvraag & variabelen**
   - Hoofdvraag + deelvragen bepalen variabelen.  
   - Literatuurstudie helpt relevante variabelen kiezen.  
   - Voorbeeld: onderzoek naar drempels bij volwassenen met ADHD → variabele “productiviteit”.

2. **Operationaliseren & meetniveau**
   - Hoe worden concepten bevraagd?  
   - Gebruik gevalideerde vragenlijsten indien mogelijk.  
   - Detailniveau bepaalt analysemogelijkheden (ordinaal vs. ratio).  
   - Meer detail = meer analysemogelijkheden.

3. **Antwoordmogelijkheden**
   - **Mutueel exclusief:** geen overlap in categorieën.  
   - **Exhaustief:** alle opties aanwezig.  
   - Voorbeeld: vervoer → auto, bus, trein, fiets, te voet, ander.

4. **Vraagstelling**
   - Formuleer duidelijk, zonder vaktaal of dubbele ontkenning.  
   - Bevraag één concept per vraag.  
   - Vermijd sturende vragen.  

5. **Doelgroep bepalen**
   - Stel **inclusie- en exclusiecriteria** op.  
   - Zorgt voor betrouwbare resultaten.

---

### 3.2 Data Invoeren

#### 3.2.1 Manueel Invoeren
- Gebruikt bij papieren vragenlijsten.  
- **Stap 1: Variable view**
  - Elke rij = variabele  
  - Belangrijke kolommen:
    - **Name:** unieke naam  
    - **Type:** numeric (SPSS standaard)  
    - **Label:** beschrijving van variabele  
    - **Values:** codeboek (bv. 1=ja, 2=nee)  
    - **Missing values:** aangeven van ontbrekende of irrelevante antwoorden  
    - **Measure:** nominaal / ordinaal / schaal  

- **Stap 2: Data view**
  - Elke rij = respondent  
  - Elke kolom = variabele  
  - Elke cel = één meetwaarde  

**Bij meerdere antwoorden:**  
→ aparte variabelen aanmaken per antwoordmogelijkheid (0 = niet aangeduid, 1 = aangeduid).

#### 3.2.2 Data Importeren
- Online platforms (Qualtrics, Surveymonkey) leveren databestand (Excel/CSV).  
- **Excel importeren:**
  - File → Import data → Excel → selecteer bestand → vink *read variable names from first row* aan.  
- **CSV importeren:**
  - File → Import data → CSV → *first line contains variable names* aanvinken.  
- Controleer altijd variable view nadien!

---

### 3.3 Data Cleaning

#### Doel
- Data controleren en opschonen vóór analyse.  
> “Tidy datasets are all alike, but every messy dataset is messy in its own way.” – *Hadley Wickham*

#### Controlepunten
**Variable view:**
- Type correct?  
- Label ingevuld?  
- Values kloppen met codeboek?  
- Missing values aangeduid?  
- Meetniveau correct?

**Data view:**
- Verwijder:
  - Duplicaten  
  - Irrelevante data, cases of variabelen  
  - Fouten (eenmalig of structureel)  

**Duplicaten verwijderen:**  
Data → Identify duplicate cases → Matching variables → 1 = uniek, 0 = duplicaat  

**Irrelevante data:**  
- Cases: niet-behorende respondenten, slordige of onrealistische antwoorden  
- Variabelen: overbodige info (IP, locatie, ID)

**Fouten opsporen:**
- Eenmalige fouten → corrigeer of markeer als user missing  
- Structurele fouten → opsporen via frequentietabel, aanpassen via RECODE

---

### 3.4 Data Transformeren

#### Doel
- Voorbereidende bewerkingen uitvoeren vóór analyse.

**Soorten transformaties:**
1. **Filteren:** analyse uitvoeren op subgroep (bv. alleen vrouwen).  
2. **Nieuwe variabelen aanmaken (COMPUTE):**  
   - bv. Leeftijd = 2025 - geboortejaar  
3. **Schalen opstellen:**  
   - Meerdere items → één totaalscore (bv. Perceived Stress Scale).  
   - Soms spiegelen (omcoderen) nodig bij omgekeerde items.  
4. **Hercoderen:**  
   - Spiegelen  
   - Structurele fouten corrigeren  
   - Categorieën samenvoegen (bv. leeftijd → minderjarig/volwassen)

# Module 2: Het beschrijven van een variabele

# Module 3: Het beschrijven van twee variabele