# App

All communication between managers happen here.

---

## Blocks

Main Block Items. Not destroyed on level load. They do not interact with anything on screen or any user. Are all static.

1. Canvas Block
2. Player Block

---

### Controllers

Are spawned everytime a level loads. Are the containers that hold elements. Containers can talk to other containers. These listen for events to be triggered.

1. Player Controller
2. Canvas Controller
3. Item Controller

--- 

#### Elements

Individual Scripts that control single functions. These trigger Events.

1. Player Movement Element
2. Player Input Element
3. Camera Follow Element

---