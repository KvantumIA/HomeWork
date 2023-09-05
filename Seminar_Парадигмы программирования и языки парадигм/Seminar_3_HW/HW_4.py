# Шаблон Наблюдатель:
# Реализуйте паттерн Наблюдатель на языке Python для системы уведомлений. Создайте класс 
# NotificationSystem (наблюдаемый объект), который будет иметь методы для добавления наблюдателей 
# и уведомления о событиях. Создайте несколько наблюдателей, реагирующих на уведомления.


class Observer:
    def update(self, message):
        pass

class ConcreteObserver(Observer):
    def update(self, message):
        print("Received message:", message)

class NotificationSystem:
    _observers = []

    def attach(self, observer):
        self._observers.append(observer)

    def notify(self, message):
        for observer in self._observers:
            observer.update(message)

subject = NotificationSystem()

observer1 = ConcreteObserver()
observer2 = ConcreteObserver()

subject.attach(observer1)
subject.attach(observer2)

subject.notify("Hello, observers!")