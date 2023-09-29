# Księgarnia ebooków (Ebookworld) (06.2023)
Aplikacja została zrealizowana w ramach zajęć projektowych z Zastosowań informatyki w gospodarce na Politechnice Wrocławskiej. Aplikacja Ebookworld ma umożliwić nowym, świeżym autorom osiągnąć sukces na rynku, uzyskać pierwszych czytelników czy recenzje dla swoich książek. Dzięki tej platformie każda pełnoletnia osoba może stać się pisarzem i podzielić się swoją twórczością z innymi. Niezależnie od tego, czy jest ona doświadczonym
autorem, pasjonatem literatury czy początkującym pisarzem, może opublikować swoje dzieło na naszej stronie i udostępnić je czytelnikom.

## Cel projektu
Celem jest projekt, implementacja, testowanie i wdrożenie internetowej księgarni Ebookworld z możliwością sprzedaży własnoręcznie napisanych utworów w formie e-booków w formacie pdf.

## Zakres pracy:
* Projekt:
    * Zdefiniowanie wymagań funkcjonalnych i niefunkcjonalnych,
    * Projekt endpointów,
    * Wykonanie makiet (ang. mockups) widoków interfejsu użytkownika,
    * Zrobienie schematów bazy danych.
* Implementacja:
    * Aplikacja kliencka,
    * Aplikacja serwerowa,
    * Uwierzytelanie i autoryzacja.
* Testowanie:
    * Testy integracyjne kontrolerów oraz serwisów,
* Wdrożenie całego systemu,
* Opracowanie dokumentacji:
    * Prezentacja końcowa,
    * Instrukcje użytkowania,
    * Dokumentacja końcowa.
    
## Zespół:

Uczestnik projektu | Obowiązki             |
-------------------|-----------------------|
 Kamil Dywan       | frontend              |
Damian Janusiak    | backend               |
Bartłomiej Gtfryd  | projekt, dokumentacja |

## Role użytkowników:
* Czytelnik / Autor,
* Administrator.

## Wymagania funkcjonalne:
* Logowanie i rejestacja,
* Edycja konta,
* Tworzenie własnych ebooków,
* Edycja i usuwanie własnych ebooków,
* Wyszukiwanie, filtrowanie i sortowanie ebooków,
* Szczegółowy podgląd ebooka,
* Koszyk,
* Przeprowadzenie transakcji,
* Statystyki autora np. zarobione pieniądze,
* Mechanizm wirtualnego portfela,
* Możliwość wyświetlenia zakupionego ebooka,
* Wyświetlenie historii zakupów,
* Ocenianie ebooków innych użytkowników,
* Wyróżnianie ebooków - lepsze pozycjonowanie i wyraźne graficzne wyróżnienie ebooka,
* Zgłoszenie podejrzenia o plagiat,
* Zarządzanie portalem przez administratora:
    * Możliwość nadawania / odbierania uprawnień administratora lub premium,
    * Podgląd ebooków,
    * Edycja i usuwanie ebooków.
    
## Model biznesowy:
* Prowizja od zakupu książek (10%),
* Płatne konto premium (specjalne promocje oraz darmowe wyróżnienia),
* Wyróżnienia ebooków,
* Reklamy na stronie.
    
