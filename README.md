
<h2>GET Endpoints</h2>

<h3>/GetAllUser</h3>
Get all Users
Output

```json
{
  "firstname": "Grogert",
  "lastname": "Johan",
  "phonenumber": 7482124,
  "userID": 1
},
{
  "firstname": "Jesper",
  "lastname": "Jacob",
  "phonenumber": 7424523,
  "userID": 2
}
```

<h3>/GetUserInterests/{id}</h3>
Get specific user interests
Output

```json
  {
    "interestName": "Golf",
    "interestDescription": "Man slår på bollen med en pinne ganska hårt och ser vart den går",
    "interestID": 1
  },
  {
    "interestName": "Fotboll",
    "interestDescription": "Sparka på bollen in ett mål",
    "interestID": 2
  },
  {
    "interestName": "Gokart",
    "interestDescription": "Racing med miniatyrbilar",
    "interestID": 3
  }
```

<h3>/GetUserLinks/{id}</h3>
Get specific user links
Output

```json
  {
    "linkID": 2,
    "linkUrl": "https://golf.se/",
    "fK_InterestLinks_Interests": 1
  },
  {
    "linkID": 3,
    "linkUrl": "https:%2F%2Fgolfbladet.se%2F",
    "fK_InterestLinks_Interests": 1
  }
```

<h3>/AddPersonToInterest/{userId}/{interestId}</h3>
Adds connection between user to interest
Input

```json
  {
    "userId": "2",
    "interestId": "3"
  }

```

<h3>/AddLinkToInterest/{interestId}/{linkUrl}</h3>
Adds a link to existing interest
Input

```json
  {
    "interestId": "1",
    "linkUrl": "https://golfbladet.se/"
  }

```

<h3>Er Schema</h3>
<img width="863" alt="Er_Schema" src="https://github.com/felixwidell/MiniProjekt_API/assets/91313243/a4cccf50-7693-48ea-b98f-5fd1f3a29b9c">
