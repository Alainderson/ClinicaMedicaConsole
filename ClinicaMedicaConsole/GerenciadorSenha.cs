namespace ClinicaMedicaConsole;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

public static class GerenciadorSenha
{
    // Gera hash com salt
    public static string GerarHash(string senha)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: senha,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: 32));

        return $"{Convert.ToBase64String(salt)}:{hash}";
    }

    // Valida senha comparando com hash armazenado
    public static bool ValidarSenha(string senhaDigitada, string senhaHashArmazenada)
    {
        var partes = senhaHashArmazenada.Split(':');
        byte[] salt = Convert.FromBase64String(partes[0]);
        string hashArmazenado = partes[1];

        string hashDigitado = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: senhaDigitada,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 10000,
            numBytesRequested: 32));

        return hashDigitado == hashArmazenado;
    }
}