import sqlite3
import tkinter


def create_database():
    # database connection
    db = sqlite3.connect('bonus_database.db')

    # sql queries for creating tables
    create_table_users = "create table IF NOT EXISTS USERS ( " \
                         "PersonID int not null PRIMARY KEY, " \
                         "NAME varchar(255) not null, " \
                         "SURNAME varchar(255) not null, " \
                         "FARTHER_NAME varchar(255) not null, " \
                         "AGE int not null " \
                         ")"

    create_table_phones = "create table IF NOT EXISTS SER_PHONES (" \
                          "PhoneID int not null PRIMARY KEY, " \
                          "Phone varchar(10) not null " \
                          ")"

    create_table_cards = "create table IF NOT EXISTS CARDS (" \
                         "CardNo int not null PRIMARY KEY " \
                         ")"

    create_table_user_phones_relation = "create table IF NOT EXISTS USER_PHONE_RELATION (" \
                                        "PersonID int not null, " \
                                        "PhoneID int not null " \
                                        ")"

    create_table_user_cards_relation = "create table IF NOT EXISTS USER_CARD_RELATION (" \
                                       "PersonID int not null, " \
                                       "CardNo int not null " \
                                       ")"

    db.execute(create_table_users)
    db.execute(create_table_phones)
    db.execute(create_table_cards)
    db.execute(create_table_user_phones_relation)
    db.execute(create_table_user_cards_relation)


def create_gui():
    top = tkinter.Tk()

    # Code to add widgets will go here...
    top.mainloop()


def main():
    create_database()
    create_gui()


main()