## Wymagania niefunkcjonalne:
* Strona jest dostępna w systemie 24/7/365,
* Użytkownik może zmienić rozmiar czcionki i włączyć tryb nocny,
* Użytkownik może wrzucić do 10 własnych e-booków (nie tyczy się użytkowników premium),
* Jest przeprowadzana automatyczna weryfikacja treści e-booków w oparciu o własny prosty oraz zewnętrzny system antyplagiatowy,
* Użytkownik akceptuje regulamin, ponosząc odpowiedzialność za plagiat i oszustwa,
* Technologie:
    * Aplikacja serwerowa:
        * Paradygmat - DDD,
        * Język programowania - C#,
        * Tworzenie aplikacji webowych - ASP .NET Core,
        * Dostęp do danych - Entity Framework Core,
        * Uwierzytelnianie i autoryzacja - ASP. NET Core Identity,
        * PayPal SDK - przeprowadzanie transakcji,
        * Wysyłanie maili -  MailKit,
        * Zewnętrzny system antyplagiatowy - CopyLeaks,
        * Testowanie - XUnit,
        * Mockowanie na potrzeby testowania - Moq,
        * IDE - Visual Studio.
    * Baza danych: T-SQL
    * Aplikacja kliencka:
        * Główny język - TypeScript (rozszerzenie JavaScript),
        * Budowa strony - React,
        * Biblioteka gotowych komponentów - MUI,
        * Zarządzanie odizolowanymi stanami aplikacji - Context API,
        * IDE - Visual Studio Code.
    * Wdrożenie:
        * Aplikacja kliencka i serwerowa - Azure App Service,
        * Baza danych: Azure SQL Database.
    * Inne:
        * Prezentacja - Microsoft Powerpoint,
        * Dokumentacja - Microsoft Word,
        * Przeprowadzenie transakcji - PayPal,
        * Instrukcje użytkownika - Scribe,
        * Specyfikacja API - Swagger.
        
## Architektura aplikacji:
Aplikacja została zrealizowana w architekturze monolitycznej. Aplikacja kliencka jest uruchamiana po stronie aplikacji serwerowej.

## Schemat bazy danych:
<p align="center">
    <img src="img/zrzuty-ekranu/erd-1.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/erd-2.png">
</p>

## Tabele bazy danych:
<p align="center">
    <img src="img/zrzuty-ekranu/erd-tabela-1.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/erd-tabela-2.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/erd-tabela-3.png">
</p>

## Specyfikacja API:
<p align="center">
    <img src="img/zrzuty-ekranu/api-1.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/api-2.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/api-3.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/api-4.png">
</p>

<p align="center">
    <img src="img/zrzuty-ekranu/api-5.png">
</p>

## Zrzuty ekranu:
### Strona główna:
<p align="center">
    <img src="img/zrzuty-ekranu/strona-glowna-1.png">
</p>
<p align="center">
    <img src="img/zrzuty-ekranu/strona-glowna-2.png">
</p>

### Aplikacja jest w pełni responsywna do szerokości równej 500px np. widok strony głównej:
<p align="center">
    <img src="img/zrzuty-ekranu/responsywnosc.png">
</p>

### Rejestracja
#### Dane Osobowe:
<p align="center">
    <img src="img/zrzuty-ekranu/rejestracja-dane.png">
</p>

#### Regulamin:
<p align="center">
    <img src="img/zrzuty-ekranu/strona-glowna-1.png">
</p>

### Logowanie:
<p align="center">
    <img src="img/zrzuty-ekranu/strona-glowna-1.png">
</p>

### Resetowanie hasła
#### Podanie adresu e-mail, który został podany przy tworzeniu konta w serwisie:
<p align="center">
    <img src="img/zrzuty-ekranu/resetowanie-hasla-1.png">
</p>

#### Na podany e-mail zostaje wysłany token, który trzeba będzie później wpisać na stronie:
<p align="center">
    <img src="img/zrzuty-ekranu/resetowanie-hasla-2.png">
</p>

### Wprowadzenie otrzymanego tokena oraz ustalenie nowego hasła:
<p align="center">
    <img src="img/zrzuty-ekranu/resetowanie-hasla-3.png">
</p>

### Dane konta:
<p align="center">
    <img src="img/zrzuty-ekranu/dane-konta.png">
</p>

### Edycja danych konta:
<p align="center">
    <img src="img/zrzuty-ekranu/dane-konta-edycja.png">
</p>

### Wyszukiwarka ebooków:
<p align="center">
    <img src="img/zrzuty-ekranu/wyszukiwarka-ebookow.png">
