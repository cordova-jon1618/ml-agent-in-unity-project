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





