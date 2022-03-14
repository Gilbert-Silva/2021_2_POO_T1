from datetime import datetime

class Contato:
  def __init__(self, nome, fone, nascimento):
    self.__Nome = nome
    self.__Fone = fone
    self.__Nasc = datetime.strptime(nascimento, '%d/%m/%Y')
  def __str__(self):
    return self.__Nome + " - " + self.__Fone + " - " + self.__Nasc.strftime("%d/%m/%Y")
    #str(self.Nasc)
  def GetNascimento(self):
    return self.__Nasc

class Agenda:
  def __init__(self):
    self.__lista = []
  def Inserir(self, contato):
    self.__lista.append(contato)
  def Listar(self):
    return self.__lista
  def Aniversariantes(self, mes):
    r = []
    for c in self.__lista:
      if (c.GetNascimento().month == mes): 
        r.append(c)
    return r
  

a = Contato("José", "12345678", "18/09/2019")
b = Contato("João", "87654321", "18/10/2019")
c = Contato("Maria", "88884444", "24/09/2009")
agenda = Agenda()
agenda.Inserir(a)
agenda.Inserir(b)
agenda.Inserir(c)
print("Todos os contatos")
for c in agenda.Listar(): print(c)
print("\nAniversariantes de setembro")
for c in agenda.Aniversariantes(9): print(c)

  
  





