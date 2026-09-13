class WeekDayError(Exception):
    pass

class Weeker:
    def __init__(self, day):
        self.weekday = day
        self.weekdaynum = Weeker.getday(self)

    def getday(self):
        match self.weekday:
            case "Mon":
                self.weekdaynum = 1
                return self.weekdaynum

            case "Tue":
                self.weekdaynum = 2
                return self.weekdaynum

            case "Wed":
                self.weekdaynum = 3
                return self.weekdaynum

            case "Thu":
                self.weekdaynum = 4
                return self.weekdaynum

            case "Fri":
                self.weekdaynum = 5
                return self.weekdaynum

            case "Sat":
                self.weekdaynum = 6
                return self.weekdaynum

            case "Sun":
                self.weekdaynum = 7
                return self.weekdaynum
            case _:
                raise WeekDayError

    def add_days(self, n):
        Weeker.getday(self)
        n += self.weekdaynum
        if n /7 > 1:
            while n > 7:
                n-=7
            self.weekdaynum = n
            Weeker.returnday(self)
        else:
            self.weekdaynum = n
            Weeker.returnday(self)

    def subtract_days(self, n):
        n -= Weeker.getday(self)
        if n /7 > 1:
            while n > 7:
                n-=7
            self.weekdaynum = n
            Weeker.returnday(self)
        else:
            self.weekdaynum = n
            Weeker.returnday(self)

    def returnday(self):
        match self.weekdaynum:
            case 1:
                self.weekday = "Mon"
                return self.weekday
            case 2:
                self.weekday = "Tue"
                return self.weekday
            case 3:
                self.weekday = "Wed"
                return self.weekday
            case 4:
                self.weekday = "Thu"
                return self.weekday
            case 5:
                self.weekday = "Fri"
                return self.weekday
            case 6:
                self.weekday = "Sat"
                return self.weekday
            case 7:
                self.weekday = "Sun"
                return self.weekday
            case _:
                raise WeekDayError

try:
    weekday = Weeker('Mon')
    print(Weeker.returnday(weekday))
    weekday.add_days(15)
    print(Weeker.returnday(weekday))
    weekday.subtract_days(23)
    print(Weeker.returnday(weekday))
    weekday = Weeker('Monday')
except WeekDayError:
    print("Sorry, I can't serve your request.")
