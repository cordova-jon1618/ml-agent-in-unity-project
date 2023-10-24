# Machine Learning (ML Agents) – Using an ML Agent to Navigate an Obstacle Course in Unity 
ML Agent In Unity Project
COMP 565: Advanced Computer Graphics


CONTACT US:
--------------

Jonathan Cordova @cordova-jon1618 - https://github.com/cordova-jon1618 

Vasantha Kumari Borra @vasanthaborra - https://github.com/vasanthaborra

Raj Kumar Lakoji @Raj0763 - https://github.com/Raj0763

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/24f079c4-85bd-47f2-b9e6-e3e35e851cac)


INTRODUCTION
	With the growing popularity of Unity as a game engine, integrating machine learning and artificial intelligence practices into various applications, such as virtual reality, game development, autonomous vehicles, and robotics, has become increasingly relevant. Our interest in this proposal is to explore the limits of what an ML agent is capable of doing in a Unity workspace environment. 
We have chosen to train an ML agent to navigate through obstacle courses, as it is a vital skill for numerous applications. Through our research, we discovered that the Unity application is an excellent environment for training real-world agents, whether it is a robot learning to kick a ball or a self-driving car, as real-world agents are often trained and tested in virtual environments like Unity. We will be using reinforcement learning to train our ML agent, as it is an effective technique that enables an agent to learn from its environment through trial and error. Our report will explore the design goals, system behavior, logical view, process view, development view, physical view, and use case view of this project. 
Overall, our aim is to gain a better understanding of how ML agents can be trained in a Unity environment using reinforcement learning and to investigate the potential applications of such agents.


MEET OUR TEAM
--------------
VASANTHA KUMARI BORRA
----------------------

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/cfcfca2a-8ef4-4154-9f1b-184c2a414478)

Computer Science graduate student at California State University, Northridge (CSUN), my focus lies in Machine Learning.



JONATHAN CORDOVA
----------------------

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/f0c79f6e-5980-4930-bb32-8f0747e8db57)

I am a Computer Science graduate student at California State University, Northridge (CSUN), I am deeply invested in exploring the transformative potential of Artificial Intelligence and Machine Learning. With a plan to graduate in Spring 2024, I seek to expand my knowledge in my area of interest.



RAJ KUMAR LAKOJI
----------------------

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/d79818f8-2fbc-4793-be3c-c2f0b27c4838)

Computer Science graduate student at California State University, Northridge (CSUN), my area of interest is data mining, deep learning, gaming, NLP and robotics. I am also enthusiastic to learn new technologies.



ABOUT OUR REPORT
--------------

This technical report provides an overview of the comprehensive document detailing our Machine Learning (ML) Agent project in Unity. The report begins with an introduction that outlines the purpose and scope of the project, followed by a section introducing our team members and their roles.
Next, the report delves into the specifics of the project, including an overview of the project's aim and the methods used to achieve it. This is followed by a step-by-step guide on how to set up the training environment and proceed after the training phase, providing readers with practical knowledge on handling ML agents.
The "Assets" and "System Behavior" sections offer a detailed examination of the resources used and the overall behavior of the system. A "List of Scenes" provides a snapshot of the different scenarios within the project, while the "High-level Architecture" section outlines the structure of our system, including the UI handler, file handler, and game manager.
The report further delves into a Sequence Diagram and a Detailed Class Diagram, offering both a visual and textual understanding of the system's flow and structure. The "Mid-level Design" segment provides a detailed breakdown of the components and modules, explaining each function under subcomponent sections.
A section on our "Tech Stack" presents the various toolkits, applications, and technologies utilized in the project. Finally, the report concludes with a discussion on the challenges faced during the project and our key takeaways, providing a comprehensive conclusion to our endeavor.

ABOUT OUR PROJECT
--------------

Our Machine Learning (ML) Agent project is a sophisticated endeavor that leverages computer vision techniques, 3D ray perception sensors, incremental rewards, and reinforcement learning paradigms to train an ML Agent to reach a door, the goal state, in a room full of obstacles.
The agent's learning process is driven by reinforcement learning, a type of machine learning where an agent learns to make decisions by taking actions in an environment to achieve the best cumulative reward. The agent is not instructed on how to navigate the room; instead, it learns through trial and error, guided by rewards and penalties.
The reward system plays a critical role in the agent's learning journey. We have implemented an incremental reward system, where the agent receives smaller rewards for making progress towards the goal (e.g., moving closer to the door), and a large reward when it successfully reaches the door. This approach encourages the agent to not only reach the door but also to find the most efficient path to it.
This project stands as a testament to the application of machine learning in creating intelligent systems capable of navigating complex environments. The techniques and methodologies we've applied here have broad implications, extending beyond our specific use-case, and demonstrating the potential of artificial intelligence in problem-solving.

