import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { disableDebugTools } from '@angular/platform-browser';
import { BsModalService } from 'ngx-bootstrap/modal';
import { Medico } from '../models/Medico';
import {MedicoService} from '../services/Medico.service';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

 titleMedico = 'Médicos'

 public selectedMedico: Medico;
 public medicoForm: FormGroup;
 

 public medicos: Medico[]; 
  
  
  selectMedico(medico: Medico){
    this.selectedMedico = medico;
    this.medicoForm.patchValue(medico)
    
  
  }

  createForm(){
    this.medicoForm= this.fb.group({
      id:[''],
      nome:['',Validators.required],
      especialidade:[''],
      crm:['',Validators.required],
      telefone:['',Validators.required]
    })
  }

  back(){
    this.selectedMedico = null;
    this.loadMedico();
  
  }

  submit(){
    this.saveMedico(this.medicoForm.value);
    
    
  }

  saveMedico(medico:Medico){
    this.MedicoService.edit(medico).subscribe(
      (retorno:Medico) => {
        console.log(retorno);
      },
      (error:any) => {
        console.log(error);
      }
    );
  }

  loadMedico(){
    this.MedicoService.getAll().subscribe(
      (medicos:Medico[]) => {
        this.medicos = medicos;
      }, 
      (error:any) =>{
        console.log(error);
      }
    );
  }

  deleteMedico(id:number){
      this.MedicoService.delete(id).subscribe(
        (modal:any) =>{
          console.log(modal);
          this.loadMedico();
        },
        (error: any) => {
          console.log(error);
          
        }
      );
  }

  constructor(private fb:FormBuilder,private modalService:BsModalService, 
    private MedicoService:MedicoService) {
    this.createForm();
   }

  ngOnInit(): void {
    this.loadMedico();
 }

}




