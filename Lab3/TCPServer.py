import socket
import re
import random

more = b"more"
less = b"less"
correct = b"correct"
numb = random.randint(0, 100)

print(numb)

sock = socket.socket()
sock.bind( ("127.0.0.1", 5050) )
sock.listen(10)
try:
    while True:
        conn, addr = sock.accept()
        conn.settimeout(60)
        data = conn.recv(8)
        udata = data.decode("utf-8")
        tmp = re.search(r'\d+' , udata)
        pnb = tmp.group()
        print(type(pnb))
        pendnum = int(pnb)
        if pendnum > numb:
            conn.send(more)
        elif pendnum < numb:
            conn.send(less)
        else:
            conn.send(correct)
            conn.close()

finally:
    print("closed")
    sock.close()