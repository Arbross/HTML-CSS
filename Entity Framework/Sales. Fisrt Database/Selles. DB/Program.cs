using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selles.DB
{
    /*CREATE DATABASE Selles

USE Selles

CREATE TABLE Buyers
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(MAX) NOT NULL CHECK([Name] <> ''),
	[Surname] NVARCHAR(MAX) NOT NULL CHECK([Surname] <> '')
)

CREATE TABLE Sellers
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(MAX) NOT NULL CHECK([Name] <> ''),
	[Surname] NVARCHAR(MAX) NOT NULL CHECK([Surname] <> '')
)

CREATE TABLE Sells
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[BuyerId] INT NOT NULL REFERENCES Buyers(Id),
	[SellerId] INT NOT NULL  REFERENCES Sellers(Id),
	[SellSum] INT NOT NULL,
	[SellDate] DATE NOT NULL CHECK([SellDate] <= GetDate())
)

insert into Buyers (Name, Surname) values ('Montgomery', 'Purchon');
insert into Buyers (Name, Surname) values ('Upton', 'Eastup');
insert into Buyers (Name, Surname) values ('Ringo', 'Railton');
insert into Buyers (Name, Surname) values ('Emyle', 'Mangham');
insert into Buyers (Name, Surname) values ('Sollie', 'Darnody');
insert into Buyers (Name, Surname) values ('Shem', 'Harburtson');
insert into Buyers (Name, Surname) values ('Dana', 'Montilla');
insert into Buyers (Name, Surname) values ('Dehlia', 'Tice');
insert into Buyers (Name, Surname) values ('Blinnie', 'Izaac');
insert into Buyers (Name, Surname) values ('Jillane', 'Ashworth');
insert into Buyers (Name, Surname) values ('Marja', 'Bengefield');
insert into Buyers (Name, Surname) values ('Dolf', 'Newrick');
insert into Buyers (Name, Surname) values ('Ethelbert', 'Bussen');
insert into Buyers (Name, Surname) values ('Hannie', 'Cornelleau');
insert into Buyers (Name, Surname) values ('Phyllida', 'Hynam');
insert into Buyers (Name, Surname) values ('Man', 'Bertolaccini');
insert into Buyers (Name, Surname) values ('Ursuline', 'Tripony');
insert into Buyers (Name, Surname) values ('Tate', 'Cargon');
insert into Buyers (Name, Surname) values ('Orton', 'Migheli');
insert into Buyers (Name, Surname) values ('Niels', 'Matterface');
insert into Buyers (Name, Surname) values ('Bronnie', 'Solleme');
insert into Buyers (Name, Surname) values ('Joscelin', 'Dyhouse');
insert into Buyers (Name, Surname) values ('Ruggiero', 'Selwin');
insert into Buyers (Name, Surname) values ('Dory', 'de Almeida');
insert into Buyers (Name, Surname) values ('Leodora', 'Ludlom');
insert into Buyers (Name, Surname) values ('Rani', 'Hawke');
insert into Buyers (Name, Surname) values ('Cobby', 'Stickings');
insert into Buyers (Name, Surname) values ('Donella', 'Domelaw');
insert into Buyers (Name, Surname) values ('Emmey', 'Crumpe');
insert into Buyers (Name, Surname) values ('Nye', 'Bridat');
insert into Buyers (Name, Surname) values ('Darwin', 'Naisbitt');
insert into Buyers (Name, Surname) values ('Stinky', 'Mattiazzi');
insert into Buyers (Name, Surname) values ('Sisely', 'Raine');
insert into Buyers (Name, Surname) values ('Sidnee', 'Bauser');
insert into Buyers (Name, Surname) values ('Merrielle', 'Raspison');
insert into Buyers (Name, Surname) values ('Michail', 'Thaxton');
insert into Buyers (Name, Surname) values ('Blakelee', 'Conrard');
insert into Buyers (Name, Surname) values ('Wendy', 'Chmarny');
insert into Buyers (Name, Surname) values ('Egan', 'Burgane');
insert into Buyers (Name, Surname) values ('Karel', 'Frankum');
insert into Buyers (Name, Surname) values ('Aldin', 'Battie');
insert into Buyers (Name, Surname) values ('Carlene', 'Hugle');
insert into Buyers (Name, Surname) values ('Kristy', 'Baigent');
insert into Buyers (Name, Surname) values ('Jordan', 'Verny');
insert into Buyers (Name, Surname) values ('Chancey', 'Bernath');
insert into Buyers (Name, Surname) values ('Kiel', 'Cottier');
insert into Buyers (Name, Surname) values ('Gris', 'Davers');
insert into Buyers (Name, Surname) values ('Thor', 'Kleynen');
insert into Buyers (Name, Surname) values ('Arlen', 'Puncher');
insert into Buyers (Name, Surname) values ('Sawyere', 'Noller');
insert into Buyers (Name, Surname) values ('Elfie', 'Yakubov');
insert into Buyers (Name, Surname) values ('Inness', 'Ridgers');
insert into Buyers (Name, Surname) values ('Milka', 'Gornal');
insert into Buyers (Name, Surname) values ('Karyn', 'Lapping');
insert into Buyers (Name, Surname) values ('Irena', 'Fitzsymons');
insert into Buyers (Name, Surname) values ('Mariel', 'Hulatt');
insert into Buyers (Name, Surname) values ('Florenza', 'Enticott');
insert into Buyers (Name, Surname) values ('Elga', 'Darrigone');
insert into Buyers (Name, Surname) values ('Nicoli', 'Pretious');
insert into Buyers (Name, Surname) values ('Torrie', 'Delgadillo');
insert into Buyers (Name, Surname) values ('Shelli', 'Huttley');
insert into Buyers (Name, Surname) values ('Aile', 'Heliet');
insert into Buyers (Name, Surname) values ('Brande', 'Ellingworth');
insert into Buyers (Name, Surname) values ('Jeff', 'Bristow');
insert into Buyers (Name, Surname) values ('Pate', 'McBoyle');
insert into Buyers (Name, Surname) values ('Misha', 'Cattow');
insert into Buyers (Name, Surname) values ('Franklyn', 'Aris');
insert into Buyers (Name, Surname) values ('Kendra', 'Higgoe');
insert into Buyers (Name, Surname) values ('Hube', 'Gascoine');
insert into Buyers (Name, Surname) values ('Tillie', 'Alcott');
insert into Buyers (Name, Surname) values ('Linet', 'Kittman');
insert into Buyers (Name, Surname) values ('Gerry', 'Caldwell');
insert into Buyers (Name, Surname) values ('Antoni', 'Dendle');
insert into Buyers (Name, Surname) values ('Elmore', 'Jobes');
insert into Buyers (Name, Surname) values ('Elisha', 'Verling');
insert into Buyers (Name, Surname) values ('Norman', 'Hannabuss');
insert into Buyers (Name, Surname) values ('Micky', 'McGarva');
insert into Buyers (Name, Surname) values ('Marylee', 'Wisam');
insert into Buyers (Name, Surname) values ('Heath', 'Cartmael');
insert into Buyers (Name, Surname) values ('Layla', 'Thurman');
insert into Buyers (Name, Surname) values ('Pattie', 'Searchfield');
insert into Buyers (Name, Surname) values ('Marcos', 'Clohisey');
insert into Buyers (Name, Surname) values ('Tades', 'Heminsley');
insert into Buyers (Name, Surname) values ('Francene', 'Bayly');
insert into Buyers (Name, Surname) values ('Theo', 'Cicchinelli');
insert into Buyers (Name, Surname) values ('Chelsae', 'Revans');
insert into Buyers (Name, Surname) values ('Emlyn', 'Eilers');
insert into Buyers (Name, Surname) values ('Graig', 'Burchmore');
insert into Buyers (Name, Surname) values ('Gwenni', 'Shedd');
insert into Buyers (Name, Surname) values ('Carolyn', 'Earle');
insert into Buyers (Name, Surname) values ('Robyn', 'Prettjohn');
insert into Buyers (Name, Surname) values ('Bernardina', 'Parsall');
insert into Buyers (Name, Surname) values ('Brandea', 'Jenton');
insert into Buyers (Name, Surname) values ('Ignaz', 'Pettegre');
insert into Buyers (Name, Surname) values ('Averil', 'Towle');
insert into Buyers (Name, Surname) values ('Jessie', 'Polak');
insert into Buyers (Name, Surname) values ('Frankie', 'Prichard');
insert into Buyers (Name, Surname) values ('Delphine', 'Charle');
insert into Buyers (Name, Surname) values ('Shelba', 'Willison');
insert into Buyers (Name, Surname) values ('Tiler', 'Nellies');

insert into Sellers (Name, Surname) values ('Esteban', 'Duprey');
insert into Sellers (Name, Surname) values ('Dave', 'Mazonowicz');
insert into Sellers (Name, Surname) values ('Malia', 'Lopes');
insert into Sellers (Name, Surname) values ('Nessy', 'Seals');
insert into Sellers (Name, Surname) values ('Thibaud', 'Colby');
insert into Sellers (Name, Surname) values ('Nata', 'Harbertson');
insert into Sellers (Name, Surname) values ('Dynah', 'Gotcher');
insert into Sellers (Name, Surname) values ('Darrell', 'Jost');
insert into Sellers (Name, Surname) values ('Keen', 'Reams');
insert into Sellers (Name, Surname) values ('Gregorio', 'Thexton');
insert into Sellers (Name, Surname) values ('Jeana', 'Denyukhin');
insert into Sellers (Name, Surname) values ('Rosamond', 'Dudney');
insert into Sellers (Name, Surname) values ('Jazmin', 'Work');
insert into Sellers (Name, Surname) values ('Corliss', 'Defew');
insert into Sellers (Name, Surname) values ('Kingston', 'Sprouls');
insert into Sellers (Name, Surname) values ('Hanna', 'Boult');
insert into Sellers (Name, Surname) values ('Kareem', 'Simionato');
insert into Sellers (Name, Surname) values ('Jennie', 'Sleicht');
insert into Sellers (Name, Surname) values ('Giovanni', 'Kissock');
insert into Sellers (Name, Surname) values ('Kendra', 'Butter');
insert into Sellers (Name, Surname) values ('Karole', 'Howgego');
insert into Sellers (Name, Surname) values ('Whitney', 'Torry');
insert into Sellers (Name, Surname) values ('Merla', 'Betun');
insert into Sellers (Name, Surname) values ('Templeton', 'Giorgetti');
insert into Sellers (Name, Surname) values ('Cointon', 'Dunkersley');
insert into Sellers (Name, Surname) values ('Corney', 'Conybear');
insert into Sellers (Name, Surname) values ('Nariko', 'McNeice');
insert into Sellers (Name, Surname) values ('Ulrikaumeko', 'Conquest');
insert into Sellers (Name, Surname) values ('Gabriele', 'Duerden');
insert into Sellers (Name, Surname) values ('Giffer', 'Callan');
insert into Sellers (Name, Surname) values ('Brooks', 'Caney');
insert into Sellers (Name, Surname) values ('Brett', 'Stockhill');
insert into Sellers (Name, Surname) values ('Dael', 'Frosch');
insert into Sellers (Name, Surname) values ('Gaynor', 'Andreix');
insert into Sellers (Name, Surname) values ('Gert', 'Dayly');
insert into Sellers (Name, Surname) values ('Tyler', 'McMarquis');
insert into Sellers (Name, Surname) values ('Kylen', 'Oliver-Paull');
insert into Sellers (Name, Surname) values ('Ashby', 'Alpin');
insert into Sellers (Name, Surname) values ('Ericha', 'Grzelczak');
insert into Sellers (Name, Surname) values ('Jeth', 'Kohtler');
insert into Sellers (Name, Surname) values ('Ara', 'Fritschmann');
insert into Sellers (Name, Surname) values ('Hallsy', 'Baalham');
insert into Sellers (Name, Surname) values ('Wat', 'Cawkwell');
insert into Sellers (Name, Surname) values ('Court', 'Millimoe');
insert into Sellers (Name, Surname) values ('Nichole', 'Powe');
insert into Sellers (Name, Surname) values ('Ashla', 'Corbett');
insert into Sellers (Name, Surname) values ('Sande', 'Duhig');
insert into Sellers (Name, Surname) values ('Spense', 'Hursthouse');
insert into Sellers (Name, Surname) values ('Raimondo', 'Epinoy');
insert into Sellers (Name, Surname) values ('Kennett', 'Malek');
insert into Sellers (Name, Surname) values ('Hashim', 'Plaster');
insert into Sellers (Name, Surname) values ('Dal', 'Rawlcliffe');
insert into Sellers (Name, Surname) values ('Conroy', 'Spiaggia');
insert into Sellers (Name, Surname) values ('Gwendolen', 'Keitch');
insert into Sellers (Name, Surname) values ('Merridie', 'Colisbe');
insert into Sellers (Name, Surname) values ('Kendra', 'Peddar');
insert into Sellers (Name, Surname) values ('Torr', 'Simpole');
insert into Sellers (Name, Surname) values ('Gerick', 'Hamblett');
insert into Sellers (Name, Surname) values ('Felicia', 'Grimsdith');
insert into Sellers (Name, Surname) values ('Norah', 'Golden');
insert into Sellers (Name, Surname) values ('Ellwood', 'Rolfi');
insert into Sellers (Name, Surname) values ('Collen', 'Yakobovicz');
insert into Sellers (Name, Surname) values ('Kelci', 'Mariner');
insert into Sellers (Name, Surname) values ('Ivett', 'Village');
insert into Sellers (Name, Surname) values ('Viviyan', 'Andryushchenko');
insert into Sellers (Name, Surname) values ('Electra', 'Keirl');
insert into Sellers (Name, Surname) values ('Stewart', 'Luty');
insert into Sellers (Name, Surname) values ('Aile', 'Schwant');
insert into Sellers (Name, Surname) values ('Demetra', 'D''Antoni');
insert into Sellers (Name, Surname) values ('Antonin', 'Pinks');
insert into Sellers (Name, Surname) values ('Packston', 'Adolf');
insert into Sellers (Name, Surname) values ('Melodee', 'Laneham');
insert into Sellers (Name, Surname) values ('Katina', 'Aspinal');
insert into Sellers (Name, Surname) values ('Siouxie', 'Murrells');
insert into Sellers (Name, Surname) values ('Althea', 'Challis');
insert into Sellers (Name, Surname) values ('Adrienne', 'Sawle');
insert into Sellers (Name, Surname) values ('Evy', 'Ashby');
insert into Sellers (Name, Surname) values ('Berget', 'Keeping');
insert into Sellers (Name, Surname) values ('Hillary', 'Way');
insert into Sellers (Name, Surname) values ('Talya', 'Hoovart');
insert into Sellers (Name, Surname) values ('Kristin', 'Carbery');
insert into Sellers (Name, Surname) values ('Gael', 'Hunnable');
insert into Sellers (Name, Surname) values ('Stevena', 'Goodbanne');
insert into Sellers (Name, Surname) values ('Jonis', 'Cicculini');
insert into Sellers (Name, Surname) values ('Tawsha', 'Creswell');
insert into Sellers (Name, Surname) values ('Emerson', 'Dupey');
insert into Sellers (Name, Surname) values ('Billi', 'Cradock');
insert into Sellers (Name, Surname) values ('Ula', 'Franzman');
insert into Sellers (Name, Surname) values ('Hodge', 'Felix');
insert into Sellers (Name, Surname) values ('Lissie', 'Found');
insert into Sellers (Name, Surname) values ('Hayden', 'Wrotham');
insert into Sellers (Name, Surname) values ('Ingamar', 'Broxholme');
insert into Sellers (Name, Surname) values ('Joelly', 'Hemphall');
insert into Sellers (Name, Surname) values ('Alisa', 'Gratland');
insert into Sellers (Name, Surname) values ('Cece', 'Stearns');
insert into Sellers (Name, Surname) values ('Henka', 'Simao');
insert into Sellers (Name, Surname) values ('Hilary', 'Midgley');
insert into Sellers (Name, Surname) values ('Welch', 'Jakel');
insert into Sellers (Name, Surname) values ('Bianka', 'Abramson');
insert into Sellers (Name, Surname) values ('Daffy', 'Skoyles');

insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (38, 43, 1539990, '2020/04/16');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (59, 35, 2788287, '1962/01/29');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (56, 38, 1437047, '1959/06/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (34, 7, 1990900, '2015/01/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (59, 99, 8145066, '1996/07/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (34, 46, 4203498, '1962/01/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (83, 71, 592776, '1949/06/01');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (37, 85, 9411695, '2017/06/03');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (18, 24, 270193, '1926/11/16');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (59, 61, 9860036, '2001/01/29');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (53, 31, 7420083, '1940/04/01');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (83, 27, 4774374, '2019/07/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (43, 35, 3748770, '1992/12/22');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (78, 57, 3284846, '1973/02/22');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (45, 95, 4433798, '1957/09/10');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (49, 88, 669124, '1952/06/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (22, 94, 8174435, '1936/01/26');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (11, 74, 1735805, '1981/10/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (60, 18, 3721821, '2010/07/12');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (60, 77, 5942650, '1948/06/13');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (19, 63, 9343511, '1982/02/24');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (97, 45, 1474017, '1925/11/24');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (19, 78, 3423133, '2016/07/01');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (18, 94, 2758803, '2012/06/13');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (13, 70, 2909739, '1971/10/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (34, 61, 8068225, '1999/04/10');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (36, 42, 4435599, '2004/10/15');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (77, 10, 7372357, '1949/03/13');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (7, 56, 4787595, '1985/12/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (2, 43, 1567263, '1924/09/19');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (98, 67, 1642645, '1951/08/20');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (61, 24, 7046770, '1942/12/06');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (75, 12, 7359583, '1982/02/22');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (66, 32, 8797477, '1939/09/03');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (5, 60, 2807426, '1995/03/21');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (10, 53, 5923515, '1938/12/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (86, 89, 3122250, '2014/08/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (80, 30, 5601877, '2018/11/29');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (11, 36, 9617307, '1960/05/15');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (82, 86, 2550818, '1957/09/16');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (10, 18, 8692779, '1988/08/27');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (70, 36, 1999565, '1995/04/06');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (16, 45, 2540015, '1928/10/19');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (55, 1, 2538267, '1940/02/18');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (89, 16, 4869145, '1979/12/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (35, 56, 427327, '1921/03/14');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (68, 39, 5705759, '1995/01/24');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (4, 46, 703715, '1976/04/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (94, 31, 5230690, '2006/07/14');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (59, 16, 1054173, '2019/06/30');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (66, 93, 8962900, '1936/07/10');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (20, 82, 1068268, '1947/02/16');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (70, 67, 9512279, '1995/10/12');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (42, 17, 8865275, '1979/02/09');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (90, 17, 4022928, '1948/12/22');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (38, 27, 2701941, '1924/07/01');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (17, 20, 1638509, '1994/09/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (57, 73, 3579469, '2017/12/05');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (80, 86, 4980245, '1998/06/04');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (65, 95, 4559037, '1988/08/19');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (92, 82, 4988043, '2001/10/23');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (93, 24, 5163330, '1986/03/22');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (13, 37, 6541101, '1934/05/14');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (33, 90, 2687677, '1999/01/12');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (63, 94, 279496, '1947/07/05');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (37, 79, 6112234, '1942/03/30');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (24, 64, 1676527, '2000/05/05');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (65, 43, 1351496, '1976/03/04');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (67, 30, 185237, '1978/03/20');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (79, 3, 5398707, '1943/09/10');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (30, 15, 9672624, '1948/11/17');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (3, 43, 3063123, '1942/03/28');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (82, 59, 4336088, '1924/09/24');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (31, 59, 1138312, '1992/06/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (94, 94, 2000845, '1939/05/17');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (65, 15, 2860827, '1960/04/04');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (4, 7, 3588120, '1935/12/15');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (65, 25, 476205, '1932/09/25');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (73, 33, 2412040, '1951/01/12');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (85, 29, 9818297, '1933/07/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (69, 75, 4044253, '2015/01/09');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (71, 21, 402128, '1923/05/26');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (55, 7, 4801877, '2009/05/01');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (51, 12, 2163037, '1998/08/20');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (17, 59, 1740394, '2012/02/19');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (27, 59, 6165263, '1972/03/28');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (20, 82, 8384617, '2010/09/20');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (69, 100, 4521829, '1921/07/10');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (27, 23, 5787964, '2005/03/08');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (80, 27, 6206696, '1924/08/29');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (53, 80, 5690230, '1963/04/21');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (95, 6, 9702555, '1987/10/04');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (65, 70, 205443, '1996/11/03');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (99, 49, 4172473, '2000/10/15');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (71, 43, 8149357, '1950/12/07');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (28, 4, 7707218, '1995/01/21');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (37, 32, 4324102, '2013/11/14');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (90, 44, 497272, '2012/04/06');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (15, 68, 6351221, '1998/06/21');
insert into Sells (BuyerId, SellerId, SellSum, SellDate) values (60, 36, 3878533, '1978/03/18');*/
    class Program
    {
        private static void AddNewSellBuy(SqlConnection connection)
        {
            Console.Write("Enter BuyerId : ");
            int buyerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter SellerId : ");
            int sellerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter SellSum : ");
            int sellSum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter SellDate : ");
            string sellDate = Console.ReadLine();

            string cmdText = $"INSERT INTO Sells (BuyerId, SellerId, SellSum, SellDate) VALUES ({buyerId}, {sellerId}, {sellSum}, '{sellDate}')";
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandTimeout = 5;

            int rows = command.ExecuteNonQuery();

            Console.WriteLine(rows + " rows affected!");
        }
        private static void SellerHighPurchase(SqlConnection connection)
        {
            string cmdText = $"SELECT Sellers.Name FROM Sellers JOIN Sells ON Sells.SellerId = Sellers.Id GROUP BY Sellers.Name HAVING MAX(Sells.SellSum) IN (SELECT MAX(Sells.SellSum) FROM Sellers JOIN Sells ON Sells.SellerId = Sellers.Id)";

            SqlCommand command = new SqlCommand(cmdText, connection);

            SqlDataReader reader = command.ExecuteReader();

            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine("\n------------");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void DeleteBuyerOrSeller(SqlConnection connection, string table = "Buyers")
        {
            Console.WriteLine("Enter id : ");
            int id = Console.Read();

            string cmdText = $"DELETE FROM {table} WHERE {table}.Id = {id}";

            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandTimeout = 5; // default - 30sec

            int rows = command.ExecuteNonQuery();

            Console.WriteLine(rows + " rows affected!");
        }

        private static void theLastBuyOfTheBuyer(SqlConnection connection)
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname : ");
            string surname = Console.ReadLine();

            string cmdText = $"SELECT TOP 1 * FROM Buyers JOIN Sells ON Sells.BuyerId = Buyers.Id WHERE Buyers.Name = '{name}' AND Buyers.Surname = '{surname}' ORDER BY Sells.SellDate DESC";

            SqlCommand command = new SqlCommand(cmdText, connection);

            SqlDataReader reader = command.ExecuteReader();

            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void InfoSelectedPeriod(SqlConnection connection)
        {
            Console.WriteLine("Enter the date to smth : ");
            string date = Console.ReadLine();

            string cmdText = $"SELECT * FROM Sells WHERE '{date}' < Sells.SellDate";

            SqlCommand command = new SqlCommand(cmdText, connection);

            SqlDataReader reader = command.ExecuteReader();

            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string conn = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString​;
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();

            Console.WriteLine("1 - Add new sell/buy");
            Console.WriteLine("2 - Info about select period");
            Console.WriteLine("3 - The last buy");
            Console.WriteLine("4 - Delete seller or buyer");
            Console.WriteLine("5 - Show seller with a high purchase");
            string choose = Console.ReadLine();

            switch(choose)
            {
                case "1":
                    {
                        Console.WriteLine("1 - Sell");
                        Console.WriteLine("2 - Buy");
                        string res = Console.ReadLine();
                        switch (res)
                        {
                            case "1":
                                {
                                    AddNewSellBuy(connection);
                                }
                                break;
                            case "2":
                                {
                                    AddNewSellBuy(connection);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "2":
                    {
                        InfoSelectedPeriod(connection);
                    }
                    break;
                case "3":
                    {
                        theLastBuyOfTheBuyer(connection);
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("1 - Buyer");
                        Console.WriteLine("2 - Seller");
                        string res = Console.ReadLine();
                        switch(res)
                        {
                            case "1":
                                {
                                    DeleteBuyerOrSeller(connection);
                                }
                                break;
                            case "2":
                                {
                                    DeleteBuyerOrSeller(connection, "Sellers"); 
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "5":
                    {
                        SellerHighPurchase(connection);
                    }
                    break;
                default:
                    break;
            }
            connection.Close();
        }
    }
}
