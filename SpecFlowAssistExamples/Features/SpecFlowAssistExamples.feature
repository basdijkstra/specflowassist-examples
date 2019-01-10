Feature: SpecFlowAssist
	In order to work with POCOs more effectively
	As a SpecFlow student
	I want to learn how to wield the powers of SpecFlow.Assist

Scenario: Work with a single table entry
	Given the following album exists
		| Artist    | Title      | ReleaseYear | LengthInMinutes | RecordLabel        |
		| Faithless | Sunday 8PM | 1998        | 58              | Cheeky Records/BMG |
	When the album is rereleased
	Then the new album details should be
		| Artist    | Title      | ReleaseYear | LengthInMinutes | RecordLabel        |
		| Faithless | Sunday 8PM | 2019        | 58              | Cheeky Records/BMG |

Scenario: Work with multiple table rows
	Given the following album collection exists
		| Artist         | Title       | ReleaseYear | LengthInMinutes | Recordlabel        |
		| Faithless      | Sunday 8PM  | 1998        | 58              | Cheeky Records/BMG |
		| London Grammar | If You Wait | 2013        | 43              | Metal & Dust       |
	When all albums in the collection are rereleased
	Then the updated album collection should equal
		| Artist         | Title       | ReleaseYear | LengthInMinutes | Recordlabel        |
		| London Grammar | If You Wait | 2019        | 43              | Metal & Dust       |
		| Faithless      | Sunday 8PM  | 2019        | 58              | Cheeky Records/BMG |

Scenario: Allow for fuzzy matching and aliasing
	Given the following album exists
		| Artist         | Title       | Release year | AlbumLength | Recordlabel  |
		| London Grammar | If You Wait | 2013         | 43          | Metal & Dust |
	When the album is rereleased
	Then the new album details should be
		| Artist         | Title       | Release year | AlbumLength | Recordlabel |
		| London Grammar | If You Wait | 2019         | 43          | Metal & Dust |