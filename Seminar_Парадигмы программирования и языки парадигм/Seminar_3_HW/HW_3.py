# Шаблон Singleton:
# Реализуйте паттерн Singleton на языке Python для класса Logger, который будет использоваться 
# для логирования информации в приложении. Гарантируйте, что только один экземпляр класса Logger будет создан.
# ----------------------------------------------------------


class Logger:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super(Logger, cls).__new__(cls)
        return cls._instance

singleton1 = Logger()
singleton2 = Logger()

print(singleton1 is singleton2)