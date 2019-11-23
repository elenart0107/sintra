CREATE DATABASE presiden_said
GO
USE presiden_said
GO

CREATE TABLE adminst (
	ADMIN_NR DECIMAL(15,5),
	PRES_NAME varchar(20),
	YEAR_INAUG decimal(15,5),
	VICE_PRES varchar(20)
)

CREATE TABLE election (
  ELECTIO_YE DECIMAL (15,5),
  CANDIDATE varchar(20),
  VOTES decimal(15,5),
  WINNERLOSE varchar(1)
)

CREATE TABLE pres_hob (
  PRES_NAME varchar(20),
  HOBBY varchar(20)
)

CREATE TABLE pres_mar (
  PRES_NAME varchar(20) DEFAULT NULL,
  SPOUSE_NAM varchar(20) DEFAULT NULL,
  PR_AGE DECIMAL(15,5) DEFAULT NULL,
  SP_AGE DECIMAL(15,5) DEFAULT NULL,
  NR_CHILDRE DECIMAL(15,5) DEFAULT NULL,
  MAR_YEAR DECIMAL(15,5) DEFAULT NULL
)

CREATE TABLE presiden (
  PRES_NAME varchar(20),
  BIRTH_YR DECIMAL(15,5),
  YRS_SERV DECIMAL(15,5) ,
  DEATH_AGE DECIMAL(15,5),
  PARTY varchar(10),
  STATE_BORN varchar(15)
)

CREATE TABLE state (
  STATE_NAME varchar(15) DEFAULT NULL,
  ADMIN_ENTE DECIMAL(15,5) DEFAULT NULL,
  YEAR_ENTER DECIMAL(15,5) DEFAULT NULL
)
GO