</p>

### Szczegóły ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/szczegoly-ebooka.png">
</p>

### Recenzje ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/recenzje.png">
</p>

### Dodawanie recenzji o ebooku:
<p align="center">
    <img src="img/zrzuty-ekranu/recenzje-dodawanie.png">
</p>

### Zgłoszenie ebooka np. z powodu plagiatu:
<p align="center">
    <img src="img/zrzuty-ekranu/zgloszenie.png">
</p>

### Zakup ebooków
#### Koszyk:
<p align="center">
    <img src="img/zrzuty-ekranu/koszyk-1.png">
</p>

#### Po złożeniu zamówienia następuje przekierowanie do strony PayPal:
<p align="center">
    <img src="img/zrzuty-ekranu/koszyk-2.png">
</p>

### Po zalogowaniu się można już przeprowadzić transakcję:
<p align="center">
    <img src="img/zrzuty-ekranu/koszyk-3.png">
</p>

### Transakcja przebiegła pomyślnie:
<p align="center">
    <img src="img/zrzuty-ekranu/koszyk-4.png">
</p>

### Historia zamówień:
<p align="center">
    <img src="img/zrzuty-ekranu/historia-zamowien.png">
</p>

### Szczegóły zamówienia:
<p align="center">
    <img src="img/zrzuty-ekranu/historia-zamowien-szczegoly.png">
</p>

### Lista zakupionych ebooków:
<p align="center">
    <img src="img/zrzuty-ekranu/zakupione-ebooki.png">
</p>

### Treść ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/ebook.png">
</p>

### Panel twórcy:
#### Statystyki twórcy:
<p align="center">
    <img src="img/zrzuty-ekranu/panel-tworcy-statystyki.png">
</p>

#### Wypłacanie pieniędzy:
##### Podanie kwoty:
<p align="center">
    <img src="img/zrzuty-ekranu/wyplacenie-1.png">
</p>

##### Wypłaty są dokonywane zewnętrznie przez administratora na podstawie otrzymanych e-maili o żądaniach wypłat:
<p align="center">
    <img src="img/zrzuty-ekranu/wyplacenie-2.png">
</p>

#### Lista utworzonych książek:
<p align="center">
    <img src="img/zrzuty-ekranu/panel-tworcy-ksiazki.png">
</p>

#### Tworzenie ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/tworzenie-ebooka-1.png">
</p>
<p align="center">
    <img src="img/zrzuty-ekranu/tworzenie-ebooka-2.png">
</p>

##### Stworzony ebook jest jeszcze niezweryfikowany, czyli niewidoczny dla standardowych użytkowników:
<p align="center">
    <img src="img/zrzuty-ekranu/weryfikacja-ebooka-w-trakcie.png">
</p>

##### Jeśli ebook zostanie odrzucony, to autor tego ebooka będzie musiał go poprawić:
<p align="center">
    <img src="img/zrzuty-ekranu/weryfikacja-ebooka-odrzucony.png">
</p>

##### Jeśli ebook zostanie zaakceptowany, to ebook ten będzie widoczny dla innych użytkowników i tym samym będą mogli go zakupić:
<p align="center">
    <img src="img/zrzuty-ekranu/weryfikacja-ebooka-zaakceptowany.png">
</p>

#### Edycja ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/edycja-ebooka.png">
</p>

#### Usuwanie ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/usuwanie-ebooka.png">
</p>

#### Ustawienie promocji ebooka:
##### Konfiguracja:
<p align="center">
    <img src="img/zrzuty-ekranu/ustalanie-promocji.png">
</p>

##### Stworzona promocja:
<p align="center">
    <img src="img/zrzuty-ekranu/ustawiona-promocja.png">
</p>

##### Ebook z ustawioną promocją jest widoczny w sekcji ebooków z promocjami:
<p align="center">
    <img src="img/zrzuty-ekranu/promocje.png">
