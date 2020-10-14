import socket
import re
import random

more = b"more"
less = b"less"
correct = b"correct"
numb = random.randint(0, 100)

print(numb)

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
    sock.bind(("127.0.0.1", 5050))
    sock.listen(10)
    conn, addr = sock.accept()
    with conn:
        while True:
            conn.settimeout(60)
            data = conn.recv(8)
            udata = data.decode("utf-8")
            tmp = re.search(r'\d+' , udata)
            pnb = tmp.group()
            pendnum = int(pnb)
            if pendnum < numb:
                conn.sendall(more)
            elif pendnum > numb:
                conn.send(less)
            else:
                conn.send(correct)
                conn.close()
