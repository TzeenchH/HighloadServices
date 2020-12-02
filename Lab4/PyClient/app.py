from flask import Flask, request
from flask_graphql import GraphQLView

import server_pb2
from serverCall import sendToServer
from schema import schema

app = Flask(__name__)

app.add_url_rule('/graphql', view_func=GraphQLView.as_view(
    'graphql',
    schema=schema,
    graphiql=True,
))


@app.route("/")
def homeScript():
    phoneNumber: str = request.args.get("phone", None)
    codeToVerify = request.args.get("code", None)
    if not phoneNumber:
        return "Error: Phone Number is not set!", 400
    if not codeToVerify:
        return "Code is required", 400
    verify_code = int(codeToVerify)

    resp = sendToServer(phoneNumber)
    if resp == server_pb2.NOT_FOUND:
        return "Phone number Not Found", 404
    if verify_code % 2 == 0:
        return "Verified status: failure", 403
    return "Verified status: success"


if __name__ == "__main__":
    app.run(host='localhost', port=5001)
