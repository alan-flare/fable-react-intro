# fable-react-intro

## Overview

A simple Fable-React application.

## Requirements

- .NET 5+
- Node.js 10.0+

## Installation

To install the project's dependencies, run the following commands:

```bash
dotnet restore
npm install
```

## Development

To start the development server, run the following commands:

```bash
npm start
```

## Debugging

Ensure your development server is running.

Using VS Code, there is a launch task `Start Chrome Debugger` that you can run to start the debugger.
With the magic of source maps, you can set breakpoints in your `.fs` files within VS Code.

Alternatively, you may use your browser and set breakpoints in the generated `.fs.js` files.
The exact instructions will depend on your browser, but essentially it simply involves:

1. Opening the Developer tools panel (usually by hitting F12).
1. Finding the F# file you want to add breakpoints to in the source of the website (look inside the webpack folder).
1. Add breakpoints to it in your browser inspector.

## Build

To build the project, run the following commands:

```bash
npm run build
```
