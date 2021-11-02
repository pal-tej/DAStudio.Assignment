# DAStudio.Assignment

The code is based on MVVM pattern and use CollectionView to display the list of transactions. The app can be compiled for Android, IOS & UWP (Windows 10)

The UI/UX (colors + graphics element )is not exactly matching the layout of the assignment but the functionality and deisgn patterns used are in accordance with the assignment. Due to the limited time I was not able to complete the uplifting of the UI and asthetics.

There are two view TranacstionsPage & TransactionDetailPage

The API backend is accessed via TransactionDataStore service class, there are two GET requests to the api endpoints.

Rest evenrthing is organized as VIewModel and Model, two model classes namely Transaction & TransactionDetail are hydrated by the incoming json response from the backend. NewtonSoft package is used for json serialization.

There are two screenshots to have see what it look like so far on my phone.
1635836138684.jpg
1635836138688.jpg



