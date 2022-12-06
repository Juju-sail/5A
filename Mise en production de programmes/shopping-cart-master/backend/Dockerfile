FROM python:3

WORKDIR /usr/src/app

COPY . .

RUN pip install --upgrade pip
RUN pip install -r requirements.txt

EXPOSE 8000

ENTRYPOINT [ "./entrypoint.sh" ]
CMD ["python", "manage.py", "runserver", "0.0.0.0:8000"]