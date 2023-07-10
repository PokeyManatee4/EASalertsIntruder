import sys
import select

ip = "192.168.0.18"
port = 3388
	
dontprint = 0

# Create a UDP socket
s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
# Bind the socket to the port
server_address = (ip, port)
s.bind(server_address)
print("Do Ctrl+c to exit the program !!")

while True:
    print("####### Server is listening #######")
    data, address = s.recvfrom(4096)
    if data.decode("utf-8") == "COMPIN":
        print("\n\n 2. Client sent test ping")
        ping = "COMRCV"
        s.sendto(ping.encode("utf-8"), address)
        print("\n\n 1. Server sent ping success")
        dontprint = 1
    if dontprint == 1:
        dontprint=0
    else:
        print("\n\n 2. Server received: ", data.decode('utf-8'), "\n\n")
        print("Error code: ",end="")
        i, o, e = select.select( [sys.stdin], [], [], 10 )
        if (i):
           send_data =  "XYX"+sys.stdin.readline().strip()
        else:
           send_data = "XYX503"
        s.sendto(send_data.encode('utf-8'), address)
        print("\n\n 1. Server sent : ", send_data,"\n\n")
