import socket
import random

more = b"more"
less = b"less"
correct = b"correct"
numb = random.randint(0, 100)

print(numb)

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
    sock.bind(("localhost", 5050))
    sock.listen(10)
    conn, addr = sock.accept()
    with conn:
        while True:
            conn.settimeout(60)
            data = conn.recv(8)
            udata = int(data.decode("utf-8"))
            print(udata)
            if udata < numb:
                print('mmm')
                conn.sendall(more)
            elif udata > numb:
                conn.send(less)
            else:
                conn.send(correct)
                conn.close()
