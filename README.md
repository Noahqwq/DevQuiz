# DevQuiz

Lernprojekt.

DevQuiz ist ein kleines Konsolenquiz für angehende Fachinformatiker:innen. Das Programm stellt Fragen zu C#, Git, GitHub, 
Datenbanken oder allgemeinen IT-Grundlagen. Am Ende wird ein Ergebnis angezeigt.

## Rollen

Repo-Owner: Noah

Koordinator: Hamidu

Git-Coach: Elias

Reviewer: Elias, Noah

Entwickler: alle

---

## Projektziel

Ziel des Projekts ist es,

* den Git- und GitHub-Workflow praktisch anzuwenden,
* gemeinsam an einem C#-Projekt zu arbeiten,
* Änderungen über Branches und Pull Requests einzubringen,
* Reviews durchzuführen und
* Merge-Konflikte kennenzulernen und zu lösen.

---

### Projekt ausführen

```bash
dotnet run
```

Falls das Repository noch nicht lokal vorhanden ist:

```bash
git clone <Repository-URL>
cd DevQuiz
dotnet run
```

---

## Features

* Konsolenbasiertes Quiz
* Fragen zu IT-Themen
* Mehrere Antwortmöglichkeiten pro Frage
* Auswertung der richtigen Antworten
* Prozentuale Ergebnisberechnung
* Übersichtliche Konsolenausgabe

---

## Git-Regeln

Für die Zusammenarbeit gelten folgende Regeln:

* Es wird **nicht direkt auf `main` gearbeitet**.
* Für jede Aufgabe wird ein eigener Feature-Branch erstellt.
* Änderungen werden mit sinnvollen Commit-Nachrichten gespeichert.
* Neue Änderungen werden über Pull Requests eingebracht.
* Jeder Pull Request wird vor dem Merge von mindestens einer anderen Person überprüft.
* Probleme und Lösungen werden dokumentiert.

---

## Verwendeter Git-Workflow

1. Aktuellen Stand holen (`git pull`)
2. Neuen Feature-Branch erstellen
3. Änderungen implementieren
4. Projekt testen (`dotnet run`)
5. Änderungen committen
6. Branch auf GitHub pushen
7. Pull Request erstellen
8. Review durchführen
9. Merge nach erfolgreichem Review

---

## Projektstruktur

```
DevQuiz/
├── Program.cs
├── QuizQuestion.cs
├── QuestionRepository.cs
├── QuizEngine.cs
├── ScoreService.cs
└── README.md
```

---