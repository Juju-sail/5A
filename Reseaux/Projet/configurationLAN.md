# Config du LAN

## Config d'un hote :

ip address add 15.200.1.2/23 dev 15-ETHZ
ip route add default via 15.200.1.253

root@PARI_host:~# ip address add 15.103.0.1/24 dev PARIrouter
root@PARI_host:~# ip route add default via 15.103.0.254

## Config d'un router :

### AS : 

LOND_router# conf t
LOND_router(config)# interface ext_13_GENE
LOND_router(config-if)# ip address 179.0.36.2/24
LOND_router(config-if)# exit

### OSPF :

PARI_router# conf t
PARI_router(config)# router ospf
PARI_router(config-router)# network 15.0.1.0/24 area 0
PARI_router(config-router)# network 15.0.5.0/24 area 0
PARI_router(config-router)# network 15.0.6.0/24 area 0
PARI_router(config-router)# network 15.0.4.0/24 area 0
PARI_router(config-router)# network 15.0.3.0/24 area 0
PARI_router(config-router)# network 179.0.41.2/24 area 0
PARI_router(config-router)# exit

### eBGP

MIAM_router# conf t
MIAM_router(config)# router bgp 15
MIAM_router(config-router)# address-family ipv4 unicast
MIAM_router(config-router-af)# neighbor 15.151.0.1 next-hop-self

MIAM_router(config-router-af)#neighbor 15.151.0.1 next-hop-self

MIAM_router(config-router-af)#neighbor 15.152.0.1 next-hop-self

MIAM_router(config-router-af)#neighbor 15.153.0.1 next-hop-self
MIAM_router(config-router-af)#neighbor 15.154.0.1 next-hop-self
MIAM_router(config-router-af)#neighbor 15.155.0.1 next-hop-self
MIAM_router(config-router-af)#neighbor 15.156.0.1 next-hop-self
MIAM_router(config-router-af)#neighbor 15.157.0.1 next-hop-self
MIAM_router(config-router-af)#neighbor 15.158.0.1 next-hop-self



On a verifier tout ça grace à looking_glass :

![image-20221121164046703](C:\Users\julie\AppData\Roaming\Typora\typora-user-images\image-20221121164046703.png)

pour joindre le 11, on passe par le 13

pour joindre le 12, on passe soit par 13, soit 14

le lien avec 13 est direct

c'est cohérent avec le schémas



### Route-map

PARI_router# conf t
PARI_router(config)# ip prefix-list PREFIXEPERMITED-LIST permit 15.0.0.0/8
PARI_router(config)# ip prefix-list PREFIXEPERMITED-LIST permit 17.0.0.0/8
PARI_router(config)# ip prefix-list PREFIXEPERMITED-LIST permit 18.0.0.0/8
PARI_router(config)# route-map PREFIXPERMITED permit 10
PARI_router(config-route-map)# match ip address prefix-list PREFIXEPERMITED-LIST
PARI_router(config-route-map)# exit
PARI_router(config)# router bgp 15
PARI_router(config-router)# neighbor 179.0.41.2 route-map PREFIXPERMITED out
PARI_router(config-router)# exit
PARI_router(config)# exit
PARI_router# show ip bgp neighbors 179.0.41.2 advertised-routes

## Config d'un switch

...