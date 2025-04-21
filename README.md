# FurnitureSimulator
FurnitureSimulator is a user-friendly Unity-based system that allows players to browse and select furniture models before entering the main gameplay scene. Designed to provide an intuitive and immersive experience, this project streamlines the selection process while maintaining a clean and interactive UI.
# Overview
The FurnitureSimulator is a Unity project developed to enhance user engagement through an intuitive pre-game interface. It allows players to preview and select different furniture models before entering the main gameplay environment. This selection phase ensures that only the chosen object is active, preventing visual clutter and improving focus.
The navigation is designed for ease of use, enabling players to cycle through furniture models using interactive buttons. Circular navigation allows seamless transitions between models, and the selected item is stored to persist across scenes. Once a selection is confirmed, the Gameplay Scene loads with the chosen furniture in place, creating a smooth and immersive experience.
This project demonstrates practical Unity concepts such as scene management, object pooling, persistent data storage, and user interface design, making it a strong foundation for expanding into more complex simulation or AR/VR environments.
# Features
- **Interactive Selection System**:<br>
Players can smoothly browse through different furniture models using Next and Previous buttons, with circular navigation for seamless transitions.

- **Smart Scene Management**:<br>
Only the selected furniture model remains active, keeping the scene clutter-free and focused.

- **Persistent Selection**:<br>
The system remembers the previously chosen model, allowing users to pick up where they left off.

- **Gameplay Integration**:<br>
Once a model is selected, it is stored and carried into the Gameplay Scene, where the selected furniture is showcased.
# Technologies Used
- **Unity Engine**:<br>
For building and running the 3D simulation environment

- **C#**:<br>
For writing scripts to control logic, UI navigation, and scene transitions
  
- **Git & GitHub**:<br>
For version control and project collaboration
  
- **Git LFS (Large File Storage)**:<br>
For managing large assets like `.fbx` model files

- **Visual Studio / VS Code**:<br>
As the primary IDE for development  

- **Vuforia Engine**: <br>
For implementing augmented reality (AR) functionality
# Installation and Build
Follow these steps to install and build the FurnitureSimulator:

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/manasijvs/Arfurnituresimulator.git
   cd Arfurnituresimulator 
2. **Open in Unity**
- **Launch Unity Hub**

- **Click on Add and select the cloned project folder**:
  
- **Ensure you're using a compatible Unity version (e.g., Unity 2021.3 or later)**

3. **Install Vuforia Engine**
- **Go to Window → Package Manager**

- **Click on the + button → Add package from git URL**:
  
- **Use the official Vuforia Git URL**
  ```bash
  https://github.com/Vuforia/vuforia-unity-android-samples.git
- **Alternatively, install from the Unity Asset Store if using the Vuforia Core Samples**

4. **Set Up Vuforia Configuration**
- **Go to File → Build Settings → Player Settings → XR Settings**

- **Enable Vuforia Augmented Reality support**
  
- **Add your Vuforia license key in Vuforia Configuration**

5. **Build the Project**
- **Go to File → Build Settings**

- **Choose your target platform (e.g., Android)**
  
- **Click Build and Run**
