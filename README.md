## WCF Services Using ASP.NET and CSharp

### 1. Web Service and Browser
Convert entered Degree Celsius to Fahrenheit and Vice Versa. We implemented this in the following 
- As a Web Service 
- As a Windows Form Application 
- As a Web Site Application
- Web Browser with Encryption/Decryption Features, Gets stock Quotes

### 2. Multithreading Chicker Farm Service
- Implemented Encoders to convert objects to strings and Decoders to convert string to objects
- Implemented MultiCell Buffer to store enocded strings
- Implemented Multithreaded to handle multiple order and supply threads
- Chick farms recieve price cuts information every time there is a new price
- A main thread handles all the thread

### 3. Service Development and Deployment and Remote Binding
- Implemented a Service Oriented Computing System
- There were 5 services that were implemented
  - Location Service - Enter the name of the place. Zip code, Latitude and Longitude will be returned. This is implemented using [Google Maps Api](https://cloud.google.com/maps-platform/)
  - Image Service - Enter the name of place, Images of the place will be returned. This is implemented using [PixaBay APi](https://pixabay.com/api/docs/)
  - Distance Service - Enter the Source and Desitnation, The distance in Kms will be returned. This implemented using Google Maps APi
  - Crime Data Service - Enter a Place name and the Voilent and property crime rates are returned
  - Weather Data Service - Enter a Place name and wind intensity of the place will be returned.
- The above mentioned services might not work because the api keys has limited expiration

### 4. XML files handling

- Implemented Web Service where it takes the url of XML file and transforms it into HTML using a XSD.

### 5. Complete User Service Deployment

- All the services mentioned in `3` are implemented as a user service
- User gets to signup for the services and login to use the services.
- All the passwords are encrypted while storing and decrypted while user authentication
- This Service is implemented at several authorization level.
  - Manager can see all the users and staff info including everyone's passwords
  - Staff can see only users details without passwords
  
### Testing

Download all the services. Open their respective `sln` files and run all the peripheral serivces before running the main service.

### License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/Bharathgc/WCF-Services-Using-ASP.NET-and-CSharp-/blob/master/LICENSE) file for details
