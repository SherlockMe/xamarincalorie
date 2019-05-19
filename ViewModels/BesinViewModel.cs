using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Ornek_2.Models;
using Ornek_2.ViewModels.Base;

namespace Ornek_2.ViewModels
{
    public class BesinViewModel : BaseVM
    {
        private Besin model;

        public Besin Model
        {
            get { return model; }
        }

        public int Id
        {
            get { return model.Id; }
            set
            {
                if(model.Id != value)
                {
                    model.Id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Ad
        {
            get { return model.Ad; }
            set
            {
                if (model.Ad != value)
                {
                    model.Ad = value;
                    OnPropertyChanged();
                }
            }
        }


        public string Ener
        {
            get { return model.Ener; }
            set
            {
                if (model.Ener != value)
                {
                    model.Ener = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Protein
        {
            get { return model.Protein; }
            set
            {
                if (model.Protein != value)
                {
                    model.Protein = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Khidrat
        {
            get { return model.Khidrat; }
            set
            {
                if (model.Khidrat != value)
                {
                    model.Khidrat = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Kalsiyum
        {
            get { return model.Kalsiyum; }
            set
            {
                if (model.Kalsiyum != value)
                {
                    model.Kalsiyum = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Demir
        {
            get { return model.Demir; }
            set
            {
                if (model.Demir != value)
                {
                    model.Demir = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Aciklama
        {
            get { return model.Aciklama; }
            set
            {
                if (model.Aciklama != value)
                {
                    model.Aciklama = value;
                    OnPropertyChanged();
                }
            }
        }

        public BesinViewModel():this(new Besin()) { }
        public BesinViewModel(Besin model)
        {
            this.model = model;
        }

        public BesinViewModel Copy()
        {
            return new BesinViewModel
            {
                Id = model.Id,
                Ad = model.Ad,
                Aciklama = model.Aciklama,
                Ener = model.Ener,
                Protein=model.Protein,
                Khidrat=model.Khidrat,
                Kalsiyum=model.Kalsiyum,
                Demir=model.Demir
            };
        }
    }
}
