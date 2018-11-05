import sqlite3
import re
from datetime import date


class Phone:
    def __init__(self, sphone):
        pattern = "9[0-9]{2}[0-9]{7}"
        match_result = re.match(pattern, sphone)
        match_result.groups()


class UserInfo:
    def __init__(self, person_id, card_id):
        self.person_id = person_id
        self.card_id = card_id


class User:
    def __init__(self, name, surname, father_name, phone=None, birthday: date=None):
        self.name = name
        self.surname = surname
        self.father_name = father_name
        self.phone = phone
        self.birthday = birthday


class Card:
    def __init__(self, card_number):
        self.card_number = card_number


db_name = 'bonus_database.db'
tableUsers = "USERS"
tablePhones = "USER_PHONES"
tableCards = "CARDS"
tableUserInfo = "USER_CARD_RELATION"


def create_database():
    # database connection
    db = sqlite3.connect(db_name)

    # TODO
    #db.execute('drop database ' + db_name)

    db = sqlite3.connect(db_name)

    # sql queries for creating tables
    create_table_users = "create table IF NOT EXISTS " + tableUsers + " ( " \
                         "PersonID int not null PRIMARY KEY, " \
                         "NAME varchar(255) not null, " \
                         "SURNAME varchar(255) not null, " \
                         "FARTHER_NAME varchar(255) not null, " \
                         "AGE int not null " \
                         ")"
    create_table_phones = "create table IF NOT EXISTS " + tablePhones + " (" \
                          "PersonID int not null," \
                          "Phone varchar(10) not null, " \
                          "FOREIGN KEY(PersonID) REFERENCES  " + tableUsers + "(PersonID)" \
                          ")"
    create_table_cards = "create table IF NOT EXISTS " + tableCards + " (" \
                         "CardNo int not null PRIMARY KEY " \
                         ")"
    create_table_user_info = "create table IF NOT EXISTS " + tableUserInfo + " (" \
                             "PersonID int not null, " \
                             "CardNo int not null" \
                             ")"

    db.execute(create_table_users)
    db.execute(create_table_phones)
    db.execute(create_table_cards)
    db.execute(create_table_user_info)

    return db


def register_user(user: User):
    insert_to_users = "insert into " + tableUsers + " values (" \
                      ""