Before You Started - Import the ML Agent Toolkit Package into Unity using Package Manager
-------------------------------------------------------------------------------------------

Here's how you can install a Package Manager package:

●	Open your project in Unity.

●	Go to Window > Package Manager.

 ![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/866351eb-0d76-40d8-b018-e630823a5c64)

●	In the Package Manager window, you can see all the available packages for your project. You can install the ML Agent package by selecting it and clicking the Install button.

 ![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/e79e062d-6a3c-4563-8ae8-4a89727be358)
 
●	Once you've installed the ML Agent package, you should be able to import our project package without losing any references.


How To Get Started - Setting up the Training Environment: 
-----------------------------------------------------------
The training phase for a Machine Learning (ML) Agent in Unity is a critical process that involves a series of steps designed to teach the agent how to navigate and interact within its environment.
Training begins by defining the agent's environment, including the objects, goals, and other elements the agent will interact with. This environment acts as the training ground where the agent learns through trial and error.
Training involves running multiple iterations or episodes where the agent interacts with its environment, makes decisions based on its observations, and receives rewards based on these decisions. The agent's behavior policy, which determines how it makes decisions, is updated over time based on the outcomes of these episodes.
Once the training is complete, the learned behavior policy is exported as a .onnx file or a "brain" which can then be used to control the agent's actions in the environment. The training phase is complete when the agent can successfully navigate its environment and achieve its goal consistently.

-----------------------------------------------------------
**(Skip to the ‘How To Get Started - After Training’ section if you want to see the results only)**
-----------------------------------------------------------

Step 1: Installing Anaconda
-----------------------------------------------------------

●	Go to the Anaconda distribution page at https://www.anaconda.com/distribution/ 

●	Select your OS (Windows, macOS, or Linux).

●	Download the Python 3.x version installer.

●	Once downloaded, run the installer and follow the instructions.

Step 2: Installing Unity ML-Agents Toolkit
-----------------------------------------------------------

●	Once Anaconda is installed, you will need to set up a new environment for ML-Agents.

●	In your Unity project, select Window and then select Package Manager.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/4a6f56d6-0542-4ce4-a2a8-eb58b4523712)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/d3d31484-6e8a-49d0-9862-10e6e38c6da1)

Step 3: Creating a Python Environment with Anaconda
-----------------------------------------------------------
●	Open Anaconda Navigator:

●	Create a new Python environment by selecting Create and typing the following command and pressing Enter:

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/1eebabac-bdac-412e-9fa3-718d9aaf9fa1)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/49821641-6144-4ef7-8929-a255db5c6e0e)

●	Another way to create this environment in Anaconda, is to open the newly installed “Anaconda Prompt”.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/b5d3fa7c-6465-42e4-b454-a28013b8aadb)

●	Run the following command

	○	conda create -n ml-agents-r17 python=3.7

●	This will create a new Python 3.7 environment called “ml-agents-r17” for release 17.

●	Navigate to the Environment section in Anaconda Navigator and select the new environment you just created.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/73c3f542-f64d-4a84-9cdb-737ccb675f0d)

●	Navigate back to Home, and launch the CMD.exe Prompt. Another method to launch the environment is to search for it on your PC. 

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/98286193-c3e6-4e0f-b334-cbc4fdff3f8f)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/bf03edc5-5591-4845-bbd3-4c535d9c098c)

Step 4: Installing PyTorch and the ML Agent into Anaconda
-----------------------------------------------------------

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/bd914963-0486-46cc-9187-0e16b701964a)

●	After launching the prompt in the ML Agent environment, install the following: 

	○	Windows users will need to install PyTorch

	○	pip3 install torch~=1.7.0 -f https://download.pytorch.org/whl/torch_stable.html

	○	Run the following command to install the correct version of mlagents (v0.26.0 in my case):

	○	pip3 install mlagents==0.29.0

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/a18b5618-a7e6-483d-a99c-76de7d1b8e89)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/3ceb0b6f-8c6e-4dfc-800d-cb02b2c8ec42)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/a6bc4c9d-bb4f-482e-938e-2a018262c81a)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/4523c980-d3f0-4dbb-9f11-99e92aa3416f)

Step 5: To Start the Training Phase
-----------------------------------------------------------

●	To run the training of the ML Agent project, navigate to the folder where the project is located.

●	Use either of the below to start training. Give the training file a name that you would like to call your agent’s “brain”.

	○	mlagents-learn --run-id=<filename>

