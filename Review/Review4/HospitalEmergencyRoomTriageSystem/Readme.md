Bilkul. Neeche aapke **current code + 10 NUnit tests** ke according `README.md` ready hai. Isko direct apne project ke `README.md` mein paste kar sakte ho.

# Hospital Emergency Room Triage System

## 1. Project Overview

The **Hospital Emergency Room Triage System** is a C# console-based application designed to manage patients in an Emergency Room (ER).

The system demonstrates the use of different data structures for different hospital management tasks:

* Patient records using `Dictionary`
* Patient searching using Binary Search
* Doctor management using Circular Linked List
* Bed management using Doubly Linked List
* Patient priority based on medical condition
* NUnit unit testing for important operations

The main purpose of the project is to demonstrate how multiple data structures can be used together to solve a real-world hospital emergency management problem.

---

## 2. Objectives

The main objectives of this project are:

1. Store and manage patient information.
2. Search patients using Patient ID.
3. Maintain doctors using a circular linked list.
4. Assign available doctors to patients.
5. Track bed occupancy using a doubly linked list.
6. Handle cases where doctors or beds are unavailable.
7. Test the application using NUnit.
8. Demonstrate different data structures and their applications.

---

## 3. Data Structures Used

### 3.1 Dictionary

A `Dictionary<int, string>` is used for maintaining patient records.

The Patient ID is used as the key and the patient's name is stored as the value.

```text
Patient ID → Patient Name
```

Example:

```text
103 → Prashansa
123 → Babita
293 → Pooja
```

The dictionary provides fast average-case lookup.

**Average Time Complexity:** `O(1)`

---

### 3.2 Binary Search

The `PatientSearch()` method searches for a patient using Patient ID.

Before performing binary search, the patients are sorted according to their Patient ID.

Example sorted IDs:

```text
103, 123, 293, 312, 568
```

Binary search is then performed on the sorted list.

**Time Complexity:** `O(log n)` for the search after sorting.

---

### 3.3 Circular Linked List

Doctors are maintained using a circular linked list.

Example:

```text
Anoop → Anisa → Mukesh
  ↑               ↓
  └───────────────┘
```

Each doctor points to the next doctor, and the last doctor points back to the first doctor.

This structure allows the system to check doctors cyclically.

Each doctor has:

```csharp
public Doctor Next { get; set; }
public bool IsBusy { get; set; }
```

The system checks for an available doctor and assigns the patient.

---

### 3.4 Doubly Linked List

Beds are maintained using a doubly linked list.

Example:

```text
NULL ← Bed 1 ⇄ Bed 2 ⇄ Bed 3 → NULL
```

Each bed contains:

```csharp
public Bed Prev { get; set; }
public Bed Next { get; set; }
```

This allows traversal in both directions.

The system checks the list for an available bed.

If a bed is available:

```text
IsAvail = true
```

After assigning it:

```text
IsAvail = false
```

---

## 4. Patient Class

The `Patient` class stores patient information.

```csharp
public class Patient
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Cond { get; set; }
}
```

The patient contains:

* Name
* Patient ID
* Medical condition

Example:

```csharp
new Patient("Babita", 123, "Critical");
```

---

## 5. Doctor Class

The `Doctor` class represents a doctor in the circular linked list.

```csharp
public class Doctor
{
    public string Name { get; set; }
    public Doctor Next { get; set; }
    public bool IsBusy { get; set; }
}
```

`Next` stores the reference to the next doctor.

`IsBusy` indicates whether the doctor is currently available.

---

## 6. Bed Class

The `Bed` class represents a hospital bed.

```csharp
public class Bed
{
    public int BedId { get; set; }
    public Bed Prev { get; set; }
    public Bed Next { get; set; }
    public bool IsAvail { get; set; }
}
```

The `Prev` and `Next` references create the doubly linked list.

---

## 7. Patient Search

The `PatientSearch()` method searches for a patient by ID.

Example:

```csharp
int result = Program.PatientSearch(patients, 103);
```

If the patient exists, the method returns its index.

If the patient does not exist:

```text
-1
```

is returned.

The method also handles an empty list.

---

## 8. Doctor Assignment

The `AddDoctor()` method assigns an available doctor to a patient.

Example:

```csharp
Program.AddDoctor(patient, doctorHead);
```

The method:

1. Starts from the head doctor.
2. Checks whether the doctor is busy.
3. Assigns the first available doctor.
4. Marks the doctor as busy.
5. Continues through the circular linked list if necessary.

If every doctor is busy, the system displays:

```text
All our Doctors are busy!!
```

---

## 9. Bed Occupancy

The `BedOccupancy()` method searches the doubly linked list for an available bed.

Example:

```csharp
Program.BedOccupancy(patient, bedHead);
```

If a bed is available, it becomes occupied.

Output example:

```text
BedId 1 is occupied by the Patient Prashansa
```

