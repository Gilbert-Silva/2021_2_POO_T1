class Pessoa:
  def __init__ (self, nome):
    self.__Nome = nome
  def __str__ (self):
    return self.__Nome
  def SetNome(self, nome):
    self.__Nome = nome
  def GetNome(self):
    return self.__Nome
 
class Aluno(Pessoa):
  def __init__ (self, nome, curso):
    super().__init__(nome)
    self.__Curso = curso
  def __str__ (self):
    return super().__str__() + " - " + self.__Curso
  def SetCurso(self, curso):
    self.__Curso = curso
  def GetCurso(self):
    return self.__Curso

class Professor(Pessoa):
  def __init__ (self, nome, diretoria):
    super().__init__(nome)
    self.__Diretoria = diretoria
  def __str__ (self):
    return super().__str__() + " - " + self.__Diretoria
  def SetDiretoria(self, diretoria):
    self.__Diretoria = diretoria
  def GetDiretoria(self):
    return self.__Diretoria


x = Aluno("Alcides", "TADS")
y = Aluno("Dina", "TADS")

print(x.GetNome())
print(x.GetCurso())
print(y.GetNome())
print(y.GetCurso())

a = Professor("Jorgiano", "Diatinf")
b = Professor("Eduardo", "Diatinf")

print(a.GetNome())
print(a.GetDiretoria())
print(b.GetNome())
print(b.GetDiretoria())
