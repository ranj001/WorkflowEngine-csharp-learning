# Workflow Engine (Learning Exercise)

This repository contains a C# .NET 8 console application that implements a simple workflow engine. The primary goal of this project is to demonstrate how interfaces can be used to design robust and loosely coupled applications.

## Key Concepts

- **Interfaces:** Activities in the workflow implement a common interface, allowing the engine to execute any activity that adheres to the contract.
- **Loose Coupling:** The workflow engine is decoupled from specific activity implementations, making it easy to extend or modify without changing the engine's core logic.
- **Extensibility:** New activities can be added by implementing the interface, promoting scalability and maintainability.

## Usage

The application runs several workflow activities, such as uploading videos, encoding, sending notifications, and changing video status. Each activity is executed through the workflow engine, showcasing interface-driven design.

## Purpose

This project is intended as a learning exercise for understanding:
- The benefits of using interfaces in C#
- How to achieve loose coupling in application architecture
- Building extensible and maintainable software

## Requirements

- .NET 8 SDK
- C# 12.0
