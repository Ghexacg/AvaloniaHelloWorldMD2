# Avalonia Hello World - Material Design 2 (Android)

A Hello World Android application built with **C# / .NET 8**, **Avalonia UI 11**, and **Material.Avalonia** (Material Design 2 theme).

## 📱 Screenshots

The app features:
- Material Design 2 AppBar (top bar with primary color)
- Material Card with Hello World greeting
- Material Icon (wave hand)
- Material Flat Button with click interaction
- Responsive Material Design 2 color scheme (Primary: #6200EE, Accent: #03DAC5)

## 🏗️ Project Structure

```
AvaloniaHelloWorldMD2/
├── AvaloniaHelloWorldMD2.sln              # Solution file
├── .gitignore
├── README.md
├── AvaloniaHelloWorldMD2/                 # Core shared project
│   ├── AvaloniaHelloWorldMD2.csproj       # Core project file
│   ├── App.axaml                          # Application definition (Material theme)
│   ├── App.axaml.cs                       # Application code-behind
│   ├── MainView.axaml                     # Main UI (Material Design 2 layout)
│   └── MainView.axaml.cs                  # UI code-behind with interaction
└── AvaloniaHelloWorldMD2.Android/         # Android platform project
├── AvaloniaHelloWorldMD2.Android.csproj
├── MainActivity.cs                    # Android entry point
└── Resources/
    └── values/
        └── styles.xml                 # Android Material theme
```

## 🛠️ Tech Stack

| Component | Version |
|-----------|---------|
| .NET | 8.0 |
| Avalonia UI | 11.2.3 |
| Material.Avalonia | 3.7.5 |
| Material.Icons.Avalonia | 2.1.10 |
| Target Android API | 21+ (Android 5.0 Lollipop) |

## 🚀 How to Build & Run

### Prerequisites
- .NET 8 SDK
- Android SDK (API 21+)
- JDK 11+

### Build
```bash
# Clone the repository
git clone https://github.com/Ghexacg/AvaloniaHelloWorldMD2.git
cd AvaloniaHelloWorldMD2

# Restore packages
dotnet restore

# Build Android APK
dotnet build AvaloniaHelloWorldMD2.Android -c Release
```

### Run on Emulator/Device
```bash
dotnet run --project AvaloniaHelloWorldMD2.Android
```

## 📝 Key Features

1. **Material Design 2 Theme** - Uses `Material.Avalonia` for authentic MD2 styling
2. **Material Card** - Content wrapped in elevated Material card
3. **Material Icons** - Hand wave icon from Material Icons library
4. **Interactive Button** - Click counter with Material flat button style
5. **Material AppBar** - Top app bar with primary color
6. **Android Native** - Runs natively on Android 5.0+

## 📄 License

MIT License
