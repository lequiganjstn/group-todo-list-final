# Group Todo List Final

A .NET MAUI todo list application built as a group project.

## Overview

`group-todo-list-final` is a .NET MAUI application that allows users to manage tasks through a to-do list interface. The project is structured as a Visual Studio solution (`solo-todo-list.slnx`) and organized under the `solo-todo-list` directory.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 10 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Installation

1. Clone the repository:
```bash
   git clone https://github.com/lequiganjstn/group-todo-list-final.git
   cd group-todo-list-final
```

2. Open the solution file in your IDE:
```
   solo-todo-list.slnx
```

3. Build and run the project from your IDE, or use the CLI:
```bash
   dotnet build
   dotnet run --project solo-todo-list
```

## Features

- Add new tasks to your to-do list
- View all current tasks
- Mark tasks as complete
- Remove tasks from the list

## Project Structure
```
group-todo-list-final/
├── .idea/                   # IDE configuration files
├── solo-todo-list/          # Main project source code
├── solo-todo-list.slnx      # Visual Studio solution file
├── .gitattributes
└── .gitignore
```

## Contributing

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add your feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request
