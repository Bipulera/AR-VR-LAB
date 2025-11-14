# AR-VR-LAB
AR flashcards for Planets and VR car simulation


---

#  VR Car Simulation & AR Smart Textbook**


This repository contains two interactive immersive applications developed using **Unity 6**, **C#**, **VR**, and **Vuforia AR**:

1. **VR Car Simulation** – An endlessly generated city driving experience in VR using button-based car controls.
2. **AR Smart Textbook – Planet Visualization** – Scan textbook images to view 3D planets using AR.

Both applications are optimized for smooth performance, educational use, and demonstration-friendly interaction.

---

# 📌 **Project Contents**

* VR Car Simulation (Unity Project)
* AR Smart Textbook (Unity + Vuforia Project)
* Scripts (C#)
* Assets & Prefabs
* Build Instructions
* Usage Guide
* Testing Guide
* Project Architecture Documentation

---

# -------------------------------------------------------------

# 🚗 **1. VR Car Simulation Project**

# -------------------------------------------------------------

## 📝 **Overview**

The **VR Car Simulation** is a virtual reality driving environment where a player drives a car through an **endlessly generated procedural city**. The simulation uses **button-based VR controls**, avoiding complex gestures and making the experience accessible on basic VR devices.

Unity components used:

* **Rigidbody**, **WheelCollider**
* Smooth camera follow scripts
* Procedural environment generator
* Object cleanup & optimization

---

## 🎯 **Objectives**

* Create a VR-based car simulation with realistic physics.
* Provide simple touch/button controls for VR.
* Implement an **infinite city generator** for an endless driving experience.
* Optimize performance to prevent memory overload.
* Use modular C# scripts for easy scalability.

---

## 🛠️ **Development Tools**

| Tool                        | Purpose                                  |
| --------------------------- | ---------------------------------------- |
| **Unity 6.2 (6000.2.10f1)** | Game engine for VR simulation            |
| **C#**                      | Physics, input, world generation scripts |
| **VS Code**                 | Code editing & debugging                 |
| **Android Build Support**   | For APK exports if required              |

---

## 📁 **Project Structure**

```
VR_Car_Simulation/
│
├── Assets/
│   ├── Scripts/
│   │   ├── CarController.cs
│   │   ├── CameraMovement.cs
│   │   ├── FollowCar.cs
│   │   ├── EndlessCity.cs
│   │   ├── DestroyOnContact.cs
│   │   ├── LaneMovement.cs
│   │   └── Vehicle.cs
│   ├── Prefabs/
│   ├── Models/
│   ├── Materials/
│   └── Scenes/
│
├── ProjectSettings/
├── Packages/
└── README.md
```

---

## ▶️ **How to Run the VR Car Simulation**

### **1. Open the Project**

* Install **Unity 6.x**
* Go to **File → Open Project**
* Select the VR Car Simulation folder.

### **2. Scene Setup**

* Open `MainScene.unity`
* Ensure the following GameObjects are assigned:

  * Car prefab with `CarController`
  * VR Camera Rig
  * Endless City Blocks
  * UI Button Controls

### **3. Play Mode**

* Press **Play**
* Use your VR device or on-screen **Left / Right / Accelerate / Brake** buttons.

### **4. Build for Android VR**

Go to:
**File → Build Settings → Android → Build**

---

## 🎮 **Controls**

| Action      | Input                  |
| ----------- | ---------------------- |
| Accelerate  | UI Button / Keyboard W |
| Brake       | UI Button / Keyboard S |
| Steer Left  | UI Button / Keyboard A |
| Steer Right | UI Button / Keyboard D |

---

## 🧩 **Script Descriptions**

### **✔ CarController.cs**

Handles:

* Motor torque
* Steering
* Brake force
* Wheel physics
* Center of mass adjustments
* VR button input

### **✔ CameraMovement.cs**

* Third-person camera following the car smoothly.

### **✔ EndlessCity.cs**

* Two road/city segments reposition forward as the car moves.
* Gives infinite driving effect without heavy performance usage.

### **✔ DestroyOnContact.cs**

* Destroys leftover objects behind the player to free memory.

### **✔ LaneMovement.cs**

* Ensures lane/road props follow car trajectory.

### **✔ Vehicle.cs**

* Simple AI vehicles for background movement.

---

# -------------------------------------------------------------

# 📘 **2. AR Smart Textbook – Planet Visualization**

# -------------------------------------------------------------

## 📝 **Overview**

The **AR Smart Textbook** app uses **Vuforia** to recognize printed textbook images and display **3D planetary models** on top of them.

Includes:

* Image Targets (Sun, Earth, Venus, Saturn)
* 3D planetary models
* AR Camera
* No UI buttons needed — works automatically

---

## 🎯 **Objectives**

* Enable AR-based learning using textbooks.
* Automatically detect printed diagrams.
* Display accurate 3D models with stable tracking.
* Provide smooth, lag-free AR visualization.

---

## 🛠️ **Development Tools**

| Tool            | Use                                 |
| --------------- | ----------------------------------- |
| Unity 6.2       | AR app development                  |
| Vuforia Engine  | Image tracking                      |
| Android SDK/NDK | APK build                           |
| 3D Models       | Planet models from online libraries |

---

## ▶️ **How to Use the AR App (APK)**

1. Install the `planets.apk` file on an Android device.
2. Grant **Camera Permission**.
3. Point your camera at the printed planet image.
4. The 3D model appears automatically.

---

## 🧪 **Testing & Verification**

To properly test the AR app:

### **1. Image Recognition Test**

* Test under good lighting.
* Ensure no glare or reflection on the image.
* Try different angles.

### **2. Stability Test**

Check:

* 3D model stays stable when the camera moves.
* No jitter or shaking.

### **3. Accuracy Test**

* Each planet should load the correct 3D model.

### **4. Device Compatibility**

Recommended:

* Android 8.0+
* 3GB RAM+
* Camera autofocus support

---


# 📌 **3. Future Scope**

### **VR Car Simulation**

* AI traffic & pedestrians
* Day/Night cycle
* Steering wheel VR interaction
* Multiplayer VR driving
* Car customization

### **AR Smart Textbook**

* Audio explanations
* Info panels describing planets
* Planet animations
* Multiple target tracking
* Quiz mode for education

---

# -------------------------------------------------------------

# 🏁 **Conclusion**

This project combines VR and AR technologies to deliver immersive learning and simulation environments.
It demonstrates:

* Realistic VR driving
* Interactive AR-based textbook enhancement
* Strong Unity & C# integration
* Optimized performance and modular code


