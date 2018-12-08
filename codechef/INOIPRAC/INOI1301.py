#CALVIN'S GAME
n,k=map(int,input().split())
a=list(map(int,input().split()))
k-=1
b=a[k:n]
c=[0]*len(b)
if len(b)>1:
	c[1]=b[1]
	for i in range(2,len(b)):
		c[i]=max(c[i-1]+b[i],c[i-2]+b[i])
d=a[0:n]
e=[0]*len(d)
if len(d)>1:
	e[1]=d[0]
	for i in range(2,len(d)):
		e[i]=max(e[i-1]+d[i-1],e[i-2]+d[i-2])
ans=-float('inf')
for i in range(k,n):
	temp=c[i-k]+e[i]
	if temp>ans:
		ans=temp
print (ans)
