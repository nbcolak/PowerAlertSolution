English

This project uses Observer Pattern, MediatR, SignalR, and .NET Core 8 to implement a real-time notification system for energy consumption. It allows for observing energy consumption data, sending notifications when a threshold is exceeded, and using MediatR for handling events in a decoupled and efficient manner. SignalR is used to send real-time updates to clients. The project also exposes a RESTful API for external interactions.

Technologies Used

	•	.NET Core 8: The backend framework for building the API.
	•	Observer Pattern: Initially used to notify observers of energy consumption updates.
	•	MediatR: Replaced the Observer pattern for event handling, enabling loose coupling between event emitters and handlers.
	•	SignalR: For real-time communication and sending notifications to clients.
	•	RESTful API: For external interaction with the system.

Features

	•	Monitors energy consumption and sends notifications when a threshold is exceeded.
	•	Real-time notification system using SignalR.
	•	Easily extendable with additional handlers for different types of events or notifications.
	•	Implements a clean separation of concerns using MediatR to decouple event publishing from handling.

Türkçe

Bu proje, Observer Tasarım Deseni, MediatR, SignalR ve .NET Core 8 kullanarak enerji tüketimi için gerçek zamanlı bir bildirim sistemi sağlar. Enerji tüketimi verileri izlenir, eşik aşıldığında bildirimler gönderilir ve MediatR olayları verimli bir şekilde yönetmek için kullanılır. SignalR, istemcilere gerçek zamanlı güncellemeler gönderir. Ayrıca proje RESTful API sunar.

Kullanılan Teknolojiler

	•	.NET Core 8: API ve hizmetleri yönetmek için kullanılan backend framework.
	•	Observer Tasarım Deseni: Başlangıçta enerji tüketimi güncellemelerini gözlemcilere bildirmek için kullanıldı.
	•	MediatR: Olay yönetimi için Observer deseninin yerini aldı ve olay yayımlayıcılar ile yöneticiler arasındaki bağı zayıflattı.
	•	SignalR: İstemcilere gerçek zamanlı bildirimler göndermek için kullanıldı.
	•	RESTful API: Sisteme harici olarak etkileşim sağlamak için kullanılır.

Özellikler

	•	Enerji tüketimini izler ve eşik aşıldığında bildirim gönderir.
	•	SignalR ile gerçek zamanlı bildirim sistemi.
	•	Farklı türdeki olaylar veya bildirimler için ek işleyicilerle kolayca genişletilebilir.
	•	Olay yayınlama ve işleme arasındaki bağı zayıflatmak için MediatR kullanır.

Deutsch

Dieses Projekt verwendet Observer Pattern, MediatR, SignalR und .NET Core 8, um ein Echtzeit-Benachrichtigungssystem für den Energieverbrauch zu implementieren. Es überwacht den Energieverbrauch, sendet Benachrichtigungen, wenn ein Schwellenwert überschritten wird, und verwendet MediatR für ein lose gekoppeltes Ereignishandling. SignalR wird verwendet, um Echtzeit-Updates an Clients zu senden. Das Projekt stellt auch eine RESTful API zur Verfügung.

Verwendete Technologien

	•	.NET Core 8: Das Backend-Framework zur Erstellung der API.
	•	Observer Pattern: Ursprünglich verwendet, um Beobachter über Energieverbrauchsaktualisierungen zu informieren.
	•	MediatR: Ersetzte das Observer-Pattern für die Ereignisverarbeitung und ermöglichte eine lose Kopplung zwischen Ereignisemittern und -handlern.
	•	SignalR: Für die Echtzeitkommunikation und das Senden von Benachrichtigungen an Clients.
	•	RESTful API: Für die externe Interaktion mit dem System.

Funktionen

	•	Überwacht den Energieverbrauch und sendet Benachrichtigungen, wenn ein Schwellenwert überschritten wird.
	•	Echtzeit-Benachrichtigungssystem mit SignalR.
	•	Leicht erweiterbar mit zusätzlichen Handlern für verschiedene Arten von Ereignissen oder Benachrichtigungen.
	•	Implementiert eine klare Trennung von Anliegen mit MediatR, um die Kopplung zwischen Ereignispublishing und -handling zu lösen.

Español

Este proyecto utiliza Observer Pattern, MediatR, SignalR y .NET Core 8 para implementar un sistema de notificación en tiempo real para el consumo de energía. Monitorea los datos de consumo de energía, envía notificaciones cuando se excede un umbral y utiliza MediatR para manejar eventos de manera desacoplada y eficiente. SignalR se utiliza para enviar actualizaciones en tiempo real a los clientes. El proyecto también expone una RESTful API para interacciones externas.

Tecnologías Usadas

	•	.NET Core 8: El framework backend para construir la API.
	•	Observer Pattern: Usado inicialmente para notificar a los observadores sobre actualizaciones del consumo de energía.
	•	MediatR: Reemplazó el patrón de observador para el manejo de eventos, permitiendo una baja acoplamiento entre emisores de eventos y manejadores.
	•	SignalR: Para la comunicación en tiempo real y el envío de notificaciones a los clientes.
	•	RESTful API: Para la interacción externa con el sistema.

Funcionalidades

	•	Monitorea el consumo de energía y envía notificaciones cuando se excede un umbral.
	•	Sistema de notificación en tiempo real con SignalR.
	•	Fácilmente extensible con manejadores adicionales para diferentes tipos de eventos o notificaciones.
	•	Implementa una separación clara de preocupaciones utilizando MediatR para desacoplar la publicación de eventos de su manejo.
