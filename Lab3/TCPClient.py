import socket

sock = socket.socket()

sock.connect(('localhost', 5050))
while True:
    pnumber = input("type number (0 - 100):")
    sock.send(bytes(pnumber + "\n", "utf-8"))
    resp = sock.recv(8)
    print(resp.decode("utf-8"))
