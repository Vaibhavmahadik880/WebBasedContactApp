# Contact Management Application

This is a full-stack Contact Management Application built with React for the frontend and ASP.NET Core Web API for the backend. The app allows users to perform CRUD (Create, Read, Update, Delete) operations on a contact list, with functionalities like pagination, sorting, searching, and deleting contacts.

## Features

- **React Frontend:**
  - List contacts with pagination and sorting.
  - Search contacts by name or phone number.
  - Add, edit, and delete contacts.
  - Toast notifications for actions (success messages for add, edit, and delete).
  - Responsive UI for easy management of contacts.

- **ASP.NET Web API Backend:**
  - RESTful API to manage contacts.
  - Endpoints for creating, retrieving, updating, and deleting contacts.
  - Pagination and sorting support for contacts.
  - Integration with SQLite as the database for persistent data storage.
  
## Table of Contents

1. [Technologies Used](#technologies-used)
2. [Project Structure](#project-structure)
3. [Getting Started](#getting-started)
4. [Frontend Setup](#frontend-setup)
5. [Backend Setup](#backend-setup)
6. [API Documentation](#api-documentation)
7. [Screenshots](#screenshots)
8. [Contributing](#contributing)

## Technologies Used

- **Frontend:**
  - React
  - Redux Toolkit for state management
  - Axios for API requests
  - React Toastify for notifications
  - Material UI for pagination
  - FontAwesome Icons

- **Backend:**
  - ASP.NET Core Web API
  - Entity Framework Core with SQLite
  - Swagger for API documentation

## Project Structure

```bash
.
├── backend              # ASP.NET Core Web API
│   ├── Controllers      # API Controllers for contacts
│   ├── Models           # Contact models
│   ├── Data             # DbContext for database interaction
│   └── Migrations       # EF Core migrations for database schema
└── frontend             # React frontend
    ├── components       # Reusable components (ContactItem, ContactForm, etc.)
    ├── redux            # Redux slices for state management
    ├── api              # Axios requests to the backend
    └── styles           # CSS files for styling the components


## Getting Started

Follow the steps below to set up and run the project locally.

### Prerequisites

- **Node.js**: Install from [Node.js](https://nodejs.org/)
- **npm or yarn**: Use npm (comes with Node.js) or install yarn globally
- **.NET Core SDK**: Download and install from [Microsoft](https://dotnet.microsoft.com/download)

### Clone the Repository

```bash
git clone https://github.com/your-username/contact-app.git
cd contact-app

### Installing Dependencies

1. **Frontend Setup**:
   Navigate to the `frontend` folder and install the dependencies:
   ```bash
   cd frontend
   npm install

2. **Backend Setup**:
cd backend
dotnet restore

3. **Frontend run**:
npm start
The frontend will be accessible at http://localhost:3000.

4. **backend run**:
he API will be accessible at http://localhost:5000.


### Database Setup

The backend uses SQLite as the database. When the backend is first run, the database will be automatically created if it doesn't exist.

If needed, run EF Core migrations to set up the database schema:
```bash
cd backend
dotnet ef database update


## API Endpoints

The following endpoints are available in the ASP.NET Web API:

- `GET /api/contacts`: Retrieve a list of all contacts.
- `POST /api/contacts`: Create a new contact.
- `PUT /api/contacts/{id}`: Update an existing contact by ID.
- `DELETE /api/contacts/{id}`: Delete a contact by ID.

## Running Tests

1. **Frontend Tests**:
   If there are tests for the React components, you can run them with:
   ```bash
   cd frontend
   npm test
