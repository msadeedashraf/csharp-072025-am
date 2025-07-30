# C# Inheritance Assignments – Real-World Domains

This document contains structured OOP assignments in C#, each focusing on **inheritance**, **abstract classes**, **method overriding**, **polymorphism**, and **interfaces** using different real-world domains.

---

## 🍽️ Domain 1: Restaurant Management System

### Assignment 1: Base Class - `RestaurantEmployee`

**Objective:** Understand base classes and shared behavior.

**Instructions:**
- Create a class `RestaurantEmployee` with:
  - Fields: `Name`, `EmployeeID`
  - Property: `ShiftTime` (get/set)
  - Method: `StartShift()` prints basic info

---

### Assignment 2: Derived Classes - `Chef`, `Server`

**Objective:** Use inheritance to define different roles.

**Instructions:**
- Create `Chef` class:
  - Method: `PrepareDish(string dish)`
- Create `Server` class:
  - Method: `TakeOrder()`

---

### Assignment 3: Abstract Method - `PerformDuty()`

**Objective:** Use an abstract method for role-specific duties.

**Instructions:**
- Make `RestaurantEmployee` an abstract class.
- Add `abstract void PerformDuty();`
- Implement in `Chef` and `Server`.

---

### Assignment 4: Interface - `ICleanable`

**Objective:** Apply interfaces for shared behavior.

**Instructions:**
- Define interface `ICleanable` with method `void Clean()`
- Implement in both `Chef` and `Server`
- Loop through list of `ICleanable` and call `Clean()`

---

### Sample Use Case:

- Chef prepares dishes and performs duty
- Server takes orders and performs duty
- Both clean their stations

---

## 🏫 Domain 2: School Management System

### Assignment 1: Base Class - `SchoolMember`

**Instructions:**
- Fields: `Name`, `ID`
- Property: `Department`
- Method: `DisplayInfo()`

---

### Assignment 2: Derived Classes - `Teacher`, `Student`

**Instructions:**
- `Teacher`:
  - Property: `Subject`
  - Method: `Teach()`
- `Student`:
  - Property: `GradeLevel`
  - Method: `Study()`

---

### Assignment 3: Abstract Method - `PerformRole()`

**Instructions:**
- Make `SchoolMember` abstract.
- Add `abstract void PerformRole();`
- Implement in `Teacher` and `Student`.

---

### Assignment 4: Polymorphism with List

**Instructions:**
- Create a list of `SchoolMember`
- Add multiple `Teacher` and `Student` objects
- Loop through and call `PerformRole()` using polymorphism

---

### Bonus: Add a `Principal` Class

**Instructions:**
- Inherit from `SchoolMember`
- Add method `EvaluateTeacher()` (print teacher’s name)

---

### Sample Use Case:

- Teacher teaches subject.
- Students study their grade-level curriculum.
- Principal evaluates a teacher.

---

## 🏥 Domain 3: Healthcare System

### Assignment 1: Abstract Class - `MedicalStaff`

**Instructions:**
- Fields: `Name`, `StaffID`
- Abstract method: `PerformDuty()`

---

### Assignment 2: Derived Classes - `Doctor`, `Nurse`

**Instructions:**
- `Doctor`:
  - Property: `Specialty`
  - Method: `Diagnose()`
- `Nurse`:
  - Property: `Ward`
  - Method: `AssistDoctor()`

---

### Assignment 3: Interface - `IAttendPatient`

**Instructions:**
- Create interface `IAttendPatient` with method:
  - `void AttendPatient(string patientName)`
- Implement differently in both `Doctor` and `Nurse`

---

### Assignment 4: Emergency Interface - `IEmergencyResponder`

**Instructions:**
- Interface `IEmergencyResponder` with method:
  - `void RespondToEmergency()`
- Implement in `Doctor`

---

### Bonus: Add `AdminStaff` Class

**Instructions:**
- Inherit from `MedicalStaff`
- Does NOT implement `IAttendPatient`
- Method: `ManageAppointments()`

---

### Sample Use Case:

- Doctor performs duty, diagnoses patient, and responds to emergency.
- Nurse assists doctor and attends patients.
- Admin manages appointment schedules.

---

## 📦 Submission Instructions

Submit:
- All `.cs` files for each assignment
- One `.csproj` or `.sln` if combining into a console app
- Screenshots or console output to demonstrate correctness

---

Happy Coding! 🚀
