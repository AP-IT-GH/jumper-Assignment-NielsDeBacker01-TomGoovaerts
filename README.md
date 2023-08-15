#Tutorial voor Jumper oefening met agent op kruispunt#
##Installatie##
Unity 2021.3.10f1 met ML Agents 2.0.1 package
ML agents 0.30.0
(Alleen op Windows) PyTorch 1.7.1
(Bij error protobuf) downgrade protobuf naar 3.20.*
##Omgeving##
Maak een loopbaan voor de projectielen en de agent met een muur op het einde om het projectiel te deleten. Daarna maak je ook een gameobject dat projectielen schiet en een projectiel prefab die verdwijnt op collision. Dupliceer dit geheel en draai 1 van de 2 opstellingen 90° en zorg ervoor dat de muren elkaar bijna raken. Plaats in het midden van het kruispunt een agent object en richt de voorkant hiervan in het midden tussen de loopbanen. Zorg dat deze agent kan springen en een ray heeft die de projectielen kan observeren. Omdat de agent op een kruispunt staat zullen er 3 rays nodig zijn. De default die rechtdoor kijkt en 2 die de projectielen zullen observeren, deze staan op 45° van de default ray. Voor beloning krijgt de agent een beloning van +0.1 voor elke update dat de agent niet springt. Om te zorgen dat de agent niet constant wordt een penalty van -1 gegeven als de agent springt. Indien de agent geraakt wordt door een projectiel krijgt deze een penalty van -100 en eindigt de episode daar. De episode eindigt ook na 500 steps. Gebruik dan MLAgents om het model te trainen. De hyperparameters zijn gewoon de standaardwaarden met uitzondering van de batch/buffergrootte en de gamma waarde. Deze zijn 128, 2048 en 0.995 respectievelijk.
##Training resultaten  ##  
![image](https://user-images.githubusercontent.com/113940442/233493789-9091302c-dbc4-44d6-8f1f-25b8aa432eb8.png)  
De "Environment/Cumulative Reward" grafiek toont een stijgende trend in beloningen naarmate het model leert. De grafiek stabiliseert rond 400.000 epochs, wat suggereert dat het model een niveau van expertise heeft bereikt waarop verdere verbetering minder frequent voorkomt. Waarschijnlijk is dit omdat het model geen reden meer heeft om te verbeteren aangezien het tegen dan elke epoch overleeft.  
![image](https://user-images.githubusercontent.com/113940442/233493789-9091302c-dbc4-44d6-8f1f-25b8aa432eb8.png)  
![image](https://user-images.githubusercontent.com/113940442/233493789-9091302c-dbc4-44d6-8f1f-25b8aa432eb8.png)  
Fluctuaties in de “policy loss” kunnen actieve exploratie en leren aanduiden, terwijl een geleidelijke daling van de “value loss” aangeeft dat het netwerk leert en nauwkeurige schattingen geeft. Beide aspecten zijn belangrijk in het reinforcement learning-proces, maar fluctuaties in de policy loss zouden moeten stabiliseren naarmate de agent beter wordt in het nemen van beslissingen.

