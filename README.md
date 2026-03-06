The app follows a "Space Mission" theme where the user must select a ship, clear security, and find a satellite in Sector 7. The project focuses on handling a large navigation stack and using different layouts for every screen.

App Navigation & Story
I used a NavigationPage in the App.xaml.cs file to manage the 8 pages. This allows the app to "push" new screens on top of each other as the mission progresses.

MainPage: The start screen with a vertical layout.

Gallery: Ship selection using a Grid to show ship images.

Details: Mission briefing using FlexLayout.

Security: A logic-gated screen requiring 7 taps to proceed.

Logs: A scrolling diagnostic screen using ScrollView.

NavComputer: A data dashboard using Frames to organize ship info.

Radar: A scanning screen using a Grid to layer circular UI elements.

MissionEnd: The final screen that uses PopToRootAsync to reset the mission.

Key Features & Layouts
Layered Grid Design: On the Radar page, I used a Grid to stack multiple Frames on top of each other. By setting a high CornerRadius, I created a circular radar effect without needing complex drawing tools.

Data Organization: On the NavComputer page, I used Frames to group data like velocity and fuel. This makes the UI look like a modern dashboard.

Security Logic: I wrote a C# click-counter for the Security page. It uses an int count variable and an if statement to keep the "Continue" button hidden (IsVisible="False") until the user taps the authorization button 7 times.

Technical Skills Applied
C# Logic: Using variables and conditional statements to control the UI.

Navigation: Managing 8 pages in a single stack.

Layouts: Practical use of VerticalStackLayout, Grid, FlexLayout, ScrollView, and Frame.
