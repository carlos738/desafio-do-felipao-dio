public class Heroi {
    public static void main(String[] args) {
        String nome = "Arthas";
        int xp = 7500;
        String nivel = " ";

        switch (xp) {
            case int n when n < 1000 -> nivel = "Ferro";
            case int n when n <= 2000 -> nivel = "Bronze";
            case int n when n <= 5000 -> nivel = "Prata";
            case int n when n <= 7000 -> nivel = "Ouro";
            case int n when n <= 8000 -> nivel = "Platina";
            case int n when n <= 9000 -> nivel = "Ascendente";
            case int n when n <= 10000 -> nivel = "Imortal";
            default -> nivel = "Radiante";

        }
        System.out.println("O Herói de nome" + nome + " está no nível de " + nivel);
    }
}