If all beds are occupied:

```text
Bed not available
```

is displayed.

---

# 10. NUnit Testing

NUnit is used to test the important functionality of the system.

The project contains **10 NUnit unit tests**.

The tests cover:

1. Patient does not exist
2. Empty patient list
3. Patient search
4. Middle patient search
5. Last patient search
6. Circular doctor linked list
7. Doctor assignment
8. All doctors busy
9. Bed occupancy
10. No bed available

---

## 11. Test Cases

### Test 1 — Patient Not Found

Checks whether searching for a non-existing Patient ID returns `-1`.

```text
Patient ID: 999
Expected Result: -1
```

---

### Test 2 — Empty List

Checks whether searching an empty patient list returns `-1`.

```text
Expected Result: -1
```

---

### Test 3 — First Patient Search

Searches for Patient ID `103`.

After sorting:

```text
103, 123, 293, 312, 568
```

Therefore:

```text
Expected Index: 0
```

---

### Test 4 — Middle Patient Search

Searches for Patient ID `293`.

Expected:

```text
Index: 2
```

---

### Test 5 — Last Patient Search

Searches for Patient ID `568`.

Expected:

```text
Index: 4
```

---

### Test 6 — Circular Doctor List

Checks whether the last doctor points back to the first doctor.

Expected structure:

```text
Anoop → Anisa → Mukesh → Anoop
```

---

### Test 7 — Doctor Assignment

Checks whether an available doctor becomes busy after assignment.

Expected:

```text
IsBusy = true
```

---

### Test 8 — All Doctors Busy

Checks the edge case where all doctors are busy.

Expected output:

```text
All our Doctors are busy!!
```

---

### Test 9 — Bed Occupancy

Checks whether an available bed becomes occupied.

Expected:

```text
IsAvail = false
```

---

### Test 10 — No Available Bed

Checks the situation where all beds are occupied.

Expected output:

```text
Bed not available
```

---

# 12. Complexity Analysis

Let:

* `n` = number of patients
* `d` = number of doctors
* `b` = number of beds

| Operation                   | Time Complexity |
| --------------------------- | --------------: |
| Add patient to list         |          `O(1)` |
| Dictionary insertion        |  `O(1)` average |
| Dictionary lookup           |  `O(1)` average |
| Sorting patients            |    `O(n log n)` |
| Binary search               |      `O(log n)` |
| Doctor search               |          `O(d)` |
| Bed search                  |          `O(b)` |
| Doctor linked-list creation |          `O(d)` |
| Bed linked-list creation    |          `O(b)` |
| Patient record display      |          `O(n)` |
| Bed traversal               |          `O(b)` |

### Binary Search

After sorting, binary search takes:

```text
O(log n)
```

### Doctor Assignment

In the worst case, all doctors may need to be checked:

```text
O(d)
```

### Bed Assignment

In the worst case, all beds may need to be checked:

```text
O(b)
```

---

# 13. Edge Cases Tested

The system handles the following edge cases:

### Empty Patient List

```text
PatientSearch(emptyList, 100)
→ -1
```

### Patient Not Found

```text
PatientSearch(patients, 999)
→ -1
```

### All Doctors Busy

```text
All our Doctors are busy!!
```

### No Available Bed

```text
Bed not available
```

### Circular Doctor List

The last doctor points back to the first doctor.

```text
Anoop → Anisa → Mukesh → Anoop
```

---

# 14. Project Structure

Recommended project structure:

```text
HospitalEmergencyRoom/
│
├── Program.cs
│
├── HospitalTest/
│   └── Tests.cs
│
└── README.md
```

`Program.cs` contains the main application code.

`Tests.cs` contains NUnit unit tests.

`README.md` contains project documentation, design and complexity analysis.

---

# 15. How to Run

### Step 1

Create a C# Console Application.

### Step 2

Add the main source code to:

```text
Program.cs
```

### Step 3

Create an NUnit Test Project.

### Step 4

Add:

```text
NUnit
NUnit3TestAdapter
Microsoft.NET.Test.Sdk
```

packages to the test project.

### Step 5

Add the `Tests.cs` file to the NUnit project.

### Step 6

Make sure the NUnit project has a reference to the main project.

### Step 7

Run the tests using Visual Studio Test Explorer.

Expected result:

```text
Total Tests: 10
Passed: 10
Failed: 0
```

---

# 16. Conclusion

The Hospital Emergency Room Triage System demonstrates the practical use of multiple data structures in a real-world hospital scenario.

The project uses:

```text
Dictionary
    ↓
Patient Records

Binary Search
    ↓
Patient Lookup

Circular Linked List
    ↓
Doctor Management

Doubly Linked List
    ↓
Bed Management

NUnit
    ↓
Unit Testing
```

These data structures help organize patient records, perform efficient searches, manage doctors and beds, and handle important emergency-room operations.
