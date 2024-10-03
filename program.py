from datetime import datetime

start_time = datetime.now()

x = 0
for i in range(0, 2147483647):
    x = i

end_time = datetime.now()
print(end_time - start_time)