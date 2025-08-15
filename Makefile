SRC_DIR=src
TEST_DIR=tests

all: build

build:
	dotnet build --project $(SRC_DIR)

test:
	dotnet test $(TEST_DIR)

watch:
	dotnet watch --project $(SRC_DIR) run

watch-test:
	dotnet watch --project $(TEST_DIR) test

debug:
	dotnet run --project $(SRC_DIR)

clean:
	dotnet clean $(SRC_DIR)
	dotnet clean
