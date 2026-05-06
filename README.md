# LockIn

LockIn is a secure password manager desktop application built with C# and Windows Forms, targeting .NET 10. It allows users to store, encrypt, and manage account credentials for various services with a modern, user-friendly interface.

## Features
- Secure AES-256 encryption for all stored passwords
- User authentication with master password
- Add, edit, and delete account entries
- Search and filter accounts
- Customizable dark and light themes
- Owner-drawn DataGridView for enhanced UI
- Encrypted data storage in JSON format

## Getting Started

### Prerequisites
- .NET 10 SDK or later
- Visual Studio 2022/2026 or compatible IDE

### Build and Run
1. Clone the repository:
   ```
   git clone https://github.com/lukebaldovino/LockIn.git
   ```
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application (F5 or Ctrl+F5).

## Usage
- On first launch, set your master password.
- Add new accounts with service name, username/email, and password.
- Click the "View" button to reveal the decrypted password (after login).
- Use the search bar to quickly find accounts.
- Switch between dark and light mode using the toggle button.

## Security
- All passwords are encrypted using AES-256 before being saved.
- The encryption key is derived from the master password and never stored in plain text.
- The app does not transmit or sync data to any server; all data is local.

## Project Structure
- `Form1.cs` - Main dashboard UI and logic
- `backend/` - Encryption, storage, and utility logic
- `accounts.json` - Encrypted account data (created at runtime)

