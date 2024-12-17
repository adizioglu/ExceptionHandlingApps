def bad_call():
    ages = [1, 3, 5]

    for i in range(len(ages) + 1):
        try:
            print(ages[i])
        except IndexError as ex:
            print("We had an error")
            print(str(ex))
            raise Exception("There was an error handling our array") from ex

def main():
    try:
        bad_call()
    except Exception as ex:
        print("There was an exception thrown in our app")
        print(str(ex))

    input()

if __name__ == "__main__":
    main()

