import socket
import io

sock = socket.socket()

sock.connect(('localhost', 5050))
while True:
    pnumber = input("type number (0 - 100):")
    bpnumber = bytes(pnumber, "utf-8")
    sock.send(b"guess " + bpnumber)
    resp = sock.recv(8)
    print(resp.decode("utf-8"))
    
    