# Vehicle Alert System Base On Lidar Sensor

### System Description
The system will detect and alert about obstacles in the vehicle path. The system should classify the alert in to three level (none, low or high). 
The system will provide obstacle location relative to the vehicle.The alerts will send to remote computer at protocole TCP/IP, 
in addition the alerts will sent via USB port at protocol RS232.

### Implementaion
The system base on Lidar sensor model [LMS141-15100](https://www.sick.com/ag/en/detection-and-ranging-solutions/2d-lidar-sensors/lms1xx/lms141-15100-security-prime/p/p389564).
the sensor connected to computer via Ethernet cable, the data transfer in TCP/IP protocol.The application on the operator computer receive all data from the sensor.
The application transfer all the data via usb to the external controller.Also, the application perform processing on all the data that received from the sensor.
The data processing include alert classifying and display alerts on the screen in correlation the user settings.

in addition, the system can be connected with remote computer as client server at TCP/IP protocol.
The remote computer receives all the data after processing from the local computer.

### System Properties
* The system GUI include the following
  * Sensor data settings - scan angle, resolution.
  * Physical settings of the system - sensor height, sensor installation angle, vehicle width.
  * Alert settings.
  * Communication settings - Ethernet, RS232.
  * Alerts view.
 * The system should be displayed alerts with an accuracy of 1 cm.
 * The system scan frequency is 25hz.
 * The alert should be classified in three level (none, low, high).
 * option to save the last alert result.
 * The system will be modularity
