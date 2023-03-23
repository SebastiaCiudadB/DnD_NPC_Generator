#include <iostream>;
#include <string>;
#include <random>;

using namespace std;

class character {

public:
	string race;

	string gender, sexOrientation;
	int age;

	string size, constitution;
	float weight, heihht;

	string skinColor, eyeColor;
	string hairColor, hairStile;

	character() {
		race = "";
		gender = "";
		sexOrientation = "";
		age = 0;
		size = "";
		constitution = "";
		weight = 0.0;
		heihht = 0.0;
		skinColor = "";
		eyeColor = "";
		hairColor = "";
		hairStile = "";
	}

	void printInformation() {
		cout << "========================================" << endl;

		cout << "Race: " << race << endl;
		cout << "\nGender: " << gender;
		cout << "\t\tSexual Orientation: " << sexOrientation << endl;

		cout << "========================================" << endl;
	}

	void setGender() {
		random_device rd;
		mt19937 gen(rd());

		uniform_int_distribution<> distrib(1, 2);

		gender = distrib(gen) == 1 ? "Male" : "Female";
	}

	void setSexualOrientation() {
		int heterosexualProbability = 25;
		int homosexualProbability = 25;
		int bisexualProbability = 25;
		int asexualProbability = 25;

		random_device rd;
		mt19937 gen(rd());

		int maxNum = 10000;

		uniform_int_distribution<> distrib(1, maxNum);

		int newA, newB, newC, newD;
		newA = maxNum / 100 * heterosexualProbability;
		newB = newA + maxNum / 100 * homosexualProbability;
		newC = newB + maxNum / 100 * bisexualProbability;
		newD = newC + maxNum / 100 * asexualProbability;

		int aux = distrib(gen);

		if (aux < newA) {
			sexOrientation = "Heterosexual";
		}
		else if (aux >= newA && aux < newB) {
			sexOrientation = "Homosexual";
		}
		else if (aux >= newB && aux < newC) {
			sexOrientation = "Bisexual";
		}
		else if (aux >= newC && aux < newD) {
			sexOrientation = "Asexual";
		}

	}

	void setAge() {
		int minAge = 10;
		int maxAge = 20;

		random_device rd;
		mt19937 gen(rd());

		uniform_int_distribution<> distrib(minAge, maxAge);

		age = distrib(gen);
	}
};

class human : public character {
public:
	void setHuman() {

		race = "Human";

		setGender();
		setSexualOrientation();
		setAge();
	}
};