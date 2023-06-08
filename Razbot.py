import smtplib
from time import sleep
from turtle import st
from email.mime.text import MIMEText
print("Welcome To RazBot")
sender_email = input(str("google username:"))
password2 = input(str("Password:"))
reciever_email = input(str("Send to:"))
Subjectz = input(str("Subject line:"))
From = input(str("From (the name you want to show up next to the email address): Currently not working because im forcing it to be one name go into the code and edit the line that says msg['from']")) #Edit line 18 and replace with email or From to get this line to work 
#smtplib.set_debuglevel(1) #Remove this if you need more information if code isnt working
TEXT = input(str("Email body:"))
SUBJECT = "test"   
#def mail_me(cont, receiver):
msg = MIMEText(TEXT, 'html')
recipients = ",".join(reciever_email)
msg['Subject'] = Subjectz
msg['From'] = '"Test"' #Controls the recipent
#msg['To'] = recipients
server = smtplib.SMTP_SSL('smtp.gmail.com')


server.login(sender_email, password2)
print("Login complete")
server.sendmail('RazALERT', reciever_email, msg.as_string())
print("Email sent")
sleep(2000)
print("Enter another email to send another Alert:")
reciever_email = input(str("Send to:"))
server.sendmail('RazALERT', reciever_email, msg.as_string())
print("Email sent")
print("Enter another email to send another Alert:")
reciever_email = input(str("Send to:"))
server.sendmail('RazALERT', reciever_email, msg.as_string())
print("Email sent")
