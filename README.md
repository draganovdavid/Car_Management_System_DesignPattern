<h1 align="center">🚗 Car Management System</h1>

<p align="center">
  Design Patterns Project in C#
</p>

<p align="center">
  Factory Method • Adapter • Observer
</p>

---

# 📌 Overview

**Car Management System** is a C# project created to demonstrate the implementation of several popular **Design Patterns** in object-oriented programming.

The application simulates a small car management system where:

- different car objects can be created;
- GPS systems can be integrated through adapters;
- customers receive automatic notifications when changes occur.

---

# 🛠 Technologies Used

- **C#**
- **.NET**
- **Visual Studio**
- **Object-Oriented Programming (OOP)**

---

# 📚 Design Patterns Used

# 1️⃣ Factory Method Pattern

## 📖 Purpose

The Factory Method pattern is used for creating different types of car objects without directly instantiating them using the `new` keyword.

---

## ✅ Used Classes

- `ICar`
- `BMW`
- `Audi`
- `CarFactory`
- `BMWFactory`
- `AudiFactory`

---

## 💡 Benefits

- Easy to extend with new car types
- Reduces dependency on concrete classes
- Improves code flexibility

---

# 2️⃣ Adapter Pattern

## 📖 Purpose

The Adapter pattern allows old GPS systems to work with a new interface.

---

## ✅ Used Classes

- `IGPS`
- `OldGPS`
- `GPSAdapter`

---

## 💡 Benefits

- Reuses old code
- Makes incompatible systems work together
- Simplifies integration

---

# 3️⃣ Observer Pattern

## 📖 Purpose

The Observer pattern is used to notify customers automatically when changes occur in the system.

---

## ✅ Used Classes

- `IObserver`
- `Customer`
- `CarMarket`

---

## 💡 Benefits

- Automatic notifications
- Low coupling between classes
- Easy to add new observers

---

# ⚙️ How the Application Works

## Step 1 — Create a Car

A car object is created using the Factory Method pattern.

---

## Step 2 — GPS Navigation

An old GPS system is connected through an Adapter.

---

## Step 3 — Customer Notifications

Customers subscribe to the market and receive notifications through the Observer pattern.

---

# ▶️ Example Output

```text
BMW created
Old GPS navigation...
Ivan received: BMW price decreased!
Maria received: BMW price decreased!
```

---

# 📂 Project Structure

```text
CarManagementSystem/
│
├── Factory/
│   ├── ICar.cs
│   ├── BMW.cs
│   ├── Audi.cs
│   ├── CarFactory.cs
│   ├── BMWFactory.cs
│   └── AudiFactory.cs
│
├── Adapter/
│   ├── IGPS.cs
│   ├── OldGPS.cs
│   └── GPSAdapter.cs
│
├── Observer/
│   ├── IObserver.cs
│   ├── Customer.cs
│   └── CarMarket.cs
│
└── Program.cs
```

---

# 🎯 Learning Objectives

This project demonstrates:

- practical usage of Design Patterns;
- object-oriented programming principles;
- code organization and extensibility;
- software architecture basics.

---

# ✅ Conclusion

The project successfully demonstrates how different Design Patterns solve specific software development problems.

Using patterns such as:

- **Factory Method**
- **Adapter**
- **Observer**

makes the code:

- cleaner;
- easier to maintain;
- easier to extend;
- more scalable.

---

# 👨‍💻 Author (David Draganov)

Student project created for educational purposes.
