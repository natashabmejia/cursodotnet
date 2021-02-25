import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { Cidade } from '../models/Cidade';
import { CidadeService } from '../Services/Cidade.service';

@Component({
  selector: 'app-cidade',
  templateUrl: './cidade.component.html',
  styleUrls: ['./cidade.component.css']
})
export class CidadeComponent implements OnInit {

  titleCidade = 'Cidades';
  public selectedCidade: Cidade;
  public cidadeForm: FormGroup;

  public cidades: Cidade[];

  selectCidade(cidade: Cidade){
    this.selectedCidade = cidade;
    this.cidadeForm.patchValue(cidade)
  }

  createForm(){
    this.cidadeForm= this.fb.group({
      id:[''],
      nome:['', Validators.required],
      estado:['', Validators.required] 
    })
  }

  back(){
    this.selectedCidade = null;
    this.loadCidade();
  }

  submit(){
    this.saveCidade(this.cidadeForm.value);
    console.log(this.cidadeForm.value);
    
  }

  saveCidade(cidade:Cidade){
    this.CidadeService.edit(cidade).subscribe(
      (retorno:Cidade) => {
        console.log(retorno);
      },
      (error:any) => {
        console.log(error);
      }
    );
  }

  loadCidade(){
    this.CidadeService.getAll().subscribe(
      (cidades:Cidade[]) => {
        this.cidades = cidades;
      },
      (error:any) =>{
        console.log(error);
      }
    );
  }

  deleteCidade(id:number){
    this.CidadeService.delete(id).subscribe(
      (modal:any) =>{
        console.log(modal);
        this.loadCidade();
      },
      (error: any) => {
        console.log(error);
        
      }
    );
}




  constructor(private fb:FormBuilder,private modalService:BsModalService,
    private CidadeService:CidadeService) {
    this.createForm();
   }

  ngOnInit(): void {
    this.loadCidade();
  }

}