●	Use this command that includes the best parameters for training provided by Unity ML Agent Documentation to make training the most efficient and effective.

	○	mlagents-learn config/moveToGoal.yaml --run-id=<filename>

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/5482649e-17d1-4ece-bd12-63cb93d6bf02)

●	Once you see the “[INFO] Listening on port 5004” notification in the console window. Please press play in the Unity Project to begin the training. NOTE: If you wait too long to press ‘Play’ in Unity, it might time out and you might have to run the command again.

●	If you would like to continue training the ML Agent later, you can use the “--resume” command to continue the training into the same brain file.

	○	mlagents-learn --run-id=<filename> --resume

●	Before pressing play, verify that the Behavior Type for the ML Agent is set to ‘Default’.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/a1eec4ce-604b-4209-93eb-7449ba6388f2)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/4dbd8369-26b0-4520-a8aa-16c302c40581)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/9edc7c33-3ba1-41e7-8cd0-f9e805067e2f)

How To Get Started - After Training:
-----------------------------------------------------------
The deployment phase for a Machine Learning (ML) Agent in Unity follows the successful completion of the training phase. This phase involves utilizing the learned behavior policy, exported as an .onnx file, to control the agent's actions within the environment.

The .onnx (Open Neural Network Exchange) file is essentially the trained model, often referred to as the 'brain' of the agent. This file encapsulates the knowledge and strategies the agent has learned during the training phase. It dictates how the agent will respond to the various states of the environment, based on its learned experiences.
To commence the deployment, the .onnx file is imported into Unity and attached to the respective ML Agent. Once the .onnx file is linked to the agent, it starts utilizing the learned policy for decision-making, effectively navigating and interacting with its environment based on the training it has undergone. It's important to note that the agent's ability to perform well in the environment is directly tied to the quality of the training phase.
Thus, the deployment phase is the fruition of the training process, showcasing the agent's learned abilities in a live environment. It's a testament to the power of machine learning and AI in creating intelligent, adaptable agents within Unity.

●	Find the generated .onnx file in the results folder.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/478611ad-5f20-4455-a147-cc41b24e7727)

●	To run a “brain” file, copy your .onnx file into Unity that was created after the training phase. You can do this by moving the .onnx file to the Assets directory of your Unity project.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/a66fb20a-0b91-476f-a06b-cd900d1a88f0)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/2fb6678f-c078-4bdb-ab9f-4a0bf352d015)

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/5e23f448-9d7f-4180-84f6-8b5a13ece55d)

●	Return to the Unity project, select the Agent to show the inspector window. In the Inspector window, find the Behavior Parameters script.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/c1668f06-fd3a-40a5-90f8-f4e68fa3f3bd)

●	Under the Model field of the Behavior Parameters script, assign the .onnx file you imported earlier.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/71678eed-1c51-40df-9b98-b3fdb75f914d)

●	Change Behavior Type to Inference Only.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/cf1d7dde-77df-4c61-ae17-f03362945c28)

●	Now, when you press the play button in Unity, your agent should use the trained model to make decisions.

![image](https://github.com/cordova-jon1618/ml-agent-in-unity-project/assets/29684905/9e7bbc15-95d1-4a8b-9586-0d32da50e5f0)

ASSETS
--------
In our Machine Learning (ML) Agent project within Unity, various assets have been utilized to facilitate the training, deployment, and interaction of the agent. These assets play an integral role in the overall project, aiding in the creation of the environment, the agent's perception, and the visualization of the agent's performance.

Summary Explanation of our Assets:
-----------------------------------------------------------

●	ML-Agents Toolkit: A crucial asset for our project, the Unity ML-Agents Toolkit is an open-source project that enables games and simulations to serve as environments for training intelligent agents.

●	Unity Environment: This consists of all the game objects that the agent interacts with, including the room and the obstacles, as well as the goal, which in this case is a door.

●	Agent: The ML Agent itself is a central asset. This includes its physical attributes, its 'brain' (trained .onnx model), and its scripts that control its behavior.

●	Scripts: Various C# scripts are used in the project to define the agent's behavior, rewards system, and interaction with the environment.

●	.onnx File: Post-training, the learned policy is exported as an .onnx file. This file is an important asset for the deployment phase as it is used to control the agent's behavior in the environment.

●	Ray Perception Sensor: This asset provides the agent with the ability to sense its environment, critical for the agent's decision-making process.

●	Materials and Textures: These assets are used for visual representation, helping to distinguish different elements within the environment, such as the agent, the obstacles, and the goal.

●	Scene Camera and Agent Camera: A key asset for providing the viewpoint for the agent's perception and the user's view of the scene.

These assets, in combination, create a comprehensive framework for the agent's learning and interaction within the Unity environment, contributing significantly to the successful execution of our ML Agent project.






