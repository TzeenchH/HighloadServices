FROM ubuntu

RUN apt update

RUN apt install git -y

Expose 5050

RUN apt install python3 -y

RUN apt install python3-pip -y

ENV SERV_PORT=5050

RUN pip3 install flask

RUN pip3 install requests

COPY ./configs.ini /

COPY ./Main.py /

CMD python3 Main.py