</p>

#### Wyrożnienie ebooka:
##### Wykorzystanie darmowego wyróżnienia albo jego zakupienie:
<p align="center">
    <img src="img/zrzuty-ekranu/wyroznienie-ebooka.png">
</p>

##### Przekierowanie do strony PayPal:
<p align="center">
    <img src="img/zrzuty-ekranu/wyroznienie-ebooka-paypal-1.png">
</p>

##### Po zalogowaniu się jest możliwe przeprowadzenie transakcji:
<p align="center">
    <img src="img/zrzuty-ekranu/wyroznienie-ebooka-paypal-2.png">
</p>

##### Komunikat o pomyślnym przeprowadzeniu transakcji:
<p align="center">
    <img src="img/zrzuty-ekranu/wyroznienie-sukces.png">
</p>

##### Widok wyrożnionego ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/wyrozniony-ebook.png">
</p>

### Premium:
#### Nieaktywne konto premium:
<p align="center">
    <img src="img/zrzuty-ekranu/premium.png">
</p>

#### Wybór planu premium:
<p align="center">
    <img src="img/zrzuty-ekranu/premium-plan.png">
</p>

#### Przekierowanie do strony PayPal:
<p align="center">
    <img src="img/zrzuty-ekranu/premium-paypal-1.png">
</p>

#### Zatwierdzenie transakcji:
<p align="center">
    <img src="img/zrzuty-ekranu/premium-paypal-2.png">
</p>

#### Informacja o pomyślnym przeprowadzeniu transakcji:
<p align="center">
    <img src="img/zrzuty-ekranu/premium-sukces.png">
</p>

#### Widok aktywnego statusu konta premium:
<p align="center">
    <img src="img/zrzuty-ekranu/premium-zakupione.png">
</p>

### Ułatwienia dostępu:
#### Strona główna (odniesienie):
<p align="center">
    <img src="img/zrzuty-ekranu/powiekszanie-1.png">
</p>

#### Powiększenie tekstu:
<p align="center">
    <img src="img/zrzuty-ekranu/powiekszanie-2.png">
</p>

#### Tryb nocny:
<p align="center">
    <img src="img/zrzuty-ekranu/tryb-nocny.png">
</p>

### Regulamin:
<p align="center">
    <img src="img/zrzuty-ekranu/regulamin.png">
</p>

### Weryfikacja ebooków (Recenzent)
#### Lista ebooków do zweryfikowania:
<p align="center">
    <img src="img/zrzuty-ekranu/weryfikacja.png">
</p>

#### Formularz weryfikacji ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/weryfikacja ebooka.png">
</p>

### Zarządzanie użytkownikami (Administrator):
#### Lista użytkowników:
<p align="center">
    <img src="img/zrzuty-ekranu/dane-uzytkownikow.png">
</p>

#### Dane użytkownika:
<p align="center">
    <img src="img/zrzuty-ekranu/zarzadzanie-danymi-uzytkownika.png">
</p>

### Zgłoszenia (Administrator):
#### Lista zgłoszeń:
<p align="center">
    <img src="img/zrzuty-ekranu/zgloszenia.png">
</p>

#### Widok zgłoszenia ebooka:
<p align="center">
    <img src="img/zrzuty-ekranu/zgloszenie-ebooka.png">
</p>

#### Dostępne statusy zgłoszeń:
<p align="center">
    <img src="img/zrzuty-ekranu/zgloszenie-ebooka-statusy.png">
</p>

## Instrukcje użytkownika:
### Jak założyć konto: https://scribehow.com/shared/Jak_zalozyc_konto_w_sklepie_Ebookworld__hACUt2YaRWWwAfKZhNOCAQ
### Jak dodać własnego ebooka: https://scribehow.com/shared/Jak_dodac_wlasnego_ebooka_w_sklepie_Ebookworld__zTJ1sM_nStOFHd9JaW2oiA
