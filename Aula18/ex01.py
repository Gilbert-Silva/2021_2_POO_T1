class Aluno:
  def __init__ (self, nome, curso):
    self.__Nome = nome
    self.__Curso = curso
  def __str__ (self):
    return self.__Nome + " - " + self.__Curso
  def SetNome(self, nome):
    self.__Nome = nome
  def GetNome(self):
    return self.__Nome
  def SetCurso(self, curso):
    self.__Curso = curso
  def GetCurso(self):
    return self.__Curso

x = Aluno("Alcides", "TADS")
y = Aluno("Dina", "TADS")

print(x)
print(y)

print(x.GetNome())
print(x.GetCurso())
print(y.GetNome())
print(y.GetCurso())

x.Diretoria = "Diatinf"
print(x.Diretoria)



