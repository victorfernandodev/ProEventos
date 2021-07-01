import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = [];
  public eventsFiltrados: any = [];
  imagemLargura = 150;
  imagemMargem = 2;
  mostrarImagem = true;
  private _filtroLista: string = '';

  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventsFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.events;
  }

  filtrarEventos(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.events.filter(
      (events: any) => events.theme.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      events.locale.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      events.eventDate.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEvents();
  }

  alterarImagem(){
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe(
      response => {
        this.events = response
        this.eventsFiltrados = this.events
      },
      error => console.log(error)
    );
  }
}
