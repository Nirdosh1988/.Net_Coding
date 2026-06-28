# SOLID Principles in C#

A complete guide to the **SOLID Principles** with real-world examples in **C# and .NET**.

This repository demonstrates how to write clean, maintainable, scalable, and testable code by applying the five SOLID principles.

## 📚 What is SOLID?

SOLID is an acronym for five object-oriented design principles introduced by **Robert C. Martin (Uncle Bob)**.

Following these principles helps developers build software that is:

- ✅ Easy to maintain
- ✅ Easy to extend
- ✅ Easy to test
- ✅ Loosely coupled
- ✅ Highly reusable

---

# SOLID Principles

**| Principle | Name | Description |**
| S | Single Responsibility Principle | A class should have only one reason to change. |
| O | Open/Closed Principle | Software entities should be open for extension but closed for modification. |
| L | Liskov Substitution Principle | Derived classes must be replaceable with their base classes. |
| I | Interface Segregation Principle | Clients should not depend on interfaces they don't use. |
| D | Dependency Inversion Principle | High-level modules should depend on abstractions, not concrete implementations. |

# Project Structure
SOLID-Principles

SOLID-Principles
│
├── SRP
│   ├── BadExample.cs
│   ├── GoodExample.cs
│
├── OCP
│   ├── BadExample.cs
│   ├── GoodExample.cs
│
├── LSP
│   ├── BadExample.cs
│   ├── GoodExample.cs
│
├── ISP
│   ├── BadExample.cs
│   ├── GoodExample.cs
│
├── DIP
│   ├── BadExample.cs
│   ├── GoodExample.cs
│
└── README.md


# 1. Single Responsibility Principle (SRP)

> A class should have only one reason to change.

### ❌ Bad Example

One class handles:

- Business Logic
- Database
- Email

```
OrderService
 ├── Save Order
 ├── Send Email
 ├── Print Invoice
```

### ✅ Good Example

Separate responsibilities.

```
OrderService
     │
     ├── OrderRepository
     ├── EmailService
     └── InvoiceService
```

### Benefits

- Easy to maintain
- Easy to test
- Loose coupling

---

# 2. Open/Closed Principle (OCP)

> Open for extension, closed for modification.

### ❌ Bad Example

Adding a new payment method requires modifying existing code.

```
if(payment=="CreditCard")
...

if(payment=="UPI")
...

if(payment=="PayPal")
...
```

### ✅ Good Example

Create separate payment classes.

```
IPayment

CreditCardPayment

UPIPayment

PayPalPayment
```

New payment methods can be added without changing existing code.

---

# 3. Liskov Substitution Principle (LSP)

> Derived classes should be replaceable for their base classes.

### ❌ Bad Example

```
Bird
 ├── Fly()

Penguin : Bird
```

Penguin cannot fly.

### ✅ Good Example

```
Bird

FlyingBird : Bird

Penguin : Bird
```

Only flying birds implement flying behavior.

---

# 4. Interface Segregation Principle (ISP)

> Do not force clients to implement methods they don't need.

### ❌ Bad Example

```
IWorker

Work()

Eat()

Sleep()
```

A Robot doesn't eat.

### ✅ Good Example

```
IWork

IEat

ISleep
```

Classes implement only the interfaces they need.

---

# 5. Dependency Inversion Principle (DIP)

> Depend on abstractions, not concrete implementations.

### ❌ Bad Example

```
SmsService

↓

NotificationEngine
```
The orchestrator (NotificationEngine) directly creates a concrete low-level instance (SmsService). Swapping to a WhatsApp api requires rewriting structural system internals.

### ✅ Good Example

```
IMessageSender 

↓

SmsService  | WhatsAppService 

# Why SOLID?

Applying SOLID principles helps you:

- Reduce code duplication
- Improve readability
- Increase maintainability
- Simplify unit testing
- Support dependency injection
- Build scalable applications

---

# Technologies Used

- C#
- .NET 8 / .NET 9
- Visual Studio 2022
- Dependency Injection
- Object-Oriented Programming

---

# Best Practices

- Keep classes focused on a single responsibility.
- Prefer composition over inheritance.
- Program against interfaces.
- Avoid tightly coupled code.
- Write unit-testable code.
- Follow Clean Architecture principles.

---

# Learning Outcomes

After completing this project, you will understand:

- ✔ SOLID Principles
- ✔ Object-Oriented Design
- ✔ Dependency Injection
- ✔ Design Patterns
- ✔ Clean Code
- ✔ Maintainable Architecture


