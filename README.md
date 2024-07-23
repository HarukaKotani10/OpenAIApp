# OpenAI Integration API

This .NET application integrates with OpenAI's API to provide intelligent conversational capabilities. The project consists of backend endpoints for various tasks such as completing sentences, identifying programming languages, and providing calorie information based on user input.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup](#setup)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project is designed to demonstrate how to integrate OpenAI's API with a .NET application. The application exposes a set of RESTful endpoints that can be used to perform various text-based tasks.

## Features

- Integration with OpenAI's API
- Endpoints for:
  - Completing sentences
  - Identifying programming languages
  - Providing calorie information
- Robust logging using Microsoft.Extensions.Logging
- Scalable and maintainable architecture using ASP.NET Core

## Technologies Used

- .NET Core
- ASP.NET Core
- OpenAI API
- Microsoft.Extensions.Logging

## Setup

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [OpenAI API Key](https://www.openai.com/api/)

### Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/HarukaKotani10/OpenAIApp.git
    ```

2. Navigate to the project directory:

    ```sh
    cd OpenAIApp
    ```

3. Restore the dependencies:

    ```sh
    dotnet restore
    ```

4. Set your OpenAI API key in the `appsettings.json` file:

    ```json
    {
      "OpenAI": {
        "ApiKey": "YOUR_API_KEY"
      },
      // Other settings
    }
    ```

5. Run the application:

    ```sh
    dotnet run
    ```

## Usage

You can test the endpoints using tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/).

### Endpoints

#### CompleteSentence

- **URL:** `/OpenAI/CompleteSentence`
- **Method:** `POST`
- **Parameters:**
  - `text` (string): The text to complete.
- **Example Request:**

    ```sh
    curl -X POST "http://localhost:5000/OpenAI/CompleteSentence" -d "text=Hello, world!"
    ```

#### AskQuestion

- **URL:** `/OpenAI/AskQuestion`
- **Method:** `POST`
- **Parameters:**
  - `text` (string): The text to check if it's a programming language.
- **Example Request:**

    ```sh
    curl -X POST "http://localhost:5000/OpenAI/AskQuestion" -d "text=Python"
    ```

- **Example Response:**

    ```json
    {
      "result": "yes"
    }
    ```

#### AskCalories

- **URL:** `/OpenAI/AskCalories`
- **Method:** `POST`
- **Parameters:**
  - `text` (string): The text containing food items.
- **Example Request:**

    ```sh
    curl -X POST "http://localhost:5000/OpenAI/AskCalories" -d "text=apple"
    ```
    
- **Example Response:**

    ```json
    {
      "result": "Apples have approximately 52 calories per 100 grams."
    }
    ```
    
