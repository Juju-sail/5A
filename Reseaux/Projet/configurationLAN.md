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

## Config d'un switch

...