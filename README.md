# HC13.2.1-Field-Naming-Bug
Issue Demonstration of possible Field Naming Bug in HotChocolate 13.2.1

Running this results in the following schema:
	
	type TestEntity {
	  plz: String
	  vkNummer: String
	  pLZ: String
	  vKNummer: String
	}

Is this a bug or desired by design?

