package creational.factory.simplefactory;

class AutoFactory {
    Auto createInstance(String carName) {
        switch (carName) {
            case "bmw":
                return new BMW335Xi();
            case "mini":
                return new MiniCooper();
            case "audi":
                return new AudiTTS();
            default:
                return new NullCar();
        }
    }
}