INSERT INTO adminst (ADMIN_NR,PRES_NAME,YEAR_INAUG,VICE_PRES) VALUES 
 (1.00000,'Washington G',1789.00000,'Adams J'),
 (2.00000,'Washington G',1793.00000,'Adams J'),
 (3.00000,'Adams J',1797.00000,'Jefferson T'),
 (4.00000,'Jefferson T',1801.00000,'Burr A'),
 (5.00000,'Jefferson T',1805.00000,'Clinton G'),
 (6.00000,'Madison J',1809.00000,'Clinton G'),
 (7.00000,'Madison J',1813.00000,'Gerry E'),
 (8.00000,'Monroe J',1817.00000,'Tompkins D'),
 (9.00000,'Monroe J',1821.00000,'Tompkins D'),
 (10.00000,'Adams J Q',1825.00000,'Calhoun J'),
 (11.00000,'Jackson A',1829.00000,'Calhoun J'),
 (12.00000,'Jackson A',1833.00000,'Van Buren M'),
 (13.00000,'Van Buren M',1837.00000,'Johnson R M'),
 (14.00000,'Harrison W H',1841.00000,'Tyler J'),
 (15.00000,'Polk J K',1845.00000,'Dallas G M'),
 (16.00000,'Taylor Z',1849.00000,'Fillmore M'),
 (17.00000,'Pierce F',1853.00000,'De Vane King W R'),
 (18.00000,'Buchanan J',1857.00000,'Breckinridge J C'),
 (19.00000,'Lincoln A',1861.00000,'Hamlin H'),
 (20.00000,'Lincoln A',1865.00000,'Johnson A'),
 (21.00000,'Grant U S',1869.00000,'Colfax S'),
 (22.00000,'Grant U S',1873.00000,'Wilson H'),
 (23.00000,'Hayes R B',1877.00000,'Wheeler W'),
 (24.00000,'Garfield J A',1881.00000,'Arthur C A'),
 (25.00000,'Cleveland G',1885.00000,'Hendricks T A'),
 (26.00000,'Harrison B',1889.00000,'Mortron L P'),
 (27.00000,'Cleveland G',1893.00000,'Stevenson A E'),
 (28.00000,'McKinley W',1897.00000,'Hobart G A'),
 (29.00000,'McKinley W',1901.00000,'Roosevelt T'),
 (30.00000,'Roosevelt T',1905.00000,'Fairbanks C W'),
 (31.00000,'Taft W H',1909.00000,'Sherman J S'),
 (32.00000,'Wilson W',1913.00000,'Marshall T R'),
 (33.00000,'Wilson W',1917.00000,'Marshall T R'),
 (34.00000,'Harding W G',1921.00000,'Coolidge C'),
 (35.00000,'Coolidge C',1925.00000,'Dawes C G'),
 (36.00000,'Hoover H C',1929.00000,'Curtis C'),
 (37.00000,'Roosevelt F D',1933.00000,'Garner J N'),
 (38.00000,'Roosevelt F D',1937.00000,'Garner J N'),
 (39.00000,'Roosevelt F D',1941.00000,'Wallace H A'),
 (40.00000,'Roosevelt F D',1945.00000,'Truman H S'),
 (41.00000,'Truman H S',1949.00000,'Barkley A W'),
 (42.00000,'Eisenhower D D',1953.00000,'Nixon R M'),
 (43.00000,'Eisenhower D D',1957.00000,'Nixon R M'),
 (44.00000,'Kennedy J F',1961.00000,'Johnson L B'),
 (45.00000,'Johnson L B',1965.00000,'Humprey H H'),
 (46.00000,'Nixon R M',1969.00000,'Agnew S T'),
 (47.00000,'Nixon R M',1970.00000,'Agnew S T'),
 (47.00000,'Nixon R M',1973.00000,'Ford G R'),
 (47.00000,'Ford G R',1974.00000,'Rockefeller N A'),
 (48.00000,'Carter J E',1977.00000,'Mondale Wf'),
 (49.00000,'Reagan R',1981.00000,'Bush G'),
 (50.00000,'Reagan R',1985.00000,'Bush G'),
 (51.00000,'Bush G',1989.00000,'Quayle D'),
 (52.00000,'Clinton B',1993.00000,'Gore A'),
 (53.00000,'Clinton B',1997.00000,'Gore A'),
 (54.00000,'Bush G W',2001.00000,'Cheney D'),
 (55.00000,'Bush G W',2005.00000,'Cheney D');

 INSERT INTO election (ELECTIO_YE,CANDIDATE,VOTES,WINNERLOSE) VALUES 
 (1789.00000,'Washington G',69.00000,'W'),
 (1789.00000,'Adams J',34.00000,'L'),
 (1789.00000,'Jay J',9.00000,'L'),
 (1789.00000,'Harrison R H',6.00000,'L'),
 (1789.00000,'Rutledge J',6.00000,'L'),
 (1789.00000,'Hancock J',4.00000,'L'),
 (1789.00000,'Clinton G',3.00000,'L'),
 (1789.00000,'Huntington S',2.00000,'L'),
 (1789.00000,'Milton J',2.00000,'L'),
 (1789.00000,'Armstrong J',1.00000,'L'),
 (1789.00000,'Lincoln B',1.00000,'L'),
 (1789.00000,'Telfair E',1.00000,'L'),
 (1792.00000,'Washington G',132.00000,'W'),
 (1792.00000,'Adams J',77.00000,'L'),
 (1792.00000,'Clinton G',50.00000,'L'),
 (1792.00000,'Jefferson T',4.00000,'L'),
 (1792.00000,'Burr A',1.00000,'L'),
 (1796.00000,'Adams J',71.00000,'W'),
 (1796.00000,'Jefferson T',68.00000,'L'),
 (1796.00000,'Pickney T',59.00000,'L'),
 (1796.00000,'Burr A',30.00000,'L'),
 (1796.00000,'Adams S',15.00000,'L'),
 (1796.00000,'Ellsworth O',11.00000,'L'),
 (1796.00000,'Clinton G',7.00000,'L'),
 (1796.00000,'Jay J',5.00000,'L'),
 (1796.00000,'Irell J',3.00000,'L'),
 (1796.00000,'Henry J',2.00000,'L'),
 (1796.00000,'Johnson S',2.00000,'L'),
 (1796.00000,'Washington G',2.00000,'L'),
 (1796.00000,'Pinckney C C',1.00000,'L'),
 (1800.00000,'Jefferson T',73.00000,'W'),
 (1800.00000,'Burr A',73.00000,'L'),
 (1800.00000,'Adams J',65.00000,'L'),
 (1800.00000,'Pinckney C C',64.00000,'L'),
 (1800.00000,'Jay J',1.00000,'L'),
 (1804.00000,'Jefferson T',162.00000,'W'),
 (1804.00000,'Pinckney C C',14.00000,'L'),
 (1808.00000,'Madison J',122.00000,'W'),
 (1808.00000,'Pinckney C C',47.00000,'L'),
 (1808.00000,'Clinton G',6.00000,'L'),
 (1812.00000,'Madison J',128.00000,'W'),
 (1812.00000,'Clinton G',89.00000,'L'),
 (1816.00000,'Monroe J',183.00000,'W'),
 (1816.00000,'King R',34.00000,'L'),
 (1820.00000,'Monroe J',231.00000,'W'),
 (1820.00000,'Adams J Q',1.00000,'L'),
 (1824.00000,'Adams J Q',84.00000,'W'),
 (1824.00000,'Jackson A',99.00000,'L'),
 (1824.00000,'Crawford W H',41.00000,'L'),
 (1824.00000,'Clay H',37.00000,'L'),
 (1828.00000,'Jackson A',178.00000,'W'),
 (1828.00000,'Adams J',83.00000,'L'),
 (1832.00000,'Jackson A',219.00000,'W'),
 (1832.00000,'clay H',49.00000,'L'),
 (1832.00000,'Floyd J',11.00000,'L'),
 (1832.00000,'Wirt W',7.00000,'L'),
 (1836.00000,'Van Buren M',170.00000,'W'),
 (1836.00000,'Harrison W H',73.00000,'L'),
 (1836.00000,'White H L',26.00000,'L'),
 (1836.00000,'Webster D',14.00000,'L'),
 (1836.00000,'Mangum W P',11.00000,'L'),
 (1840.00000,'Harrison W H',234.00000,'W'),
 (1840.00000,'Van Buren M',60.00000,'L'),
 (1844.00000,'Polk J K',170.00000,'W'),
 (1844.00000,'Clay H',105.00000,'L'),
 (1848.00000,'Taylor Z',163.00000,'W'),
 (1848.00000,'Cass L',127.00000,'L'),
 (1852.00000,'Pierce F',254.00000,'W'),
 (1852.00000,'Scott W',42.00000,'L'),
 (1856.00000,'Buchanan J',174.00000,'W'),
 (1856.00000,'Fremont J C',114.00000,'L'),
 (1856.00000,'Fillmore M',8.00000,'L'),
 (1860.00000,'Lincoln A',180.00000,'W'),
 (1860.00000,'Breckinridge J',72.00000,'L'),
 (1860.00000,'Bell J',39.00000,'L'),
 (1860.00000,'Douglas S',12.00000,'L'),
 (1864.00000,'Lincoln A',212.00000,'W'),
 (1864.00000,'McClellan G B',21.00000,'L'),
 (1868.00000,'Grant U S',214.00000,'W'),
 (1868.00000,'Seymour',80.00000,'L'),
 (1872.00000,'Grant U S',286.00000,'W'),
 (1872.00000,'Hendricks T A',42.00000,'L'),
 (1872.00000,'Brown B G',18.00000,'L'),
 (1872.00000,'Jenkins C J',2.00000,'L'),
 (1872.00000,'Davis D',1.00000,'L'),
 (1876.00000,'Hayes R B',185.00000,'W'),
 (1876.00000,'Tilden S J',184.00000,'L'),
 (1880.00000,'Garfield J A',214.00000,'W'),
 (1880.00000,'Hancock W S',155.00000,'L'),
 (1884.00000,'Cleveland G',219.00000,'W'),
 (1884.00000,'Blaine J G',182.00000,'L'),
 (1888.00000,'Harrison B',233.00000,'W'),
 (1888.00000,'Cleveland G',168.00000,'L'),
 (1892.00000,'Cleveland G',277.00000,'W'),
 (1892.00000,'Harrison B',145.00000,'L'),
 (1892.00000,'Weaver J B',22.00000,'L'),
 (1896.00000,'McKinley W',271.00000,'W'),
 (1896.00000,'Bryan W J',176.00000,'W'),
 (1900.00000,'McKinley W',292.00000,'W'),
 (1900.00000,'Bryan W J',155.00000,'L'),
 (1904.00000,'Roosevelt T',336.00000,'W'),
 (1904.00000,'Parker A B',140.00000,'L'),
 (1908.00000,'Taft W H',321.00000,'W'),
 (1908.00000,'Bryan W J',162.00000,'L'),
 (1912.00000,'Wilson W',435.00000,'W'),
 (1912.00000,'Roosevelt T',88.00000,'L'),
 (1912.00000,'Taft W H',8.00000,'L'),
 (1916.00000,'Wilson W',277.00000,'W'),
 (1916.00000,'Hughes C E',254.00000,'L'),
 (1920.00000,'Harding W G',404.00000,'W'),
 (1920.00000,'Cox W W',127.00000,'L'),
 (1924.00000,'Coolidge C',382.00000,'W'),
 (1924.00000,'Davis J W',136.00000,'L'),
 (1924.00000,'La Follette R M',13.00000,'L'),
 (1928.00000,'Hoover H C',444.00000,'W'),
 (1928.00000,'Smith A E',87.00000,'L'),
 (1932.00000,'Roosevelt F D',472.00000,'W'),
 (1932.00000,'Hoover H C',59.00000,'L'),
 (1936.00000,'Roosevelt F D',523.00000,'W'),
 (1936.00000,'Landon A M',8.00000,'L'),
 (1940.00000,'Roosevelt F D',449.00000,'W'),
 (1940.00000,'Wilkie W L',82.00000,'L'),
 (1944.00000,'Roosevelt F D',432.00000,'W'),
 (1944.00000,'Dewey T E',99.00000,'L'),
 (1948.00000,'Truman H S',303.00000,'W'),
 (1948.00000,'Dewey T E',189.00000,'L'),
 (1948.00000,'Thurmond J S',39.00000,'L'),
 (1952.00000,'Eisenhouwer D D',442.00000,'W'),
 (1952.00000,'Stevenson A',89.00000,'L'),
 (1956.00000,'Eisenhouwer D D',457.00000,'W'),
 (1956.00000,'Stevenson A',73.00000,'L'),
 (1956.00000,'Jones W B',1.00000,'L'),
 (1960.00000,'Kennedy J F',303.00000,'W'),
 (1960.00000,'Nixon R M',219.00000,'L'),
 (1960.00000,'Byrd',15.00000,'L'),
 (1964.00000,'Johnson L B',486.00000,'W'),
 (1964.00000,'Goldwater',52.00000,'L'),
 (1968.00000,'Nixon R M',301.00000,'W'),
 (1968.00000,'Humphrey H H',191.00000,'L'),
 (1968.00000,'Wallace G C',46.00000,'L'),
 (1972.00000,'Nixon R M',520.00000,'W'),
 (1972.00000,'McGovern G S',17.00000,'L'),
 (1972.00000,'Hospers J',1.00000,'L'),
 (1976.00000,'Carter J E',297.00000,'W'),
 (1976.00000,'Ford G R',240.00000,'L'),
 (1980.00000,'Reagan R',489.00000,'W'),
 (1980.00000,'Carter J E',49.00000,'L'),
 (1992.00000,'Clinton B',370.00000,'W'),
 (1992.00000,'Bush G',168.00000,'L'),
 (1992.00000,'Perot R',0.00000,'L'),
 (1996.00000,'Clinton B',0.00000,'W'),
 (1996.00000,'Dole B',0.00000,'L'),
 (2000.00000,'Bush G W',0.00000,'W'),
 (2000.00000,'Gore A',0.00000,'L'),
 (2004.00000,'Bush G W',286.00000,'W'),
 (2004.00000,'Kerry J',0.00000,'L');

 INSERT INTO pres_hob (PRES_NAME,HOBBY) VALUES 
 ('Adams J Q','Billiards'),
 ('Adams J Q','Swimming'),
 ('Adams J Q','Walking'),
 ('Arthur C A','Fishing'),
 ('Bush','Fishing'),
 ('Bush','Shooting'),
 ('Cleveland G','Fishing'),
 ('Coolidge C','Fishing'),
 ('Coolidge C','Golf'),
 ('Coolidge C','Indian Clubs'),
 ('Coolidge C','Mechanical Horse'),
 ('Coolidge C','Pitching Hay'),
 ('Eisenhouwer D D','Bridge'),
 ('Eisenhouwer D D','Fishing'),
 ('Eisenhouwer D D','Golf'),
 ('Eisenhouwer D D','Hunting'),
 ('Eisenhouwer D D','Painting'),
 ('Garfield J A','Billiards'),
 ('Harding W G','Golf'),
 ('Harding W G','Poker'),
 ('Harding W G','Riding'),
 ('Harrison B','Hunting'),
 ('Hayens R B','Croquet'),
 ('Hayens R B','Driving'),
 ('Hayens R B','Shooting'),
 ('Hoover H C','Fishing'),
 ('Hoover H C','Medicine Ball'),
 ('Jackson A','Riding'),
 ('Johnson L B','Riding'),
 ('Kennedy J F','Sailing'),
 ('Kennedy J F','Swimming'),
 ('Kennedy J F','Touch Football'),
 ('Lincoln A','Walking'),
 ('McKinley W','Riding'),
 ('McKinley W','Swimming'),
 ('McKinley W','Walking'),
 ('Nixon R M','Golf'),
 ('Reagan R','Shooting'),
 ('Roosevelt F D','Fishing'),
 ('Roosevelt F D','Sailing'),
 ('Roosevelt F D','Swimming'),
 ('Roosevelt T','Boxing'),
 ('Roosevelt T','Hunting'),
 ('Roosevelt T','Jujitsu'),
 ('Roosevelt T','Riding'),
 ('Roosevelt T','Shooting'),
 ('Roosevelt T','Tennis'),
 ('Roosevelt T','Wrestling'),
 ('Taft W H','Golf'),
 ('Taft W H','Riding'),
 ('Taylor Z','Riding'),
 ('Truman H S','Fishing'),
 ('Truman H S','Poker'),
 ('Truman H S','Walking'),
 ('Van Buren M','Riding'),
 ('Washington G','Fishing'),
 ('Washington G','Riding'),
 ('Wilson W','Golf'),
 ('Wilson W','Riding'),
 ('Wilson W','Walking'),
 ('Clinton B','Sax'),
 ('Bush G W','Baseball');

 INSERT INTO pres_mar (PRES_NAME,SPOUSE_NAM,PR_AGE,SP_AGE,NR_CHILDRE,MAR_YEAR) VALUES 
 ('Washington G','Curtis M D',26.00000,27.00000,0.00000,1759.00000),
 ('Adams J','Smith A',28.00000,19.00000,5.00000,1764.00000),
 ('Jefferson T','Skelton M W',28.00000,23.00000,6.00000,1772.00000),
 ('Madison J','Todd D D P',43.00000,26.00000,0.00000,1794.00000),
 ('Monroe J','Kortright E',27.00000,17.00000,3.00000,1786.00000),
 ('Adams J Q','Johnson L C',30.00000,22.00000,4.00000,1797.00000),
 ('Jackson A','Robards R D',26.00000,26.00000,0.00000,1794.00000),
 ('Van Buren M','Hoes H',24.00000,23.00000,4.00000,1807.00000),
 ('Harrison W H','Symmes A T',22.00000,20.00000,10.00000,1795.00000),
 ('Tyler J','Christian L',23.00000,22.00000,8.00000,1813.00000),
 ('Tyler J','Gardiner J',54.00000,24.00000,7.00000,1844.00000),
 ('Polk J K','Childress S',28.00000,20.00000,0.00000,1824.00000),
 ('Taylor Z','Smith M M',25.00000,21.00000,6.00000,1810.00000),
 ('Fillmore M','Powers A',26.00000,27.00000,2.00000,1826.00000),
 ('Fillmore M','McIntosh C C',58.00000,44.00000,0.00000,1858.00000),
 ('Pierce F','Appleton J M',29.00000,28.00000,3.00000,1834.00000),
 ('Lincoln A','Todd M',33.00000,23.00000,4.00000,1842.00000),
 ('Johnson A','McCardle E',18.00000,16.00000,5.00000,1827.00000),
 ('Grant U S','Dent J B',26.00000,22.00000,4.00000,1848.00000),
 ('Hayes R B','Webb L W',30.00000,21.00000,8.00000,1852.00000),
 ('Garfield J A','Rudolph L',26.00000,26.00000,7.00000,1858.00000),
 ('Arthur C A','Herndon E L',29.00000,22.00000,3.00000,1859.00000),
 ('Cleveland G','Folson F',49.00000,21.00000,5.00000,1886.00000),
 ('Harrison B','Scott C L',20.00000,21.00000,2.00000,1853.00000),
 ('Harrison B','Dimmick M S L',62.00000,37.00000,1.00000,1896.00000),
 ('McKinley W','Saxton I',27.00000,23.00000,2.00000,1871.00000),
 ('Roosevelt T','Lee A H',22.00000,19.00000,1.00000,1880.00000),
 ('Roosevelt T','Carow E K',28.00000,25.00000,5.00000,1886.00000),
 ('Taft W H','Herron H',28.00000,25.00000,3.00000,1886.00000),
 ('Wilson W','Axson E L',28.00000,25.00000,3.00000,1885.00000),
 ('Wilson W','Galt E B',58.00000,43.00000,0.00000,1915.00000),
 ('Harding W G','De Wolfe F K',25.00000,30.00000,0.00000,1891.00000),
 ('Coolidge C','Goodhue G A',33.00000,26.00000,2.00000,1905.00000),
 ('Hoover H C','Henry L',24.00000,23.00000,2.00000,1899.00000),
 ('Roosevelt F D','Roosevelt A E',23.00000,20.00000,6.00000,1905.00000),
 ('Truman H S','Wallace E V',35.00000,34.00000,1.00000,1919.00000),
 ('Eisenhouwer D D','Doud G',25.00000,19.00000,2.00000,1916.00000),
 ('Kennedy J F','Bouvier J L',36.00000,24.00000,3.00000,1953.00000),
 ('Johnson L B','Taylor C A',26.00000,21.00000,2.00000,1934.00000),
 ('Nixon R M','Ryan T C',27.00000,28.00000,2.00000,1940.00000),
 ('Ford G R','Warren E B',35.00000,30.00000,4.00000,1948.00000),
 ('Carter J E','Smith R',21.00000,18.00000,4.00000,1946.00000),
 ('Reagan R','Wyman J',28.00000,25.00000,2.00000,1940.00000),
 ('Reagan R','Davis N',41.00000,28.00000,2.00000,1952.00000),
 ('Bush G','? Barbara',0.00000,0.00000,0.00000,0.00000),
 ('Clinton B','Rodham H',25.00000,24.00000,1.00000,1971.00000),
 ('Bush G W','Welsh L',31.00000,31.00000,2.00000,1977.00000);

 INSERT INTO presiden (PRES_NAME,BIRTH_YR,YRS_SERV,DEATH_AGE,PARTY,STATE_BORN) VALUES 
 ('Washington G',1732.00000,7.00000,67.00000,'Federalist','Virginia'),
 ('Adams J',1735.00000,4.00000,90.00000,'Federalist','Massachusetts'),
 ('Jefferson T',1743.00000,8.00000,83.00000,'Demo-Rep','Virginia'),
 ('Madison J',1751.00000,8.00000,85.00000,'Demo-Rep','Virginia'),
 ('Monroe J',1758.00000,8.00000,73.00000,'Demo-Rep','Virginia'),
 ('Adams J Q',1767.00000,4.00000,80.00000,'Demo-Rep','Massachusetts'),
 ('Jackson A',1767.00000,8.00000,78.00000,'Democratic','South Carolina'),
 ('Van Buren M',1782.00000,4.00000,79.00000,'Democratic','New York'),
 ('Harrison W H',1773.00000,0.00000,68.00000,'Whig','Virginia'),
 ('Tyler J',1790.00000,3.00000,71.00000,'Whig','Virginia'),
 ('Polk J K',1795.00000,4.00000,53.00000,'Democratic','North Carolina'),
 ('Taylor Z',1784.00000,1.00000,65.00000,'Whig','Virginia'),
 ('Fillmore M',1800.00000,2.00000,74.00000,'Whig','New York'),
 ('Pierce F',1804.00000,4.00000,64.00000,'Democratic','New Hampshire'),
 ('Buchanan J',1791.00000,4.00000,77.00000,'Democratic','Pennsylvania'),
 ('Lincoln A',1809.00000,4.00000,56.00000,'Republican','Kentucky'),
 ('Johnson A',1808.00000,3.00000,66.00000,'Democratic','North Carolina'),
 ('Grant U S',1822.00000,8.00000,63.00000,'Republican','Ohio'),
 ('Hayes R B',1822.00000,4.00000,70.00000,'Republican','Ohio'),
 ('Garfield J A',1831.00000,0.00000,49.00000,'Republican','Ohio'),
 ('Arthur C A',1830.00000,3.00000,56.00000,'Republican','Vermont'),
 ('Cleveland G',1837.00000,8.00000,71.00000,'Democratic','New Jersey'),
 ('Harrison B',1833.00000,4.00000,67.00000,'Republican','Ohio'),
 ('McKinley W',1843.00000,4.00000,58.00000,'Republican','Ohio'),
 ('Roosevelt T',1858.00000,7.00000,60.00000,'Republican','New York'),
 ('Taft W H',1857.00000,4.00000,72.00000,'Republican','Ohio'),
 ('Wilson W',1856.00000,8.00000,67.00000,'Democratic','Virginia'),
 ('Harding W G',1865.00000,2.00000,57.00000,'Republican','Ohio'),
 ('Coolidge C',1872.00000,5.00000,60.00000,'Republican','Vermont'),
 ('Hoover H C',1874.00000,4.00000,90.00000,'Republican','Iowa'),
 ('Roosevelt F D',1882.00000,12.00000,63.00000,'Democratic','New York'),
 ('Truman H S',1884.00000,7.00000,88.00000,'Democratic','Missouri'),
 ('Eisenhouwer D D',1890.00000,8.00000,79.00000,'Republican','Texas'),
 ('Kennedy J F',1917.00000,2.00000,46.00000,'Democratic','Massachusetts'),
 ('Johnson L B',1908.00000,5.00000,65.00000,'Democratic','Texas'),
 ('Nixon R M',1913.00000,5.00000,0.00000,'Republican','California'),
 ('Ford G R',1913.00000,2.00000,0.00000,'Republican','Nebraska'),
 ('Carter J E',1924.00000,4.00000,0.00000,'Democratic','Georgia'),
 ('Reagan R',1911.00000,8.00000,93.00000,'Republican','Illinois'),
 ('Bush G',1924.00000,4.00000,0.00000,'Republican','Texas'),
 ('Clinton B',1946.00000,8.00000,0.00000,'Democratic','Arkansas'),
 ('Bush G W',1946.00000,0.00000,0.00000,'Republican','Texas');

 INSERT INTO state (STATE_NAME,ADMIN_ENTE,YEAR_ENTER) VALUES 
 ('Massachusetts',0.00000,1776.00000),
 ('Pennsylvania',0.00000,1776.00000),
 ('Virginia',0.00000,1776.00000),
 ('Connecticut',0.00000,1776.00000),
 ('South Carolina',0.00000,1776.00000),
 ('Maryland',0.00000,1776.00000),
 ('New Georgia',0.00000,1776.00000),
 ('New Hampshire',0.00000,1776.00000),
 ('Delaware',0.00000,1776.00000),
 ('New York',0.00000,1776.00000),
 ('North Carolina',0.00000,1776.00000),
 ('Rhode Island',0.00000,1776.00000),
 ('Vermont',1.00000,1791.00000),
 ('Kentucky',1.00000,1792.00000),
 ('Tennessee',2.00000,1796.00000),
 ('Ohio',4.00000,1803.00000),
 ('Louisianna',6.00000,1812.00000),
 ('Indiana',7.00000,1816.00000),
 ('Mississippi',8.00000,1817.00000),
 ('Illinois',8.00000,1818.00000),
 ('Alabama',8.00000,1819.00000),
 ('Maine',8.00000,1820.00000),
 ('Missouri',9.00000,1821.00000),
 ('Arkansas',12.00000,1836.00000),
 ('Michigan',12.00000,1837.00000),
 ('Florida',14.00000,1845.00000),
 ('Texas',15.00000,1845.00000),
 ('Iowa',15.00000,1846.00000),
 ('Wisconsin',15.00000,1848.00000),
 ('California',16.00000,1850.00000),
 ('Minnesota',18.00000,1858.00000),
 ('Oregan',18.00000,1859.00000),
 ('Kansas',18.00000,1861.00000),
 ('West Virginia',19.00000,1863.00000),
 ('Nevada',19.00000,1864.00000),
 ('Nebraska',20.00000,1867.00000),
 ('Colorado',22.00000,1876.00000),
 ('North Dakota',26.00000,1889.00000),
 ('South Dakota',26.00000,1889.00000),
 ('Montana',26.00000,1889.00000),
 ('Washington',26.00000,1889.00000),
 ('Idaho',26.00000,1890.00000),
 ('Wyoming',26.00000,1890.00000),
 ('Utah',27.00000,1896.00000),
 ('Oklahoma',30.00000,1907.00000),
 ('New Mexico',31.00000,1912.00000),
 ('Arizona',31.00000,1912.00000),
 ('Alaska',43.00000,1959.00000),
 ('Hawaii',43.00000,1959.00000),
 ('Georgia',14.00000,1845.00000),
 ('New Jersey',26.00000,1890.00000);