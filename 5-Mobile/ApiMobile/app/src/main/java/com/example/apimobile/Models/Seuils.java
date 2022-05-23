package com.example.apimobile.Models;

import java.util.Date;

public class Seuils {
    private Integer IdSeuil;
    private Double SeuilBas;
    private Double SeuilHaut;
    private Date DateSeuil;
    private Integer Temps;
    private Integer Nature;

    public Seuils(){

    }

    public Seuils(Integer IdSeuil,Double SeuilBas,Double SeuilHaut,Date DateSeuil,Integer Temps,Integer Nature){
        this.IdSeuil=IdSeuil;
        this.SeuilBas=SeuilBas;
        this.SeuilHaut=SeuilHaut;
        this.DateSeuil=DateSeuil;
        this.Temps=Temps;
        this.Nature=Nature;
    }

    public Integer getIdSeuil() {
        return IdSeuil;
    }

    public void setIdSeuil(Integer idSeuil) {
        IdSeuil = idSeuil;
    }

    public Double getSeuilBas() {
        return SeuilBas;
    }

    public void setSeuilBas(Double seuilBas) {
        SeuilBas = seuilBas;
    }

    public Double getSeuilHaut() {
        return SeuilHaut;
    }

    public void setSeuilHaut(Double seuilHaut) {
        SeuilHaut = seuilHaut;
    }

    public Date getDateSeuil() {
        return DateSeuil;
    }

    public void setDateSeuil(Date dateSeuil) {
        DateSeuil = dateSeuil;
    }

    public Integer getTemps() {
        return Temps;
    }

    public void setTemps(Integer temps) {
        Temps = temps;
    }

    public Integer getNature() {
        return Nature;
    }

    public void setNature(Integer nature) {
        Nature = nature;
    }
}
