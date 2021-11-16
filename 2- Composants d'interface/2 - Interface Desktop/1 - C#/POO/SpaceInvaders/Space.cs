using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public List<List<Invaders>> Grille { get; set; } = new();
        public int PositionCanon { get; set; }
        public int Score { get; set; } = 0;

        public Space(int nbLignes, int nbColonnes)
        {
            this.NbLignes = nbLignes;
            this.NbColonnes = nbColonnes;
            this.PositionCanon = this.NbColonnes / 2;
            this.InitGrille();         
        }

        public void InitGrille()
        {
            List<Invaders> l = new();
            //Init de la 1ere ligne de jeu
            for (int j = 0; j < this.NbColonnes; j++)
            {
                l.Add(new Invaders());
            }
            this.Grille.Add(l);
            //Init des cases vides de jeu
            for (int i=1;i<this.NbLignes;i++)
            {
                l = new List<Invaders>();
                for (int j=0;j<this.NbColonnes;j++)
                {
                    l.Add(new Invaders(" "));
                }
                this.Grille.Add(l);
            }
            this.Grille[NbLignes - 1][this.PositionCanon].Motif="§";
        }

        public override string ToString()
        {
            string grille = "┌";
            for (int i = 0; i < this.NbColonnes; i++)
            {
                grille += "─";
            }
            grille += "┐\n";
            foreach (var elm in this.Grille)
            {
                grille += "|";
                foreach (var elm2 in elm)
                {
                    grille += elm2.ToString();
                }
                grille += "|\n";
            }
            grille += "└";
            for (int i = 0; i < this.NbColonnes; i++)
            {
                grille += "─";
            }
            grille += "┘";

            grille += "\n\nScore : "+this.Score;
            return grille;
        }

        public void Tirer()
        {
            for (int i=this.NbLignes-3; i>=0;i--) // this.NbLignes-3 car en this.NbLignes-2 c'est la ligne du canon
            {

                if (this.Grille[i][this.PositionCanon].Motif =="#")
                {
                    this.Score += 10;
                }
                this.Grille[i][this.PositionCanon].Motif="^";
                if (i< this.NbLignes - 1)
                {
                    this.Grille[i+1][this.PositionCanon].Motif = " ";
                }
                Console.Clear();
                Console.WriteLine(this.ToString());
                Thread.Sleep(1000);
            }
            this.Grille[0][this.PositionCanon].Motif = " ";
            Console.Clear();
            Console.WriteLine(this.ToString());
        }

        public void AllerAGauche()
        {
            Console.Clear();
            if (this.PositionCanon>0)
            {
                this.Grille[NbLignes - 1][this.PositionCanon].Motif = " ";
                this.PositionCanon -= 1;
                this.Grille[NbLignes - 1][this.PositionCanon].Motif = "§";
            }
            Console.WriteLine(this);
        }

        public void AllerADroite()
        {
            Console.Clear();
            if (this.PositionCanon < this.NbColonnes-1)
            {
                this.Grille[NbLignes - 1][this.PositionCanon].Motif = " ";
                this.PositionCanon += 1;
                this.Grille[NbLignes - 1][this.PositionCanon].Motif = "§";
            }
            Console.WriteLine(this);
        }
    }
}
