# Basic Facebook Features

A **C# WinForms desktop application** that integrates with the Facebook API to provide rich user interaction and analytics.  
Built as part of an academic software project to showcase UI design, data visualization, and use of object-oriented design patterns.

## 📌 Features

- 🔐 **Facebook login** via `FacebookWrapper.dll`
- 📸 View user's **posts, albums, events, liked pages**
- 📊 Visualize activity using **bar and pie charts**
- 🎨 Customize chart appearance with **color settings**
- ⚡ **Caching system** to reduce API calls and improve performance
- 🧩 Modular UI with dynamic **menu system** and **FlowLayoutPanel** buttons

## 🧠 Design Patterns Implemented

This project applies multiple object-oriented design patterns for modularity, flexibility, and clarity:

### ✅ Builder Pattern
Used in the creation of user activity charts.  
Encapsulates the construction of different chart types (bar/pie) with various configurations.

### ✅ Command Pattern
Used to encapsulate actions behind UI menu buttons.  
Each menu item triggers a command (delegate-based) that performs an API call, cache access, or UI navigation.

### ✅ Decorator Pattern
Used to enhance UI label components dynamically.  
Applies visual effects such as blinking, dimming, or movement on title labels.

### ✅ Factory Method Pattern
Used for creating instances of data analyzers.  
Supports multiple analyzer types such as by category, by hour, or by day.

### ✅ Strategy Pattern
Used to define different data sorting strategies in UI.  
Supports sorting alphabetically, by time, or other user-defined criteria.

### ✅ Prototype Pattern
Used to clone complex analyzer objects before modifications.  
Ensures consistent duplication of internal state without coupling to concrete classes.

## 🗂 Project Structure

```
BasicFacebookFeatures/
├── FacebookWinFormsApp/        # Forms, UI logic, user interaction
├── Diagrams/                   # UML diagrams (Class & Sequence)
├── Resources/                  # DLLs, icons, images
├── .gitignore
├── FacebookApp.sln
└── README.md
```

## 📊 UML Diagrams

All UML diagrams (PDF) are in the [`Diagrams`](./Diagrams) folder:

### 📘 Class Diagrams:
- Builder, Command, Decorator, Factory Method, Prototype, Strategy

### 🔁 Sequence Diagrams:
- Builder, Command, Decorator, Factory, Prototype, Strategy

## 🛠 Technologies

- C# WinForms
- Facebook API (via `FacebookWrapper.dll`)
- System.Windows.Forms.DataVisualization
- Git & GitHub
  
## 📄 License

This project is licensed under the MIT License.  
🔗 [https://github.com/Hadar2001/BasicFacebookFeatures](https://github.com/Hadar2001/BasicFacebookFeatures)
